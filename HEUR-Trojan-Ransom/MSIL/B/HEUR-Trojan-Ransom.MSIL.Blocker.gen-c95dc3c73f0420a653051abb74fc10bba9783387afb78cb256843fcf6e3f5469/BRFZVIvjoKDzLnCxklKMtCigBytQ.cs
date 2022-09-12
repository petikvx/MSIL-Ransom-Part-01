using System;

internal class BRFZVIvjoKDzLnCxklKMtCigBytQ
{
	public static int WPoQjPPCNooVamvyPaHmkiFrHUCc()
	{
		string text = JLYZweHMBzUemxKAFQAkQfAoGNSb.hxNbOKyxbxNBDTOuFEHjfddIABTeA();
		int length = text.Length;
		byte[] array = new byte[length];
		int num = 0;
		int length2 = text.Length;
		checked
		{
			for (int i = 0; i < length2; i++)
			{
				char c = text[i];
				switch (c)
				{
				case ']':
					array[num] = 108;
					num++;
					continue;
				case '[':
					array[num] = 104;
					num++;
					continue;
				case ' ':
					array[num++] = 146;
					continue;
				case '!':
					array[num] = 148;
					num++;
					continue;
				case '#':
					array[num] = 152;
					num++;
					for (; i < text.Length && text[i] != ' '; i++)
					{
					}
					continue;
				case '*':
					array[num] = 110;
					num++;
					continue;
				case '-':
					array[num] = 140;
					num++;
					continue;
				case '0':
					array[num] = 178;
					num++;
					continue;
				case '1':
					array[num] = 180;
					num++;
					continue;
				case '2':
					array[num] = 182;
					num++;
					continue;
				case '3':
					array[num] = 184;
					num++;
					continue;
				case '4':
					array[num] = 186;
					num++;
					continue;
				case '5':
					array[num] = 188;
					num++;
					continue;
				case '6':
					array[num] = 190;
					num++;
					continue;
				case '7':
					array[num] = 160;
					num++;
					continue;
				case '8':
					array[num] = 162;
					num++;
					continue;
				case '9':
					array[num] = 164;
					num++;
					continue;
				case '<':
					array[num] = 170;
					num++;
					continue;
				case '=':
					array[num] = 172;
					num++;
					continue;
				case '>':
					array[num] = 174;
					num++;
					continue;
				case '\n':
				case '\r':
					array[num++] = 204;
					continue;
				default:
					if (c == Convert.ToChar(13) || c == Convert.ToChar(10) || c != '@')
					{
						continue;
					}
					break;
				}
				array[num] = 210;
				num++;
				break;
			}
			Console.WriteLine("List size : [" + num + "]  <> Full list size : [" + length + "]");
			return num;
		}
	}
}
