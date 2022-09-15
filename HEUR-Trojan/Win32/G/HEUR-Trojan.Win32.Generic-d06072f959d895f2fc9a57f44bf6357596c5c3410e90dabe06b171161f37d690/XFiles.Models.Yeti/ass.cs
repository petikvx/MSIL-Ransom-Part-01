using System.Collections.Generic;
using System.Text;

namespace XFiles.Models.Yeti;

public class ass
{
	public assType ObjectType { get; set; }

	public byte[] ObjectData { get; set; }

	public int ObjectLength { get; set; }

	public List<ass> Objects { get; set; }

	public ass()
	{
		Objects = new List<ass>();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		switch (ObjectType)
		{
		case assType.Sequence:
			stringBuilder.AppendLine("SEQUENCE {");
			break;
		case assType.Integer:
		{
			byte[] objectData = ObjectData;
			foreach (byte b2 in objectData)
			{
				stringBuilder2.AppendFormat("{0:X2}", b2);
			}
			stringBuilder.Append("\tINTEGER ").Append((object?)stringBuilder2).AppendLine();
			break;
		}
		case assType.OctetString:
		{
			byte[] objectData = ObjectData;
			foreach (byte b3 in objectData)
			{
				stringBuilder2.AppendFormat("{0:X2}", b3);
			}
			stringBuilder.Append("\tOCTETSTRING ").AppendLine(stringBuilder2.ToString());
			break;
		}
		case assType.ObjectIdentifier:
		{
			byte[] objectData = ObjectData;
			foreach (byte b in objectData)
			{
				stringBuilder2.AppendFormat("{0:X2}", b);
			}
			stringBuilder.Append("\tOBJECTIDENTIFIER ").AppendLine(stringBuilder2.ToString());
			break;
		}
		}
		foreach (ass @object in Objects)
		{
			stringBuilder.Append(@object.ToString());
		}
		if (ObjectType == assType.Sequence)
		{
			stringBuilder.AppendLine("}");
		}
		stringBuilder2.Remove(0, stringBuilder2.Length - 1);
		return stringBuilder.ToString();
	}
}
