using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class PropertyStore
{
	private readonly IPropertyStore storeInterface;

	[NonSerialized]
	internal static GetString _0086;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(storeInterface.GetCount(out var propCount));
			return propCount;
		}
	}

	public PropertyStoreProperty this[int index]
	{
		get
		{
			PropertyKey key = Get(index);
			Marshal.ThrowExceptionForHR(storeInterface.GetValue(ref key, out var value));
			return new PropertyStoreProperty(key, value);
		}
	}

	public PropertyStoreProperty this[PropertyKey key]
	{
		get
		{
			for (int i = 0; i < Count; i++)
			{
				PropertyKey key2 = Get(i);
				if (key2.formatId == key.formatId && key2.propertyId == key.propertyId)
				{
					Marshal.ThrowExceptionForHR(storeInterface.GetValue(ref key2, out var value));
					return new PropertyStoreProperty(key2, value);
				}
			}
			return null;
		}
	}

	public bool Contains(PropertyKey key)
	{
		for (int i = 0; i < Count; i++)
		{
			PropertyKey propertyKey = Get(i);
			if (propertyKey.formatId == key.formatId && propertyKey.propertyId == key.propertyId)
			{
				return true;
			}
		}
		return false;
	}

	public PropertyKey Get(int index)
	{
		Marshal.ThrowExceptionForHR(storeInterface.GetAt(index, out var key));
		return key;
	}

	public PropVariant GetValue(int index)
	{
		PropertyKey key = Get(index);
		Marshal.ThrowExceptionForHR(storeInterface.GetValue(ref key, out var value));
		return value;
	}

	internal PropertyStore(IPropertyStore store)
	{
		storeInterface = store;
	}

	static PropertyStore()
	{
		Strings.CreateGetStringDelegate(typeof(PropertyStore));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0086(107400196), _0086(107400159)), _0086(107400154), _0086(107400149)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0086(107400176)))
		{
			return;
		}
		throw new SecurityException(_0086(107400119));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
