using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SetAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetAuthentication()
	{
	}
}
