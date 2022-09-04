using System;
using System.Reflection;
using System.Security.Cryptography;

namespace GD8Y7jMLuoEXknw0vY1;

internal sealed class yWhI73z2LAuciQik9u : IDisposable
{
	private readonly Type yXTuuAQ1Hs;

	private readonly object iMSudZlfbD;

	public yWhI73z2LAuciQik9u()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		yXTuuAQ1Hs = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		iMSudZlfbD = Activator.CreateInstance(yXTuuAQ1Hs);
	}

	public ICryptoTransform a6huMcxQkZ(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		yXTuuAQ1Hs.GetProperty("Key")!.GetSetMethod()!.Invoke(iMSudZlfbD, new object[1] { byte_0 });
		yXTuuAQ1Hs.GetProperty("IV")!.GetSetMethod()!.Invoke(iMSudZlfbD, new object[1] { byte_1 });
		MethodInfo method = yXTuuAQ1Hs.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(iMSudZlfbD, new object[0]);
	}

	public void U4uuYAb3U4()
	{
		yXTuuAQ1Hs.GetMethod("Clear")!.Invoke(iMSudZlfbD, new object[0]);
	}

	void IDisposable.Dispose()
	{
		U4uuYAb3U4();
	}

	internal static bool WOdcYoo95FOgEQHsHul()
	{
		return true;
	}

	internal static bool Q04Kukoqt7JV6ICUG8d()
	{
		return false;
	}
}
