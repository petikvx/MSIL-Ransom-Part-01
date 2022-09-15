using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Utilities.IO.Pem;

public class PemReader
{
	private readonly TextReader reader;

	private readonly MemoryStream buffer;

	private readonly StreamWriter textBuffer;

	private readonly IList pushback = Platform.CreateArrayList();

	private int c;

	public TextReader Reader => reader;

	public PemReader(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		buffer = new MemoryStream();
		textBuffer = new StreamWriter(buffer);
		this.reader = reader;
	}

	public PemObject ReadPemObject()
	{
		do
		{
			if (seekDash())
			{
				if (consumeDash())
				{
					skipWhiteSpace();
					continue;
				}
				throw new IOException("no data after consuming leading dashes");
			}
			return null;
		}
		while (!expect("BEGIN"));
		skipWhiteSpace();
		if (!bufferUntilStopChar('-', skipWhiteSpace: false))
		{
			throw new IOException("ran out of data before consuming type");
		}
		string text = bufferedString().Trim();
		if (!consumeDash())
		{
			throw new IOException("ran out of data consuming header");
		}
		skipWhiteSpace();
		IList list = Platform.CreateArrayList();
		string data;
		while (true)
		{
			if (seekColon(64))
			{
				if (bufferUntilStopChar(':', skipWhiteSpace: false))
				{
					string name = bufferedString().Trim();
					c = Read();
					if (c == 58)
					{
						if (bufferUntilStopChar('\n', skipWhiteSpace: false))
						{
							skipWhiteSpace();
							string val = bufferedString().Trim();
							list.Add(new PemHeader(name, val));
							continue;
						}
						throw new IOException("ran out of data before consuming header value");
					}
					throw new IOException("expected colon");
				}
				throw new IOException("ran out of data reading header key value");
			}
			skipWhiteSpace();
			if (!bufferUntilStopChar('-', skipWhiteSpace: true))
			{
				throw new IOException("ran out of data before consuming payload");
			}
			data = bufferedString();
			if (!seekDash())
			{
				throw new IOException("did not find leading '-'");
			}
			if (!consumeDash())
			{
				throw new IOException("no data after consuming trailing dashes");
			}
			if (!expect("END " + text))
			{
				throw new IOException("END " + text + " was not found.");
			}
			if (seekDash())
			{
				break;
			}
			throw new IOException("did not find ending '-'");
		}
		consumeDash();
		return new PemObject(text, list, Base64.Decode(data));
	}

	private string bufferedString()
	{
		textBuffer.Flush();
		string result = Strings.FromUtf8ByteArray(buffer.ToArray());
		buffer.Position = 0L;
		buffer.SetLength(0L);
		return result;
	}

	private bool seekDash()
	{
		c = 0;
		while ((c = Read()) >= 0 && c != 45)
		{
		}
		PushBack(c);
		return c == 45;
	}

	private bool seekColon(int upTo)
	{
		c = 0;
		bool result = false;
		IList list = Platform.CreateArrayList();
		while (upTo >= 0 && c >= 0)
		{
			c = Read();
			list.Add(c);
			if (c != 58)
			{
				upTo--;
				continue;
			}
			result = true;
			break;
		}
		while (list.Count > 0)
		{
			PushBack((int)list[list.Count - 1]);
			list.RemoveAt(list.Count - 1);
		}
		return result;
	}

	private bool consumeDash()
	{
		c = 0;
		while ((c = Read()) >= 0 && c == 45)
		{
		}
		PushBack(c);
		return c != -1;
	}

	private void skipWhiteSpace()
	{
		while ((c = Read()) >= 0 && c <= 32)
		{
		}
		PushBack(c);
	}

	private bool expect(string value)
	{
		int num = 0;
		while (true)
		{
			if (num < value.Length)
			{
				c = Read();
				if (c != value[num])
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

	private bool bufferUntilStopChar(char stopChar, bool skipWhiteSpace)
	{
		while ((c = Read()) >= 0)
		{
			if (!skipWhiteSpace || c > 32)
			{
				if (c == stopChar)
				{
					PushBack(c);
					break;
				}
				textBuffer.Write((char)c);
				textBuffer.Flush();
			}
		}
		return c > -1;
	}

	private void PushBack(int value)
	{
		if (pushback.Count == 0)
		{
			pushback.Add(value);
		}
		else
		{
			pushback.Insert(0, value);
		}
	}

	private int Read()
	{
		if (pushback.Count > 0)
		{
			int result = (int)pushback[0];
			pushback.RemoveAt(0);
			return result;
		}
		return reader.Read();
	}
}
