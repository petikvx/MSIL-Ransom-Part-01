using System;

internal class UsageException : ApplicationException
{
	private int _returnCode;

	public int ReturnCode => _returnCode;

	private static string Usage()
	{
		return Resource.FormatString("RegSvcs_Usage");
	}

	public UsageException(int code)
		: base(Usage())
	{
	}

	public UsageException(int code, string msg)
		: base(msg + "\n" + Usage())
	{
		_returnCode = code;
	}
}
