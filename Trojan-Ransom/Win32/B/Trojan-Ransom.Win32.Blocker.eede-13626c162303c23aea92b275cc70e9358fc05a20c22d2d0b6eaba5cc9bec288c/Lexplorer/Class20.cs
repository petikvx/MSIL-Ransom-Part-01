using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lexplorer;

internal class Class20 : Class13
{
	private const int MOUSE_SPEED = 50;

	public Class20()
	{
		methodTable.Add("CLICK", Click);
		methodTable.Add("MOVE", Move);
		methodTable.Add("RIGHTCLICK", RightClick);
		methodTable.Add("LEFTBUTTONDOWN", MoveThenHoldLeftMouseButton);
		methodTable.Add("RIGHTBUTTONDOWN", MoveThenHoldRightMouseButton);
		methodTable.Add("RIGHTBUTTONUP", MoveThenUnholdRightMouseButton);
		methodTable.Add("LEFTBUTTONUP", MoveThenUnholdLeftMouseButton);
		methodTable.Add("MIDDLEBUTTONDOWN", MoveThenHoldMiddleButton);
		methodTable.Add("MIDDLEBUTTONUP", MoveThenUnholdMiddleButton);
		methodTable.Add("WHEEL", Scroll);
	}

	private bool Scroll(Class10 props, bool forced)
	{
		int direction = int.Parse(props["V"]);
		int num = int.Parse(props["D"]);
		Class3.SimulateMouseVerticalScroll(direction);
		if (num > 0)
		{
			Thread.Sleep(num);
		}
		return true;
	}

	private bool Click(Class10 props, bool forced)
	{
		int num = int.Parse(props["X"]);
		int num2 = int.Parse(props["Y"]);
		int durationMilliseconds = int.Parse(props["D"]);
		Point position = Cursor.get_Position();
		if (position.X != num && position.Y != num2 && !Class3.MoveMouseTo(new Point(num, num2), 0, durationMilliseconds, forced))
		{
			return false;
		}
		Class3.SimulateClick(200);
		return true;
	}

	private bool Move(Class10 props, bool forced)
	{
		int num = int.Parse(props["X"]);
		int num2 = int.Parse(props["Y"]);
		int durationMilliseconds = int.Parse(props["D"]);
		Point position = Cursor.get_Position();
		if (position.X != num && position.Y != num2 && !Class3.MoveMouseTo(new Point(num, num2), 0, durationMilliseconds, forced))
		{
			return false;
		}
		return true;
	}

	private bool RightClick(Class10 props, bool forced)
	{
		int num = int.Parse(props["X"]);
		int num2 = int.Parse(props["Y"]);
		int durationMilliseconds = int.Parse(props["D"]);
		Point position = Cursor.get_Position();
		if (position.X != num && position.Y != num2 && !Class3.MoveMouseTo(new Point(num, num2), 0, durationMilliseconds, forced))
		{
			return false;
		}
		Class3.SimulateClick(200, (MouseButtons)2097152);
		return true;
	}

	private bool MoveThenHoldMouseButton(int x, int y, MouseButtons button, int speed, bool forced)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		Point position = Cursor.get_Position();
		if (position.X != x && position.Y != y && !Class3.MoveMouseTo(new Point(x, y), 0, speed, forced))
		{
			return false;
		}
		Class3.HoldMouseButton(button);
		return true;
	}

	private bool MoveThenUnholdMouseButton(int x, int y, MouseButtons button, int speed, bool forced)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		Point position = Cursor.get_Position();
		if (position.X != x && position.Y != y && !Class3.MoveMouseTo(new Point(x, y), 0, speed, forced))
		{
			return false;
		}
		Class3.UnholdMouseButton(button);
		return true;
	}

	private bool MoveThenUnholdLeftMouseButton(Class10 props, bool forced)
	{
		int x = int.Parse(props["X"]);
		int y = int.Parse(props["Y"]);
		int speed = int.Parse(props["D"]);
		return MoveThenUnholdMouseButton(x, y, (MouseButtons)1048576, speed, forced);
	}

	private bool MoveThenUnholdRightMouseButton(Class10 props, bool forced)
	{
		int x = int.Parse(props["X"]);
		int y = int.Parse(props["Y"]);
		int speed = int.Parse(props["D"]);
		return MoveThenUnholdMouseButton(x, y, (MouseButtons)2097152, speed, forced);
	}

	private bool MoveThenHoldLeftMouseButton(Class10 props, bool forced)
	{
		int x = int.Parse(props["X"]);
		int y = int.Parse(props["Y"]);
		int speed = int.Parse(props["D"]);
		return MoveThenHoldMouseButton(x, y, (MouseButtons)1048576, speed, forced);
	}

	private bool MoveThenHoldRightMouseButton(Class10 props, bool forced)
	{
		int x = int.Parse(props["X"]);
		int y = int.Parse(props["Y"]);
		int speed = int.Parse(props["D"]);
		return MoveThenHoldMouseButton(x, y, (MouseButtons)2097152, speed, forced);
	}

	private bool MoveThenHoldMiddleButton(Class10 props, bool forced)
	{
		int x = int.Parse(props["X"]);
		int y = int.Parse(props["Y"]);
		int speed = int.Parse(props["D"]);
		return MoveThenHoldMouseButton(x, y, (MouseButtons)4194304, speed, forced);
	}

	private bool MoveThenUnholdMiddleButton(Class10 props, bool forced)
	{
		int x = int.Parse(props["X"]);
		int y = int.Parse(props["Y"]);
		int speed = int.Parse(props["D"]);
		return MoveThenUnholdMouseButton(x, y, (MouseButtons)4194304, speed, forced);
	}

	public override string ToString()
	{
		return $"Command type: MOUSE, Method={base.ExecutionMethodName}";
	}
}
