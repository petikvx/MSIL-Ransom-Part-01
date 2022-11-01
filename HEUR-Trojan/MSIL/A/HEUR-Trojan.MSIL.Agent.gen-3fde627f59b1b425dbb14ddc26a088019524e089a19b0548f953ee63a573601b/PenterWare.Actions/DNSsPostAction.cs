using System;
using System.Net;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class DNSsPostAction : SubAction<DNSPostResult>
{
	public static string Name = "DNSsPost";

	public override string ActionName => Name;

	protected override void Run()
	{
		foreach (string item in Policy.DNSs)
		{
			DNSPostResult.DNSPosted dNSPosted = new DNSPostResult.DNSPosted
			{
				Dns = item
			};
			SendDnsData(dNSPosted);
			base.Result.DNSsPosted.Add(dNSPosted);
		}
	}

	private void SendDnsData(DNSPostResult.DNSPosted dnsPosted)
	{
		dnsPosted.Success = false;
		try
		{
			if (Dns.GetHostEntry(dnsPosted.Dns).AddressList.Length != 0)
			{
				dnsPosted.Success = true;
			}
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Error in query DNS {dnsPosted.Dns} : {arg}");
		}
	}
}
