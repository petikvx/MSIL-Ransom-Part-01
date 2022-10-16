using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StubObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubObject()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralContext()
	{
	}
}
