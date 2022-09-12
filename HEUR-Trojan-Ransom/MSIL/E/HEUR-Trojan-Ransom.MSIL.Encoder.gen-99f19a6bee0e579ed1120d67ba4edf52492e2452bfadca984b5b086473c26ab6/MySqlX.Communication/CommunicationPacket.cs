namespace MySqlX.Communication;

internal class CommunicationPacket
{
	public byte[] Buffer;

	public int MessageType;

	public int Length;

	public CommunicationPacket(int messageType, int length, byte[] data)
	{
		MessageType = messageType;
		Length = length;
		Buffer = data;
	}
}
