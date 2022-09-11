using System.IO;

internal class Class47
{
	public static MemoryStream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		int num2 = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = Class43.smethod_1(38);
			while (true)
			{
				switch (num)
				{
				case 8:
					num2 = binaryReader.ReadUInt16();
					num = 4;
					goto IL_0013;
				case 4:
					goto IL_0013;
				case 5:
					flag = binaryReader.ReadBoolean();
					num = 8;
					goto case 8;
				case 2:
					binaryReader.ReadBoolean();
					num = 5;
					goto case 5;
				case 6:
					binaryReader.Read(array, 0, num2);
					num = 7;
					goto case 7;
				case 7:
					array2 = new byte[4];
					num = 3;
					goto case 3;
				case 3:
					binaryReader.Read(array2, 0, 4);
					num = 0;
					goto case 0;
				case 0:
					num3 = 0;
					num = 1;
					goto case 1;
				case 1:
					if (num3 == 0)
					{
						goto IL_00b7;
					}
					num = 9;
					goto case 9;
				case 10:
					num3++;
					goto IL_00b7;
				case 9:
					{
						array[num3] = (byte)(array[num3] ^ array2[num3 % 4]);
						num = 10;
						goto case 10;
					}
					IL_00b7:
					if (num3 >= num2)
					{
						while (true)
						{
							int num4 = Class43.smethod_1(38);
							while (true)
							{
								switch (num4)
								{
								case 2:
									new BinaryReader(new MemoryStream(array, writable: false)).ReadString();
									num4 = 0;
									goto IL_00e8;
								case 0:
									goto IL_00e8;
								case 1:
									if (flag)
									{
										num4 = 3;
									}
									else if (true)
									{
										smethod_1(binaryReader.BaseStream, memoryStream);
										goto IL_0144;
									}
									goto case 3;
								case 3:
									{
										Class43.smethod_0(binaryReader.BaseStream, memoryStream);
										goto IL_0144;
									}
									IL_0144:
									memoryStream.Position = 0L;
									return memoryStream;
								}
								break;
								IL_00e8:
								memoryStream = new MemoryStream();
								num4 = Class43.smethod_1(37);
							}
						}
					}
					goto case 9;
				}
				break;
				IL_0013:
				array = new byte[num2];
				num = Class43.smethod_1(49);
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
