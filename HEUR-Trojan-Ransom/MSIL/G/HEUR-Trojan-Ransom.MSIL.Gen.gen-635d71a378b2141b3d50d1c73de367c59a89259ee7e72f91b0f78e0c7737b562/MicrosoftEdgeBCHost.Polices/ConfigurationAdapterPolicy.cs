using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigurationAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralRepository()
	{
	}
}
