using System.Diagnostics;
using Microsoft.VisualBasic;

namespace ns0;

public class GClass6
{
	public static readonly object object_0;

	public static readonly object object_1;

	public static readonly object object_2;

	public static readonly object object_3;

	public static readonly object object_4;

	public static readonly object object_5;

	public static readonly object object_6;

	public static readonly object object_7;

	static GClass6()
	{
		string[] array = default(string[]);
		while (true)
		{
			object_0 = "PackageIO";
			while (true)
			{
				object_1 = "FeudalNate";
				while (true)
				{
					object_2 = "Xbox 360 IO Class";
					while (true)
					{
						object_3 = "IO Class for Xbox 360 Packages";
						int num = 19;
						if (!smethod_4())
						{
							break;
						}
						while (true)
						{
							switch (num)
							{
							case 20:
								array[2] = (string)object_4;
								goto default;
							case 12:
								array[4] = (string)object_3;
								goto case 15;
							case 15:
								array[5] = "\n\nAuthor: ";
								goto case 5;
							case 5:
								array[6] = (string)object_1;
								goto case 4;
							case 4:
								array[7] = "\n\n";
								num = 8;
								if (smethod_4())
								{
									continue;
								}
								goto case 2;
							case 2:
								array = new string[11];
								goto case 11;
							case 11:
								array[0] = (string)object_0;
								goto case 3;
							case 3:
								array[1] = " - ";
								goto case 20;
							default:
								array[3] = "\n";
								goto case 12;
							case 19:
								object_4 = "0.1.7.0";
								goto case 9;
							case 9:
								object_5 = "http://www.openio.net16.net";
								_ = 0;
								if (smethod_4())
								{
									num = 17;
									if (smethod_4())
									{
										continue;
									}
									goto case 3;
								}
								goto case 16;
							case 6:
							case 17:
								object_6 = "Special thanks to Mojobojo and DJ Shepherd";
								goto case 2;
							case 7:
								break;
							case 14:
								goto end_IL_0102;
							case 21:
								goto end_IL_0119;
							case 10:
								goto end_IL_0125;
							case 8:
								array[8] = (string)object_6;
								goto case 13;
							case 13:
								array[9] = "\n\n\n";
								goto case 16;
							case 16:
							case 18:
								array[10] = (string)smethod_2(object_5);
								goto case 1;
							case 1:
								object_7 = smethod_3(array);
								return;
							case 22:
								return;
							}
							break;
						}
						continue;
						end_IL_0102:
						break;
					}
					continue;
					end_IL_0119:
					break;
				}
				continue;
				end_IL_0125:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	public GClass6()
	{
		smethod_6(this);
	}

	public static void smethod_0()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		smethod_7(object_7, (MsgBoxStyle)64, "About PackageIO");
	}

	public static void smethod_1()
	{
		smethod_8(object_5);
	}

	internal static object smethod_2(object object_8)
	{
		return ((string)object_8).ToString();
	}

	internal static object smethod_3(object object_8)
	{
		return string.Concat((string?[])object_8);
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static bool smethod_5()
	{
		return false;
	}

	internal static void smethod_6(object object_8)
	{
		object_8._002Ector();
	}

	internal static MsgBoxResult smethod_7(object object_8, MsgBoxStyle msgBoxStyle_0, object object_9)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_8, msgBoxStyle_0, object_9);
	}

	internal static object smethod_8(object object_8)
	{
		return Process.Start((string)object_8);
	}
}
