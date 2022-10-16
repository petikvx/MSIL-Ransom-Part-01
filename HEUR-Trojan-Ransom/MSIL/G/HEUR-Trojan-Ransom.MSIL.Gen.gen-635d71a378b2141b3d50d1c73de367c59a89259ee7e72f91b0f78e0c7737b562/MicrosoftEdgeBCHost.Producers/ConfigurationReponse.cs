using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralObject()
	{
	}
}
