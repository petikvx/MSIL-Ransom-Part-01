using System;
using System.Runtime.CompilerServices;

internal class runW : W, MyEvents
{
	public new PropertysRun Props;

	private MyEvents.CreatedEventHandler CreatedEvent;

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

	public runW()
	{
		Props = new PropertysRun(this);
	}

	public void Load()
	{
		Props.AddContextMenu();
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}
}
