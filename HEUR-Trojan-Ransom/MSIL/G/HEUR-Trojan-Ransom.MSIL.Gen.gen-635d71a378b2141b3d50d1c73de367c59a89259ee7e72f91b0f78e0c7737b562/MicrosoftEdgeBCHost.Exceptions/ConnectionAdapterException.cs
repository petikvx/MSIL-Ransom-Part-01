using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConnectionAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceUtils()
	{
	}
}
