using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ImporterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfacePrototype()
	{
	}
}
