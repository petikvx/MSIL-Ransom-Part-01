using System.Collections.Generic;
using System.Windows.Forms;

namespace White.Core.InputDevices;

public class MouseCursor
{
	public static MouseCursor IShapedCursor;

	public static MouseCursor Pointer;

	public static readonly MouseCursor DefaultAndWait;

	public static readonly MouseCursor Wait;

	public static readonly MouseCursor SilverlightWait;

	public static MouseCursor SilverlightPointer;

	private readonly int value;

	private static readonly List<MouseCursor> waitCursors;

	public static List<MouseCursor> WaitCursors => waitCursors;

	static MouseCursor()
	{
		IShapedCursor = new MouseCursor(65555);
		Pointer = new MouseCursor(65553);
		DefaultAndWait = new MouseCursor(65575);
		Wait = new MouseCursor(65557);
		SilverlightWait = new MouseCursor(65543);
		SilverlightPointer = new MouseCursor(65539);
		waitCursors = new List<MouseCursor>();
		waitCursors.Add(DefaultAndWait);
		waitCursors.Add(Wait);
		waitCursors.Add(SilverlightWait);
		waitCursors.AddRange(DynamicWaitCursors());
	}

	public MouseCursor(int value)
	{
		this.value = value;
	}

	public static List<MouseCursor> DynamicWaitCursors()
	{
		List<MouseCursor> list = new List<MouseCursor>();
		list.Add(new MouseCursor(Cursors.get_WaitCursor().get_Handle().ToInt32()));
		return list;
	}

	public override bool Equals(object obj)
	{
		if (object.ReferenceEquals(null, obj))
		{
			return false;
		}
		if (object.ReferenceEquals(this, obj))
		{
			return true;
		}
		if (obj.GetType() != typeof(MouseCursor))
		{
			return false;
		}
		return ((MouseCursor)obj).value == value;
	}

	public override int GetHashCode()
	{
		return value;
	}

	public override string ToString()
	{
		int num = value;
		return num.ToString();
	}
}
