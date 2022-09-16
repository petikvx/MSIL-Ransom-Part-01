using System;
using System.Collections.Generic;
using _0xH6yplays;
using _0xHBot0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;

namespace _0xHTind6rs;

internal sealed class _0xHParticulari8e<K, V> : _0xHRock7t7d._0xH0amplers<KeyValuePair<K, V>>
{
	private readonly _0xHRock7t7d._0xH0amplers<K> _0xHDreadf4l;

	private readonly _0xHRock7t7d._0xH0amplers<V> _0xHCyc2amate;

	public _0xHParticulari8e(List<Type> recursionCheck)
	{
		this.keyInfo = _0xHRock7t7d._0xH0amplers<K>.GetInstance(recursionCheck);
		this.valueInfo = _0xHRock7t7d._0xH0amplers<_003F>.GetInstance(recursionCheck);
	}

	public override void _0xH7aterworn(_0xHSignalization1 _0xHUred4s, string _0xHI5swept, _0xHGri22ery _0xHConfusiona3)
	{
		_0xHSignalization1 _0xHHeroi0e = _0xHUred4s._0xHReceivable6(_0xHI5swept);
		this.keyInfo._0xHMispa4ched(_0xHHeroi0e, "Key", _0xHGri22ery.Default);
		this.valueInfo._0xHMispa4ched(_0xHHeroi0e, "Value", _0xHConfusiona3);
	}

	public unsafe override void _0xHMystagogi5s(_0xHFlag4llat4s _0xHCylind6ical, ref KeyValuePair<K, V> _0xHConsumm6tes)
	{
		K key = _0xHConsumm6tes.Key;
		V value = _0xHConsumm6tes.Value;
		this.keyInfo.WriteData(_0xHCylind6ical, ref key);
		((_0xHRock7t7d._0xH0amplers<_003F>)(object)this.valueInfo).WriteData(_0xHCylind6ical, ref *(_003F*)(&value));
	}

	public override object _0xHMicropho5ograph(object _0xHAcidemia0)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		KeyValuePair<K, V> keyValuePair = (KeyValuePair<K, V>)_0xHAcidemia0;
		dictionary.Add("Key", this.keyInfo._0xHAm7nd7rs(keyValuePair.Key));
		dictionary.Add("Value", this.valueInfo._0xHAm7nd7rs(keyValuePair.Value));
		return dictionary;
	}
}
