using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Jg5;
using Lk5;
using Ma2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using j0;
using o8F;

namespace d1Y;

public class q1S
{
	internal sealed class Sg9
	{
		internal object x;

		internal Sg9()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Jy4
	{
		internal TrackBar Y;

		internal TextBox v;

		internal TextBox a;

		internal TextBox i;

		internal TextBox N;

		internal TabControl j;

		internal TabPage f;
	}

	private object m_S;

	private object m_b;

	private string m_W;

	private string q;

	private string y;

	private object N;

	private object o;

	private object t;

	private Gw.Qd i;

	public string O
	{
		get
		{
			return i.v;
		}
		set
		{
			i.v = value;
		}
	}

	public string f
	{
		get
		{
			return this.m_W;
		}
		set
		{
			this.m_W = value;
		}
	}

	public string W
	{
		get
		{
			return q;
		}
		set
		{
			q = value;
		}
	}

	public string r
	{
		get
		{
			return y;
		}
		set
		{
			y = value;
		}
	}

	public object x
	{
		get
		{
			return i.a;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			i.a = objectValue;
		}
	}

	public object S
	{
		get
		{
			return N;
		}
		set
		{
			N = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object b
	{
		get
		{
			return o;
		}
		set
		{
			o = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object U
	{
		get
		{
			return t;
		}
		set
		{
			t = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static void s3S()
	{
		throw new NotImplementedException();
	}

	private void o3W(object sender, EventArgs e)
	{
		n6E.e7Y();
	}

	private void k7N(object sender, EventArgs e)
	{
		Ni3.e4G();
	}

	private void s2R(object sender, EventArgs e)
	{
		Fr7.k6A();
	}

	private void Nj4(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(x, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void o6A(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(i.Y, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void n8G(object sender, EventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		k0H();
		object obj = "insert into log values(uuid_short(), '" + O + "','Logout', current_timestamp())";
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { S }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { (string)obj }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			ISerializable serializable = ex;
			Interaction.MsgBox((object)((Exception)serializable).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		f9M();
		NewLateBinding.LateCall(b, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Kk8();
	}

	private void Kk8()
	{
		throw new NotImplementedException();
	}

	private void f9M()
	{
		throw new NotImplementedException();
	}

	private void k0H()
	{
		throw new NotImplementedException();
	}

	private void c6W(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(U, (Type)null, "Text", new object[1] { f + " " + W }, (string[])null, (Type[])null, false, true);
	}

	private void x9F(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(this.m_S, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void d2X(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(this.m_b, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static void Ds9(Cf7.Xq4 xq4_0, int int_0)
	{
		object obj = new byte[16];
		int num = 0;
		checked
		{
			while (num < 16)
			{
				if (num == 0)
				{
					((byte[])obj)[num] = (byte)num;
					(obj as byte[])[num + 1] = (byte)Math.Abs(int_0);
				}
				else if (num > 1)
				{
					((byte[])obj)[num] = (byte)Math.Abs(int_0 + 53);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			xq4_0.c = obj as byte[];
			n6E.Qp9(xq4_0, xq4_0.c, 255);
		}
	}
}
