using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceStruct()
	{
	}
}
