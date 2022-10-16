using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComposerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceTests()
	{
	}
}
