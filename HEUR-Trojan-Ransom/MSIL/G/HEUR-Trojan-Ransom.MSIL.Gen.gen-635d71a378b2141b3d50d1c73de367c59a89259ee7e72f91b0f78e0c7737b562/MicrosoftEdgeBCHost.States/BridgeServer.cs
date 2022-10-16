using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeServer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralExpression()
	{
	}
}
