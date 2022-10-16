using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigObject()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralParameter()
	{
	}
}
