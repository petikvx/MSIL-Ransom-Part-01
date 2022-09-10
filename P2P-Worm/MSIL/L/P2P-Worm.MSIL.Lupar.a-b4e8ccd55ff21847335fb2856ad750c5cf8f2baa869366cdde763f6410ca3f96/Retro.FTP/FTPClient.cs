using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Retro.FTP;

public class FTPClient
{
	private string Host;

	private string fPath;

	private string User;

	private string Pass;

	private string l;

	private int Port;

	private int bytes;

	private Socket ftpSocket;

	private int value;

	private bool logined;

	private string reply;

	private static int BLOCK_SIZE = 512;

	private byte[] b = new byte[BLOCK_SIZE];

	private Encoding ASCII = Encoding.ASCII;

	public FTPClient()
	{
		Host = "localhost";
		fPath = ".";
		User = "anonymous";
		Pass = "test@test.com";
		Port = 21;
		logined = false;
	}

	public void setHost(string Host)
	{
		this.Host = Host;
	}

	public string getHost()
	{
		return Host;
	}

	public void setPort(int Port)
	{
		this.Port = Port;
	}

	public int getPort()
	{
		return Port;
	}

	public void setPath(string Path)
	{
		fPath = Path;
	}

	public string getPath()
	{
		return fPath;
	}

	public void setUser(string User)
	{
		this.User = User;
	}

	public void setPass(string Pass)
	{
		this.Pass = Pass;
	}

	public string[] getFileList(string mask)
	{
		if (!logined)
		{
			login();
		}
		Socket socket = createDataSocket();
		sendCommand("NLST " + mask);
		if (value != 150 && value != 125)
		{
			throw new IOException(reply.Substring(4));
		}
		l = "";
		int num;
		do
		{
			num = socket.Receive(b, b.Length, SocketFlags.None);
			l += ASCII.GetString(b, 0, num);
		}
		while (num >= b.Length);
		char[] separator = new char[1] { '\n' };
		string[] result = l.Split(separator);
		socket.Close();
		readReply();
		if (value != 226)
		{
			throw new IOException(reply.Substring(4));
		}
		return result;
	}

	public long getFileSize(string fileName)
	{
		if (!logined)
		{
			login();
		}
		sendCommand("SIZE " + fileName);
		long num = 0L;
		if (value != 213)
		{
			throw new IOException(reply.Substring(4));
		}
		return long.Parse(reply.Substring(4));
	}

	public void login()
	{
		ftpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPEndPoint remoteEP = new IPEndPoint(Dns.GetHostEntry(Host).AddressList[0], Port);
		try
		{
			ftpSocket.Connect(remoteEP);
		}
		catch (Exception)
		{
			throw new IOException("Couldn't connect to remote server");
		}
		readReply();
		if (value != 220)
		{
			close();
			throw new IOException(reply.Substring(4));
		}
		sendCommand("USER " + User);
		if (value != 331 && value != 230)
		{
			cleanup();
			throw new IOException(reply.Substring(4));
		}
		if (value != 230)
		{
			sendCommand("PASS " + Pass);
			if (value != 230 && value != 202)
			{
				cleanup();
				throw new IOException(reply.Substring(4));
			}
		}
		logined = true;
		Console.WriteLine("Connected to " + Host);
		chdir(fPath);
	}

	public void setBinaryMode(bool mode)
	{
		if (mode)
		{
			sendCommand("TYPE I");
		}
		else
		{
			sendCommand("TYPE A");
		}
		if (value != 200)
		{
			throw new IOException(reply.Substring(4));
		}
	}

	public void upload(string fileName)
	{
		upload(fileName, resume: false);
	}

