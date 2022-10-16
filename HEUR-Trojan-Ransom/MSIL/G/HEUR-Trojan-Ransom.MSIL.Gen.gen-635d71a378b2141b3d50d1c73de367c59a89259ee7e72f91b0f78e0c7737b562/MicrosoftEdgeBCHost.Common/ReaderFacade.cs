using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReaderFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralRegistry()
	{
	}
}
