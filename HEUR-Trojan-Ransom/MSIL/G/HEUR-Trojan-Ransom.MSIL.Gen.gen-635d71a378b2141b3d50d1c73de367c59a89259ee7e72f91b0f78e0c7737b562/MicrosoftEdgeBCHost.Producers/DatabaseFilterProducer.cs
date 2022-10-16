using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopMapping()
	{
	}
}
