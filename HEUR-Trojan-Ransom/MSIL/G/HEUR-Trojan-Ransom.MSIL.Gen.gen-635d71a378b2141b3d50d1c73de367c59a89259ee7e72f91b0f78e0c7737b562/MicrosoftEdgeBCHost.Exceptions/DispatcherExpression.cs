using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralExporter()
	{
	}
}
