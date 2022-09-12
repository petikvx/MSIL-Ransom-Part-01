namespace Examine;

public interface IIndexField
{
	string Name { get; set; }

	bool EnableSorting { get; set; }

	string Type { get; set; }
}
