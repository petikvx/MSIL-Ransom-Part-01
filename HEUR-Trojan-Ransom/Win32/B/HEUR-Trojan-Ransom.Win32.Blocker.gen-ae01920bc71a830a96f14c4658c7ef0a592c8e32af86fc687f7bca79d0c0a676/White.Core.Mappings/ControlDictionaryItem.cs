using System;
using System.Windows.Automation;

namespace White.Core.Mappings;

public class ControlDictionaryItem
{
	private readonly Type testControlType;

	private readonly ControlType controlType;

	private readonly string className;

	private readonly bool identifiedByClassName;

	private readonly bool isPrimary;

	private readonly bool isExcluded;

	private readonly string frameworkId;

	private readonly bool hasPrimaryChildren;

	public virtual bool IsPrimary => isPrimary;

	public virtual Type TestControlType => testControlType;

	public virtual string FrameworkId => frameworkId;

	public virtual ControlType ControlType => controlType;

	public virtual string ClassName => className;

	public virtual bool IsExcluded => isExcluded;

	public virtual bool IsIdentifiedByClassName => identifiedByClassName;

	public virtual bool HasPrimaryChildren => hasPrimaryChildren;

	public virtual bool IsIdentifiedByName { get; set; }

	public ControlDictionaryItem(Type testControlType, ControlType controlType, string className, bool identifiedByClassName, bool isPrimary, bool isExcluded, string frameworkId, bool hasPrimaryChildren)
	{
		this.testControlType = testControlType;
		this.controlType = controlType;
		this.className = className;
		this.identifiedByClassName = identifiedByClassName;
		this.isPrimary = isPrimary;
		this.isExcluded = isExcluded;
		this.frameworkId = frameworkId;
		this.hasPrimaryChildren = hasPrimaryChildren;
	}

	public static ControlDictionaryItem Primary(Type testControlType, ControlType controlType)
	{
		return new ControlDictionaryItem(testControlType, controlType, string.Empty, identifiedByClassName: false, isPrimary: true, isExcluded: false, null, hasPrimaryChildren: false);
	}

	public static ControlDictionaryItem Primary(Type testControlType, ControlType controlType, bool hasPrimaryChildren)
	{
		return new ControlDictionaryItem(testControlType, controlType, string.Empty, identifiedByClassName: false, isPrimary: true, isExcluded: false, null, hasPrimaryChildren);
	}

	private static ControlDictionaryItem Primary(Type testControlType, ControlType controlType, string frameworkId)
	{
		return new ControlDictionaryItem(testControlType, controlType, string.Empty, identifiedByClassName: false, isPrimary: true, isExcluded: false, frameworkId, hasPrimaryChildren: false);
	}

	public static ControlDictionaryItem WinFormPrimary(Type testControlType, ControlType controlType)
	{
		return Primary(testControlType, controlType, "WinForm");
	}

	public static ControlDictionaryItem WPFPrimary(Type testControlType, ControlType controlType)
	{
		return Primary(testControlType, controlType, "WPF");
	}

	public static ControlDictionaryItem Win32Primary(Type testControlType, ControlType controlType)
	{
		return Primary(testControlType, controlType, "Win32");
	}

	public static ControlDictionaryItem SilverlightPrimary(Type testControlType, ControlType controlType)
	{
		return Primary(testControlType, controlType, "Silverlight");
	}

	private static ControlDictionaryItem Secondary(Type testControlType, ControlType controlType, string frameworkId)
	{
		return new ControlDictionaryItem(testControlType, controlType, string.Empty, identifiedByClassName: false, isPrimary: false, isExcluded: false, frameworkId, hasPrimaryChildren: false);
	}

	public static ControlDictionaryItem Secondary(Type testControlType, ControlType controlType)
	{
		return new ControlDictionaryItem(testControlType, controlType, string.Empty, identifiedByClassName: false, isPrimary: false, isExcluded: false, null, hasPrimaryChildren: false);
	}

	public static ControlDictionaryItem Secondary(Type testControlType, ControlType controlType, bool hasPrimaryChildren)
	{
		return new ControlDictionaryItem(testControlType, controlType, string.Empty, identifiedByClassName: false, isPrimary: false, isExcluded: false, null, hasPrimaryChildren);
	}

	public static ControlDictionaryItem WinFormSecondary(Type testControlType, ControlType controlType)
	{
		return Secondary(testControlType, controlType, "WinForm");
	}

	public static ControlDictionaryItem Win32Secondary(Type testControlType, ControlType controlType)
	{
		return Secondary(testControlType, controlType, "Win32");
	}

	public static ControlDictionaryItem WPFSecondary(Type testControlType, ControlType controlType)
	{
		return Secondary(testControlType, controlType, "WPF");
	}

	public static ControlDictionaryItem SilverlightSecondary(Type testControlType, ControlType controlType)
	{
		return Secondary(testControlType, controlType, "Silverlight");
	}

	public virtual bool OfFramework(string id)
	{
		if (!string.IsNullOrEmpty(id))
		{
			return id.Equals(id);
		}
		return true;
	}

	public override string ToString()
	{
		return $"TestControlType: {testControlType.Name}, ControlType: {controlType.get_LocalizedControlType()}, ClassName: {className}, IdentifiedByClassName: {identifiedByClassName}, IsPrimary: {isPrimary}, IsExcluded: {isExcluded}, FrameworkId: {frameworkId}, HasPrimaryChildren: {hasPrimaryChildren}, IsIdentifiedByName: {IsIdentifiedByName}";
	}
}
