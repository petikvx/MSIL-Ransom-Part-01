using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Cleaner.registrydeneme1;

public class Form1 : Form
{
	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("timer1")]
	private Timer _timer1;

	[AccessedThroughProperty("notifyIcon1")]
	private NotifyIcon _notifyIcon1;

	[AccessedThroughProperty("button1")]
	private Button _button1;

	private ArrayList a1;

	private ArrayList a2;

	private ArrayList aa;

	private string[] baslangic;

	private IContainer components;

	private string[] degisensuruculer;

	private string[] dizi;

	private string[] ilk;

	private Process[] islemler;

	private string[] klasorprefect;

	private string[] klasortemp;

	private string[] klasortempesas;

	private string[] kurulu;

	private Label label1;

	private Label label2;

	private Label label5;

	private Label label6;

	private string[] string_0;

	private ListBox listBox1;

	private ListBox listBox2;

	private ListBox listBox3;

	private string[] m1;

	private string[] m2;

	private ArrayList ma0;

	private ArrayList ma1;

	private ArrayList ma2;

	private ArrayList ma3;

	private ArrayList ma4;

	private ArrayList ma5;

	private ArrayList ma6;

	private ArrayList ma7;

	private string makineadi;

	private string[] mus;

	private string[] mus1;

	private string[] n0;

	private string[] n1;

	private string[] n2;

	private string[] n3;

	private string[] n4;

	private string[] n5;

	private string[] n6;

	private string[] n7;

	private string[] paylasimdizi;

	private string[] paylasimdizidegerleri;

	private string[] prefectdizi;

	private ProgressBar progressBar1;

	private string[] s;

	private string[] subn;

	private string[] tempdizi;

	private string[] tempesas;

	private TextBox textBox3;

	private string[] tprinternet;

	private string[] tprinternetesas;

	private virtual Button button1
	{
		get
		{
			return _button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_button1 != null)
			{
				((Control)_button1).remove_Click((EventHandler)button1_Click_1);
			}
			_button1 = value;
			if (_button1 != null)
			{
				((Control)_button1).add_Click((EventHandler)button1_Click_1);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_PictureBox1 == null)
			{
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
			}
		}
	}

	private virtual NotifyIcon notifyIcon1
	{
		get
		{
			return _notifyIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_notifyIcon1 != null)
			{
				_notifyIcon1.remove_Click((EventHandler)notifyIcon1_Click);
			}
			_notifyIcon1 = value;
			if (_notifyIcon1 != null)
			{
				_notifyIcon1.add_Click((EventHandler)notifyIcon1_Click);
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_TextBox2 == null)
			{
			}
			_TextBox2 = value;
			if (_TextBox2 != null)
			{
			}
		}
	}

	internal virtual TextBox TextBox4
	{
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_TextBox4 == null)
			{
			}
			_TextBox4 = value;
			if (_TextBox4 != null)
			{
			}
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label3 == null)
			{
			}
			_Label3 = value;
			if (_Label3 != null)
			{
			}
		}
	}

	private virtual Timer timer1
	{
		get
		{
			return _timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_timer1 != null)
			{
				_timer1.remove_Tick((EventHandler)timer1_Tick_1);
			}
			_timer1 = value;
			if (_timer1 != null)
			{
				_timer1.add_Tick((EventHandler)timer1_Tick_1);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_SizeChanged((EventHandler)Form1_SizeChanged);
		a1 = new ArrayList();
		a2 = new ArrayList();
		aa = new ArrayList();
		components = null;
		ma0 = new ArrayList();
		ma1 = new ArrayList();
		ma2 = new ArrayList();
		ma3 = new ArrayList();
		ma4 = new ArrayList();
		ma5 = new ArrayList();
		ma6 = new ArrayList();
		ma7 = new ArrayList();
		makineadi = SystemInformation.get_ComputerName();
		InitializeComponent();
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		//IL_247e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2484: Invalid comparison between Unknown and I4
		listBox1.get_Items().Clear();
		listBox2.get_Items().Clear();
		listBox3.get_Items().Clear();
		try
		{
			progressBar1.set_Value(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		islemler = Process.GetProcesses(makineadi);
		dizi = Directory.GetLogicalDrives();
		checked
		{
			try
			{
				int num = dizi.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					listBox1.get_Items().Add((object)dizi[i]);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			int num2 = islemler.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if ((object)islemler[i].ProcessName == "activexdebugger32")
				{
					islemler[i].Kill();
				}
				if ((object)islemler[i].ProcessName == "sxs")
				{
					islemler[i].Kill();
				}
				if ((object)islemler[i].ProcessName == "copy")
				{
					islemler[i].Kill();
				}
				if ((object)islemler[i].ProcessName == "host")
				{
					islemler[i].Kill();
				}
			}
			try
			{
				progressBar1.set_Value(progressBar1.get_Value() + 25);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			int num3 = dizi.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				if (Directory.Exists(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temp"))
				{
					try
					{
						tempdizi = Directory.GetFiles(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temp");
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temp"))
				{
					try
					{
						klasortemp = Directory.GetDirectories(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temp");
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temporary Internet Files"))
				{
					try
					{
						tprinternet = Directory.GetFiles(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temporary Internet Files");
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temporary Internet Files"))
				{
					try
					{
						tprinternetesas = Directory.GetDirectories(dizi[i] + "\\Documents and Settings\\" + SystemInformation.get_UserName() + "\\Local Settings\\Temporary Internet Files");
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\WINDOWS\\Prefetch"))
				{
					try
					{
						prefectdizi = Directory.GetFiles(dizi[i] + "\\WINDOWS\\Prefetch");
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\WINDOWS\\Prefetch"))
				{
					try
					{
						klasorprefect = Directory.GetDirectories(dizi[i] + "\\WINDOWS\\Prefetch");
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\WINDOWS\\Temp"))
				{
					try
					{
						tempesas = Directory.GetFiles(dizi[i] + "\\WINDOWS\\Temp");
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
				}
				if (Directory.Exists(dizi[i] + "\\WINDOWS\\Temp"))
				{
					try
					{
						klasortempesas = Directory.GetDirectories(dizi[i] + "\\WINDOWS\\Temp");
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
				}
				temp_prefect_temizle();
			}
			try
			{
				progressBar1.set_Value(progressBar1.get_Value() + 25);
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			int num4 = dizi.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				if (dizi[i].StartsWith("A:") || dizi[i].StartsWith("B:"))
				{
					continue;
				}
				try
				{
					if (File.Exists(dizi[i] + "\\activexdebugger32.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\activexdebugger32.exe", FileAttributes.Normal);
						}
						catch (Exception projectError13)
						{
							ProjectData.SetProjectError(projectError13);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\activexdebugger32.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\activexdebugger32.exe"));
					}
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\copy.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\copy.exe", FileAttributes.Normal);
						}
						catch (Exception projectError15)
						{
							ProjectData.SetProjectError(projectError15);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\copy.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\copy.exe"));
					}
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\host.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\host.exe", FileAttributes.Normal);
						}
						catch (Exception projectError17)
						{
							ProjectData.SetProjectError(projectError17);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\host.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\host.exe"));
					}
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\sxs.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\sxs.exe", FileAttributes.Normal);
						}
						catch (Exception projectError19)
						{
							ProjectData.SetProjectError(projectError19);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\sxs.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\sxs.exe"));
					}
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\bittorent.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\bittorent.exe", FileAttributes.Normal);
						}
						catch (Exception projectError21)
						{
							ProjectData.SetProjectError(projectError21);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\bittorent.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\bittorent.exe"));
					}
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\autorun.inf"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\autorun.inf", FileAttributes.Normal);
						}
						catch (Exception projectError23)
						{
							ProjectData.SetProjectError(projectError23);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\autorun.inf");
						listBox3.get_Items().Add((object)(dizi[i] + "\\autorun.inf"));
					}
				}
				catch (Exception projectError24)
				{
					ProjectData.SetProjectError(projectError24);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\AUTORUN.INF"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\AUTORUN.INF", FileAttributes.Normal);
						}
						catch (Exception projectError25)
						{
							ProjectData.SetProjectError(projectError25);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\AUTORUN.INF");
						listBox3.get_Items().Add((object)(dizi[i] + "\\AUTORUN.INF"));
					}
				}
				catch (Exception projectError26)
				{
					ProjectData.SetProjectError(projectError26);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\AUTORUN.inf"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\AUTORUN.inf", FileAttributes.Normal);
						}
						catch (Exception projectError27)
						{
							ProjectData.SetProjectError(projectError27);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\AUTORUN.inf");
						listBox3.get_Items().Add((object)(dizi[i] + "\\AUTORUN.inf"));
					}
				}
				catch (Exception projectError28)
				{
					ProjectData.SetProjectError(projectError28);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\autorun.INF"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\autorun.INF", FileAttributes.Normal);
						}
						catch (Exception projectError29)
						{
							ProjectData.SetProjectError(projectError29);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\autorun.INF");
						listBox3.get_Items().Add((object)(dizi[i] + "\\autorun.INF"));
					}
				}
				catch (Exception projectError30)
				{
					ProjectData.SetProjectError(projectError30);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\WINDOWS\\system32\\activexdebugger32.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\WINDOWS\\system32\\activexdebugger32.exe", FileAttributes.Normal);
						}
						catch (Exception projectError31)
						{
							ProjectData.SetProjectError(projectError31);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\WINDOWS\\system32\\activexdebugger32.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\WINDOWS\\system32\\activexdebugger32.exe"));
					}
				}
				catch (Exception projectError32)
				{
					ProjectData.SetProjectError(projectError32);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\WINDOWS\\system\\ACD.CMD"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\WINDOWS\\system\\ACD.CMD", FileAttributes.Normal);
						}
						catch (Exception projectError33)
						{
							ProjectData.SetProjectError(projectError33);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\WINDOWS\\system\\ACD.CMD");
						listBox3.get_Items().Add((object)(dizi[i] + "\\WINDOWS\\system\\ACD.CMD"));
					}
				}
				catch (Exception projectError34)
				{
					ProjectData.SetProjectError(projectError34);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\WINDOWS\\system\\ACD2.CMD"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\WINDOWS\\system\\ACD2.CMD", FileAttributes.Normal);
						}
						catch (Exception projectError35)
						{
							ProjectData.SetProjectError(projectError35);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\WINDOWS\\system\\ACD2.CMD");
						listBox3.get_Items().Add((object)(dizi[i] + "\\WINDOWS\\system\\ACD2.CMD"));
					}
				}
				catch (Exception projectError36)
				{
					ProjectData.SetProjectError(projectError36);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\WINDOWS\\system32\\PAC.EXE"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\WINDOWS\\system32\\PAC.EXE", FileAttributes.Normal);
						}
						catch (Exception projectError37)
						{
							ProjectData.SetProjectError(projectError37);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\WINDOWS\\system32\\PAC.EXE");
						listBox3.get_Items().Add((object)(dizi[i] + "\\WINDOWS\\system32\\PAC.EXE"));
					}
				}
				catch (Exception projectError38)
				{
					ProjectData.SetProjectError(projectError38);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\fooool.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\fooool.exe", FileAttributes.Normal);
						}
						catch (Exception projectError39)
						{
							ProjectData.SetProjectError(projectError39);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\fooool.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\fooool.exe"));
					}
				}
				catch (Exception projectError40)
				{
					ProjectData.SetProjectError(projectError40);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\explorer.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\explorer.exe", FileAttributes.Normal);
						}
						catch (Exception projectError41)
						{
							ProjectData.SetProjectError(projectError41);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\explorer.exe");
						listBox3.get_Items().Add((object)(dizi[i] + "\\explorer.exe"));
					}
				}
				catch (Exception projectError42)
				{
					ProjectData.SetProjectError(projectError42);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				progressBar1.set_Value(progressBar1.get_Value() + 25);
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				s = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru")!.GetSubKeyNames();
			}
			catch (Exception projectError44)
			{
				ProjectData.SetProjectError(projectError44);
				ProjectData.ClearProjectError();
			}
			try
			{
				ilk = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru")!.GetValueNames();
			}
			catch (Exception projectError45)
			{
				ProjectData.SetProjectError(projectError45);
				ProjectData.ClearProjectError();
			}
			try
			{
				m1 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[0])!.GetValueNames();
			}
			catch (Exception projectError46)
			{
				ProjectData.SetProjectError(projectError46);
				ProjectData.ClearProjectError();
			}
			try
			{
				m2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[1])!.GetValueNames();
			}
			catch (Exception projectError47)
			{
				ProjectData.SetProjectError(projectError47);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num5 = ilk.Length - 1;
				for (int i = 0; i <= num5; i++)
				{
					aa.Add(RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru")!.GetValue(ilk[i])));
				}
			}
			catch (Exception projectError48)
			{
				ProjectData.SetProjectError(projectError48);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num6 = m1.Length - 1;
				for (int i = 0; i <= num6; i++)
				{
					a1.Add(RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[0])!.GetValue(m1[i])));
				}
			}
			catch (Exception projectError49)
			{
				ProjectData.SetProjectError(projectError49);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num7 = m2.Length - 1;
				for (int i = 0; i <= num7; i++)
				{
					a2.Add(RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[1])!.GetValue(m2[i])));
				}
			}
			catch (Exception projectError50)
			{
				ProjectData.SetProjectError(projectError50);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num8 = ilk.Length - 1;
				for (int i = 0; i <= num8; i++)
				{
					if (ilk[i].IndexOf("activexdebugger32") > 0 || ilk[i].IndexOf("copy.exe") != 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Search Assistant\\ACMru\\" + ilk[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru", writable: true)!.DeleteValue(ilk[i]);
					}
					if (aa[i]!.ToString()!.IndexOf("activexdebugger32") > 0 || aa[i]!.ToString()!.IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Search Assistant\\ACMru\\" + ilk[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru", writable: true)!.DeleteValue(ilk[i]);
					}
				}
			}
			catch (Exception projectError51)
			{
				ProjectData.SetProjectError(projectError51);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num9 = m1.Length - 1;
				for (int i = 0; i <= num9; i++)
				{
					if (m1[i].IndexOf("activexdebugger32") > 0 || m1[i].IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[0] + m1[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[0], writable: true)!.DeleteValue(m1[i]);
					}
					if (a1[i]!.ToString()!.IndexOf("activexdebugger32") > 0 || a1[i]!.ToString()!.IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[0] + m1[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[0], writable: true)!.DeleteValue(m1[i]);
					}
				}
			}
			catch (Exception projectError52)
			{
				ProjectData.SetProjectError(projectError52);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num10 = m2.Length - 1;
				for (int i = 0; i <= num10; i++)
				{
					if (m2[i].IndexOf("activexdebugger32") > 0 || m2[i].IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[1] + m2[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[1], writable: true)!.DeleteValue(m2[i]);
					}
					if (a2[i]!.ToString()!.IndexOf("activexdebugger32") > 0 || a2[i]!.ToString()!.IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[1] + m2[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Search Assistant\\ACMru\\" + s[1], writable: true)!.DeleteValue(m2[i]);
					}
				}
			}
			catch (Exception projectError53)
			{
				ProjectData.SetProjectError(projectError53);
				ProjectData.ClearProjectError();
			}
			ArrayList arrayList = new ArrayList();
			try
			{
				mus = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
			}
			catch (Exception projectError54)
			{
				ProjectData.SetProjectError(projectError54);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num11 = mus.Length - 1;
				for (int i = 0; i <= num11; i++)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(mus[i])));
				}
			}
			catch (Exception projectError55)
			{
				ProjectData.SetProjectError(projectError55);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num12 = mus.Length - 1;
				for (int i = 0; i <= num12; i++)
				{
					if (mus[i].IndexOf("activexdebugger32") > 0 || mus[i].IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache" + mus[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(mus[i]);
					}
					if (arrayList[i]!.ToString()!.IndexOf("activexdebugger32") > 0 || arrayList[i]!.ToString()!.IndexOf("copy.exe") > 0)
					{
						listBox3.get_Items().Add((object)("Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache" + mus[i]));
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(mus[i]);
					}
				}
			}
			catch (Exception projectError56)
			{
				ProjectData.SetProjectError(projectError56);
				ProjectData.ClearProjectError();
			}
			ArrayList arrayList2 = new ArrayList();
			try
			{
				mus1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon")!.GetValueNames();
			}
			catch (Exception projectError57)
			{
				ProjectData.SetProjectError(projectError57);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num13 = mus1.Length - 1;
				for (int i = 0; i <= num13; i++)
				{
					arrayList2.Add(RuntimeHelpers.GetObjectValue(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon")!.GetValue(mus1[i])));
				}
			}
			catch (Exception projectError58)
			{
				ProjectData.SetProjectError(projectError58);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num14 = mus1.Length - 1;
				for (int i = 0; i <= num14; i++)
				{
					if (mus1[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon" + mus1[i]));
						Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.DeleteValue(mus1[i]);
					}
					if (arrayList2[i]!.ToString()!.IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon" + mus1[i]));
						Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.DeleteValue(mus1[i]);
					}
				}
			}
			catch (Exception projectError59)
			{
				ProjectData.SetProjectError(projectError59);
				ProjectData.ClearProjectError();
			}
			try
			{
				subn = Registry.Users.GetSubKeyNames();
			}
			catch (Exception projectError60)
			{
				ProjectData.SetProjectError(projectError60);
				ProjectData.ClearProjectError();
			}
			try
			{
				n0 = Registry.Users.OpenSubKey(subn[0] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n1 = Registry.Users.OpenSubKey(subn[1] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n2 = Registry.Users.OpenSubKey(subn[2] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n3 = Registry.Users.OpenSubKey(subn[3] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n4 = Registry.Users.OpenSubKey(subn[4] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n5 = Registry.Users.OpenSubKey(subn[5] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n6 = Registry.Users.OpenSubKey(subn[6] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
				n7 = Registry.Users.OpenSubKey(subn[7] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValueNames();
			}
			catch (Exception projectError61)
			{
				ProjectData.SetProjectError(projectError61);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num15 = n0.Length - 1;
				for (int i = 0; i <= num15; i++)
				{
					ma0.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[0] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n0[i])));
				}
			}
			catch (Exception projectError62)
			{
				ProjectData.SetProjectError(projectError62);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num16 = n1.Length - 1;
				for (int i = 0; i <= num16; i++)
				{
					ma1.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[1] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n1[i])));
				}
			}
			catch (Exception projectError63)
			{
				ProjectData.SetProjectError(projectError63);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num17 = n2.Length - 1;
				for (int i = 0; i <= num17; i++)
				{
					ma2.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[2] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n2[i])));
				}
			}
			catch (Exception projectError64)
			{
				ProjectData.SetProjectError(projectError64);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num18 = n3.Length - 1;
				for (int i = 0; i <= num18; i++)
				{
					ma3.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[3] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n3[i])));
				}
			}
			catch (Exception projectError65)
			{
				ProjectData.SetProjectError(projectError65);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num19 = n4.Length - 1;
				for (int i = 0; i <= num19; i++)
				{
					ma4.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[4] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n4[i])));
				}
			}
			catch (Exception projectError66)
			{
				ProjectData.SetProjectError(projectError66);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num20 = n5.Length - 1;
				for (int i = 0; i <= num20; i++)
				{
					ma5.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[5] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n5[i])));
				}
			}
			catch (Exception projectError67)
			{
				ProjectData.SetProjectError(projectError67);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num21 = n6.Length - 1;
				for (int i = 0; i <= num21; i++)
				{
					ma6.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[6] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n6[i])));
				}
			}
			catch (Exception projectError68)
			{
				ProjectData.SetProjectError(projectError68);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num22 = n7.Length - 1;
				for (int i = 0; i <= num22; i++)
				{
					ma7.Add(RuntimeHelpers.GetObjectValue(Registry.Users.OpenSubKey(subn[7] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache")!.GetValue(n7[i])));
				}
			}
			catch (Exception projectError69)
			{
				ProjectData.SetProjectError(projectError69);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num23 = n0.Length - 1;
				for (int i = 0; i <= num23; i++)
				{
					if (n0[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[0] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n0[i]));
						Registry.Users.OpenSubKey(subn[0] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n0[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma0[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[0] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n0[i]));
						Registry.Users.OpenSubKey(subn[0] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n0[i]);
					}
				}
			}
			catch (Exception projectError70)
			{
				ProjectData.SetProjectError(projectError70);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num24 = n1.Length - 1;
				for (int i = 0; i <= num24; i++)
				{
					if (n1[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[1] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n1[i]));
						Registry.Users.OpenSubKey(subn[1] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n1[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma1[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[1] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n1[i]));
						Registry.Users.OpenSubKey(subn[1] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n1[i]);
					}
				}
			}
			catch (Exception projectError71)
			{
				ProjectData.SetProjectError(projectError71);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num25 = n2.Length - 1;
				for (int i = 0; i <= num25; i++)
				{
					if (n2[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[2] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n2[i]));
						Registry.Users.OpenSubKey(subn[2] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n2[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma2[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[2] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n2[i]));
						Registry.Users.OpenSubKey(subn[2] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n2[i]);
					}
				}
			}
			catch (Exception projectError72)
			{
				ProjectData.SetProjectError(projectError72);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num26 = n3.Length - 1;
				for (int i = 0; i <= num26; i++)
				{
					if (n3[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[3] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n3[i]));
						Registry.Users.OpenSubKey(subn[3] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n3[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma3[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[3] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n3[i]));
						Registry.Users.OpenSubKey(subn[3] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n3[i]);
					}
				}
			}
			catch (Exception projectError73)
			{
				ProjectData.SetProjectError(projectError73);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num27 = n4.Length - 1;
				for (int i = 0; i <= num27; i++)
				{
					if (n4[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[4] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n4[i]));
						Registry.Users.OpenSubKey(subn[4] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n4[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma4[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[4] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n4[i]));
						Registry.Users.OpenSubKey(subn[4] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n4[i]);
					}
				}
			}
			catch (Exception projectError74)
			{
				ProjectData.SetProjectError(projectError74);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num28 = n5.Length - 1;
				for (int i = 0; i <= num28; i++)
				{
					if (n5[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[5] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n5[i]));
						Registry.Users.OpenSubKey(subn[5] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n5[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma5[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[5] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n5[i]));
						Registry.Users.OpenSubKey(subn[5] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n5[i]);
					}
				}
			}
			catch (Exception projectError75)
			{
				ProjectData.SetProjectError(projectError75);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num29 = n6.Length - 1;
				for (int i = 0; i <= num29; i++)
				{
					if (n6[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[6] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n6[i]));
						Registry.Users.OpenSubKey(subn[6] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n6[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma6[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[6] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n6[i]));
						Registry.Users.OpenSubKey(subn[6] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n6[i]);
					}
				}
			}
			catch (Exception projectError76)
			{
				ProjectData.SetProjectError(projectError76);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num30 = n7.Length - 1;
				for (int i = 0; i <= num30; i++)
				{
					if (n7[i].IndexOf("activexdebugger32") > 0)
					{
						listBox3.get_Items().Add((object)(subn[7] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n7[i]));
						Registry.Users.OpenSubKey(subn[7] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n7[i]);
					}
					if (ObjectType.ObjTst(LateBinding.LateGet(ma7[i], (Type)null, "ToStringIndexOf", new object[1] { "activexdebugger32" }, (string[])null, (bool[])null), (object)0, false) > 0)
					{
						listBox3.get_Items().Add((object)(subn[7] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache\\" + n7[i]));
						Registry.Users.OpenSubKey(subn[7] + "\\Software\\Microsoft\\Windows\\ShellNoRoam\\MUICache", writable: true)!.DeleteValue(n7[i]);
					}
				}
			}
			catch (Exception projectError77)
			{
				ProjectData.SetProjectError(projectError77);
				ProjectData.ClearProjectError();
			}
			try
			{
				paylasimdizi = Registry.LocalMachine.OpenSubKey("SYSTEM")!.GetSubKeyNames();
			}
			catch (Exception projectError78)
			{
				ProjectData.SetProjectError(projectError78);
				ProjectData.ClearProjectError();
			}
			int num31 = paylasimdizi.Length - 1;
			for (int i = 0; i <= num31; i++)
			{
				if (!paylasimdizi[i].StartsWith("ControlSet"))
				{
					continue;
				}
				try
				{
					paylasimdizidegerleri = Registry.LocalMachine.OpenSubKey("SYSTEM\\" + paylasimdizi[i] + "\\Services\\lanmanserver\\Shares")!.GetValueNames();
				}
				catch (Exception projectError79)
				{
					ProjectData.SetProjectError(projectError79);
					ProjectData.ClearProjectError();
				}
				try
				{
					int num32 = paylasimdizidegerleri.Length - 1;
					for (int j = 0; j <= num32; j++)
					{
						if (paylasimdizidegerleri[j].IndexOf("PATRON") > 0)
						{
							listBox3.get_Items().Add((object)("HKEY_LOCAL_MACHINE\\SYSTEM\\" + paylasimdizi[i] + "\\Services\\lanmanserver\\Shares-->" + paylasimdizidegerleri[j]));
							Registry.LocalMachine.OpenSubKey("SYSTEM\\" + paylasimdizi[i] + "\\Services\\lanmanserver\\Shares", writable: true)!.DeleteValue(paylasimdizidegerleri[j]);
						}
					}
				}
				catch (Exception projectError80)
				{
					ProjectData.SetProjectError(projectError80);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				progressBar1.set_Value(progressBar1.get_Value() + 25);
			}
			catch (Exception projectError81)
			{
				ProjectData.SetProjectError(projectError81);
				ProjectData.ClearProjectError();
			}
		}
		if ((int)MessageBox.Show("Temizleme işleminin başarıyla tamamlanması için sistemin yeniden başlatılması gerekmektedir,yeniden başlatmak isterseniz uygulamalarınızı kaydedin ve Evet butonuna tıklayın.", "Dikkat", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			Process.Start("ShutDown", "/r -t 0");
		}
		try
		{
			progressBar1.set_Value(0);
		}
		catch (Exception projectError82)
		{
			ProjectData.SetProjectError(projectError82);
			ProjectData.ClearProjectError();
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

	private void donanimdegiskligioldu()
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string_0 = degisensuruculer;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				islemler = Process.GetProcesses(makineadi);
				int num = islemler.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if ((object)islemler[i].ProcessName == "activexdebugger32")
					{
						((Form)this).set_WindowState((FormWindowState)0);
						((Control)this).set_Visible(true);
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			dizi = Directory.GetLogicalDrives();
			int num2 = dizi.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (dizi[i].StartsWith("A:") || dizi[i].StartsWith("B:"))
				{
					continue;
				}
				try
				{
					if (File.Exists(dizi[i] + "\\activexdebugger32.exe"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\activexdebugger32.exe", FileAttributes.Normal);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\activexdebugger32.exe");
						MessageBox.Show("Taşınabilir diskinizde activexdebugger32.exe virüsü bulundu ve temizlendi diskinizi yeniden takıp çıkarırsanız sorun çözülebilir", "VİRÜS BULUNDU");
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\autorun.inf"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\autorun.inf", FileAttributes.Normal);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\autorun.inf");
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\AUTORUN.INF"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\AUTORUN.INF", FileAttributes.Normal);
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\AUTORUN.INF");
					}
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\AUTORUN.inf"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\AUTORUN.inf", FileAttributes.Normal);
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\AUTORUN.inf");
					}
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (File.Exists(dizi[i] + "\\autorun.INF"))
					{
						try
						{
							File.SetAttributes(dizi[i] + "\\autorun.INF", FileAttributes.Normal);
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							ProjectData.ClearProjectError();
						}
						File.Delete(dizi[i] + "\\autorun.INF");
					}
				}
				catch (Exception projectError12)
				{
					ProjectData.SetProjectError(projectError12);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string_0 = Directory.GetLogicalDrives();
		checked
		{
			int num = string_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				listBox1.get_Items().Add((object)string_0[i]);
			}
		}
	}

	private void Form1_SizeChanged(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			((Control)this).Hide();
		}
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected O, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		button1 = new Button();
		listBox1 = new ListBox();
		label1 = new Label();
		progressBar1 = new ProgressBar();
		this.label2 = new Label();
		this.textBox3 = new TextBox();
		listBox2 = new ListBox();
		label5 = new Label();
		listBox3 = new ListBox();
		label6 = new Label();
		notifyIcon1 = new NotifyIcon(components);
		timer1 = new Timer(components);
		PictureBox1 = new PictureBox();
		TextBox2 = new TextBox();
		TextBox4 = new TextBox();
		Label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)button1).set_Font(new Font("Arial", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)button1).set_ForeColor(Color.MidnightBlue);
		Button obj = button1;
		Point location = new Point(488, 344);
		((Control)obj).set_Location(location);
		((Control)button1).set_Name("button1");
		Button obj2 = button1;
		Size size = new Size(192, 47);
		((Control)obj2).set_Size(size);
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Temizle ");
		listBox1.set_HorizontalScrollbar(true);
		ListBox obj3 = listBox1;
		location = new Point(10, 156);
		((Control)obj3).set_Location(location);
		((Control)listBox1).set_Name("listBox1");
		listBox1.set_SelectionMode((SelectionMode)0);
		ListBox obj4 = listBox1;
		size = new Size(198, 95);
		((Control)obj4).set_Size(size);
		((Control)listBox1).set_TabIndex(3);
		label1.set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label1).set_ForeColor(Color.MidnightBlue);
		Label obj5 = label1;
		location = new Point(16, 136);
		((Control)obj5).set_Location(location);
		((Control)label1).set_Name("label1");
		Label obj6 = label1;
		size = new Size(188, 15);
		((Control)obj6).set_Size(size);
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("Bilgisayarınızdaki  Sürücüler");
		((Control)progressBar1).set_Anchor((AnchorStyles)7);
		ProgressBar obj7 = progressBar1;
		location = new Point(10, 440);
		((Control)obj7).set_Location(location);
		((Control)progressBar1).set_Name("progressBar1");
		ProgressBar obj8 = progressBar1;
		size = new Size(670, 15);
		((Control)obj8).set_Size(size);
		((Control)progressBar1).set_TabIndex(9);
		this.label2.set_AutoSize(true);
		((Control)this.label2).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)this.label2).set_ForeColor(Color.MidnightBlue);
		Label obj9 = this.label2;
		location = new Point(520, 408);
		((Control)obj9).set_Location(location);
		((Control)this.label2).set_Name("label2");
		Label obj10 = this.label2;
		size = new Size(137, 22);
		((Control)obj10).set_Size(size);
		((Control)this.label2).set_TabIndex(11);
		((Control)this.label2).set_Text("İşlem Durumu");
		((TextBoxBase)this.textBox3).set_BackColor(Color.MidnightBlue);
		((Control)this.textBox3).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((TextBoxBase)this.textBox3).set_ForeColor(SystemColors.Window);
		TextBox obj11 = this.textBox3;
		location = new Point(8, 264);
		((Control)obj11).set_Location(location);
		((TextBoxBase)this.textBox3).set_Multiline(true);
		((Control)this.textBox3).set_Name("textBox3");
		((TextBoxBase)this.textBox3).set_ReadOnly(true);
		TextBox obj12 = this.textBox3;
		size = new Size(672, 56);
		((Control)obj12).set_Size(size);
		((Control)this.textBox3).set_TabIndex(16);
		this.textBox3.set_Text("Bu program bilgisayarınızdaki patron1, patron2 paylaşımlarına sebep olan Activexdebugger32.exe trojanını temizlemek için hazırlanmıştır.Bu program çalışırken şüphelendiğiniz tüm taşınabilir usb cihazlarınızın bilgisayarınıza takılı olduğundan emin olunuz.");
		listBox2.set_HorizontalScrollbar(true);
		ListBox obj13 = listBox2;
		location = new Point(224, 158);
		((Control)obj13).set_Location(location);
		((Control)listBox2).set_Name("listBox2");
		listBox2.set_SelectionMode((SelectionMode)0);
		ListBox obj14 = listBox2;
		size = new Size(456, 95);
		((Control)obj14).set_Size(size);
		((Control)listBox2).set_TabIndex(21);
		label5.set_AutoSize(true);
		((Control)label5).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label5).set_ForeColor(Color.MidnightBlue);
		Label obj15 = label5;
		location = new Point(232, 136);
		((Control)obj15).set_Location(location);
		((Control)label5).set_Name("label5");
		Label obj16 = label5;
		size = new Size(109, 15);
		((Control)obj16).set_Size(size);
		((Control)label5).set_TabIndex(22);
		((Control)label5).set_Text("Silinen Dosyalar");
		listBox3.set_HorizontalScrollbar(true);
		ListBox obj17 = listBox3;
		location = new Point(224, 32);
		((Control)obj17).set_Location(location);
		((Control)listBox3).set_Name("listBox3");
		listBox3.set_SelectionMode((SelectionMode)0);
		ListBox obj18 = listBox3;
		size = new Size(456, 95);
		((Control)obj18).set_Size(size);
		((Control)listBox3).set_TabIndex(24);
		label6.set_AutoSize(true);
		((Control)label6).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label6).set_ForeColor(Color.MidnightBlue);
		Label obj19 = label6;
		location = new Point(232, 8);
		((Control)obj19).set_Location(location);
		((Control)label6).set_Name("label6");
		Label obj20 = label6;
		size = new Size(187, 15);
		((Control)obj20).set_Size(size);
		((Control)label6).set_TabIndex(25);
		((Control)label6).set_Text("Temizlenen Virüslü Dosyalar");
		notifyIcon1.set_Text("DRACULA Virüs Temizleyici V 3.0 Aktif Koruma");
		notifyIcon1.set_Visible(true);
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		PictureBox1.set_Image((Image)(Bitmap)resourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(48, 8);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(120, 120);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(28);
		PictureBox1.set_TabStop(false);
		((TextBoxBase)TextBox2).set_BackColor(Color.MidnightBlue);
		((Control)TextBox2).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((TextBoxBase)TextBox2).set_ForeColor(SystemColors.Window);
		TextBox textBox = TextBox2;
		location = new Point(8, 320);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox2).set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		TextBox textBox2 = TextBox2;
		size = new Size(472, 56);
		((Control)textBox2).set_Size(size);
		((Control)TextBox2).set_TabIndex(30);
		TextBox2.set_Text("Temizle butonuna basıldığında bilgisayarınızda bulunan tüm sürücülerdeki activexdebugger32.exe ve etkilerini temizlenecek, windowsun geçici ve tercih dosyaları silinecektir.");
		((TextBoxBase)TextBox4).set_BackColor(Color.MidnightBlue);
		((Control)TextBox4).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((TextBoxBase)TextBox4).set_ForeColor(SystemColors.Window);
		TextBox textBox3 = TextBox4;
		location = new Point(8, 376);
		((Control)textBox3).set_Location(location);
		((TextBoxBase)TextBox4).set_Multiline(true);
		((Control)TextBox4).set_Name("TextBox4");
		((TextBoxBase)TextBox4).set_ReadOnly(true);
		TextBox textBox4 = TextBox4;
		size = new Size(472, 56);
		((Control)textBox4).set_Size(size);
		((Control)TextBox4).set_TabIndex(31);
		TextBox4.set_Text("Bu trojanın tekrar bilgisayarınıza bulaşmasını engellemek için http://guvenlik.ankara.edu.tr sayfalarındaki güncel, lisanslı, antivirüs yazılımımızı kurmanız gerekmekte ve virüs tanım dosyalarını güncellemeniz  gerekmektedir.");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Times New Roman", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)Label3).set_ForeColor(Color.MidnightBlue);
		Label label = Label3;
		location = new Point(216, 456);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		size = new Size(277, 13);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(32);
		((Control)Label3).set_Text("Ankara Üniversitesi Bilgi İşlem Daire Başkanlığı © 2007");
		((Form)this).set_AcceptButton((IButtonControl)(object)button1);
		((Form)this).set_AutoScale(false);
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(Color.LightSteelBlue);
		size = new Size(692, 469);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[14]
		{
			(Control)Label3,
			(Control)TextBox4,
			(Control)TextBox2,
			(Control)PictureBox1,
			(Control)label6,
			(Control)listBox3,
			(Control)label5,
			(Control)listBox2,
			(Control)this.textBox3,
			(Control)this.label2,
			(Control)progressBar1,
			(Control)label1,
			(Control)listBox1,
			(Control)button1
		});
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text(" Ankara Üniversitesi Bilgi İşlem Daire Başkanlığı Activexdebugger32.exe Temizleyicisi");
		((Control)this).ResumeLayout(false);
	}

	private void notifyIcon1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			((Control)this).set_Visible(true);
			((Form)this).set_WindowState((FormWindowState)0);
		}
	}

	private void temp_prefect_temizle()
	{
		checked
		{
			try
			{
				int num = tempdizi.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						File.SetAttributes(tempdizi[i], FileAttributes.Normal);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					File.Delete(tempdizi[i]);
					listBox2.get_Items().Add((object)tempdizi[i]);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num2 = prefectdizi.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					try
					{
						File.SetAttributes(prefectdizi[i], FileAttributes.Normal);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					File.Delete(prefectdizi[i]);
					listBox2.get_Items().Add((object)prefectdizi[i]);
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num3 = tempesas.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					try
					{
						File.SetAttributes(tempesas[i], FileAttributes.Normal);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					File.Delete(tempesas[i]);
					listBox2.get_Items().Add((object)tempesas[i]);
				}
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num4 = klasorprefect.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					try
					{
						File.SetAttributes(klasorprefect[i], FileAttributes.Normal);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					Directory.Delete(klasorprefect[i]);
					listBox2.get_Items().Add((object)klasorprefect[i]);
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num5 = klasortemp.Length - 1;
				for (int i = 0; i <= num5; i++)
				{
					try
					{
						File.SetAttributes(klasortemp[i], FileAttributes.Normal);
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					Directory.Delete(klasortemp[i]);
					listBox2.get_Items().Add((object)klasortemp[i]);
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num6 = klasortempesas.Length - 1;
				for (int i = 0; i <= num6; i++)
				{
					try
					{
						File.SetAttributes(klasortempesas[i], FileAttributes.Normal);
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					Directory.Delete(klasortempesas[i]);
					listBox2.get_Items().Add((object)klasortempesas[i]);
				}
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num7 = tprinternet.Length - 1;
				for (int i = 0; i <= num7; i++)
				{
					try
					{
						File.SetAttributes(tprinternet[i], FileAttributes.Normal);
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
					Directory.Delete(tprinternet[i]);
					listBox2.get_Items().Add((object)tprinternet[i]);
				}
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num8 = tprinternetesas.Length - 1;
				for (int i = 0; i <= num8; i++)
				{
					try
					{
						File.SetAttributes(tprinternetesas[i], FileAttributes.Normal);
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
					}
					Directory.Delete(tprinternetesas[i]);
					listBox2.get_Items().Add((object)tprinternetesas[i]);
				}
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void timer1_Tick_1(object sender, EventArgs e)
	{
		try
		{
			degisensuruculer = Directory.GetLogicalDrives();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (string_0.Length != degisensuruculer.Length)
			{
				donanimdegiskligioldu();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
