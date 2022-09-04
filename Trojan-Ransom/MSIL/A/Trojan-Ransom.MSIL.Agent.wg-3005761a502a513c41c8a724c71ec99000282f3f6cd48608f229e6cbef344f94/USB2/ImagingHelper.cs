using System.Drawing;
using System.IO;
using ns0;

namespace USB2;

public static class ImagingHelper
{
	public static bool ConvertToIcon(Stream input, Stream output, int size = 16, bool preserveAspectRatio = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		Bitmap val = (Bitmap)Delegate198.smethod_0(input);
		if (val != null)
		{
			int num;
			int num2;
			if (preserveAspectRatio)
			{
				num = size;
				num2 = Delegate63.smethod_0(val) / Delegate184.smethod_0(val) * size;
			}
			else
			{
				num = (num2 = size);
			}
			Bitmap val2 = Delegate77.smethod_0((Image)(object)val, new Size(num, num2));
			if (val2 != null)
			{
				MemoryStream memoryStream = Delegate265.smethod_0();
				try
				{
					Delegate249.smethod_0(val2, memoryStream, Delegate37.smethod_0());
					BinaryWriter binaryWriter = Delegate88.smethod_0(output);
					if (output != null && binaryWriter != null)
					{
						Delegate47.smethod_0(binaryWriter, 0);
						Delegate47.smethod_0(binaryWriter, 0);
						Delegate342.smethod_0(binaryWriter, 1);
						Delegate342.smethod_0(binaryWriter, 1);
						Delegate47.smethod_0(binaryWriter, (byte)num);
						Delegate47.smethod_0(binaryWriter, (byte)num2);
						Delegate47.smethod_0(binaryWriter, 0);
						Delegate47.smethod_0(binaryWriter, 0);
						Delegate342.smethod_0(binaryWriter, 0);
						Delegate342.smethod_0(binaryWriter, 32);
						Delegate101.smethod_0(binaryWriter, (int)Delegate21.smethod_0(memoryStream));
						Delegate101.smethod_0(binaryWriter, 22);
						Delegate236.smethod_0(binaryWriter, Delegate302.smethod_0(memoryStream));
						Delegate114.smethod_0(binaryWriter);
						return true;
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						Delegate69.smethod_0(memoryStream);
					}
				}
			}
			return false;
		}
		return false;
	}

	public static bool ConvertToIcon(string inputPath, string outputPath, int size = 16, bool preserveAspectRatio = false)
	{
		FileStream fileStream = Delegate269.smethod_0(inputPath, FileMode.Open);
		try
		{
			FileStream fileStream2 = Delegate269.smethod_0(outputPath, FileMode.OpenOrCreate);
			try
			{
				return Delegate331.smethod_0(fileStream, fileStream2, size, preserveAspectRatio);
			}
			finally
			{
				if (fileStream2 != null)
				{
					Delegate69.smethod_0(fileStream2);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				Delegate69.smethod_0(fileStream);
			}
		}
	}
}
