using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TRM.Spread;

public class AppGlobalMessages : IDisposable
{
	public delegate void MessageEventArg(int msg, IntPtr wparam, IntPtr lparam);

	private class MessageWindow : NativeWindow, IDisposable
	{
		private int[] _messageKeys = new int[0];

		private Dictionary<int, MessageEventArg> Messages { get; set; }

		public MessageWindow()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			Messages = new Dictionary<int, MessageEventArg>();
			((NativeWindow)this).CreateHandle(new CreateParams());
		}

		public void AddMessageListener(int msg, MessageEventArg message)
		{
			Messages.Add(msg, message);
			int[] array = new int[Messages.Count];
			int num = 0;
			foreach (int key in Messages.Keys)
			{
				int num2 = (array[num] = key);
				num++;
			}
			_messageKeys = array;
		}

		public void Dispose()
		{
			if (Messages != null)
			{
				Messages.Clear();
			}
			Messages = null;
		}

		protected override void WndProc(ref Message message)
		{
			((NativeWindow)this).WndProc(ref message);
			if (_messageKeys.Length == 0)
			{
				return;
			}
			try
			{
				int num = Array.IndexOf(_messageKeys, ((Message)(ref message)).get_Msg());
				if (num >= 0)
				{
					int key = _messageKeys[num];
					MessageEventArg messageEventArg = Messages[key];
					messageEventArg.BeginInvoke(((Message)(ref message)).get_Msg(), ((Message)(ref message)).get_WParam(), ((Message)(ref message)).get_LParam(), null, null);
				}
			}
			catch
			{
			}
		}
	}

	private const int HWND_BROADCAST = 65535;

	private MessageWindow _window;

	public void AddMessage(int msg, MessageEventArg message)
	{
		if (_window == null)
		{
			_window = new MessageWindow();
		}
		_window.AddMessageListener(msg, message);
	}

	public void Dispose()
	{
		if (_window != null)
		{
			_window.Dispose();
			_window = null;
		}
	}

	public static bool PostMessage(int msg, IntPtr wparam, IntPtr lparam)
	{
		return PostMessage((IntPtr)65535, msg, wparam, lparam);
	}

	[DllImport("user32")]
	public static extern int RegisterWindowMessage(string message);

	[DllImport("user32")]
	private static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
}
