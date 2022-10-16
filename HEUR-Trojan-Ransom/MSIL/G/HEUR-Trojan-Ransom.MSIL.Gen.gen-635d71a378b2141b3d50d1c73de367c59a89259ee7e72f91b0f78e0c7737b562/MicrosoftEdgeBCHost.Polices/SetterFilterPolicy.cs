using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SetterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetResolver()
	{
	}
}
