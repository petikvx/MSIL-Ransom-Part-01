using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using White.Core.Configuration;
using White.Core.Drawing;
using White.Core.UIA;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.WindowsAPI;
using log4net;

namespace White.Core.InputDevices;

public class Mouse : IMouse
{
	private const int ExtraMillisecondsBecauseOfBugInWindows = 13;

	public static Mouse instance = new Mouse();

	private DateTime lastClickTime = DateTime.Now;

	private readonly short doubleClickTime = GetDoubleClickTime();

	private Point lastClickLocation;

	private ILog logger = LogManager.GetLogger(typeof(Mouse));

	public virtual Point Location
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			Point cursorInfo = default(Point);
			GetCursorPos(ref cursorInfo);
			return cursorInfo.ConvertToWindowsPoint();
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			if (value.IsInvalid())
			{
				throw new WhiteException($"Trying to set location outside the screen. {value}");
			}
			SetCursorPos((int)((Point)(ref value)).get_X(), (int)((Point)(ref value)).get_Y());
		}
	}

	public virtual MouseCursor Cursor
	{
		get
		{
			CursorInfo cursorInfo = CursorInfo.New();
			GetCursorInfo(ref cursorInfo);
			int value = cursorInfo.handle.ToInt32();
			return new MouseCursor(value);
		}
	}

	[DllImport("User32.dll")]
	private static extern uint SendInput(uint numberOfInputs, ref Input input, int structSize);

	[DllImport("user32.dll")]
	private static extern IntPtr GetMessageExtraInfo();

	[DllImport("user32.dll")]
	private static extern bool GetCursorPos(ref Point cursorInfo);

	[DllImport("user32.dll")]
	private static extern bool SetCursorPos(int x, int y);

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(ref CursorInfo cursorInfo);

	[DllImport("user32.dll")]
	private static extern short GetDoubleClickTime();

	private Mouse()
	{
	}

	public virtual void RightClick()
	{
		SendInput(InputFactory.Mouse(MouseInput(8)));
		SendInput(InputFactory.Mouse(MouseInput(16)));
	}

	public virtual void Click()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		Point location = Location;
		if (((Point)(ref lastClickLocation)).Equals(location))
		{
			int num = doubleClickTime - DateTime.Now.Subtract(lastClickTime).Milliseconds;
			if (num > 0)
			{
				Thread.Sleep(num + 13);
			}
		}
		MouseLeftButtonUpAndDown();
		lastClickTime = DateTime.Now;
		lastClickLocation = Location;
	}

	public static void LeftUp()
	{
		SendInput(InputFactory.Mouse(MouseInput(4)));
	}

	public static void LeftDown()
	{
		SendInput(InputFactory.Mouse(MouseInput(2)));
	}

	public virtual void DoubleClick(Point point)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		DoubleClick(point, new NullActionListener());
	}

	public virtual void DoubleClick(Point point, ActionListener actionListener)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Location = point;
		MouseLeftButtonUpAndDown();
		Thread.Sleep(CoreAppXmlConfiguration.Instance.DoubleClickInterval);
		MouseLeftButtonUpAndDown();
		ActionPerformed(actionListener);
	}

	private static void SendInput(Input input)
	{
		SendInput(1u, ref input, Marshal.SizeOf((object)input));
	}

	private static MouseInput MouseInput(int command)
	{
		return new MouseInput(command, GetMessageExtraInfo());
	}

	public virtual void RightClick(Point point, ActionListener actionListener)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Location = point;
		RightClickHere(actionListener);
	}

	public virtual void RightClick(Point point)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		RightClick(point, new NullActionListener());
	}

	internal virtual void RightClickHere(ActionListener actionListener)
	{
		RightClick();
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	public virtual void Click(Point point)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Click(point, new NullActionListener());
	}

	public virtual void Click(Point point, ActionListener actionListener)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Location = point;
		Click();
		ActionPerformed(actionListener);
	}

	private static void ActionPerformed(ActionListener actionListener)
	{
		ActionType[] actionTypes = new ActionType[1];
		actionListener.ActionPerformed(new White.Core.UIItems.Actions.Action(actionTypes));
	}

	public virtual void DragAndDrop(IUIItem draggedItem, IUIItem dropItem)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		Point startPosition = draggedItem.Bounds.Center();
		Point endPosition = dropItem.Bounds.Center();
		DragAndDrop(draggedItem, startPosition, dropItem, endPosition);
	}

	public virtual void DragAndDrop(IUIItem draggedItem, Point startPosition, IUIItem dropItem, Point endPosition)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		Location = startPosition;
		HoldForDrag();
		draggedItem.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
		float num = (float)(1.0 / (double)CoreAppXmlConfiguration.Instance.DragStepCount);
		logger.Info((object)(CoreAppXmlConfiguration.Instance.DragStepCount + ":" + num));
		Point location = default(Point);
		for (int i = 1; i <= CoreAppXmlConfiguration.Instance.DragStepCount; i++)
		{
			double num2 = ((Point)(ref startPosition)).get_X() + (((Point)(ref endPosition)).get_X() - ((Point)(ref startPosition)).get_X()) * (double)(num * (float)i);
			double num3 = ((Point)(ref startPosition)).get_Y() + (((Point)(ref endPosition)).get_Y() - ((Point)(ref startPosition)).get_Y()) * (double)(num * (float)i);
			((Point)(ref location))._002Ector((double)(int)num2, (double)(int)num3);
			Location = location;
			draggedItem.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
		}
		LeftUp();
		dropItem.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	private void HoldForDrag()
	{
		LeftDown();
		LeftUp();
		Thread.Sleep(CoreAppXmlConfiguration.Instance.DoubleClickInterval);
		LeftDown();
	}

	public static void MouseLeftButtonUpAndDown()
	{
		LeftDown();
		LeftUp();
	}

	public virtual void MoveOut()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		Location = new Point(0.0, 0.0);
	}

	public virtual void DragHorizontally(UIItem uiItem, int distance)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		Location = uiItem.Bounds.Center();
		Point location = Location;
		double x = ((Point)(ref location)).get_X();
		Point location2 = Location;
		double y = ((Point)(ref location2)).get_Y();
		HoldForDrag();
		ActionPerformed(uiItem);
		Location = new Point(x + (double)distance, y);
		LeftUp();
	}

	public virtual void DragVertically(UIItem uiItem, int distance)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		Location = uiItem.Bounds.Center();
		Point location = Location;
		double x = ((Point)(ref location)).get_X();
		Point location2 = Location;
		double y = ((Point)(ref location2)).get_Y();
		HoldForDrag();
		ActionPerformed(uiItem);
		Location = new Point(x, y + (double)distance);
		LeftUp();
	}
}
