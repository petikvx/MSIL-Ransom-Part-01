using System;

namespace fhlergarw;

public class fhlergarwMYINF
{
	public string fhlergarwuip = "";

	public string fhlergarwclientNum = "";

	public string fhlergarwuname = "";

	public string fhlergarwapver;

	public string fhlergarwcname = "";

	public string fhlergarwlancard = "";

	public fhlergarwMYINF()
	{
		fhlergarwInfo();
	}

	private void fhlergarwInfo()
	{
		fhlergarwapver = "S.P.0.5|fhlergarw".Split(new char[1] { '|' })[0];
		fhlergarwcname = Environment.MachineName;
		fhlergarwuname = Environment.UserName;
		fhlergarwuip = "";
		fhlergarwlancard = "";
	}
}
