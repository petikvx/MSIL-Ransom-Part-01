using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceStub()
	{
	}
}
