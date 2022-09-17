using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet;

public class HandleFun
{
	public void Fun(Clients client, MsgPack unpack_msgpack)
	{
		try
		{
			FormFun formFun = (FormFun)(object)Application.get_OpenForms().get_Item("fun:" + unpack_msgpack.ForcePathObject("Hwid").AsString);
			if (formFun != null && formFun.Client == null)
			{
				formFun.Client = client;
				formFun.timer1.set_Enabled(true);
			}
		}
		catch
		{
		}
	}
}
