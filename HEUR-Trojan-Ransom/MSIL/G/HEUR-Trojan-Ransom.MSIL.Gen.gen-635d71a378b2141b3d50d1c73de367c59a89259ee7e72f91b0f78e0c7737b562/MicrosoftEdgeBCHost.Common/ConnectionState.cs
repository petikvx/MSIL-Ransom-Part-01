using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionState()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceException()
	{
	}
}
