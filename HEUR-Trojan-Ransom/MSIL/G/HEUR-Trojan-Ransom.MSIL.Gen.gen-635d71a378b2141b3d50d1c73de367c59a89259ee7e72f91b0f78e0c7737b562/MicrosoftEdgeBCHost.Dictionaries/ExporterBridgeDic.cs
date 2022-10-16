using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceRole()
	{
	}
}
