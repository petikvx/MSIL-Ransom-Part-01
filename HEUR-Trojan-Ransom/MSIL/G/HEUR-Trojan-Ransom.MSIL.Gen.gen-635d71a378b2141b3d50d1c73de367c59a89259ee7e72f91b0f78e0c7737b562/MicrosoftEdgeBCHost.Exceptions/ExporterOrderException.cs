using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceSchema()
	{
	}
}
