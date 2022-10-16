using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListContext()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceSingleton()
	{
	}
}
