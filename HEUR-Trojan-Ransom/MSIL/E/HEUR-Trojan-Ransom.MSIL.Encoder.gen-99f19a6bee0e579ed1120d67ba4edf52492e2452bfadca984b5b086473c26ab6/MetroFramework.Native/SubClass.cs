using System;
using System.Security;
using System.Windows.Forms;

namespace MetroFramework.Native;

[SuppressUnmanagedCodeSecurity]
internal class SubClass : NativeWindow
{
	public delegate int SubClassWndProcEventHandler(ref Message m);

	private bool IsSubClassed;

	public bool SubClassed
	{
		get
		{
			return IsSubClassed;
		}
		set
		{
			IsSubClassed = value;
		}
	}

	public event SubClassWndProcEventHandler SubClassedWndProc;

	public SubClass(IntPtr Handle, bool _SubClass)
	{
		((NativeWindow)this).AssignHandle(Handle);
		IsSubClassed = _SubClass;
	}

	protected override void WndProc(ref Message m)
	{
		if (!IsSubClassed || OnSubClassedWndProc(ref m) == 0)
		{
			((NativeWindow)this).WndProc(ref m);
		}
	}

	public void CallDefaultWndProc(ref Message m)
	{
		((NativeWindow)this).WndProc(ref m);
	}

	public int HiWord(int Number)
	{
		return (Number >> 16) & 0xFFFF;
	}

	public int LoWord(int Number)
	{
		return Number & 0xFFFF;
	}

	public int MakeLong(int LoWord, int HiWord)
	{
		return (HiWord << 16) | (LoWord & 0xFFFF);
	}

	public IntPtr MakeLParam(int LoWord, int HiWord)
	{
		return (IntPtr)((HiWord << 16) | (LoWord & 0xFFFF));
	}

	private int OnSubClassedWndProc(ref Message m)
	{
		if (this.SubClassedWndProc != null)
		{
			return this.SubClassedWndProc(ref m);
		}
		return 0;
	}
}
