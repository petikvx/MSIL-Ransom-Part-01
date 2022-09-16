using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.WindowsAzure;
using Microsoft.VisualStudio.WindowsAzure.Authentication;

namespace _0xHH4bit4nt;

internal static class _0xHColdh1art1d
{
	public static IAzureSubscriptionContext _0xHCru3iform(this IAzureAuthenticationManager _0xH5ensationalized, string _0xHSp3iler)
	{
		if (_0xH5ensationalized == null)
		{
			throw new ArgumentNullException("authenticationManager");
		}
		Task<IEnumerable<IAzureRdfeSubscriptionContext>> subscriptionsAsync = _0xH5ensationalized.GetSubscriptionsAsync();
		subscriptionsAsync.Wait();
		IEnumerable<IAzureRdfeSubscriptionContext> result = subscriptionsAsync.Result;
		IAzureSubscriptionIdentifier subscriptionIdentifier = null;
		IAzureSubscriptionContext result2 = null;
		if (_0xH5ensationalized.TryParseSubscriptionIdentifier(_0xHSp3iler, ref subscriptionIdentifier))
		{
			result2 = (IAzureSubscriptionContext)(object)result.FirstOrDefault((Func<IAzureRdfeSubscriptionContext, bool>)((IAzureRdfeSubscriptionContext context) => ((IEquatable<IAzureSubscriptionIdentifier>)((IAzureSubscriptionContext)context).get_Subscription()).Equals(subscriptionIdentifier)));
		}
		return result2;
	}

	public static async Task<IAzureSubscriptionContext> _0xHRe7rgu7rd(this IAzureAuthenticationManager _0xHOv8rhating, string _0xHPart0c0pates)
	{
		if (_0xHOv8rhating == null)
		{
			throw new ArgumentNullException("authenticationManager");
		}
		IEnumerable<IAzureRdfeSubscriptionContext> source = await _0xHOv8rhating.GetSubscriptionsAsync();
		IAzureSubscriptionIdentifier subscriptionIdentifier = null;
		IAzureSubscriptionContext result = null;
		if (_0xHOv8rhating.TryParseSubscriptionIdentifier(_0xHPart0c0pates, ref subscriptionIdentifier))
		{
			result = (IAzureSubscriptionContext)(object)source.FirstOrDefault((Func<IAzureRdfeSubscriptionContext, bool>)((IAzureRdfeSubscriptionContext context) => ((IEquatable<IAzureSubscriptionIdentifier>)((IAzureSubscriptionContext)context).get_Subscription()).Equals(subscriptionIdentifier)));
		}
		return result;
	}

	public static IAzureSubscriptionIdentifier _0xHAlveol5rs(this IAzureAuthenticationManager _0xH6arooning, string _0xH7ncrementally)
	{
		if (_0xH6arooning == null)
		{
			throw new ArgumentNullException("authenticationManager");
		}
		IAzureSubscriptionIdentifier result = null;
		_0xH6arooning.TryParseSubscriptionIdentifier(_0xH7ncrementally, ref result);
		return result;
	}
}
