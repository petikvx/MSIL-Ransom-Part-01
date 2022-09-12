using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip;

public class GZipInputStream : InflaterInputStream
{
	protected bool bool_0;

	protected Crc32 crc32_0;

	private bool kiTGlkiOrZGfhVmMTMfOXACnnPoRA;

	public GZipInputStream(Stream baseInputStream)
		: this(baseInputStream, 4096)
	{
	}

	public GZipInputStream(Stream baseInputStream, int size)
		: base(baseInputStream, new Inflater(noHeader: true), size)
	{
		crc32_0 = new Crc32();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (!kiTGlkiOrZGfhVmMTMfOXACnnPoRA)
		{
			DxoaIEGTYkaJrXYqswkhSPdjRtPR();
		}
		if (!bool_0)
		{
			int num = base.Read(buffer, offset, count);
			if (num > 0)
			{
				crc32_0.Update(buffer, offset, num);
			}
			if (inflater_0.IsFinished)
			{
				pNbQmvpLFxXTfLAjMPfLTdxrMJAh();
			}
			return num;
		}
		return 0;
	}

	private void pNbQmvpLFxXTfLAjMPfLTdxrMJAh()
	{
		byte[] array = new byte[8];
		int num = inflater_0.RemainingInput;
		if (num > 8)
		{
			num = 8;
		}
		Array.Copy(inputBuffer.RawData, inputBuffer.RawLength - inflater_0.RemainingInput, array, 0, num);
		int num2 = 8 - num;
		while (true)
		{
			if (num2 > 0)
			{
				int num3 = baseInputStream.Read(array, 8 - num2, num2);
				if (num3 > 0)
				{
					num2 -= num3;
					continue;
				}
				throw new EndOfStreamException("EOS reading GZIP footer");
			}
			int num4 = (array[0] & 0xFF) | ((array[1] & 0xFF) << 8) | ((array[2] & 0xFF) << 16) | (array[3] << 24);
			if (num4 == (int)crc32_0.Value)
			{
				uint num5 = (array[4] & 0xFFu) | (uint)((array[5] & 0xFF) << 8) | (uint)((array[6] & 0xFF) << 16) | (uint)(array[7] << 24);
				if ((inflater_0.TotalOut & 0xFFFFFFFFL) == num5)
				{
					break;
				}
				throw new GZipException("Number of bytes mismatch in footer");
			}
			throw new GZipException("GZIP crc sum mismatch, theirs \"" + num4 + "\" and ours \"" + (int)crc32_0.Value);
		}
		bool_0 = true;
	}

	private void DxoaIEGTYkaJrXYqswkhSPdjRtPR()
	{
		Crc32 crc = new Crc32();
		int num = baseInputStream.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("EOS reading GZIP header");
		}
		while (true)
		{
			crc.Update(num);
			if (num == 31)
			{
				num = baseInputStream.ReadByte();
				if (num >= 0)
				{
					if (num == 139)
					{
						crc.Update(num);
						int num2 = baseInputStream.ReadByte();
						if (num2 >= 0)
						{
							if (num2 == 8)
							{
								crc.Update(num2);
								int num3 = baseInputStream.ReadByte();
								if (num3 >= 0)
								{
									crc.Update(num3);
									if ((num3 & 0xE0) == 0)
									{
										for (int i = 0; i < 6; i++)
										{
											int num4 = baseInputStream.ReadByte();
											if (num4 >= 0)
											{
												crc.Update(num4);
												continue;
											}
											throw new EndOfStreamException("EOS reading GZIP header");
										}
										if (((uint)num3 & 4u) != 0)
										{
											for (int j = 0; j < 2; j++)
											{
												int num5 = baseInputStream.ReadByte();
												if (num5 >= 0)
												{
													crc.Update(num5);
													continue;
												}
												throw new EndOfStreamException("EOS reading GZIP header");
											}
											if (baseInputStream.ReadByte() < 0 || baseInputStream.ReadByte() < 0)
											{
												throw new EndOfStreamException("EOS reading GZIP header");
											}
											int num6 = baseInputStream.ReadByte();
											int num7 = baseInputStream.ReadByte();
											if (num6 < 0 || num7 < 0)
											{
												throw new EndOfStreamException("EOS reading GZIP header");
											}
											crc.Update(num6);
											crc.Update(num7);
											int num8 = (num6 << 8) | num7;
											for (int k = 0; k < num8; k++)
											{
												int num9 = baseInputStream.ReadByte();
												if (num9 >= 0)
												{
													crc.Update(num9);
													continue;
												}
												throw new EndOfStreamException("EOS reading GZIP header");
											}
										}
										if (((uint)num3 & 8u) != 0)
										{
											int num10;
											while ((num10 = baseInputStream.ReadByte()) > 0)
											{
												crc.Update(num10);
											}
											if (num10 < 0)
											{
												throw new EndOfStreamException("EOS reading GZIP header");
											}
											crc.Update(num10);
										}
										if (((uint)num3 & 0x10u) != 0)
										{
											int num11;
											while ((num11 = baseInputStream.ReadByte()) > 0)
											{
												crc.Update(num11);
											}
											if (num11 < 0)
											{
												throw new EndOfStreamException("EOS reading GZIP header");
											}
											crc.Update(num11);
										}
										if ((num3 & 2) == 0)
										{
											break;
										}
										int num12 = baseInputStream.ReadByte();
										if (num12 >= 0)
										{
											int num13 = baseInputStream.ReadByte();
											if (num13 >= 0)
											{
												if (((num12 << 8) | num13) != ((int)crc.Value & 0xFFFF))
												{
												}
												continue;
											}
											throw new EndOfStreamException("EOS reading GZIP header");
										}
										throw new EndOfStreamException("EOS reading GZIP header");
									}
									throw new GZipException("Reserved flag bits in GZIP header != 0");
								}
								throw new EndOfStreamException("EOS reading GZIP header");
							}
							throw new GZipException("Error GZIP header, data not in deflate format");
						}
						throw new EndOfStreamException("EOS reading GZIP header");
					}
					throw new GZipException("Error GZIP header,  second magic byte doesn't match");
				}
				throw new EndOfStreamException("EOS reading GZIP header");
			}
			throw new GZipException("Error GZIP header, first magic byte doesn't match");
		}
		kiTGlkiOrZGfhVmMTMfOXACnnPoRA = true;
	}
}
