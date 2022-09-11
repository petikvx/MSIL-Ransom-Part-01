using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal sealed class WaveWindow : Form
{
	private WaveInterop.WaveCallback waveCallback;

	[NonSerialized]
	internal static GetString _0086;

	public WaveWindow(WaveInterop.WaveCallback waveCallback)
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
			((Form)this).WndProc(ref m);
			break;
		}
	}

	static WaveWindow()
	{
		Strings.CreateGetStringDelegate(typeof(WaveWindow));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0086(107397890), _0086(107397853)), _0086(107397848), _0086(107397843)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0086(107397870)))
		{
			return;
		}
		throw new SecurityException(_0086(107397813));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
