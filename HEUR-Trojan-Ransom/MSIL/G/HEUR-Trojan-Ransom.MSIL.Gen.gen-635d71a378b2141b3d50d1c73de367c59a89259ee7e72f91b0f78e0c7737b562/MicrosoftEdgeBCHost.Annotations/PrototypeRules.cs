using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrototypeRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeRules()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInitializer()
	{
	}
}
