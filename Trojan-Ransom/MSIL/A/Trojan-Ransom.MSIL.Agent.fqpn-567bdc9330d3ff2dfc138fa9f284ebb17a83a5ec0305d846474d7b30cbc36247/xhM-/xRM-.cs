using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace xhM_003D;

public class xRM_003D : Form
{
	private int xxM_003D;

	private const int yBM_003D = 0;

	private const int yRM_003D = 5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler Shown;

	private IContainer yhM_003D;

	private Label yxM_003D;

	private Label zBM_003D;

	private Label zRM_003D;

	private Label zhM_003D;

	private Label zxM_003D;

	private Label _0BM_003D;

	private PictureBox _0RM_003D;

	private PictureBox _0hM_003D;

	private Timer _0xM_003D;

	private Label _1BM_003D;

	private RichTextBox _1RM_003D;

	private Label _1hM_003D;

	public event EventHandler _2RM_003D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public xRM_003D()
	{
	}

	[DllImport("User32", EntryPoint = "ShowWindow")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern int _2hM_003D(int hwnd, int nCmdShow);

	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "DeleteFile", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool _2xM_003D(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _3BM_003D(string path)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _3RM_003D(string fileName)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _3hM_003D(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _3xM_003D(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _4BM_003D()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static xRM_003D()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
	}
}
