using System;
using System.Collections.Generic;
using System.Text;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_INFO_REQUEST", 60)]
internal class InformationRequestMessage : Message
{
	public string Name { get; private set; }

	public string Instruction { get; private set; }

	public string Language { get; private set; }

	public IEnumerable<AuthenticationPrompt> Prompts { get; private set; }

	protected override void LoadData()
	{
		Name = ReadString(Encoding.UTF8);
		Instruction = ReadString(Encoding.UTF8);
		Language = ReadString(SshData.Ascii);
		uint num = ReadUInt32();
		List<AuthenticationPrompt> list = new List<AuthenticationPrompt>();
		for (int i = 0; i < num; i++)
		{
			string request = ReadString(Encoding.UTF8);
			bool isEchoed = ReadBoolean();
			list.Add(new AuthenticationPrompt(i, isEchoed, request));
		}
		Prompts = list;
	}

	protected override void SaveData()
	{
		throw new NotImplementedException();
	}

	internal override void Process(Session session)
	{
		session.OnUserAuthenticationInformationRequestReceived(this);
	}
}
