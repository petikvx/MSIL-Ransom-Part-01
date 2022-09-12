using System;

namespace Gecko.WebIDL;

public class SubtleCrypto : WebIDLBase
{
	public SubtleCrypto(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> Encrypt(WebIDLUnion<object, string> algorithm, nsISupports key, WebIDLUnion<IntPtr, IntPtr> data)
	{
		return CallMethod<Promise<object>>("encrypt", new object[3] { algorithm, key, data });
	}

	public Promise<object> Decrypt(WebIDLUnion<object, string> algorithm, nsISupports key, WebIDLUnion<IntPtr, IntPtr> data)
	{
		return CallMethod<Promise<object>>("decrypt", new object[3] { algorithm, key, data });
	}

	public Promise<object> Sign(WebIDLUnion<object, string> algorithm, nsISupports key, WebIDLUnion<IntPtr, IntPtr> data)
	{
		return CallMethod<Promise<object>>("sign", new object[3] { algorithm, key, data });
	}

	public Promise<object> Verify(WebIDLUnion<object, string> algorithm, nsISupports key, WebIDLUnion<IntPtr, IntPtr> signature, WebIDLUnion<IntPtr, IntPtr> data)
	{
		return CallMethod<Promise<object>>("verify", new object[4] { algorithm, key, signature, data });
	}

	public Promise<object> Digest(WebIDLUnion<object, string> algorithm, WebIDLUnion<IntPtr, IntPtr> data)
	{
		return CallMethod<Promise<object>>("digest", new object[2] { algorithm, data });
	}

	public Promise<object> GenerateKey(WebIDLUnion<object, string> algorithm, bool extractable, string[] keyUsages)
	{
		return CallMethod<Promise<object>>("generateKey", new object[3] { algorithm, extractable, keyUsages });
	}

	public Promise<object> DeriveKey(WebIDLUnion<object, string> algorithm, nsISupports baseKey, WebIDLUnion<object, string> derivedKeyType, bool extractable, string[] keyUsages)
	{
		return CallMethod<Promise<object>>("deriveKey", new object[5] { algorithm, baseKey, derivedKeyType, extractable, keyUsages });
	}

	public Promise<object> DeriveBits(WebIDLUnion<object, string> algorithm, nsISupports baseKey, uint length)
	{
		return CallMethod<Promise<object>>("deriveBits", new object[3] { algorithm, baseKey, length });
	}

	public Promise<object> ImportKey(string format, object keyData, WebIDLUnion<object, string> algorithm, bool extractable, string[] keyUsages)
	{
		return CallMethod<Promise<object>>("importKey", new object[5] { format, keyData, algorithm, extractable, keyUsages });
	}

	public Promise<object> ExportKey(string format, nsISupports key)
	{
		return CallMethod<Promise<object>>("exportKey", new object[2] { format, key });
	}

	public Promise<object> WrapKey(string format, nsISupports key, nsISupports wrappingKey, WebIDLUnion<object, string> wrapAlgorithm)
	{
		return CallMethod<Promise<object>>("wrapKey", new object[4] { format, key, wrappingKey, wrapAlgorithm });
	}

	public Promise<object> UnwrapKey(string format, WebIDLUnion<IntPtr, IntPtr> wrappedKey, nsISupports unwrappingKey, WebIDLUnion<object, string> unwrapAlgorithm, WebIDLUnion<object, string> unwrappedKeyAlgorithm, bool extractable, string[] keyUsages)
	{
		return CallMethod<Promise<object>>("unwrapKey", new object[7] { format, wrappedKey, unwrappingKey, unwrapAlgorithm, unwrappedKeyAlgorithm, extractable, keyUsages });
	}
}
