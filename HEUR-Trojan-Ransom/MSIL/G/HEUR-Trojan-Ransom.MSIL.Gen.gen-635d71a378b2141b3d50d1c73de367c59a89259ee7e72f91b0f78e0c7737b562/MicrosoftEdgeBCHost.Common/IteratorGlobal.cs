using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceCandidate()
	{
	}
}
