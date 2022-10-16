using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWorker()
	{
		WriterPropertyProducer.ResolveStub();
		InitSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitSerializer()
	{
	}
}
