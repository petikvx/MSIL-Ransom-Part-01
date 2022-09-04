using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Text;
using SimpleJson;
using e9a0jRW7WM0ZtAYBQW;

namespace DeathByCaptcha;

public class SocketClient : Client
{
	public const string ServerHost = "api.dbcapi.me";

	public const int ServerFirstPort = 8123;

	public const int ServerLastPort = 8130;

	public const string Terminator = "\r\n";

	protected TcpClient tcpClient;

	public bool Connected
	{
		get
		{
			if (tcpClient != null)
			{
				return tcpClient.Connected;
			}
			return false;
		}
	}

	protected void Disconnect()
	{
		if (Connected && tcpClient != null)
		{
			Log("CLOSE");
			try
			{
				tcpClient.GetStream().Close();
			}
			catch (System.Exception)
			{
			}
			try
			{
				tcpClient.Close();
			}
			catch (System.Exception)
			{
			}
			tcpClient = null;
		}
	}

	protected bool Connect()
	{
		if (!Connected)
		{
			Log("CONN");
			TcpClient tcpClient = new TcpClient();
			tcpClient.SendTimeout = 60000;
			tcpClient.ReceiveTimeout = 60000;
			tcpClient.Connect("api.dbcapi.me", new Random().Next(8123, 8131));
			if (tcpClient.Connected)
			{
				this.tcpClient = tcpClient;
			}
		}
		return Connected;
	}

	protected SocketClient Send(byte[] buf)
	{
		Log("SEND", Encoding.ASCII.GetString(buf, 0, buf.Length - 2));
		tcpClient.GetStream().Write(buf, 0, buf.Length);
		return this;
	}

	protected string Receive()
	{
		int num = 0;
		byte[] array = new byte[256];
		StringBuilder stringBuilder = new StringBuilder();
		NetworkStream stream = tcpClient.GetStream();
		do
		{
			if (0 < (num = stream.Read(array, 0, array.Length)))
			{
				stringBuilder.Append(Encoding.ASCII.GetString(array, 0, num));
				continue;
			}
			throw new IOException("API connection lost");
		}
		while (!stringBuilder.ToString(num - 2, 2).Equals("\r\n"));
		Log("RECV", stringBuilder.ToString());
		return stringBuilder.ToString();
	}

	protected Hashtable Call(string cmd, Hashtable args)
	{
		args["cmd"] = cmd;
		args["version"] = "DBC/.NET v4.1.2";
		int num = 2;
		byte[] bytes = Encoding.ASCII.GetBytes(Writer.Write(args) + "\r\n");
		Hashtable hashtable = null;
		while (0 < num && hashtable == null)
		{
			num--;
			if (!Connected && !cmd.Equals("login"))
			{
				Call("login", base.Credentials);
			}
			lock (_callLock)
			{
				try
				{
					if (Connect())
					{
						hashtable = (Hashtable)Reader.Read(Send(bytes).Receive());
					}
				}
				catch (FormatException)
				{
					Disconnect();
					hashtable = new Hashtable();
				}
				catch (System.Exception)
				{
					Disconnect();
				}
			}
		}
		if (hashtable == null)
		{
			throw new IOException("API connection lost or timed out");
		}
		if (hashtable.ContainsKey("error"))
		{
			lock (_callLock)
			{
				Disconnect();
			}
			string text = Convert.ToString(hashtable["error"]);
			if (text.Equals("not-logged-in"))
			{
				throw new AccessDeniedException("Access denied, check your credentials");
			}
			if (text.Equals("banned"))
			{
				throw new AccessDeniedException("Access denied, account is suspended");
			}
			if (text.Equals("insufficient-funds"))
			{
				throw new AccessDeniedException("Access denied, balance is too low");
			}
			if (text.Equals("invalid-captcha"))
			{
				throw new InvalidCaptchaException("CAPTCHA was rejected, please check if it's a valid image");
			}
			if (text.Equals("service-overload"))
			{
				throw new ServiceOverloadException("CAPTCHA was rejected due to service overload");
			}
			throw new IOException("API server error occured: " + text);
		}
		return hashtable;
	}

	protected Hashtable Call(string cmd)
	{
		return Call(cmd, new Hashtable());
	}

	public SocketClient(string username, string password)
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		base._002Ector(username, password);
	}

	~SocketClient()
	{
		Close();
	}

	public override void Close()
	{
		lock (_callLock)
		{
			Disconnect();
		}
	}

	public override User GetUser()
	{
		return new User(Call("user"));
	}

	public override Captcha GetCaptcha(int id)
	{
		Hashtable hashtable = new Hashtable();
		hashtable["captcha"] = id;
		return new Captcha(Call("captcha", hashtable));
	}

	public override Captcha Upload(byte[] img)
	{
		Hashtable hashtable = new Hashtable();
		hashtable["swid"] = 0;
		hashtable["captcha"] = Convert.ToBase64String(img);
		Captcha captcha = new Captcha(Call("upload", hashtable));
		if (!captcha.Uploaded)
		{
			return null;
		}
		return captcha;
	}

	public override bool Report(int id)
	{
		Hashtable hashtable = new Hashtable();
		hashtable["captcha"] = id;
		return !new Captcha(Call("report", hashtable)).Correct;
	}
}
