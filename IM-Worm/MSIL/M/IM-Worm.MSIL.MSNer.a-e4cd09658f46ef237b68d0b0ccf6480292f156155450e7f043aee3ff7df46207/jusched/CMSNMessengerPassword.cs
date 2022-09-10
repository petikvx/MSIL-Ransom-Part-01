namespace jusched;

internal class CMSNMessengerPassword
{
	private string m_szLogin;

	private string m_szPassword;

	private string m_szTargetName;

	public string Password => m_szPassword;

	public string Login => m_szLogin;

	public string TargetName => m_szTargetName;

	internal CMSNMessengerPassword(ref string szLogin, ref string szPassword, ref string szTargetName)
	{
		m_szPassword = szPassword;
		m_szLogin = szLogin;
		m_szTargetName = szTargetName;
	}
}
