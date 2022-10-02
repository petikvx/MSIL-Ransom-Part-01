using System.IO;

internal class Class44
{
	public static MemoryStream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		int num2 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		bool flag = default(bool);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = Class40.Class41.smethod_4(23);
			while (true)
			{
				switch (num)
				{
				case 9:
					num2 = binaryReader.ReadUInt16();
					num = 3;
					goto case 3;
				case 3:
					array = new byte[num2];
					num = 1;
					goto case 1;
				case 1:
					binaryReader.Read(array, 0, num2);
					num = 2;
					goto case 2;
				case 2:
					array2 = new byte[4];
					num = 6;
					goto case 6;
				case 6:
					binaryReader.Read(array2, 0, 4);
					num = 5;
					goto case 5;
				case 5:
					num3 = 0;
					num = 4;
					goto case 4;
				case 4:
					if (num3 != 0)
					{
						goto IL_0050;
					}
					goto IL_00b0;
				case 8:
					binaryReader.ReadBoolean();
					num = 7;
					goto case 7;
				case 7:
					flag = binaryReader.ReadBoolean();
					num = 9;
					goto case 9;
				case 0:
					array[num3] = (byte)(array[num3] ^ array2[num3 % 4]);
					num = 10;
					goto case 10;
				case 10:
					{
						num3++;
						goto IL_00b0;
					}
					IL_00b0:
					if (num3 >= num2)
					{
						while (true)
						{
							int num4 = Class40.Class41.smethod_4(18);
							while (true)
							{
								switch (num4)
								{
								case 2:
									goto IL_00d2;
								case 0:
									new BinaryReader(new MemoryStream(array, writable: false)).ReadString();
									num4 = 2;
									goto IL_00d2;
								case 1:
									if (flag)
									{
										num4 = 3;
									}
									else if (true)
									{
										smethod_1(binaryReader.BaseStream, memoryStream);
										goto IL_0147;
									}
									goto case 3;
								case 3:
									{
										Class40.smethod_0(binaryReader.BaseStream, memoryStream);
										goto IL_0147;
									}
									IL_0147:
									memoryStream.Position = 0L;
									return memoryStream;
								}
								break;
								IL_00d2:
								memoryStream = new MemoryStream();
								num4 = Class40.Class41.smethod_4(14);
							}
						}
					}
					goto case 0;
				}
				break;
				IL_0050:
				num = Class40.Class41.smethod_4(18);
			}
		}
	}

	private static void smethod_1(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		while (true)
		{
			int num = stream_0.Read(array, 0, array.Length);
			if (num > 0)
			{
				stream_1.Write(array, 0, num);
				continue;
			}
			break;
		}
	}
}
