using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Es9r;
using Jq7;
using Microsoft.VisualBasic.CompilerServices;
using c9N;

namespace r6N;

[DesignerGenerated]
public class Te7 : Form
{
	private IContainer components;

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Zr7);
			Panel panel = _Panel1;
			if (panel != null)
			{
				((Control)panel).remove_Paint(val);
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				((Control)panel).add_Paint(val);
			}
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f6A;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
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
			EventHandler eventHandler = f8A;
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

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wy6;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).add_Click(eventHandler);
			}
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[CompilerGenerated]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = y3Y;
			ProgressBar progressBar = _ProgressBar1;
			if (progressBar != null)
			{
				((Control)progressBar).remove_Click(eventHandler);
			}
			_ProgressBar1 = value;
			progressBar = _ProgressBar1;
			if (progressBar != null)
			{
				((Control)progressBar).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = y2J;
			Label label = _Label2;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Rz6;
			Label label = _Label3;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	public Te7()
	{
		((Form)this).add_Load((EventHandler)z4S);
		Qz4();
	}

	private void z4S(object sender, EventArgs e)
	{
	}

	private void f6A(object sender, EventArgs e)
	{
	}

	private void Wy4(object sender, EventArgs e)
	{
	}

	private void f8A(object sender, EventArgs e)
	{
		ProgressBar1.set_Value(checked(ProgressBar1.get_Value() + 1));
		Label2.set_Text(ProgressBar1.get_Value() + "%");
		if (ProgressBar1.get_Value() >= 100)
		{
			Timer1.set_Enabled(false);
			((Control)We04.Forms.LoginForm1).Show();
			((Form)this).Close();
		}
	}

	private void y3Y(object sender, EventArgs e)
	{
	}

	private void Wy6(object sender, EventArgs e)
	{
	}

	[STAThread]
	public static void Xk4()
	{
		try
		{
			if (Dj8.Fo2(2) && Dj8.Zq3())
			{
				p6S.d2Q(1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Environment.Exit(Environment.ExitCode);
			ProjectData.ClearProjectError();
		}
	}

	private void y2J(object sender, EventArgs e)
	{
	}

	private void Rz6(object sender, EventArgs e)
	{
	}

	private void Zr7(object sender, PaintEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	protected override void t3C(bool z5L)
	{
		try
		{
			if (z5L && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z5L);
		}
	}

	[DebuggerStepThrough]
	private void Qz4()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Te7));
		Panel1 = new Panel();
		Label1 = new Label();
		Timer1 = new Timer(components);
		PictureBox1 = new PictureBox();
		ProgressBar1 = new ProgressBar();
		Label2 = new Label();
		Label3 = new Label();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(652, 48));
		((Control)Panel1).set_TabIndex(0);
		((Control)Label1).set_BackColor(Color.SkyBlue);
		((Control)Label1).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(-3, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(652, 48));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("STUDENT INFORMATION MANAGEMENT");
		Label1.set_TextAlign((ContentAlignment)32);
		Timer1.set_Enabled(true);
		((Control)PictureBox1).set_BackColor(SystemColors.ButtonFace);
		((Control)PictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		((Control)PictureBox1).set_Location(new Point(0, 47));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(649, 335));
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		((Control)ProgressBar1).set_Location(new Point(0, 416));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(622, 20));
		((Control)ProgressBar1).set_TabIndex(3);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Black);
		((Control)Label2).set_Location(new Point(590, 416));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(59, 20));
		((Control)Label2).set_TabIndex(4);
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(0, 385));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(652, 28));
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Welcome To Student Information Management S/W.");
		Label3.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(648, 436));
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Startup");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Welcome To S.I.M.");
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
