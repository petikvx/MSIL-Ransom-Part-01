using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceExporter()
	{
	}
}
