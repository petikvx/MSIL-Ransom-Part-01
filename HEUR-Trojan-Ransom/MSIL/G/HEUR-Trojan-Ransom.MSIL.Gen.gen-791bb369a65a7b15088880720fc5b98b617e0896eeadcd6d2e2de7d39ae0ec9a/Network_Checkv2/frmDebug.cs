using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Network_Checkv2.My;

namespace Network_Checkv2;

[DesignerGenerated]
public class frmDebug : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public frmDebug()
	{
		((Form)this).add_Load((EventHandler)frmDebug_Load);
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		components = new Container();
		GroupBox1 = new GroupBox();
		Label12 = new Label();
		Label11 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		Button1 = new Button();
		Timer1 = new Timer(components);
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Location(new Point(16, 13));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(260, 192));
		((Control)GroupBox1).set_TabIndex(2);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Debugging Information");
		Label12.set_AutoSize(true);
		((Control)Label12).set_Location(new Point(90, 158));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(57, 13));
		((Control)Label12).set_TabIndex(11);
		Label12.set_Text("Fail Count:");
		Label11.set_AutoSize(true);
		((Control)Label11).set_ForeColor(Color.Blue);
		((Control)Label11).set_Location(new Point(8, 157));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(60, 13));
		((Control)Label11).set_TabIndex(10);
		Label11.set_Text("Failt Count:");
		Label10.set_AutoSize(true);
		((Control)Label10).set_Location(new Point(90, 104));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(90, 13));
		((Control)Label10).set_TabIndex(9);
		Label10.set_Text("intLogging_Count");
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.Blue);
		((Control)Label9).set_Location(new Point(8, 104));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(59, 13));
		((Control)Label9).set_TabIndex(8);
		Label9.set_Text("Log Count:");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(90, 129));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(42, 13));
		((Control)Label8).set_TabIndex(7);
		Label8.set_Text("dblFails");
		Label7.set_AutoSize(true);
		((Control)Label7).set_ForeColor(Color.Blue);
		((Control)Label7).set_Location(new Point(8, 129));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(55, 13));
		((Control)Label7).set_TabIndex(6);
		Label7.set_Text("Ping Fails:");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(90, 79));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(56, 13));
		((Control)Label6).set_TabIndex(5);
		Label6.set_Text("Ping URL:");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.Blue);
		((Control)Label5).set_Location(new Point(8, 79));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(56, 13));
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("Ping URL:");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(90, 52));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(64, 13));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("Log Events:");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(Color.Blue);
		((Control)Label3).set_Location(new Point(8, 52));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(64, 13));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Log Events:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(90, 26));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(57, 13));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("IntTimeout");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.Blue);
		((Control)Label1).set_Location(new Point(8, 26));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(60, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("IntTimeout:");
		((Control)Button1).set_Location(new Point(201, 228));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("&Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Timer1.set_Interval(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(295, 262));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("frmDebug");
		((Form)this).set_Text("frmDebug");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		((Form)this).Close();
	}

	private void frmDebug_Load(object sender, EventArgs e)
	{
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Interval(500);
		Label2.set_Text(Conversions.ToString(ModBase.intTimeout));
		Label4.set_Text(Conversions.ToString(MyProject.Forms.Form1.LogToolStripMenuItem.get_Checked()));
		Label6.set_Text(MySettingsProperty.Settings.pingURL);
		Label8.set_Text(Conversions.ToString(MyProject.Forms.Form1.dblFails));
		Label10.set_Text(Conversions.ToString(MyProject.Forms.Form1.intLogging_Count));
		Label12.set_Text(Conversions.ToString(MyProject.Forms.Form1.intFail_Count));
	}
}
