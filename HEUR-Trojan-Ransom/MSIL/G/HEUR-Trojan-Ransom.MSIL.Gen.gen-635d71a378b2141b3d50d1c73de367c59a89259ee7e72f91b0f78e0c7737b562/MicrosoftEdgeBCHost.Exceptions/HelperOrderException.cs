using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceManager()
	{
	}
}
