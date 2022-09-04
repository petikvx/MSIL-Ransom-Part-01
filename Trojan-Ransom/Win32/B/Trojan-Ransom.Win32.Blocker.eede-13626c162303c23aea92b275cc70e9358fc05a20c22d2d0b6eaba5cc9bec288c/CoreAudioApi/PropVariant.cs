using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

[StructLayout(LayoutKind.Explicit)]
public struct PropVariant
{
	[FieldOffset(0)]
	private short vt;

	[FieldOffset(2)]
	private short wReserved1;

	[FieldOffset(4)]
	private short wReserved2;

	[FieldOffset(6)]
	private short wReserved3;

	[FieldOffset(8)]
	private sbyte cVal;

	[FieldOffset(8)]
	private byte bVal;

	[FieldOffset(8)]
	private short iVal;

	[FieldOffset(8)]
	private ushort uiVal;

	[FieldOffset(8)]
	private int lVal;

	[FieldOffset(8)]
	private uint ulVal;

	[FieldOffset(8)]
	private long hVal;

	[FieldOffset(8)]
	private ulong uhVal;

	[FieldOffset(8)]
	private float fltVal;

	[FieldOffset(8)]
	private double dblVal;

	[FieldOffset(8)]
	private Blob blobVal;

	[FieldOffset(8)]
	private DateTime date;

	[FieldOffset(8)]
	private bool boolVal;

	[FieldOffset(8)]
	private int scode;

	[FieldOffset(8)]
	private FILETIME filetime;

	[FieldOffset(8)]
	private IntPtr everything_else;

	public object Value
	{
		get
		{
			VarEnum varEnum = (VarEnum)vt;
			return varEnum switch
			{
				VarEnum.VT_I1 => bVal, 
				VarEnum.VT_UI4 => ulVal, 
				VarEnum.VT_I8 => hVal, 
				VarEnum.VT_INT => iVal, 
				VarEnum.VT_I2 => iVal, 
				VarEnum.VT_I4 => lVal, 
				VarEnum.VT_BLOB => GetBlob(), 
				VarEnum.VT_LPWSTR => Marshal.PtrToStringUni(everything_else), 
				_ => "FIXME Type = " + varEnum, 
			};
		}
	}

	internal byte[] GetBlob()
	{
		byte[] array = new byte[blobVal.Length];
		for (int i = 0; i < blobVal.Length; i++)
		{
			array[i] = Marshal.ReadByte((IntPtr)((long)blobVal.Data + i));
		}
		return array;
	}
}
