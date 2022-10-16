using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StubOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceCreator()
	{
	}
}
