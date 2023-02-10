using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using g2H;

namespace z0R2;

[DesignerGenerated]
public class x0S9 : Form
{
	private IContainer components;

	private DateTime timeof;

	private object crrYera;

	private object tims;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCurrentYear")]
	internal virtual Label lblCurrentYear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressLoader")]
	internal virtual ProgressBar ProgressLoader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer splashTimer
	{
		[CompilerGenerated]
		get
		{
			return _splashTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Sk2e;
			Timer val = _splashTimer;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_splashTimer = value;
			val = _splashTimer;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblWait")]
	internal virtual Label lblWait
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public x0S9()
	{
		((Form)this).add_Load((EventHandler)Pe3j);
		timeof = DateAndTime.get_TimeOfDay();
		crrYera = DateTime.Now.ToString("yyyy");
		tims = DateTime.Now.ToString("s");
		Wq90();
	}

	[DebuggerNonUserCode]
	protected override void Dr93(bool q1E4)
	{
		try
		{
			if (q1E4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q1E4);
		}
	}

	[DebuggerStepThrough]
	private void Wq90()
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
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		Panel1 = new Panel();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		lblCurrentYear = new Label();
		ProgressLoader = new ProgressBar();
		splashTimer = new Timer(components);
		lblWait = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Century Gothic", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(255, 108, 16));
		((Control)Label1).set_Location(new Point(215, 220));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(361, 32));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Powered by Mercy Gwara");
		((Control)Panel1).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)Panel1).set_ForeColor(Color.DarkOrange);
		((Control)Panel1).set_Location(new Point(197, 267));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(393, 4));
		((Control)Panel1).set_TabIndex(1);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		((Control)PictureBox1).set_Location(new Point(314, 47));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(146, 104));
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Century Gothic", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.FromArgb(255, 108, 16));
		((Control)Label2).set_Location(new Point(274, 291));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(218, 22));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Copyright all Reserved");
		lblCurrentYear.set_AutoSize(true);
		((Control)lblCurrentYear).set_Font(new Font("Century Gothic", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblCurrentYear).set_ForeColor(Color.FromArgb(255, 108, 16));
		((Control)lblCurrentYear).set_Location(new Point(338, 353));
		((Control)lblCurrentYear).set_Name("lblCurrentYear");
		((Control)lblCurrentYear).set_Size(new Size(85, 22));
		((Control)lblCurrentYear).set_TabIndex(4);
		lblCurrentYear.set_Text("(c) 2034");
		((Control)ProgressLoader).set_Location(new Point(-3, 429));
		((Control)ProgressLoader).set_Name("ProgressLoader");
		((Control)ProgressLoader).set_Size(new Size(806, 23));
		((Control)ProgressLoader).set_TabIndex(5);
		((Control)ProgressLoader).set_Visible(false);
		lblWait.set_AutoSize(true);
		((Control)lblWait).set_Font(new Font("Century Gothic", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblWait).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)lblWait).set_Location(new Point(326, 169));
		((Control)lblWait).set_Name("lblWait");
		((Control)lblWait).set_Size(new Size(125, 23));
		((Control)lblWait).set_TabIndex(6);
		lblWait.set_Text("Please wait..");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(800, 507));
		((Control)this).get_Controls().Add((Control)(object)lblWait);
		((Control)this).get_Controls().Add((Control)(object)ProgressLoader);
		((Control)this).get_Controls().Add((Control)(object)lblCurrentYear);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("SplashScreen");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Pe3j(object b5CY, EventArgs Lp30)
	{
		lblCurrentYear.set_Text(Conversions.ToString(Operators.AddObject((object)"(c)", crrYera)));
		splashTimer.set_Enabled(true);
		((Control)lblWait).set_Visible(true);
	}

	private void Fk54(object m2P3, PaintEventArgs x2P7)
	{
	}

	private void Sk2e(object x5X4, EventArgs j7G0)
	{
		ProgressLoader.Increment(1);
		if (ProgressLoader.get_Value() == 100)
		{
			splashTimer.Stop();
			((Control)Gw5.Forms.LoginForm).Show();
			((Control)this).Hide();
		}
	}
}
