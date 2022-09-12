using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using ns1;
using ns14;
using ns8;

namespace ns17;

internal class Class214 : Class213
{
	[CompilerGenerated]
	private List<Class213> list_0;

	public List<Class213> Expressions
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public Class214(Enum33 enum33_1)
		: base(enum33_1)
	{
		Expressions = new List<Class213>();
	}

	public override bool vmethod_0(JToken jtoken_0, JToken jtoken_1, Class195? class195_0)
	{
		switch (enum33_0)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case Enum33.const_9:
			foreach (Class213 expression in Expressions)
			{
				if (expression.vmethod_0(jtoken_0, jtoken_1, class195_0))
				{
					return true;
				}
			}
			return false;
		case Enum33.const_8:
			foreach (Class213 expression2 in Expressions)
			{
				if (!expression2.vmethod_0(jtoken_0, jtoken_1, class195_0))
				{
					return false;
				}
			}
			return true;
		}
	}
}
