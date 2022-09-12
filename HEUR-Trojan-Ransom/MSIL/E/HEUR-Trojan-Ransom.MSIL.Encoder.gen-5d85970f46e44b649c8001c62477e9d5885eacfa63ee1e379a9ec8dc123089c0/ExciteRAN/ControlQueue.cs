using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ExciteRAN;

internal sealed class ControlQueue
{
	internal static readonly byte[] lastHandler;

	internal readonly int urlHeader;

	static ControlQueue()
	{
		if (lastHandler != null)
		{
			return;
		}
		while (true)
		{
			switch (2)
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
			lastHandler = PcitureStack.InsertProcess(97L, manifestResourceStream);
			return;
		}
	}

	internal static int ResolveMenuItem(int P_0)
	{
		return BitConverter.ToInt32(lastHandler, P_0);
	}

	internal static long ChangeEditor(int P_0)
	{
		return BitConverter.ToInt64(lastHandler, P_0);
	}

	internal static float OrderPane(int P_0)
	{
		return BitConverter.ToSingle(lastHandler, P_0);
	}

	internal static double CloneMethod(int P_0)
	{
		return BitConverter.ToDouble(lastHandler, P_0);
	}

	internal static void ReplaceDevice(Array P_0, int P_1)
	{
		int num = 0;
		if ((lastHandler[P_1] & 0x80) == 0)
		{
			while (true)
			{
				switch (5)
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
			num = lastHandler[P_1];
			P_1++;
		}
		else if ((lastHandler[P_1] & 0x40) == 0)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (lastHandler[P_1] & -129) << 8;
			num |= lastHandler[P_1 + 1];
			P_1 += 2;
		}
		else
		{
			num = (lastHandler[P_1] & -193) << 24;
			num |= lastHandler[P_1 + 1] << 16;
			num |= lastHandler[P_1 + 2] << 8;
			num |= lastHandler[P_1 + 3];
			P_1 += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
		Buffer.BlockCopy(lastHandler, P_1, P_0, 0, num);
	}
}
