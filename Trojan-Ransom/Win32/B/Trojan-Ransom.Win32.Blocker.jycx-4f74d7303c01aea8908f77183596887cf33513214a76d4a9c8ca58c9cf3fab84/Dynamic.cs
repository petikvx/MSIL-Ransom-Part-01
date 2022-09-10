using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

internal class Dynamic
{
	public delegate IntPtr LoadLibraryAParameters(string name);

	private static readonly LoadLibraryAParameters LoadLibrary = CreateApi<LoadLibraryAParameters>("kernel32", "LoadLibraryA");

	public static T CreateApi<T>(string name, string method)
	{
		IntPtr notMatchAddress = default(IntPtr);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(GetInternalModuleBaseAddr(name, notMatchAddress), method), typeof(T));
	}

	public static IntPtr GetInternalModuleBaseAddr(string ModuleName, IntPtr NotMatchAddress)
	{
		IntPtr intPtr = default(IntPtr);
		if (!ModuleName.Contains(".dll"))
		{
			ModuleName += ".dll";
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Process.GetCurrentProcess().Modules.GetEnumerator();
			IntPtr intPtr2 = default(IntPtr);
			while (enumerator.MoveNext())
			{
				ProcessModule processModule = (ProcessModule)enumerator.Current;
				if (Operators.CompareString(processModule.ModuleName!.ToLower(), ModuleName, false) == 0)
				{
					if (NotMatchAddress == intPtr2)
					{
						return processModule.BaseAddress;
					}
					if (!(processModule.BaseAddress == NotMatchAddress))
					{
						return processModule.BaseAddress;
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return LoadLibrary(ModuleName);
	}

	public static byte[] ReadByteArray(IntPtr Address, int Size)
	{
		checked
		{
			byte[] array = new byte[Size - 1 + 1];
			int num = Size - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (IntPtr.Size)
				{
				case 4:
					array[i] = Marshal.ReadByte((IntPtr)(Address.ToInt32() + i));
					break;
				case 8:
					array[i] = Marshal.ReadByte((IntPtr)(Address.ToInt64() + i));
					break;
				}
			}
			return array;
		}
	}

	public static IntPtr GetProcAddress(IntPtr ModuleAddress, string ExportName)
	{
		IntPtr intPtr = default(IntPtr);
		return IntPtr.Size switch
		{
			4 => (IntPtr)InternalGetProcAddressManual32((int)ModuleAddress, ExportName), 
			8 => (IntPtr)InternalGetProcAddressManual64((long)ModuleAddress, ExportName), 
			_ => intPtr, 
		};
	}

	public static int InternalGetProcAddressManual32(int ModuleAddress, string Export)
	{
		checked
		{
			int num = Marshal.ReadInt32((IntPtr)(ModuleAddress + 60));
			int num2 = Marshal.ReadInt32((IntPtr)(ModuleAddress + num + 120));
			byte[] value = ReadByteArray((IntPtr)(ModuleAddress + num2), 40);
			int num3 = BitConverter.ToInt32(value, 24);
			int num4 = BitConverter.ToInt32(value, 32) + ModuleAddress;
			int num5 = BitConverter.ToInt32(value, 28) + ModuleAddress;
			int num6 = BitConverter.ToInt32(value, 36) + ModuleAddress;
			string text = null;
			IntPtr intPtr = Marshal.AllocHGlobal(64);
			int num7 = num3;
			int num8 = 0;
			int result;
			while (true)
			{
				if (num8 <= num7)
				{
					int num9 = Marshal.ReadInt32((IntPtr)(num4 + (num8 - 1) * 4));
					Marshal.Copy(ReadByteArray((IntPtr)(ModuleAddress + num9), 64), 0, intPtr, 64);
					text = Marshal.PtrToStringAnsi(intPtr);
					int num10 = BitConverter.ToInt16(ReadByteArray((IntPtr)(num6 + (num8 - 1) * 2), 2), 0);
					result = BitConverter.ToInt32(ReadByteArray((IntPtr)(num5 + num10 * 4), 4), 0) + ModuleAddress;
					if (Operators.CompareString(text, Export, false) == 0)
					{
						break;
					}
					num8++;
					continue;
				}
				Marshal.FreeHGlobal(intPtr);
				return 0;
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}

	public static long InternalGetProcAddressManual64(long ModuleAddress, string Export)
	{
		checked
		{
			int num = Marshal.ReadInt32((IntPtr)(ModuleAddress + 60L));
			int num2 = Marshal.ReadInt32((IntPtr)(ModuleAddress + num + 136L));
			byte[] value = ReadByteArray((IntPtr)(ModuleAddress + num2), 40);
			int num3 = BitConverter.ToInt32(value, 24);
			long num4 = BitConverter.ToInt32(value, 32) + ModuleAddress;
			long num5 = BitConverter.ToInt32(value, 28) + ModuleAddress;
			long num6 = BitConverter.ToInt32(value, 36) + ModuleAddress;
			string text = null;
			IntPtr intPtr = Marshal.AllocHGlobal(64);
			int num7 = num3;
			int num8 = 0;
			long result;
			while (true)
			{
				if (num8 <= num7)
				{
					int num9 = Marshal.ReadInt32((IntPtr)(num4 + (num8 - 1) * 4));
					Marshal.Copy(ReadByteArray((IntPtr)(ModuleAddress + num9), 64), 0, intPtr, 64);
					text = Marshal.PtrToStringAnsi(intPtr);
					int num10 = BitConverter.ToInt16(ReadByteArray((IntPtr)(num6 + (num8 - 1) * 2), 2), 0);
					result = BitConverter.ToInt32(ReadByteArray((IntPtr)(num5 + num10 * 4), 4), 0) + ModuleAddress;
					if (Operators.CompareString(text, Export, false) == 0)
					{
						break;
					}
					num8++;
					continue;
				}
				Marshal.FreeHGlobal(intPtr);
				return 0L;
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}
}
