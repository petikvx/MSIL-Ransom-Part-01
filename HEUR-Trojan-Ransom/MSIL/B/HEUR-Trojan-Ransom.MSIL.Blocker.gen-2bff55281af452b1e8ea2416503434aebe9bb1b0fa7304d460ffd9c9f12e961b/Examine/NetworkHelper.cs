using System;
using System.Net;

namespace Examine;

internal class NetworkHelper
{
	public static string FileSafeMachineName => MachineName.ReplaceNonAlphanumericChars("-");

	public static string MachineName
	{
		get
		{
			try
			{
				return Environment.MachineName;
			}
			catch
			{
				try
				{
					return Dns.GetHostName();
				}
				catch
				{
					throw new ApplicationException("Cannot resolve the current machine name eithe by Environment.MachineName or by Dns.GetHostname()");
				}
			}
		}
	}
}
