using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Tagging;

namespace Ony.SyntaxLume
{
	public class Tagger : ITagger<ClassificationTag>
	{
		public event EventHandler<SnapshotSpanEventArgs> TagsChanged;

		private readonly Dictionary<string, IClassificationType> _modifierMap;
		private static Regex _lineStartRegex;

		public Tagger(ITextBuffer buffer, IClassificationTypeRegistryService registry, IClassifier classifier)
		{
			_modifierMap = new Dictionary<string, IClassificationType>(StringComparer.OrdinalIgnoreCase)
			{
				["public"] = registry.GetClassificationType("access modifier - public"),
				["private"] = registry.GetClassificationType("access modifier - private"),
				["protected"] = registry.GetClassificationType("access modifier - protected"),
				["internal"] = registry.GetClassificationType("access modifier - internal"),
				["virtual"] = registry.GetClassificationType("modifier - virtual"),
				["abstract"] = registry.GetClassificationType("modifier - abstract"),
				["sealed"] = registry.GetClassificationType("modifier - sealed"),
				["override"] = registry.GetClassificationType("modifier - override"),
				["static"] = registry.GetClassificationType("modifier - static"),
                ["if"] = registry.GetClassificationType("control flow - if"),
                ["else"] = registry.GetClassificationType("control flow - else"),
                ["while"] = registry.GetClassificationType("control flow - while"),
                ["do"] = registry.GetClassificationType("control flow - do"),
                ["for"] = registry.GetClassificationType("control flow - for"),
                ["foreach"] = registry.GetClassificationType("control flow - foreach"),
                ["switch"] = registry.GetClassificationType("control flow - switch"),
                ["break"] = registry.GetClassificationType("control flow - break"),
                ["continue"] = registry.GetClassificationType("control flow - continue"),
                ["return"] = registry.GetClassificationType("control flow - return"),
                ["goto"] = registry.GetClassificationType("control flow - goto"),
                ["throw"] = registry.GetClassificationType("control flow - throw"),
                ["yield"] = registry.GetClassificationType("control flow - yield"),
			};
			_lineStartRegex = new Regex($@"^\s*({string.Join("|", _modifierMap.Keys)}|\[)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

		public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans)
		{
			if (spans.Count == 0)
				yield break;
			foreach (var span in spans)
			{
				var startLine = span.Snapshot.GetLineFromPosition(span.Start);
				var endLine = span.Snapshot.GetLineFromPosition(span.End);

				for (var i = startLine.LineNumber; i <= endLine.LineNumber; i++)
				{
					var line = span.Snapshot.GetLineFromLineNumber(i);
					var lineText = line.GetText();

					if (!_lineStartRegex.IsMatch(lineText))
						continue;

					foreach (var keyword in _modifierMap.Keys)
					{
						var pos = 0;
						while ((pos = lineText.IndexOf(keyword, pos, StringComparison.OrdinalIgnoreCase)) >= 0)
						{
							var validStart = pos == 0 || !char.IsLetterOrDigit(lineText[pos - 1]);
							var validEnd = pos + keyword.Length >= lineText.Length ||
										   !char.IsLetterOrDigit(lineText[pos + keyword.Length]);

							if (validStart && validEnd)
							{
								var keywordSpan = new SnapshotSpan(span.Snapshot, line.Start + pos, keyword.Length);

								if (span.Contains(keywordSpan) || span.OverlapsWith(keywordSpan))
								{
									if (IsInDeclarationContext(keywordSpan))
									{
										yield return new TagSpan<ClassificationTag>(
												keywordSpan,
												new ClassificationTag(_modifierMap[keyword]));
									}
								}
							}

							pos += keyword.Length;
						}
					}
				}
			}
		}

		private bool IsInDeclarationContext(SnapshotSpan keywordSpan)
		{
			var line = keywordSpan.Snapshot.GetLineFromPosition(keywordSpan.Start);
			var lineText = line.GetText();
			var keyword = keywordSpan.GetText();
			var keywordPosition = keywordSpan.Start - line.Start;

			if (lineText.Substring(0, keywordPosition).Contains("//") || lineText.Contains("/*") && lineText.Contains("*/"))
				return false;

			var textBeforeKeyword = lineText.Substring(0, keywordPosition).Trim();
			var textAfterKeyword = lineText.Substring(keywordPosition + keyword.Length).Trim();

			return (string.IsNullOrWhiteSpace(textBeforeKeyword) || textBeforeKeyword.EndsWith("]") || _modifierMap.Keys.Any(mod => textBeforeKeyword.EndsWith(mod, StringComparison.OrdinalIgnoreCase))) && !textAfterKeyword.StartsWith("=") && !textAfterKeyword.StartsWith("==");
		}
	}
}