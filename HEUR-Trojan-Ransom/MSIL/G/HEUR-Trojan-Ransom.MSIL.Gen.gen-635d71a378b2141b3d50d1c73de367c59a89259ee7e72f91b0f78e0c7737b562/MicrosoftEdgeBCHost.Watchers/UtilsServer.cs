using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class UtilsServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsServer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralMock()
	{
	}
}
