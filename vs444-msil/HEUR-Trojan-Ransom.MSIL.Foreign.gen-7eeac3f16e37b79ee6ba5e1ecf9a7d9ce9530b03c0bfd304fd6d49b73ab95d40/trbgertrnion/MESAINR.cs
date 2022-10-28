using System;

namespace trbgertrnion;

public class MESAINR
{
	public string trbgertrnionuname = "";

	public string trbgertrnionapver;

	public string trbgertrnioncname = "";

	public string trbgertrnionuip = "";

	public string trbgertrnionclientNum = "";

	public string trbgertrnionlancard = "";

	public MESAINR()
	{
		trbgertrnionapver = "S.D.0.1|trbgertrnion".Split(new char[1] { '|' })[0];
		trbgertrnioncname = Environment.MachineName;
		trbgertrnionuname = Environment.UserName;
		trbgertrnionuip = "";
		trbgertrnionlancard = "";
	}
}
