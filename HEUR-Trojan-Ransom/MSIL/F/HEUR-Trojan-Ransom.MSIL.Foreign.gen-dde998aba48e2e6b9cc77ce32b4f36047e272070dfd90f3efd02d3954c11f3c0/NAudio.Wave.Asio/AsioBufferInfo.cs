using System;
using System.Runtime.InteropServices;

namespace NAudio.Wave.Asio;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
internal struct AsioBufferInfo
{
	public bool isInput;

	public int channelNum;

	public IntPtr pBuffer0;

	public IntPtr pBuffer1;

	public IntPtr Buffer(int bufferIndex)
	{
		if (bufferIndex != 0)
		{
			return pBuffer1;
		}
		return pBuffer0;
	}
}
