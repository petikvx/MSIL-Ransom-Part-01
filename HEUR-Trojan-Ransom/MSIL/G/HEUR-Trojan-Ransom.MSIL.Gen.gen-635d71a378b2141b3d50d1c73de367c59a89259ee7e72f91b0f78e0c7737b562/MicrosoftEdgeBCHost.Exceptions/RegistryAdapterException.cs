using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegistryAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceAccount()
	{
	}
}
