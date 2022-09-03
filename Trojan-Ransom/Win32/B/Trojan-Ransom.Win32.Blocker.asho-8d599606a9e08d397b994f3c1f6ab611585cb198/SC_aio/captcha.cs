using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class captcha : Form
{
	private IContainer components;

	[AccessedThroughProperty("capimg")]
	private PictureBox _capimg;

	[AccessedThroughProperty("capres")]
	private TextBox _capres;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private bool clicked;

	private bool active;

	private int donotshow;

	internal virtual PictureBox capimg
	{
		get
		{
			return _capimg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_capimg = value;
		}
	}

	internal virtual TextBox capres
	{
		get
		{
			return _capres;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = capres_TextChanged;
			KeyEventHandler val = new KeyEventHandler(capres_KeyDown);
			if (_capres != null)
			{
				((Control)_capres).remove_TextChanged(eventHandler);
				((Control)_capres).remove_KeyDown(val);
			}
			_capres = value;
			if (_capres != null)
			{
				((Control)_capres).add_TextChanged(eventHandler);
				((Control)_capres).add_KeyDown(val);
			}
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

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	public captcha()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).add_KeyDown(new KeyEventHandler(captcha_KeyDown));
		((Control)this).add_Leave((EventHandler)captcha_Leave);
		((Form)this).add_Load((EventHandler)captcha_Load);
		((Control)this).add_LostFocus((EventHandler)captcha_LostFocus);
		((Control)this).add_VisibleChanged((EventHandler)captcha_VisibleChanged);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		components = new Container();
		capimg = new PictureBox();
		capres = new TextBox();
		Button1 = new Button();
		Timer1 = new Timer(components);
		((ISupportInitialize)capimg).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox obj = capimg;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)capimg).set_Name("capimg");
		PictureBox obj2 = capimg;
		Size size = new Size(120, 40);
		((Control)obj2).set_Size(size);
		capimg.set_TabIndex(0);
		capimg.set_TabStop(false);
		TextBox obj3 = capres;
		location = new Point(12, 57);
		((Control)obj3).set_Location(location);
		((Control)capres).set_Name("capres");
		TextBox obj4 = capres;
		size = new Size(83, 20);
		((Control)obj4).set_Size(size);
		((Control)capres).set_TabIndex(1);
		Button button = Button1;
		location = new Point(101, 55);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(31, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Go");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Timer1.set_Interval(500);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(140, 84);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)capres);
		((Control)this).get_Controls().Add((Control)(object)capimg);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("captcha");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Solve");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)capimg).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public object solve(string url)
	{
		if (MyProject.Forms.aio.autocontrolled)
		{
			Timer1.Start();
		}
		active = true;
		clicked = false;
		capres.set_Text("");
		showme();
		((Control)capres).Focus();
		capimg.set_ImageLocation(url);
		while (!clicked)
		{
			Application.DoEvents();
		}
		active = false;
		if (MyProject.Forms.aio.autocontrolled)
		{
			Timer1.Stop();
		}
		capimg.set_Image((Image)null);
		((Control)this).Hide();
		return capres.get_Text();
	}

	private void submitit()
	{
		if (capres.get_Text().Length > 3)
		{
			clicked = true;
		}
	}

	private void showme()
	{
		checked
		{
			if (donotshow == 0)
			{
				MyProject.Forms.aio.stealth();
				((Control)this).Show();
				((Control)this).BringToFront();
				((Form)this).set_Opacity(100.0);
				((Form)this).set_ShowInTaskbar(false);
				if (!((Control)Button1).get_Focused())
				{
					((Control)capres).Focus();
				}
				if (MyProject.Forms.aio.autocontrolled)
				{
					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
				}
				Point position = new Point(((Form)this).get_Location().X + 15, ((Form)this).get_Location().Y + 65);
				Cursor.set_Position(position);
			}
			else
			{
				donotshow--;
			}
		}
	}

	private void avoidaltf4(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 115)
		{
			donotshow = 5;
			((Control)this).Hide();
		}
	}

	private void captcha_KeyDown(object sender, KeyEventArgs e)
	{
		avoidaltf4(e);
	}

	private void captcha_Leave(object sender, EventArgs e)
	{
		if (MyProject.Forms.aio.autocontrolled & active)
		{
			showme();
		}
	}

	private void captcha_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		submitit();
	}

	private void captcha_LostFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.aio.autocontrolled & active)
		{
			showme();
		}
	}

	private void captcha_VisibleChanged(object sender, EventArgs e)
	{
		if (MyProject.Forms.aio.autocontrolled & active)
		{
			showme();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (MyProject.Forms.aio.autocontrolled & active)
		{
			showme();
		}
	}

	private void capres_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			submitit();
		}
		else
		{
			avoidaltf4(e);
		}
	}

	private void capres_TextChanged(object sender, EventArgs e)
	{
	}
}
