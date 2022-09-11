using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NAudio.Wave;

internal sealed class WaveWindowNative : NativeWindow
{
	private WaveInterop.WaveCallback waveCallback;

	public WaveWindowNative(WaveInterop.WaveCallback waveCallback)
	{
		this.waveCallback = waveCallback;
	}

	protected override void WndProc(ref Message m)
	{
		WaveInterop.WaveMessage msg = (WaveInterop.WaveMessage)((Message)(ref m)).get_Msg();
		switch (msg)
		{
		case WaveInterop.WaveMessage.WaveOutDone:
		case WaveInterop.WaveMessage.WaveInData:
		{
			IntPtr wParam = ((Message)(ref m)).get_WParam();
			WaveHeader waveHeader = new WaveHeader();
			Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), (object)waveHeader);
			waveCallback(wParam, msg, IntPtr.Zero, waveHeader, IntPtr.Zero);
			break;
		}
		case WaveInterop.WaveMessage.WaveOutOpen:
		case WaveInterop.WaveMessage.WaveOutClose:
		case WaveInterop.WaveMessage.WaveInOpen:
		case WaveInterop.WaveMessage.WaveInClose:
			waveCallback(((Message)(ref m)).get_WParam(), msg, IntPtr.Zero, null, IntPtr.Zero);
			break;
		default:
			((NativeWindow)this).WndProc(ref m);
			break;
		}
	}
}
