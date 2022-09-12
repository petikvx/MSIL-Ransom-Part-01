using System;

namespace Renci.SshNet;

internal class RemotePathNoneTransformation : IRemotePathTransformation
{
	public string Transform(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return path;
	}
}
