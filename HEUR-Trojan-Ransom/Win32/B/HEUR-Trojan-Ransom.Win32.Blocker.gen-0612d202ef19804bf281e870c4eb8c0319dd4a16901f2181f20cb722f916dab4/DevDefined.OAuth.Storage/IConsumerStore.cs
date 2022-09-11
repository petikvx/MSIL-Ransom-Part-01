using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage;

public interface IConsumerStore
{
	bool IsConsumer(IConsumer consumer);

	void SetConsumerSecret(IConsumer consumer, string consumerSecret);

	string GetConsumerSecret(IOAuthContext consumer);

	void SetConsumerCertificate(IConsumer consumer, X509Certificate2 certificate);

	AsymmetricAlgorithm GetConsumerPublicKey(IConsumer consumer);
}
