using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StatusContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusContext()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceInterpreter()
	{
	}
}
