using System;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace triPOS_vbnet;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
public class SignaturePoint
{
	public static readonly SignaturePoint PenUp = new SignaturePoint(-1, -1);

	public static readonly SignaturePoint Empty = new SignaturePoint(0, 0);

	private short m_X;

	private short m_Y;

	public short X
	{
		get
		{
			return m_X;
		}
		set
		{
			m_X = value;
		}
	}

	public short Y
	{
		get
		{
			return m_Y;
		}
		set
		{
			m_Y = value;
		}
	}

	public Point Point => new Point(X, Y);

	public bool IsPenUp => Equals(PenUp);

	public bool IsEmpty => Equals(Empty);

	public SignaturePoint(short x, short y)
	{
		X = x;
		Y = y;
	}

	public SignaturePoint(int x, int y)
	{
		checked
		{
			this._002Ector((short)x, (short)y);
		}
	}

	public SignaturePoint(SignaturePoint point)
		: this(point.X, point.Y)
	{
	}

	public SignaturePoint(byte[] data, int index, bool bigEndian)
		: this((SignaturePoint)ByteArrayToStructure(data, index, typeof(SignaturePoint)))
	{
		if (bigEndian)
		{
			X = IPAddress.NetworkToHostOrder(X);
			Y = IPAddress.NetworkToHostOrder(Y);
		}
	}

	public SignaturePoint()
		: this(Empty)
	{
	}

	public override bool Equals(object obj)
	{
		return ((SignaturePoint)obj).X == X && ((SignaturePoint)obj).Y == Y;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		return Conversions.ToString(Conversions.ToDouble("{") + (double)X + Conversions.ToDouble(",") + (double)Y + Conversions.ToDouble("}"));
	}

	private static object ByteArrayToStructure(byte[] source, int sourceIndex, Type destinationType, int length = 0)
	{
		if (length <= 0)
		{
			length = Marshal.SizeOf(destinationType);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(length);
		Marshal.Copy(source, sourceIndex, intPtr, length);
		object objectValue = RuntimeHelpers.GetObjectValue(Marshal.PtrToStructure(intPtr, destinationType));
		Marshal.FreeHGlobal(intPtr);
		return objectValue;
	}
}
