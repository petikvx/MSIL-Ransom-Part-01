using System.Windows;
using White.Core.UIItems;
using White.Core.UIItems.Actions;

namespace White.Core.InputDevices;

public class AttachedMouse : IMouse
{
	private readonly ActionListener actionListener;

	private readonly Mouse mouse;

	public virtual Point Location
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return mouse.Location;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			mouse.Location = value;
		}
	}

	internal AttachedMouse(Mouse mouse, ActionListener actionListener)
	{
		this.actionListener = actionListener;
		this.mouse = mouse;
	}

	public virtual void RightClick()
	{
		mouse.RightClick();
		ActionPerformed();
	}

	private void ActionPerformed()
	{
		actionListener.ActionPerformed(Action.WindowMessage);
	}

	public virtual void Click()
	{
		mouse.Click();
		ActionPerformed();
	}

	public virtual void DoubleClick(Point point)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		mouse.DoubleClick(point);
		ActionPerformed();
	}

	public virtual void Click(Point point)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		mouse.Click(point);
		ActionPerformed();
	}

	public virtual void DragAndDrop(IUIItem draggedItem, IUIItem dropItem)
	{
		mouse.DragAndDrop(draggedItem, dropItem);
		ActionPerformed();
	}

	public virtual void DragAndDrop(IUIItem draggedItem, Point startPosition, IUIItem dropItem, Point endPosition)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		mouse.DragAndDrop(draggedItem, startPosition, dropItem, endPosition);
		ActionPerformed();
	}
}
