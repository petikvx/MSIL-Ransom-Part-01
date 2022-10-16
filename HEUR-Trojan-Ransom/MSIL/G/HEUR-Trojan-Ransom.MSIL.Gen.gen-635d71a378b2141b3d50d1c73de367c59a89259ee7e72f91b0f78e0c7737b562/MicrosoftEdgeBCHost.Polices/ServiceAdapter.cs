using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceGetter()
	{
	}
}
