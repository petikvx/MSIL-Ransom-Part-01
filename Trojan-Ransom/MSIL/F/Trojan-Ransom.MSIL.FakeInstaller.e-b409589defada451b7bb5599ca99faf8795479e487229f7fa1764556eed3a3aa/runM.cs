using System;
using System.Runtime.CompilerServices;

internal class runM : M, MyEvents
{
	public delegate void ChangingValueEventHandler(object sender, string e);

	public delegate void ChangedValueEventHandler(object sender, EventArgs e);

	private MyEvents.CreatedEventHandler CreatedEvent;

	private ChangingValueEventHandler ChangingValueEvent;

	private ChangedValueEventHandler ChangedValueEvent;

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

	public event ChangingValueEventHandler ChangingValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ChangingValueEvent = (ChangingValueEventHandler)Delegate.Combine(ChangingValueEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ChangingValueEvent = (ChangingValueEventHandler)Delegate.Remove(ChangingValueEvent, value);
		}
	}

	public event ChangedValueEventHandler ChangedValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ChangedValueEvent = (ChangedValueEventHandler)Delegate.Combine(ChangedValueEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ChangedValueEvent = (ChangedValueEventHandler)Delegate.Remove(ChangedValueEvent, value);
		}
	}

	public runM()
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

	public void RaiseChangingValue(string val)
	{
		ChangingValueEvent?.Invoke(this, val);
	}

	public void RaiseChangedValue()
	{
		ChangedValueEvent?.Invoke(this, new EventArgs());
	}
}
