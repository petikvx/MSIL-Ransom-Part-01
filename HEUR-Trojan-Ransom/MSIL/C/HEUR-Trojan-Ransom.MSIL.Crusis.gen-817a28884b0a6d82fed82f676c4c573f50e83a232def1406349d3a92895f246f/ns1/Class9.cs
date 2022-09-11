using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns1;

internal sealed class Class9
{
	public unsafe static string smethod_0(string string_0)
	{
		void* ptr = stackalloc byte[12];
		string password = "fdfdfrtertert";
		string s = "fdfdfrtertert";
		*(int*)ptr = 2;
		string s2 = "@1B2c3D4sfg5F6g7H8";
		*(int*)((byte*)ptr + 4) = 256;
		byte[] bytes = Encoding.ASCII.GetBytes(s2);
		byte[] bytes2 = Encoding.ASCII.GetBytes(s);
		byte[] array = Convert.FromBase64String(string_0);
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, *(int*)ptr);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] bytes3 = rfc2898DeriveBytes.GetBytes(*(int*)((byte*)ptr + 4) / 8);
		MemoryStream memoryStream = new MemoryStream(array);
		ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		rijndaelManaged.Mode = CipherMode.CBC;
		byte[] array2 = new byte[checked(array.Length - 1 + 1)];
		*(int*)((byte*)ptr + 8) = cryptoStream.Read(array2, 0, array2.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array2, 0, *(int*)((byte*)ptr + 8));
	}
}
