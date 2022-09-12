using System;

namespace ntharprmes;

public class MRAEINF
{
	public string ntharprmeslancard = "";

	public string ntharprmesuname = "";

	public string ntharprmescname = "";

	public string ntharprmesapver;

	public string ntharprmesuip = "";

	public string ntharprmesclientNum = "";

	public MRAEINF()
	{
		ntharprmesapver = "S.D.0.5|ntharprmes".Split(new char[1] { '|' })[0];
		ntharprmescname = Environment.MachineName;
		ntharprmesuname = Environment.UserName;
		ntharprmesuip = "";
		ntharprmeslancard = "";
	}
}
