using ATI.ACE.LOG.Foundation.Implementation.Private;

namespace ATI.ACE.LOG.EXE;

internal class ServicesWrapper
{
	public readonly string sn;

	public readonly IServices s;

	public ServicesWrapper(IServices rS)
	{
		s = rS;
		sn = s.ServiceName();
	}

	public override string ToString()
	{
		return sn;
	}
}
