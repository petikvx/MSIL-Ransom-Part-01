using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceParser()
	{
	}
}
