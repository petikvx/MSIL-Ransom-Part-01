using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerServer()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralStrategy()
	{
	}
}
