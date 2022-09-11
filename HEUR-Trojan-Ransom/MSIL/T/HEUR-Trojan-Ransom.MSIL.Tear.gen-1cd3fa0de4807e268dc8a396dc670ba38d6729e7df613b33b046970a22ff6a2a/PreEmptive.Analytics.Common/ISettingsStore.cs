using System.Collections.Generic;

namespace PreEmptive.Analytics.Common;

public interface ISettingsStore
{
	string this[string string_0] { get; set; }

	int Count { get; }

	IList<string> Keys { get; }

	int MaxValueLength { get; }

	int MaxKeyLength { get; }

	void Flush();
}
