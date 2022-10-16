using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralEvent()
	{
	}
}
