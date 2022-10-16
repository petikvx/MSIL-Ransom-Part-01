using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyServer()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralMock()
	{
	}
}
