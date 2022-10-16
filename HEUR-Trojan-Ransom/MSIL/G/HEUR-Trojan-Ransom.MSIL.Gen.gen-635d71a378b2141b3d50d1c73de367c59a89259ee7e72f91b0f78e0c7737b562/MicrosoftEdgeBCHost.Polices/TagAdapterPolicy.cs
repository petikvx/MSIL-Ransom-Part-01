using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TagAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralInfo()
	{
	}
}
