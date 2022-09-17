using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Handle_Packet;

namespace Server.Connection;

internal class Listener
{
	private Socket Server { get; set; }

	public void Connect(object port)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
			Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				SendBufferSize = 51200,
				ReceiveBufferSize = 51200
			};
			Server.Bind(localEP);
			Server.Listen(500);
			new HandleLogs().Addmsg($"Listenning to: {port}", Color.Green);
			Server.BeginAccept(EndAccept, null);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			Environment.Exit(0);
		}
	}

	private void EndAccept(IAsyncResult ar)
	{
		try
		{
			new Clients(Server.EndAccept(ar));
		}
		catch
		{
		}
		finally
		{
			Server.BeginAccept(EndAccept, null);
		}
	}
}
