using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TemplateFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralWorker()
	{
	}
}
