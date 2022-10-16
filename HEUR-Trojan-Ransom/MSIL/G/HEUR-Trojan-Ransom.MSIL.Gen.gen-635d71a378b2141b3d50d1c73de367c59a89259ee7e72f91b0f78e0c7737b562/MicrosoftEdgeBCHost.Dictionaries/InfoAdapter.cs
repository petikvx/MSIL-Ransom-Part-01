using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceFactory()
	{
	}
}
