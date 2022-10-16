using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttributeBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceRole()
	{
	}
}
