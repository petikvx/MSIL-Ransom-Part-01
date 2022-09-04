using System;
using System.Runtime.InteropServices;

namespace ns2;

internal sealed class Class5
{
	internal static Delegate smethod_0(IntPtr intptr_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
			}
		}
	}
}
