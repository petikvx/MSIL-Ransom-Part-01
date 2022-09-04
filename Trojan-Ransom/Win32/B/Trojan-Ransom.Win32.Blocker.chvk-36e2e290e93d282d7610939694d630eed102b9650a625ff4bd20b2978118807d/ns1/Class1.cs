using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace ns1;

internal sealed class Class1 : Computer
{
	internal static IntPtr smethod_0(long long_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 25:
				return (IntPtr)long_0;
			}
		}
	}

	internal static IntPtr smethod_1(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return gchandle_0.AddrOfPinnedObject();
			}
		}
	}
}
