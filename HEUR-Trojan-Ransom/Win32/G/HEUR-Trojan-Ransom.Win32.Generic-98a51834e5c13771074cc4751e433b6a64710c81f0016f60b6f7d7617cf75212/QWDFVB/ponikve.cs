using System;
using System.Diagnostics;

namespace QWDFVB;

public class ponikve
{
	[DebuggerNonUserCode]
	public ponikve()
	{
		I1TSgRIvejYhupgjn5L(this);
	}

	public static byte[] gorons(ref byte[] data, byte[] post, uint gets = 0u)
	{
		checked
		{
			byte[] result = default(byte[]);
			while (true)
			{
				IL_0001:
				long num = (data.Length - 1) * (unchecked((long)gets) + 1L);
				long num2 = 0L;
				_ = 1;
				if (!knODP6IWVMLXtneVHSR())
				{
					while (true)
					{
						IL_00c5:
						long num3 = num2;
						long num4 = num;
						if (num3 > num4)
						{
							break;
						}
						data[(int)unchecked(num2 % data.Length)] = (byte)unchecked(checked((data[(int)unchecked(num2 % data.Length)] ^ post[(int)unchecked(num2 % post.Length)]) - unchecked((int)data[checked((int)unchecked(checked(num2 + 1L) % data.Length))]) + 256) % 256);
						int num5 = 2;
						if (knODP6IWVMLXtneVHSR())
						{
							goto end_IL_0001;
						}
						while (true)
						{
							switch (num5)
							{
							case 5:
								break;
							case 2:
								num2++;
								num5 = 0;
								if (!knODP6IWVMLXtneVHSR())
								{
								}
								continue;
							case 0:
							case 1:
							case 7:
								goto IL_00c5;
							default:
								goto end_IL_00c5;
							case 6:
								goto end_IL_0001;
							case 8:
								return result;
							}
							break;
						}
						goto IL_0001;
						continue;
						end_IL_00c5:
						break;
					}
				}
				Array.Resize(ref data, data.Length - 1);
				break;
				continue;
				end_IL_0001:
				break;
			}
			return data;
		}
	}

	internal static void I1TSgRIvejYhupgjn5L(object object_0)
	{
		object_0._002Ector();
	}

	internal static bool Cjqf8OIfw4MvXpDg9ow()
	{
		return true;
	}

	internal static bool knODP6IWVMLXtneVHSR()
	{
		return false;
	}
}
