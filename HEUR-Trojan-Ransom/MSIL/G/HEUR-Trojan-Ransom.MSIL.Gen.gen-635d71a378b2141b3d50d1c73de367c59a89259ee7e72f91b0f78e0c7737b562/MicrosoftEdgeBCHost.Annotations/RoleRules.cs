using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RoleRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleRules()
	{
		WriterPropertyProducer.ResolveStub();
		PublishListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishListener()
	{
	}
}
