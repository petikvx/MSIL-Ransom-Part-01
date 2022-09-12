using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ExciteRAN;

internal class StoreType
{
	internal static readonly byte[] windowPosition;

	internal readonly int parentLog;

	static StoreType()
	{
		if (windowPosition != null)
		{
			return;
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "RXhjaXRlUkFOJQ==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			windowPosition = StreamTree.SaveFile(97L, manifestResourceStream);
			return;
		}
	}

	internal static int RegisterNode(int windowPosition)
	{
		return BitConverter.ToInt32(StoreType.windowPosition, windowPosition);
	}

	internal static long SortCommand(int windowPosition)
	{
		return BitConverter.ToInt64(StoreType.windowPosition, windowPosition);
	}

	internal static float EnableForm(int windowPosition)
	{
		return BitConverter.ToSingle(StoreType.windowPosition, windowPosition);
	}

	internal static double ProcessTemplate(int windowPosition)
	{
		return BitConverter.ToDouble(StoreType.windowPosition, windowPosition);
	}

	internal static void JoinServer(Array windowPosition, int parentLog)
	{
		int num = 0;
		if ((StoreType.windowPosition[parentLog] & 0x80) == 0)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = StoreType.windowPosition[parentLog];
			parentLog++;
		}
		else if ((StoreType.windowPosition[parentLog] & 0x40) == 0)
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (StoreType.windowPosition[parentLog] & -129) << 8;
			num |= StoreType.windowPosition[parentLog + 1];
			parentLog += 2;
		}
		else
		{
			num = (StoreType.windowPosition[parentLog] & -193) << 24;
			num |= StoreType.windowPosition[parentLog + 1] << 16;
			num |= StoreType.windowPosition[parentLog + 2] << 8;
			num |= StoreType.windowPosition[parentLog + 3];
			parentLog += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
		Buffer.BlockCopy(StoreType.windowPosition, parentLog, windowPosition, 0, num);
	}
}
