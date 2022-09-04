using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class runTr : Tr, MyEvents
{
	public delegate void ClickButtonEventHandler(object sender, EventArgs e);

	public delegate void ActivationSuccessulEventHandler(object sender, EventArgs e);

	public delegate void ActivationFailedEventHandler(object sender, EventArgs e);

	private MyEvents.CreatedEventHandler CreatedEvent;

	private ClickButtonEventHandler ClickButtonEvent;

	private ActivationSuccessulEventHandler ActivationSuccessulEvent;

	private ActivationFailedEventHandler ActivationFailedEvent;

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

	public event ClickButtonEventHandler ClickButton
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ClickButtonEvent = (ClickButtonEventHandler)Delegate.Combine(ClickButtonEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ClickButtonEvent = (ClickButtonEventHandler)Delegate.Remove(ClickButtonEvent, value);
		}
	}

	public event ActivationSuccessulEventHandler ActivationSuccessul
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ActivationSuccessulEvent = (ActivationSuccessulEventHandler)Delegate.Combine(ActivationSuccessulEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ActivationSuccessulEvent = (ActivationSuccessulEventHandler)Delegate.Remove(ActivationSuccessulEvent, value);
		}
	}

	public event ActivationFailedEventHandler ActivationFailed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ActivationFailedEvent = (ActivationFailedEventHandler)Delegate.Combine(ActivationFailedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ActivationFailedEvent = (ActivationFailedEventHandler)Delegate.Remove(ActivationFailedEvent, value);
		}
	}

	public runTr()
	{
		Props = new PropertysRun(this);
	}

	public void Load()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		Props.AddContextMenu();
		((Control)Buttn).add_Click((EventHandler)Buttn_Click);
		((Control)TextB).add_KeyUp(new KeyEventHandler(TextB_KeyUpRun));
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}

	private void Buttn_Click(object sender, EventArgs e)
	{
		ClickButtonEvent?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
		string @bool = Props.KeyValidation(TextB.get_Text(), peremens.trans("Да"));
		if (peremens.DaOrNet(@bool))
		{
			ActivationSuccessulEvent?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			ActivationFailedEvent?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void TextB_KeyUpRun(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			e.set_Handled(false);
			Buttn_Click(null, null);
		}
	}
}
