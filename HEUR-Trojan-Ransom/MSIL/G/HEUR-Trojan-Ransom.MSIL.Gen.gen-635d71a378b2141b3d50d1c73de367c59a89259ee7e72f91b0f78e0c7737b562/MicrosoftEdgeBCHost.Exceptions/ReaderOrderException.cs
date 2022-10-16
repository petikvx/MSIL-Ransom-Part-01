using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReaderOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceValue()
	{
	}
}
