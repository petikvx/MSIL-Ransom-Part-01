using System;

namespace awdrgori;

public class awdrgoriMYINF
{
	public string awdrgoriuip = "";

	public string awdrgoriclientNum = "";

	public string awdrgoriuname = "";

	public string awdrgoriapver;

	public string awdrgoricname = "";

	public string awdrgorilancard = "";

	public awdrgoriMYINF()
	{
		awdrgoriInfo();
	}

	private void awdrgoriInfo()
	{
		awdrgoriapver = "A.P.0.1|awdrgori".Split(new char[1] { '|' })[0];
		awdrgoricname = Environment.MachineName;
		awdrgoriuname = Environment.UserName;
		awdrgoriuip = "";
		awdrgorilancard = "";
	}
}
