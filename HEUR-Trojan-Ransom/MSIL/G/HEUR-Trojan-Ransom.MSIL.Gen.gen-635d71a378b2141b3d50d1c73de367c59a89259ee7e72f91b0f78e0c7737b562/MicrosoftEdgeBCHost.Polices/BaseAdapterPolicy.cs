using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralUtils()
	{
	}
}
