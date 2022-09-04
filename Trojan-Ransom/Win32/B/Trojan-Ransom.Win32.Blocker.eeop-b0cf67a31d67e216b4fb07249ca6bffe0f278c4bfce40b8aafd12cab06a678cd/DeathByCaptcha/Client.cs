using System;
using System.Collections;
using System.IO;
using System.Threading;
using e9a0jRW7WM0ZtAYBQW;

namespace DeathByCaptcha;

public abstract class Client
{
	public const string Version = "DBC/.NET v4.1.2";

	public const int SoftwareVendorId = 0;

	public const int DefaultTimeout = 60;

	public const int PollsInterval = 5;

	public bool Verbose;

	protected string _username;

	protected string _password;

	protected object _callLock;

	public Hashtable Credentials
	{
		get
		{
			Hashtable hashtable = new Hashtable();
			hashtable["username"] = _username;
			hashtable["password"] = _password;
			return hashtable;
		}
	}

	public User User => GetUser();

	public double Balance => GetBalance();

	protected void Log(string call, string msg)
	{
		if (Verbose)
		{
			Console.WriteLine(DateTime.Now.Ticks + " " + call + ((msg != null) ? (": " + msg) : ""));
		}
	}

	protected void Log(string call)
	{
		Log(call, null);
	}

	protected byte[] Load(Stream st)
	{
		long num = -1L;
		if (st.CanSeek)
		{
			num = st.Position;
			st.Position = 0L;
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = 1024;
		byte[] array = new byte[1024];
		while (st.CanRead && 0 < (num2 = st.Read(array, num3, num4)))
		{
			num3 += num2;
			Array.Resize(ref array, num3 + num4);
		}
		if (-1L < num)
		{
			st.Position = num;
		}
		Array.Resize(ref array, num3);
		return array;
	}

	protected byte[] Load(string fn)
	{
		if (!File.Exists(fn))
		{
			throw new FileNotFoundException("CAPTCHA image file " + fn + " not found");
		}
		using FileStream st = File.OpenRead(fn);
		return Load(st);
	}

	protected Captcha Poll(Captcha captcha, int timeout)
	{
		if (captcha != null)
		{
			DateTime dateTime = DateTime.Now.AddSeconds((0 < timeout) ? timeout : 60);
			while (dateTime > DateTime.Now && !captcha.Solved)
			{
				Thread.Sleep(5000);
				try
				{
					captcha = GetCaptcha(captcha);
				}
				catch (System.Exception ex)
				{
					if (Verbose)
					{
						Console.WriteLine(DateTime.Now.Ticks + " POLL " + ex.Message);
					}
					return null;
				}
			}
			if (captcha.Solved && captcha.Correct)
			{
				return captcha;
			}
		}
		return null;
	}

	protected void PollWithCallback(object state)
	{
		PollPayload pollPayload = (PollPayload)state;
		pollPayload.Callback(Poll(pollPayload.Captcha, pollPayload.Timeout));
	}

	public Client(string username, string password)
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		_username = "";
		_password = "";
		_callLock = new object();
		base._002Ector();
		_username = username;
		_password = password;
	}

	public abstract void Close();

	public abstract User GetUser();

	public double GetBalance()
	{
		return GetUser().Balance;
	}

	public abstract Captcha GetCaptcha(int id);

	public Captcha GetCaptcha(Captcha captcha)
	{
		return GetCaptcha(captcha.Id);
	}

	public string GetText(int id)
	{
		return GetCaptcha(id).Text;
	}

	public string GetText(Captcha captcha)
	{
		return GetCaptcha(captcha).Text;
	}

	public abstract Captcha Upload(byte[] img);

	public Captcha Upload(Stream st)
	{
		return Upload(Load(st));
	}

	public Captcha Upload(string fn)
	{
		return Upload(Load(fn));
	}

	public abstract bool Report(int id);

	public bool Report(Captcha captcha)
	{
		return Report(captcha.Id);
	}

	public Captcha Decode(byte[] img, int timeout)
	{
		return Poll(Upload(img), timeout);
	}

	public void Decode(DecodeDelegate callback, byte[] img, int timeout)
	{
		PollPayload pollPayload = new PollPayload();
		pollPayload.Callback = callback;
		pollPayload.Captcha = Upload(img);
		pollPayload.Timeout = timeout;
		new Thread(PollWithCallback).Start(pollPayload);
	}

	public Captcha Decode(byte[] img)
	{
		return Decode(img, 0);
	}

	public void Decode(DecodeDelegate callback, byte[] img)
	{
		Decode(callback, img, 0);
	}

	public Captcha Decode(Stream st, int timeout)
	{
		return Decode(Load(st), timeout);
	}

	public void Decode(DecodeDelegate callback, Stream st, int timeout)
	{
		Decode(callback, Load(st), timeout);
	}

	public Captcha Decode(Stream st)
	{
		return Decode(st, 0);
	}

	public void Decode(DecodeDelegate callback, Stream st)
	{
		Decode(callback, Load(st), 0);
	}

	public Captcha Decode(string fn, int timeout)
	{
		return Decode(Load(fn), timeout);
	}

	public void Decode(DecodeDelegate callback, string fn, int timeout)
	{
		Decode(callback, Load(fn), timeout);
	}

	public Captcha Decode(string fn)
	{
		return Decode(fn, 0);
	}

	public void Decode(DecodeDelegate callback, string fn)
	{
		Decode(callback, Load(fn), 0);
	}
}
