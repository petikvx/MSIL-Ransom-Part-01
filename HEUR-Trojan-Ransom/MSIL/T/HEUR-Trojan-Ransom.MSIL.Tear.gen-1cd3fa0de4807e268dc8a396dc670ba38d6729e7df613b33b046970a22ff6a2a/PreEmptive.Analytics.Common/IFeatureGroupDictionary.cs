namespace PreEmptive.Analytics.Common;

public interface IFeatureGroupDictionary
{
	FeatureGroup TryRemove(string name, string partitionid, out bool foundpartition);

	void Add(string name, FeatureGroup adder);
}
