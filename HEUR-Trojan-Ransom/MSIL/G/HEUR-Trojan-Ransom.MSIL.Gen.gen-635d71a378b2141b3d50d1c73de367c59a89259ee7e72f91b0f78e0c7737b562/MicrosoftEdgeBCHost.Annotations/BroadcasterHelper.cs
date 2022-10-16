using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralList()
	{
	}
}
