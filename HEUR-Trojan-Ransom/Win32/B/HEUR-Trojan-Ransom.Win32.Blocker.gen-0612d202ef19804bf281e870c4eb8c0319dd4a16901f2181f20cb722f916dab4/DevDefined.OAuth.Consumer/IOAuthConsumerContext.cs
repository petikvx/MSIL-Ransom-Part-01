using System.Security.Cryptography;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Consumer;

public interface IOAuthConsumerContext
{
	string Realm { get; set; }

	string ConsumerKey { get; set; }

	string ConsumerSecret { get; set; }

	string SignatureMethod { get; set; }

	string UserAgent { get; set; }

	AsymmetricAlgorithm Key { get; set; }

	bool UseHeaderForOAuthParameters { get; set; }

	void SignContext(IOAuthContext context);

	void SignContextWithToken(IOAuthContext context, IToken token);
}
