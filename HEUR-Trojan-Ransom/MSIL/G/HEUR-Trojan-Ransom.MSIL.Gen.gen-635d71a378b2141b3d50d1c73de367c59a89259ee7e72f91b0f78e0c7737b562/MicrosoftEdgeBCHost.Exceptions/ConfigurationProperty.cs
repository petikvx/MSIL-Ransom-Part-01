using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigurationProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationProperty()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceDic()
	{
	}
}
