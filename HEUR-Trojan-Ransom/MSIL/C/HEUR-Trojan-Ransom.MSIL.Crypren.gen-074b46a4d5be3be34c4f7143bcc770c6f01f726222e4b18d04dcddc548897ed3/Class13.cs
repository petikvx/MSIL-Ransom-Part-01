using System;
using System.Collections;

internal class Class13
{
	internal readonly string string_0;

	private ArrayList arrayList_0;

	private Hashtable hashtable_0;

	internal Class13()
		: this(null)
	{
	}

	internal Class13(string string_1)
	{
		string_0 = string_1;
		while (true)
		{
			int num = Class46.Class47.smethod_0(75);
			while (true)
			{
				switch (num ^ Class84.smethod_0(406))
				{
				case -101:
					arrayList_0 = new ArrayList();
					num = Class89.smethod_1(54);
					continue;
				case -102:
					hashtable_0 = new Hashtable();
					num = -2;
					continue;
				case -103:
					num = -1;
					continue;
				case -104:
					Delegate339.smethod_0(this, string_1);
					num = -6;
					continue;
				case -100:
					return;
				}
				break;
			}
		}
	}

	internal static string smethod_0(string string_1, string string_2)
	{
		Class13 object_ = Delegate340.smethod_0(string_1);
		return Delegate341.smethod_0(object_, string_2);
	}

	internal ArrayList method_0(string string_1)
	{
		if (string_1 == null && 0 == 0)
		{
			return arrayList_0;
		}
		return hashtable_0[string_1] as ArrayList;
	}

	internal string method_1(string string_1)
	{
		if (string_1 == null && 0 == 0)
		{
			throw new ArgumentNullException();
		}
		ArrayList arrayList = Delegate342.smethod_0(this, string_1);
		if (arrayList == null && 0 == 0)
		{
			return null;
		}
		Class22 @class = arrayList[Class84.smethod_0(0)] as Class22;
		if (@class == null && 0 == 0)
		{
			return string.Empty;
		}
		return @class.string_1;
	}

	private void method_2(string string_1)
	{
		arrayList_0.Clear();
		hashtable_0.Clear();
		if (string_1 == null && 0 == 0)
		{
			return;
		}
		char[] array = new char[Class84.smethod_0(1)];
		array[Class84.smethod_0(0)] = (char)Class84.smethod_0(41);
		string[] array2 = string_1.Split(array);
		string[] array3 = default(string[]);
		int i = default(int);
		ArrayList arrayList = default(ArrayList);
		while (true)
		{
			int num = Class84.smethod_0(7);
			int num2 = Class84.smethod_0(43);
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(67))
				{
				case 117:
					num ^= Class84.smethod_0(51);
					goto default;
				default:
					num2 = Class84.smethod_0(71);
					continue;
				case 116:
					num2 = 28;
					continue;
				case 115:
					switch (num)
					{
					default:
						num2 = 26;
						continue;
					case 110:
						array3 = array2;
						num = 29;
						break;
					case 111:
						num = Class84.smethod_0(6);
						break;
					case 112:
						i = Class84.smethod_0(0);
						num = 28;
						break;
					case 113:
						for (; i < array3.Length; i += Class84.smethod_0(1))
						{
							string text = array3[i];
							if ((text.Length == 0) ? true : false)
							{
								continue;
							}
							char[] array4 = new char[Class84.smethod_0(1)];
							array4[Class84.smethod_0(0)] = (char)Class84.smethod_0(130);
							string[] array5 = text.Split(array4, Class84.smethod_0(6));
							if ((array5.Length == 0) ? true : false)
							{
								continue;
							}
							Class22 @class = Delegate343.smethod_0(array5[Class84.smethod_0(0)].Trim().ToLower());
							@class.string_1 = ((array5.Length < Class84.smethod_0(6)) ? "" : array5[Class84.smethod_0(1)]);
							while (true)
							{
								int num3 = Class49.smethod_0(83);
								while (true)
								{
									switch (num3 ^ Class84.smethod_0(412))
									{
									case -109:
										num3 = -1;
										continue;
									case -110:
										arrayList_0.Add(@class);
										num3 = -3;
										continue;
									case -111:
										arrayList = hashtable_0[@class.string_0] as ArrayList;
										num3 = -4;
										continue;
									case -112:
										break;
									default:
										goto end_IL_01b5;
									case -108:
										goto IL_020d;
									}
									if (arrayList != null)
									{
										num3 = Class89.smethod_1(55);
										continue;
									}
									if (0 == 0)
									{
										arrayList = new ArrayList();
										hashtable_0[@class.string_0] = arrayList;
									}
									goto IL_020d;
									IL_020d:
									arrayList.Add(@class);
									goto end_IL_01e2;
									continue;
									end_IL_01b5:
									break;
								}
								continue;
								end_IL_01e2:
								break;
							}
						}
						return;
					}
					goto case 117;
				case 114:
					break;
				}
				break;
			}
		}
	}
}
