using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceFactory()
	{
	}
}
