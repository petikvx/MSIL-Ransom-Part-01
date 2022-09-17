using System.Collections.Generic;

namespace Server.Helper;

public class AsyncTask
{
	public byte[] msgPack;

	public string id;

	public bool admin;

	public List<string> doneClient;

	public AsyncTask(byte[] _msgPack, string _id, bool _admin)
	{
		msgPack = _msgPack;
		id = _id;
		admin = _admin;
		doneClient = new List<string>();
	}
}
