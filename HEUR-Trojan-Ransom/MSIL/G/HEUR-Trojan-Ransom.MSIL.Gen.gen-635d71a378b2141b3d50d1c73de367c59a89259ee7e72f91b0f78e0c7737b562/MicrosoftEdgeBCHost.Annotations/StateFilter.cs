using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PopPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopPage()
	{
	}
}
