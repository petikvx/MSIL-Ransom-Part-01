using System;

namespace thnaviwa;

public class URYINF
{
	public string thnaviwaapver;

	public string thnaviwauip = "";

	public string thnaviwaclientNum = "";

	public string thnaviwauname = "";

	public string thnaviwacname = "";

	public string thnaviwalancard = "";

	public URYINF()
	{
		thnaviwaInfo();
	}

	private void thnaviwaInfo()
	{
		thnaviwaapver = "1.0.2.0|thnaviwa".Split(new char[1] { '|' })[0];
		thnaviwacname = Environment.MachineName;
		thnaviwauname = Environment.UserName;
		thnaviwauip = "";
		thnaviwalancard = "";
	}
}
