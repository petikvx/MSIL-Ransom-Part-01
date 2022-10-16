using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttributeBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CloneMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneMessage()
	{
	}
}
