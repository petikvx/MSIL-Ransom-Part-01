using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PublisherExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralMap()
	{
	}
}
