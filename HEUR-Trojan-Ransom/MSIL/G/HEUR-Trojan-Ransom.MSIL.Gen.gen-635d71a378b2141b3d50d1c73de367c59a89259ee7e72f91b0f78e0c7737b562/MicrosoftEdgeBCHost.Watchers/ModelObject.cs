using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ModelObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelObject()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralAuthentication()
	{
	}
}
