using System;
using System.Runtime.InteropServices;

namespace MySql.Data.MySqlClient.Authentication;

internal struct SecBufferDesc : IDisposable
{
	public int ulVersion;

	public int cBuffers;

	public IntPtr pBuffers;

	public SecBufferDesc(int bufferSize)
	{
		ulVersion = 0;
		cBuffers = 1;
		SecBuffer structure = new SecBuffer(bufferSize);
		pBuffers = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
		Marshal.StructureToPtr(structure, pBuffers, fDeleteOld: false);
	}

	public SecBufferDesc(byte[] secBufferBytes)
	{
		ulVersion = 0;
		cBuffers = 1;
		SecBuffer structure = new SecBuffer(secBufferBytes);
		pBuffers = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
		Marshal.StructureToPtr(structure, pBuffers, fDeleteOld: false);
	}

	public void Dispose()
	{
		if (pBuffers != IntPtr.Zero)
		{
			Marshal.PtrToStructure<SecBuffer>(pBuffers)!.Dispose();
			Marshal.FreeHGlobal(pBuffers);
			pBuffers = IntPtr.Zero;
		}
	}

	public byte[] GetSecBufferByteArray()
	{
		byte[] array = null;
		if (pBuffers == IntPtr.Zero)
		{
			throw new InvalidOperationException("Object has already been disposed!!!");
		}
		SecBuffer secBuffer = Marshal.PtrToStructure<SecBuffer>(pBuffers);
		if (secBuffer.cbBuffer > 0)
		{
			array = new byte[secBuffer.cbBuffer];
			Marshal.Copy(secBuffer.pvBuffer, array, 0, secBuffer.cbBuffer);
		}
		return array;
	}
}
