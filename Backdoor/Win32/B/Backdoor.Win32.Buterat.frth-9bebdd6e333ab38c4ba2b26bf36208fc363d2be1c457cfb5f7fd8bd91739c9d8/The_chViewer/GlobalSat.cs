using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace The_chViewer;

public class GlobalSat
{
	private const byte Start = 160;

	private const byte SequenceStart = 162;

	private const byte End = 176;

	private const byte SequenceEnd = 179;

	private static bool _isFristOpenPort = true;

	public SimpleLogger Logger { get; private set; }

	private SerialPort Port { get; set; }

	public string PortName { get; set; }

	public int BaudRate { get; set; }

	public GlobalSat(string portName = "COM1", int baudRate = 115200)
	{
		Logger = new SimpleLogger();
		PortName = portName;
		BaudRate = baudRate;
	}

	public void SetBaudRate(int baudRate)
	{
		BaudRate = baudRate;
	}

	private void SafetyWrite(byte[] buffer, int offset, int count)
	{
		try
		{
			Port.Write(buffer, offset, count);
		}
		catch (IOException ex)
		{
			Logger.Log(ex.Message, SimpleLogger.MessageLevel.Error);
		}
	}

	private bool Open(int tryCount = 0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (Port != null && Port.get_IsOpen())
		{
			Close();
		}
		Port = new SerialPort(PortName, BaudRate);
		Port.set_DataBits(8);
		Port.set_StopBits((StopBits)1);
		Port.set_Parity((Parity)0);
		try
		{
			Port.Open();
		}
		catch (UnauthorizedAccessException ex)
		{
			Logger.Log($"Ошибка. {ex.Message} (попытка № {tryCount + 1}", SimpleLogger.MessageLevel.Error);
			if (tryCount == 3)
			{
				return false;
			}
			Thread.Sleep(1300);
			return Open(++tryCount);
		}
		catch (IOException ex2)
		{
			Logger.Log($"Ошибка. {ex2.Message} ", SimpleLogger.MessageLevel.Error);
			return false;
		}
		catch (Exception ex3)
		{
			Logger.Log($"Ошибка. {ex3.Message} ", SimpleLogger.MessageLevel.Error);
			return false;
		}
		if (_isFristOpenPort)
		{
			Logger.Log(string.Format(Strings.PORT_OPENED_SUCCESSFULLY, PortName), SimpleLogger.MessageLevel.Success);
			_isFristOpenPort = false;
		}
		return true;
	}

	public void Close()
	{
		try
		{
			if (Port != null)
			{
				Port.Close();
				Thread.Sleep(300);
			}
		}
		catch (Exception ex)
		{
			Logger.Log($"Port.Close; {ex.Message}\n{ex.StackTrace}", SimpleLogger.MessageLevel.Error);
		}
	}

	public void SetPort(string portName, int baudRate)
	{
		PortName = portName;
		if (Port != null)
		{
			Close();
			Port.set_PortName(portName);
			Port.set_BaudRate(baudRate);
		}
	}

