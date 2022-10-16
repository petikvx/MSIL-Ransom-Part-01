using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PageValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralTemplate()
	{
	}
}
