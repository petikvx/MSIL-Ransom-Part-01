using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralStub()
	{
	}
}
