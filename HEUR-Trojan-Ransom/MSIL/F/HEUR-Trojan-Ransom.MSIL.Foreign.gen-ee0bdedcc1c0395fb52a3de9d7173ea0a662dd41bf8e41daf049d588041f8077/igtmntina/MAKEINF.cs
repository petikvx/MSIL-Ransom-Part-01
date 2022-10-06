using System;

namespace igtmntina;

public class MAKEINF
{
	public string igtmntinalancard = "";

	public string igtmntinauname = "";

	public string igtmntinaapver;

	public string igtmntinacname = "";

	public MAKEINF()
	{
		igtmntinaapver = "S.0.0.2|igtmntina".Split(new char[1] { '|' })[0].ToString();
		igtmntinacname = Environment.MachineName.ToString();
		igtmntinauname = Environment.UserName.ToString();
	}
}
