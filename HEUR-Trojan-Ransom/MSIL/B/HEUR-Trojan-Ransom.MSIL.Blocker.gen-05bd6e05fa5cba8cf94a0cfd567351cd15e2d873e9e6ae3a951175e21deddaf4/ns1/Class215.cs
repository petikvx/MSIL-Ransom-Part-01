using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using ns0;
using ns10;
using ns6;

namespace ns1;

internal class Class215 : Class213
{
	public readonly object object_0;

	public readonly object? object_1;

	public Class215(Enum33 enum33_1, object object_2, object? object_3)
		: base(enum33_1)
	{
		object_0 = object_2;
		object_1 = object_3;
	}

	public override bool vmethod_0(JToken jtoken_0, JToken jtoken_1, Class195? class195_0)
	{
		if (enum33_0 == Enum33.const_3)
		{
			return Class4.smethod_706(this, jtoken_0, jtoken_1, object_0).Any();
		}
		using (IEnumerator<JToken> enumerator = Class4.smethod_706(this, jtoken_0, jtoken_1, object_0).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				IEnumerable<JToken> enumerable = Class4.smethod_706(this, jtoken_0, jtoken_1, object_1);
				ICollection<JToken> collection = (enumerable as ICollection<JToken>) ?? enumerable.ToList();
				do
				{
					JToken current = enumerator.Current;
					foreach (JToken item in collection)
					{
						if (Class4.smethod_149(item, this, current, class195_0))
						{
							return true;
						}
					}
				}
				while (enumerator.MoveNext());
			}
		}
		return false;
	}
}
