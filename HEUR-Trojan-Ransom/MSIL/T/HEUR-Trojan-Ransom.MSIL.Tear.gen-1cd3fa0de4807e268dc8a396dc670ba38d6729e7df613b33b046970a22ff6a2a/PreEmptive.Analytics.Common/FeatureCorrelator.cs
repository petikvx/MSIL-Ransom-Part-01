using System;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public class FeatureCorrelator
{
	private IFeatureGroupDictionary ifeatureGroupDictionary_0;

	private IFeaturePartitioner ifeaturePartitioner_0;

	public FeatureCorrelator([Optional] IFeatureGroupDictionary featuregroups, [Optional] IFeaturePartitioner partitioner)
	{
		ifeatureGroupDictionary_0 = featuregroups ?? new LockingFeatureGroupDictionary();
		ifeaturePartitioner_0 = partitioner ?? new ThreadFeaturePartitioner();
	}

	public FeatureGroup Start(string name)
	{
		if (1 == 0)
		{
		}
		int num = 32022;
		int num2 = num;
		num = 32022;
		switch (num2 == num)
		{
		default:
		{
			if (0 == 0)
			{
			}
			FeatureGroup featureGroup = new FeatureGroup(Guid.NewGuid(), ifeaturePartitioner_0.GetPartition());
			ifeatureGroupDictionary_0.Add(name, featureGroup);
			return featureGroup;
		}
		}
	}

	public FeatureGroup Stop(string name)
	{
		bool foundpartition = false;
		FeatureGroup featureGroup = ifeatureGroupDictionary_0.TryRemove(name, ifeaturePartitioner_0.GetPartition(), out foundpartition);
		if (featureGroup == null)
		{
			while (true)
			{
				int num = 2395;
				int num2 = num;
				num = 2395;
				switch (num2 == num)
				{
				case false:
				case true:
					break;
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					return new FeatureGroup(Guid.NewGuid(), ifeaturePartitioner_0.GetPartition());
				}
			}
		}
		return featureGroup;
	}
}
