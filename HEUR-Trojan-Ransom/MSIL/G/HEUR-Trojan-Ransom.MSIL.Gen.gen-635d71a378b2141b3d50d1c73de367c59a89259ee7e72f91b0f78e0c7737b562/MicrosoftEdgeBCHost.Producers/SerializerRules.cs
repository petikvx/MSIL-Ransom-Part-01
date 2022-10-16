using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerRules()
	{
		WriterPropertyProducer.ResolveStub();
		MapTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapTag()
	{
	}
}