	private Response ParseResponse(byte[] data)
	{
		if (data.Length == 0)
		{
			return new Response();
		}
		Response response = new Response();
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
		try
		{
			binaryReader.BaseStream.Seek(4L, SeekOrigin.Begin);
			byte b = binaryReader.ReadByte();
			switch (b)
			{
			case 186:
				response.setTypeOfResponse(b);
				if (GetInt(binaryReader) == 1)
				{
					Logger.Log("Память успешно очищена.", SimpleLogger.MessageLevel.Success);
				}
				else
				{
					Logger.Log("Во время очистки памяти произошла ошибка.", SimpleLogger.MessageLevel.Error);
				}
				break;
			case 187:
			{
				response.setTypeOfResponse(b);
				int num3 = binaryReader.ReadByte() + binaryReader.ReadByte();
				byte @byte = binaryReader.ReadByte();
				short nextIdx = ToShort(binaryReader.ReadByte(), @byte);
				response.setTypeOfResponse(187);
				response.setCntDataCur(num3);
				response.setNextIdx(nextIdx);
				for (int num4 = num3; num4 != 0; num4--)
				{
					FileInfoRec fileInfoRec = new FileInfoRec(binaryReader);
					response.addRec(fileInfoRec);
					Console.WriteLine(fileInfoRec);
				}
				break;
			}
			case 191:
			case 223:
			{
				response.Id = 0;
				for (int i = 0; i < 8; i++)
				{
					byte b2 = binaryReader.ReadByte();
					response.Id = response.Id * 10 + b2;
				}
				break;
			}
			case 181:
			{
				response.setTypeOfResponse(b);
				int num = 2;
				int num2 = 0;
				while (binaryReader.BaseStream.Position <= data.Length)
				{
					GpsRec gpsRec = new GpsRec(binaryReader, num);
					if (gpsRec.isValid() && binaryReader.BaseStream.Position <= data.Length)
					{
						response.addRec(gpsRec);
						num = gpsRec.getTypeOfNextRec();
						num2++;
						Logger.Log(num2 + ": " + gpsRec, SimpleLogger.MessageLevel.Debug);
						continue;
					}
					Logger.Log(binaryReader.BaseStream.Position + "<=" + data.Length + ", not valid: " + gpsRec, SimpleLogger.MessageLevel.DebugError);
					break;
				}
				binaryReader.BaseStream.Seek(1042L, SeekOrigin.Begin);
				while (binaryReader.BaseStream.Position <= data.Length && (num != 2 || data.Length - binaryReader.BaseStream.Position >= 32L) && (num != 1 || data.Length - binaryReader.BaseStream.Position >= 20L) && (num != 0 || data.Length - binaryReader.BaseStream.Position >= 8L))
				{
					GpsRec gpsRec2 = new GpsRec(binaryReader, num);
					if (gpsRec2.isValid() && binaryReader.BaseStream.Position <= data.Length)
					{
						response.addRec(gpsRec2);
						num = gpsRec2.getTypeOfNextRec();
						num2++;
						Logger.Log(num2 + ": " + gpsRec2, SimpleLogger.MessageLevel.Debug);
						continue;
					}
					Logger.Log(binaryReader.BaseStream.Position + "<=" + data.Length + ", not valid: " + gpsRec2, SimpleLogger.MessageLevel.DebugError);
					break;
				}
				break;
			}
			}
			return response;
		}
		catch (EndOfStreamException ex)
		{
			Logger.Log($"Чтение за пределами потока.\n{ex.Message}", SimpleLogger.MessageLevel.Error);
			return null;
		}
		catch (Exception ex2)
		{
			Logger.Log($"Необработное исключение в ParseResponse.\n{ex2.Message}", SimpleLogger.MessageLevel.Error);
			return null;
		}
	}

	private IEnumerable<object> ReadFileInfoList()
	{
		int num = 0;
		List<object> list = new List<object>();
		do
		{
			byte[] @short = GetShort(num);
			Response response = SendGetTrackFileHeader(@short[0], @short[1]);
			if (response == null)
			{
				break;
			}
			num = response.getNextIdx();
			list.AddRange(response.getRecs());
		}
		while (num > 0);
		return list;
	}

	private IEnumerable<object> ReadGpsRecList(IEnumerable<object> fileInfoRecs)
	{
		List<object> list = new List<object>();
		foreach (FileInfoRec fileInfoRec in fileInfoRecs)
		{
			int idx = fileInfoRec.getIdx();
			byte[] @short = GetShort(idx);
			Response response = SendGetGpsRecs(@short[0], @short[1]);
			if (response != null)
			{
				Logger.Log(string.Format(Strings.TRACK_LOADED, idx + 1, response.getRecs().Count), SimpleLogger.MessageLevel.Information);
				list.AddRange(response.getRecs());
				continue;
			}
			return list;
		}
		return list;
	}

