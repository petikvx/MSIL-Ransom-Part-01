using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralInstance()
	{
	}
}
