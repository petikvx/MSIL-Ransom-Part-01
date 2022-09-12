using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class OutputWindow
{
	private byte[] hFKtVmJVfLiWcGHRwKbIKFcZaWyt = new byte[32768];

	private int OrKBXxOackLvqOEOUzRjisytcdew;

	private int HvalecTXTDwngvbHvCNacigrrqWF;

	private const int VALsvuAdyJtBZrPfoVAJlUnCUfFf = 32767;

	private const int jDBSNCGjquesdZoiNRgbCBlTfXfCA = 32768;

	public void CopyDict(byte[] dictionary, int offset, int length)
	{
		if (dictionary != null)
		{
			if (HvalecTXTDwngvbHvCNacigrrqWF > 0)
			{
				throw new InvalidOperationException();
			}
			if (length > 32768)
			{
				offset += length - 32768;
				length = 32768;
			}
			Array.Copy(dictionary, offset, hFKtVmJVfLiWcGHRwKbIKFcZaWyt, 0, length);
			OrKBXxOackLvqOEOUzRjisytcdew = length & 0x7FFF;
			return;
		}
		throw new ArgumentNullException("dictionary");
	}

	public int CopyOutput(byte[] output, int offset, int int_0)
	{
		int num = OrKBXxOackLvqOEOUzRjisytcdew;
		if (int_0 <= HvalecTXTDwngvbHvCNacigrrqWF)
		{
			num = (OrKBXxOackLvqOEOUzRjisytcdew - HvalecTXTDwngvbHvCNacigrrqWF + int_0) & 0x7FFF;
		}
		else
		{
			int_0 = HvalecTXTDwngvbHvCNacigrrqWF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, 32768 - num3, output, offset, num3);
			offset += num3;
			int_0 = num;
		}
		Array.Copy(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, num - int_0, output, offset, int_0);
		HvalecTXTDwngvbHvCNacigrrqWF -= num2;
		if (HvalecTXTDwngvbHvCNacigrrqWF < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	public int CopyStored(StreamManipulator input, int length)
	{
		length = Math.Min(Math.Min(length, 32768 - HvalecTXTDwngvbHvCNacigrrqWF), input.AvailableBytes);
		int num = 32768 - OrKBXxOackLvqOEOUzRjisytcdew;
		int num2;
		if (length <= num)
		{
			num2 = input.CopyBytes(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, OrKBXxOackLvqOEOUzRjisytcdew, length);
		}
		else
		{
			num2 = input.CopyBytes(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, OrKBXxOackLvqOEOUzRjisytcdew, num);
			if (num2 == num)
			{
				num2 += input.CopyBytes(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, 0, length - num);
			}
		}
		OrKBXxOackLvqOEOUzRjisytcdew = (OrKBXxOackLvqOEOUzRjisytcdew + num2) & 0x7FFF;
		HvalecTXTDwngvbHvCNacigrrqWF += num2;
		return num2;
	}

	public int GetAvailable()
	{
		return HvalecTXTDwngvbHvCNacigrrqWF;
	}

	public int GetFreeSpace()
	{
		return 32768 - HvalecTXTDwngvbHvCNacigrrqWF;
	}

	public void Repeat(int length, int distance)
	{
		HvalecTXTDwngvbHvCNacigrrqWF += length;
		if (HvalecTXTDwngvbHvCNacigrrqWF <= 32768)
		{
			int num = (OrKBXxOackLvqOEOUzRjisytcdew - distance) & 0x7FFF;
			int num2 = 32768 - length;
			if (num <= num2 && OrKBXxOackLvqOEOUzRjisytcdew < num2)
			{
				if (length <= distance)
				{
					Array.Copy(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, num, hFKtVmJVfLiWcGHRwKbIKFcZaWyt, OrKBXxOackLvqOEOUzRjisytcdew, length);
					OrKBXxOackLvqOEOUzRjisytcdew += length;
				}
				else
				{
					while (length-- > 0)
					{
						hFKtVmJVfLiWcGHRwKbIKFcZaWyt[OrKBXxOackLvqOEOUzRjisytcdew++] = hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num++];
					}
				}
			}
			else
			{
				GuxAZmrRKMEkIcgKVjHGgzMbDzPeb(num, length, distance);
			}
			return;
		}
		throw new InvalidOperationException("Window full");
	}

	public void Reset()
	{
		OrKBXxOackLvqOEOUzRjisytcdew = 0;
		HvalecTXTDwngvbHvCNacigrrqWF = 0;
	}

	private void GuxAZmrRKMEkIcgKVjHGgzMbDzPeb(int repStart, int length, int distance)
	{
		while (length-- > 0)
		{
			hFKtVmJVfLiWcGHRwKbIKFcZaWyt[OrKBXxOackLvqOEOUzRjisytcdew++] = hFKtVmJVfLiWcGHRwKbIKFcZaWyt[repStart++];
			OrKBXxOackLvqOEOUzRjisytcdew &= 32767;
			repStart &= 0x7FFF;
		}
	}

	public void Write(int value)
	{
		if (HvalecTXTDwngvbHvCNacigrrqWF++ == 32768)
		{
			throw new InvalidOperationException("Window full");
		}
		hFKtVmJVfLiWcGHRwKbIKFcZaWyt[OrKBXxOackLvqOEOUzRjisytcdew++] = (byte)value;
		OrKBXxOackLvqOEOUzRjisytcdew &= 32767;
	}
}
