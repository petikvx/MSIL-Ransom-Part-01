using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ThreadAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralUtils()
	{
	}
}
