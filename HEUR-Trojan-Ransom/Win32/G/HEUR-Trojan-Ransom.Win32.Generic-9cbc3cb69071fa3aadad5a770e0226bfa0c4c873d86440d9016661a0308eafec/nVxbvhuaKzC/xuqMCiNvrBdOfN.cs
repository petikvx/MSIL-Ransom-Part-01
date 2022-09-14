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

namespace nVxbvhuaKzC;

internal sealed class xuqMCiNvrBdOfN
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct eNFNrHdFRgter
	{
		public string GLXXnHmYEYGJe;

		public uint zvIaHTDaFbAux;

		public string wlXtpQKDtaDM;

		public eNFNrHdFRgter(string string_0, uint uint_0, string string_1)
		{
			GLXXnHmYEYGJe = string_0;
			zvIaHTDaFbAux = uint_0;
			wlXtpQKDtaDM = string_1;
		}

		public override string ToString()
		{
			return GLXXnHmYEYGJe;
		}
	}

	private sealed class LRYexMQUDMxxS
	{
		public CloxxHDYIiDnH.mtofTxzGXYEyJ qqGkEiSRWYrMl;
	}

	private sealed class ASghwOOpcg
	{
		public LRYexMQUDMxxS WXLiNyPxfRxdM;

		public string MuNxpnCAWjtlvxMXH;

		public void _003CGetAllShares_003Eb__1()
		{
			kdAKfaGXumZJd(MuNxpnCAWjtlvxMXH, WXLiNyPxfRxdM.qqGkEiSRWYrMl);
		}
	}

	public static ReaderWriterLockSlim AljkCdwSIXVrSq;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static eNFNrHdFRgter[] iLMkzCbUZErD(string string_0)
	{
		List<eNFNrHdFRgter> list = new List<eNFNrHdFRgter>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(eNFNrHdFRgter));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				eNFNrHdFRgter item = (eNFNrHdFRgter)Marshal.PtrToStructure(ptr, typeof(eNFNrHdFRgter));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new eNFNrHdFRgter(getString_0(107407014) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void kdAKfaGXumZJd(string string_0, CloxxHDYIiDnH.mtofTxzGXYEyJ mtofTxzGXYEyJ_0)
	{
		string[] source = new string[2]
		{
			getString_0(107406973),
			getString_0(107406992)
		};
		eNFNrHdFRgter[] array = iLMkzCbUZErD(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			eNFNrHdFRgter[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				eNFNrHdFRgter eNFNrHdFRgter = array2[i];
				if (mtofTxzGXYEyJ_0.EnyefEsEjePkew != null && mtofTxzGXYEyJ_0.EnyefEsEjePkew.Contains(eNFNrHdFRgter.GLXXnHmYEYGJe.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107406947), string_0, eNFNrHdFRgter.GLXXnHmYEYGJe);
					Directory.GetFiles(text);
					list.Add(eNFNrHdFRgter.GLXXnHmYEYGJe);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!FcnBvlzKWyQDwH.ErNGCzDqbgJcNq.Contains(text))
							{
								FcnBvlzKWyQDwH.ErNGCzDqbgJcNq.Add(text);
							}
							list2.Add(eNFNrHdFRgter.GLXXnHmYEYGJe);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(eNFNrHdFRgter.GLXXnHmYEYGJe))
					{
						list3.Add(eNFNrHdFRgter.GLXXnHmYEYGJe);
					}
				}
			}
		}
		jdtBGFKHrhDpc.LqTHULtwfUJog++;
	}

	public static void DUkpYirkJJlLqA(List<string> list_0, CloxxHDYIiDnH.mtofTxzGXYEyJ mtofTxzGXYEyJ_0)
	{
		LRYexMQUDMxxS lRYexMQUDMxxS = new LRYexMQUDMxxS();
		lRYexMQUDMxxS.qqGkEiSRWYrMl = mtofTxzGXYEyJ_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				ASghwOOpcg CS_0024_003C_003E8__locals0 = new ASghwOOpcg();
				CS_0024_003C_003E8__locals0.WXLiNyPxfRxdM = lRYexMQUDMxxS;
				CS_0024_003C_003E8__locals0.MuNxpnCAWjtlvxMXH = enumerator.Current;
				action = delegate
				{
					kdAKfaGXumZJd(CS_0024_003C_003E8__locals0.MuNxpnCAWjtlvxMXH, CS_0024_003C_003E8__locals0.WXLiNyPxfRxdM.qqGkEiSRWYrMl);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = lRYexMQUDMxxS.qqGkEiSRWYrMl.HmjfHrzPbYuL;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static xuqMCiNvrBdOfN()
	{
		Strings.CreateGetStringDelegate(typeof(xuqMCiNvrBdOfN));
		AljkCdwSIXVrSq = new ReaderWriterLockSlim();
	}
}