	private Response SendGetId()
	{
		Logger.Log("Получаем ID устройства", SimpleLogger.MessageLevel.Information);
		if (!Open())
		{
			return null;
		}
		byte[] array = new byte[1] { 191 };
		byte[] @short = GetShort(Checksum(array));
		byte[] obj = new byte[9] { 160, 162, 0, 1, 191, 0, 0, 176, 179 };
		obj[5] = @short[0];
		obj[6] = @short[1];
		byte[] array2 = obj;
		SafetyWrite(array2, 0, array2.Length);
		Sleep();
		if (Port.get_BytesToRead() == 0)
		{
			return null;
		}
		byte[] array3 = new byte[Port.get_BytesToRead()];
		Port.Read(array3, 0, Port.get_BytesToRead());
		return ParseResponse(array3);
	}

	private Response SendSetId(byte[] id)
	{
		Logger.Log("Идет установка ID устройству ...", SimpleLogger.MessageLevel.Information);
		if (!Open())
		{
			Logger.Log(string.Format(Strings.PORT_BLOCKED, PortName), SimpleLogger.MessageLevel.Error);
			return null;
		}
		byte[] array = new byte[9]
		{
			192,
			id[0],
			id[1],
			id[2],
			id[3],
			id[4],
			id[5],
			id[6],
			id[7]
		};
		byte[] @short = GetShort(Checksum(array));
		byte[] obj = new byte[17]
		{
			160, 162, 0, 9, 192, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 176, 179
		};
		obj[5] = id[0];
		obj[6] = id[1];
		obj[7] = id[2];
		obj[8] = id[3];
		obj[9] = id[4];
		obj[10] = id[5];
		obj[11] = id[6];
		obj[12] = id[7];
		obj[13] = @short[0];
		obj[14] = @short[1];
		byte[] array2 = obj;
		SafetyWrite(array2, 0, array2.Length);
		Sleep();
		byte[] array3 = new byte[Port.get_BytesToRead()];
		Port.Read(array3, 0, Port.get_BytesToRead());
		return ParseResponse(array3);
	}

	private Response SendGetTrackFileHeader(byte hightIndex, byte lowIndex)
	{
		if (!Open())
		{
			Logger.Log(string.Format(Strings.PORT_BLOCKED, PortName), SimpleLogger.MessageLevel.Error);
			return null;
		}
		byte[] array = new byte[3] { 187, hightIndex, lowIndex };
		Logger.Log(Strings.GetHeader, SimpleLogger.MessageLevel.Information);
		byte[] @short = GetShort(Checksum(array));
		byte[] obj = new byte[11]
		{
			160, 162, 0, 3, 187, 0, 0, 0, 0, 176,
			179
		};
		obj[5] = hightIndex;
		obj[6] = lowIndex;
		obj[7] = @short[0];
		obj[8] = @short[1];
		byte[] array2 = obj;
		SafetyWrite(array2, 0, array2.Length);
		Sleep(2000);
		byte[] array3 = new byte[Port.get_BytesToRead()];
		Port.Read(array3, 0, Port.get_BytesToRead());
		return ParseResponse(array3);
	}

	private Response SendGetGpsRecs(byte hightIndex = 0, byte lowIndex = 0)
	{
		if (!Open())
		{
			Logger.Log(string.Format(Strings.PORT_BLOCKED, PortName), SimpleLogger.MessageLevel.Error);
			return null;
		}
		byte[] array = new byte[3] { 181, hightIndex, lowIndex };
		byte[] @short = GetShort(Checksum(array));
		byte[] obj = new byte[11]
		{
			160, 162, 0, 3, 181, 0, 0, 0, 0, 176,
			179
		};
		obj[5] = hightIndex;
		obj[6] = lowIndex;
		obj[7] = @short[0];
		obj[8] = @short[1];
		byte[] array2 = obj;
		SafetyWrite(array2, 0, array2.Length);
		Sleep();
		byte[] array3 = new byte[Port.get_ReadBufferSize()];
		Port.Read(array3, 0, Port.get_ReadBufferSize());
		return ParseResponse(array3);
	}

