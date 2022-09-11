using System;
using System.Runtime.InteropServices;

namespace NAudio.Wave.Compression;

[StructLayout(LayoutKind.Sequential, Size = 128)]
internal sealed class AcmStreamHeaderStruct
{
	public int cbStruct;

	public AcmStreamHeaderStatusFlags fdwStatus;

	public IntPtr userData;

	public IntPtr sourceBufferPointer;

	public int sourceBufferLength;

	public int sourceBufferLengthUsed;

	public IntPtr sourceUserData;

	public IntPtr destBufferPointer;

	public int destBufferLength;

	public int destBufferLengthUsed;

	public IntPtr destUserData;
}
