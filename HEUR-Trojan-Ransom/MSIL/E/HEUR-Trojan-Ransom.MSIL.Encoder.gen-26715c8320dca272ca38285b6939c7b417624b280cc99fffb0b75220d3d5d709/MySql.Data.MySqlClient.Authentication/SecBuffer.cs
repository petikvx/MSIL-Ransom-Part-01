using System;
using System.Runtime.InteropServices;

namespace MySql.Data.MySqlClient.Authentication;

public struct SecBuffer : IDisposable
{
	public int cbBuffer;

	public int BufferType;

	public IntPtr pvBuffer;

	public SecBuffer(int bufferSize)
	{
		cbBuffer = bufferSize;
		BufferType = 2;
		pvBuffer = Marshal.AllocHGlobal(bufferSize);
	}

	public SecBuffer(byte[] secBufferBytes)
	{
		cbBuffer = secBufferBytes.Length;
		BufferType = 2;
		pvBuffer = Marshal.AllocHGlobal(cbBuffer);
		Marshal.Copy(secBufferBytes, 0, pvBuffer, cbBuffer);
	}

	public SecBuffer(byte[] secBufferBytes, SecBufferType bufferType)
	{
		cbBuffer = secBufferBytes.Length;
		BufferType = (int)bufferType;
		pvBuffer = Marshal.AllocHGlobal(cbBuffer);
		Marshal.Copy(secBufferBytes, 0, pvBuffer, cbBuffer);
	}

	public void Dispose()
	{
		if (pvBuffer != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(pvBuffer);
			pvBuffer = IntPtr.Zero;
		}
	}
}
