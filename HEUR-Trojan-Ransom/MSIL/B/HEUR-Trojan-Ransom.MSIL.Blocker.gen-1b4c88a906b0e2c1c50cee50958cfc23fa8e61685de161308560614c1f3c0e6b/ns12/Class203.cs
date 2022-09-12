using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using ns1;
using ns14;
using ns8;

namespace ns12;

internal class Class203 : Class198
{
	internal Class213 class213_0;

	public Class203(Class213 class213_1)
	{
		class213_0 = class213_1;
	}

	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, Class195? class195_0)
	{
		//yield-return decompiler failed: Method not found
		return new Class216(-2)
		{
			class203_0 = this,
			jtoken_2 = jtoken_0,
			ienumerable_1 = ienumerable_0,
			class195_1 = class195_0
		};
	}
}
