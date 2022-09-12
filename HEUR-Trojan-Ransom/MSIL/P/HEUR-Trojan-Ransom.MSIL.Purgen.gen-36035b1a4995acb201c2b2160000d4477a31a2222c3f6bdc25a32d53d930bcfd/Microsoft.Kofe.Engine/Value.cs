namespace Microsoft.Kofe.Engine;

public interface Value
{
	F18024EA9 Kind { get; }

	string DisplayValue { get; }

	bool HasChildren { get; }

	string DisplayType();
}
