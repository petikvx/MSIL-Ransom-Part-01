using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class nsACStringBase : IString
{
	private IntPtr mData;

	private int mLength;

	private int mFlags;

	protected nsACStringBase()
	{
	}

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	protected static extern int NS_CStringContainerInit(nsACStringBase container);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	protected static extern int NS_CStringSetData(nsACStringBase str, byte[] data, int length);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	protected internal static extern int NS_CStringGetData(nsACStringBase str, out IntPtr data, IntPtr nullTerm);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	protected static extern int NS_CStringContainerFinish(nsACStringBase container);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.Bool)]
	protected static extern bool NS_CStringGetIsVoid(nsACStringBase str);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	protected static extern void NS_CStringSetIsVoid(nsACStringBase str, [MarshalAs(UnmanagedType.Bool)] bool isVoid);

	public virtual void SetData(string value)
	{
		if (value != null)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			NS_CStringSetData(this, bytes, bytes.Length);
		}
		else
		{
			NS_CStringSetIsVoid(this, isVoid: true);
		}
	}

	public byte[] GetRawData()
	{
		IntPtr data;
		int num = NS_CStringGetData(this, out data, IntPtr.Zero);
		byte[] array = new byte[num];
		if (num > 0)
		{
			Marshal.Copy(data, array, 0, num);
		}
		return array;
	}

	public override string ToString()
	{
		IntPtr data;
		int num = NS_CStringGetData(this, out data, IntPtr.Zero);
		if (num > 0)
		{
			byte[] array = new byte[num];
			Marshal.Copy(data, array, 0, num);
			return Encoding.UTF8.GetString(array);
		}
		if (NS_CStringGetIsVoid(this))
		{
			return null;
		}
		return string.Empty;
	}
}
