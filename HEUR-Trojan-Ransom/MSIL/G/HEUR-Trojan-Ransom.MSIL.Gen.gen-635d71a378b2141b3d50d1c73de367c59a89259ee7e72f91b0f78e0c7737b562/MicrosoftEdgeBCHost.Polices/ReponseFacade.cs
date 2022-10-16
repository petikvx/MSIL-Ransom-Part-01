using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseFacade()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralClass()
	{
	}
}
