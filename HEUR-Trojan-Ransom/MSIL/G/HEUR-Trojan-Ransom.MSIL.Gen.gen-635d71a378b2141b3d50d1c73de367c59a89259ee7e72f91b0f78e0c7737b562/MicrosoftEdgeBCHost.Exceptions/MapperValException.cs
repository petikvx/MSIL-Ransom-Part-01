using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperValException()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeMapper()
	{
	}
}
