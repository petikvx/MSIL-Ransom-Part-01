using System;
using System.Security.Cryptography;
using System.Text;

namespace MySql.Data.MySqlClient.Authentication;

internal class CachingSha2AuthenticationPlugin : Sha256AuthenticationPlugin
{
	internal static AuthStage _authStage;

	public override string PluginName => "caching_sha2_password";

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
		rawPubkey = data;
		if (data == null)
		{
			byte[] array = GetPassword() as byte[];
			byte[] array2 = new byte[array.Length - 1];
			Array.Copy(array, 1, array2, 0, array.Length - 1);
			return array2;
		}
		if (data[0] == 3)
		{
			_authStage = AuthStage.FAST_AUTH;
			return null;
		}
		return GeneratePassword();
	}

	protected byte[] GeneratePassword()
	{
		if (base.Settings.SslMode != 0)
		{
			_authStage = AuthStage.FULL_AUTH;
			byte[] bytes = base.Encoding.GetBytes(base.Settings.Password);
			byte[] array = new byte[bytes.Length + 1];
			Array.Copy(bytes, 0, array, 0, bytes.Length);
			array[bytes.Length] = 0;
			return array;
		}
		if (rawPubkey != null && rawPubkey[0] == 4)
		{
			_authStage = AuthStage.REQUEST_RSA_KEY;
			return new byte[1] { 2 };
		}
		if (!base.Settings.AllowPublicKeyRetrieval)
		{
			throw new MySqlException(Resources.RSAPublicKeyRetrievalNotEnabled);
		}
		_authStage = AuthStage.FULL_AUTH;
		byte[] rsaPassword = GetRsaPassword(base.Settings.Password, AuthenticationData, rawPubkey);
		if (rsaPassword != null && rsaPassword.Length == 1 && rsaPassword[0] == 0)
		{
			return null;
		}
		return rsaPassword;
	}

	private byte[] GetRsaPassword(string password, byte[] seedBytes, byte[] rawPublicKey)
	{
		if (password.Length == 0)
		{
			return new byte[1];
		}
		if (rawPubkey == null)
		{
			return null;
		}
		byte[] xor = GetXor(Encoding.Default.GetBytes(password), seedBytes);
		if (base.ServerVersion >= new Version("8.0.5"))
		{
			return (MySqlPemReader.ConvertPemToRSAProvider(rawPublicKey) ?? throw new MySqlException(Resources.UnableToReadRSAKey)).Encrypt(xor, fOAEP: true);
		}
		return (MySqlPemReader.ConvertPemToRSAProvider(rawPublicKey) ?? throw new MySqlException(Resources.UnableToReadRSAKey)).Encrypt(xor, fOAEP: false);
	}

	public override object GetPassword()
	{
		_authStage = AuthStage.GENERATE_SCRAMBLE;
		if (base.Settings.Password.Length == 0)
		{
			return new byte[1];
		}
		SHA256 sHA = SHA256.Create();
		byte[] array = sHA.ComputeHash(Encoding.Default.GetBytes(base.Settings.Password));
		byte[] array2 = sHA.ComputeHash(array);
		byte[] array3 = new byte[AuthenticationData.Length + array2.Length];
		Array.Copy(array2, 0, array3, 0, array2.Length);
		Array.Copy(AuthenticationData, 0, array3, array2.Length, AuthenticationData.Length);
		byte[] array4 = sHA.ComputeHash(array3);
		byte[] array5 = new byte[array4.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array5[i] = (byte)(array[i] ^ array4[i]);
		}
		byte[] array6 = new byte[array5.Length + 1];
		Array.Copy(array5, 0, array6, 1, array5.Length);
		array6[0] = 32;
		return array6;
	}
}
