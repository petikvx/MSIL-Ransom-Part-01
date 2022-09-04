using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class PropertysOther
{
	public object obj;

	public string errFind;

	public string top;

	private byte[] IV;

	private string WCCan;

	private string WCOk;

	private string WCRet;

	private string WCYes;

	private string WCNo;

	private string WCAb;

	private string WCIgn;

	private string WCHelp;

	public string Name
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateSet(obj, (Type)null, "Name", new object[1] { value }, (string[])null, (Type[])null);
			if (peremens2.proj != null)
			{
				object proj = peremens2.proj;
				object[] array = new object[2] { this, text };
				bool[] array2 = new bool[2] { false, true };
				NewLateBinding.LateCall(proj, (Type)null, "ChangeName", array, (string[])null, (Type[])null, array2, true);
				if (array2[1])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
			}
		}
	}

	public string Index
	{
		get
		{
			return "0";
		}
		set
		{
		}
	}

	public string Type
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (objectValue != null)
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "defaultName", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return "";
		}
		set
		{
		}
	}

	public object Hider
	{
		get
		{
			return GetAttribs(args, "Hidden");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "Hidden");
		}
	}

	public object FileReadOnly
	{
		get
		{
			return GetAttribs(args, "ReadOnly");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "ReadOnly");
		}
	}

	public object Archive
	{
		get
		{
			return GetAttribs(args, "Archive");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "Archive");
		}
	}

	public object Folder
	{
		get
		{
			return GetAttribs(args, "Directory");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "Directory");
		}
	}

	public object Encrypted
	{
		get
		{
			return GetAttribs(args, "Encrypted");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "Encrypted");
		}
	}

	public object notIndexer
	{
		get
		{
			return GetAttribs(args, "NotContentIndexed");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "NotContentIndexed");
		}
	}

	public object Sys
	{
		get
		{
			return GetAttribs(args, "System");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "System");
		}
	}

	public object Temp
	{
		get
		{
			return GetAttribs(args, "Temporary");
		}
		set
		{
			SetAttribs(args, Conversions.ToString(value), "Temporary");
		}
	}

	public object CreateTime
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return peremens.ToMyDate(File.GetCreationTime(str));
		}
		set
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			if (File.Exists(str))
			{
				File.SetCreationTime(str, Conversions.ToDate(value));
			}
			else if (Directory.Exists(str))
			{
				Directory.SetCreationTime(str, Conversions.ToDate(value));
			}
		}
	}

	public object AccessTime
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return peremens.ToMyDate(File.GetLastAccessTime(str));
		}
		set
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			if (File.Exists(str))
			{
				File.SetLastAccessTime(str, Conversions.ToDate(value));
			}
			else if (Directory.Exists(str))
			{
				Directory.SetLastAccessTime(str, Conversions.ToDate(value));
			}
		}
	}

	public object EditTime
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return peremens.ToMyDate(File.GetLastWriteTime(str));
		}
		set
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			if (File.Exists(str))
			{
				File.SetLastWriteTime(str, Conversions.ToDate(value));
			}
			else if (Directory.Exists(str))
			{
				Directory.SetLastWriteTime(str, Conversions.ToDate(value));
			}
		}
	}

	public object ExistFile
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return peremens.DaOrNet(File.Exists(str));
		}
		set
		{
		}
	}

	public object ExistPath
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return peremens.DaOrNet(Directory.Exists(str));
		}
		set
		{
		}
	}

	public object GetFiles
	{
		get
		{
			string text = "";
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			string[] files = Directory.GetFiles(str);
			checked
			{
				int num = files.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += files[i];
					if (i < files.Length - 1)
					{
						text += "; ";
					}
				}
				return text;
			}
		}
		set
		{
		}
	}

	public object GetPaths
	{
		get
		{
			string text = "";
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			string[] directories = Directory.GetDirectories(str);
			checked
			{
				int num = directories.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += directories[i];
					if (i < directories.Length - 1)
					{
						text += "; ";
					}
				}
				return text;
			}
		}
		set
		{
		}
	}

	public object GetRoot
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return Directory.GetDirectoryRoot(str);
		}
		set
		{
		}
	}

	public object GetParent
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return Path.GetDirectoryName(str);
		}
		set
		{
		}
	}

	public object GetDrives
	{
		get
		{
			string text = "";
			string[] logicalDrives = Directory.GetLogicalDrives();
			checked
			{
				int num = logicalDrives.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += logicalDrives[i];
					if (i < logicalDrives.Length - 1)
					{
						text += "; ";
					}
				}
				return text;
			}
		}
		set
		{
		}
	}

	public object GetPathName
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return Directory.GetParent(str)!.get_Name();
		}
		set
		{
		}
	}

	public object GetFileName
	{
		get
		{
			string str = peremens.UbratKovich(args[0]).str;
			return Path.GetFileName(str);
		}
		set
		{
		}
	}

	public object GetExtension
	{
		get
		{
			string str = peremens.UbratKovich(args[0]).str;
			return Path.GetExtension(str);
		}
		set
		{
		}
	}

	public object GetFileNameWithoutExtension
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			if (Directory.Exists(str))
			{
				return Path.GetFileName(str);
			}
			return Path.GetFileNameWithoutExtension(str);
		}
		set
		{
		}
	}

	public object GetFileSize
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			if (Operators.CompareString(peremens.NikakoiEsli(str), peremens.trans("Никакой"), false) == 0)
			{
				return "0";
			}
			object result = default(object);
			try
			{
				FileInfo fileInfo = new FileInfo(str);
				result = fileInfo.Length;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
				}
				ProjectData.ClearProjectError();
				return result;
			}
		}
		set
		{
		}
	}

	public object FilesCount
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return Directory.GetFiles(str).Length;
		}
		set
		{
		}
	}

	public object DirectoriesCount
	{
		get
		{
			string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
			return Directory.GetDirectories(str).Length;
		}
		set
		{
		}
	}

	public string WallPaper
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			peremens.SystemParametersInfo(115u, stringBuilder.Capacity, stringBuilder, 0u);
			if (peremens.isDevelop & !peremens.isRUN())
			{
				return "\"" + stringBuilder.ToString() + "\"";
			}
			return stringBuilder.ToString();
		}
		set
		{
			value = peremens.GetMaxPath(value);
			StringBuilder pvParam = new StringBuilder(value, 256);
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					peremens.SystemParametersInfo(20u, 0, pvParam, 3u);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			peremens.SystemParametersInfo(20u, 0, new StringBuilder(256), 3u);
		}
	}

	public string DesktopStyle
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\\\Desktop", writable: true);
			string value = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey.GetValue("WallpaperStyle"), (object)","), registryKey.GetValue("TileWallpaper")));
			int num = peremens.DeskStyle.IndexOfValue(value);
			if (num != -1)
			{
				return Conversions.ToString(peremens.DeskStyle.GetKey(num));
			}
			return peremens.trans("Никакой");
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				return;
			}
			StringBuilder pvParam = new StringBuilder(peremens.UbratKovich(WallPaper).str, 256);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\\\Desktop", writable: true);
			string[] array = (string[])NewLateBinding.LateGet(peremens.DeskStyle.GetByIndex(peremens.DeskStyle.IndexOfKey(Strings.LCase(value))), (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null);
			if (array.Length < 2)
			{
				return;
			}
			try
			{
				registryKey.SetValue("WallpaperStyle", array[0]);
				registryKey.SetValue("TileWallpaper", array[1]);
				peremens.SystemParametersInfo(20u, 0, pvParam, 3u);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string DesktopResolution
	{
		get
		{
			peremens.DevMode lpDevMode = default(peremens.DevMode);
			peremens.EnumDisplaySettings(null, -1, ref lpDevMode);
			return Conversions.ToString(lpDevMode.dmPelsWidth) + "x" + Conversions.ToString(lpDevMode.dmPelsHeight);
		}
		set
		{
			string text = "";
			peremens.DevMode lpDevMode = default(peremens.DevMode);
			peremens.EnumDisplaySettings(null, -1, ref lpDevMode);
			lpDevMode.dmPelsWidth = Conversions.ToInteger(value.Split(new char[1] { 'x' })[0]);
			lpDevMode.dmPelsHeight = Conversions.ToInteger(value.Split(new char[1] { 'x' })[1]);
			text = getErrString((int)peremens.ChangeDisplaySettings(ref lpDevMode, 0), value);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Errors.MessangeCritic(text);
			}
		}
	}

	public string DesktopBits
	{
		get
		{
			peremens.DevMode lpDevMode = default(peremens.DevMode);
			peremens.EnumDisplaySettings(null, -1, ref lpDevMode);
			return Conversions.ToString((int)lpDevMode.dmBitsPerPel);
		}
		set
		{
			string text = "";
			peremens.DevMode lpDevMode = default(peremens.DevMode);
			peremens.EnumDisplaySettings(null, -1, ref lpDevMode);
			lpDevMode.dmBitsPerPel = Conversions.ToShort(value);
			text = getErrString((int)peremens.ChangeDisplaySettings(ref lpDevMode, 0), value);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Errors.MessangeCritic(text);
			}
		}
	}

	public string DesktopFrequency
	{
		get
		{
			peremens.DevMode lpDevMode = default(peremens.DevMode);
			peremens.EnumDisplaySettings(null, -1, ref lpDevMode);
			return Conversions.ToString(lpDevMode.dmDisplayFrequency);
		}
		set
		{
			string text = "";
			peremens.DevMode lpDevMode = default(peremens.DevMode);
			peremens.EnumDisplaySettings(null, -1, ref lpDevMode);
			lpDevMode.dmDisplayFrequency = Conversions.ToInteger(value);
			text = getErrString((int)peremens.ChangeDisplaySettings(ref lpDevMode, 0), value);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Errors.MessangeCritic(text);
			}
		}
	}

	public string ScreenSaver
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\\\Desktop", writable: true);
			if (peremens.isDevelop & !peremens.isRUN())
			{
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\"", registryKey.GetValue("SCRNSAVE.EXE")), (object)"\""));
			}
			return Conversions.ToString(registryKey.GetValue("SCRNSAVE.EXE"));
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\\\Desktop", writable: true);
			registryKey.SetValue("SCRNSAVE.EXE", value);
		}
	}

	public string Screenshot
	{
		get
		{
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			Application.DoEvents();
			if (Operators.CompareString(peremens.NetTakNet(args[0]), peremens.trans("Нет"), false) == 0)
			{
				peremens.DoKeyBoard(0, (Keys)44);
				peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)44);
			}
			else
			{
				peremens.DoKeyBoard(0, (Keys)18);
				peremens.DoKeyBoard(0, (Keys)44);
				peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)44);
				peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)18);
			}
			int num;
			do
			{
				num = 11;
				args[0] = Path.GetTempFileName().Replace(".tmp", ".jpg");
				Application.DoEvents();
			}
			while (Clipboard.GetDataObject().GetData(DataFormats.Bitmap) == null);
			try
			{
				((Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap)).Save(args[0]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(ex2.Message);
				}
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
			return args[0];
		}
		set
		{
		}
	}

	public string ScreenshotOfObject
	{
		get
		{
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected O, but got Unknown
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			object myObjFromUniqName = peremens.RunProj.GetMyObjFromUniqName(args[0]);
			if (myObjFromUniqName == null)
			{
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(peremens.trans("Невозможно сфотографировать объект *, так как такого объекта не существует!").Replace("*", args[0]));
				}
				return "";
			}
			int num = Conversions.ToInteger(DesktopResolution.Split(new char[1] { 'x' })[0]);
			int num2 = Conversions.ToInteger(DesktopResolution.Split(new char[1] { 'x' })[1]);
			if (Operators.ConditionalCompareObjectLess((object)num, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			if (Operators.ConditionalCompareObjectLess((object)num2, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				num2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			Bitmap val = new Bitmap(num, num2);
			object obj = NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { val, null };
			Point location = new Point(0, 0);
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null);
			Size size = default(Size);
			Rectangle rectangle = new Rectangle(location, (obj2 != null) ? ((Size)obj2) : size);
			array[1] = rectangle;
			object[] array2 = array;
			object[] array3 = array2;
			bool[] array4 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj, (Type)null, "DrawToBitmap", array3, (string[])null, (Type[])null, array4, true);
			if (array4[0])
			{
				val = (Bitmap)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(Bitmap));
			}
			Point location2 = new Point(0, 0);
			Bitmap obj3 = val;
			object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myObjFromUniqName, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null);
			rectangle = new Rectangle(location2, (obj4 != null) ? ((Size)obj4) : size);
			val = obj3.Clone(rectangle, (PixelFormat)0);
			args[0] = Path.GetTempFileName().Replace(".tmp", ".jpg");
			((Image)val).Save(args[0]);
			return args[0];
		}
		set
		{
		}
	}

	public string MouseX
	{
		get
		{
			return Conversions.ToString(Cursor.get_Position().X);
		}
		set
		{
			Point position = new Point(Conversions.ToInteger(value), Cursor.get_Position().Y);
			Cursor.set_Position(position);
		}
	}

	public string MouseY
	{
		get
		{
			return Conversions.ToString(Cursor.get_Position().Y);
		}
		set
		{
			Point position = new Point(Cursor.get_Position().X, Conversions.ToInteger(value));
			Cursor.set_Position(position);
		}
	}

	public string MouseLeft
	{
		get
		{
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.mouseHook));
			return peremens.DaOrNet(peremens.mleft);
		}
		set
		{
			if (Operators.CompareString(value, peremens.trans("Да"), false) == 0)
			{
				peremens.DoMouse(peremens.NativeMethods.MOUSEEVENTF.LEFTDOWN, Cursor.get_Position());
			}
			else
			{
				peremens.DoMouse(peremens.NativeMethods.MOUSEEVENTF.LEFTUP, Cursor.get_Position());
			}
		}
	}

	public string MouseRight
	{
		get
		{
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.mouseHook));
			return peremens.DaOrNet(peremens.mright);
		}
		set
		{
			if (Operators.CompareString(value, peremens.trans("Да"), false) == 0)
			{
				peremens.DoMouse(peremens.NativeMethods.MOUSEEVENTF.RIGHTDOWN, Cursor.get_Position());
			}
			else
			{
				peremens.DoMouse(peremens.NativeMethods.MOUSEEVENTF.RIGHTUP, Cursor.get_Position());
			}
		}
	}

	public string MouseWheel
	{
		get
		{
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.mouseHook));
			return peremens.DaOrNet(peremens.mwheel);
		}
	}

	public string KeyboardKey
	{
		get
		{
			if (peremens.RunProj == null)
			{
				return "\"Menu; Tab;\"";
			}
			if (!peremens.RunProj.isRUN)
			{
				return "\"Menu; Tab;\"";
			}
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.keyboardHook));
			string text = "";
			checked
			{
				int num = peremens.ks.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, peremens.ks[i]));
					if (peremens.ks.Count > 1)
					{
						text += "; ";
					}
				}
				return text;
			}
		}
		set
		{
			string[] array = value.Split(new char[1] { ';' });
			Application.DoEvents();
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(Strings.Trim(array[i]), "", false) != 0)
					{
						peremens.DoKeyBoard(0, (Keys)Conversions.ToInteger(peremens.Keyz[Strings.Trim(Strings.LCase(array[i]))]));
					}
				}
				Application.DoEvents();
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Operators.CompareString(Strings.Trim(array[i]), "", false) != 0)
					{
						peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)Conversions.ToInteger(peremens.Keyz[Strings.Trim(Strings.LCase(array[i]))]));
					}
				}
			}
		}
	}

	public string KeyboardShift
	{
		get
		{
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.keyboardHook));
			return peremens.DaOrNet(peremens.shft);
		}
		set
		{
			if (Operators.CompareString(value, peremens.trans("Да"), false) == 0)
			{
				peremens.DoKeyBoard(0, (Keys)16);
			}
			else
			{
				peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)16);
			}
		}
	}

	public string KeyboardAlt
	{
		get
		{
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.keyboardHook));
			return peremens.DaOrNet(peremens.alt);
		}
		set
		{
			if (Operators.CompareString(value, peremens.trans("Да"), false) == 0)
			{
				peremens.DoKeyBoard(0, (Keys)18);
			}
			else
			{
				peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)18);
			}
		}
	}

	public string KeyboardControl
	{
		get
		{
			peremens.HookRun(RuntimeHelpers.GetObjectValue(peremens.keyboardHook));
			return peremens.DaOrNet(peremens.ctrl);
		}
		set
		{
			if (Operators.CompareString(value, peremens.trans("Да"), false) == 0)
			{
				peremens.DoKeyBoard(0, (Keys)17);
			}
			else
			{
				peremens.DoKeyBoard(peremens.NativeMethods.KEYEVENTF.KEYUP, (Keys)17);
			}
		}
	}

	public string ClipboardPicture
	{
		get
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			if (!Clipboard.ContainsImage())
			{
				return "";
			}
			string text;
			try
			{
				text = Path.GetTempFileName().Replace(".tmp", ".jpg");
				((Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap)).Save(text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(ex2.Message);
				}
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
			return text;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					Clipboard.SetImage(Image.FromFile(peremens.GetMaxPath(value)));
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			Clipboard.Clear();
		}
	}

	public string ClipboardText
	{
		get
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				string result = default(string);
				try
				{
					if (Clipboard.ContainsFileDropList())
					{
						string text = "";
						int num = Clipboard.GetFileDropList().Count - 1;
						for (int i = 0; i <= num; i++)
						{
							text += Clipboard.GetFileDropList()[i];
							if (Clipboard.GetFileDropList().Count > 1)
							{
								text += "; ";
							}
						}
						result = text;
						return result;
					}
					if (Clipboard.ContainsText())
					{
						result = Clipboard.GetText((TextDataFormat)1);
						return result;
					}
					result = "";
					return result;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
					}
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}
		set
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Clipboard.SetText(value, (TextDataFormat)1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string WindowInFocus
	{
		get
		{
			IntPtr foregroundWindow = peremens.GetForegroundWindow();
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					if (num2 <= num)
					{
						if (processes[num2].MainWindowHandle == foregroundWindow)
						{
							break;
						}
						num2++;
						continue;
					}
					return "";
				}
				if (Operators.CompareString(processes[num2].MainWindowTitle, "", false) != 0)
				{
					return processes[num2].MainWindowTitle;
				}
				return Conversions.ToString((int)processes[num2].MainWindowHandle);
			}
		}
		set
		{
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (processes[i].MainWindowHandle != (IntPtr)0 && ((Operators.CompareString(processes[i].MainWindowTitle.ToUpper(), value.ToUpper(), false) == 0) | (Operators.CompareString(processes[i].MainWindowHandle.ToString(), value, false) == 0)))
					{
						peremens.SetForegroundWindow(processes[i].MainWindowHandle);
					}
				}
			}
		}
	}

	public string Key
	{
		get
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			string name = "";
			RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
			if ((Operators.CompareString(this.get_ExistKey(args), peremens.trans("Нет"), false) == 0) & (Operators.CompareString(name, "", false) != 0))
			{
				Interaction.MsgBox((object)Errors.notRegistry(args[0]), (MsgBoxStyle)0, (object)null);
				return peremens.trans("");
			}
			checked
			{
				if (registryKey.GetValueKind(name) == RegistryValueKind.Binary)
				{
					byte[] array = (byte[])registryKey.GetValue(name);
					if (array.Length == 0)
					{
						return peremens.trans("Никакой");
					}
					string text = "";
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						text = text + Conversions.ToString(array[i]) + " ";
					}
					return Strings.Trim(text);
				}
				return Conversions.ToString(registryKey.GetValue(name, ""));
			}
		}
		set
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			string name = "";
			RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
			RegistryValueKind type = RegistryValueKind.String;
			if (Operators.CompareString(this.get_ExistKey(args), peremens.trans("Нет"), false) == 0)
			{
				if (Operators.CompareString(name, "", false) != 0)
				{
					Interaction.MsgBox((object)Errors.notRegistry(args[0]), (MsgBoxStyle)0, (object)null);
					return;
				}
			}
			else
			{
				type = registryKey.GetValueKind(name);
			}
			peremens.CreateRegistryKey(registryKey, name, value, type);
		}
	}

	public string TypeKey
	{
		get
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			string name = "";
			RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
			if ((Operators.CompareString(this.get_ExistKey(args), peremens.trans("Нет"), false) == 0) & (Operators.CompareString(name, "", false) != 0))
			{
				Interaction.MsgBox((object)Errors.notRegistry(args[0]), (MsgBoxStyle)0, (object)null);
				return peremens.trans("никакой");
			}
			return Conversions.ToString(peremens.TypeRegistry.GetKey(peremens.TypeRegistry.IndexOfValue(registryKey.GetValueKind(name))));
		}
		set
		{
		}
	}

	public string ExistKey
	{
		get
		{
			string name = "";
			RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
			if (Operators.CompareString(name, "", false) == 0)
			{
				return peremens.trans("Нет");
			}
			try
			{
				registryKey.GetValueKind(name);
				return peremens.trans("Да");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = peremens.trans("Нет");
				ProjectData.ClearProjectError();
				return result;
			}
		}
		set
		{
		}
	}

	public string ExistSubKey
	{
		get
		{
			string name = "";
			RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
			if (registryKey == null)
			{
				return peremens.trans("Нет");
			}
			if (Operators.CompareString(name, "", false) == 0)
			{
				return peremens.trans("Да");
			}
			return peremens.trans("Нет");
		}
		set
		{
		}
	}

	public string Chars
	{
		get
		{
			if ((double)args[0].Length <= Conversions.ToDouble(args[1]) - 1.0)
			{
				return "";
			}
			return Conversions.ToString(args[0][checked((int)Math.Round(Conversions.ToDouble(args[1]) - 1.0))]);
		}
	}

	public string Compare => Conversions.ToString(string.Compare(args[0], args[1]));

	public string IndexOfLine
	{
		get
		{
			int num = 0;
			string str = "\r\n";
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			checked
			{
				int num2 = args[0].IndexOf(args[1], peremens.Int(args[2]) - 1, StringComparison.CurrentCultureIgnoreCase);
				UladitVbCrlf(ref args[0], ref str);
				while (num2 != -1)
				{
					if (num2 > 0)
					{
						num2--;
					}
					num2 = args[0].LastIndexOf(str, num2, StringComparison.CurrentCultureIgnoreCase);
					num++;
				}
				return Conversions.ToString(num);
			}
		}
	}

	public string IndexOfIgnoreCase
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			return Conversions.ToString(checked(args[0].IndexOf(args[1], peremens.Int(args[2]) - 1, StringComparison.CurrentCultureIgnoreCase) + 1));
		}
	}

	public string IndexOf
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			return Conversions.ToString(checked(args[0].IndexOf(args[1], peremens.Int(args[2]) - 1) + 1));
		}
	}

	public string LastIndexOfIgnoreCase
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			checked
			{
				if (Conversions.ToDouble(args[2]) > (double)(args[0].Length + 1))
				{
					args[2] = Conversions.ToString(args[0].Length);
				}
				return Conversions.ToString(args[0].LastIndexOf(args[1], peremens.Int(args[2]) - 1, StringComparison.CurrentCultureIgnoreCase) + 1);
			}
		}
	}

	public string IndexOfRegular
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			Match match = Regex.Match(args[0], args[1]);
			if (match.Success)
			{
				return Conversions.ToString(checked(match.Index + 1));
			}
			return Conversions.ToString(0);
		}
	}

	public string CharsLength => Conversions.ToString(args[0].Length);

	public string Split
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			string[] separator = new string[1] { args[1] };
			string[] array = args[0].Split(separator, StringSplitOptions.None);
			if (Conversions.ToDouble(args[2]) - 1.0 >= (double)array.Length)
			{
				return "";
			}
			return array[checked((int)Math.Round(Conversions.ToDouble(args[2]) - 1.0))];
		}
	}

	public string Substring
	{
		get
		{
			args[1] = Conversions.ToString(Conversions.ToDouble(args[1]) - 1.0);
			if ((double)peremens.Int(args[2]) + Conversions.ToDouble(args[1]) > (double)args[0].Length)
			{
				args[2] = Conversions.ToString((double)args[0].Length - Conversions.ToDouble(args[1]));
			}
			if (Conversions.ToDouble(args[2]) > -1.0)
			{
				return args[0].Substring(Conversions.ToInteger(args[1]), Conversions.ToInteger(args[2]));
			}
			return args[0].Substring(Conversions.ToInteger(args[1]));
		}
	}

	public string SplitCount
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			return Conversions.ToString(args[0].Split(new char[1] { Conversions.ToChar(args[1]) }).Length);
		}
	}

	public string DeleteQuotes
	{
		get
		{
			string text = peremens.UbratKovich(args[0]).str;
			checked
			{
				if (((Operators.CompareString(text, args[0], false) == 0) & (text.Length > 1)) && ((Operators.CompareString(Conversions.ToString(text[0]), "\"", false) == 0) & (Operators.CompareString(Conversions.ToString(text[text.Length - 1]), "\"", false) == 0)))
				{
					text = text.Substring(1, text.Length - 2);
				}
				return text;
			}
		}
	}

	public string PutInQuotes => "\"" + peremens.CreateKovich(peremens.CreateKovich(args[0])) + "\"";

	public string IndexOfWithoutQuotes
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			CodeString codeString = new CodeString(args[0], "None", withFormating: false);
			return Conversions.ToString(checked(codeString.IndexOf(args[1], (int)Math.Round(Conversions.ToDouble(args[2]) - 1.0)) + 1));
		}
	}

	public string SplitWithoutQuotes
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			CodeString codeString = new CodeString(args[0], "None", withFormating: false);
			string[] texty = codeString.Split("", args[1]).texty;
			if (Conversions.ToDouble(args[2]) - 1.0 >= (double)texty.Length)
			{
				return "";
			}
			return texty[checked((int)Math.Round(Conversions.ToDouble(args[2]) - 1.0))];
		}
	}

	public string SplitWithoutQuotesCount
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			CodeString codeString = new CodeString(args[0], "None", withFormating: false);
			string[] texty = codeString.Split("", args[1]).texty;
			return Conversions.ToString(texty.Length);
		}
	}

	public string Consist
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			return Conversions.ToString(checked(args[0].IndexOfAny(args[1].ToCharArray()) + 1));
		}
	}

	public string ConsistNo
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			return peremens.DaOrNet(args[0].IndexOfAny(args[1].ToCharArray()) == -1);
		}
	}

	public string IsNumericText => this.get_ConsistAll(new string[2]
	{
		args[0],
		"1234567890"
	});

	public string isNumberText => peremens.DaOrNet(Iz.isDouble(ref args[0]));

	public string ConsistAll
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			args[1] = args[1].Replace("^", "\\^").Replace("[", "\\[").Replace("]", "\\]");
			return peremens.DaOrNet(Operators.CompareString(Regex.Match(args[0], "[" + args[1] + "]*").Value, args[0], false) == 0);
		}
	}

	public string Line
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			TextBox val = new TextBox();
			val.set_Text(args[0]);
			if ((double)((TextBoxBase)val).get_Lines().Length <= Conversions.ToDouble(args[1]) - 1.0)
			{
				return "";
			}
			return ((TextBoxBase)val).get_Lines()[checked((int)Math.Round(Conversions.ToDouble(args[1]) - 1.0))];
		}
	}

	public string LinesCount
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			TextBox val = new TextBox();
			val.set_Text(args[0]);
			return Conversions.ToString(((TextBoxBase)val).get_Lines().Length);
		}
	}

	public string Insert => args[0].Insert(checked((int)Math.Round(Conversions.ToDouble(args[1]) - 1.0)), args[2]);

	public string Remove
	{
		get
		{
			args[1] = Conversions.ToString(Conversions.ToDouble(args[1]) - 1.0);
			if ((double)peremens.Int(args[2]) + Conversions.ToDouble(args[1]) > (double)args[0].Length)
			{
				args[2] = Conversions.ToString((double)args[0].Length - Conversions.ToDouble(args[1]));
			}
			if (Conversions.ToDouble(args[2]) != -1.0)
			{
				return args[0].Remove(Conversions.ToInteger(args[1]), Conversions.ToInteger(args[2]));
			}
			return args[0].Remove(Conversions.ToInteger(args[1]));
		}
	}

	public string ReplaceOne
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			int num = args[0].IndexOf(args[1], StringComparison.CurrentCultureIgnoreCase);
			if (num == -1)
			{
				return args[0];
			}
			args[0] = args[0].Remove(num, args[1].Length);
			return args[0].Insert(num, args[2]);
		}
	}

	public string ReplaceAll
	{
		get
		{
			if (args[0] == null)
			{
				return Conversions.ToString(0);
			}
			UladitVbCrlf(ref args[0], ref args[1]);
			return args[0].Replace(args[1], args[2]);
		}
	}

	public string toUpper => Strings.UCase(args[0]);

	public string toLower => Strings.LCase(args[0]);

	public string TrimAll => args[0].Trim();

	public string TrimStart => args[0].TrimStart(new char[0]);

	public string TrimEnd => args[0].TrimEnd(new char[0]);

	public object EncryptText
	{
		get
		{
			byte[] keySimmetric = getKeySimmetric(args[1]);
			MemoryStream memoryStream = new MemoryStream();
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(keySimmetric, IV), CryptoStreamMode.Write);
			StreamWriter streamWriter = new StreamWriter(cryptoStream);
			streamWriter.Write(args[0]);
			streamWriter.Close();
			string result = Convert.ToBase64String(memoryStream.ToArray());
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
	}

	public object DecryptText
	{
		get
		{
			try
			{
				byte[] keySimmetric = getKeySimmetric(args[1]);
				byte[] buffer = Convert.FromBase64String(args[0]);
				MemoryStream memoryStream = new MemoryStream(buffer);
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(keySimmetric, IV), CryptoStreamMode.Read);
				StreamReader streamReader = new StreamReader(cryptoStream);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				memoryStream.Close();
				cryptoStream.Close();
				return text.Replace("\r\n".Substring(1), "\r\n");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				object result = peremens.trans("Ошибка при дешифрации. Либо неверный ключ шифрования, либо данные для дешифрации некорректны.");
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public string WasCancel
	{
		get
		{
			return WCCan;
		}
		set
		{
			WCCan = value;
		}
	}

	public string WasOk
	{
		get
		{
			return WCOk;
		}
		set
		{
			WCOk = value;
		}
	}

	public string WasRetry
	{
		get
		{
			return WCRet;
		}
		set
		{
			WCRet = value;
		}
	}

	public string WasYes
	{
		get
		{
			return WCYes;
		}
		set
		{
			WCYes = value;
		}
	}

	public string WasNo
	{
		get
		{
			return WCNo;
		}
		set
		{
			WCNo = value;
		}
	}

	public string WasAbort
	{
		get
		{
			return WCAb;
		}
		set
		{
			WCAb = value;
		}
	}

	public string WasIgnore
	{
		get
		{
			return WCIgn;
		}
		set
		{
			WCIgn = value;
		}
	}

	public string WasHelp
	{
		get
		{
			return WCHelp;
		}
		set
		{
			WCHelp = value;
		}
	}

	public PropertysOther(object ob)
	{
		IV = new byte[16]
		{
			16, 2, 3, 41, 5, 6, 7, 81, 9, 10,
			11, 12, 13, 14, 15, 16
		};
		WCCan = peremens.trans("Нет");
		WCOk = peremens.trans("Нет");
		WCRet = peremens.trans("Нет");
		WCYes = peremens.trans("Нет");
		WCNo = peremens.trans("Нет");
		WCAb = peremens.trans("Нет");
		WCIgn = peremens.trans("Нет");
		WCHelp = peremens.trans("Нет");
		obj = RuntimeHelpers.GetObjectValue(ob);
	}

	public string GetAttribs(string[] args, string attr)
	{
		string str = peremens.UbratKovich(peremens.GetMaxPath(args[0])).str;
		FileAttributes attributes = File.GetAttributes(str);
		int num = Enum.Format(attributes.GetType(), attributes, "g").IndexOf(attr);
		if (num != -1)
		{
			return peremens.trans("Да");
		}
		return peremens.trans("Нет");
	}

	public void SetAttribs(string[] args, string value, string attr)
	{
		string maxPath = peremens.GetMaxPath(args[0]);
		FileAttributes attributes = File.GetAttributes(maxPath);
		int num = Enum.Format(attributes.GetType(), attributes, "g").IndexOf(attr);
		checked
		{
			if ((num == -1) & (Operators.CompareString(value, peremens.trans("Да"), false) == 0))
			{
				attributes += 2;
				File.SetAttributes(maxPath, attributes);
			}
			else if ((num != -1) & (Operators.CompareString(value, peremens.trans("Нет"), false) == 0))
			{
				attributes -= 2;
				File.SetAttributes(maxPath, attributes);
			}
		}
	}

	public void SaveInFile(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			File.WriteAllText(args[0], args[1], GetEncodText(args[2]));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public string OpenFile(params string[] args)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return "";
				}
				args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
				int count = 500000;
				BinaryReader binaryReader = new BinaryReader(new StreamReader(args[0]).BaseStream, GetEncodText(args[1]));
				List<byte> list = new List<byte>();
				while (true)
				{
					Application.DoEvents();
					byte[] array = binaryReader.ReadBytes(count);
					if (array.Length == 0)
					{
						break;
					}
					list.AddRange(array);
				}
				binaryReader.Close();
				byte[] array2 = list.ToArray();
				int num = array2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (array2[i] == 0)
					{
						array2[i] = 48;
					}
				}
				return GetEncodText(args[1]).GetString(array2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
				}
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public void AppendText(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			File.AppendAllText(peremens.UbratKovich(args[0]).str, args[1], GetEncodText(args[2]));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void SavePicture(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			args[1] = peremens.GetMaxPath(peremens.UbratKovich(args[1]).str);
			File.Copy(args[1], args[0], overwrite: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void Copy(params string[] args)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			args[1] = peremens.GetMaxPath(peremens.UbratKovich(args[1]).str);
			if (File.Exists(args[0]))
			{
				object[] array = new object[3];
				object[] array2 = array;
				int num = 0;
				array2[0] = args[0];
				object[] array3 = array;
				int num2 = 1;
				array3[1] = args[1];
				array[2] = true;
				object[] array4 = array;
				object[] array5 = array4;
				bool[] array6 = new bool[3] { true, true, false };
				NewLateBinding.LateCall(objectValue, (Type)null, "copyfile", array5, (string[])null, (Type[])null, array6, true);
				if (array6[0])
				{
					args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
				}
				if (array6[1])
				{
					args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(string));
				}
			}
			else
			{
				object[] array4 = new object[3]
				{
					peremens.GetPathBezSlash(args[0]),
					null,
					null
				};
				object[] array7 = array4;
				int num2 = 1;
				array7[1] = args[1];
				array4[2] = true;
				object[] array = array4;
				object[] array8 = array;
				bool[] array6 = new bool[3] { false, true, false };
				NewLateBinding.LateCall(objectValue, (Type)null, "copyfolder", array8, (string[])null, (Type[])null, array6, true);
				if (array6[1])
				{
					args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void Rename(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			string directoryName = Path.GetDirectoryName(args[0]);
			FileSystem.Rename(args[0], directoryName + "\\" + args[1]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void Move(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			args[1] = peremens.GetMaxPath(peremens.UbratKovich(args[1]).str);
			if (File.Exists(args[0]))
			{
				if (File.Exists(args[1]))
				{
					File.Delete(args[1]);
				}
				File.Move(args[0], args[1]);
			}
			else
			{
				Directory.Move(args[0], args[1]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message) + " " + peremens.trans("Советуем воспользоваться более надежным методом, таким как \"_Копировать\""));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void OpenDirectory(params string[] args)
	{
		Run("explorer.exe", Path.GetDirectoryName(args[0]) + "," + Path.GetFileName(args[0]));
	}

	public void Encrypt(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			File.Encrypt(args[0]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void Decrypt(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			File.Decrypt(args[0]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void Delete(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
			if (File.Exists(args[0]))
			{
				object[] array = new object[1];
				object[] array2 = array;
				int num = 0;
				array2[0] = args[0];
				object[] array3 = array;
				object[] array4 = array3;
				bool[] array5 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue, (Type)null, "deletefile", array4, (string[])null, (Type[])null, array5, true);
				if (array5[0])
				{
					args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
				}
			}
			else
			{
				object[] array3 = new object[1];
				object[] array6 = array3;
				int num = 0;
				array6[0] = args[0];
				object[] array = array3;
				object[] array7 = array;
				bool[] array5 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue, (Type)null, "deletefolder", array7, (string[])null, (Type[])null, array5, true);
				if (array5[0])
				{
					args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void CreateDirectory(params string[] args)
	{
		try
		{
			Directory.CreateDirectory(peremens.GetMaxPath(peremens.UbratKovich(args[0]).str));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public string FindFile(params string[] args)
	{
		checked
		{
			string result = default(string);
			try
			{
				args[0] = peremens.GetMaxPath(peremens.UbratKovich(args[0]).str);
				DirectoryInfo directoryInfo = new DirectoryInfo(args[0]);
				FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos(args[1]);
				DirectoryInfo[] directories = directoryInfo.GetDirectories(args[1]);
				DirectoryInfo[] directories2 = directoryInfo.GetDirectories();
				if (Operators.CompareString(top, "", false) == 0)
				{
					top = args[0];
				}
				string text = "";
				int num = fileSystemInfos.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text = text + fileSystemInfos[i].FullName + "; ";
				}
				int num2 = directories.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					text = text + directories[i].FullName + "; ";
				}
				int num3 = directories2.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					Application.DoEvents();
					text += FindFile(directories2[i].FullName, args[1]);
				}
				if (Operators.CompareString(top, args[0], false) == 0)
				{
					string text2 = errFind;
					top = "";
					errFind = "";
					if (Operators.CompareString(text2, "", false) != 0)
					{
						Errors.MessangeCritic(Errors.FileNotCreate(text2));
					}
				}
				result = text;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					errFind = errFind + ex2.Message + "\r\n";
				}
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(top, args[0], false) == 0)
			{
				string text3 = errFind;
				top = "";
				errFind = "";
				if (Operators.CompareString(text3, "", false) != 0)
				{
					Errors.MessangeCritic(Errors.FileNotCreate(text3));
				}
			}
			return result;
		}
	}

	public string getErrString(int iRet, string val)
	{
		string result = "";
		switch (iRet)
		{
		default:
			result = "Unknown return value from ChangeDisplaySettings API";
			break;
		case -6:
			result = "The settings change was unsuccessful because system is DualView capable.";
			break;
		case -5:
			result = "An invalid parameter was passed in. This can include an invalid flag or combination of flags.";
			break;
		case -4:
			result = "An invalid set of flags was passed in.";
			break;
		case -3:
			result = "Unable to write settings to the registry.";
			break;
		case -2:
			result = "Invalid value the display setting. Value \"" + val + "\" is not admissible.";
			break;
		case -1:
			result = "ChangeDisplaySettigns API failed";
			break;
		case 1:
			result = "Please restart your system";
			break;
		case 0:
			break;
		}
		return result;
	}

	public void ScreenshotToClipboard(params string[] args)
	{
		if (Operators.CompareString(peremens.NetTakNet(args[0]), peremens.trans("Нет"), false) == 0)
		{
			SendKeys.SendWait("+{PRTSC}");
			return;
		}
		SendKeys.SendWait("%{PRTSC 2}");
		SendKeys.SendWait("%{PRTSC 2}");
		SendKeys.SendWait("%{PRTSC 2}");
		SendKeys.SendWait("%{PRTSC 5}");
	}

	public peremens.ErrString BreakApplication()
	{
		return new peremens.ErrString("", "BreakApplication");
	}

	public peremens.ErrString BreakEvent()
	{
		return new peremens.ErrString("", "BreakEvent");
	}

	public peremens.ErrString BreakLoop()
	{
		return new peremens.ErrString("", "BreakLoop");
	}

	public peremens.ErrString IgnoreErrors()
	{
		peremens.IgnorEr = true;
		return new peremens.ErrString("", "IgnoreErrors");
	}

	public void Run(params string[] args)
	{
		try
		{
			Process.Start(args[0], args[1]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeExclamen(ex2.Message + ". " + peremens.trans("Выполнялось") + ": \"" + args[0] + "\" \"" + args[1] + "\"");
			}
			ProjectData.ClearProjectError();
		}
	}

	public object RunWithResult(params string[] args)
	{
		checked
		{
			object result = default(object);
			try
			{
				string text = "";
				string[] array = args[0].Split(new string[1] { "\r\n" }, StringSplitOptions.None);
				Process process = new Process();
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.FileName = array[0];
				process.StartInfo.Arguments = args[1];
				process.Start();
				StreamWriter streamWriter = new StreamWriter(process.StandardInput.BaseStream, GetEncodText(args[2]));
				int num = array.Length - 1;
				for (int i = 1; i <= num; i++)
				{
					streamWriter.WriteLine(array[i]);
				}
				streamWriter.Close();
				process.WaitForExit(100);
				StreamReader streamReader = new StreamReader(process.StandardOutput.BaseStream, GetEncodText(args[2]));
				text += streamReader.ReadToEnd();
				streamReader.Close();
				StreamReader streamReader2 = new StreamReader(process.StandardError.BaseStream, GetEncodText(args[2]));
				text += streamReader2.ReadToEnd();
				streamReader2.Close();
				process.Close();
				result = text;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeExclamen(ex2.Message + ". " + peremens.trans("Выполнялось") + ": \"" + args[0] + "\" \"" + args[1] + "\"");
				}
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public Encoding GetEncodText(string enc)
	{
		object obj = peremens.FileEncodings.IndexOfKey(Strings.LCase(enc));
		if (Operators.ConditionalCompareObjectEqual(obj, (object)(-1), false))
		{
			try
			{
				if (Versioned.IsNumeric((object)enc))
				{
					return Encoding.GetEncoding(peremens.Int(enc));
				}
				return Encoding.GetEncoding(enc);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				throw new Exception(peremens.trans("Кодировка * не поддерживается").Replace("*", enc));
			}
		}
		return (Encoding)peremens.FileEncodings.GetByIndex(Conversions.ToInteger(obj));
	}

	public void ClipboardClear()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void WheelRun(params string[] args)
	{
		peremens.DoMouse(peremens.NativeMethods.MOUSEEVENTF.WHEEL, Cursor.get_Position(), Conversions.ToInteger(args[0]));
	}

	public void ShutDown()
	{
		try
		{
			Process.Start("shutdown", "-s -t 00 -f");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(ex2.Message);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void Restart()
	{
		try
		{
			Process.Start("shutdown", "-r -t 00 -f");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(ex2.Message);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void TypeText(params string[] args)
	{
		SendKeys.SendWait(args[0]);
	}

	public string ProcessesList()
	{
		string text = "";
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += processes[i].ProcessName;
				if (i < processes.Length - 1)
				{
					text += ",";
				}
			}
			return text;
		}
	}

	public void KillProcess(params string[] args)
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(processes[i].ProcessName.ToUpper(), args[0].ToUpper(), false) == 0)
				{
					processes[i].Kill();
				}
				else if (Operators.CompareString(processes[i].MainWindowTitle, args[0], false) == 0)
				{
					processes[i].Kill();
				}
				else if (Operators.CompareString(processes[i].MainWindowHandle.ToString(), args[0], false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public string WindowsList()
	{
		string text = "";
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (processes[i].MainWindowHandle != (IntPtr)0)
				{
					text = ((Operators.CompareString(processes[i].MainWindowTitle, "", false) == 0) ? (text + processes[i].MainWindowHandle) : (text + processes[i].MainWindowTitle));
					if (i < processes.Length - 1)
					{
						text += ",";
					}
				}
			}
			if ((text.LastIndexOf(",") == text.Length - 1) & (text.Length > 0))
			{
				text = text.Substring(0, text.Length - 1);
			}
			return text;
		}
	}

	public void DeleteKey(params string[] args)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		string name = "";
		RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
		if (Operators.CompareString(this.get_ExistKey(args), peremens.trans("Нет"), false) == 0)
		{
			Interaction.MsgBox((object)Errors.notRegistry(args[0]), (MsgBoxStyle)0, (object)null);
		}
		else
		{
			registryKey.DeleteValue(name);
		}
	}

	public void DeleteSubKey(params string[] args)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		string name = "";
		RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
		if (registryKey != null)
		{
			if (Operators.CompareString(this.get_ExistSubKey(args), peremens.trans("Нет"), false) == 0)
			{
				Interaction.MsgBox((object)Errors.notRegistry(args[0]), (MsgBoxStyle)0, (object)null);
			}
			else
			{
				registryKey.DeleteSubKeyTree(name);
			}
		}
	}

	public void CreateKey(params string[] args)
	{
		string name = "";
		RegistryKey registryKey = peremens.GetRegistryKey(args[0], ref name);
		if (Versioned.IsNumeric((object)args[2]))
		{
			peremens.CreateRegistryKey(registryKey, name, args[1], (RegistryValueKind)Conversions.ToInteger(args[2]));
		}
		else
		{
			peremens.CreateRegistryKey(registryKey, name, args[1], (RegistryValueKind)Conversions.ToInteger(peremens.TypeRegistry.GetByIndex(peremens.TypeRegistry.IndexOfKey(Strings.LCase(args[2])))));
		}
	}

	public void CreateSubKey(params string[] args)
	{
		string name = "";
		peremens.GetRegistryKey(args[0], ref name)?.CreateSubKey(name);
	}

	public void UladitVbCrlf(ref string txt, ref string str)
	{
		if (txt != null && txt.IndexOf("\r\n") == -1 && txt.IndexOf("\r\n".Substring(1)) != -1)
		{
			str = str.Replace("\r\n", "\r\n".Substring(1));
		}
	}

	public byte[] getKeySimmetric(string k)
	{
		if (Operators.CompareString(k, "", false) == 0)
		{
			throw new Exception(peremens.trans("Ключ шифрования должен обязательно присутствовать!"));
		}
		byte[] bytes = Encoding.UTF8.GetBytes(k);
		int num = bytes.Length;
		num = ((num > 16) ? 32 : 16);
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i < bytes.Length)
				{
					array[i] = bytes[i];
				}
				else
				{
					array[i] = 1;
				}
			}
			return array;
		}
	}

	public void ShowMessage(params string[] args)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		int num = Conversions.ToInteger(peremens.MsgStyleButtons.GetByIndex(peremens.MsgStyleButtons.IndexOfKey(Strings.LCase(args[1]))));
		int num2 = Conversions.ToInteger(peremens.MsgStyleTypes.GetByIndex(peremens.MsgStyleTypes.IndexOfKey(Strings.LCase(args[2]))));
		MsgBoxResult val = Interaction.MsgBox((object)args[0], (MsgBoxStyle)checked(num + num2), (object)args[3]);
		if ((int)val == 3)
		{
			WasAbort = peremens.trans("Да");
		}
		else
		{
			WasAbort = peremens.trans("Нет");
		}
		if ((int)val == 2)
		{
			WasCancel = peremens.trans("Да");
		}
		else
		{
			WasCancel = peremens.trans("Нет");
		}
		if ((int)val == 5)
		{
			WasIgnore = peremens.trans("Да");
		}
		else
		{
			WasIgnore = peremens.trans("Нет");
		}
		if ((int)val == 7)
		{
			WasNo = peremens.trans("Да");
		}
		else
		{
			WasNo = peremens.trans("Нет");
		}
		if ((int)val == 1)
		{
			WasOk = peremens.trans("Да");
		}
		else
		{
			WasOk = peremens.trans("Нет");
		}
		if ((int)val == 4)
		{
			WasRetry = peremens.trans("Да");
		}
		else
		{
			WasRetry = peremens.trans("Нет");
		}
		if ((int)val == 6)
		{
			WasYes = peremens.trans("Да");
		}
		else
		{
			WasYes = peremens.trans("Нет");
		}
	}

	public string DayOfMonth(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.Day);
	}

	public string DayOfYear(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.DayOfYear);
	}

	public string DayOfWeek(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString((int)t.DayOfWeek);
	}

	public string Hour(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.Hour);
	}

	public string Minute(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.Minute);
	}

	public string Second(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.Second);
	}

	public string Quarter(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(DateAndTime.DatePart((DateInterval)1, dateTime, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
	}

	public string WeekOfYear(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(DateAndTime.DatePart((DateInterval)5, dateTime, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
	}

	public string Year(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.Year);
	}

	public string Month(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.Month);
	}

	public string Ticks(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return Conversions.ToString(t.ToBinary());
	}

	public string Time(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return t.GetDateTimeFormats()[45];
	}

	public string DaysInMonth(params string[] args)
	{
		return Conversions.ToString(DateTime.DaysInMonth(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1])));
	}

	public string Now()
	{
		return peremens.ToMyDate(DateTime.Now);
	}

	public string Today()
	{
		return peremens.ToMyDate(DateTime.Today).Split(new char[1] { ' ' })[0];
	}

	public string DateAddDay(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)4, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddHour(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)7, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddMinute(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)8, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddSecond(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)9, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddQuarter(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)1, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddWeek(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)5, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddYear(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)0, Conversion.Val(args[1]), dateTime));
	}

	public string DateAddMonth(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
		{
			return "";
		}
		return peremens.ToMyDate(DateAndTime.DateAdd((DateInterval)2, Conversion.Val(args[1]), dateTime));
	}

	public string DateDiffDay(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)4, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffHour(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)7, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffMinute(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)8, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffSecond(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)9, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffQuarter(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)1, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffWeek(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)5, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffYear(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)0, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string DateDiffMonth(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		DateTime dateTime2 = peremens.FromMyDate(args[1]);
		if ((DateTime.Compare(dateTime, DateTime.MinValue) != 0) & (DateTime.Compare(dateTime2, DateTime.MinValue) != 0))
		{
			return Conversions.ToString(DateAndTime.DateDiff((DateInterval)2, dateTime, dateTime2, (FirstDayOfWeek)0, (FirstWeekOfYear)1));
		}
		return "";
	}

	public string WeekdayName(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) != 0)
		{
			return peremens.trans(DateAndTime.WeekdayName(DateAndTime.Weekday(dateTime, (FirstDayOfWeek)0), false, (FirstDayOfWeek)0), toEng: false, fromEng: true);
		}
		return "";
	}

	public string MonthName(params string[] args)
	{
		DateTime dateTime = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(dateTime, DateTime.MinValue) != 0)
		{
			return peremens.trans(DateAndTime.MonthName(DateAndTime.Month(dateTime), false), toEng: false, fromEng: true);
		}
		return "";
	}

	public string GetDateTimeFormats(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		if (DateTime.Compare(t, DateTime.MinValue) == 0)
		{
			return "";
		}
		return t.GetDateTimeFormats()[checked((int)Math.Round(Conversions.ToDouble(args[1]) - 1.0))];
	}

	public void SetSystemData(params string[] args)
	{
		DateTime t = peremens.FromMyDate(args[0]);
		checked
		{
			if (DateTime.Compare(t, DateTime.MinValue) != 0)
			{
				peremens.SYSTEMTIME lpSystemTime = default(peremens.SYSTEMTIME);
				lpSystemTime.wDay = (short)t.Day;
				lpSystemTime.wDayOfWeek = 0;
				lpSystemTime.wHour = (short)t.Hour;
				lpSystemTime.wMilliseconds = (short)t.Millisecond;
				lpSystemTime.wMinute = (short)t.Minute;
				lpSystemTime.wMonth = (short)t.Month;
				lpSystemTime.wSecond = (short)t.Second;
				lpSystemTime.wYear = (short)t.Year;
				peremens.SetSystemTime(ref lpSystemTime);
			}
		}
	}

	public void RunVBScript(params string[] args)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("MSScriptControl.ScriptControl", ""));
			NewLateBinding.LateSet(objectValue, (Type)null, "Language", new object[1] { "VBScript" }, (string[])null, (Type[])null);
			object[] array = new object[1];
			object[] array2 = array;
			int num = 0;
			array2[0] = args[0];
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[1] { true };
			NewLateBinding.LateCall(objectValue, (Type)null, "AddCode", array4, (string[])null, (Type[])null, array5, true);
			if (array5[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
			}
			NewLateBinding.LateCall(objectValue, (Type)null, "Run", new object[1] { "main" }, (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(ex2.Message);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void RunAlgoritm2(params string[] args)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		bool isCompilBest = peremens.isCompilBest;
		peremens.isCompilBest = false;
		try
		{
			CodeString codeString = new CodeString(args[0], "None", withFormating: false);
			string[] texty = codeString.Split("", Conversions.ToString(Strings.Chr(182)), "\r\n", "\r\n".Substring(1)).texty;
			TreeNode parent = new TreeNode();
			Perevodi.ToTreeFromAlgCode(ref parent, texty, 0);
			peremens.isRunAlg2Code = true;
			PropertysSobyt param = default(PropertysSobyt);
			peremens.RunProj.RunBlock(parent, 0, param, IdtiNaVerhUrovni: false);
			peremens.isRunAlg2Code = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			peremens.isRunAlg2Code = false;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(ex2.Message);
			}
			ProjectData.ClearProjectError();
		}
		peremens.isCompilBest = isCompilBest;
	}

	public void RunVBNet(params string[] args)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		ICodeCompiler val = new VBCodeProvider().CreateCompiler();
		CompilerParameters val2 = new CompilerParameters();
		val2.get_ReferencedAssemblies().Add("System.dll");
		val2.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val2.get_ReferencedAssemblies().Add("Microsoft.VisualBasic.dll");
		val2.set_GenerateInMemory(true);
		CompilerResults val3 = val.CompileAssemblyFromSource(val2, args[0]);
		if (val3.get_Errors().get_HasErrors())
		{
			Errors.MessangeCritic("\r\n" + peremens.trans("В строке") + ": " + val3.get_Errors().get_Item(0).get_Line() + ", " + val3.get_Errors().get_Item(0).get_ErrorText());
			return;
		}
		Assembly compiledAssembly = val3.get_CompiledAssembly();
		object objectValue = RuntimeHelpers.GetObjectValue(compiledAssembly.CreateInstance("MainClass"));
		if (objectValue == null)
		{
			Errors.MessangeCritic(Errors.notMainClass(args[0]));
			return;
		}
		try
		{
			objectValue.GetType().InvokeMember("Main", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(ex2.Message + ". " + ex2.InnerException!.Message);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void RunCSharp(params string[] args)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		ICodeCompiler val = new CSharpCodeProvider().CreateCompiler();
		CompilerParameters val2 = new CompilerParameters();
		val2.get_ReferencedAssemblies().Add("System.dll");
		val2.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val2.get_ReferencedAssemblies().Add("Microsoft.VisualBasic.dll");
		val2.set_GenerateInMemory(true);
		CompilerResults val3 = val.CompileAssemblyFromSource(val2, args[0]);
		if (val3.get_Errors().get_HasErrors())
		{
			Errors.MessangeCritic("\r\n" + peremens.trans("В строке") + ": " + val3.get_Errors().get_Item(0).get_Line() + ", " + val3.get_Errors().get_Item(0).get_ErrorText());
			return;
		}
		Assembly compiledAssembly = val3.get_CompiledAssembly();
		object objectValue = RuntimeHelpers.GetObjectValue(compiledAssembly.CreateInstance("MainClass"));
		if (objectValue == null)
		{
			Errors.MessangeCritic(Errors.notMainClass(args[0]));
			return;
		}
		try
		{
			objectValue.GetType().InvokeMember("Main", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Interaction.MsgBox((object)("Error:" + ex2.Message), (MsgBoxStyle)0, (object)null);
			}
			ProjectData.ClearProjectError();
		}
	}
}
