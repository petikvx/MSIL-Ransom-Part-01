using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CiscoAnyconnectControl.UI.Utility;

internal abstract class OSUtil : I_OSUtil
{
	private static Lazy<OSUtil> _instance = new Lazy<OSUtil>(delegate
	{
		_003C_003Ec.smethod_1("Environment.OSVersion: {0}", new object[1] { _003C_003Ec.smethod_0() });
		return new WindowsOSUtil();
	});

	public static OSUtil Instance => _instance.Value;

	public event EventHandler TrayIconDoubleClick
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.TrayIconDoubleClick;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)OSUtil.smethod_0((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.TrayIconDoubleClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.TrayIconDoubleClick;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)OSUtil.smethod_1((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.TrayIconDoubleClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler TrayExitClick
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.TrayExitClick;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)OSUtil.smethod_0((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.TrayExitClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.TrayExitClick;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)OSUtil.smethod_1((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.TrayExitClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public abstract bool AddUiToSystemStart();

	public abstract bool RemoveUiFromSystemStart();

	public abstract void ShowTrayIcon();

	public abstract void HideTrayIcon();

	public abstract void DisableCiscoAutostart();

	public abstract void RestoreCiscoAutostart();

	public abstract bool IsCiscoAutostartEnabled();

	public abstract bool IsElevatedProcess();

	protected virtual void OnTrayIconDoubleClick(object sender, EventArgs e)
	{
		this.TrayIconDoubleClick?.Invoke(sender, e);
	}

	protected virtual void OnTrayExitClick(object sender, EventArgs e)
	{
		this.TrayExitClick?.Invoke(sender, e);
	}

	static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_1(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}
}
