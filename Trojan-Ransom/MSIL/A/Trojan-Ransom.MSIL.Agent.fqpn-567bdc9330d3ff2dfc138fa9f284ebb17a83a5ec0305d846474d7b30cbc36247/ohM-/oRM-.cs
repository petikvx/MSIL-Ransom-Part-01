using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ohM_003D;

public class oRM_003D : IDisposable
{
	[Flags]
	internal enum _6RM_003D : uint
	{
		_6hM_003D = 0u,
		_6xM_003D = 1u,
		_7BM_003D = 2u,
		_7RM_003D = 4u,
		_7hM_003D = 8u,
		_7xM_003D = 0x10u,
		_8BM_003D = 0x20u,
		_8RM_003D = 0x40u,
		_8hM_003D = 0x80u,
		_8xM_003D = 0x100u,
		_9BM_003D = 0x1FFu
	}

	private IntPtr oxM_003D;

	public IntPtr pBM_003D;

	private string pRM_003D;

	public string qBM_003D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[DllImport("user32.dll", EntryPoint = "CreateDesktop")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern IntPtr qRM_003D(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, long dwDesiredAccess, IntPtr lpsa);

	[DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern bool qhM_003D(IntPtr hDesktop);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "CloseDesktop", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool qxM_003D(IntPtr handle);

	[DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool rBM_003D(IntPtr hDesktop);

	[DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr rRM_003D(int dwThreadId);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentThreadId")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int rhM_003D();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void rxM_003D()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Dispose(bool fDisposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IDisposable.Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public oRM_003D()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public oRM_003D(string sDesktopName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sBM_003D()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sRM_003D()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IntPtr shM_003D()
	{
		return default(IntPtr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntPtr sxM_003D()
	{
		return default(IntPtr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static oRM_003D()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
	}
}
