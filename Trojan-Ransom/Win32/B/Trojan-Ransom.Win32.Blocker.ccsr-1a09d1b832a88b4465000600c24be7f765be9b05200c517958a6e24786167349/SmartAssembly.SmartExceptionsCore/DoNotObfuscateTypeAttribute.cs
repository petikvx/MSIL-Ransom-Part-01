using System;
using System.Drawing;
using System.IO;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class DoNotObfuscateTypeAttribute : Attribute
{
	static DoNotObfuscateTypeAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static byte smethod_0(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return color_0.G;
			case 98:
				return color_0.A;
			}
		}
	}

	internal static bool smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 105:
				return Directory.Exists(string_0);
			}
		}
	}
}
