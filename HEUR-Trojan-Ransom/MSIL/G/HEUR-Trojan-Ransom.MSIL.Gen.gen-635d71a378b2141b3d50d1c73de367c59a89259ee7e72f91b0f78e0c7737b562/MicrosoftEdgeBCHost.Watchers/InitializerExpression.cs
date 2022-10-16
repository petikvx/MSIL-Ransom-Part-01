using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralAdapter()
	{
	}
}
