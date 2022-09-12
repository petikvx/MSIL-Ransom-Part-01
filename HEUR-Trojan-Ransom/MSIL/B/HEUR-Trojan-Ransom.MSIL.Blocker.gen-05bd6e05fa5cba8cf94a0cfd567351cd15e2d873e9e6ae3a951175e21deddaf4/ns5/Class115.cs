using System.Runtime.CompilerServices;

namespace ns5;

internal abstract class Class115
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	public bool ProcessDictionaryKeys
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool ProcessExtensionDataNames
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool OverrideSpecifiedNames
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public virtual string vmethod_0(string string_0, bool bool_3)
	{
		if (bool_3 && !OverrideSpecifiedNames)
		{
			return string_0;
		}
		return vmethod_3(string_0);
	}

	public virtual string vmethod_1(string string_0)
	{
		if (!ProcessExtensionDataNames)
		{
			return string_0;
		}
		return vmethod_3(string_0);
	}

	public virtual string vmethod_2(string string_0)
	{
		if (!ProcessDictionaryKeys)
		{
			return string_0;
		}
		return vmethod_3(string_0);
	}

	protected abstract string vmethod_3(string string_0);

	public override int GetHashCode()
	{
		return (((((GetType().GetHashCode() * 397) ^ ProcessDictionaryKeys.GetHashCode()) * 397) ^ ProcessExtensionDataNames.GetHashCode()) * 397) ^ OverrideSpecifiedNames.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return method_0(obj as Class115);
	}

	protected bool method_0(Class115? class115_0)
	{
		if (class115_0 == null)
		{
			return false;
		}
		if (GetType() == class115_0!.GetType() && ProcessDictionaryKeys == class115_0!.ProcessDictionaryKeys && ProcessExtensionDataNames == class115_0!.ProcessExtensionDataNames)
		{
			return OverrideSpecifiedNames == class115_0!.OverrideSpecifiedNames;
		}
		return false;
	}
}
