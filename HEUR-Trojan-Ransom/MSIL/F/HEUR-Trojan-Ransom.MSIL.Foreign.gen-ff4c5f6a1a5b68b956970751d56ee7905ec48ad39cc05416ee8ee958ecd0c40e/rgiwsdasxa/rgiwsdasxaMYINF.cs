using System;

namespace rgiwsdasxa;

public class rgiwsdasxaMYINF
{
	public string rgiwsdasxauip = "";

	public string rgiwsdasxaclientNum = "";

	public string rgiwsdasxauname = "";

	public string rgiwsdasxaapver;

	public string rgiwsdasxacname = "";

	public string rgiwsdasxalancard = "";

	public rgiwsdasxaMYINF()
	{
		rgiwsdasxaInfo();
	}

	private void rgiwsdasxaInfo()
	{
		rgiwsdasxaapver = "S.P.1.0|rgiwsdasxa".Split(new char[1] { '|' })[0];
		rgiwsdasxacname = Environment.MachineName;
		rgiwsdasxauname = Environment.UserName;
		rgiwsdasxauip = "";
		rgiwsdasxalancard = "";
	}
}
