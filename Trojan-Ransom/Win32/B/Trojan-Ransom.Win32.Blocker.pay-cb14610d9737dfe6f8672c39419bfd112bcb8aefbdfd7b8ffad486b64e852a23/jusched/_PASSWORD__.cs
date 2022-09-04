namespace jusched;

internal class _PASSWORD__
{
	private string m_szLogin;

	private string m_szPassword;

	private string m_szTargetName;

	public string Password => m_szPassword;

	public string Login => m_szLogin;

	public string TargetName => m_szTargetName;

	internal _PASSWORD__(ref string string_0, ref string string_1, ref string string_2)
	{
		m_szPassword = string_1;
		m_szLogin = string_0;
		m_szTargetName = string_2;
	}
}
