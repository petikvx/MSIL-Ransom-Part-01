using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceManager()
	{
	}
}
