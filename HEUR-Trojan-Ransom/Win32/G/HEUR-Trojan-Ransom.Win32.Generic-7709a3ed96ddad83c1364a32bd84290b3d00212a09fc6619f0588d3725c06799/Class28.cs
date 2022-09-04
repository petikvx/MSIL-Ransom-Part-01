using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;

internal sealed class Class28
{
	private NetworkStream networkStream_0;

	private TcpClient tcpClient_0;

	private StreamReader streamReader_0;

	private StreamWriter streamWriter_0;

	private string string_0;

	private string string_1;

	private int int_0;

	private string string_2;

	private string string_3;

	public void method_0(string string_4, int int_1, string string_5, string string_6)
	{
		try
		{
			string_1 = string_4;
			int_0 = int_1;
			string_2 = string_5;
			string_3 = string_6;
			tcpClient_0 = new TcpClient();
			tcpClient_0.Connect(string_4, int_1);
			if (!tcpClient_0.Connected)
			{
				return;
			}
			networkStream_0 = tcpClient_0.GetStream();
			streamReader_0 = new StreamReader(networkStream_0);
			streamWriter_0 = new StreamWriter(networkStream_0);
			streamWriter_0.AutoFlush = true;
			streamWriter_0.WriteLine("USER " + string_5 + " " + string_5 + " * :" + string_5);
			streamWriter_0.WriteLine("NICK " + string_5);
			streamWriter_0.WriteLine("JOIN " + string_6);
			streamWriter_0.WriteLine("JOIN #" + Class25.smethod_2());
			while ((string_0 = streamReader_0.ReadLine()) != null)
			{
				if (string_0.StartsWith("PING :") || string_0.StartsWith(":" + string_5))
				{
					streamWriter_0.WriteLine("PONG :" + string_0.Substring(string_0.IndexOf(" :") + 2));
				}
				Console.WriteLine(string_0);
				Class27.smethod_0(string_0);
			}
		}
		catch (Exception ex)
		{
			method_3("ERROR: " + ex.ToString(), Class11.string_1, "red");
		}
	}

	public void method_1(string string_4)
	{
		try
		{
			streamWriter_0.WriteLine("JOIN " + string_4);
		}
		catch
		{
		}
	}

	public void method_2(string string_4)
	{
		try
		{
			streamWriter_0.WriteLine("QUIT " + string_4);
		}
		catch
		{
		}
	}

	public void method_3(string string_4, string string_5, string string_6)
	{
		try
		{
			string text = string.Empty;
			if (string_6 != null)
			{
				if (Class0.dictionary_0 == null)
				{
					Class0.dictionary_0 = new Dictionary<string, int>(14)
					{
						{ "navy_blue", 0 },
						{ "green", 1 },
						{ "red", 2 },
						{ "brown", 3 },
						{ "purple", 4 },
						{ "orange", 5 },
						{ "yellow", 6 },
						{ "lime", 7 },
						{ "teal", 8 },
						{ "light_cyan", 9 },
						{ "light_blue", 10 },
						{ "pink", 11 },
						{ "grey", 12 },
						{ "light_grey", 13 }
					};
				}
				if (Class0.dictionary_0.TryGetValue(string_6, out var value))
				{
					switch (value)
					{
					case 0:
						text = "\u00032";
						break;
					case 1:
						text = "\u00033";
						break;
					case 2:
						text = "\u00034";
						break;
					case 3:
						text = "\u00035";
						break;
					case 4:
						text = "\u00036";
						break;
					case 5:
						text = "\u00037";
						break;
					case 6:
						text = "\u00038";
						break;
					case 7:
						text = "\u00039";
						break;
					case 8:
						text = "\u000310";
						break;
					case 9:
						text = "\u000311";
						break;
					case 10:
						text = "\u000312";
						break;
					case 11:
						text = "\u000313";
						break;
					case 12:
						text = "\u000314";
						break;
					case 13:
						text = "\u000315";
						break;
					}
				}
			}
			streamWriter_0.WriteLine("PRIVMSG " + string_5 + " :" + text + " " + string_4);
			streamWriter_0.Flush();
		}
		catch
		{
		}
	}
}
