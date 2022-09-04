using System;
using System.Runtime.InteropServices;

[Attribute1(Exclude = true, ApplyToMembers = true, StripAfterObfuscation = true)]
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
internal sealed class Attribute1 : Attribute
{
	private bool applyToMembers = true;

	private bool exclude = true;

	private bool strip = true;

	public bool ApplyToMembers
	{
		get
		{
			return applyToMembers;
		}
		set
		{
			applyToMembers = value;
		}
	}

	public bool Exclude
	{
		get
		{
			return exclude;
		}
		set
		{
			exclude = value;
		}
	}

	public bool StripAfterObfuscation
	{
		get
		{
			return strip;
		}
		set
		{
			strip = value;
		}
	}
}
