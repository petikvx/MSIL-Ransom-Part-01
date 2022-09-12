using System.Collections.Generic;
using ns1;
using ns14;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class FieldMultipleFilter : Class198
{
	internal List<string> list_0;

	public FieldMultipleFilter(List<string> names)
	{
		list_0 = names;
	}

	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, Class195? class195_0)
	{
		//yield-return decompiler failed: Method not found
		return new Class211(-2)
		{
			fieldMultipleFilter_0 = this,
			ienumerable_1 = ienumerable_0,
			class195_1 = class195_0
		};
	}
}
