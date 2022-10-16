using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ThreadOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceSetter()
	{
	}
}
