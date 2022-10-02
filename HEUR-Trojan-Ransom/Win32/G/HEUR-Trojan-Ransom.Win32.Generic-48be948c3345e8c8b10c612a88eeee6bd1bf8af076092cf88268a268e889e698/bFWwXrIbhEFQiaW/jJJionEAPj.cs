using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bFWwXrIbhEFQiaW;

public sealed class jJJionEAPj
{
	[NonSerialized]
	internal static GetString getString_0;

	public void MnUXtmLbFtUrg(string EfePTsPMmcovE, HashSet<string> iHIJIloAPstxbOhkJ, out Dictionary<ulong, TBzXjPONBCkB> JkBXdEWzxJQ, out Dictionary<ulong, TBzXjPONBCkB> RTemUIrBEhbT)
	{
		RTemUIrBEhbT = new Dictionary<ulong, TBzXjPONBCkB>();
		JkBXdEWzxJQ = new Dictionary<ulong, TBzXjPONBCkB>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr OMZGolTjJfN = IntPtr.Zero;
		try
		{
			CVMqTGIxIvRzt(EfePTsPMmcovE, RTemUIrBEhbT);
			tEIaWeCKUYzn(EfePTsPMmcovE, out OMZGolTjJfN);
			sPccOfxwKPHPup(OMZGolTjJfN);
			cedwzMXGzvKL(ref intptr_, OMZGolTjJfN);
			zbrWfmqAZTnzjJwn(intptr_, ref JkBXdEWzxJQ, iHIJIloAPstxbOhkJ, RTemUIrBEhbT, OMZGolTjJfN);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107461815), ex);
		}
		finally
		{
			if (OMZGolTjJfN.ToInt32() != -1)
			{
				SHnbdIEbpZVY.CloseHandle(OMZGolTjJfN);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void CVMqTGIxIvRzt(string string_0, Dictionary<ulong, TBzXjPONBCkB> dictionary_0)
	{
		string text = getString_0(107461778) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = SHnbdIEbpZVY.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			SHnbdIEbpZVY.KqLbsJldtwrpU SJtAZElmUTSBQhs = default(SHnbdIEbpZVY.KqLbsJldtwrpU);
			if (SHnbdIEbpZVY.GetFileInformationByHandle(intPtr, out SJtAZElmUTSBQhs))
			{
				ulong num = SJtAZElmUTSBQhs.AnGFfhutTzBiK;
				ulong key = (num << 32) | SJtAZElmUTSBQhs.TGoaEIVjOWlkL;
				TBzXjPONBCkB value = new TBzXjPONBCkB(text, 0uL);
				dictionary_0.Add(key, value);
			}
			SHnbdIEbpZVY.CloseHandle(intPtr);
		}
	}

	private void tEIaWeCKUYzn(string DNFdlbXWMwtkV, out IntPtr OMZGolTjJfN)
	{
		string string_ = getString_0(107461778) + DNFdlbXWMwtkV;
		OMZGolTjJfN = SHnbdIEbpZVY.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void zbrWfmqAZTnzjJwn(IntPtr intptr_0, ref Dictionary<ulong, TBzXjPONBCkB> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, TBzXjPONBCkB> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		SHnbdIEbpZVY.ZeroMemory(intPtr, 65544);
		uint yWIMbVaTqpP = 0u;
		while (SHnbdIEbpZVY.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(SHnbdIEbpZVY.jnIazHGnCORozK), intPtr, 65544, out yWIMbVaTqpP, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (yWIMbVaTqpP > 60)
			{
				SHnbdIEbpZVY.QoWeGPjHkVe qoWeGPjHkVe = new SHnbdIEbpZVY.QoWeGPjHkVe(intptr_2);
				if ((qoWeGPjHkVe.uzCIwIVLjuuPXJm & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(qoWeGPjHkVe.CzcaGffkBlWLOa))
					{
						throw new Exception(string.Format(getString_0(107461801), qoWeGPjHkVe.CzcaGffkBlWLOa, qoWeGPjHkVe.BJxpRYxmovKECx));
					}
					dictionary_1.Add(qoWeGPjHkVe.CzcaGffkBlWLOa, new TBzXjPONBCkB(qoWeGPjHkVe.BJxpRYxmovKECx, qoWeGPjHkVe.cyPzvzJClXSHGR));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(qoWeGPjHkVe.BJxpRYxmovKECx);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(qoWeGPjHkVe.CzcaGffkBlWLOa))
						{
							dictionary_0.Add(qoWeGPjHkVe.CzcaGffkBlWLOa, new TBzXjPONBCkB(qoWeGPjHkVe.BJxpRYxmovKECx, qoWeGPjHkVe.cyPzvzJClXSHGR));
						}
						else
						{
							TBzXjPONBCkB tBzXjPONBCkB = dictionary_0[qoWeGPjHkVe.CzcaGffkBlWLOa];
							if (string.Compare(qoWeGPjHkVe.BJxpRYxmovKECx, tBzXjPONBCkB.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107461764), qoWeGPjHkVe.CzcaGffkBlWLOa, qoWeGPjHkVe.BJxpRYxmovKECx, tBzXjPONBCkB.Name);
								throw new Exception(string.Format(getString_0(107461801), qoWeGPjHkVe.CzcaGffkBlWLOa, qoWeGPjHkVe.BJxpRYxmovKECx));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + qoWeGPjHkVe.syLgGjAvrENOBJu);
				yWIMbVaTqpP -= qoWeGPjHkVe.syLgGjAvrENOBJu;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void sPccOfxwKPHPup(IntPtr intptr_0)
	{
		SHnbdIEbpZVY.RWEUSmHFxC structure = default(SHnbdIEbpZVY.RWEUSmHFxC);
		structure.CHdyXOnpJmbQg = 8388608uL;
		structure.cQwLKkxfJSNZM = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		SHnbdIEbpZVY.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		SHnbdIEbpZVY.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void cedwzMXGzvKL(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint ZgnwYwBWzx = 0u;
		SHnbdIEbpZVY.KWjceTmPPWvJ AwXKlKESDeMnt = default(SHnbdIEbpZVY.KWjceTmPPWvJ);
		if (SHnbdIEbpZVY.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out AwXKlKESDeMnt, sizeof(SHnbdIEbpZVY.KWjceTmPPWvJ), out ZgnwYwBWzx, IntPtr.Zero))
		{
			SHnbdIEbpZVY.jnIazHGnCORozK structure = default(SHnbdIEbpZVY.jnIazHGnCORozK);
			structure.gKNYMqNbuo = 0uL;
			structure.pARaykxKVQVgSWvNqt = 0L;
			structure.TLelSwkujCZJP = AwXKlKESDeMnt.XTtmiHSMvd;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			SHnbdIEbpZVY.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static jJJionEAPj()
	{
		Strings.CreateGetStringDelegate(typeof(jJJionEAPj));
	}
}
