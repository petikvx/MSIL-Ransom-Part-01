using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace p80hVGtz;

internal class vRvDyS3Z
{
	internal static bool KE94ovRt(object object_0, object object_1, object object_2, object object_3, ref object object_4, ref object object_5, int int_0)
	{
		return (int_0 ^ 0x5C40) switch
		{
			_ => ForLoopControl.ForLoopInitObj(object_0, object_1, object_2, object_3, ref object_4, ref object_5), 
		};
	}

	internal static bool m3io0jnW(object object_0, object object_1, ref object object_2, int int_0)
	{
		return (int_0 ^ 0xC9B8) switch
		{
			_ => ForLoopControl.ForNextCheckObj(object_0, object_1, ref object_2), 
		};
	}

	internal static string RaPIakol(bool bool_0, int int_0)
	{
		return (int_0 ^ 0xA558) switch
		{
			_ => Conversions.ToString(bool_0), 
		};
	}

	internal static NumberFormatInfo smethod_0(CultureInfo cultureInfo_0, int int_0)
	{
		return (int_0 ^ 0x9D6D) switch
		{
			_ => cultureInfo_0.NumberFormat, 
		};
	}

	internal static float erQzpN5j(string string_0, IFormatProvider iformatProvider_0, int int_0)
	{
		return (int_0 ^ 0x8FED) switch
		{
			_ => Convert.ToSingle(string_0, iformatProvider_0), 
		};
	}

	internal static void wzXEPY8o(StreamWriter streamWriter_0, int int_0)
	{
		switch (int_0 ^ 0xE230)
		{
		}
		streamWriter_0.Flush();
	}

	internal static void scoOYfGp(TcpClient tcpClient_0, string string_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x5E98)
		{
		}
		tcpClient_0.Connect(string_0, int_0);
	}

	internal static DialogResult gNX0QwTV(string string_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0x8E86) switch
		{
			_ => MessageBox.Show(string_0), 
		});
	}

	internal static void r89ztNx4(Thread thread_0, int int_0)
	{
		switch (int_0 ^ 0xC74C)
		{
		default:
			thread_0.Start();
			break;
		case 1:
			thread_0.Abort();
			break;
		}
	}

	internal static void smethod_1(Thread thread_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x1997)
		{
		}
		thread_0.Name = string_0;
	}

	internal static bool ghSn2ObZ(TcpClient tcpClient_0, int int_0)
	{
		return (int_0 ^ 0x8789) switch
		{
			_ => tcpClient_0.Connected, 
		};
	}

	internal static NetworkStream LqjCQ5t0(TcpClient tcpClient_0, int int_0)
	{
		return (int_0 ^ 0xA46F) switch
		{
			_ => tcpClient_0.GetStream(), 
		};
	}

	internal static void G1cHOzUE(TcpClient tcpClient_0, int int_0)
	{
		switch (int_0 ^ 0x8C74)
		{
		}
		tcpClient_0.Close();
	}

	internal static bool FkJs352v(Thread thread_0, int int_0)
	{
		return (int_0 ^ 0x148) switch
		{
			_ => thread_0.IsAlive, 
		};
	}

	internal static void hOJzEwSC(int int_0, int int_1)
	{
		switch (int_1 ^ 0x8FAC)
		{
		}
		Thread.Sleep(int_0);
	}

	internal static MsgBoxResult WaN2uVeZ(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (MsgBoxResult)((int_0 ^ 0x85FB) switch
		{
			_ => Interaction.MsgBox(object_0, msgBoxStyle_0, object_1), 
		});
	}

	internal static object smethod_2(Control control_0, Delegate delegate_0, object[] object_0, int int_0)
	{
		return (int_0 ^ 0xCA4A) switch
		{
			_ => control_0.Invoke(delegate_0, object_0), 
		};
	}

	internal static void mdII4JVG(BinaryFormatter binaryFormatter_0, Stream stream_0, object object_0, int int_0)
	{
		switch (int_0 ^ 0x4A47)
		{
		}
		binaryFormatter_0.Serialize(stream_0, object_0);
	}

	internal static void oNl1lUma(Stream stream_0, int int_0)
	{
		switch (int_0 ^ 0x4B52)
		{
		}
		stream_0.Close();
	}

	internal static object smethod_3(BinaryFormatter binaryFormatter_0, Stream stream_0, int int_0)
	{
		return (int_0 ^ 0xC04C) switch
		{
			_ => binaryFormatter_0.Deserialize(stream_0), 
		};
	}
}
