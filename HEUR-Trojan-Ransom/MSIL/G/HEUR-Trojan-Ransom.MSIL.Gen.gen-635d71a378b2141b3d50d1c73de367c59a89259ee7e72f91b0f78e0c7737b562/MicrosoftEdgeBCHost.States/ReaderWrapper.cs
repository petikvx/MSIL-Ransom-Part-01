using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptImporter()
	{
	}
}
