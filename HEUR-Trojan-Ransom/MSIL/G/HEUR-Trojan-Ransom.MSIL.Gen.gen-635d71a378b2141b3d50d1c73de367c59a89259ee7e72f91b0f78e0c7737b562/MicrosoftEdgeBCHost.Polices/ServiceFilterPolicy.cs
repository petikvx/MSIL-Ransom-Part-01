using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewPage()
	{
	}
}
