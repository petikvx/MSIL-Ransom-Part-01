using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchClient()
	{
	}
}
