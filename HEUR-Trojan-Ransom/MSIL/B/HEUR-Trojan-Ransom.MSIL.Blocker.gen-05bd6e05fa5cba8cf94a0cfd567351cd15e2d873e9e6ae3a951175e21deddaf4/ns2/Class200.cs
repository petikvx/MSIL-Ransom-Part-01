using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using ns0;
using ns18;

namespace ns2;

internal class Class200 : Class198
{
	internal List<int> list_0;

	public Class200(List<int> list_1)
	{
		list_0 = list_1;
	}

	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, Class195? class195_0)
	{
		//yield-return decompiler failed: Method not found
		return new Class208(-2)
		{
			class200_0 = this,
			ienumerable_1 = ienumerable_0,
			class195_1 = class195_0
		};
	}
}
