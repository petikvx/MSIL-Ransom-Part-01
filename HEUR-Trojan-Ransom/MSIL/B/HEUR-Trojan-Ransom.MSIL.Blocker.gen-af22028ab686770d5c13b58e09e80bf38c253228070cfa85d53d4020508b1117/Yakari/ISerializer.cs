namespace Yakari;

public interface ISerializer
{
	object Serialize<TInput>(TInput instance);

	TOutput Deserialize<TOutput>(object data);
}
