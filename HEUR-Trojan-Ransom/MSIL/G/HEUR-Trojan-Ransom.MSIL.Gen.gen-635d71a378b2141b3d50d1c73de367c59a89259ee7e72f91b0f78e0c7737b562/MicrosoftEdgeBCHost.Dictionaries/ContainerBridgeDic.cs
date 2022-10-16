using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContainerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceCode()
	{
	}
}
