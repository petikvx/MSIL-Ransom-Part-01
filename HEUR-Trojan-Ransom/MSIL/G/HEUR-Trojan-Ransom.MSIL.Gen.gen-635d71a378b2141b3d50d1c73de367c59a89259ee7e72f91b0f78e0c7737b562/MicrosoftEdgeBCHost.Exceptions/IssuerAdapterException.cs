using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IssuerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceProc()
	{
	}
}
