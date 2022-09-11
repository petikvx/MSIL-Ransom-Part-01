using System;

namespace hargardius;

public class MLRLEINF
{
	public string hargardiusapver;

	public string hargardiusuip = "";

	public string hargardiusclientNum = "";

	public string hargardiuslancard = "";

	public string hargardiusuname = "";

	public string hargardiuscname = "";

	public MLRLEINF()
	{
		hargardiusInfo();
	}

	private void hargardiusInfo()
	{
		hargardiusapver = "M.D.0.2|hargardius".Split(new char[1] { '|' })[0];
		hargardiuscname = Environment.MachineName;
		hargardiusuname = Environment.UserName;
		hargardiusuip = "";
		hargardiuslancard = "";
	}
}
