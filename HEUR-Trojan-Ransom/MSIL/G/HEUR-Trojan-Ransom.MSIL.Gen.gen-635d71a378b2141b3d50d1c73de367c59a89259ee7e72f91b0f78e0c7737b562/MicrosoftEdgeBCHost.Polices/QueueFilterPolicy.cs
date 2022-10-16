using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class QueueFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatImporter()
	{
	}
}
