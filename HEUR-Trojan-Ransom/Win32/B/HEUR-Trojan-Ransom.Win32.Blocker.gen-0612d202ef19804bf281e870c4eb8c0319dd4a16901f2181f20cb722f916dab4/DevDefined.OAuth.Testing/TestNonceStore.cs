using System.Collections.Generic;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Storage;

namespace DevDefined.OAuth.Testing;

public class TestNonceStore : INonceStore
{
	private readonly Dictionary<string, List<string>> _nonces = new Dictionary<string, List<string>>();

	public bool RecordNonceAndCheckIsUnique(IConsumer consumer, string nonce)
	{
		List<string> nonceListForConsumer = GetNonceListForConsumer(consumer.ConsumerKey);
		lock (nonceListForConsumer)
		{
			if (nonceListForConsumer.Contains(nonce))
			{
				return false;
			}
			nonceListForConsumer.Add(nonce);
			return true;
		}
	}

	private List<string> GetNonceListForConsumer(string consumerKey)
	{
		List<string> value = new List<string>();
		if (!_nonces.TryGetValue(consumerKey, out value))
		{
			lock (_nonces)
			{
				if (_nonces.TryGetValue(consumerKey, out value))
				{
					return value;
				}
				value = new List<string>();
				_nonces[consumerKey] = value;
				return value;
			}
		}
		return value;
	}
}
