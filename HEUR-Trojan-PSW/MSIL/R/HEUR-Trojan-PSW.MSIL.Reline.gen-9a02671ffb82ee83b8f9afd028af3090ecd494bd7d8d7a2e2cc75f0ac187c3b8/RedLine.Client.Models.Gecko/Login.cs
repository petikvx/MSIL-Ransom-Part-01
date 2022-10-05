namespace RedLine.Client.Models.Gecko;

public class Login
{
	public int id { get; set; }

	public string hostname { get; set; }

	public object httpRealm { get; set; }

	public string formSubmitURL { get; set; }

	public string usernameField { get; set; }

	public string passwordField { get; set; }

	public string encryptedUsername { get; set; }

	public string encryptedPassword { get; set; }
}
