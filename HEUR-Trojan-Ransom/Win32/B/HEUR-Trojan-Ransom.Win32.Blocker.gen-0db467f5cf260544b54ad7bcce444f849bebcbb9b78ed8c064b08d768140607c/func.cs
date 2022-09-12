using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class func
{
	public static byte[] VisibilityState_003CFixedUpdate_003Eb__4_0Awake
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			Bitmap val = new Bitmap(innocuousImg);
			int num = 0;
			byte[] array = new byte[3 * ((Image)val).get_Width() * ((Image)val).get_Height()];
			for (int i = 0; i < ((Image)val).get_Height(); i++)
			{
				for (int j = 0; j < ((Image)val).get_Width(); j++)
				{
					Color pixel = val.GetPixel(j, i);
					array[num++] = pixel.R;
					array[num++] = pixel.G;
					array[num++] = pixel.B;
				}
			}
			return array;
		}
	}

	public static Bitmap Directoryset_MemberSinceExecute
	{
		set
		{
			int width = ((Image)value).get_Width();
			byte[] array = new byte[width * width * 4];
			int num = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(value.GetPixel(i, j).ToArgb()), 0, array, num, 4);
					num += 4;
				}
			}
			byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
			Buffer.BlockCopy(array, 4, array2, 0, array2.Length);
			return array2;
		}
	}

	public static Image unloadPluginsUnloadget_Directory(byte[] bytes)
	{
		using MemoryStream memoryStream = new MemoryStream(bytes);
		return Image.FromStream((Stream)memoryStream);
	}

	public static Bitmap ParseUInt32getCommandTypeGetAssembliesFromDirectory(byte[] rgbComponents, int width, int hight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		Queue<byte> queue = new Queue<byte>(rgbComponents);
		Bitmap val = new Bitmap(width, hight);
		for (int i = 0; i < hight; i++)
		{
			for (int j = 0; j < width; j++)
			{
				val.SetPixel(j, i, Color.FromArgb(queue.Dequeue(), queue.Dequeue(), queue.Dequeue()));
			}
		}
		return val;
	}

	public static byte[] GetTypesFromParentClassget_AliasesAwake(Image imageFileName)
	{
		byte[] innocuousLookingData = func.get_VisibilityState_003CFixedUpdate_003Eb__4_0Awake(imageFileName);
		int byteCount = BitConverter.ToInt32(Awakeget_MemberSince_invoke(innocuousLookingData, 0, 4), 0);
		return Awakeget_MemberSince_invoke(innocuousLookingData, 4, byteCount);
	}

	private static byte[] Awakeget_MemberSince_invoke(byte[] innocuousLookingData, int byteIndex, int byteCount)
	{
		int num = byteCount * 8;
		int num2 = byteIndex * 8;
		bool[] array = new bool[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = (int)innocuousLookingData[i + num2] % 2 == 1;
		}
		BitArray bitArray = new BitArray(array);
		byte[] array2 = new byte[bitArray.Length / 8];
		bitArray.CopyTo(array2, 0);
		return array2;
	}
}
