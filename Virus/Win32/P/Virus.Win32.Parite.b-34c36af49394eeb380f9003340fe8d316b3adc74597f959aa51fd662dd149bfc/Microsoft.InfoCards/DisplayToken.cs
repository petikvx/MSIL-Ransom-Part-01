using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class DisplayToken
{
	private string m_displayString;

	private string m_mimeType;

	private List<DisplayClaim> m_displayList;

	private DisplayClaimType m_displayType;

	public IEnumerable<DisplayClaim> ClaimList => m_displayList;

	public DisplayToken()
	{
		m_displayType = DisplayClaimType.NoDisplayToken;
	}

	public DisplayToken(string displayString, string mimeType)
	{
		m_displayString = displayString;
		m_mimeType = mimeType;
		m_displayType = DisplayClaimType.DisplayClaimString;
	}

	public DisplayToken(List<DisplayClaim> claimList)
	{
		m_displayList = claimList;
		m_displayType = DisplayClaimType.DisplayClaimList;
	}

	public void Serialize(BinaryWriter writer)
	{
		writer.Write((byte)m_displayType);
		switch (m_displayType)
		{
		default:
			InfoCardTrace.ThrowInvalidArgumentConditional(true, "ClaimType");
			break;
		case DisplayClaimType.DisplayClaimString:
			Utility.SerializeString(writer, m_displayString);
			Utility.SerializeString(writer, m_mimeType);
			break;
		case DisplayClaimType.DisplayClaimList:
			writer.Write((uint)m_displayList.Count);
			{
				foreach (DisplayClaim display in m_displayList)
				{
					display.Serialize(writer);
				}
				break;
			}
		case DisplayClaimType.NoDisplayToken:
			break;
		}
	}

	public void Deserialize(BinaryReader reader)
	{
		m_displayType = (DisplayClaimType)reader.ReadByte();
		switch (m_displayType)
		{
		default:
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("InvalidDisplayClaimType")));
		case DisplayClaimType.NoDisplayToken:
			break;
		case DisplayClaimType.DisplayClaimString:
			m_displayString = Utility.DeserializeString(reader);
			m_mimeType = Utility.DeserializeString(reader);
			break;
		case DisplayClaimType.DisplayClaimList:
		{
			m_displayList.Clear();
			uint num = reader.ReadUInt32();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				DisplayClaim item = new DisplayClaim(reader);
				m_displayList.Add(item);
			}
			break;
		}
		}
	}
}
