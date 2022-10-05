using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft;

internal class Clipboard : NativeWindow
{
	public delegate void ChangedEventHandler(Clipboard sender);

	private ChangedEventHandler ChangedEvent;

	private IntPtr ID;

	public event ChangedEventHandler Changed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ChangedEvent = (ChangedEventHandler)Delegate.Combine(ChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ChangedEvent = (ChangedEventHandler)Delegate.Remove(ChangedEvent, value);
		}
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetClipboardViewer(IntPtr handle);

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ChangeClipboardChain(IntPtr handle, IntPtr next);

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern long SendMessage(IntPtr handle, int code, IntPtr flags, IntPtr data);

	public Clipboard()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		((NativeWindow)this).CreateHandle(new CreateParams());
	}

	public void Install()
	{
		ID = SetClipboardViewer(((NativeWindow)this).get_Handle());
	}

	public void Uninstall()
	{
		ChangeClipboardChain(((NativeWindow)this).get_Handle(), ID);
	}

	protected override void WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		case 776:
			ChangedEvent?.Invoke(this);
			SendMessage(ID, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			break;
		case 781:
			if (((Message)(ref m)).get_WParam() == ID)
			{
				ID = ((Message)(ref m)).get_LParam();
			}
			else
			{
				SendMessage(ID, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			}
			break;
		}
		((NativeWindow)this).WndProc(ref m);
	}

	protected override void Finalize()
	{
		Uninstall();
	}
}
