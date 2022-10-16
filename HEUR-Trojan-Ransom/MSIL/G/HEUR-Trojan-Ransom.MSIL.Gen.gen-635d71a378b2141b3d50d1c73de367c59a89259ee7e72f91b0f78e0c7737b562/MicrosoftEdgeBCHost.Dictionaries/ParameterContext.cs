using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParameterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterContext()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceSpecification()
	{
	}
}
