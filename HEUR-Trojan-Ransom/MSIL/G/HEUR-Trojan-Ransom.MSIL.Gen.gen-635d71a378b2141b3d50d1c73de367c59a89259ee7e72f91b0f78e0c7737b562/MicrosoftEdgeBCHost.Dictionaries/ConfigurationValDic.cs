using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigurationValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralSystem()
	{
	}
}
