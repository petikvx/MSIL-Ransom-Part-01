using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 178)]
	private struct Struct18
	{
	}

	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	private bool bool_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[89];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal bool bool_1;

	internal bool bool_2 = true;

	public SecurityException SecurityException => securityException_0;

	public string SecurityMessage => string_0;

	public bool CanContinue => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool ReportException
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool flag = (bool_1 = value);
		}
	}

	public SecurityExceptionEventArgs(SecurityException securityException)
	{
		securityException_0 = securityException;
	}

	public SecurityExceptionEventArgs(SecurityException securityException, bool canContinue)
		: this(securityException)
	{
		bool flag = (bool_2 = canContinue);
	}

	public SecurityExceptionEventArgs(string securityMessage, bool canContinue)
		: this(new SecurityException(securityMessage), canContinue)
	{
		string_0 = securityMessage;
	}

	static SecurityExceptionEventArgs()
	{
		byte[] publicKeyToken;
		int num = (publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken()).Length;
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = i;
			int num3 = publicKeyToken[i] & 0xFF;
			array[num2] = (char)(num3 ^ (num3 << 7));
		}
		object_0 = array;
		object_1 = new string[2];
	}
}
