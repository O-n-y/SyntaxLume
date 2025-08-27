using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

#pragma warning disable CS0649

namespace Ony.SyntaxLume;

internal static class ClassificationTypes
{
	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - public")]
	internal static ClassificationTypeDefinition PublicModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - private")]
	internal static ClassificationTypeDefinition PrivateModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - internal")]
	internal static ClassificationTypeDefinition InternalModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - protected")]
	internal static ClassificationTypeDefinition ProtectedModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - virtual")]
	internal static ClassificationTypeDefinition VirtualModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - abstract")]
	internal static ClassificationTypeDefinition AbstractModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - sealed")]
	internal static ClassificationTypeDefinition SealedModifierType = null;
	
	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - override")]
	internal static ClassificationTypeDefinition OverrideModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - static")]
	internal static ClassificationTypeDefinition StaticModifierType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - if")]
    internal static ClassificationTypeDefinition ControlFlowIfType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - else")]
    internal static ClassificationTypeDefinition ControlFlowElseType = null;


    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - while")]
    internal static ClassificationTypeDefinition ControlFlowWhileType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - do")]
    internal static ClassificationTypeDefinition ControlFlowDoType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - switch")]
    internal static ClassificationTypeDefinition ControlFlowSwitchType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - break")]
    internal static ClassificationTypeDefinition ControlFlowBreakType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - continue")]
    internal static ClassificationTypeDefinition ControlFlowContinueType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - for")]
    internal static ClassificationTypeDefinition ControlFlowForType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - foreach")]
    internal static ClassificationTypeDefinition ControlFlowForeachType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - return")]
    internal static ClassificationTypeDefinition ControlFlowReturnType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - goto")]
    internal static ClassificationTypeDefinition ControlFlowGotoType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - throw")]
    internal static ClassificationTypeDefinition ControlFlowThrowType = null;

    [Export(typeof(ClassificationTypeDefinition))]
    [Name("control flow - yield")]
    internal static ClassificationTypeDefinition ControlFlowYieldType = null;
}