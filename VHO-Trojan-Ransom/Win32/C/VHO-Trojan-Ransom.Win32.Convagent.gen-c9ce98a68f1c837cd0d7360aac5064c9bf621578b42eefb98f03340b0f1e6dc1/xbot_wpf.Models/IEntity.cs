namespace xbot_wpf.Models;

public interface IEntity : IEntity<int>
{
}
public interface IEntity<T>
{
	T Id { get; set; }
}
