using System;

namespace SmartAssembly.Zip;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class DoNotEncodeStringsAttribute : Attribute
{
	static DoNotEncodeStringsAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	internal static short smethod_1(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 74:
				return BitConverter.ToInt16(byte_0, int_0);
			}
		}
	}
}
