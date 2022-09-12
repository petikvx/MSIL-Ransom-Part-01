using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using Ubiety.Dns.Core;
using Ubiety.Dns.Core.Common;
using Ubiety.Dns.Core.Records;

namespace MySql.Data.Common;

internal static class DnsResolver
{
	private static Resolver _resolver;

	internal static string ServiceName { get; private set; }

	internal static void CreateResolver(string serviceName)
	{
		_resolver = new Resolver
		{
			Recursion = true,
			UseCache = true,
			Retries = 3,
			TransportType = TransportType.Udp
		};
		ServiceName = serviceName;
	}

	internal static List<DnsSrvRecord> GetDnsSrvRecords(string serviceName)
	{
		if (_resolver == null)
		{
			CreateResolver(serviceName);
		}
		List<DnsSrvRecord> list = new List<DnsSrvRecord>();
		foreach (RecordSrv item in _resolver.Query(ServiceName, QuestionType.SRV, QuestionClass.IN).RecordSrv)
		{
			list.Add(item);
		}
		if (list.Count <= 0)
		{
			throw new MySqlException(string.Format(Resources.DnsSrvNoHostsAvailable, ServiceName));
		}
		Reset();
		return SortSrvRecords(list);
	}

	internal static List<DnsSrvRecord> SortSrvRecords(List<DnsSrvRecord> srvRecords)
	{
		srvRecords.Sort(new DnsSrvRecord());
		Random random = new Random();
		List<DnsSrvRecord> list = new List<DnsSrvRecord>();
		foreach (int priority in srvRecords.Select((DnsSrvRecord s) => s.Priority).Distinct().ToList())
		{
			List<DnsSrvRecord> list2 = srvRecords.Where((DnsSrvRecord r) => r.Priority == priority).ToList();
			while (list2.Count > 1)
			{
				int count = list2.Count;
				int num = 0;
				int[] array = new int[count];
				for (int i = 0; i < count; i++)
				{
					num = (array[i] = num + list2[i].Weight);
				}
				int num2 = random.Next(num + 1);
				int j;
				for (j = 0; j < count && array[j] < num2; j++)
				{
				}
				list.Add(list2[j]);
				list2.RemoveAt(j);
			}
			list.Add(list2[0]);
		}
		return list;
	}

	private static void Reset()
	{
		if (_resolver != null)
		{
			_resolver = null;
		}
	}
}
