using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClassBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateExporter()
	{
	}
}
