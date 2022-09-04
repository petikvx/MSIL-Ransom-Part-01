using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class0
{
	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		checked
		{
			object obj = default(object);
			object obj2 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj, (object)(byte_0.Length * 2 + bytes.Length), (object)0, (object)(-1), ref obj2, ref obj))
			{
				do
				{
					byte_0[Conversions.ToInteger(Operators.ModObject(obj, (object)byte_0.Length))] = (byte)unchecked(checked((byte_0[Conversions.ToInteger(Operators.ModObject(obj, (object)byte_0.Length))] ^ bytes[Conversions.ToInteger(Operators.ModObject(obj, (object)bytes.Length))]) - unchecked((int)byte_0[Conversions.ToInteger(Operators.ModObject(Operators.AddObject(obj, (object)1), (object)byte_0.Length))]) + 256) % 256);
				}
				while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
			}
			return byte_0;
		}
	}
}
