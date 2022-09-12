using System;
using System.Runtime.CompilerServices;
using ns1;
using ns10;
using ns12;

namespace ns3;

internal class Class142 : Class138
{
	[CompilerGenerated]
	private Delegate7<object>? delegate7_0;

	public Delegate7<object>? ISerializableCreator
	{
		[CompilerGenerated]
		get
		{
			return delegate7_0;
		}
		[CompilerGenerated]
		set
		{
			delegate7_0 = value;
		}
	}

	public Class142(Type type_3)
		: base(type_3)
	{
		enum26_0 = Enum26.const_7;
	}
}
