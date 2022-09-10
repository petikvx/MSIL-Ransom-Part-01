using System;

namespace rlbwrarhsa;

public class MLRLEINF
{
	public string rlbwrarhsaapver;

	public string rlbwrarhsauip = "";

	public string rlbwrarhsaclientNum = "";

	public string rlbwrarhsalancard = "";

	public string rlbwrarhsauname = "";

	public string rlbwrarhsacname = "";

	public MLRLEINF()
	{
		rlbwrarhsaInfo();
	}

	private void rlbwrarhsaInfo()
	{
		rlbwrarhsaapver = "M.0.0.3|rlbwrarhsa".Split(new char[1] { '|' })[0];
		rlbwrarhsacname = Environment.MachineName;
		rlbwrarhsauname = Environment.UserName;
		rlbwrarhsauip = "";
		rlbwrarhsalancard = "";
	}
}
