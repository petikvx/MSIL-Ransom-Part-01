using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceThread()
	{
	}
}
