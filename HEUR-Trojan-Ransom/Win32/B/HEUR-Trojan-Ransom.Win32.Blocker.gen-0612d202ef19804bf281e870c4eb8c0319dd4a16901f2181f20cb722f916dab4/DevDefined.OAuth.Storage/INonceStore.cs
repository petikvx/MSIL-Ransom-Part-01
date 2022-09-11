using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage;

public interface INonceStore
{
	bool RecordNonceAndCheckIsUnique(IConsumer consumer, string nonce);
}
