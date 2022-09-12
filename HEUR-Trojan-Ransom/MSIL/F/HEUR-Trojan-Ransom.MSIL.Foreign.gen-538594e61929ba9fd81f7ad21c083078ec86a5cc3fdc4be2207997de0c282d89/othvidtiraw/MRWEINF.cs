using System;

namespace othvidtiraw;

public class MRWEINF
{
	public string othvidtirawlancard = "";

	public string othvidtirawuname = "";

	public string othvidtirawcname = "";

	public string othvidtirawapver;

	public string othvidtirawuip = "";

	public string othvidtirawclientNum = "";

	public MRWEINF()
	{
		othvidtirawapver = "S.D.2.7|othvidtiraw".Split(new char[1] { '|' })[0];
		othvidtirawcname = Environment.MachineName;
		othvidtirawuname = Environment.UserName;
		othvidtirawuip = "";
		othvidtirawlancard = "";
	}
}
