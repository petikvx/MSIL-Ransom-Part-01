using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class CodeString
{
	private string txt;

	private bool withFormating;

	private string Razdeliteli;

	private string[] splits;

	public string Text
	{
		get
		{
			return txt;
		}
		set
		{
			txt = value;
			if (withFormating)
			{
				AutoKovichki();
			}
		}
	}

	public CodeString(string str, string Razdeliteli = "All", bool withFormating = true)
	{
		this.withFormating = true;
		this.withFormating = withFormating;
		this.Razdeliteli = Razdeliteli;
		checked
		{
			if (Razdeliteli.IndexOf("All") == 0)
			{
				splits = peremens.uslovs;
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = ",";
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = "(";
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = ")";
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = "[";
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = "]";
				if (Operators.CompareString(Razdeliteli, "AllWithAndOr", false) == 0)
				{
					splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
					splits[splits.Length - 1] = "And";
					splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
					splits[splits.Length - 1] = "Or";
				}
				Text = str;
			}
			else if ((Operators.CompareString(Razdeliteli, "Uslovs", false) == 0) | (Operators.CompareString(Razdeliteli, "True", false) == 0))
			{
				splits = peremens.uslovs;
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = ",";
				Text = str;
			}
			else if (Operators.CompareString(Razdeliteli, "UslovsBezZapyatoi", false) == 0)
			{
				splits = peremens.uslovs;
				Text = str;
			}
			else if ((Operators.CompareString(Razdeliteli, "Opers", false) == 0) | (Operators.CompareString(Razdeliteli, "False", false) == 0))
			{
				splits = peremens.opers;
				splits = (string[])Utils.CopyArray((Array)splits, (Array)new string[splits.Length + 1]);
				splits[splits.Length - 1] = ",";
				Text = str;
			}
			else if (Operators.CompareString(Razdeliteli, "<=> and high", false) == 0)
			{
				peremens.ReDims(ref splits);
				splits[splits.Length - 1] = "<=>";
				peremens.ReDims(ref splits);
				splits[splits.Length - 1] = "And";
				peremens.ReDims(ref splits);
				splits[splits.Length - 1] = "Or";
				Text = str;
			}
			else if (Operators.CompareString(Razdeliteli, "None", false) == 0)
			{
				txt = str;
			}
		}
	}

	public void AutoKovichki()
	{
		string text = "";
		MySplitStruct mySplitStruct = Split("vezde");
		checked
		{
			int num = mySplitStruct.texty.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(mySplitStruct.texty[i], "", false) != 0)
				{
					string text2 = mySplitStruct.texty[i];
					int num2 = 0;
					if (!Versioned.IsNumeric((object)text2))
					{
						object proj = peremens2.proj;
						object[] array = new object[1] { text2 };
						bool[] array2 = new bool[1] { true };
						object obj = NewLateBinding.LateGet(proj, (Type)null, "isString", array, (string[])null, (Type[])null, array2);
						if (array2[0])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						if (Conversions.ToBoolean(obj))
						{
							char[] trimChars = new char[5] { '(', ')', '[', ']', ' ' };
							string text3 = text2.Trim(trimChars);
							if (Operators.CompareString(text3, "", false) != 0 && ((Operators.CompareString(Conversions.ToString(text3[0]), "\"", false) != 0) | (Operators.CompareString(Conversions.ToString(text3[text3.Length - 1]), "\"", false) != 0)))
							{
								mySplitStruct.texty[i] = mySplitStruct.texty[i].Replace(text2, peremens.CreateKovich(text2));
								text2 = peremens.CreateKovich(text2);
								mySplitStruct.texty[i] = mySplitStruct.texty[i].Insert(num2, "\"");
								mySplitStruct.texty[i] = mySplitStruct.texty[i].Insert(num2 + text2.Length + 1, "\"");
							}
						}
					}
					text += mySplitStruct.texty[i];
				}
				if (mySplitStruct.splity != null && i < mySplitStruct.splity.Length)
				{
					text = ((Operators.CompareString(mySplitStruct.splity[i], ",", false) != 0) ? ((!((Operators.CompareString(mySplitStruct.splity[i], "(", false) == 0) | (Operators.CompareString(mySplitStruct.splity[i], ")", false) == 0) | (Operators.CompareString(mySplitStruct.splity[i], "[", false) == 0) | (Operators.CompareString(mySplitStruct.splity[i], "]", false) == 0))) ? (text + " " + mySplitStruct.splity[i] + " ") : (text + mySplitStruct.splity[i])) : (text + mySplitStruct.splity[i] + " "));
				}
			}
			txt = text;
		}
	}

	public int PerviyNeSkobka(string str)
	{
		checked
		{
			int num = str.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (Operators.CompareString(Conversions.ToString(str[num2]), "(", false) != 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return 0;
			}
			return num2;
		}
	}

	public int PosledniyNeSkobka(string str)
	{
		checked
		{
			int num = str.Length - 1;
			while (true)
			{
				if (num >= 0)
				{
					if (Operators.CompareString(Conversions.ToString(str[num]), ")", false) != 0)
					{
						break;
					}
					num += -1;
					continue;
				}
				return 0;
			}
			return num;
		}
	}

	public int IndexOf(string str, int start = 0, bool naOdnomUrovne = false)
	{
		int num = start;
		if (Operators.CompareString(txt, "", false) == 0)
		{
			return -1;
		}
		while (true)
		{
			if (num <= checked(txt.Length - 1))
			{
				if (Operators.CompareString(Conversions.ToString(txt[num]), "(", false) == 0 && naOdnomUrovne)
				{
					num = Conversions.ToInteger(PropuskSkobok(num, "(", ")"));
				}
				else if (Operators.CompareString(Conversions.ToString(txt[num]), "[", false) == 0 && naOdnomUrovne)
				{
					num = Conversions.ToInteger(PropuskSkobok(num, "[", "]"));
				}
				else if (((Operators.CompareString(Conversions.ToString(txt[num]), ")", false) == 0) | (Operators.CompareString(Conversions.ToString(txt[num]), "]", false) == 0)) && naOdnomUrovne)
				{
					return -1;
				}
				checked
				{
					if (num != -1)
					{
						if (Operators.CompareString(Conversions.ToString(txt[num]), "\"", false) == 0)
						{
							num = PropuskKovich(num);
							if (num == -1)
							{
								return -1;
							}
						}
						if (num <= Text.Length - 1)
						{
							if (str.Length - 1 <= txt.Length - 1 - num)
							{
								if (Operators.CompareString(Strings.UCase(txt.Substring(num, str.Length)), Strings.UCase(str), false) == 0)
								{
									break;
								}
								num++;
								continue;
							}
							return -1;
						}
						return -1;
					}
					return -1;
				}
			}
			return -1;
		}
		return num;
	}

	public int LastIndexOf(string str, int start = 0, bool naOdnomUrovne = false)
	{
		if (start == 0)
		{
			start = str.Length;
		}
		if (Operators.CompareString(txt, "", false) == 0)
		{
			return -1;
		}
		int num = checked(txt.Length - start);
		while (true)
		{
			if (num > -1)
			{
				if (Operators.CompareString(Conversions.ToString(txt[num]), ")", false) == 0 && naOdnomUrovne)
				{
					num = Conversions.ToInteger(PropuskSkobokLast(num, ")", "("));
				}
				else if (Operators.CompareString(Conversions.ToString(txt[num]), "]", false) == 0 && naOdnomUrovne)
				{
					num = Conversions.ToInteger(PropuskSkobokLast(num, "]", "["));
				}
				else if (((Operators.CompareString(Conversions.ToString(txt[num]), "(", false) == 0) | (Operators.CompareString(Conversions.ToString(txt[num]), "[", false) == 0)) && naOdnomUrovne)
				{
					return -1;
				}
				if (num != -1)
				{
					if (Operators.CompareString(Conversions.ToString(txt[num]), "\"", false) == 0)
					{
						num = PropuskKovichLast(num);
						if (num == -1)
						{
							return -1;
						}
					}
					if (Operators.CompareString(Strings.UCase(txt.Substring(num, str.Length)), Strings.UCase(str), false) == 0)
					{
						break;
					}
					num = checked(num - 1);
					continue;
				}
				return -1;
			}
			return -1;
		}
		return num;
	}

	public object PropuskSkobok(int ind, string skobkaOpen, string skobkaClose)
	{
		int num = 1;
		checked
		{
			int num3;
			do
			{
				if (ind + 1 <= txt.Length - 1)
				{
					int num2 = IndexOf(skobkaOpen, ind + 1);
					num3 = IndexOf(skobkaClose, ind + 1);
					if (num3 != -1)
					{
						if (num2 == -1)
						{
							num2 = txt.Length;
						}
						if (num2 < num3)
						{
							num++;
							ind = num2;
						}
						else
						{
							num--;
							ind = num3;
						}
						continue;
					}
					return -1;
				}
				return -1;
			}
			while (num > 0);
			return num3;
		}
	}

	public object PropuskSkobokLast(int ind, string skobkaOpen, string skobkaClose)
	{
		int num = 1;
		checked
		{
			int num3;
			do
			{
				if (ind - 1 >= 0)
				{
					int num2 = LastIndexOf(skobkaOpen, ind - 1);
					num3 = LastIndexOf(skobkaClose, ind - 1);
					if (num3 != -1)
					{
						if (num2 == -1)
						{
							num2 = 0;
						}
						if (num2 < num3)
						{
							num++;
							ind = num2;
						}
						else
						{
							num--;
							ind = num3;
						}
						continue;
					}
					return -1;
				}
				return -1;
			}
			while (num > 0);
			return num3;
		}
	}

	public int PropuskKovich(int ind)
	{
		checked
		{
			int num = txt.IndexOf("\"", ind + 1);
			if (num + 1 < txt.Length - 1)
			{
				while (Operators.CompareString(Conversions.ToString(txt[num + 1]), "\"", false) == 0)
				{
					num = txt.IndexOf("\"", num + 2);
					if (num != -1)
					{
						if (num + 1 > txt.Length - 1)
						{
							break;
						}
						continue;
					}
					return -1;
				}
			}
			if (num <= ind)
			{
				return -1;
			}
			return num;
		}
	}

	public int PropuskKovichLast(int ind)
	{
		checked
		{
			int num = txt.LastIndexOf("\"", ind - 1);
			if (num > 1)
			{
				while (Operators.CompareString(Conversions.ToString(txt[num - 1]), "\"", false) == 0)
				{
					num = txt.LastIndexOf("\"", num - 2);
					if (num != -1)
					{
						if (num < 2)
						{
							break;
						}
						continue;
					}
					return -1;
				}
			}
			if (num >= ind)
			{
				return -1;
			}
			return num;
		}
	}

	public MySplitStruct Split(string naUrovne, params string[] spl)
	{
		object obj = 0;
		object obj2 = 0;
		object obj3 = 0;
		object obj4 = 0;
		string[] mass = null;
		string[] mass2 = null;
		int[] mass3 = null;
		string text = "";
		string text2 = "";
		bool flag = false;
		bool flag2 = false;
		if (spl.Length == 0)
		{
			spl = splits;
		}
		if (spl == null)
		{
			spl = new string[1] { "~)!(@*#&$^%A:SLDK" };
		}
		checked
		{
			while (Operators.ConditionalCompareObjectLessEqual(obj, (object)(txt.Length - 1), false))
			{
				if (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "\"", false) == 0)
				{
					int num = PropuskKovich(Conversions.ToInteger(obj));
					if (num != -1)
					{
						obj = num + 1;
					}
				}
				if (Operators.ConditionalCompareObjectGreater(obj, (object)(txt.Length - 1), false))
				{
					break;
				}
				if ((Operators.CompareString(naUrovne, "naOdnomUrovne", false) == 0) | unchecked(Operators.CompareString(naUrovne, "naVtoromUrovne", false) == 0 && flag))
				{
					if ((Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "(", false) == 0) | ((Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), ",", false) == 0) & (Operators.CompareString(spl[0], ".", false) != 0) & (Operators.CompareString(spl[0], ",", false) != 0) & (Operators.CompareString(spl[0], "~)!(@*#&$^%A:SLDK", false) != 0)))
					{
						if (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), ",", false) == 0)
						{
							text2 = Strings.Trim(txt.Substring(Conversions.ToInteger(obj2), Conversions.ToInteger(Operators.SubtractObject(obj, obj2))));
							text = ",";
						}
						else
						{
							int num2 = Conversions.ToInteger(PropuskSkobok(Conversions.ToInteger(obj), "(", ")"));
							if (num2 != -1)
							{
								obj = num2 + 1;
								flag2 = true;
							}
						}
					}
					else if (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "[", false) == 0)
					{
						int num2 = Conversions.ToInteger(PropuskSkobok(Conversions.ToInteger(obj), "[", "]"));
						if (num2 != -1)
						{
							obj = num2 + 1;
						}
					}
					else if ((Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), ")", false) == 0) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "]", false) == 0))
					{
						if (Operators.CompareString(naUrovne, "naVtoromUrovne", false) != 0)
						{
							break;
						}
						obj3 = Operators.SubtractObject((object)txt.Length, obj);
						flag = false;
						obj = Operators.AddObject(obj, (object)1);
						flag2 = true;
					}
				}
				else if (unchecked(Operators.CompareString(naUrovne, "naVtoromUrovne", false) == 0 && !flag))
				{
					if ((Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "(", false) == 0) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "[", false) == 0))
					{
						obj4 = Operators.AddObject(obj4, Operators.AddObject(obj, (object)1));
						txt = txt.Substring(Conversions.ToInteger(Operators.AddObject(obj, (object)1)));
						obj2 = 0;
						flag = true;
						obj = 0;
						continue;
					}
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)0, false))
					{
						obj = Operators.AddObject(obj, (object)1);
						continue;
					}
				}
				if (Operators.ConditionalCompareObjectGreater(obj, (object)(txt.Length - 1), false))
				{
					break;
				}
				if (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(obj)]), "\"", false) == 0)
				{
					int num = PropuskKovich(Conversions.ToInteger(obj));
					if (num != -1)
					{
						obj = num;
					}
				}
				if (Operators.ConditionalCompareObjectGreater(obj, (object)(txt.Length - 1), false))
				{
					break;
				}
				if ((Operators.CompareString(text, "", false) == 0) & (Operators.CompareString(text2, "", false) == 0) & (!flag | (flag & (Operators.CompareString(naUrovne, "naVtoromUrovne", false) == 0) & (Operators.CompareString(spl[0], "<=>", false) == 0))))
				{
					int num3 = spl.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						if (Operators.ConditionalCompareObjectGreater((object)(spl[i].Length - 1), Operators.SubtractObject((object)(txt.Length - 1), obj), false) || Operators.CompareString(Strings.UCase(txt.Substring(Conversions.ToInteger(obj), spl[i].Length)), Strings.UCase(spl[i]), false) != 0 || (((Operators.CompareString(text, "", false) != 0) & (Operators.CompareString(text2, "", false) != 0)) && spl[i].Length < text.Length))
						{
							continue;
						}
						if ((Operators.CompareString(Strings.UCase(spl[i]), Strings.UCase(peremens.MyZnak + peremens.trans("И")), false) == 0) | (Operators.CompareString(Strings.UCase(spl[i]), Strings.UCase(peremens.MyZnak + peremens.trans("ИЛИ")), false) == 0) | ((Operators.CompareString(Strings.UCase(spl[i]), peremens.MyZnak + Strings.UCase("And"), false) == 0) | (Operators.CompareString(Strings.UCase(spl[i]), peremens.MyZnak + Strings.UCase("Or"), false) == 0)))
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater((object)txt.Length, Operators.AddObject(obj, (object)spl[i].Length), false), Operators.CompareObjectGreater(obj, (object)0, false))))
							{
								if (char.IsLetterOrDigit(txt[Conversions.ToInteger(Operators.AddObject(obj, (object)spl[i].Length))]) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.AddObject(obj, (object)spl[i].Length))]), "_", false) == 0) | (char.IsLetterOrDigit(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]), "_", false) == 0)))
								{
									continue;
								}
							}
							else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual((object)txt.Length, Operators.AddObject(obj, (object)spl[i].Length), false), Operators.CompareObjectGreater(obj, (object)0, false))) && (char.IsLetterOrDigit(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]), "_", false) == 0)))
							{
								continue;
							}
						}
						else if ((Operators.CompareString(Strings.UCase(spl[i]), Strings.UCase("And"), false) == 0) | (Operators.CompareString(Strings.UCase(spl[i]), Strings.UCase("Or"), false) == 0))
						{
							if ((Operators.CompareString(Razdeliteli, "<=> and high", false) != 0) & (Operators.CompareString(Razdeliteli, "AllWithAndOr", false) != 0))
							{
								continue;
							}
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater((object)txt.Length, Operators.AddObject(obj, (object)spl[i].Length), false), Operators.CompareObjectGreater(obj, (object)0, false))))
							{
								if (char.IsLetterOrDigit(txt[Conversions.ToInteger(Operators.AddObject(obj, (object)spl[i].Length))]) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.AddObject(obj, (object)spl[i].Length))]), "_", false) == 0) | (char.IsLetterOrDigit(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]), "_", false) == 0)))
								{
									continue;
								}
							}
							else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual((object)txt.Length, Operators.AddObject(obj, (object)spl[i].Length), false), Operators.CompareObjectGreater(obj, (object)0, false))) && (char.IsLetterOrDigit(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]) | (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]), "_", false) == 0)))
							{
								continue;
							}
							int num4 = txt.IndexOf(peremens.MyZnak + peremens.trans("Файлы и папки", toEng: true));
							if (Conversions.ToBoolean(Operators.AndObject((object)(num4 != -1), Operators.CompareObjectLess(obj, (object)(num4 + (peremens.MyZnak + peremens.trans("Файлы и папки", toEng: true)).Length), false))))
							{
								continue;
							}
						}
						text = spl[i];
						if (Operators.ConditionalCompareObjectEqual(obj3, (object)0, false))
						{
							text2 = txt.Substring(Conversions.ToInteger(obj2), Conversions.ToInteger(Operators.SubtractObject(obj, obj2)));
						}
						else if (Operators.ConditionalCompareObjectGreaterEqual(Operators.SubtractObject(Operators.SubtractObject((object)txt.Length, obj3), obj2), (object)0, false))
						{
							text2 = txt.Substring(Conversions.ToInteger(obj2), Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((object)txt.Length, obj3), obj2)));
							obj3 = 0;
						}
						if ((((Operators.CompareString(text, "-", false) == 0) | (Operators.CompareString(text, "+", false) == 0)) & (Operators.CompareString(Strings.Trim(text2), "", false) == 0)) && mass != null && Array.IndexOf(peremens.uslovs, mass[mass.Length - 1]) != -1)
						{
							text = "";
							text2 = "";
							break;
						}
					}
				}
				if ((Operators.CompareString(text, "", false) != 0) | (Operators.CompareString(text2, "", false) != 0))
				{
					peremens.ReDims(ref mass);
					mass[mass.Length - 1] = Strings.UCase(Strings.Trim(text));
					peremens.ReDims(ref mass2);
					mass2[mass2.Length - 1] = Strings.Trim(text2);
					peremens.ReDims(ref mass3);
					mass3[mass3.Length - 1] = Conversions.ToInteger(Operators.AddObject(obj2, obj4));
					obj2 = Operators.AddObject(obj, (object)text.Length);
					text = "";
					text2 = "";
					Conversions.ToInteger(obj);
					obj = Operators.SubtractObject(obj2, (object)1);
				}
				obj = Operators.AddObject(obj, (object)1);
				if (flag2 & (Operators.CompareString(spl[0], ",", false) != 0))
				{
					obj = Operators.SubtractObject(obj, (object)1);
					flag2 = false;
				}
			}
			text2 = txt.Substring(Conversions.ToInteger(obj2), Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((object)txt.Length, obj2), obj3)));
			peremens.ReDims(ref mass2);
			mass2[mass2.Length - 1] = Strings.Trim(text2);
			peremens.ReDims(ref mass3);
			mass3[mass3.Length - 1] = Conversions.ToInteger(Operators.AddObject(obj2, obj4));
			return new MySplitStruct(mass, mass2, mass3);
		}
	}

	public void temp()
	{
		object obj = default(object);
		object objectValue = RuntimeHelpers.GetObjectValue(obj);
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)txt, (Type)null, "IndexOf", new object[2]
		{
			"\"",
			Operators.AddObject(objectValue, (object)1)
		}, (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(objectValue2, (object)(-1), false))
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
		}
		checked
		{
			if (Operators.ConditionalCompareObjectLess(Operators.AddObject(objectValue2, (object)1), (object)(txt.Length - 1), false))
			{
				while (Operators.CompareString(Conversions.ToString(txt[Conversions.ToInteger(Operators.AddObject(objectValue2, (object)1))]), "\"", false) == 0)
				{
					objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)txt, (Type)null, "IndexOf", new object[2]
					{
						"\"",
						Operators.AddObject(objectValue2, (object)2)
					}, (string[])null, (Type[])null, (bool[])null));
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreaterEqual(Operators.AddObject(objectValue2, (object)1), (object)(txt.Length - 1), false), Operators.CompareObjectEqual(objectValue2, (object)(-1), false))))
					{
						break;
					}
				}
			}
			if (Operators.ConditionalCompareObjectEqual(objectValue2, (object)(-1), false))
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
			}
			if (Operators.ConditionalCompareObjectLess(objectValue2, objectValue, false))
			{
				object obj2 = ((obj2 != null) ? ((object[])Utils.CopyArray((Array)obj2, (Array)new object[Conversions.ToInteger(NewLateBinding.LateGet(obj2, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1])) : ((object[])Utils.CopyArray((Array)obj2, (Array)new object[1])));
				object obj3 = default(object);
				NewLateBinding.LateIndexSet(obj2, new object[2]
				{
					Operators.SubtractObject(NewLateBinding.LateGet(obj2, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
					txt.Substring(Conversions.ToInteger(obj3), Conversions.ToInteger(Operators.SubtractObject((object)(txt.Length - 1), obj3)))
				}, (string[])null);
			}
			obj = RuntimeHelpers.GetObjectValue(objectValue2);
		}
	}
}
