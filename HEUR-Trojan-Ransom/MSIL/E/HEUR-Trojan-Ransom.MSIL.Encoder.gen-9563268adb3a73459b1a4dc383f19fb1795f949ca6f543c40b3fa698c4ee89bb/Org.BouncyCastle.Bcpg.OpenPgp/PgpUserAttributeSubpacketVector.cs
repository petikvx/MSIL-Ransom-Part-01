using Org.BouncyCastle.Bcpg.Attr;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpUserAttributeSubpacketVector
{
	private readonly UserAttributeSubpacket[] packets;

	internal PgpUserAttributeSubpacketVector(UserAttributeSubpacket[] packets)
	{
		this.packets = packets;
	}

	public UserAttributeSubpacket GetSubpacket(UserAttributeSubpacketTag type)
	{
		int num = 0;
		while (true)
		{
			if (num != packets.Length)
			{
				if (packets[num].SubpacketType == type)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return packets[num];
	}

	public ImageAttrib GetImageAttribute()
	{
		UserAttributeSubpacket subpacket = GetSubpacket(UserAttributeSubpacketTag.ImageAttribute);
		if (subpacket != null)
		{
			return (ImageAttrib)subpacket;
		}
		return null;
	}

	internal UserAttributeSubpacket[] ToSubpacketArray()
	{
		return packets;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is PgpUserAttributeSubpacketVector pgpUserAttributeSubpacketVector))
		{
			return false;
		}
		if (pgpUserAttributeSubpacketVector.packets.Length != packets.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num != packets.Length)
			{
				if (!pgpUserAttributeSubpacketVector.packets[num].Equals(packets[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = 0;
		UserAttributeSubpacket[] array = packets;
		foreach (object obj in array)
		{
			num ^= obj.GetHashCode();
		}
		return num;
	}
}
