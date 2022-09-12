using System;
using System.Text;

namespace MySql.Data.MySqlClient.Authentication;

public abstract class MySqlAuthenticationPlugin
{
	private NativeDriver _driver;

	protected byte[] AuthenticationData;

	protected MySqlConnectionStringBuilder Settings => _driver.Settings;

	protected Version ServerVersion => new Version(_driver.Version.Major, _driver.Version.Minor, _driver.Version.Build);

	internal ClientFlags Flags => _driver.Flags;

	protected Encoding Encoding => _driver.Encoding;

	public abstract string PluginName { get; }

	internal static MySqlAuthenticationPlugin GetPlugin(string method, NativeDriver driver, byte[] authData)
	{
		if (method == "mysql_old_password")
		{
			driver.Close(isOpen: true);
			throw new MySqlException(Resources.OldPasswordsNotSupported);
		}
		MySqlAuthenticationPlugin obj = AuthenticationPluginManager.GetPlugin(method) ?? throw new MySqlException(string.Format(Resources.UnknownAuthenticationMethod, method));
		obj._driver = driver;
		obj.SetAuthData(authData);
		return obj;
	}

	protected virtual void SetAuthData(byte[] data)
	{
		AuthenticationData = data;
	}

	protected virtual void CheckConstraints()
	{
	}

	protected virtual void AuthenticationFailed(Exception ex)
	{
		throw new MySqlException(string.Format(Resources.AuthenticationFailed, Settings.Server, GetUsername(), PluginName, ex.Message), ex);
	}

	protected virtual void AuthenticationSuccessful()
	{
	}

	protected virtual byte[] MoreData(byte[] data)
	{
		return null;
	}

	internal void Authenticate(bool reset)
	{
		CheckConstraints();
		MySqlPacket packet = _driver.Packet;
		packet.WriteString(GetUsername());
		WritePassword(packet);
		if (((Flags & ClientFlags.CONNECT_WITH_DB) > (ClientFlags)0uL || reset) && !string.IsNullOrEmpty(Settings.Database))
		{
			packet.WriteString(Settings.Database);
		}
		if (reset)
		{
			packet.WriteInteger(8L, 2);
		}
		if ((Flags & ClientFlags.PLUGIN_AUTH) != (ClientFlags)0uL)
		{
			packet.WriteString(PluginName);
		}
		_driver.SetConnectAttrs();
		_driver.SendPacket(packet);
		packet = ReadPacket();
		byte[] buffer = packet.Buffer;
		if (PluginName == "caching_sha2_password" && buffer[0] == 1)
		{
			ContinueAuthentication(new byte[1] { buffer[1] });
		}
		if (buffer[0] == 254)
		{
			if (packet.IsLastPacket)
			{
				_driver.Close(isOpen: true);
				throw new MySqlException(Resources.OldPasswordsNotSupported);
			}
			HandleAuthChange(packet);
		}
		_driver.ReadOk(read: false);
		AuthenticationSuccessful();
	}

	private void WritePassword(MySqlPacket packet)
	{
		bool flag = (Flags & ClientFlags.SECURE_CONNECTION) > (ClientFlags)0uL;
		object password = GetPassword();
		if (password is string)
		{
			if (flag)
			{
				packet.WriteLenString((string)password);
			}
			else
			{
				packet.WriteString((string)password);
			}
			return;
		}
		if (password == null)
		{
			packet.WriteByte(0);
			return;
		}
		if (!(password is byte[]))
		{
			throw new MySqlException("Unexpected password format: " + password.GetType());
		}
		packet.Write(password as byte[]);
	}

	private MySqlPacket ReadPacket()
	{
		try
		{
			return _driver.ReadPacket();
		}
		catch (MySqlException ex)
		{
			AuthenticationFailed(ex);
			return null;
		}
	}

	private void HandleAuthChange(MySqlPacket packet)
	{
		packet.ReadByte();
		string method = packet.ReadString();
		byte[] array = new byte[packet.Length - packet.Position];
		Array.Copy(packet.Buffer, packet.Position, array, 0, array.Length);
		GetPlugin(method, _driver, array).ContinueAuthentication();
	}

	private void ContinueAuthentication(byte[] data = null)
	{
		MySqlPacket mySqlPacket = _driver.Packet;
		mySqlPacket.Clear();
		byte[] array = MoreData(data);
		while (array != null)
		{
			mySqlPacket.Clear();
			mySqlPacket.Write(array);
			_driver.SendPacket(mySqlPacket);
			mySqlPacket = ReadPacket();
			if (mySqlPacket.Buffer[0] != 1)
			{
				return;
			}
			byte[] array2 = new byte[mySqlPacket.Length - 1];
			Array.Copy(mySqlPacket.Buffer, 1, array2, 0, array2.Length);
			array = MoreData(array2);
		}
		ReadPacket();
	}

	public virtual string GetUsername()
	{
		return Settings.UserID;
	}

	public virtual object GetPassword()
	{
		return null;
	}
}
