using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttrFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PostAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostAuthentication()
	{
	}
}
