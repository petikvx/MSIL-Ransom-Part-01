using System;

namespace roigtbraorn;

public class MYAIINF
{
	public string roigtbraornuname = "";

	public string roigtbraornapver;

	public string roigtbraorncname = "";

	public string roigtbraornuip = "";

	public string roigtbraornclientNum = "";

	public string roigtbraornlancard = "";

	public MYAIINF()
	{
		roigtbraornapver = "S.D.0.5|roigtbraorn".Split(new char[1] { '|' })[0];
		roigtbraorncname = Environment.MachineName;
		roigtbraornuname = Environment.UserName;
		roigtbraornuip = "";
		roigtbraornlancard = "";
	}
}
