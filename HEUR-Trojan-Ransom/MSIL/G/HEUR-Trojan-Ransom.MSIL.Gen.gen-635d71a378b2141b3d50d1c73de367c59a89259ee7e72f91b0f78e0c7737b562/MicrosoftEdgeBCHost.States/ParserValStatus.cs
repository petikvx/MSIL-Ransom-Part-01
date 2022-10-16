using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralModel()
	{
	}
}
