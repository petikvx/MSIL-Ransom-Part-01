namespace Renci.SshNet.Compression;

internal class Zlib : Compressor
{
	public override string Name => "zlib";

	public override void Init(Session session)
	{
		base.Init(session);
		base.IsActive = true;
	}
}
