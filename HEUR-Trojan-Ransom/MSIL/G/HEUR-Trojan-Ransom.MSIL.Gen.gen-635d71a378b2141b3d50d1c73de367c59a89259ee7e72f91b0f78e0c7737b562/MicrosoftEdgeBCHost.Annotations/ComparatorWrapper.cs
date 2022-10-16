using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PushImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushImporter()
	{
	}
}
