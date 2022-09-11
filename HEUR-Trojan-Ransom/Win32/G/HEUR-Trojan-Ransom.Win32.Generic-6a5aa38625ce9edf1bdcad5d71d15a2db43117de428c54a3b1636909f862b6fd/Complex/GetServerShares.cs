using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Complex;

public class GetServerShares
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHARE_INFO_1
	{
		public string shi1_netname;

		public uint shi1_type;

		public string shi1_remark;

		public SHARE_INFO_1(string sharename, uint sharetype, string remark)
		{
			shi1_netname = sharename;
			shi1_type = sharetype;
			shi1_remark = remark;
		}

		public override string ToString()
		{
			return shi1_netname;
		}
	}

	private enum NetError : uint
	{
		NERR_Success = 0u,
		NERR_BASE = 2100u,
		NERR_UnknownDevDir = 2116u,
		NERR_DuplicateShare = 2118u,
		NERR_BufTooSmall = 2123u
	}

	private enum SHARE_TYPE : uint
	{
		STYPE_DISKTREE = 0u,
		STYPE_PRINTQ = 1u,
		STYPE_DEVICE = 2u,
		STYPE_IPC = 3u,
		STYPE_SPECIAL = 2147483648u
	}

	private const uint MAX_PREFERRED_LENGTH = uint.MaxValue;

	private const int NERR_Success = 0;

	public SHARE_INFO_1[] EnumNetShares(string Server)
	{
		List<SHARE_INFO_1> list = new List<SHARE_INFO_1>();
		int entriesread = 0;
		int totalentries = 0;
		int resume_handle = 0;
		int num = Marshal.SizeOf(typeof(SHARE_INFO_1));
		IntPtr bufPtr = IntPtr.Zero;
		StringBuilder serverName = new StringBuilder(Server);
		int num2 = NetShareEnum(serverName, 1, ref bufPtr, uint.MaxValue, ref entriesread, ref totalentries, ref resume_handle);
		if (num2 == 0)
		{
			IntPtr ptr = bufPtr;
			for (int i = 0; i < entriesread; i++)
			{
				SHARE_INFO_1 item = (SHARE_INFO_1)Marshal.PtrToStructure(ptr, typeof(SHARE_INFO_1));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(bufPtr);
			return list.ToArray();
		}
		list.Add(new SHARE_INFO_1("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr Buffer);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder ServerName, int level, ref IntPtr bufPtr, uint prefmaxlen, ref int entriesread, ref int totalentries, ref int resume_handle);

	public static void EnumerateServerShares()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			SHARE_INFO_1[] array = new GetServerShares().EnumNetShares(Environment.MachineName);
			SHARE_INFO_1[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				SHARE_INFO_1 sHARE_INFO_ = array2[i];
				if (sHARE_INFO_.ToString().Contains("ADMIN$") || sHARE_INFO_.ToString().Contains("print$") || sHARE_INFO_.ToString().Contains("User") || sHARE_INFO_.ToString().Contains("IPC$") || logicalDrives.Contains(sHARE_INFO_.ToString().Replace("$", ":\\")))
				{
					continue;
				}
				if (!Program.DizonList.Contains("\\\\" + Environment.MachineName + "\\" + sHARE_INFO_))
				{
					Program.DizonList.Add("\\\\" + Environment.MachineName + "\\" + sHARE_INFO_);
				}
				if (Program.ConsoleReport)
				{
					try
					{
						Console.WriteLine("Share Added: {0}", "\\\\" + Environment.MachineName + "\\" + sHARE_INFO_);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, "Error while enumerating shares: " + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
