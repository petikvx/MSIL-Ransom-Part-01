using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CreatorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceParams()
	{
	}
}
