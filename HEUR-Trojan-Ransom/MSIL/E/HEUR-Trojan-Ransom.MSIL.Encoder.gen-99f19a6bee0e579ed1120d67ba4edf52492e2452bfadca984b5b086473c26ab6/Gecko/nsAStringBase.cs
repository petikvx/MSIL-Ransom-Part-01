using System;
using System.Runtime.InteropServices;

namespace Gecko;

public abstract class nsAStringBase : IDisposable, IString
{
	private IntPtr _container;

	public IntPtr Container
	{
		get
		{
			if (_container == IntPtr.Zero)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			return _container;
		}
	}

	protected bool IsDisposed => _container == IntPtr.Zero;

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	protected static extern int NS_StringContainerInit(IntPtr container);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	protected static extern int NS_StringGetData(IntPtr str, out IntPtr data, [MarshalAs(UnmanagedType.U1)] out bool nullTerm);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	protected static extern int NS_StringContainerFinish(IntPtr container);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	protected static extern bool NS_StringGetIsVoid(IntPtr str);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	protected static extern void NS_StringSetIsVoid(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool isVoid);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	protected static extern int NS_StringSetData(IntPtr aAString, string data, int length);

	protected nsAStringBase(IntPtr container)
	{
		_container = container;
	}

	~nsAStringBase()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		_container = IntPtr.Zero;
	}

	public virtual void SetData(string value)
	{
		if (value != null)
		{
			NS_StringSetData(Container, value, value.Length);
		}
		else
		{
			NS_StringSetIsVoid(Container, isVoid: true);
		}
	}

	public override string ToString()
	{
		if (IsDisposed)
		{
			return GetType().Name;
		}
		IntPtr data;
		bool nullTerm;
		int num = NS_StringGetData(Container, out data, out nullTerm);
		if (num > 0)
		{
			return Marshal.PtrToStringUni(data, num);
		}
		if (NS_StringGetIsVoid(Container))
		{
			return null;
		}
		return string.Empty;
	}
}
