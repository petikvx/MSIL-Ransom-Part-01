namespace Renci.SshNet;

public interface IRemotePathTransformation
{
	string Transform(string path);
}
