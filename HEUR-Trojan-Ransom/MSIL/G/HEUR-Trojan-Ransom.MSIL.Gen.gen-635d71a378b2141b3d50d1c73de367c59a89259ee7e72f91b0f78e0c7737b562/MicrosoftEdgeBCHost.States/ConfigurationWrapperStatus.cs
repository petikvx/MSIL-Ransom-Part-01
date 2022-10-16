using System.IO;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal sealed class ConfigurationWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Stream SetStub(object setup)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
