using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralMapping()
	{
	}
}
