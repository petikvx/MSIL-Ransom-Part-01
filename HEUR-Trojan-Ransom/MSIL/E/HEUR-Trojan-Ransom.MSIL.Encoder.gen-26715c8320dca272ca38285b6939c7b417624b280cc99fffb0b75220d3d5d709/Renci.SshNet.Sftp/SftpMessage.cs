using System.Globalization;
using System.IO;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

internal abstract class SftpMessage : SshData
{
	protected override int BufferCapacity => 5;

	public abstract SftpMessageTypes SftpMessageType { get; }

	protected override void LoadData()
	{
	}

	protected override void SaveData()
	{
		Write((byte)SftpMessageType);
	}

	protected override void WriteBytes(SshDataStream stream)
	{
		long position = stream.Position;
		stream.Seek(4L, SeekOrigin.Current);
		base.WriteBytes(stream);
		long position2 = stream.Position;
		long num = position2 - position - 4L;
		stream.Position = position;
		stream.Write((uint)num);
		stream.Position = position2;
	}

	protected SftpFileAttributes ReadAttributes()
	{
		return SftpFileAttributes.FromBytes(base.DataStream);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "SFTP Message : {0}", new object[1] { SftpMessageType });
	}
}
