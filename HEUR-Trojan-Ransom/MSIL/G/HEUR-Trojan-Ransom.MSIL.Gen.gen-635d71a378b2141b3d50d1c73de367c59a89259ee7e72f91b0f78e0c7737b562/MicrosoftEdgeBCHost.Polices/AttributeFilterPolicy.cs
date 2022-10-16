using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttributeFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterpreter()
	{
	}
}
