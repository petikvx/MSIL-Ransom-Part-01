using System;
using System.Text;

namespace Renci.SshNet;

internal class RemotePathShellQuoteTransformation : IRemotePathTransformation
{
	private enum ShellQuoteState
	{
		Unquoted = 1,
		SingleQuoted,
		Quoted
	}

	public string Transform(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		StringBuilder stringBuilder = new StringBuilder(path.Length + 2);
		ShellQuoteState shellQuoteState = ShellQuoteState.Unquoted;
		foreach (char c in path)
		{
			switch (c)
			{
			case '\'':
				switch (shellQuoteState)
				{
				case ShellQuoteState.Unquoted:
					stringBuilder.Append('"');
					break;
				case ShellQuoteState.SingleQuoted:
					stringBuilder.Append('\'');
					stringBuilder.Append('"');
					break;
				}
				shellQuoteState = ShellQuoteState.Quoted;
				break;
			default:
				switch (shellQuoteState)
				{
				case ShellQuoteState.Unquoted:
					stringBuilder.Append('\'');
					break;
				case ShellQuoteState.Quoted:
					stringBuilder.Append('"');
					stringBuilder.Append('\'');
					break;
				}
				shellQuoteState = ShellQuoteState.SingleQuoted;
				break;
			case '!':
				switch (shellQuoteState)
				{
				case ShellQuoteState.Unquoted:
					stringBuilder.Append('\\');
					break;
				case ShellQuoteState.SingleQuoted:
					stringBuilder.Append('\'');
					stringBuilder.Append('\\');
					break;
				case ShellQuoteState.Quoted:
					stringBuilder.Append('"');
					stringBuilder.Append('\\');
					break;
				}
				shellQuoteState = ShellQuoteState.Unquoted;
				break;
			}
			stringBuilder.Append(c);
		}
		switch (shellQuoteState)
		{
		case ShellQuoteState.SingleQuoted:
			stringBuilder.Append('\'');
			break;
		case ShellQuoteState.Quoted:
			stringBuilder.Append('"');
			break;
		}
		if (stringBuilder.Length == 0)
		{
			stringBuilder.Append("''");
		}
		return stringBuilder.ToString();
	}
}
