using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class runCB : CB, MyEvents
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

	public runCB()
	{
		Props = new PropertysRun(this);
	}

	public void Load()
	{
		Props.AddContextMenu();
		((CheckBox)this).set_AutoCheck(true);
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}
}
