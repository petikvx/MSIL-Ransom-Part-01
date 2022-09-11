using System.Security.Cryptography;

namespace DevDefined.OAuth.Framework;

public class SigningContext
{
	public AsymmetricAlgorithm Algorithm { get; set; }

	public string ConsumerSecret { get; set; }

	public string SignatureBase { get; set; }
}
