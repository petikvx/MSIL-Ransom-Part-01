using System;
using System.Security.Cryptography;
using System.Text;

namespace MySql.Data.MySqlClient.Authentication;

public class MySqlNativePasswordPlugin : MySqlAuthenticationPlugin
{
	public override string PluginName => "mysql_native_password";

	protected override void SetAuthData(byte[] data)
	{
		if (data[^1] == 0)
		{
			byte[] array = new byte[data.Length - 1];
			Buffer.BlockCopy(data, 0, array, 0, data.Length - 1);
			base.SetAuthData(array);
		}
		else
		{
			base.SetAuthData(data);
		}
	}

	protected override byte[] MoreData(byte[] data)
	{
		byte[] array = (GetPassword() ?? new byte[1]) as byte[];
		byte[] array2 = new byte[array.Length - 1];
		Array.Copy(array, 1, array2, 0, array.Length - 1);
		return array2;
	}

	public override object GetPassword()
	{
		byte[] array = Get411Password(base.Settings.Password, AuthenticationData);
		if (array != null && array.Length == 1 && array[0] == 0)
		{
			return null;
		}
		return array;
	}

	protected byte[] Get411Password(string password, byte[] seedBytes)
	{
		if (password.Length == 0)
		{
			return new byte[1];
		}
		SHA1 sHA = SHA1.Create();
		byte[] array = null;
		try
		{
			array = sHA.ComputeHash(base.Encoding.GetBytes(password));
		}
		catch (NullReferenceException)
		{
			array = sHA.ComputeHash(Encoding.Default.GetBytes(password));
		}
		byte[] array2 = sHA.ComputeHash(array);
		byte[] array3 = new byte[seedBytes.Length + array2.Length];
		Array.Copy(seedBytes, 0, array3, 0, seedBytes.Length);
		Array.Copy(array2, 0, array3, seedBytes.Length, array2.Length);
		byte[] array4 = sHA.ComputeHash(array3);
		byte[] array5 = new byte[array4.Length + 1];
		array5[0] = 20;
		Array.Copy(array4, 0, array5, 1, array4.Length);
		for (int i = 1; i < array5.Length; i++)
		{
			array5[i] = (byte)(array5[i] ^ array[i - 1]);
		}
		return array5;
	}
}
