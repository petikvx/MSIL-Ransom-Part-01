using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ModelOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelOrder()
	{
		WriterPropertyProducer.ResolveStub();
		AddItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddItem()
	{
	}
}
