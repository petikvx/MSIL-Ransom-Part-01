using Gecko.Interop;

namespace Gecko.Cryptography;

public static class KeyObjectFactory
{
	private static ComPtr<nsIKeyObjectFactory> _keyObjectFactory;

	static KeyObjectFactory()
	{
		_keyObjectFactory = Xpcom.GetService2<nsIKeyObjectFactory>("@mozilla.org/security/keyobjectfactory;1");
	}

	public static KeyObject UnwrapKey(AlgorithmType algorithm, byte[] key)
	{
		nsIKeyObject keyObject = _keyObjectFactory.Instance.UnwrapKey((short)algorithm, key, (uint)key.Length);
		return new KeyObject(keyObject);
	}

	public static KeyObject LookupKeyByName(string name)
	{
		nsIKeyObject keyObject = nsString.Pass(_keyObjectFactory.Instance.LookupKeyByName, name);
		return new KeyObject(keyObject);
	}
}
