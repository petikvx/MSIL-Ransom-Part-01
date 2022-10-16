using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ModelAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceItem()
	{
	}
}
