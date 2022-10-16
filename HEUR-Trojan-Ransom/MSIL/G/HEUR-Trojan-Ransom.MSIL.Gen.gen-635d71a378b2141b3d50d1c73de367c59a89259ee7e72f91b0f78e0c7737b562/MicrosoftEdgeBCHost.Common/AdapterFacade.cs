using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdapterFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralPolicy()
	{
	}
}
