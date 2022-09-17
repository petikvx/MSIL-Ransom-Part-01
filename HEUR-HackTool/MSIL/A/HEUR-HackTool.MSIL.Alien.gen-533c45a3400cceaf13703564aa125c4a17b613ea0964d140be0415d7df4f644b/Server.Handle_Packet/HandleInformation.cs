using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet;

public class HandleInformation
{
	public void AddToInformationList(Clients client, MsgPack unpack_msgpack)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Path.Combine(Application.get_StartupPath(), "ClientsFolder\\" + unpack_msgpack.ForcePathObject("ID").AsString + "\\Information");
			string text2 = text + "\\Information.txt";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text2, unpack_msgpack.ForcePathObject("InforMation").AsString);
			Process.Start("explorer.exe", text2);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}
