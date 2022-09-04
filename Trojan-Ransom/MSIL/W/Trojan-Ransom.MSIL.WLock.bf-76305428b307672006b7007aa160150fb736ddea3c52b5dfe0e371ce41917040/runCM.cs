using System;
using System.Runtime.CompilerServices;

internal class runCM : CM, MyEvents
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

	public runCM()
	{
		Props = new PropertysRun(this);
	}

	public void Load()
	{
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}
}
