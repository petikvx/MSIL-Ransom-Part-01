using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		LoginTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginTest()
	{
	}
}
