using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Cryptography;

namespace hgDM6zCb;

public class GClass2
{
	private static readonly HybridDictionary hybridDictionary_0 = new HybridDictionary(3);

	internal static string smethod_0()
	{
		return "ar";
	}

	internal static bool smethod_1(object object_0)
	{
		if (object_0 == null)
		{
			return false;
		}
		Type type = object_0.GetType();
		Assembly assembly = type.Assembly;
		HybridDictionary hybridDictionary;
		lock (hybridDictionary_0)
		{
			hybridDictionary = (HybridDictionary)hybridDictionary_0[assembly];
		}
		if (hybridDictionary == null)
		{
			hybridDictionary = new HybridDictionary();
			lock (hybridDictionary_0)
			{
				hybridDictionary_0[assembly] = hybridDictionary;
			}
		}
		return !hybridDictionary.Contains(type);
	}

	internal static void smethod_2(RijndaelManaged rijndaelManaged_0, byte[] byte_0)
	{
		rijndaelManaged_0.Key = byte_0;
		rijndaelManaged_0.IV = byte_0;
		rijndaelManaged_0.Mode = CipherMode.CBC;
		rijndaelManaged_0.Padding = PaddingMode.None;
	}
}
