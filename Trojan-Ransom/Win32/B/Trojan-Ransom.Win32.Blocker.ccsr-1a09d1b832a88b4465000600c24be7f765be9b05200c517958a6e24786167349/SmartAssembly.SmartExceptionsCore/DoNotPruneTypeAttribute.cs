using System;
using Microsoft.Win32;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class DoNotPruneTypeAttribute : Attribute
{
	static DoNotPruneTypeAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(RegistryKey registryKey_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				registryKey_0.Close();
				return;
			}
		}
	}

	internal static void smethod_1(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		while (true)
		{
			switch (int_4 ^ int_3)
			{
			case 54:
				Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
				return;
			}
		}
	}
}
