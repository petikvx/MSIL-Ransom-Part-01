using System;
using ns11;

namespace ns12;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
internal sealed class Attribute6 : Attribute5
{
	internal bool bool_0;

	public bool AllowNullItems
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

	public Attribute6()
	{
	}

	public Attribute6(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public Attribute6(string string_3)
		: base(string_3)
	{
	}
}
