using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CollectionServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionServer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralIterator()
	{
	}
}
