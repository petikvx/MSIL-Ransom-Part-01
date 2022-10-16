using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InsertResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertResolver()
	{
	}
}
