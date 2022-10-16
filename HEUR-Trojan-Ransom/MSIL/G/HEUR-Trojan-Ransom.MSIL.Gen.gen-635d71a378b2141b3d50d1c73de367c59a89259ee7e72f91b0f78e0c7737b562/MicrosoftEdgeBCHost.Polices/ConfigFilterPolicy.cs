using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginCollection()
	{
	}
}
