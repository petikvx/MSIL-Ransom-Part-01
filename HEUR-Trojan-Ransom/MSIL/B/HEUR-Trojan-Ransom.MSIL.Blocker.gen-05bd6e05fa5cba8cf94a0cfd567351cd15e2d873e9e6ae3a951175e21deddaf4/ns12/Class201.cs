using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using ns0;
using ns18;

namespace ns12;

internal class Class201 : Class198
{
	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private int? nullable_1;

	[CompilerGenerated]
	private int? nullable_2;

	public int? Start
	{
		[CompilerGenerated]
		get
		{
			return nullable_0;
		}
		[CompilerGenerated]
		set
		{
			nullable_0 = value;
		}
	}

	public int? End
	{
		[CompilerGenerated]
		get
		{
			return nullable_1;
		}
		[CompilerGenerated]
		set
		{
			nullable_1 = value;
		}
	}

	public int? Step
	{
		[CompilerGenerated]
		get
		{
			return nullable_2;
		}
		[CompilerGenerated]
		set
		{
			nullable_2 = value;
		}
	}

	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, Class195? class195_0)
	{
		//yield-return decompiler failed: Method not found
		return new Class209(-2)
		{
			class201_0 = this,
			ienumerable_1 = ienumerable_0,
			class195_1 = class195_0
		};
	}
}
