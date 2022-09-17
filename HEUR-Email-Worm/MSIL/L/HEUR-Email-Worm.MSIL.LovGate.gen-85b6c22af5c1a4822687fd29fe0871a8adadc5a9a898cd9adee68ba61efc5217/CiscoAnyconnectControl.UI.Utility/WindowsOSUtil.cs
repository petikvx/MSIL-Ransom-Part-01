#define TRACE
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using CiscoAnyconnectControl.Utility;
using Microsoft.Win32;

namespace CiscoAnyconnectControl.UI.Utility;

internal class WindowsOSUtil : OSUtil
{
	private const string AutostartKeyName = "CiscoAnyconnectControl";

	private NotifyIcon _trayIcon;

	private string CiscoAutostartKeyName => "Cisco AnyConnect Secure Mobility Agent for Windows";

	private string RegistryAutostartKey => "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	private string RegistryDisabledAutostartKey => "AutorunsDisabled";

	public override bool AddUiToSystemStart()
	{
		try
		{
			RegistryKey registryKey = WindowsOSUtil.smethod_2(Registry.CurrentUser, RegistryAutostartKey, bool_0: true);
			try
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_4(registryKey, "CiscoAnyconnectControl", (object)WindowsOSUtil.smethod_3("\"", Util.FullAssemblyPath, "\" -tray -unsafeRunAsUser"));
					return true;
				}
				WindowsOSUtil.smethod_5("Autostart key couldn't be opened!");
			}
			finally
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_6((IDisposable)registryKey);
				}
			}
		}
		catch (SecurityException ex)
		{
			Util.TraceException("SecuriyException in AddUiToSystemStart:", ex);
		}
		return false;
	}

	public override bool RemoveUiFromSystemStart()
	{
		try
		{
			RegistryKey registryKey = WindowsOSUtil.smethod_2(Registry.CurrentUser, RegistryAutostartKey, bool_0: true);
			try
			{
				if (registryKey != null)
				{
					if (WindowsOSUtil.smethod_7(registryKey, "CiscoAnyconnectControl") != null)
					{
						WindowsOSUtil.smethod_8(registryKey, "CiscoAnyconnectControl");
					}
					return true;
				}
				WindowsOSUtil.smethod_5("Autostart key couldn't be opened!");
			}
			finally
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_6((IDisposable)registryKey);
				}
			}
		}
		catch (SecurityException ex)
		{
			Util.TraceException("SecuriyException in RemoveUiFromSystemStart:", ex);
		}
		return false;
	}

	public override void ShowTrayIcon()
	{
		if (_trayIcon == null)
		{
			_trayIcon = CreateTrayIcon();
		}
		WindowsOSUtil.smethod_9(_trayIcon, bool_0: true);
	}

	private void _trayIcon_DoubleClick(object sender, EventArgs e)
	{
		OnTrayIconDoubleClick(sender, e);
	}

	public override void HideTrayIcon()
	{
		if (_trayIcon != null)
		{
			WindowsOSUtil.smethod_9(_trayIcon, bool_0: false);
		}
	}

	public override void DisableCiscoAutostart()
	{
		try
		{
			RegistryKey registryKey = WindowsOSUtil.smethod_2(Registry.LocalMachine, RegistryAutostartKey, bool_0: true);
			try
			{
				if (registryKey == null)
				{
					WindowsOSUtil.smethod_5("Autostart key couldn't be opened!");
					return;
				}
				object obj = WindowsOSUtil.smethod_7(registryKey, CiscoAutostartKeyName);
				if (obj != null)
				{
				}
			}
			finally
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_6((IDisposable)registryKey);
				}
			}
		}
		catch (SecurityException ex)
		{
			Util.TraceException("SecuriyException in DisableCiscoAutostart:", ex);
		}
	}

	public override void RestoreCiscoAutostart()
	{
		try
		{
			RegistryKey registryKey = WindowsOSUtil.smethod_2(Registry.LocalMachine, RegistryAutostartKey, bool_0: true);
			try
			{
				if (registryKey != null)
				{
					RegistryKey registryKey2 = WindowsOSUtil.smethod_2(registryKey, RegistryDisabledAutostartKey, bool_0: true);
					try
					{
						if (registryKey2 != null)
						{
							object obj = WindowsOSUtil.smethod_7(registryKey2, CiscoAutostartKeyName);
							if (obj != null)
							{
								WindowsOSUtil.smethod_4(registryKey, CiscoAutostartKeyName, obj);
								WindowsOSUtil.smethod_8(registryKey2, CiscoAutostartKeyName);
							}
							else
							{
								WindowsOSUtil.smethod_5("Cannot find backup key. Nothing to restore from.");
							}
						}
						else
						{
							WindowsOSUtil.smethod_5("Backup key couldn't be opened!");
						}
						return;
					}
					finally
					{
						if (registryKey2 != null)
						{
							WindowsOSUtil.smethod_6((IDisposable)registryKey2);
						}
					}
				}
				WindowsOSUtil.smethod_5("Autostart key couldn't be opened!");
			}
			finally
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_6((IDisposable)registryKey);
				}
			}
		}
		catch (SecurityException ex)
		{
			Util.TraceException("SecuriyException in DisableCiscoAutostart:", ex);
		}
	}

	public override bool IsCiscoAutostartEnabled()
	{
		try
		{
			RegistryKey registryKey = WindowsOSUtil.smethod_2(Registry.LocalMachine, RegistryAutostartKey, bool_0: true);
			try
			{
				if (registryKey != null)
				{
					return WindowsOSUtil.smethod_7(registryKey, CiscoAutostartKeyName) != null;
				}
				WindowsOSUtil.smethod_5("Autostart key couldn't be opened!");
				return false;
			}
			finally
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_6((IDisposable)registryKey);
				}
			}
		}
		catch (SecurityException ex)
		{
			Util.TraceException("SecuriyException in DisableCiscoAutostart:", ex);
		}
		throw WindowsOSUtil.smethod_10("Windows:IsCiscoAutostartEnabled ran to end without reaching a return.");
	}

	public override bool IsElevatedProcess()
	{
		try
		{
			RegistryKey registryKey = WindowsOSUtil.smethod_2(Registry.LocalMachine, "Software", bool_0: true);
			try
			{
				return true;
			}
			finally
			{
				if (registryKey != null)
				{
					WindowsOSUtil.smethod_6((IDisposable)registryKey);
				}
			}
		}
		catch (SecurityException ex)
		{
			Util.TraceException("SecuriyException in DisableCiscoAutostart:", ex);
			return false;
		}
	}

	private NotifyIcon CreateTrayIcon()
	{
		_trayIcon = WindowsOSUtil.smethod_11();
		WindowsOSUtil.smethod_12(_trayIcon, (EventHandler)_trayIcon_DoubleClick);
		try
		{
			WindowsOSUtil.smethod_17(_trayIcon, WindowsOSUtil.smethod_16(WindowsOSUtil.smethod_14(WindowsOSUtil.smethod_13(), "CiscoAnyconnectControl.UI.Resources.trayIcon.ico") ?? throw WindowsOSUtil.smethod_15()));
		}
		catch (Exception ex)
		{
			Util.TraceException("Error loading trayIcon:", ex);
		}
		ContextMenu val = WindowsOSUtil.smethod_18();
		WindowsOSUtil.smethod_21(WindowsOSUtil.smethod_19((Menu)(object)val), WindowsOSUtil.smethod_20("Exit", (EventHandler)OnTrayExitClick));
		WindowsOSUtil.smethod_22(_trayIcon, val);
		return _trayIcon;
	}

	static RegistryKey smethod_2(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static string smethod_3(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static void smethod_4(RegistryKey registryKey_0, string string_0, object object_0)
	{
		registryKey_0.SetValue(string_0, object_0);
	}

	static void smethod_5(string string_0)
	{
		Trace.TraceError(string_0);
	}

	static void smethod_6(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static object smethod_7(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	static void smethod_8(RegistryKey registryKey_0, string string_0)
	{
		registryKey_0.DeleteValue(string_0);
	}

	static void smethod_9(NotifyIcon notifyIcon_0, bool bool_0)
	{
		notifyIcon_0.set_Visible(bool_0);
	}

	static Exception smethod_10(string string_0)
	{
		return new Exception(string_0);
	}

	static NotifyIcon smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new NotifyIcon();
	}

	static void smethod_12(NotifyIcon notifyIcon_0, EventHandler eventHandler_0)
	{
		notifyIcon_0.add_DoubleClick(eventHandler_0);
	}

	static Assembly smethod_13()
	{
		return Assembly.GetExecutingAssembly();
	}

	static Stream smethod_14(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	static InvalidOperationException smethod_15()
	{
		return new InvalidOperationException();
	}

	static Icon smethod_16(Stream stream_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Icon(stream_0);
	}

	static void smethod_17(NotifyIcon notifyIcon_0, Icon icon_0)
	{
		notifyIcon_0.set_Icon(icon_0);
	}

	static ContextMenu smethod_18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ContextMenu();
	}

	static MenuItemCollection smethod_19(Menu menu_0)
	{
		return menu_0.get_MenuItems();
	}

	static MenuItem smethod_20(string string_0, EventHandler eventHandler_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new MenuItem(string_0, eventHandler_0);
	}

	static int smethod_21(MenuItemCollection menuItemCollection_0, MenuItem menuItem_0)
	{
		return menuItemCollection_0.Add(menuItem_0);
	}

	static void smethod_22(NotifyIcon notifyIcon_0, ContextMenu contextMenu_0)
	{
		notifyIcon_0.set_ContextMenu(contextMenu_0);
	}
}
