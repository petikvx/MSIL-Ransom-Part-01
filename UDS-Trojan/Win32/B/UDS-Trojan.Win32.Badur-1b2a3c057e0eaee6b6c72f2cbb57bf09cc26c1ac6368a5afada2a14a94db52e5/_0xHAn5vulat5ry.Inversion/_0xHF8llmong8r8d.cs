using System.Collections.Generic;
using System.Reflection;

namespace _0xHAn5vulat5ry.Inversion;

[DefaultMember("Item")]
internal class _0xHF8llmong8r8d<TKey1, TKey2, TValue> : Dictionary<TKey1, Dictionary<TKey2, TValue>>
{
	public virtual TValue _0xHDuke7 => base[key1][key2];

	public void _0xHW5atsits(TKey1 _0xHD3vis3, TKey2 _0xHFram3abl3, TValue _0xHPo8ers)
	{
		if (!ContainsKey(_0xHD3vis3))
		{
			Add(_0xHD3vis3, new Dictionary<TKey2, TValue>());
		}
		base[_0xHD3vis3].Add(_0xHFram3abl3, _0xHPo8ers);
	}
}
