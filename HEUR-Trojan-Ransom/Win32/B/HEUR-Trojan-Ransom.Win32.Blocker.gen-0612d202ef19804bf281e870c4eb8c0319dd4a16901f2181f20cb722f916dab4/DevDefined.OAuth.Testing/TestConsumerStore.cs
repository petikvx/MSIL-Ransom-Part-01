using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Storage;
using DevDefined.OAuth.Tests;

namespace DevDefined.OAuth.Testing;

public class TestConsumerStore : IConsumerStore
{
	public bool IsConsumer(IConsumer consumer)
	{
		if (consumer.ConsumerKey == "key")
		{
			return string.IsNullOrEmpty(consumer.Realm);
		}
		return false;
	}

	public void SetConsumerSecret(IConsumer consumer, string consumerSecret)
	{
		throw new NotImplementedException();
	}

	public string GetConsumerSecret(IOAuthContext consumer)
	{
		return "secret";
	}

	public void SetConsumerCertificate(IConsumer consumer, X509Certificate2 certificate)
	{
		throw new NotImplementedException();
	}

	public AsymmetricAlgorithm GetConsumerPublicKey(IConsumer consumer)
	{
		return TestCertificates.OAuthTestCertificate().PublicKey.Key;
	}
}
