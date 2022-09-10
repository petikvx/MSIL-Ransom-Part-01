using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

public class clsFTP
{
	private string m_sRemoteHost;

	private string m_sRemotePath;

	private string m_sRemoteUser;

	private string m_sRemotePassword;

	private string m_sMess;

	private int m_iRemotePort;

	private int m_iBytes;

	private Socket m_objClientSocket;

	private int m_iRetValue;

	private bool m_bLoggedIn;

	private string m_sMes;

	private string m_sReply;

	public const int BLOCK_SIZE = 512;

	private byte[] m_aBuffer;

	private Encoding ASCII;

	private string m_sMessageString;

	public string RemoteHost
	{
		get
		{
			return m_sRemoteHost;
		}
		set
		{
			m_sRemoteHost = value;
		}
	}

	public int RemotePort
	{
		get
		{
			return m_iRemotePort;
		}
		set
		{
			m_iRemotePort = value;
		}
	}

	public string RemotePath
	{
		get
		{
			return m_sRemotePath;
		}
		set
		{
			m_sRemotePath = value;
		}
	}

	public string RemotePassword
	{
		get
		{
			return m_sRemotePassword;
		}
		set
		{
			m_sRemotePassword = value;
		}
	}

	public string RemoteUser
	{
		get
		{
			return m_sRemoteUser;
		}
		set
		{
			m_sRemoteUser = value;
		}
	}

	public string MessageString
	{
		get
		{
			return m_sMessageString;
		}
		set
		{
			m_sMessageString = value;
		}
	}

	public clsFTP()
	{
		m_aBuffer = new byte[513];
		ASCII = Encoding.ASCII;
		m_sRemoteHost = "microsoft";
		m_sRemotePath = ".";
		m_sRemoteUser = "anonymous";
		m_sRemotePassword = "";
		m_sMessageString = "";
		m_iRemotePort = 21;
		m_bLoggedIn = false;
	}

	public clsFTP(string sRemoteHost, string sRemotePath, string sRemoteUser, string sRemotePassword, int iRemotePort)
	{
		m_aBuffer = new byte[513];
		ASCII = Encoding.ASCII;
		m_sRemoteHost = sRemoteHost;
		m_sRemotePath = sRemotePath;
		m_sRemoteUser = sRemoteUser;
		m_sRemotePassword = sRemotePassword;
		m_sMessageString = "";
		m_iRemotePort = iRemotePort;
		m_bLoggedIn = false;
	}

	public string[] GetFileList(string sMask)
	{
		char c = '\n';
		m_sMes = "";
		if (!m_bLoggedIn)
		{
			Login();
		}
		Socket socket = CreateDataSocket();
		SendCommand("NLST " + sMask);
		if (!((m_iRetValue == 150) | (m_iRetValue == 125)))
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		m_sMes = "";
		int num;
		do
		{
			Array.Clear(m_aBuffer, 0, m_aBuffer.Length);
			num = socket.Receive(m_aBuffer, m_aBuffer.Length, SocketFlags.None);
			m_sMes += ASCII.GetString(m_aBuffer, 0, num);
		}
		while (num >= m_aBuffer.Length);
		string[] result = m_sMes.Split(new char[1] { c });
		socket.Close();
		ReadReply();
		if (m_iRetValue != 226)
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		return result;
	}

	public long GetFileSize(string sFileName)
	{
		if (!m_bLoggedIn)
		{
			Login();
		}
		SendCommand("SIZE " + sFileName);
		long num = 0L;
		if (m_iRetValue != 213)
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		return long.Parse(m_sReply.Substring(4));
	}

