using System;

namespace rgocrwse;

public class ortmirdsMYINF
{
	public string ortmirdsuip = "";

	public string ortmirdsclientNum = "";

	public string ortmirdsuname = "";

	public string ortmirdsapver;

	public string ortmirdscname = "";

	public string ortmirdslancard = "";

	private void ortmirdsInfo()
	{
		ortmirdsapver = "S.P.0.3|ortmirds".Split(new char[1] { '|' })[0];
		ortmirdscname = Environment.MachineName;
		ortmirdsuname = Environment.UserName;
		ortmirdsuip = "";
		ortmirdslancard = "";
	}

	public ortmirdsMYINF()
	{
		ortmirdsInfo();
	}
}
