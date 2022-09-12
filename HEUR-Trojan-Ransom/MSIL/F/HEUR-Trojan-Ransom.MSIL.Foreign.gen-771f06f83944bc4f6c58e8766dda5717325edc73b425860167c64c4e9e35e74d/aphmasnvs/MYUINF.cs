using System;

namespace aphmasnvs;

public class MYUINF
{
	public string aphmasnvsapver;

	public string aphmasnvscname = "";

	public string aphmasnvslancard = "";

	public string aphmasnvsuip = "";

	public string aphmasnvsclientNum = "";

	public string aphmasnvsuname = "";

	public MYUINF()
	{
		aphmasnvsuname = Environment.UserName;
		aphmasnvsapver = "S.P.0.9|aphmasnvs".Split(new char[1] { '|' })[0];
		aphmasnvscname = Environment.MachineName;
		aphmasnvsuip = "";
		aphmasnvslancard = "";
	}
}
