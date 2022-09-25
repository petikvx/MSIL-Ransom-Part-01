using System;

namespace Stealer;

public class Gecko1
{
	public static Gecko4 Create(byte[] dataToParse)
	{
		Gecko4 gecko = new Gecko4();
		for (int i = 0; i < dataToParse.Length; i++)
		{
			Gecko2 gecko2 = (Gecko2)dataToParse[i];
			int num = 0;
			switch (gecko2)
			{
			case Gecko2.Sequence:
			{
				byte[] array3;
				if (gecko.ObjectLength == 0)
				{
					gecko.ObjectType = Gecko2.Sequence;
					gecko.ObjectLength = dataToParse.Length - (i + 2);
					array3 = new byte[gecko.ObjectLength];
				}
				else
				{
					gecko.Objects.Add(new Gecko4
					{
						ObjectType = Gecko2.Sequence,
						ObjectLength = dataToParse[i + 1]
					});
					array3 = new byte[dataToParse[i + 1]];
				}
				num = ((array3.Length > dataToParse.Length - (i + 2)) ? (dataToParse.Length - (i + 2)) : array3.Length);
				Array.Copy(dataToParse, i + 2, array3, 0, array3.Length);
				gecko.Objects.Add(Create(array3));
				i = i + 1 + dataToParse[i + 1];
				break;
			}
			case Gecko2.Integer:
			{
				gecko.Objects.Add(new Gecko4
				{
					ObjectType = Gecko2.Integer,
					ObjectLength = dataToParse[i + 1]
				});
				byte[] array2 = new byte[dataToParse[i + 1]];
				num = ((i + 2 + dataToParse[i + 1] > dataToParse.Length) ? (dataToParse.Length - (i + 2)) : dataToParse[i + 1]);
				Array.Copy(dataToParse, i + 2, array2, 0, num);
				gecko.Objects[gecko.Objects.Count - 1].ObjectData = array2;
				i = i + 1 + gecko.Objects[gecko.Objects.Count - 1].ObjectLength;
				break;
			}
			case Gecko2.OctetString:
			{
				gecko.Objects.Add(new Gecko4
				{
					ObjectType = Gecko2.OctetString,
					ObjectLength = dataToParse[i + 1]
				});
				byte[] array4 = new byte[dataToParse[i + 1]];
				num = ((i + 2 + dataToParse[i + 1] > dataToParse.Length) ? (dataToParse.Length - (i + 2)) : dataToParse[i + 1]);
				Array.Copy(dataToParse, i + 2, array4, 0, num);
				gecko.Objects[gecko.Objects.Count - 1].ObjectData = array4;
				i = i + 1 + gecko.Objects[gecko.Objects.Count - 1].ObjectLength;
				break;
			}
			case Gecko2.ObjectIdentifier:
			{
				gecko.Objects.Add(new Gecko4
				{
					ObjectType = Gecko2.ObjectIdentifier,
					ObjectLength = dataToParse[i + 1]
				});
				byte[] array = new byte[dataToParse[i + 1]];
				num = ((i + 2 + dataToParse[i + 1] > dataToParse.Length) ? (dataToParse.Length - (i + 2)) : dataToParse[i + 1]);
				Array.Copy(dataToParse, i + 2, array, 0, num);
				gecko.Objects[gecko.Objects.Count - 1].ObjectData = array;
				i = i + 1 + gecko.Objects[gecko.Objects.Count - 1].ObjectLength;
				break;
			}
			}
		}
		return gecko;
	}
}
