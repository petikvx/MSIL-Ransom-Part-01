namespace Business.Data;

public interface IPaging
{
	dynamic Data { get; set; }

	int Length { get; set; }

	int CurrentPage { get; set; }

	int Count { get; set; }

	int CountPage { get; set; }
}
