using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace triPOS_vbnet;

public class SignatureBuild
{
	public enum SignatureFormat
	{
		Ascii3Byte,
		PointsBigEndian,
		PointsLittleEndian
	}

	private string format;

	private SignaturePoint maximumSignaturePoint;

	private SignaturePoint minimumSignaturePoint;

	private SignatureFormat sigFormat;

	private SignaturePoint[] signaturePoints;

	public SignatureBuild()
	{
		format = string.Empty;
	}

	public Bitmap GetSignatureBitmap(int padding)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		checked
		{
			if (signaturePoints != null)
			{
				Bitmap val = new Bitmap((short)unchecked(maximumSignaturePoint.X - minimumSignaturePoint.X) + padding * 2, (short)unchecked(maximumSignaturePoint.Y - minimumSignaturePoint.Y) + padding * 2);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.Clear(Color.White);
				Pen val3 = new Pen(Color.Red, 1.8f);
				SignaturePoint signaturePoint = SignaturePoint.PenUp;
				SignaturePoint[] array = signaturePoints;
				foreach (SignaturePoint signaturePoint2 in array)
				{
					if (!signaturePoint2.IsPenUp && !signaturePoint.IsPenUp)
					{
						int num = (short)unchecked(signaturePoint.X - minimumSignaturePoint.X) + padding;
						int num2 = (short)unchecked(signaturePoint.Y - minimumSignaturePoint.Y) + padding;
						int num3 = (short)unchecked(signaturePoint2.X - minimumSignaturePoint.X) + padding;
						int num4 = (short)unchecked(signaturePoint2.Y - minimumSignaturePoint.Y) + padding;
						val2.DrawLine(val3, num, num2, num3, num4);
					}
					signaturePoint = signaturePoint2;
				}
				return val;
			}
			return null;
		}
	}

	public void SetData(byte[] data)
	{
		switch (sigFormat)
		{
		default:
			signaturePoints = null;
			break;
		case SignatureFormat.PointsBigEndian:
		case SignatureFormat.PointsLittleEndian:
			ConvertPoints(data, 0);
			break;
		case SignatureFormat.Ascii3Byte:
			ConvertAscii3Byte(data);
			break;
		}
	}

	public void SetFormat(string formatInput)
	{
		format = formatInput;
		switch (format)
		{
		default:
			signaturePoints = null;
			break;
		case "PointsLittleEndian":
			sigFormat = SignatureFormat.PointsLittleEndian;
			break;
		case "PointsBigEndian":
			sigFormat = SignatureFormat.PointsBigEndian;
			break;
		case "Ascii3Byte":
			sigFormat = SignatureFormat.Ascii3Byte;
			break;
		}
	}

	private void ConvertAscii3Byte(byte[] data)
	{
		signaturePoints = null;
		List<SignaturePoint> list = new List<SignaturePoint>();
		minimumSignaturePoint = new SignaturePoint(short.MaxValue, short.MaxValue);
		maximumSignaturePoint = new SignaturePoint(short.MinValue, short.MinValue);
		SignaturePoint signaturePoint = SignaturePoint.Empty;
		checked
		{
			int num = data.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (data[num2] == 112)
					{
						list.Add(SignaturePoint.PenUp);
						signaturePoint = SignaturePoint.Empty;
					}
					else if (data[num2] >= 96 && data[num2] <= 111)
					{
						if (data.Length - num2 < 4)
						{
							throw new Exception("Invalid input data!");
						}
						signaturePoint = new SignaturePoint((short)((((unchecked((int)data[num2]) - 96) & 0xC) << 7) | (unchecked((int)data[checked(num2 + 1)]) - 32 << 3) | (((unchecked((int)data[checked(num2 + 3)]) - 32) & 0x38) >> 3)), (short)((((unchecked((int)data[num2]) - 96) & 3) << 9) | (unchecked((int)data[checked(num2 + 2)]) - 32 << 3) | ((unchecked((int)data[checked(num2 + 3)]) - 32) & 7)));
						num2 += 3;
						if (list.Count == 0)
						{
							list.Add(SignaturePoint.PenUp);
						}
						list.Add(new SignaturePoint(signaturePoint.X, signaturePoint.Y));
						SetMinMaxSignaturePoint(signaturePoint);
					}
					else
					{
						if (data.Length - num2 < 3)
						{
							break;
						}
						short num3 = (short)(unchecked((short)(checked((short)(unchecked((int)data[num2]) - 32)) << 3)) | (((short)(unchecked((int)data[checked(num2 + 2)]) - 32) & 0x38) >> 3));
						num3 = unchecked((short)((short)(num3 << 7) >> 7));
						num2++;
						short num4 = (short)(unchecked((short)(checked((short)(unchecked((int)data[num2]) - 32)) << 3)) | ((short)(unchecked((int)data[checked(num2 + 1)]) - 32) & 7));
						num4 = unchecked((short)((short)(num4 << 7) >> 7));
						num2++;
						SignaturePoint signaturePoint2;
						(signaturePoint2 = signaturePoint).X = (short)unchecked(signaturePoint2.X + num3);
						(signaturePoint2 = signaturePoint).Y = (short)unchecked(signaturePoint2.Y + num4);
						if (list.Count == 0)
						{
							list.Add(SignaturePoint.PenUp);
						}
						list.Add(new SignaturePoint(signaturePoint.X, signaturePoint.Y));
						SetMinMaxSignaturePoint(signaturePoint);
					}
					num2++;
					continue;
				}
				signaturePoints = list.ToArray();
				SignaturePoint[] array = signaturePoints;
				foreach (SignaturePoint signaturePoint3 in array)
				{
					if (!signaturePoint3.IsPenUp)
					{
						signaturePoint3.Y = (short)unchecked(checked((short)unchecked(maximumSignaturePoint.Y - signaturePoint3.Y)) + minimumSignaturePoint.Y);
					}
				}
				return;
			}
			throw new Exception("Invalid input data!");
		}
	}

	private void ConvertPoints(byte[] data, int startIndex)
	{
		signaturePoints = null;
		List<SignaturePoint> list = new List<SignaturePoint>();
		minimumSignaturePoint = new SignaturePoint(short.MaxValue, short.MaxValue);
		maximumSignaturePoint = new SignaturePoint(short.MinValue, short.MinValue);
		SignaturePoint empty = SignaturePoint.Empty;
		checked
		{
			for (int i = startIndex; i < data.Length; i += Marshal.SizeOf(typeof(SignaturePoint)))
			{
				if (data.Length - i >= Marshal.SizeOf(typeof(SignaturePoint)))
				{
					empty = new SignaturePoint(data, i, sigFormat == SignatureFormat.PointsBigEndian);
					list.Add(empty);
					if (!empty.IsPenUp)
					{
						SetMinMaxSignaturePoint(empty);
					}
				}
			}
			signaturePoints = list.ToArray();
		}
	}

	private void SetMinMaxSignaturePoint(SignaturePoint signaturePoint)
	{
		if (signaturePoint.X > maximumSignaturePoint.X)
		{
			maximumSignaturePoint.X = signaturePoint.X;
		}
		if (signaturePoint.X < minimumSignaturePoint.X)
		{
			minimumSignaturePoint.X = signaturePoint.X;
		}
		if (signaturePoint.Y > maximumSignaturePoint.Y)
		{
			maximumSignaturePoint.Y = signaturePoint.Y;
		}
		if (signaturePoint.Y < minimumSignaturePoint.Y)
		{
			minimumSignaturePoint.Y = signaturePoint.Y;
		}
	}
}
