using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

internal class JLYZweHMBzUemxKAFQAkQfAoGNSb
{
	public static string nmkOSMnchTcxZJeUhGzamLZueMYaA = ".\\List";

	private static PSYlgKfazHAcyVcUgFicYVxxVhCK.wVHHPyInIDISSSTNsozODXjhhLoA gbfKSfWStTHTgBadTqKkptAmVVPE = new PSYlgKfazHAcyVcUgFicYVxxVhCK.wVHHPyInIDISSSTNsozODXjhhLoA();

	private int qRXwrJVQybTFCuPogggogVgDPuXM = BRFZVIvjoKDzLnCxklKMtCigBytQ.WPoQjPPCNooVamvyPaHmkiFrHUCc();

	public static string hxNbOKyxbxNBDTOuFEHjfddIABTeA()
	{
		string s = File.ReadAllText(nmkOSMnchTcxZJeUhGzamLZueMYaA + ".pak");
		byte[] buffer = gbfKSfWStTHTgBadTqKkptAmVVPE.oueMBTgYsDIXzUONvcCrDTilrQsc(s);
		byte[] input = gbfKSfWStTHTgBadTqKkptAmVVPE.nHxBJzEWAiWisEfpsvuJncvIUVTcA(buffer);
		byte[] bytes = gbfKSfWStTHTgBadTqKkptAmVVPE.NUzHGuIXnBLOXZKcQQCrhqzJPkwc(input);
		return Encoding.Default.GetString(bytes);
	}

	public void WIzQtaoBPWInzejqcBnSiyhUlHFiA()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(nmkOSMnchTcxZJeUhGzamLZueMYaA + ".pak"))
		{
			Console.WriteLine("파일이 존재하지 않습니다. " + nmkOSMnchTcxZJeUhGzamLZueMYaA + ".pak");
			MessageBox.Show("파일이 존재하지 않습니다. " + nmkOSMnchTcxZJeUhGzamLZueMYaA + ".pak");
			return;
		}
		string text = hxNbOKyxbxNBDTOuFEHjfddIABTeA();
		int length = text.Length;
		byte[] array = new byte[length];
		int num = 0;
		byte[] bytes = BitConverter.GetBytes(qRXwrJVQybTFCuPogggogVgDPuXM);
		Array.Reverse((Array)bytes);
		byte[] array2 = bytes;
		num = 1;
		array[0] = array2[3];
		num = 2;
		array[1] = array2[2];
		num = 3;
		array[2] = array2[1];
		num = 4;
		array[3] = array2[0];
		num = 5;
		array[4] = 0;
		num = 6;
		array[5] = 0;
		num = 7;
		array[6] = 0;
		num = 8;
		array[7] = 0;
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
				default:
					if (c == Convert.ToChar(13) || c == Convert.ToChar(10) || c != '@')
					{
						continue;
					}
					break;
				case '\n':
				case '\r':
					array[num++] = 204;
					continue;
				}
				array[num] = 210;
				num++;
				break;
			}
			array[num++] = 0;
			array[num++] = 0;
			array[num++] = 0;
			array[num++] = 0;
			for (int j = 0; j < 128; j++)
			{
				array[num++] = gWVlZfpcCjARRCSdWzgamHHHNiTOA.DPluyTNUtLQNBpbbmVxEUvWbQGwp[j];
			}
			array[num++] = gWVlZfpcCjARRCSdWzgamHHHNiTOA.AiNLWwtXrVpDyaaGXaPTGyFLTLoT;
			array[num++] = gWVlZfpcCjARRCSdWzgamHHHNiTOA.yyvcENIUEhBxIezmLOvTWeRVAyIsA;
			array[num++] = gWVlZfpcCjARRCSdWzgamHHHNiTOA.rWOEIYDAqnPjJcJJHdnEbaZnzIkdb;
			array[num++] = gWVlZfpcCjARRCSdWzgamHHHNiTOA.hOAmwbOpuZmUWbfzSarPAHSKHuNxA;
			Console.WriteLine("List size 추가 : [" + num + "]  <> Full list size : [" + length + "]");
			FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\List.pak", FileMode.Create);
			fileStream.Write(array, 0, num);
			fileStream.Flush();
			fileStream.Close();
		}
	}
}
