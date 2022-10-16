using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigState()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceTag()
	{
	}
}
