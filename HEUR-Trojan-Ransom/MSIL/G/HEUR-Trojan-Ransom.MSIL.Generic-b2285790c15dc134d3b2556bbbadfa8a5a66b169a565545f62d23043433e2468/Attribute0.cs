using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
[Attribute0(Exclude = true, ApplyToMembers = true, StripAfterObfuscation = true)]
internal sealed class Attribute0 : Attribute
{
	private bool bool_0 = true;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private string string_0 = "";

	public bool ApplyToMembers
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool Exclude
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public string Feature
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public bool StripAfterObfuscation
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}
}