	public void upload(string fileName, bool resume)
	{
		if (!logined)
		{
			login();
		}
		Socket socket = createDataSocket();
		long num = 0L;
		if (resume)
		{
			try
			{
				setBinaryMode(mode: true);
				num = getFileSize(fileName);
			}
			catch (Exception)
			{
				num = 0L;
			}
		}
		if (num > 0L)
		{
			sendCommand("REST " + num);
			if (value != 350)
			{
				num = 0L;
			}
		}
		sendCommand("STOR " + Path.GetFileName(fileName));
		if (value != 125)
		{
		}
		FileStream fileStream = new FileStream(fileName, FileMode.Open);
		if (num != 0L)
		{
			fileStream.Seek(num, SeekOrigin.Begin);
		}
		while ((bytes = fileStream.Read(b, 0, b.Length)) > 0)
		{
			socket.Send(b, bytes, SocketFlags.None);
		}
		fileStream.Close();
		if (socket.Connected)
		{
			socket.Close();
		}
		readReply();
		if (value != 226 && value != 250)
		{
			throw new IOException(reply.Substring(4));
		}
	}

	public void deleteRemoteFile(string fileName)
	{
		if (!logined)
		{
			login();
		}
		sendCommand("DELE " + fileName);
	}

	public void renameRemoteFile(string oldFileName, string newFileName)
	{
		if (!logined)
		{
			login();
		}
		sendCommand("RNFR " + oldFileName);
		if (value != 350)
		{
			throw new IOException(reply.Substring(4));
		}
		sendCommand("RNTO " + newFileName);
		if (value != 250)
		{
			throw new IOException(reply.Substring(4));
		}
	}

	public void mkdir(string dirName)
	{
		if (!logined)
		{
			login();
		}
		sendCommand("MKD " + dirName);
	}

	public void rmdir(string dirName)
	{
		if (!logined)
		{
			login();
		}
		sendCommand("RMD " + dirName);
	}

	public void chdir(string dirName)
	{
		if (!dirName.Equals("."))
		{
			if (!logined)
			{
				login();
			}
			sendCommand("CWD " + dirName);
			fPath = dirName;
		}
	}

	public void close()
	{
		if (ftpSocket != null)
		{
			sendCommand("QUIT");
		}
		cleanup();
	}

	private void readReply()
	{
		l = "";
		reply = readLine();
		value = int.Parse(reply.Substring(0, 3));
	}

	private void cleanup()
	{
		if (ftpSocket != null)
		{
			ftpSocket.Close();
			ftpSocket = null;
		}
		logined = false;
	}

	private string readLine()
	{
		do
		{
			bytes = ftpSocket.Receive(b, b.Length, SocketFlags.None);
			l += ASCII.GetString(b, 0, bytes);
		}
		while (bytes >= b.Length);
		char[] separator = new char[1] { '\n' };
		string[] array = l.Split(separator);
		if (l.Length > 2)
		{
			l = array[^2];
		}
		else
		{
			l = array[0];
		}
		if (!l.Substring(3, 1).Equals(" "))
		{
			return readLine();
		}
		return l;
	}

	private void sendCommand(string command)
	{
		byte[] array = Encoding.ASCII.GetBytes((command + "\r\n").ToCharArray());
		ftpSocket.Send(array, array.Length, SocketFlags.None);
		readReply();
	}

	private Socket createDataSocket()
	{
		sendCommand("PASV");
		if (value != 227)
		{
			throw new IOException(reply.Substring(4));
		}
		int num = reply.IndexOf('(');
		int num2 = reply.IndexOf(')');
		string text = reply.Substring(num + 1, num2 - num - 1);
		int[] array = new int[6];
		int length = text.Length;
		int num3 = 0;
		string text2 = "";
		for (int i = 0; i < length; i++)
		{
			if (num3 > 6)
			{
				break;
			}
			char c = char.Parse(text.Substring(i, 1));
			if (char.IsDigit(c))
			{
				text2 += c;
			}
			if (c == ',' || i + 1 == length)
			{
				try
				{
					array[num3++] = int.Parse(text2);
					text2 = "";
				}
				catch (Exception)
				{
				}
			}
		}
		string hostNameOrAddress = array[0] + "." + array[1] + "." + array[2] + "." + array[3];
		int port = (array[4] << 8) + array[5];
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPEndPoint remoteEP = new IPEndPoint(Dns.GetHostEntry(hostNameOrAddress).AddressList[0], port);
		try
		{
			socket.Connect(remoteEP);
			return socket;
		}
		catch (Exception)
		{
			return socket;
		}
	}
}
