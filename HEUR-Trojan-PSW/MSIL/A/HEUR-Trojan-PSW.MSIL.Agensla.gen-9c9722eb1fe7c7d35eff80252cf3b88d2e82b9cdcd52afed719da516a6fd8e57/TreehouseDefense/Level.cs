namespace TreehouseDefense;

internal class Level
{
	private readonly IInvader[] _invaders;

	public Tower[] Towers { get; set; }

	public Level(IInvader[] invaders)
	{
		_invaders = invaders;
	}

	public bool Play()
	{
		int num = _invaders.Length;
		while (num > 0)
		{
			Tower[] towers = Towers;
			foreach (Tower tower in towers)
			{
				tower.FireOnInvaders(_invaders);
			}
			num = 0;
			IInvader[] invaders = _invaders;
			foreach (IInvader invader in invaders)
			{
				if (invader.IsActive)
				{
					invader.Move();
					if (invader.HasScored)
					{
						return false;
					}
					num++;
				}
			}
		}
		return true;
	}
}
