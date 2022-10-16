using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfacePage()
	{
	}
}
