using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class MidiOut : IDisposable
{
	private IntPtr hMidiOut = IntPtr.Zero;

	private bool disposed;

	private MidiInterop.MidiOutCallback callback;

	[NonSerialized]
	internal static GetString _0003;

	public static int NumberOfDevices => MidiInterop.midiOutGetNumDevs();

	public int Volume
	{
		get
		{
			int lpdwVolume = 0;
			MmException.Try(MidiInterop.midiOutGetVolume(hMidiOut, ref lpdwVolume), _0003(107413374));
			return lpdwVolume;
		}
		set
		{
			MmException.Try(MidiInterop.midiOutSetVolume(hMidiOut, value), _0003(107413381));
		}
	}

	public static MidiOutCapabilities DeviceInfo(int midiOutDeviceNumber)
	{
		MidiOutCapabilities caps = default(MidiOutCapabilities);
		int uSize = Marshal.SizeOf((object)caps);
		MmException.Try(MidiInterop.midiOutGetDevCaps((IntPtr)midiOutDeviceNumber, out caps, uSize), _0003(107413448));
		return caps;
	}

	public MidiOut(int deviceNo)
	{
		callback = Callback;
		MmException.Try(MidiInterop.midiOutOpen(out hMidiOut, (IntPtr)deviceNo, callback, IntPtr.Zero, 196608), _0003(107413423));
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

	public void Reset()
	{
		MmException.Try(MidiInterop.midiOutReset(hMidiOut), _0003(107413356));
	}

	public void SendDriverMessage(int message, int param1, int param2)
	{
		MmException.Try(MidiInterop.midiOutMessage(hMidiOut, message, (IntPtr)param1, (IntPtr)param2), _0003(107413307));
	}

	public void Send(int message)
	{
		MmException.Try(MidiInterop.midiOutShortMsg(hMidiOut, message), _0003(107413318));
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			MidiInterop.midiOutClose(hMidiOut);
		}
		disposed = true;
	}

	private void Callback(IntPtr midiInHandle, MidiInterop.MidiOutMessage message, IntPtr userData, IntPtr messageParameter1, IntPtr messageParameter2)
	{
	}

	public void SendBuffer(byte[] byteBuffer)
	{
		MidiInterop.MIDIHDR lpMidiOutHdr = default(MidiInterop.MIDIHDR);
		lpMidiOutHdr.lpData = Marshal.AllocHGlobal(byteBuffer.Length);
		Marshal.Copy(byteBuffer, 0, lpMidiOutHdr.lpData, byteBuffer.Length);
		lpMidiOutHdr.dwBufferLength = byteBuffer.Length;
		lpMidiOutHdr.dwBytesRecorded = byteBuffer.Length;
		int uSize = Marshal.SizeOf((object)lpMidiOutHdr);
		MidiInterop.midiOutPrepareHeader(hMidiOut, ref lpMidiOutHdr, uSize);
		if (MidiInterop.midiOutLongMsg(hMidiOut, ref lpMidiOutHdr, uSize) != 0)
		{
			MidiInterop.midiOutUnprepareHeader(hMidiOut, ref lpMidiOutHdr, uSize);
		}
		Marshal.FreeHGlobal(lpMidiOutHdr.lpData);
	}

	~MidiOut()
	{
		Dispose(disposing: false);
	}

	static MidiOut()
	{
		Strings.CreateGetStringDelegate(typeof(MidiOut));
	}
}
