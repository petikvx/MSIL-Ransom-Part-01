using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
internal sealed class Attribute1 : Attribute
{
	private bool applyToMembers;

	private bool exclude;

	private bool strip;

	private string feature;

	[SpecialName]
	public bool method_0()
	{
		return true;
	}

	[SpecialName]
	public void method_1(bool bool_0)
	{
	}

	[SpecialName]
	public bool method_2()
	{
		return true;
	}

	[SpecialName]
	public void method_3(bool bool_0)
	{
	}

	[SpecialName]
	public string method_4()
	{
		return null;
	}

	[SpecialName]
	public void method_5(string string_0)
	{
	}

	[SpecialName]
	public bool method_6()
	{
		return true;
	}

	[SpecialName]
	public void method_7(bool bool_0)
	{
	}

	static Attribute1()
	{
		Class0.smethod_13();
	}
}