	public void SendClear()
	{
		if (!Open())
		{
			Logger.Log(string.Format(Strings.PORT_BLOCKED, PortName), SimpleLogger.MessageLevel.Error);
			return;
		}
		byte[] array = new byte[3] { 186, 255, 255 };
		GetShort(Checksum(array));
		byte[] array2 = new byte[11]
		{
			160, 162, 0, 3, 186, 255, 255, 2, 184, 176,
			179
		};
		Logger.Log("Erasing memory start", SimpleLogger.MessageLevel.Information);
		SafetyWrite(array2, 0, array2.Length);
		Sleep(500);
		byte[] array3 = new byte[Port.get_BytesToRead()];
		Port.Read(array3, 0, Port.get_BytesToRead());
		ParseResponse(array3);
	}

	public string ExportToGpx()
	{
		IEnumerable<object> enumerable = ReadFileInfoList();
		if (((IList<object>)enumerable).Count == 0)
		{
			Logger.Log("Треки не найдены.", SimpleLogger.MessageLevel.Information);
			return string.Empty;
		}
		IEnumerable<object> enumerable2 = ReadGpsRecList(enumerable);
		if (((IList<object>)enumerable2).Count == 0)
		{
			return string.Empty;
		}
		string text = $"Export_{DateTime.Now}.gpx";
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<gpx\n");
		stringBuilder.Append("  version=\"1.0\"\n");
		stringBuilder.Append("  creator=\"dg100util by Glebov Boris\"\n");
		stringBuilder.Append("  xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"\n");
		stringBuilder.Append("  xmlns=\"http://www.topografix.com/GPX/1/0\"\n");
		stringBuilder.Append("  xsi:schemaLocation=\"http://www.topografix.com/GPX/1/0 http://www.topografix.com/GPX/1/0/gpx.xsd\">\n");
		stringBuilder.Append("  <name>" + text + "</name>\n");
		List<GpsRec> list = new List<GpsRec>();
		GpsRec arg = null;
		foreach (GpsRec item in enumerable2)
		{
			if (item.equals(arg))
			{
				list.Add(item);
			}
			arg = item;
		}
		foreach (GpsRec item2 in list)
		{
			stringBuilder.Append(item2.ToGpxWpt() + "\n");
		}
		stringBuilder.Append("  <trk>\n");
		stringBuilder.Append("    <trkseg>\n");
		foreach (GpsRec item3 in enumerable2)
		{
			stringBuilder.Append(item3.ToGpxTrkpt() + "\n");
		}
		stringBuilder.Append("    </trkseg>\n");
		stringBuilder.Append("  </trk>\n");
		stringBuilder.Append("</gpx>\n");
		Close();
		return stringBuilder.ToString();
	}

	public int GetId()
	{
		return SendGetId()?.Id ?? (-1);
	}

	public void SetId(int Id)
	{
		byte[] array = new byte[8];
		string text = Id.ToString();
		for (int i = 0; i < text.Length; i++)
		{
			array[text.Length - i - 1] = byte.Parse(text[i].ToString());
		}
		byte[] array2 = new byte[8];
		for (int j = 0; j < 8; j++)
		{
			array2[j] = array[8 - j - 1];
		}
		SendSetId(array2);
		Close();
	}

	private static byte[] GetShort(int num)
	{
		byte b = (byte)(num >> 8);
		byte b2 = (byte)((uint)num & 0xFFu);
		return new byte[2] { b, b2 };
	}

	private static short ToShort(short byte1, short byte2)
	{
		return (short)((byte2 << 8) + byte1);
	}

	private int GetInt(BinaryReader buf)
	{
		return buf.ReadByte() * 256 * 256 * 256 + buf.ReadByte() * 256 * 256 + buf.ReadByte() * 256 + buf.ReadByte();
	}

	private static short ToShort(byte[] buf)
	{
		return (short)(buf[0] * 256 + buf[0]);
	}

	private static int ToInt(byte[] buf)
	{
		throw new NotImplementedException();
	}

	private int Checksum(byte[] array)
	{
		int num = array[0];
		for (int i = 1; i < array.Length; i++)
		{
			num += array[i];
		}
		return num & 0x7FFF;
	}

	private void Sleep(int time = 200)
	{
		Thread.Sleep(time);
	}
}
