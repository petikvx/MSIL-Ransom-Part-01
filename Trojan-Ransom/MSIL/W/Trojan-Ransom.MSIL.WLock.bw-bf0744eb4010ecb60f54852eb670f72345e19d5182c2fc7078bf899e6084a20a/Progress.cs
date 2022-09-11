using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Progress : Form
{
	private IContainer components;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	public int ProgressBarValue
	{
		get
		{
			return ProgressBar1.get_Value();
		}
		set
		{
			ProgressBar1.set_Value(value);
			((Form)this).set_TopMost(false);
		}
	}

	public Progress()
	{
		((Form)this).add_Load((EventHandler)Progress_Load);
		((Control)this).add_VisibleChanged((EventHandler)Progress_VisibleChanged);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		components = new Container();
		ProgressBar1 = new ProgressBar();
		Label1 = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)ProgressBar1).set_BackColor(Color.Black);
		ProgressBar progressBar = ProgressBar1;
		Point location = new Point(103, 9);
		((Control)progressBar).set_Location(location);
		ProgressBar1.set_MarqueeAnimationSpeed(1000);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		Size size = new Size(265, 14);
		((Control)progressBar2).set_Size(size);
		ProgressBar1.set_Style((ProgressBarStyle)1);
		((Control)ProgressBar1).set_TabIndex(1);
		Label label = Label1;
		location = new Point(12, 8);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(85, 15);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Компиляция");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(380, 30);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Progress");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Progress");
		((Control)this).ResumeLayout(false);
	}

	private void Progress_Load(object sender, EventArgs e)
	{
	}

	private void Progress_VisibleChanged(object sender, EventArgs e)
	{
		((Form)this).set_TopMost(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.Stop();
	}
}
