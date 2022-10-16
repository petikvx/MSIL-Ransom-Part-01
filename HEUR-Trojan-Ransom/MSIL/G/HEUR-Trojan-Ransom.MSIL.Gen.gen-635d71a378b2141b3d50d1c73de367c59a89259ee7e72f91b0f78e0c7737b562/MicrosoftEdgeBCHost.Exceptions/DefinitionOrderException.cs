using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DefinitionOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceAlgo()
	{
	}
}
