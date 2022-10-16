using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ErrorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceExporter()
	{
	}
}
