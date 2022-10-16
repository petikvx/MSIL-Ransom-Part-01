using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExporterWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutService()
	{
	}
}
