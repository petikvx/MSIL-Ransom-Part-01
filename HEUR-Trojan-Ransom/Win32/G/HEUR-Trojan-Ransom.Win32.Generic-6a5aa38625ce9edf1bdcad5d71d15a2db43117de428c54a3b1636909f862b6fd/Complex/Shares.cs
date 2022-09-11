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

namespace Complex;

internal class Shares
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct WKSTA_INFO_100
	{
		public int platform_id;

		public string computer_name;

		public string lan_group;

		public int ver_major;

		public int ver_minor;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHARE_INFO_0
	{
		public string shi0_netname;
	}

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

	public static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();

	[DllImport("Netapi32.dll", SetLastError = true)]
	public static extern int NetWkstaGetInfo(string servername, int level, out IntPtr bufptr);

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr Buffer);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder ServerName, int level, ref IntPtr bufPtr, uint prefmaxlen, ref int entriesread, ref int totalentries, ref int resume_handle);

	public static SHARE_INFO_1[] EnumNetShares(string Server)
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

	public static void GetComputerShares(string computer, Options.Arguments argumetns)
	{
		string[] source = new string[2] { "ERROR=53", "ERROR=5" };
		SHARE_INFO_1[] array = EnumNetShares(computer);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			SHARE_INFO_1[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				SHARE_INFO_1 sHARE_INFO_ = array2[i];
				if (argumetns.filter != null && argumetns.filter.Contains(sHARE_INFO_.shi1_netname.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = $"\\\\{computer}\\{sHARE_INFO_.shi1_netname}";
					Directory.GetFiles(text);
					list.Add(sHARE_INFO_.shi1_netname);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!Program.DizonList.Contains(text))
							{
								Program.DizonList.Add(text);
							}
							list2.Add(sHARE_INFO_.shi1_netname);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(sHARE_INFO_.shi1_netname))
					{
						list3.Add(sHARE_INFO_.shi1_netname);
					}
				}
			}
		}
		Status.currentCount++;
	}

	public static void WriteToFileThreadSafe(string text, string path)
	{
		_readWriteLock.EnterWriteLock();
		try
		{
			using StreamWriter streamWriter = File.AppendText(path);
			streamWriter.WriteLine(text);
			streamWriter.Close();
		}
		finally
		{
			_readWriteLock.ExitWriteLock();
		}
	}

	public static void GetAllShares(List<string> computers, Options.Arguments arguments)
	{
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = computers.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				string computer = enumerator.Current;
				action = delegate
				{
					GetComputerShares(computer, arguments);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = arguments.threads;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}
}
