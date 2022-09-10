using System.Collections;

namespace OpenNETCF.Desktop.Communication;

public class PerformanceStatistics : IEnumerable
{
	public class StatisticEnumerator : IEnumerator
	{
		private int index;

		private PerformanceStatistics m_stats;

		public PerformanceStatistic Current => (PerformanceStatistic)m_stats.items[index];

		object IEnumerator.Current => Current;

		internal StatisticEnumerator(PerformanceStatistics stats)
		{
			m_stats = stats;
			index = -1;
		}

		public void Reset()
		{
			index = -1;
		}

		public bool MoveNext()
		{
			index++;
			return index < m_stats.items.Count;
		}
	}

	private ArrayList items;

	public int Count => items.Count;

	internal PerformanceStatistics()
	{
		items = new ArrayList();
	}

	internal void Add(PerformanceStatistic stat)
	{
		items.Add(stat);
	}

	internal void Clear()
	{
		items.Clear();
	}

	public StatisticEnumerator GetEnumerator()
	{
		return new StatisticEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
