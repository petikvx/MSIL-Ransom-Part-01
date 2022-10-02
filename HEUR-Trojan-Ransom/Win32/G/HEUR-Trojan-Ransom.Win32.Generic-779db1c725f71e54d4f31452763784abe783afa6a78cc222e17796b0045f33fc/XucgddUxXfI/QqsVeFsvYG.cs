using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace XucgddUxXfI;

public sealed class QqsVeFsvYG
{
	[NonSerialized]
	internal static GetString getString_0;

	public void WEtNMskVzoB(string LjqGtpwCKh, HashSet<string> WXQdYlmhJNv, out Dictionary<ulong, UbQjvrTNaCh> iXbkIPkbXrHYHx, out Dictionary<ulong, UbQjvrTNaCh> kSXFerOjljb)
	{
		kSXFerOjljb = new Dictionary<ulong, UbQjvrTNaCh>();
		iXbkIPkbXrHYHx = new Dictionary<ulong, UbQjvrTNaCh>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr URItBxqHttftJZ = IntPtr.Zero;
		try
		{
			lkTfSSaVAXFa(LjqGtpwCKh, kSXFerOjljb);
			fOJdDXiqeMkZNA(LjqGtpwCKh, out URItBxqHttftJZ);
			GlwbzrifMwVkLOHq(URItBxqHttftJZ);
			aoBHtEXnlThuvD(ref intptr_, URItBxqHttftJZ);
			QYWklLehwem(intptr_, ref iXbkIPkbXrHYHx, WXQdYlmhJNv, kSXFerOjljb, URItBxqHttftJZ);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107473398), ex);
		}
		finally
		{
			if (URItBxqHttftJZ.ToInt32() != -1)
			{
				bmquIkEwEpEOL.CloseHandle(URItBxqHttftJZ);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void lkTfSSaVAXFa(string string_0, Dictionary<ulong, UbQjvrTNaCh> dictionary_0)
	{
		string text = getString_0(107473361) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = bmquIkEwEpEOL.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			bmquIkEwEpEOL.xoIvabctPqd TGrLpLRFSbNw = default(bmquIkEwEpEOL.xoIvabctPqd);
			if (bmquIkEwEpEOL.GetFileInformationByHandle(intPtr, out TGrLpLRFSbNw))
			{
				ulong num = TGrLpLRFSbNw.gfWEnyEsbmwDN;
				ulong key = (num << 32) | TGrLpLRFSbNw.tgPlztpawXs;
				UbQjvrTNaCh value = new UbQjvrTNaCh(text, 0uL);
				dictionary_0.Add(key, value);
			}
			bmquIkEwEpEOL.CloseHandle(intPtr);
		}
	}

	private void fOJdDXiqeMkZNA(string ksYiiSwuGpp, out IntPtr URItBxqHttftJZ)
	{
		string string_ = getString_0(107473361) + ksYiiSwuGpp;
		URItBxqHttftJZ = bmquIkEwEpEOL.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void QYWklLehwem(IntPtr intptr_0, ref Dictionary<ulong, UbQjvrTNaCh> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, UbQjvrTNaCh> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		bmquIkEwEpEOL.ZeroMemory(intPtr, 65544);
		uint RzdXIZVhAWiMbV = 0u;
		while (bmquIkEwEpEOL.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(bmquIkEwEpEOL.hYDtRlkGXWAJfUa), intPtr, 65544, out RzdXIZVhAWiMbV, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (RzdXIZVhAWiMbV > 60)
			{
				bmquIkEwEpEOL.uBVCUKyWIDiNNY uBVCUKyWIDiNNY = new bmquIkEwEpEOL.uBVCUKyWIDiNNY(intptr_2);
				if ((uBVCUKyWIDiNNY.ofPDrxfWpjLbGLGz & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(uBVCUKyWIDiNNY.keGvbwZGujwwZ))
					{
						throw new Exception(string.Format(getString_0(107473384), uBVCUKyWIDiNNY.keGvbwZGujwwZ, uBVCUKyWIDiNNY.hYqWYCJHXZctLnp));
					}
					dictionary_1.Add(uBVCUKyWIDiNNY.keGvbwZGujwwZ, new UbQjvrTNaCh(uBVCUKyWIDiNNY.hYqWYCJHXZctLnp, uBVCUKyWIDiNNY.OdUiyOTopCZFYvGl));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(uBVCUKyWIDiNNY.hYqWYCJHXZctLnp);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(uBVCUKyWIDiNNY.keGvbwZGujwwZ))
						{
							dictionary_0.Add(uBVCUKyWIDiNNY.keGvbwZGujwwZ, new UbQjvrTNaCh(uBVCUKyWIDiNNY.hYqWYCJHXZctLnp, uBVCUKyWIDiNNY.OdUiyOTopCZFYvGl));
						}
						else
						{
							UbQjvrTNaCh ubQjvrTNaCh = dictionary_0[uBVCUKyWIDiNNY.keGvbwZGujwwZ];
							if (string.Compare(uBVCUKyWIDiNNY.hYqWYCJHXZctLnp, ubQjvrTNaCh.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107472835), uBVCUKyWIDiNNY.keGvbwZGujwwZ, uBVCUKyWIDiNNY.hYqWYCJHXZctLnp, ubQjvrTNaCh.Name);
								throw new Exception(string.Format(getString_0(107473384), uBVCUKyWIDiNNY.keGvbwZGujwwZ, uBVCUKyWIDiNNY.hYqWYCJHXZctLnp));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + uBVCUKyWIDiNNY.VIWvrIUBrNGzjHQsp);
				RzdXIZVhAWiMbV -= uBVCUKyWIDiNNY.VIWvrIUBrNGzjHQsp;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void GlwbzrifMwVkLOHq(IntPtr intptr_0)
	{
		bmquIkEwEpEOL.iSLVPaewudDGJ structure = default(bmquIkEwEpEOL.iSLVPaewudDGJ);
		structure.ObbecfcxooJgPOwPr = 8388608uL;
		structure.vRMAbLveSlJuK = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		bmquIkEwEpEOL.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		bmquIkEwEpEOL.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void aoBHtEXnlThuvD(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint fqqekfCnmNCxD = 0u;
		bmquIkEwEpEOL.TrMxKjIHnLj thVmiBRJxTQRzn = default(bmquIkEwEpEOL.TrMxKjIHnLj);
		if (bmquIkEwEpEOL.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out thVmiBRJxTQRzn, sizeof(bmquIkEwEpEOL.TrMxKjIHnLj), out fqqekfCnmNCxD, IntPtr.Zero))
		{
			bmquIkEwEpEOL.hYDtRlkGXWAJfUa structure = default(bmquIkEwEpEOL.hYDtRlkGXWAJfUa);
			structure.rtLSDFiCmAWbNuTw = 0uL;
			structure.bgnwmPFjMALt = 0L;
			structure.xDzTgbmKQPMmUi = thVmiBRJxTQRzn.vPIsFRIZhLZzXT;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			bmquIkEwEpEOL.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static QqsVeFsvYG()
	{
		Strings.CreateGetStringDelegate(typeof(QqsVeFsvYG));
	}
}
