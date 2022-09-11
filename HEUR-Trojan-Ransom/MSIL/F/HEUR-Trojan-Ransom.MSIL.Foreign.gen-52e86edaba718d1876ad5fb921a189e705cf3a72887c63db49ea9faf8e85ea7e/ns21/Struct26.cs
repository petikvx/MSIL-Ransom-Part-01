using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns25;

namespace ns21;

internal struct Struct26 : IDisposable
{
	public int int_0;

	public int int_1;

	public IntPtr intptr_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Struct26(int int_2)
	{
		int_0 = 0;
		int_1 = 1;
		Struct28 structure = new Struct28(int_2);
		intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
		Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: false);
	}

	public Struct26(byte[] byte_0)
	{
		int_0 = 0;
		int_1 = 1;
		Struct28 structure = new Struct28(byte_0);
		intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
		Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: false);
	}

	void IDisposable.Dispose()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Marshal.PtrToStructure<Struct28>(intptr_0)!.System_002EIDisposable_002EDispose();
			Marshal.FreeHGlobal(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	public byte[] method_0()
	{
		byte[] array = null;
		if (intptr_0 == IntPtr.Zero)
		{
			throw new InvalidOperationException(getString_0(107369850));
		}
		Struct28 @struct = Marshal.PtrToStructure<Struct28>(intptr_0);
		if (@struct.int_0 > 0)
		{
			array = new byte[@struct.int_0];
			Marshal.Copy(@struct.intptr_0, array, 0, @struct.int_0);
		}
		return array;
	}

	static Struct26()
	{
		Strings.CreateGetStringDelegate(typeof(Struct26));
	}
}
