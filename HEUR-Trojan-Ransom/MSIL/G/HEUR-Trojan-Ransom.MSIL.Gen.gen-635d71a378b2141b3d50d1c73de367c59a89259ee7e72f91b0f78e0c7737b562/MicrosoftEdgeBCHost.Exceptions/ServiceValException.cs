using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServiceValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceValException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintDescriptor()
	{
	}
}
