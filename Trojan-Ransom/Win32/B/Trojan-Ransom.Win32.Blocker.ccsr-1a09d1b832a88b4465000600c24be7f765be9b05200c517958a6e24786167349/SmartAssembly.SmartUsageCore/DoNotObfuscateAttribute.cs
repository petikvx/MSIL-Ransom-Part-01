using System;
using System.Xml;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotObfuscateAttribute : Attribute
{
	static DoNotObfuscateAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(XmlWriter xmlWriter_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				xmlWriter_0.WriteStartDocument();
				return;
			}
		}
	}
}
