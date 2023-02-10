using System;

namespace hdrmiprcav;

public class MORLEINF
{
	public string acc_date_time = "";

	public string rm_version;

	public string com_name = "";

	public string account_name = "";

	public string account_opt = "";

	public string lan_info = "";

	public MORLEINF()
	{
		rm_version = "S.D.0.2|".Split(new char[1] { '|' })[0];
		com_name = Environment.MachineName;
		acc_date_time = Environment.UserName;
		account_name = "";
		lan_info = "";
	}
}
