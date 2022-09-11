using System;

namespace NAudio.Wave;

public sealed class WaveInEventArgs : EventArgs
{
	private byte[] buffer;

	private int bytes;

	public byte[] Buffer => buffer;

	public int BytesRecorded => bytes;

	public WaveInEventArgs(byte[] buffer, int bytes)
	{
		this.buffer = buffer;
		this.bytes = bytes;
	}
}
