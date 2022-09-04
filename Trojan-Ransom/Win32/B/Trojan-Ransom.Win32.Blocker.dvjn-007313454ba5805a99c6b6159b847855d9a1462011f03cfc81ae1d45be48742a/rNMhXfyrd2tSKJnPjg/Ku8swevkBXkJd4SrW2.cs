using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace rNMhXfyrd2tSKJnPjg;

internal sealed class Ku8swevkBXkJd4SrW2 : IDisposable
{
	private readonly Type msTYzpRvCD;

	private readonly object BiYuLWyjF5;

	public Ku8swevkBXkJd4SrW2()
	{
		try
		{
			Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
			msTYzpRvCD = assembly.GetType("System.Security.Cryptography.AesManaged");
		}
		catch (FileNotFoundException)
		{
			Assembly assembly = Assembly.Load("mscorlib");
			msTYzpRvCD = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
		}
		BiYuLWyjF5 = Activator.CreateInstance(msTYzpRvCD);
	}

	public ICryptoTransform U8pYvL3heZ(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		msTYzpRvCD.GetProperty("Key")!.GetSetMethod()!.Invoke(BiYuLWyjF5, new object[1] { byte_0 });
		if (!xXZuH7osdGqMfskqPtE())
		{
			switch (3)
			{
			case 0:
			case 3:
				msTYzpRvCD.GetProperty("IV")!.GetSetMethod()!.Invoke(BiYuLWyjF5, new object[1] { byte_1 });
				break;
			case 4:
				goto IL_00a5;
			}
		}
		MethodInfo method = msTYzpRvCD.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		goto IL_00a5;
		IL_00a5:
		return (ICryptoTransform)method.Invoke(BiYuLWyjF5, new object[0]);
	}

	public void IfeYyq8ThB()
	{
		msTYzpRvCD.GetMethod("Clear")!.Invoke(BiYuLWyjF5, new object[0]);
	}

	void IDisposable.Dispose()
	{
		IfeYyq8ThB();
	}

	internal static bool cymwwcoM3H1TBV5IHxd()
	{
		return true;
	}

	internal static bool xXZuH7osdGqMfskqPtE()
	{
		return false;
	}
}
