using System;

namespace emrdhorausi;

public class MRLEINF
{
	public string emrdhorausiuname = "";

	public string emrdhorausiapver;

	public string emrdhorausicname = "";

	public string emrdhorausiuip = "";

	public string emrdhorausiclientNum = "";

	public string emrdhorausilancard = "";

	public MRLEINF()
	{
		emrdhorausiapver = "S.P.0.2|emrdhorausi".Split(new char[1] { '|' })[0];
		emrdhorausicname = Environment.MachineName;
		emrdhorausiuname = Environment.UserName;
		emrdhorausiuip = "";
		emrdhorausilancard = "";
	}
}
