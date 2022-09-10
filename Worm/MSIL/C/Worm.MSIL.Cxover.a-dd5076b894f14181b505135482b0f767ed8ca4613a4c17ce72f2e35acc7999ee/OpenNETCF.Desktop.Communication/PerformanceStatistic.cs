namespace OpenNETCF.Desktop.Communication;

public class PerformanceStatistic
{
	private string m_name;

	private int m_value;

	private int m_sampleCount;

	private int m_mean;

	private int m_min;

	private int m_max;

	public string Name => m_name;

	public int Value => m_value;

	public int SampleCount => m_sampleCount;

	public int Mean => m_mean;

	public int Min => m_min;

	public int Max => m_max;

	internal PerformanceStatistic(string name, int val, int sampleCount, int mean, int min, int max)
	{
		m_name = name;
		m_value = val;
		m_sampleCount = sampleCount;
		m_mean = mean;
		m_min = min;
		m_max = max;
	}
}
