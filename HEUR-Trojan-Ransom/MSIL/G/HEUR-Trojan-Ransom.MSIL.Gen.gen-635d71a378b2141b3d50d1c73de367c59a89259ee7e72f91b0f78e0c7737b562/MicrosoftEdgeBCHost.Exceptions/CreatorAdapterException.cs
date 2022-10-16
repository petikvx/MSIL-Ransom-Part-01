using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceUtils()
	{
	}
}
