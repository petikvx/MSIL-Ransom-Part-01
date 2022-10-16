using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceClass()
	{
	}
}
