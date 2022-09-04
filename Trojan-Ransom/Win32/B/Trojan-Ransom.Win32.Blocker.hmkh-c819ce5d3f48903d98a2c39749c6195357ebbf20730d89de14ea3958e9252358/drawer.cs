using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

[DesignerGenerated]
public sealed class drawer : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("draw")]
	private Timer timer_0;

	public static object tekst = "";

	public drawer()
	{
		((Form)this).add_Load((EventHandler)drawer_Load);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 262);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("drawer");
		((Form)this).set_Text("drawer");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_1)
	{
		EventHandler eventHandler = method_0;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_1;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDC(IntPtr hwnd);

	private void method_0(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		try
		{
			Graphics val = Graphics.FromHdc(GetDC(IntPtr.Zero));
			val.DrawString(Conversions.ToString(tekst), new Font("arial", 25f), Brushes.get_Red(), Conversions.ToSingle(Conversions.ToString(Conversion.Int(VBMath.Rnd() * (float)((Computer)Class1.Class0_0).get_Screen().get_Bounds().Width))), Conversions.ToSingle(Conversions.ToString(Conversion.Int(VBMath.Rnd() * (float)((Computer)Class1.Class0_0).get_Screen().get_Bounds().Height))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void drawer_Load(object sender, EventArgs e)
	{
	}
}
