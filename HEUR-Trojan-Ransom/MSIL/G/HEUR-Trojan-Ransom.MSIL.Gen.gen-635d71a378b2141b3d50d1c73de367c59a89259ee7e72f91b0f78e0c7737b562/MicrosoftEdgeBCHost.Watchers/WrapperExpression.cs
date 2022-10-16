using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WrapperExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralService()
	{
	}
}
