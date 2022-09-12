using System;
using System.Text;

namespace MySql.Data.MySqlClient.Authentication;

internal class Sha256AuthenticationPlugin : MySqlAuthenticationPlugin
{
	protected byte[] rawPubkey;

	public override string PluginName => "sha256_password";

	protected override byte[] MoreData(byte[] data)
	{
		rawPubkey = data;
		return GetNonLengthEncodedPassword();
	}

	public override object GetPassword()
	{
		if (base.Settings.SslMode != 0)
		{
			byte[] bytes = base.Encoding.GetBytes(base.Settings.Password);
			byte[] array = new byte[bytes.Length + 2];
			Array.Copy(bytes, 0, array, 1, bytes.Length);
			array[0] = (byte)(bytes.Length + 1);
			array[^1] = 0;
			return array;
		}
		if (base.Settings.Password.Length == 0)
		{
			return new byte[1];
		}
		if (rawPubkey == null)
		{
			return new byte[1] { 1 };
		}
		if (!base.Settings.AllowPublicKeyRetrieval)
		{
			throw new MySqlException(Resources.RSAPublicKeyRetrievalNotEnabled);
		}
		byte[] rsaPassword = GetRsaPassword(base.Settings.Password, AuthenticationData, rawPubkey);
		if (rsaPassword != null && rsaPassword.Length == 1 && rsaPassword[0] == 0)
		{
			return null;
		}
		return rsaPassword;
	}

	private byte[] GetNonLengthEncodedPassword()
	{
		if (base.Settings.SslMode != 0)
		{
			byte[] bytes = base.Encoding.GetBytes(base.Settings.Password);
			byte[] array = new byte[bytes.Length + 1];
			Array.Copy(bytes, 0, array, 0, bytes.Length);
			array[bytes.Length] = 0;
			return array;
		}
		return GetPassword() as byte[];
	}

	private byte[] GetRsaPassword(string password, byte[] seedBytes, byte[] rawPublicKey)
	{
		if (password.Length == 0)
		{
			return new byte[1];
		}
		byte[] xor = GetXor(Encoding.Default.GetBytes(password), seedBytes);
		return (MySqlPemReader.ConvertPemToRSAProvider(rawPublicKey) ?? throw new MySqlException(Resources.UnableToReadRSAKey)).Encrypt(xor, fOAEP: true);
	}

	protected byte[] GetXor(byte[] src, byte[] pattern)
	{
		byte[] array = new byte[src.Length + 1];
		Array.Copy(src, 0, array, 0, src.Length);
		array[src.Length] = 0;
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)(array[i] ^ pattern[i % pattern.Length]);
		}
		return array2;
	}
}
