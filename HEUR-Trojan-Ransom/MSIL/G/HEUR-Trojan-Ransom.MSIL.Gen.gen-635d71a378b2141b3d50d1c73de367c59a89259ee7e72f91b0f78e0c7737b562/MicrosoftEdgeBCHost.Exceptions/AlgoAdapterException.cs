using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AlgoAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceRules()
	{
	}
}
