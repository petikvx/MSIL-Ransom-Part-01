using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralList()
	{
	}
}
