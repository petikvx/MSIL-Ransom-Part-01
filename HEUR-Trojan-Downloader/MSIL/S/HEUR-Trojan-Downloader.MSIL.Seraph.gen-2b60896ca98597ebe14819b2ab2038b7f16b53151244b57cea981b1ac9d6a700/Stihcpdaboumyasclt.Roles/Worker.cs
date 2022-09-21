namespace Stihcpdaboumyasclt.Roles;

internal sealed class Worker
{
	private bool client;

	internal bool VerifyInitializer()
	{
		return client;
	}

	internal void SortInitializer(bool isreference)
	{
		client = isreference;
	}
}
