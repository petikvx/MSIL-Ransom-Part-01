using System;
using System.IO;
using System.Security;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class DoNotObfuscateTypeAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotObfuscateTypeAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static int smethod_0(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 100:
				return stream_0.ReadByte();
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_1(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return dateTime_0.Year;
			}
		}
	}
}
