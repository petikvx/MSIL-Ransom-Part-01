using System;
using System.Drawing;
using System.IO;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class DoNotPruneAttribute : Attribute
{
	static DoNotPruneAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static byte smethod_0(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return color_0.R;
			}
		}
	}

	internal static bool smethod_1(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return string_0.Contains(string_1);
			}
		}
	}

	internal static void smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				stream_0.Flush();
				return;
			}
		}
	}
}
