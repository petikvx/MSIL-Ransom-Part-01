using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ionic;
using ns1;
using ns11;
using ns12;
using ns2;
using ns5;
using ns7;
using ns9;

namespace ns10;

internal sealed class Class16
{
	private enum Enum4
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4
	}

	internal static class Class17
	{
		public static readonly string string_0 = "(?<=(?:[^']*'[^']*')*'[^']*)";

		public static readonly string string_1 = "(?=[^']*'(?:[^']*'[^']*')*[^']*$)";

		public static readonly string string_2 = "(?<=(?:[^']*'[^']*')*[^']*)";

		public static readonly string string_3 = "(?=(?:[^']*'[^']*')*[^']*$)";
	}

	internal Class9 class9_0;

	[CompilerGenerated]
	private bool bool_0;

	public Class16(string string_0, bool bool_1)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			class9_0 = smethod_0(string_0);
		}
		method_1(bool_1);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	private static Class9 smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		string_0 = Class6.smethod_271(string_0);
		if (string_0.IndexOf(" ") == -1)
		{
			string_0 = "name = " + string_0;
		}
		string[] array = string_0.Trim().Split(' ', '\t');
		if (array.Length < 3)
		{
			throw new ArgumentException(string_0);
		}
		Class9 @class = null;
		LogicalConjunction logicalConjunction = LogicalConjunction.NONE;
		Stack<Enum4> stack = new Stack<Enum4>();
		Stack<Class9> stack2 = new Stack<Class9>();
		stack.Push(Enum4.const_0);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].ToLower();
			Enum4 @enum;
			switch (text)
			{
			case "and":
			case "xor":
			case "or":
				@enum = stack.Peek();
				if (@enum == Enum4.const_2)
				{
					if (array.Length > i + 3)
					{
						logicalConjunction = (LogicalConjunction)Enum.Parse(typeof(LogicalConjunction), array[i].ToUpper(), ignoreCase: true);
						Class15 class7 = new Class15();
						class7.class9_0 = @class;
						Class6.smethod_346((Class9)null, class7);
						class7.logicalConjunction_0 = logicalConjunction;
						@class = class7;
						stack.Push(@enum);
						stack.Push(Enum4.const_3);
						stack2.Push(@class);
						goto IL_0681;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "(":
				@enum = stack.Peek();
				if (@enum == Enum4.const_0 || @enum == Enum4.const_3 || @enum == Enum4.const_1)
				{
					if (array.Length > i + 4)
					{
						stack.Push(Enum4.const_1);
						goto IL_0681;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case ")":
				@enum = stack.Pop();
				if (stack.Peek() == Enum4.const_1)
				{
					stack.Pop();
					stack.Push(Enum4.const_2);
					goto IL_0681;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "atime":
			case "ctime":
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
								goto end_IL_02e7;
							}
							catch (FormatException)
							{
								try
								{
									value = DateTime.ParseExact(array[i + 2], "MM/dd/yyyy", null);
									goto end_IL_02e7;
								}
								catch (FormatException)
								{
									value = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd", null);
									goto end_IL_02e7;
								}
							}
							end_IL_02e7:;
						}
					}
					value = DateTime.SpecifyKind(value, DateTimeKind.Local).ToUniversalTime();
					Class11 class5 = new Class11();
					class5.whichTime_0 = (WhichTime)Enum.Parse(typeof(WhichTime), array[i], ignoreCase: true);
					class5.comparisonOperator_0 = (ComparisonOperator)Class6.smethod_473(typeof(ComparisonOperator), array[i + 1]);
					class5.dateTime_0 = value;
					@class = class5;
					i += 2;
					stack.Push(Enum4.const_2);
					goto IL_0681;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "length":
			case "size":
				if (array.Length > i + 2)
				{
					long num = 0L;
					string text3 = array[i + 2];
					num = (text3.ToUpper().EndsWith("K") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L) : (text3.ToUpper().EndsWith("KB") ? (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L) : (text3.ToUpper().EndsWith("M") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L * 1024L) : (text3.ToUpper().EndsWith("MB") ? (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L * 1024L) : (text3.ToUpper().EndsWith("G") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L * 1024L * 1024L) : ((!text3.ToUpper().EndsWith("GB")) ? long.Parse(array[i + 2]) : (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L * 1024L * 1024L)))))));
					Class10 class8 = new Class10();
					class8.long_0 = num;
					class8.comparisonOperator_0 = (ComparisonOperator)Class6.smethod_473(typeof(ComparisonOperator), array[i + 1]);
					@class = class8;
					i += 2;
					stack.Push(Enum4.const_2);
					goto IL_0681;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "filename":
			case "name":
				if (array.Length > i + 2)
				{
					ComparisonOperator comparisonOperator2 = (ComparisonOperator)Class6.smethod_473(typeof(ComparisonOperator), array[i + 1]);
					if (comparisonOperator2 == ComparisonOperator.NotEqualTo || comparisonOperator2 == ComparisonOperator.EqualTo)
					{
						string text2 = array[i + 2];
						if (text2.StartsWith("'") && text2.EndsWith("'"))
						{
							text2 = text2.Substring(1, text2.Length - 2).Replace("\u0006", " ");
						}
						Class12 class4 = new Class12();
						class4.vmethod_2(text2);
						class4.comparisonOperator_0 = comparisonOperator2;
						@class = class4;
						i += 2;
						stack.Push(Enum4.const_2);
						goto IL_0681;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "attrs":
			case "attributes":
			case "type":
				if (array.Length > i + 2)
				{
					ComparisonOperator comparisonOperator = (ComparisonOperator)Class6.smethod_473(typeof(ComparisonOperator), array[i + 1]);
					if (comparisonOperator == ComparisonOperator.NotEqualTo || comparisonOperator == ComparisonOperator.EqualTo)
					{
						object obj;
						if (!(text == "type"))
						{
							Class14 class2 = new Class14();
							Class6.smethod_365(class2, array[i + 2]);
							class2.comparisonOperator_0 = comparisonOperator;
							obj = class2;
						}
						else
						{
							Class13 class3 = new Class13();
							Class6.smethod_428(class3, array[i + 2]);
							class3.comparisonOperator_0 = comparisonOperator;
							obj = class3;
						}
						@class = (Class9)obj;
						i += 2;
						stack.Push(Enum4.const_2);
						goto IL_0681;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "":
				stack.Push(Enum4.const_4);
				goto IL_0681;
			default:
				{
					throw new ArgumentException("'" + array[i] + "'");
				}
				IL_0681:
				@enum = stack.Peek();
				if (@enum == Enum4.const_2)
				{
					stack.Pop();
					if (stack.Peek() == Enum4.const_3)
					{
						while (stack.Peek() == Enum4.const_3)
						{
							Class15 class6 = stack2.Pop() as Class15;
							Class6.smethod_346(@class, class6);
							@class = class6;
							stack.Pop();
							@enum = stack.Pop();
							if (@enum != Enum4.const_2)
							{
								throw new ArgumentException("??");
							}
						}
					}
					else
					{
						stack.Push(Enum4.const_2);
					}
				}
				if (@enum == Enum4.const_4)
				{
					stack.Pop();
				}
				break;
			}
		}
		return @class;
	}

	string object.ToString()
	{
		return "FileSelector(" + class9_0.ToString() + ")";
	}
}
