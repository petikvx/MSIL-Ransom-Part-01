using System.Collections.Generic;

namespace Renci.SshNet.Common;

public class AuthenticationPromptEventArgs : AuthenticationEventArgs
{
	public string Language { get; private set; }

	public string Instruction { get; private set; }

	public IEnumerable<AuthenticationPrompt> Prompts { get; private set; }

	public AuthenticationPromptEventArgs(string username, string instruction, string language, IEnumerable<AuthenticationPrompt> prompts)
		: base(username)
	{
		Instruction = instruction;
		Language = language;
		Prompts = prompts;
	}
}
