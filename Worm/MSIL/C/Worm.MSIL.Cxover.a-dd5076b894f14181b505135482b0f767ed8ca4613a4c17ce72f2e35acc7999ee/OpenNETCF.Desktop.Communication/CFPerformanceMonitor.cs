using System;
using System.IO;

namespace OpenNETCF.Desktop.Communication;

public class CFPerformanceMonitor
{
	private PerformanceStatistics m_stats;

	private RAPI m_rapi;

	private static string m_perfkey = "SOFTWARE\\Microsoft\\.NETCompactFramework\\PerfMonitor";

	internal CFPerformanceMonitor(RAPI rapi)
	{
		m_stats = new PerformanceStatistics();
		m_rapi = rapi;
	}

	public void EnableProfiling()
	{
		m_rapi.CheckConnection();
		CERegistryKey cERegistryKey = CERegistry.LocalMachine.CreateSubKey(m_perfkey);
		cERegistryKey.SetValue("Counters", 1);
	}

	public void DisableProfiling()
	{
		m_rapi.CheckConnection();
		CERegistryKey cERegistryKey = CERegistry.LocalMachine.CreateSubKey(m_perfkey);
		cERegistryKey.SetValue("Counters", 0);
	}

	public PerformanceStatistics GetCurrentStatistics()
	{
		m_rapi.CheckConnection();
		GetStats();
		return m_stats;
	}

	private void GetStats()
	{
		string text = "\\mscoree.stat";
		m_rapi.CopyFileFromDevice(text, "\\mscoree.stat", Overwrite: true);
		StreamReader streamReader = File.OpenText(text);
		for (string text2 = streamReader.ReadLine(); text2 != null; text2 = streamReader.ReadLine())
		{
			if (text2.Length > 1 && text2.Substring(0, 7) != "counter")
			{
				string name = text2.Substring(0, 47).Trim();
				int val = Convert.ToInt32(text2.Substring(46, 11).Trim(), 10);
				int sampleCount = Convert.ToInt32(text2.Substring(57, 9).Trim(), 10);
				int mean = Convert.ToInt32(text2.Substring(66, 9).Trim(), 10);
				int min = Convert.ToInt32(text2.Substring(75, 9).Trim(), 10);
				int max = Convert.ToInt32(text2.Substring(84, 9).Trim(), 10);
				m_stats.Add(new PerformanceStatistic(name, val, sampleCount, mean, min, max));
			}
		}
		streamReader.Close();
		File.Delete(text);
	}
}
