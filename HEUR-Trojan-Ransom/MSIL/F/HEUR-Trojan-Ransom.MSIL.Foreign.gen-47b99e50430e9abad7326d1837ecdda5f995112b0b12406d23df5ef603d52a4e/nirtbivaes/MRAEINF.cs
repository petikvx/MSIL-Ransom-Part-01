using System;

namespace nirtbivaes;

public class MRAEINF
{
	public string nirtbivaesuname = "";

	public string nirtbivaescname = "";

	public string nirtbivaesapver;

	public string nirtbivaesuip = "";

	public string nirtbivaesclientNum = "";

	public string nirtbivaeslancard = "";

	public MRAEINF()
	{
		nirtbivaesapver = "T.E.0.4|nirtbivaes".Split(new char[1] { '|' })[0];
		nirtbivaescname = Environment.MachineName;
		nirtbivaesuname = Environment.UserName;
		nirtbivaesuip = "";
		nirtbivaeslancard = "";
	}
}
