using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EbNNdTmxNaUt;

public sealed class aMKFziBBCmob
{
	[NonSerialized]
	internal static GetString getString_0;

	public void npFmhzJJPSuN(string PzYaZUPOOfK, HashSet<string> OnSVJrtUIBn, out Dictionary<ulong, gscyLTjmBf> qrnSaygDPkbER, out Dictionary<ulong, gscyLTjmBf> YXoVGwdUQxRA)
	{
		YXoVGwdUQxRA = new Dictionary<ulong, gscyLTjmBf>();
		qrnSaygDPkbER = new Dictionary<ulong, gscyLTjmBf>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr YAVFBlAhoNamTnB = IntPtr.Zero;
		try
		{
			uAZUJuvsOHm(PzYaZUPOOfK, YXoVGwdUQxRA);
			YUbSpEAGMMly(PzYaZUPOOfK, out YAVFBlAhoNamTnB);
			VoWZVVWEMkANjJkB(YAVFBlAhoNamTnB);
			TuYlwbXHtKtn(ref intptr_, YAVFBlAhoNamTnB);
			bwlaktCXLuVsA(intptr_, ref qrnSaygDPkbER, OnSVJrtUIBn, YXoVGwdUQxRA, YAVFBlAhoNamTnB);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107365058), ex);
		}
		finally
		{
			if (YAVFBlAhoNamTnB.ToInt32() != -1)
			{
				AmnWAzTthqCkpC.CloseHandle(YAVFBlAhoNamTnB);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void uAZUJuvsOHm(string string_0, Dictionary<ulong, gscyLTjmBf> dictionary_0)
	{
		string text = getString_0(107365021) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = AmnWAzTthqCkpC.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			AmnWAzTthqCkpC.XVIrYtVRfertl ymeHoyFmYPgBojS = default(AmnWAzTthqCkpC.XVIrYtVRfertl);
			if (AmnWAzTthqCkpC.GetFileInformationByHandle(intPtr, out ymeHoyFmYPgBojS))
			{
				ulong num = ymeHoyFmYPgBojS.AKMieZBVbpJP;
				ulong key = (num << 32) | ymeHoyFmYPgBojS.BxuWXmtpCvps;
				gscyLTjmBf value = new gscyLTjmBf(text, 0uL);
				dictionary_0.Add(key, value);
			}
			AmnWAzTthqCkpC.CloseHandle(intPtr);
		}
	}

	private void YUbSpEAGMMly(string hYLyZZklEKn, out IntPtr YAVFBlAhoNamTnB)
	{
		string string_ = getString_0(107365021) + hYLyZZklEKn;
		YAVFBlAhoNamTnB = AmnWAzTthqCkpC.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void bwlaktCXLuVsA(IntPtr intptr_0, ref Dictionary<ulong, gscyLTjmBf> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, gscyLTjmBf> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		AmnWAzTthqCkpC.ZeroMemory(intPtr, 65544);
		uint eMjVwOZDNgOz = 0u;
		while (AmnWAzTthqCkpC.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(AmnWAzTthqCkpC.DVWIjMggjb), intPtr, 65544, out eMjVwOZDNgOz, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (eMjVwOZDNgOz > 60)
			{
				AmnWAzTthqCkpC.kHLXLNBhhMWm kHLXLNBhhMWm = new AmnWAzTthqCkpC.kHLXLNBhhMWm(intptr_2);
				if ((kHLXLNBhhMWm.qqsZWujGubBR & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(kHLXLNBhhMWm.KatpPmNNpfL))
					{
						throw new Exception(string.Format(getString_0(107365044), kHLXLNBhhMWm.KatpPmNNpfL, kHLXLNBhhMWm.jWQZGcHzfCPq));
					}
					dictionary_1.Add(kHLXLNBhhMWm.KatpPmNNpfL, new gscyLTjmBf(kHLXLNBhhMWm.jWQZGcHzfCPq, kHLXLNBhhMWm.WdeRAUzrgltAdokFP));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(kHLXLNBhhMWm.jWQZGcHzfCPq);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(kHLXLNBhhMWm.KatpPmNNpfL))
						{
							dictionary_0.Add(kHLXLNBhhMWm.KatpPmNNpfL, new gscyLTjmBf(kHLXLNBhhMWm.jWQZGcHzfCPq, kHLXLNBhhMWm.WdeRAUzrgltAdokFP));
						}
						else
						{
							gscyLTjmBf gscyLTjmBf2 = dictionary_0[kHLXLNBhhMWm.KatpPmNNpfL];
							if (string.Compare(kHLXLNBhhMWm.jWQZGcHzfCPq, gscyLTjmBf2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107365007), kHLXLNBhhMWm.KatpPmNNpfL, kHLXLNBhhMWm.jWQZGcHzfCPq, gscyLTjmBf2.Name);
								throw new Exception(string.Format(getString_0(107365044), kHLXLNBhhMWm.KatpPmNNpfL, kHLXLNBhhMWm.jWQZGcHzfCPq));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + kHLXLNBhhMWm.jYzUggJtCmf);
				eMjVwOZDNgOz -= kHLXLNBhhMWm.jYzUggJtCmf;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void VoWZVVWEMkANjJkB(IntPtr intptr_0)
	{
		AmnWAzTthqCkpC.TcLJhgmKaZbNP structure = default(AmnWAzTthqCkpC.TcLJhgmKaZbNP);
		structure.KEhskOMFWYC = 8388608uL;
		structure.ybuJkQJtaJ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		AmnWAzTthqCkpC.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		AmnWAzTthqCkpC.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void TuYlwbXHtKtn(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint CeJJQiVALNudX = 0u;
		AmnWAzTthqCkpC.jydZyqQbYyh BYTGvUigkBlTq = default(AmnWAzTthqCkpC.jydZyqQbYyh);
		if (AmnWAzTthqCkpC.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out BYTGvUigkBlTq, sizeof(AmnWAzTthqCkpC.jydZyqQbYyh), out CeJJQiVALNudX, IntPtr.Zero))
		{
			AmnWAzTthqCkpC.DVWIjMggjb structure = default(AmnWAzTthqCkpC.DVWIjMggjb);
			structure.VWTZZTpyukVwMh = 0uL;
			structure.cyiXmrMkWVq = 0L;
			structure.mupoJYbAfVREZR = BYTGvUigkBlTq.bFHZtDlXKkd;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			AmnWAzTthqCkpC.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static aMKFziBBCmob()
	{
		Strings.CreateGetStringDelegate(typeof(aMKFziBBCmob));
	}
}
