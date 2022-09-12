using MySqlX.XDevAPI.Relational;

namespace MySqlX.Protocol;

internal abstract class ValueDecoder
{
	public delegate object ClrDecoderDelegate(byte[] bytes);

	public ClrDecoderDelegate ClrValueDecoder;

	public Column Column { get; set; }

	public uint Flags { get; set; }

	public uint ContentType { get; set; }

	public abstract void SetMetadata();
}
