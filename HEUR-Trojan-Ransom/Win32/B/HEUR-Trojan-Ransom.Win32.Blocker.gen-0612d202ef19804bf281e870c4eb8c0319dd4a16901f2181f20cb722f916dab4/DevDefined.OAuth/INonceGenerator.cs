using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth;

public interface INonceGenerator
{
	string GenerateNonce(IOAuthContext context);
}
