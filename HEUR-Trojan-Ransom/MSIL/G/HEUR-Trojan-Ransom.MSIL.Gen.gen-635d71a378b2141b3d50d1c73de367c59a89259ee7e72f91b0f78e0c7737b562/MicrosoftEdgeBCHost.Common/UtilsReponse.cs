using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class UtilsReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsReponse()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceBase()
	{
	}
}
