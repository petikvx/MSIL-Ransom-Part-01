using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ns2;

internal sealed class Class4
{
	internal static IntPtr smethod_0(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return process_0.Handle;
			}
		}
	}

	internal static string smethod_1(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 42:
				return process_0.ProcessName;
			}
		}
	}

	internal static GCHandle smethod_2(object object_0, GCHandleType gchandleType_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return GCHandle.Alloc(object_0, gchandleType_0);
			}
		}
	}

	internal static void smethod_3(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				gchandle_0.Free();
				return;
			}
		}
	}

	internal static void smethod_4(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		while (true)
		{
			switch (int_4 ^ int_3)
			{
			case 67:
				Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
				return;
			}
		}
	}

	internal static int smethod_5(ref IntPtr intptr_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return intptr_0.ToInt32();
			}
		}
	}
}
