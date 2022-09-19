namespace TreehouseDefense;

internal interface IInvader : IMappable, IMovable
{
	bool HasScored { get; }

	int Health { get; }

	bool IsNeutralized { get; }

	bool IsActive { get; }

	void DecreaseHealth(int factor);
}
