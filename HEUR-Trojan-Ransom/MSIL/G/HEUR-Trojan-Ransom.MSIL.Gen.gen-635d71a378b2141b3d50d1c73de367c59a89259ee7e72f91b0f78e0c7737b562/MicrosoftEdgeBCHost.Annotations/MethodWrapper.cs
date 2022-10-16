using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CloneMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneMap()
	{
	}
}
