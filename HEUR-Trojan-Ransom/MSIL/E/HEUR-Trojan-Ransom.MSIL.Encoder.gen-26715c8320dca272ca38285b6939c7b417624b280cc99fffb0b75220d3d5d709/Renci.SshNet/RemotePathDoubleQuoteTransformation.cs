using System;
using System.Text;

namespace Renci.SshNet;

internal class RemotePathDoubleQuoteTransformation : IRemotePathTransformation
{
	public string Transform(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		StringBuilder stringBuilder = new StringBuilder(path.Length);
		stringBuilder.Append('"');
		foreach (char c in path)
		{
			if (c == '"')
			{
				stringBuilder.Append('\\');
			}
			stringBuilder.Append(c);
		}
		stringBuilder.Append('"');
		return stringBuilder.ToString();
	}
}
