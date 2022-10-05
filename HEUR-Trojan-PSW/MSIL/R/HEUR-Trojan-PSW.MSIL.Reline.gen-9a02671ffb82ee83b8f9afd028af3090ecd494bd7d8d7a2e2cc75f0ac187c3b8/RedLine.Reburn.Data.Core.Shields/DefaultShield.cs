using RedLine.Reburn.Models.Core;

namespace RedLine.Reburn.Data.Core.Shields;

public class DefaultShield : IFileShield
{
	public bool Verify()
	{
		return true;
	}
}
