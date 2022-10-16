using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SchemaAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceItem()
	{
	}
}
