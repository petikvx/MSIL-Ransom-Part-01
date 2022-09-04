namespace rundll32;

public struct ircUser
{
	private irc _irc;

	private string _nick;

	private string _user;

	private string _host;

	public irc irc => _irc;

	public string nick => _nick;

	public string user => _user;

	public string host => _host;

	public ircUser(irc irc, string nick, string user)
	{
		_irc = irc;
		_nick = nick;
		_user = user;
		_host = "127.0.0.1";
	}

	public ircUser(irc irc, string nick, string user, string host)
	{
		_irc = irc;
		_nick = nick;
		_user = user;
		_host = host;
	}

	public void loadIrc(irc irc)
	{
		_irc = irc;
	}
}
