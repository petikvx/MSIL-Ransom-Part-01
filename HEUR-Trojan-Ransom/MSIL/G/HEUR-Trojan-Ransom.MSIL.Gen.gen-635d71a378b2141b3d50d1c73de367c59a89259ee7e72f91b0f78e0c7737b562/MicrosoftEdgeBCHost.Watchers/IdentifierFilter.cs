using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InsertAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertAuthentication()
	{
	}
}
