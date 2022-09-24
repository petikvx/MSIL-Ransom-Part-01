using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

internal sealed class HNDBddbMue
{
	public static List<string> lvcuknzboJRx;

	public static string HyYnCuPmIKcH;

	public static List<string> exjmfwlmGyZrvbw;

	public static List<string> kApDLovEFpGFRrxV;

	public static List<string> rqoVZArZUsDI;

	public List<string> MqpAQFUwTv = new List<string>();

	public List<string> QpGApenFelDg = new List<string>();

	public List<string> qaiacEyUYrH = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool NhBKYOYAcHZTx(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	static HNDBddbMue()
	{
		Strings.CreateGetStringDelegate(typeof(HNDBddbMue));
		lvcuknzboJRx = new List<string>();
		HyYnCuPmIKcH = getString_0(107393161);
		exjmfwlmGyZrvbw = new List<string>();
		kApDLovEFpGFRrxV = new List<string>();
		rqoVZArZUsDI = new List<string>();
	}
}
