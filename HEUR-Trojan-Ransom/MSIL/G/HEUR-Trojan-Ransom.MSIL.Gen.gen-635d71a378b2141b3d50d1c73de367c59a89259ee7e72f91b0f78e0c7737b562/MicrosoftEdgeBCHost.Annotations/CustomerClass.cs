using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CustomerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerClass()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceItem()
	{
	}
}
