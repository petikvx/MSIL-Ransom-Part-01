using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceError()
	{
	}
}
