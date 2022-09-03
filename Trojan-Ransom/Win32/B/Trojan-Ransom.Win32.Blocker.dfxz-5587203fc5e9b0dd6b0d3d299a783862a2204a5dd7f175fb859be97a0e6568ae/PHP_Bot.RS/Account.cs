namespace PHP_Bot.RS;

internal class Account
{
	private string username;

	private string password;

	private int pin;

	public string GetUsername => username;

	public string GetPassword => password;

	public int GetPin => pin;

	public Account()
	{
	}

	public Account(string username)
	{
		this.username = username;
	}

	public Account(string username, string password)
	{
		this.username = username;
		this.password = password;
	}

	public Account(string username, string password, int pin)
	{
		this.username = username;
		this.password = password;
		this.pin = pin;
	}
}
