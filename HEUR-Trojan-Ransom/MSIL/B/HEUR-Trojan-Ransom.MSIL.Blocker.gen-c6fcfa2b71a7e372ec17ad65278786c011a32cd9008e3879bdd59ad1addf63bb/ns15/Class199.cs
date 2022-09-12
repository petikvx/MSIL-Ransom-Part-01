using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using ns0;
using ns18;

namespace ns15;

internal class Class199 : Class198
{
	[CompilerGenerated]
	private int? nullable_0;

	public int? Index
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

	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, Class195? class195_0)
	{
		//yield-return decompiler failed: Method not found
		return new Class197(-2)
		{
			class199_0 = this,
			ienumerable_1 = ienumerable_0,
			class195_1 = class195_0
		};
	}
}
