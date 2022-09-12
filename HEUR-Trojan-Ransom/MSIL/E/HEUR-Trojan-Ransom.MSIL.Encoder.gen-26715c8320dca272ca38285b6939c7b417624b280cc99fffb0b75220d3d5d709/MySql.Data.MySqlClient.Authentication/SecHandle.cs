using System;

namespace MySql.Data.MySqlClient.Authentication;

public struct SecHandle
{
	private IntPtr dwLower;

	private IntPtr dwUpper;
}
