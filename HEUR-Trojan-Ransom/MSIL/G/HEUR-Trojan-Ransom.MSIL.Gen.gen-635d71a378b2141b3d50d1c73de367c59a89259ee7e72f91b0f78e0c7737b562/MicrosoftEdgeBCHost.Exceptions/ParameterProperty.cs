using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceTest()
	{
	}
}
