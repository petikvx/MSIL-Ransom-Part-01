using System;

namespace irvrmjavhica;

public class MORLEINF
{
	public string irvrmjavhicauDtme = "";

	public string irvrmjavhicarpvier;

	public string irvrmjavhicactDme = "";

	public string irvrmjavhicauthip = "";

	public string irvrmjavhicaclieThum = "";

	public string irvrmjavhicalaCird = "";

	public MORLEINF()
	{
		irvrmjavhicarpvier = "S.P.1.3|irvrmjavhica".Split(new char[1] { '|' })[0];
		irvrmjavhicactDme = Environment.MachineName;
		irvrmjavhicauDtme = Environment.UserName;
		irvrmjavhicauthip = "";
		irvrmjavhicalaCird = "";
	}
}
