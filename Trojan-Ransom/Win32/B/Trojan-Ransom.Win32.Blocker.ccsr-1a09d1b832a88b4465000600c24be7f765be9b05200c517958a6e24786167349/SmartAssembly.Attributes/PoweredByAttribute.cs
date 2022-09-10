using System;
using System.Reflection;
using SmartAssembly.Zip;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	public PoweredByAttribute(string s)
	{
	}

	static PoweredByAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Assembly smethod_0(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return Assembly.Load(byte_0);
			}
		}
	}
}
