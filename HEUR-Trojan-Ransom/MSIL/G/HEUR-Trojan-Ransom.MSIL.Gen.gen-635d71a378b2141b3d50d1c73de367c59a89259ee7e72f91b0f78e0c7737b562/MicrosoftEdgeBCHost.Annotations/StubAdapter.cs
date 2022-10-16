using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		PushProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushProc()
	{
	}
}
