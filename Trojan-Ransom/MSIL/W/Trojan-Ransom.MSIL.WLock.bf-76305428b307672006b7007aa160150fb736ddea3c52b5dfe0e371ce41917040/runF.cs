using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class runF : Form, MyEvents
{
	public delegate void DoubleClickTrayEventHandler(object sender, EventArgs e);

	public delegate void MinimizeEventHandler(object sender, EventArgs e);

	public string TypeObj;

	public string defaultName;

	public PropertysRun Props;

	private MyEvents.CreatedEventHandler CreatedEvent;

	private DoubleClickTrayEventHandler DoubleClickTrayEvent;

	private MinimizeEventHandler MinimizeEvent;

	public object MyObj;

	public string StatusTemp;

	public NotifyIcon ni;

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

	public event DoubleClickTrayEventHandler DoubleClickTray
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			DoubleClickTrayEvent = (DoubleClickTrayEventHandler)Delegate.Combine(DoubleClickTrayEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			DoubleClickTrayEvent = (DoubleClickTrayEventHandler)Delegate.Remove(DoubleClickTrayEvent, value);
		}
	}

	public event MinimizeEventHandler Minimize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			MinimizeEvent = (MinimizeEventHandler)Delegate.Combine(MinimizeEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			MinimizeEvent = (MinimizeEventHandler)Delegate.Remove(MinimizeEvent, value);
		}
	}

	public runF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Окно");
		Props = new PropertysRun(this);
		ni = new NotifyIcon();
		if (peremens.isRUN())
		{
			((Control)this).set_Visible(false);
		}
		((Control)this).set_DoubleBuffered(true);
	}

	public void Load()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		Props.AddContextMenu();
		Props.AddContextMenu("", mainmenu: true);
		if (StatusTemp != null)
		{
			Props.WindowState = StatusTemp;
		}
		ni.add_MouseDoubleClick(new MouseEventHandler(ni_DoubleClickTray));
		((Control)this).add_Resize((EventHandler)ResizeF);
	}

	public void ni_DoubleClickTray(object sender, MouseEventArgs e)
	{
		DoubleClickTrayEvent?.Invoke(this, null);
	}

	public void ResizeF(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (!Props.Sem & ((int)((Form)this).get_WindowState() == 1))
		{
			MinimizeEvent?.Invoke(this, null);
		}
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}
}
