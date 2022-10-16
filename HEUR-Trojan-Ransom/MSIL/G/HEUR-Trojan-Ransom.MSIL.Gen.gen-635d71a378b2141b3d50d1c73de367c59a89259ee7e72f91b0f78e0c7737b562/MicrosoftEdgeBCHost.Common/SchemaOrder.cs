using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaOrder()
	{
		WriterPropertyProducer.ResolveStub();
		PushItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushItem()
	{
	}
}
