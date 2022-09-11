using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns1;

internal sealed class Class127
{
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private bool bool_6;

	[NonSerialized]
	internal static GetString getString_0;

	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			Position = 0;
		}
	}

	public bool AnsiQuotes
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool BackslashEscapes
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool MultiLine
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool SqlServerMode
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public bool Quoted
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		private set
		{
			bool_4 = value;
		}
	}

	public bool IsComment
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		private set
		{
			bool_5 = value;
		}
	}

	public int StartIndex
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int StopIndex
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int Position
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public bool ReturnComments
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	public Class127()
	{
		BackslashEscapes = true;
		MultiLine = true;
		Position = 0;
	}

	public Class127(string string_1)
		: this()
	{
		string_0 = string_1;
	}

	public List<string> method_0()
	{
		List<string> list = new List<string>();
		for (string text = method_1(); text != null; text = method_1())
		{
			list.Add(text);
		}
		return list;
	}

	public string method_1()
	{
		if (!method_3())
		{
			return null;
		}
		return string_0.Substring(StartIndex, StopIndex - StartIndex);
	}

	public static bool smethod_0(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return false;
		}
		if (string_1[0] == '?')
		{
			return true;
		}
		if (string_1.Length > 1 && string_1[0] == '@')
		{
			return string_1[1] != '@';
		}
		return false;
	}

	public string method_2()
	{
		while (true)
		{
			if (method_3())
			{
				if (StopIndex - StartIndex < 2)
				{
					continue;
				}
				char c = string_0[StartIndex];
				char c2 = string_0[StartIndex + 1];
				switch (c)
				{
				case '@':
					if (c2 == '@')
					{
						continue;
					}
					break;
				default:
					continue;
				case '?':
					break;
				}
				break;
			}
			return null;
		}
		return string_0.Substring(StartIndex, StopIndex - StartIndex);
	}

	public bool method_3()
	{
		Quoted = false;
		IsComment = false;
		int num = -1;
		StopIndex = -1;
		StartIndex = -1;
		while (true)
		{
			if (Position < string_0.Length)
			{
				char c = string_0[Position++];
				if (char.IsWhiteSpace(c))
				{
					continue;
				}
				if (c != '`' && c != '\'' && c != '"' && (c != '[' || !SqlServerMode))
				{
					if (c != '#' && c != '-' && c != '/')
					{
						method_7();
					}
					else if (!method_5(c))
					{
						method_8();
					}
				}
				else
				{
					method_9(c);
				}
				if (StartIndex != -1)
				{
					break;
				}
				continue;
			}
			return false;
		}
		return true;
	}

	public string method_4()
	{
		StringBuilder stringBuilder = new StringBuilder(getString_0(107409511));
		_ = StartIndex;
		string text = method_1();
		while (true)
		{
			if (text != null)
			{
				stringBuilder.Append(text);
				if (text == getString_0(107409506) && !Quoted)
				{
					break;
				}
				text = method_1();
				continue;
			}
			throw new InvalidOperationException(getString_0(107357785));
		}
		return stringBuilder.ToString();
	}

	private bool method_5(char char_0)
	{
		if (char_0 == '/' && (Position >= string_0.Length || string_0[Position] != '*'))
		{
			return false;
		}
		if (char_0 == '-' && (Position + 1 >= string_0.Length || string_0[Position] != '-' || string_0[Position + 1] != ' '))
		{
			return false;
		}
		string text = getString_0(107357244);
		if (string_0[Position] == '*')
		{
			text = getString_0(107357239);
		}
		int startIndex = Position - 1;
		int num = string_0.IndexOf(text, Position);
		if (text == getString_0(107357244))
		{
			num = string_0.IndexOf('\n', Position);
		}
		num = (Position = ((num != -1) ? (num + text.Length) : (string_0.Length - 1)));
		if (ReturnComments)
		{
			StartIndex = startIndex;
			StopIndex = num;
			IsComment = true;
		}
		return true;
	}

	private void method_6(int int_3, int int_4)
	{
		StartIndex = int_3;
		StopIndex = int_4;
		_ = MultiLine;
	}

	private void method_7()
	{
		StartIndex = Position - 1;
		if (!method_12(string_0[StartIndex]))
		{
			while (Position < string_0.Length)
			{
				char c = string_0[Position];
				if (char.IsWhiteSpace(c) || method_12(c))
				{
					break;
				}
				Position++;
			}
		}
		Quoted = false;
		StopIndex = Position;
	}

	private void method_8()
	{
		StartIndex = Position - 1;
		StopIndex = Position;
		Quoted = false;
	}

	private void method_9(char char_0)
	{
		if (char_0 == '[')
		{
			char_0 = ']';
		}
		StartIndex = Position - 1;
		bool flag = false;
		bool flag2 = false;
		while (Position < string_0.Length)
		{
			char c = string_0[Position];
			if (c != char_0 || flag)
			{
				if (flag)
				{
					flag = false;
				}
				else if (c == '\\' && BackslashEscapes)
				{
					flag = true;
				}
				Position++;
				continue;
			}
			flag2 = true;
			break;
		}
		if (flag2)
		{
			Position++;
		}
		Quoted = flag2;
		StopIndex = Position;
	}

	private bool method_10(char char_0)
	{
		if (char_0 != '`' && char_0 != '\'')
		{
			return char_0 == '"';
		}
		return true;
	}

	private bool method_11(char char_0)
	{
		if (char_0 != '@')
		{
			return char_0 == '?';
		}
		return true;
	}

	private bool method_12(char char_0)
	{
		if (!char.IsLetterOrDigit(char_0) && char_0 != '$' && char_0 != '_' && char_0 != '.')
		{
			if (method_11(char_0))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	static Class127()
	{
		Strings.CreateGetStringDelegate(typeof(Class127));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398134), getString_0(107398129)).Replace(getString_0(107398092), getString_0(107398087)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_7: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398082)))
		{
			throw new SecurityException(getString_0(107398057));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_7, [MarshalAs(UnmanagedType.Bool)] out bool bool_8);
}
