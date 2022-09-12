namespace Renci.SshNet.Common;

public class AuthenticationPrompt
{
	public int Id { get; private set; }

	public bool IsEchoed { get; private set; }

	public string Request { get; private set; }

	public string Response { get; set; }

	public AuthenticationPrompt(int id, bool isEchoed, string request)
	{
		Id = id;
		IsEchoed = isEchoed;
		Request = request;
	}
}
