using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConnectionGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceParams()
	{
	}
}
