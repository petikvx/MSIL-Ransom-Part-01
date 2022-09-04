using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace rundll32;

internal class ftp
{
	public string host;

	public int port;

	public string user;

	public string pass;

	public TcpClient _tcp;

	public Socket _data;

	private StreamWriter _sw;

	private StreamReader _sr;

	private string result;

	private string bucket;

	private string tempFileContents;

	private Thread connThread;

	private Thread dataThread;

	public ftp(string host, int port, string user, string pass)
	{
		this.host = host;
		this.port = port;
		this.user = user;
		this.pass = pass;
	}

	public void close()
	{
		try
		{
			connThread.Abort();
		}
		catch
		{
		}
		try
		{
			dataThread.Abort();
		}
		catch
		{
		}
		try
		{
			_tcp.Close();
		}
		catch
		{
		}
		try
		{
			_data.Close();
		}
		catch
		{
		}
	}

	public void connect()
	{
		_tcp = new TcpClient();
		_tcp.Connect(host, port);
		_sw = new StreamWriter(_tcp.GetStream());
		_sr = new StreamReader(_tcp.GetStream());
		connThread = new Thread(loopT);
		connThread.Start();
		_sw.AutoFlush = true;
		_sw.WriteLine("USER " + user);
		_sw.WriteLine("PASS " + pass);
	}

	public bool changeDir(string path)
	{
		bucket = null;
		_sw.WriteLine("CWD " + path);
		while (bucket == null)
		{
		}
		return bucket.StartsWith("250");
	}

	public bool makeDir(string dir)
	{
		bucket = null;
		_sw.WriteLine("MKD " + dir);
		while (bucket == null)
		{
		}
		return bucket.StartsWith("250");
	}

	public void writeFile(string fileName, string contents)
	{
		tempFileContents = contents;
		bucket = null;
		_sw.WriteLine("PASV");
		while (_data == null)
		{
		}
		bucket = null;
		_sw.WriteLine("TYPE I");
		while (_data == null)
		{
		}
		_sw.WriteLine("STOR " + fileName);
		while (bucket == null)
		{
		}
		dataThread = new Thread(loopUpload);
		dataThread.Start();
	}

	public string[] getFileFolders()
	{
		bucket = null;
		_sw.WriteLine("PASV");
		while (_data == null)
		{
		}
		dataThread = new Thread(loopFolders);
		dataThread.Start();
		_sw.WriteLine("LIST");
		while (result == null)
		{
		}
		string text = result;
		result = null;
		string[] array = text.Split(new char[1] { '\n' });
		List<string> list = new List<string>();
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split(new char[1] { ' ' });
			if (array3.Length > 4)
			{
				list.Add(array3[^1].Replace("\r", ""));
			}
		}
		return list.ToArray();
	}

	private void loopT()
	{
		try
		{
			while (true)
			{
				string text = _sr.ReadLine();
				if (text == null)
				{
					break;
				}
				Console.WriteLine(text);
				bucket = text;
				try
				{
					if (text.StartsWith("227"))
					{
						_data = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
						string[] array = text.Split(new char[1] { '(' })[1].Split(new char[1] { ')' })[0].Split(new char[1] { ',' });
						string text2 = $"{array[0]}.{array[1]}.{array[2]}.{array[3]}";
						int num = (int.Parse(array[4]) << 8) + int.Parse(array[5]);
						_data.Connect(text2, num);
					}
				}
				catch
				{
				}
			}
			throw new Exception();
		}
		catch
		{
		}
	}

	private void loopUpload()
	{
		try
		{
			_data.Send(Encoding.ASCII.GetBytes(tempFileContents));
			_data.Close();
		}
		catch
		{
		}
	}

	private void loopFolders()
	{
		try
		{
			int num = 0;
			while (_data.Available < 1)
			{
				Thread.Sleep(50);
				num++;
				if (num == 50)
				{
					result = "";
					break;
				}
			}
			byte[] array = new byte[512];
			long num2 = 0L;
			string text = "";
			while (_data.Available > 0)
			{
				num2 = _data.Receive(array, array.Length, SocketFlags.None);
				text += Encoding.ASCII.GetString(array, 0, (int)num2);
			}
			result = text;
			_data.Close();
			_data = null;
		}
		catch
		{
		}
	}
}
