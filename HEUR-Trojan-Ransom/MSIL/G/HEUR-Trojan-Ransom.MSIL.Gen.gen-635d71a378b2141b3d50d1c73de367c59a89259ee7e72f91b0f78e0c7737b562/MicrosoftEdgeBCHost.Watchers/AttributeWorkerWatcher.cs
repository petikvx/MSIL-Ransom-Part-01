using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttributeWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralRole()
	{
	}
}
