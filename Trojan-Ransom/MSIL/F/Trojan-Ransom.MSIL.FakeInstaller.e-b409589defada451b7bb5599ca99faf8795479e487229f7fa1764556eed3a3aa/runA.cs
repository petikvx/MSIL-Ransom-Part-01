using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class runA : A, MyEvents
{
	public delegate void OnEndEventHandler(object sender, EventArgs e);

	public new PropertysRun Props;

	private MyEvents.CreatedEventHandler CreatedEvent;

	[AccessedThroughProperty("tmr")]
	private Timer _tmr;

	private OnEndEventHandler OnEndEvent;

	public virtual Timer tmr
	{
		get
		{
			return _tmr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmr != null)
			{
				_tmr.remove_Tick((EventHandler)tmrScroll_Tick);
			}
			_tmr = value;
			if (_tmr != null)
			{
				_tmr.add_Tick((EventHandler)tmrScroll_Tick);
			}
		}
	}

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

	public event OnEndEventHandler OnEnd
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			OnEndEvent = (OnEndEventHandler)Delegate.Combine(OnEndEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			OnEndEvent = (OnEndEventHandler)Delegate.Remove(OnEndEvent, value);
		}
	}

	public runA()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		Props = new PropertysRun(this);
		tmr = new Timer();
		tmr.set_Interval(100);
		tmr.Start();
		Props.strAlias = peremens.GetUIN();
	}

	public void Load()
	{
		Props.AddContextMenu();
		Props.MediaWindow = (Control)(object)this;
		if (Props.nadoProigrat)
		{
			Props.PlayMovie();
		}
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}

	private void tmrScroll_Tick(object sender, EventArgs e)
	{
		if ((Props.PlayPosition >= Props.TotalPosition) & Props.bPlaying)
		{
			Props.StopMovie();
			OnEndEvent?.Invoke(null, null);
		}
	}
}
