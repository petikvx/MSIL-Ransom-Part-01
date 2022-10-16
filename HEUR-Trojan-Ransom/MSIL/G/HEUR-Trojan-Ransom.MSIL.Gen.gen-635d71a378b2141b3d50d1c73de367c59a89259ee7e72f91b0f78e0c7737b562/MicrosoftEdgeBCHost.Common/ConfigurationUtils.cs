using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceCollection()
	{
	}
}
