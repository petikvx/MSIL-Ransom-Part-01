using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Helper;

public static class GlobalConfigHelper
{
	public static GlobalConfigData ReadGlobalConfigData(string filename)
	{
		GlobalConfigData globalConfigData = new GlobalConfigData();
		try
		{
			string[] array = File.ReadAllLines(filename);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.StartsWith("proxyserver=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.ProxyServer = GetStringValue(text);
				}
				else if (text.StartsWith("proxyport=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.ProxyPort = GetIntegerValue(text);
				}
				else if (text.StartsWith("proxyuser=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.ProxyUser = GetStringValue(text);
				}
				else if (text.StartsWith("proxypass=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.ProxyPass = GetStringValue(text);
				}
				else if (text.StartsWith("DelayConnect=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.ConnectDelayTime = GetIntegerValue(text);
				}
				else if (text.StartsWith("RepeatTime=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.RepeatTime = GetIntegerValue(text);
				}
				else if (text.StartsWith("TryTimes=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.TryTimes = GetIntegerValue(text);
				}
				else if (text.StartsWith("HttpTimeout=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.HttpTimeout = GetIntegerValue(text) * 1000;
				}
				else if (text.StartsWith("HttpTryTimes=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.HttpTryTimes = GetIntegerValue(text);
				}
				else if (text.StartsWith("EnableLog=", StringComparison.OrdinalIgnoreCase))
				{
					globalConfigData.WriteToLogFile = GetBoolValue(text);
				}
			}
			return globalConfigData;
		}
		catch (Exception ex)
		{
			TraceLog.Error(ex.Message);
			return null;
		}
	}

	public static void GetIntegerListValue(Collection<int> list, string line)
	{
		string[] array = GetStringValue(line).Split(new char[1] { ',' });
		string[] array2 = array;
		foreach (string str in array2)
		{
			int integer = ContentHelper.GetInteger(str);
			if (-1 != integer)
			{
				list.Add(integer);
			}
		}
	}

	public static bool GetBoolValue(string line)
	{
		return "1" == GetStringValue(line);
	}

	public static int GetIntegerValue(string line)
	{
		string stringValue = GetStringValue(line);
		return ContentHelper.GetInteger(stringValue);
	}

	public static string GetStringValue(string line)
	{
		return line.Substring(line.IndexOf('=') + 1);
	}
}
