using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectThread()
	{
	}
}
