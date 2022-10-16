using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PrintClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintClient()
	{
	}
}
