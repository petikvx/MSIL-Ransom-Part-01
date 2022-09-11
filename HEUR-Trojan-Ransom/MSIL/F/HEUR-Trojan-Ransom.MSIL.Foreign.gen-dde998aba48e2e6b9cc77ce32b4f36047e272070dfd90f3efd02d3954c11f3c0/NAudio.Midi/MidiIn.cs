using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class MidiIn : IDisposable
{
	private IntPtr hMidiIn = IntPtr.Zero;

	private bool disposed;

	private MidiInterop.MidiInCallback callback;

	[NonSerialized]
	internal static GetString _009D;

	public static int NumberOfDevices => MidiInterop.midiInGetNumDevs();

	public event EventHandler<MidiInMessageEventArgs> MessageReceived;

	public event EventHandler<MidiInMessageEventArgs> ErrorReceived;

	public MidiIn(int deviceNo)
	{
		callback = Callback;
		MmException.Try(MidiInterop.midiInOpen(out hMidiIn, (IntPtr)deviceNo, callback, IntPtr.Zero, 196608), _009D(107413119));
	}

	public void Close()
	{
		Dispose();
	}

	public void Dispose()
	{
		GC.KeepAlive(callback);
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public void Start()
	{
		MmException.Try(MidiInterop.midiInStart(hMidiIn), _009D(107413070));
	}

	public void Stop()
	{
		MmException.Try(MidiInterop.midiInStop(hMidiIn), _009D(107413085));
	}

	public void Reset()
	{
		MmException.Try(MidiInterop.midiInReset(hMidiIn), _009D(107413036));
	}

	private void Callback(IntPtr midiInHandle, MidiInterop.MidiInMessage message, IntPtr userData, IntPtr messageParameter1, IntPtr messageParameter2)
	{
		switch (message)
		{
		case MidiInterop.MidiInMessage.Data:
			if (this.MessageReceived != null)
			{
				this.MessageReceived(this, new MidiInMessageEventArgs(messageParameter1.ToInt32(), messageParameter2.ToInt32()));
			}
			break;
		case MidiInterop.MidiInMessage.Error:
			if (this.ErrorReceived != null)
			{
				this.ErrorReceived(this, new MidiInMessageEventArgs(messageParameter1.ToInt32(), messageParameter2.ToInt32()));
			}
			break;
		case MidiInterop.MidiInMessage.Open:
		case MidiInterop.MidiInMessage.Close:
		case MidiInterop.MidiInMessage.LongData:
		case MidiInterop.MidiInMessage.LongError:
		case (MidiInterop.MidiInMessage)967:
		case (MidiInterop.MidiInMessage)968:
		case (MidiInterop.MidiInMessage)969:
		case (MidiInterop.MidiInMessage)970:
		case (MidiInterop.MidiInMessage)971:
		case MidiInterop.MidiInMessage.MoreData:
			break;
		}
	}

	public static MidiInCapabilities DeviceInfo(int midiInDeviceNumber)
	{
		MidiInCapabilities capabilities = default(MidiInCapabilities);
		int size = Marshal.SizeOf((object)capabilities);
		MmException.Try(MidiInterop.midiInGetDevCaps((IntPtr)midiInDeviceNumber, out capabilities, size), _009D(107413051));
		return capabilities;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			MidiInterop.midiInClose(hMidiIn);
		}
		disposed = true;
	}

	~MidiIn()
	{
		Dispose(disposing: false);
	}

	static MidiIn()
	{
		Strings.CreateGetStringDelegate(typeof(MidiIn));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009D(107399193), _009D(107399156)), _009D(107399151), _009D(107399146)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009D(107399173)))
		{
			return;
		}
		throw new SecurityException(_009D(107399116));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
