using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Ionic;

public class GClass3
{
	private enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4
	}

	private static class Class7
	{
		public static readonly string string_0 = "(?<=(?:[^']*'[^']*')*'[^']*)";

		public static readonly string string_1 = "(?=[^']*'(?:[^']*'[^']*')*[^']*$)";

		public static readonly string string_2 = "(?<=(?:[^']*'[^']*')*[^']*)";

		public static readonly string string_3 = "(?=(?:[^']*'[^']*')*[^']*$)";
	}

	internal Class0 class0_0;

	[CompilerGenerated]
	private bool bool_0;

	public string String_0
	{
		get
		{
			if (class0_0 == null)
			{
				return null;
			}
			return class0_0.ToString();
		}
		set
		{
			if (value == null)
			{
				class0_0 = null;
			}
			else if (value.Trim() == "")
			{
				class0_0 = null;
			}
			else
			{
				class0_0 = smethod_1(value);
			}
		}
	}

	public bool Boolean_0
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

	public GClass3(string selectionCriteria)
		: this(selectionCriteria, traverseDirectoryReparsePoints: true)
	{
	}

	public GClass3(string selectionCriteria, bool traverseDirectoryReparsePoints)
	{
		if (!string.IsNullOrEmpty(selectionCriteria))
		{
			class0_0 = smethod_1(selectionCriteria);
		}
		Boolean_0 = traverseDirectoryReparsePoints;
	}

	private static string smethod_0(string string_0)
	{
		string[][] array = new string[11][]
		{
			new string[2] { "([^']*)\\(\\(([^']+)", "$1( ($2" },
			new string[2] { "(.)\\)\\)", "$1) )" },
			new string[2] { "\\((\\S)", "( $1" },
			new string[2] { "(\\S)\\)", "$1 )" },
			new string[2] { "^\\)", " )" },
			new string[2] { "(\\S)\\(", "$1 (" },
			new string[2] { "\\)(\\S)", ") $1" },
			new string[2] { "(=)('[^']*')", "$1 $2" },
			new string[2] { "([^ !><])(>|<|!=|=)", "$1 $2" },
			new string[2] { "(>|<|!=|=)([^ =])", "$1 $2" },
			new string[2] { "/", "\\" }
		};
		string input = string_0;
		for (int i = 0; i < array.Length; i++)
		{
			string pattern = Class7.string_2 + array[i][0] + Class7.string_3;
			input = Regex.Replace(input, pattern, array[i][1]);
		}
		string pattern2 = "/" + Class7.string_1;
		input = Regex.Replace(input, pattern2, "\\");
		pattern2 = " " + Class7.string_1;
		return Regex.Replace(input, pattern2, "\u0006");
	}

	private static Class0 smethod_1(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		string_0 = smethod_0(string_0);
		if (string_0.IndexOf(" ") == -1)
		{
			string_0 = "name = " + string_0;
		}
		string[] array = string_0.Trim().Split(' ', '\t');
		if (array.Length < 3)
		{
			throw new ArgumentException(string_0);
		}
		Class0 @class = null;
		LogicalConjunction logicalConjunction = LogicalConjunction.NONE;
		Stack<Enum0> stack = new Stack<Enum0>();
		Stack<Class0> stack2 = new Stack<Class0>();
		stack.Push(Enum0.const_0);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].ToLower();
			Enum0 @enum;
			switch (text)
			{
			case ")":
				@enum = stack.Pop();
				if (stack.Peek() == Enum0.const_1)
				{
					stack.Pop();
					stack.Push(Enum0.const_2);
					goto IL_0760;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "(":
				@enum = stack.Peek();
				if (@enum == Enum0.const_0 || @enum == Enum0.const_3 || @enum == Enum0.const_1)
				{
					if (array.Length > i + 4)
					{
						stack.Push(Enum0.const_1);
						goto IL_0760;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "size":
			case "length":
				if (array.Length > i + 2)
				{
					long num = 0L;
					string text3 = array[i + 2];
					num = (text3.ToUpper().EndsWith("K") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L) : (text3.ToUpper().EndsWith("KB") ? (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L) : (text3.ToUpper().EndsWith("M") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L * 1024L) : (text3.ToUpper().EndsWith("MB") ? (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L * 1024L) : (text3.ToUpper().EndsWith("G") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L * 1024L * 1024L) : ((!text3.ToUpper().EndsWith("GB")) ? long.Parse(array[i + 2]) : (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L * 1024L * 1024L)))))));
					@class = new Class1
					{
						long_0 = num,
						comparisonOperator_0 = (ComparisonOperator)Class8.smethod_1(typeof(ComparisonOperator), array[i + 1])
					};
					i += 2;
					stack.Push(Enum0.const_2);
					goto IL_0760;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "":
				stack.Push(Enum0.const_4);
				goto IL_0760;
			case "filename":
			case "name":
				if (array.Length > i + 2)
				{
					ComparisonOperator comparisonOperator2 = (ComparisonOperator)Class8.smethod_1(typeof(ComparisonOperator), array[i + 1]);
					if (comparisonOperator2 == ComparisonOperator.NotEqualTo || comparisonOperator2 == ComparisonOperator.EqualTo)
					{
						string text2 = array[i + 2];
						if (text2.StartsWith("'") && text2.EndsWith("'"))
						{
							text2 = text2.Substring(1, text2.Length - 2).Replace("\u0006", " ");
						}
						@class = new Class3
						{
							MatchingFileSpec = text2,
							comparisonOperator_0 = comparisonOperator2
						};
						i += 2;
						stack.Push(Enum0.const_2);
						goto IL_0760;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "and":
			case "or":
			case "xor":
				@enum = stack.Peek();
				if (@enum == Enum0.const_2)
				{
					if (array.Length > i + 3)
					{
						logicalConjunction = (LogicalConjunction)Enum.Parse(typeof(LogicalConjunction), array[i].ToUpper(), ignoreCase: true);
						@class = new Class6
						{
							class0_0 = @class,
							Class0_0 = null,
							logicalConjunction_0 = logicalConjunction
						};
						stack.Push(@enum);
						stack.Push(Enum0.const_3);
						stack2.Push(@class);
						goto IL_0760;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "ctime":
			case "atime":
			case "mtime":
				if (array.Length > i + 2)
				{
					DateTime value;
					try
					{
						value = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd-HH:mm:ss", null);
					}
					catch (FormatException)
					{
						try
						{
							value = DateTime.ParseExact(array[i + 2], "yyyy/MM/dd-HH:mm:ss", null);
						}
						catch (FormatException)
						{
							try
							{
								value = DateTime.ParseExact(array[i + 2], "yyyy/MM/dd", null);
								goto end_IL_0652;
							}
							catch (FormatException)
							{
								try
								{
									value = DateTime.ParseExact(array[i + 2], "MM/dd/yyyy", null);
									goto end_IL_0652;
								}
								catch (FormatException)
								{
									value = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd", null);
									goto end_IL_0652;
								}
							}
							end_IL_0652:;
						}
					}
					value = DateTime.SpecifyKind(value, DateTimeKind.Local).ToUniversalTime();
					@class = new Class2
					{
						whichTime_0 = (WhichTime)Enum.Parse(typeof(WhichTime), array[i], ignoreCase: true),
						comparisonOperator_0 = (ComparisonOperator)Class8.smethod_1(typeof(ComparisonOperator), array[i + 1]),
						dateTime_0 = value
					};
					i += 2;
					stack.Push(Enum0.const_2);
					goto IL_0760;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "type":
			case "attrs":
			case "attributes":
				if (array.Length > i + 2)
				{
					ComparisonOperator comparisonOperator = (ComparisonOperator)Class8.smethod_1(typeof(ComparisonOperator), array[i + 1]);
					if (comparisonOperator == ComparisonOperator.NotEqualTo || comparisonOperator == ComparisonOperator.EqualTo)
					{
						@class = ((text == "type") ? ((Class0)new Class4
						{
							String_0 = array[i + 2],
							comparisonOperator_0 = comparisonOperator
						}) : ((Class0)new Class5
						{
							String_0 = array[i + 2],
							comparisonOperator_0 = comparisonOperator
						}));
						i += 2;
						stack.Push(Enum0.const_2);
						goto IL_0760;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			default:
				{
					throw new ArgumentException("'" + array[i] + "'");
				}
				IL_0760:
				@enum = stack.Peek();
				if (@enum == Enum0.const_2)
				{
					stack.Pop();
					if (stack.Peek() == Enum0.const_3)
					{
						while (stack.Peek() == Enum0.const_3)
						{
							Class6 obj = stack2.Pop() as Class6;
							obj.Class0_0 = @class;
							@class = obj;
							stack.Pop();
							@enum = stack.Pop();
							if (@enum != Enum0.const_2)
							{
								throw new ArgumentException("??");
							}
						}
					}
					else
					{
						stack.Push(Enum0.const_2);
					}
				}
				if (@enum == Enum0.const_4)
				{
					stack.Pop();
				}
				break;
			}
		}
		return @class;
	}

	public override string ToString()
	{
		return "FileSelector(" + class0_0.ToString() + ")";
	}

	private bool method_0(string string_0)
	{
		return class0_0.Evaluate(string_0);
	}

	[Conditional("SelectorTrace")]
	private void method_1(string string_0, params object[] object_0)
	{
		if (class0_0 != null && class0_0.Verbose)
		{
			Console.WriteLine(string_0, object_0);
		}
	}

	public ICollection<string> method_2(string string_0)
	{
		return method_3(string_0, bool_1: false);
	}

	public ReadOnlyCollection<string> method_3(string string_0, bool bool_1)
	{
		if (class0_0 == null)
		{
			throw new ArgumentException("SelectionCriteria has not been set");
		}
		List<string> list = new List<string>();
		try
		{
			if (Directory.Exists(string_0))
			{
				string[] files = Directory.GetFiles(string_0);
				foreach (string text in files)
				{
					if (method_0(text))
					{
						list.Add(text);
					}
				}
				if (bool_1)
				{
					files = Directory.GetDirectories(string_0);
					foreach (string text2 in files)
					{
						if (Boolean_0 || (File.GetAttributes(text2) & FileAttributes.ReparsePoint) == 0)
						{
							if (method_0(text2))
							{
								list.Add(text2);
							}
							list.AddRange(method_3(text2, bool_1));
						}
					}
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (IOException)
		{
		}
		return list.AsReadOnly();
	}

	private bool method_4(GClass8 gclass8_0)
	{
		return class0_0.Evaluate(gclass8_0);
	}

	public ICollection<GClass8> method_5(GClass9 gclass9_0)
	{
		if (gclass9_0 == null)
		{
			throw new ArgumentNullException("zip");
		}
		List<GClass8> list = new List<GClass8>();
		foreach (GClass8 item in gclass9_0)
		{
			if (method_4(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public ICollection<GClass8> method_6(GClass9 gclass9_0, string string_0)
	{
		if (gclass9_0 == null)
		{
			throw new ArgumentNullException("zip");
		}
		List<GClass8> list = new List<GClass8>();
		string text = string_0?.Replace("/", "\\");
		if (text != null)
		{
			while (text.EndsWith("\\"))
			{
				text = text.Substring(0, text.Length - 1);
			}
		}
		foreach (GClass8 item in gclass9_0)
		{
			if ((string_0 == null || Path.GetDirectoryName(item.String_2) == string_0 || Path.GetDirectoryName(item.String_2) == text) && method_4(item))
			{
				list.Add(item);
			}
		}
		return list;
	}
}
