using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttributeOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralCreator()
	{
	}
}
