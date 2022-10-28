using System;

namespace uiltghnsra;

public class MYUINF
{
	public string uiltghnsrarpver;

	public string uiltghnsracname = "";

	public string uiltghnsralanrard = "";

	public string uiltghnsrauip = "";

	public string uiltghnsraclientNum = "";

	public string uiltghnsrauname = "";

	public MYUINF()
	{
		uiltghnsrauname = Environment.UserName;
		uiltghnsrarpver = "S.P.0.1|uiltghnsra".Split(new char[1] { '|' })[0];
		uiltghnsracname = Environment.MachineName;
		uiltghnsrauip = "";
		uiltghnsralanrard = "";
	}
}
