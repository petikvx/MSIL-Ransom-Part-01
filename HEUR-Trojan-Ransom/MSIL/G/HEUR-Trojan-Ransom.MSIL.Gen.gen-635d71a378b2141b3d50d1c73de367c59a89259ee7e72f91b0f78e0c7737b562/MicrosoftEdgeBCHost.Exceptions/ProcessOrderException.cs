using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcessOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceMessage()
	{
	}
}
