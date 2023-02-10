using System.IO;

namespace WindowsLoader;

internal class PackageQueue
{
	internal static readonly byte[] idEnabled;

	static PackageQueue()
	{
		if (idEnabled != null)
		{
			return;
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string text = "V2luZG93cyBMb2FkZXIk";
			byte[] array = ActionSite.RemovePane(text);
			text = ConfigFactory.RemovePane(FormDesigner.RemovePane(), array, 0, array.Length);
			Stream nextUri = TemplateSite.RemovePane(Window.RemovePane(), text);
			idEnabled = VectorStack.RemovePane(97L, nextUri);
			return;
		}
	}

	internal static string RemovePane(int idEnabled)
	{
		int num = 0;
		if ((PackageQueue.idEnabled[idEnabled] & 0x80) == 0)
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
			num = PackageQueue.idEnabled[idEnabled];
			idEnabled++;
		}
		else if ((PackageQueue.idEnabled[idEnabled] & 0x40) == 0)
		{
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (PackageQueue.idEnabled[idEnabled] & -129) << 8;
			num |= PackageQueue.idEnabled[idEnabled + 1];
			idEnabled += 2;
		}
		else
		{
			num = (PackageQueue.idEnabled[idEnabled] & -193) << 24;
			num |= PackageQueue.idEnabled[idEnabled + 1] << 16;
			num |= PackageQueue.idEnabled[idEnabled + 2] << 8;
			num |= PackageQueue.idEnabled[idEnabled + 3];
			idEnabled += 4;
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
					return string.Empty;
				}
			}
		}
		string text = ConfigFactory.RemovePane(DriveConverter.RemovePane(), PackageQueue.idEnabled, idEnabled, num);
		return MemoryHelper.RemovePane(text);
	}
}
