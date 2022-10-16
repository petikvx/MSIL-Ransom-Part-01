using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GlobalPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceInfo()
	{
	}
}
