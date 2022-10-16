using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationVal()
	{
		WriterPropertyProducer.ResolveStub();
		GetSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetSpecification()
	{
	}
}
