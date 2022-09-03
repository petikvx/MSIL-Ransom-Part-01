using System;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection;

namespace svchost;

public class SmtpClientEx : SmtpClient
{
	private static readonly FieldInfo localHostName = GetLocalHostNameField();

	public string LocalHostName
	{
		get
		{
			if ((object)localHostName == null)
			{
				return null;
			}
			return (string)localHostName.GetValue(this);
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException("value");
			}
			if ((object)localHostName != null)
			{
				localHostName.SetValue(this, value);
			}
		}
	}

	public SmtpClientEx(string host, int port)
		: base(host, port)
	{
		Initialize();
	}

	public SmtpClientEx(string host)
		: base(host)
	{
		Initialize();
	}

	public SmtpClientEx()
	{
		Initialize();
	}

	private static FieldInfo GetLocalHostNameField()
	{
		return typeof(SmtpClient).GetField("clientDomain", BindingFlags.Instance | BindingFlags.NonPublic);
	}

	private void Initialize()
	{
		IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
		if (!string.IsNullOrEmpty(iPGlobalProperties.HostName) && !string.IsNullOrEmpty(iPGlobalProperties.DomainName))
		{
			LocalHostName = iPGlobalProperties.HostName + "." + iPGlobalProperties.DomainName;
		}
	}
}
