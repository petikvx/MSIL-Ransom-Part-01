using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigurationObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationObject()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralProduct()
	{
	}
}
