using System;
using System.Runtime.InteropServices;

namespace NAudio.Midi;

internal sealed class MidiInterop
{
	public enum MidiInMessage
	{
		Open = 961,
		Close = 962,
		Data = 963,
		LongData = 964,
		Error = 965,
		LongError = 966,
		MoreData = 972
	}

	public enum MidiOutMessage
	{
		Open = 967,
		Close,
		Done
	}

	public delegate void MidiInCallback(IntPtr midiInHandle, MidiInMessage message, IntPtr userData, IntPtr messageParameter1, IntPtr messageParameter2);

	public delegate void MidiOutCallback(IntPtr midiInHandle, MidiOutMessage message, IntPtr userData, IntPtr messageParameter1, IntPtr messageParameter2);

	public struct MMTIME
	{
		public int wType;

		public int u;
	}

	public struct MIDIEVENT
	{
		public int dwDeltaTime;

		public int dwStreamID;

		public int dwEvent;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public int dwParms;
	}

	public struct MIDIHDR
	{
		public IntPtr lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public IntPtr dwUser;

		public int dwFlags;

		public IntPtr lpNext;

		public IntPtr reserved;

		public int dwOffset;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public IntPtr[] dwReserved;
	}

	public struct MIDIPROPTEMPO
	{
		public int cbStruct;

		public int dwTempo;
	}

	public const int CALLBACK_FUNCTION = 196608;

	public const int CALLBACK_NULL = 0;

	[DllImport("winmm.dll")]
	public static extern MmResult midiConnect(IntPtr hMidiIn, IntPtr hMidiOut, IntPtr pReserved);

	[DllImport("winmm.dll")]
	public static extern MmResult midiDisconnect(IntPtr hMidiIn, IntPtr hMidiOut, IntPtr pReserved);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInAddBuffer(IntPtr hMidiIn, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR lpMidiInHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInClose(IntPtr hMidiIn);

	[DllImport("winmm.dll", CharSet = CharSet.Auto)]
	public static extern MmResult midiInGetDevCaps(IntPtr deviceId, out MidiInCapabilities capabilities, int size);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInGetErrorText(int err, string lpText, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInGetID(IntPtr hMidiIn, out int lpuDeviceId);

	[DllImport("winmm.dll")]
	public static extern int midiInGetNumDevs();

	[DllImport("winmm.dll")]
	public static extern MmResult midiInMessage(IntPtr hMidiIn, int msg, IntPtr dw1, IntPtr dw2);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInOpen(out IntPtr hMidiIn, IntPtr uDeviceID, MidiInCallback callback, IntPtr dwInstance, int dwFlags);

	[DllImport("winmm.dll", EntryPoint = "midiInOpen")]
	public static extern MmResult midiInOpenWindow(out IntPtr hMidiIn, IntPtr uDeviceID, IntPtr callbackWindowHandle, IntPtr dwInstance, int dwFlags);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInPrepareHeader(IntPtr hMidiIn, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR lpMidiInHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInReset(IntPtr hMidiIn);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInStart(IntPtr hMidiIn);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInStop(IntPtr hMidiIn);

	[DllImport("winmm.dll")]
	public static extern MmResult midiInUnprepareHeader(IntPtr hMidiIn, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR lpMidiInHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutCacheDrumPatches(IntPtr hMidiOut, int uPatch, IntPtr lpKeyArray, int uFlags);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutCachePatches(IntPtr hMidiOut, int uBank, IntPtr lpPatchArray, int uFlags);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutClose(IntPtr hMidiOut);

	[DllImport("winmm.dll", CharSet = CharSet.Auto)]
	public static extern MmResult midiOutGetDevCaps(IntPtr deviceNumber, out MidiOutCapabilities caps, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutGetErrorText(IntPtr err, string lpText, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutGetID(IntPtr hMidiOut, out int lpuDeviceID);

	[DllImport("winmm.dll")]
	public static extern int midiOutGetNumDevs();

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutGetVolume(IntPtr uDeviceID, ref int lpdwVolume);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutLongMsg(IntPtr hMidiOut, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR lpMidiOutHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutMessage(IntPtr hMidiOut, int msg, IntPtr dw1, IntPtr dw2);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutOpen(out IntPtr lphMidiOut, IntPtr uDeviceID, MidiOutCallback dwCallback, IntPtr dwInstance, int dwFlags);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutPrepareHeader(IntPtr hMidiOut, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR lpMidiOutHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutReset(IntPtr hMidiOut);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutSetVolume(IntPtr hMidiOut, int dwVolume);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutShortMsg(IntPtr hMidiOut, int dwMsg);

	[DllImport("winmm.dll")]
	public static extern MmResult midiOutUnprepareHeader(IntPtr hMidiOut, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR lpMidiOutHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamClose(IntPtr hMidiStream);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamOpen(out IntPtr hMidiStream, IntPtr puDeviceID, int cMidi, IntPtr dwCallback, IntPtr dwInstance, int fdwOpen);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamOut(IntPtr hMidiStream, [MarshalAs(UnmanagedType.Struct)] ref MIDIHDR pmh, int cbmh);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamPause(IntPtr hMidiStream);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamPosition(IntPtr hMidiStream, [MarshalAs(UnmanagedType.Struct)] ref MMTIME lpmmt, int cbmmt);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamProperty(IntPtr hMidiStream, IntPtr lppropdata, int dwProperty);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamRestart(IntPtr hMidiStream);

	[DllImport("winmm.dll")]
	public static extern MmResult midiStreamStop(IntPtr hMidiStream);
}
