using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TemplateWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		StartMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartMap()
	{
	}
}
