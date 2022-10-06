using System;
using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption;

internal class ZipAESStream : CryptoStream
{
	private const int AUTH_CODE_LENGTH = 10;

	private const int CRYPTO_BLOCK_SIZE = 16;

	private Stream _stream;

	private ZipAESTransform _transform;

	private byte[] _slideBuffer;

	private int _slideBufStartPos;

	private int _slideBufFreePos;

	private int _blockAndAuth;

	public ZipAESStream(Stream stream, ZipAESTransform transform, CryptoStreamMode mode)
		: base(stream, transform, mode)
	{
		_stream = stream;
		_transform = transform;
		_slideBuffer = new byte[1024];
		_blockAndAuth = 26;
		if (mode != 0)
		{
			throw new Exception("ZipAESStream only for read");
		}
	}

	public override int Read(byte[] outBuffer, int offset, int count)
	{
		int num = 0;
		while (num < count)
		{
			int num2 = _slideBufFreePos - _slideBufStartPos;
			int num3 = _blockAndAuth - num2;
			if (_slideBuffer.Length - _slideBufFreePos < num3)
			{
				int num4 = 0;
				int num5 = _slideBufStartPos;
				while (num5 < _slideBufFreePos)
				{
					_slideBuffer[num4] = _slideBuffer[num5];
					num5++;
					num4++;
				}
				_slideBufFreePos -= _slideBufStartPos;
				_slideBufStartPos = 0;
			}
			int num6 = _stream.Read(_slideBuffer, _slideBufFreePos, num3);
			_slideBufFreePos += num6;
			num2 = _slideBufFreePos - _slideBufStartPos;
			if (num2 >= _blockAndAuth)
			{
				_transform.TransformBlock(_slideBuffer, _slideBufStartPos, 16, outBuffer, offset);
				num += 16;
				offset += 16;
				_slideBufStartPos += 16;
				continue;
			}
			if (num2 > 10)
			{
				int num7 = num2 - 10;
				_transform.TransformBlock(_slideBuffer, _slideBufStartPos, num7, outBuffer, offset);
				num += num7;
				_slideBufStartPos += num7;
			}
			else if (num2 < 10)
			{
				throw new Exception("Internal error missed auth code");
			}
			byte[] authCode = _transform.GetAuthCode();
			for (int i = 0; i < 10; i++)
			{
				if (authCode[i] != _slideBuffer[_slideBufStartPos + i])
				{
					throw new Exception("AES Authentication Code does not match. This is a super-CRC check on the data in the file after compression and encryption. \r\nThe file may be damaged.");
				}
			}
			break;
		}
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}
}