	public bool Login()
	{
		m_objClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPEndPoint remoteEP = new IPEndPoint(Dns.Resolve(m_sRemoteHost).AddressList[0], m_iRemotePort);
		try
		{
			m_objClientSocket.Connect(remoteEP);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageString = m_sReply;
			throw new IOException("Couldn't connect to remote server");
		}
		ReadReply();
		if (m_iRetValue != 220)
		{
			CloseConnection();
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		SendCommand("USER " + m_sRemoteUser);
		if (!((m_iRetValue == 331) | (m_iRetValue == 230)))
		{
			Cleanup();
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		if (m_iRetValue != 230)
		{
			SendCommand("PASS " + m_sRemotePassword);
			if (!((m_iRetValue == 230) | (m_iRetValue == 202)))
			{
				Cleanup();
				MessageString = m_sReply;
				throw new IOException(m_sReply.Substring(4));
			}
		}
		m_bLoggedIn = true;
		ChangeDirectory(m_sRemotePath);
		return m_bLoggedIn;
	}

	public void SetBinaryMode(bool bMode)
	{
		if (bMode)
		{
			SendCommand("TYPE I");
		}
		else
		{
			SendCommand("TYPE A");
		}
		if (m_iRetValue != 200)
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
	}

	public void DownloadFile(string sFileName)
	{
		DownloadFile(sFileName, "", bResume: false);
	}

	public void DownloadFile(string sFileName, bool bResume)
	{
		DownloadFile(sFileName, "", bResume);
	}

	public void DownloadFile(string sFileName, string sLocalFileName)
	{
		DownloadFile(sFileName, sLocalFileName, bResume: false);
	}

	public void DownloadFile(string sFileName, string sLocalFileName, bool bResume)
	{
		if (!m_bLoggedIn)
		{
			Login();
		}
		SetBinaryMode(bMode: true);
		if (sLocalFileName.Equals(""))
		{
			sLocalFileName = sFileName;
		}
		if (!File.Exists(sLocalFileName))
		{
			Stream stream = File.Create(sLocalFileName);
			stream.Close();
		}
		FileStream fileStream = new FileStream(sLocalFileName, FileMode.Open);
		Socket socket = CreateDataSocket();
		long num = 0L;
		if (bResume)
		{
			num = fileStream.Length;
			if (num > 0L)
			{
				SendCommand("REST " + Conversions.ToString(num));
				if (m_iRetValue != 350)
				{
					num = 0L;
				}
			}
			if (num > 0L)
			{
				fileStream.Seek(num, SeekOrigin.Begin);
			}
		}
		SendCommand("RETR " + sFileName);
		if (!((m_iRetValue == 150) | (m_iRetValue == 125)))
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		do
		{
			Array.Clear(m_aBuffer, 0, m_aBuffer.Length);
			m_iBytes = socket.Receive(m_aBuffer, m_aBuffer.Length, SocketFlags.None);
			fileStream.Write(m_aBuffer, 0, m_iBytes);
		}
		while (m_iBytes > 0);
		fileStream.Close();
		if (socket.Connected)
		{
			socket.Close();
		}
		ReadReply();
		if (!((m_iRetValue == 226) | (m_iRetValue == 250)))
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
	}

	public void UploadFile(string sFileName)
	{
		UploadFile(sFileName, bResume: false);
	}

	public void UploadFile(string sFileName, bool bResume)
	{
		if (!m_bLoggedIn)
		{
			Login();
		}
		Socket socket = CreateDataSocket();
		long num = 0L;
		if (bResume)
		{
			try
			{
				SetBinaryMode(bMode: true);
				num = GetFileSize(sFileName);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				num = 0L;
				ProjectData.ClearProjectError();
			}
		}
		if (num > 0L)
		{
			SendCommand("REST " + Conversions.ToString(num));
			if (m_iRetValue != 350)
			{
				num = 0L;
			}
		}
		SendCommand("STOR " + Path.GetFileName(sFileName));
		if (!((m_iRetValue == 125) | (m_iRetValue == 150)))
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		bool flag = false;
		if (File.Exists(sFileName))
		{
			FileStream fileStream = new FileStream(sFileName, FileMode.Open);
			if (num != 0L)
			{
				fileStream.Seek(num, SeekOrigin.Begin);
			}
			for (m_iBytes = fileStream.Read(m_aBuffer, 0, m_aBuffer.Length); m_iBytes > 0; m_iBytes = fileStream.Read(m_aBuffer, 0, m_aBuffer.Length))
			{
				socket.Send(m_aBuffer, m_iBytes, SocketFlags.None);
			}
			fileStream.Close();
		}
		else
		{
			flag = true;
		}
		if (socket.Connected)
		{
			socket.Close();
		}
		if (flag)
		{
			MessageString = m_sReply;
			throw new IOException("The file: " + sFileName + " was not found.  Can not upload the file to the FTP Site.");
		}
		ReadReply();
		if (!((m_iRetValue == 226) | (m_iRetValue == 250)))
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
	}

	public bool DeleteFile(string sFileName)
	{
		bool result = true;
		if (!m_bLoggedIn)
		{
			Login();
		}
		SendCommand("DELE " + sFileName);
		if (m_iRetValue != 250)
		{
			result = false;
			MessageString = m_sReply;
		}
		return result;
	}

	public bool RenameFile(string sOldFileName, string sNewFileName)
	{
		bool result = true;
		if (!m_bLoggedIn)
		{
			Login();
		}
		SendCommand("RNFR " + sOldFileName);
		if (m_iRetValue != 350)
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		SendCommand("RNTO " + sNewFileName);
		if (m_iRetValue != 250)
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		return result;
	}

	public bool CreateDirectory(string sDirName)
	{
		bool result = true;
		if (!m_bLoggedIn)
		{
			Login();
		}
		SendCommand("MKD " + sDirName);
		if (m_iRetValue != 257)
		{
			result = false;
			MessageString = m_sReply;
		}
		return result;
	}

	public bool RemoveDirectory(string sDirName)
	{
		bool result = true;
		if (!m_bLoggedIn)
		{
			Login();
		}
		SendCommand("RMD " + sDirName);
		if (m_iRetValue != 250)
		{
			result = false;
			MessageString = m_sReply;
		}
		return result;
	}

	public bool ChangeDirectory(string sDirName)
	{
		bool result = true;
		if (!sDirName.Equals("."))
		{
			if (!m_bLoggedIn)
			{
				Login();
			}
			SendCommand("CWD " + sDirName);
			if (m_iRetValue != 250)
			{
				result = false;
				MessageString = m_sReply;
			}
			m_sRemotePath = sDirName;
			return result;
		}
		bool result2 = default(bool);
		return result2;
	}

	public void CloseConnection()
	{
		if (m_objClientSocket != null)
		{
			SendCommand("QUIT");
		}
		Cleanup();
	}

	private void ReadReply()
	{
		m_sMes = "";
		m_sReply = ReadLine();
		m_iRetValue = int.Parse(m_sReply.Substring(0, 3));
	}

	private void Cleanup()
	{
		if (m_objClientSocket != null)
		{
			m_objClientSocket.Close();
			m_objClientSocket = null;
		}
		m_bLoggedIn = false;
	}

	private string ReadLine(bool bClearMes = false)
	{
		char c = '\n';
		if (bClearMes)
		{
			m_sMes = "";
		}
		do
		{
			Array.Clear(m_aBuffer, 0, 512);
			m_iBytes = m_objClientSocket.Receive(m_aBuffer, m_aBuffer.Length, SocketFlags.None);
			m_sMes += ASCII.GetString(m_aBuffer, 0, m_iBytes);
		}
		while (m_iBytes >= m_aBuffer.Length);
		string[] array = m_sMes.Split(new char[1] { c });
		if (m_sMes.Length > 2)
		{
			m_sMes = array[checked(array.Length - 2)];
		}
		else
		{
			m_sMes = array[0];
		}
		if (!m_sMes.Substring(3, 1).Equals(" "))
		{
			return ReadLine(bClearMes: true);
		}
		return m_sMes;
	}

	private void SendCommand(string sCommand)
	{
		sCommand += "\r\n";
		byte[] bytes = ASCII.GetBytes(sCommand);
		m_objClientSocket.Send(bytes, bytes.Length, SocketFlags.None);
		ReadReply();
	}

	private Socket CreateDataSocket()
	{
		int[] array = new int[7];
		SendCommand("PASV");
		if (m_iRetValue != 227)
		{
			MessageString = m_sReply;
			throw new IOException(m_sReply.Substring(4));
		}
		int num = m_sReply.IndexOf("(");
		int num2 = m_sReply.IndexOf(")");
		checked
		{
			string text = m_sReply.Substring(num + 1, num2 - num - 1);
			int length = text.Length;
			int num3 = 0;
			string text2 = "";
			int num4 = (length - 1) & -1;
			int num5 = 0;
			Socket socket;
			while (true)
			{
				int num6 = num5;
				int num7 = num4;
				if (num6 <= num7)
				{
					char c = char.Parse(text.Substring(num5, 1));
					if (char.IsDigit(c))
					{
						text2 += Conversions.ToString(c);
					}
					else if (Operators.CompareString(Conversions.ToString(c), ",", false) != 0)
					{
						MessageString = m_sReply;
						throw new IOException("Malformed PASV reply: " + m_sReply);
					}
					if ((Operators.CompareString(Conversions.ToString(c), ",", false) == 0) | (num5 + 1 == length))
					{
						try
						{
							array[num3] = int.Parse(text2);
							num3++;
							text2 = "";
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							MessageString = m_sReply;
							throw new IOException("Malformed PASV reply: " + m_sReply);
						}
					}
					num5++;
					continue;
				}
				string hostName = Conversions.ToString(array[0]) + "." + Conversions.ToString(array[1]) + "." + Conversions.ToString(array[2]) + "." + Conversions.ToString(array[3]);
				int num8 = (int)Math.Round((double)array[4] * 256.0);
				num8 += array[5];
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				IPEndPoint remoteEP = new IPEndPoint(Dns.Resolve(hostName).AddressList[0], num8);
				try
				{
					socket.Connect(remoteEP);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					MessageString = m_sReply;
					throw new IOException("Can't connect to remote server");
				}
				break;
			}
			return socket;
		}
	}
}
