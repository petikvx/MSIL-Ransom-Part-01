using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SerializerFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerFacade()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralClass()
	{
	}
}
