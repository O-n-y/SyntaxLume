using Microsoft.VisualStudio.Text.Classification;
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Utilities;

namespace Ony.SyntaxLume;

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - public")]
[Name("Public Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class PublicModifierFormat : ClassificationFormatDefinition
{
    public PublicModifierFormat()
    {
        DisplayName = "C# Access Modifier - Public";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - private")]
[Name("Private Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class PrivateModifierFormat : ClassificationFormatDefinition
{
    public PrivateModifierFormat()
    {
        DisplayName = "C# Access Modifier - Private";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - internal")]
[Name("Internal Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class InternalModifierFormat : ClassificationFormatDefinition
{
    public InternalModifierFormat()
    {
        DisplayName = "C# Access Modifier - Internal";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - protected")]
[Name("Protected Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ProtectedModifierFormat : ClassificationFormatDefinition
{
    public ProtectedModifierFormat()
    {
        DisplayName = "C# Access Modifier - Protected";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - virtual")]
[Name("Virtual Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class VirtualModifierFormat : ClassificationFormatDefinition
{
    public VirtualModifierFormat()
    {
        DisplayName = "C# Modifier - Virtual";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - abstract")]
[Name("Abstract Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class AbstractModifierFormat : ClassificationFormatDefinition
{
    public AbstractModifierFormat()
    {
        DisplayName = "C# Modifier - Abstract";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - sealed")]
[Name("Sealed Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class SealedModifierFormat : ClassificationFormatDefinition
{
	public SealedModifierFormat()
	{
		DisplayName = "C# Modifier - Sealed";
		ForegroundColor = Colors.DarkGray;
	}
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - override")]
[Name("Override Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class OverrideModifierFormat : ClassificationFormatDefinition
{
	public OverrideModifierFormat()
	{
		DisplayName = "C# Modifier - Override";
		ForegroundColor = Colors.Gray;
	}
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - static")]
[Name("Static Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class StaticModifierFormat : ClassificationFormatDefinition
{
	public StaticModifierFormat()
	{
		DisplayName = "C# Modifier - Static";
		ForegroundColor = Colors.Gray;
	}
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - if")]
[Name("Control Flow If Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowIfFormat : ClassificationFormatDefinition
{
    public ControlFlowIfFormat()
    {
        DisplayName = "C# Control Flow - if";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - else")]
[Name("Control Flow Else Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowElseFormat : ClassificationFormatDefinition
{
    public ControlFlowElseFormat()
    {
        DisplayName = "C# Control Flow - else";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - while")]
[Name("Control Flow While Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowWhileFormat : ClassificationFormatDefinition
{
    public ControlFlowWhileFormat()
    {
        DisplayName = "C# Control Flow - while";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - do")]
[Name("Control Flow Do Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowDoFormat : ClassificationFormatDefinition
{
    public ControlFlowDoFormat()
    {
        DisplayName = "C# Control Flow - do";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - for")]
[Name("Control Flow For Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowForFormat : ClassificationFormatDefinition
{
    public ControlFlowForFormat()
    {
        DisplayName = "C# Control Flow - for";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - foreach")]
[Name("Control Flow Foreach Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowForeachFormat : ClassificationFormatDefinition
{
    public ControlFlowForeachFormat()
    {
        DisplayName = "C# Control Flow - foreach";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - switch")]
[Name("Control Flow Switch Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowSwitchFormat : ClassificationFormatDefinition
{
    public ControlFlowSwitchFormat()
    {
        DisplayName = "C# Control Flow - switch";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - break")]
[Name("Control Flow Break Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowBreakFormat : ClassificationFormatDefinition
{
    public ControlFlowBreakFormat()
    {
        DisplayName = "C# Control Flow - break";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - continue")]
[Name("Control Flow Continue Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowContinueFormat : ClassificationFormatDefinition
{
    public ControlFlowContinueFormat()
    {
        DisplayName = "C# Control Flow - continue";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - return")]
[Name("Control Flow Return Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowReturnFormat : ClassificationFormatDefinition
{
    public ControlFlowReturnFormat()
    {
        DisplayName = "C# Control Flow - return";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - goto")]
[Name("Control Flow Goto Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowGotoFormat : ClassificationFormatDefinition
{
    public ControlFlowGotoFormat()
    {
        DisplayName = "C# Control Flow - goto";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - throw")]
[Name("Control Flow Throw Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowThrowFormat : ClassificationFormatDefinition
{
    public ControlFlowThrowFormat()
    {
        DisplayName = "C# Control Flow - throw";
        ForegroundColor = Colors.OrangeRed;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "control flow - yield")]
[Name("Control Flow Yield Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ControlFlowYieldFormat : ClassificationFormatDefinition
{
    public ControlFlowYieldFormat()
    {
        DisplayName = "C# Control Flow - yield";
        ForegroundColor = Colors.OrangeRed;
    }
}
