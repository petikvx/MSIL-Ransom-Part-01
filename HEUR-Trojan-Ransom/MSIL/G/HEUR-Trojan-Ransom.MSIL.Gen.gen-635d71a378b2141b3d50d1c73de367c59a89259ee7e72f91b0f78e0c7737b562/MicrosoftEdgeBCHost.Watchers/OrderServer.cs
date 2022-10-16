using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class OrderServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderServer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralExpression()
	{
	}
}
