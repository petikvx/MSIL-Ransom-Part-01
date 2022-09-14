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

namespace coxZRmDhvSAWo;

internal sealed class OzMrYmCzWNyZ
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct kOYOZMhjVjFY
	{
		public string eXIgFrwIcgI;

		public uint svWXFTDgmS;

		public string qetoeXyZfUDKBj;

		public kOYOZMhjVjFY(string string_0, uint uint_0, string string_1)
		{
			eXIgFrwIcgI = string_0;
			svWXFTDgmS = uint_0;
			qetoeXyZfUDKBj = string_1;
		}

		public override string ToString()
		{
			return eXIgFrwIcgI;
		}
	}

	private sealed class MagjaoKDvGZe
	{
		public GWtVEbHHeSoT.DreBjpmCbgKhJ ALEIZPJgPxctYC;
	}

	private sealed class spRfvBgohXdWOMH
	{
		public MagjaoKDvGZe VXvsaHKGsPg;

		public string aDUgMOOGDWWbi;

		public void _003CGetAllShares_003Eb__1()
		{
			ggXnXpUXeBwhtI(aDUgMOOGDWWbi, VXvsaHKGsPg.ALEIZPJgPxctYC);
		}
	}

	public static ReaderWriterLockSlim aFeNBXceUhLNT;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static kOYOZMhjVjFY[] rFJYdgCUGQV(string string_0)
	{
		List<kOYOZMhjVjFY> list = new List<kOYOZMhjVjFY>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(kOYOZMhjVjFY));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				kOYOZMhjVjFY item = (kOYOZMhjVjFY)Marshal.PtrToStructure(ptr, typeof(kOYOZMhjVjFY));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new kOYOZMhjVjFY(getString_0(107364473) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void ggXnXpUXeBwhtI(string string_0, GWtVEbHHeSoT.DreBjpmCbgKhJ dreBjpmCbgKhJ_0)
	{
		string[] source = new string[2]
		{
			getString_0(107364464),
			getString_0(107364483)
		};
		kOYOZMhjVjFY[] array = rFJYdgCUGQV(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			kOYOZMhjVjFY[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				kOYOZMhjVjFY kOYOZMhjVjFY = array2[i];
				if (dreBjpmCbgKhJ_0.smWXbICUUTvJslJG != null && dreBjpmCbgKhJ_0.smWXbICUUTvJslJG.Contains(kOYOZMhjVjFY.eXIgFrwIcgI.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107364438), string_0, kOYOZMhjVjFY.eXIgFrwIcgI);
					Directory.GetFiles(text);
					list.Add(kOYOZMhjVjFY.eXIgFrwIcgI);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!aSOyqwTwiifNb.ZmKssmQIdPi.Contains(text))
							{
								aSOyqwTwiifNb.ZmKssmQIdPi.Add(text);
							}
							list2.Add(kOYOZMhjVjFY.eXIgFrwIcgI);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(kOYOZMhjVjFY.eXIgFrwIcgI))
					{
						list3.Add(kOYOZMhjVjFY.eXIgFrwIcgI);
					}
				}
			}
		}
		YgHkehYlHjXEY.HZMOpTDYHgAg++;
	}

	public static void IxsZhWVYeH(List<string> list_0, GWtVEbHHeSoT.DreBjpmCbgKhJ dreBjpmCbgKhJ_0)
	{
		MagjaoKDvGZe magjaoKDvGZe = new MagjaoKDvGZe();
		magjaoKDvGZe.ALEIZPJgPxctYC = dreBjpmCbgKhJ_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				spRfvBgohXdWOMH CS_0024_003C_003E8__locals0 = new spRfvBgohXdWOMH();
				CS_0024_003C_003E8__locals0.VXvsaHKGsPg = magjaoKDvGZe;
				CS_0024_003C_003E8__locals0.aDUgMOOGDWWbi = enumerator.Current;
				action = delegate
				{
					ggXnXpUXeBwhtI(CS_0024_003C_003E8__locals0.aDUgMOOGDWWbi, CS_0024_003C_003E8__locals0.VXvsaHKGsPg.ALEIZPJgPxctYC);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = magjaoKDvGZe.ALEIZPJgPxctYC.IeqSEttefCWKQHvP;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static OzMrYmCzWNyZ()
	{
		Strings.CreateGetStringDelegate(typeof(OzMrYmCzWNyZ));
		aFeNBXceUhLNT = new ReaderWriterLockSlim();
	}
}
