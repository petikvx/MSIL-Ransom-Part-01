using System;
using System.Security.Cryptography;
using System.Text;

namespace MySql.Data.MySqlClient.Authentication;

internal class Sha256MemoryAuthenticationPlugin : MySqlAuthenticationPlugin
{
	public override string PluginName => "SHA256_MEMORY";

	public byte[] GetClientHash(string data, byte[] nonce)
	{
		if (string.IsNullOrEmpty(data))
		{
			return new byte[0];
		}
		SHA256 sHA = SHA256.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		byte[] array = sHA.ComputeHash(bytes);
		byte[] array2 = sHA.ComputeHash(array);
		byte[] array3 = new byte[array2.Length + nonce.Length];
		array2.CopyTo(array3, 0);
		nonce.CopyTo(array3, array2.Length);
		array3 = sHA.ComputeHash(array3);
		byte[] xOr = GetXOr(array3, array);
		return Encoding.UTF8.GetBytes(BitConverter.ToString(xOr).Replace("-", ""));
	}

	protected byte[] GetXOr(byte[] left, byte[] right)
	{
		if (left.Length != right.Length)
		{
			throw new ArrayTypeMismatchException();
		}
		byte[] array = new byte[left.Length];
		for (int i = 0; i < left.Length; i++)
		{
			array[i] = (byte)(left[i] ^ right[i]);
		}
		return array;
	}
}
