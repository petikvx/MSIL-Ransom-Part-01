using System.IO;

namespace Sony.Vegas.NetRender;

public class Share
{
	private string _server;

	private string _netName;

	private string _path;

	private ShareType _shareType;

	private string _remark;

	public extern string Server { get; }

	public extern string NetName { get; }

	public extern string Path { get; }

	public ShareType ShareType
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_000e, IL_001b, IL_0024, IL_002a
			//IL_0009: Expected F8, but got I4
			//IL_0013: Expected native int or pointer, but got F8
			/*Error near IL_0001: Unknown opcode: 0xFF*/;
		}
	}

	public extern string Remark { get; }

	public extern bool IsFileSystem { get; }

	public extern DirectoryInfo Root { get; }

	public extern Share(string server, string netName, string path, ShareType shareType, string remark);

	public override extern string ToString();

	public extern bool MatchesPath(string path);
}
