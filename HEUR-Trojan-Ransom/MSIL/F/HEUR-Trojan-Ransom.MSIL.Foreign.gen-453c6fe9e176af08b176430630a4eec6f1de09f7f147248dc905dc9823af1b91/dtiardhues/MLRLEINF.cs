using System;

namespace dtiardhues;

public class MLRLEINF
{
	public string dtiardhuesapver;

	public string dtiardhuesuip = "";

	public string dtiardhuesclientNum = "";

	public string dtiardhueslancard = "";

	public string dtiardhuesuname = "";

	public string dtiardhuescname = "";

	public MLRLEINF()
	{
		dtiardhuesInfo();
	}

	private void dtiardhuesInfo()
	{
		dtiardhuesapver = "M.D.0.0|dtiardhues".Split(new char[1] { '|' })[0];
		dtiardhuescname = Environment.MachineName;
		dtiardhuesuname = Environment.UserName;
		dtiardhuesuip = "";
		dtiardhueslancard = "";
	}
}
