using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InstanceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralHelper()
	{
	}
}
