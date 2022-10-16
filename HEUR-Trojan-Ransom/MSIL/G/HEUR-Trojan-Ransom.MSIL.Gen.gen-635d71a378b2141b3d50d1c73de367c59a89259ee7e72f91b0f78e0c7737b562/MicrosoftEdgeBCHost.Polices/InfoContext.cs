using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoContext()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceWrapper()
	{
	}
}
