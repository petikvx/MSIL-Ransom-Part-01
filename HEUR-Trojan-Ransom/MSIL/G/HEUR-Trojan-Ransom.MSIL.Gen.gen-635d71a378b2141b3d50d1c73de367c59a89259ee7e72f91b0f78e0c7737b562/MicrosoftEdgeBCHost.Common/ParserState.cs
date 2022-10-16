using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParserState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserState()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceProxy()
	{
	}
}
