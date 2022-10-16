using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherVal()
	{
		WriterPropertyProducer.ResolveStub();
		CreateProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateProducer()
	{
	}
}
