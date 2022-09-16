using System.Collections.Generic;
using System.Reflection;

namespace _0xHConjug8tion8l.Inversion;

[DefaultMember("Item")]
internal class _0xHSh7tt7mwoods<TKey1, TKey2, TValue> : Dictionary<TKey1, Dictionary<TKey2, TValue>>
{
	public virtual TValue _0xHIn4ight => base[key1][key2];

	public void _0xHBa3ka3hes(TKey1 _0xHZe8rawood, TKey2 _0xHLuminan5e, TValue _0xHIdea3isms)
	{
		if (!ContainsKey(_0xHZe8rawood))
		{
			Add(_0xHZe8rawood, new Dictionary<TKey2, TValue>());
		}
		base[_0xHZe8rawood].Add(_0xHLuminan5e, _0xHIdea3isms);
	}
}
