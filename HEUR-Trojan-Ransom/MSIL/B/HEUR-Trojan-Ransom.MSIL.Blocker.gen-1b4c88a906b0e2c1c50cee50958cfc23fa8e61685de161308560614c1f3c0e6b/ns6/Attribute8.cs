using System;
using ns1;
using ns10;
using ns11;
using ns13;
using ns18;

namespace ns6;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
internal sealed class Attribute8 : Attribute5
{
	internal Enum9 enum9_0;

	internal Enum11? nullable_4;

	internal Enum16? nullable_5;

	internal Enum12? nullable_6;

	public Enum9 MemberSerialization
	{
		get
		{
			return enum9_0;
		}
		set
		{
			enum9_0 = value;
		}
	}

	public Enum11 MissingMemberHandling
	{
		get
		{
			return nullable_4.GetValueOrDefault();
		}
		set
		{
			nullable_4 = value;
		}
	}

	public Enum12 ItemNullValueHandling
	{
		get
		{
			return nullable_6.GetValueOrDefault();
		}
		set
		{
			nullable_6 = value;
		}
	}

	public Enum16 ItemRequired
	{
		get
		{
			return nullable_5.GetValueOrDefault();
		}
		set
		{
			nullable_5 = value;
		}
	}

	public Attribute8()
	{
	}

	public Attribute8(Enum9 enum9_1)
	{
		enum9_0 = enum9_1;
	}

	public Attribute8(string string_3)
		: base(string_3)
	{
	}
}
