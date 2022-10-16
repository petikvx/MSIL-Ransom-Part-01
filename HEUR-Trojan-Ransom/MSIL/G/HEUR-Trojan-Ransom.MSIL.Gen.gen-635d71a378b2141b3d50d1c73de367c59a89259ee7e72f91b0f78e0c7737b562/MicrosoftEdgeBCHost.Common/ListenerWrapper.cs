using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListenerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteAttribute()
	{
	}
}
