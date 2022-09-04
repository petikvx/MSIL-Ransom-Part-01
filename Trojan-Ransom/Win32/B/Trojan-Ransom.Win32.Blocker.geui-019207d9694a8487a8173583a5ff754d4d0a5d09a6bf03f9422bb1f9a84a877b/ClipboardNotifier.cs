using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class ClipboardNotifier : NativeWindow, IDisposable
{
	public delegate void ChangedEventHandler(object sender, ClipboardEventArgs e);

	public class ClipboardEventArgs : EventArgs
	{
		public object Object;

		public DataType Type;

		public Window Window;

		public DateTime DateTime;

		public ClipboardEventArgs(object Object, DataType Type, Window Window, DateTime DateTime)
		{
			this.Object = RuntimeHelpers.GetObjectValue(Object);
			this.Type = Type;
			this.Window = Window;
			this.DateTime = DateTime;
		}

		public override string ToString()
		{
			return Object.ToString();
		}
	}

	public class Window
	{
		public string Name;

		public IntPtr Handle;

		public bool Changed;

		public Process Process;

		public Window(string Name, IntPtr Handle, bool Changed, Process Process)
		{
			this.Name = Name;
			this.Handle = Handle;
			this.Changed = Changed;
			this.Process = Process;
		}
	}

	public enum DataType
	{
		Text,
		Image,
		Audio
	}

	private ChangedEventHandler ChangedEvent;

	private IntPtr id;

	private IntPtr tempHandle;

	private bool disposedValue;

	public bool IsRunning => id != IntPtr.Zero;

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

	public ClipboardNotifier()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		id = IntPtr.Zero;
		tempHandle = IntPtr.Zero;
		((NativeWindow)this).CreateHandle(new CreateParams());
	}

	public void Start()
	{
		API.SetClipboardViewer(((NativeWindow)this).get_Handle());
	}

	public void Stop()
	{
		API.ChangeClipboardChain(((NativeWindow)this).get_Handle(), id);
		id = IntPtr.Zero;
	}

	public void Clear()
	{
		Clipboard.Clear();
	}

	public void ResetTitle()
	{
		tempHandle = IntPtr.Zero;
	}

	public Window CurrentWindow()
	{
		return GetCurrentWindow();
	}

	public void SetText(string Text)
	{
		Clipboard.SetText(Text);
	}

	public void SetImage(Image Image)
	{
		Clipboard.SetImage(Image);
	}

	public void SetAudio(Stream Stream)
	{
		Clipboard.SetAudio(Stream);
	}

	protected override void WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		case 776:
			RaiseEvents();
			API.SendMessage(id, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			break;
		case 781:
			if (((Message)(ref m)).get_WParam() == id)
			{
				id = ((Message)(ref m)).get_LParam();
			}
			else
			{
				API.SendMessage(id, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			}
			break;
		}
		((NativeWindow)this).WndProc(ref m);
	}

	private void RaiseEvents()
	{
		object obj = null;
		DataType type = DataType.Text;
		Window currentWindow = GetCurrentWindow();
		DateTime messageDate = GetMessageDate(API.GetMessageTime());
		bool flag = true;
		if (Clipboard.ContainsText())
		{
			type = DataType.Text;
			obj = Clipboard.GetText();
			if (string.IsNullOrEmpty(obj.ToString()))
			{
				return;
			}
		}
		else if (flag == Clipboard.ContainsImage())
		{
			type = DataType.Image;
			obj = Clipboard.GetImage();
		}
		else if (flag == Clipboard.ContainsAudio())
		{
			type = DataType.Audio;
			obj = Clipboard.GetAudioStream();
		}
		if (obj != null)
		{
			ChangedEvent?.Invoke(this, new ClipboardEventArgs(RuntimeHelpers.GetObjectValue(obj), type, currentWindow, messageDate));
		}
	}

	private Window GetCurrentWindow()
	{
		IntPtr intPtr = API.GetForegroundWindow();
		bool changed = tempHandle != intPtr;
		string name = string.Empty;
		Process process = new Process();
		StringBuilder stringBuilder = new StringBuilder(256);
		if (API.GetWindowText(intPtr, stringBuilder, 256) > 0)
		{
			name = stringBuilder.ToString();
		}
		try
		{
			int lpdwProcessId = 0;
			API.GetWindowThreadProcessId(intPtr, ref lpdwProcessId);
			process = Process.GetProcessById(lpdwProcessId);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		tempHandle = intPtr;
		return new Window(name, intPtr, changed, process);
	}

	private DateTime GetMessageDate(double messageTime)
	{
		DateTime now = DateTime.Now;
		TimeSpan value = new TimeSpan(checked((long)Math.Round((double)Environment.TickCount + messageTime)));
		return now.Subtract(value);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			Stop();
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
