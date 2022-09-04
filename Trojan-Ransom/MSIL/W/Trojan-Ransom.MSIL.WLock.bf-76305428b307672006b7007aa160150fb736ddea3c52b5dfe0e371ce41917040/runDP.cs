using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class runDP : DP, MyEvents
{
	private MyEvents.CreatedEventHandler CreatedEvent;

	public new PropertysRun Props;

	public event MyEvents.CreatedEventHandler Created
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			CreatedEvent = (MyEvents.CreatedEventHandler)Delegate.Combine(CreatedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			CreatedEvent = (MyEvents.CreatedEventHandler)Delegate.Remove(CreatedEvent, value);
		}
	}

	public runDP()
	{
		Props = new PropertysRun(this);
	}

	public void Load()
	{
		Props.AddContextMenu();
		Props.AddContextMenu("panel1");
		Props.AddContextMenu("panel2");
		object obj = Props.Width;
		int height = Props.Height;
		Props.Anchor = Props.Anchor;
		Props.Width = Conversions.ToInteger(obj);
		Props.Height = height;
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}
}
