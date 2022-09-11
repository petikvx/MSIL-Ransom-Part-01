using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Consumer;

public interface IConsumerRequestFactory
{
	IConsumerRequest CreateConsumerRequest(IOAuthContext context, IOAuthConsumerContext consumerContext, IToken token);
}
