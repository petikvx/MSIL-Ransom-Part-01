using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PropertyRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyRules()
	{
		WriterPropertyProducer.ResolveStub();
		EnableConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableConfiguration()
	{
	}
}
