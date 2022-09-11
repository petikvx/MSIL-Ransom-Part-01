using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class InfoChunk
{
	private SFVersion verSoundFont;

	private string waveTableSoundEngine;

	private string bankName;

	private string dataROM;

	private string creationDate;

	private string author;

	private string targetProduct;

	private string copyright;

	private string comments;

	private string tools;

	private SFVersion verROM;

	[NonSerialized]
	internal static GetString _008F;

	public SFVersion SoundFontVersion => verSoundFont;

	public string WaveTableSoundEngine
	{
		get
		{
			return waveTableSoundEngine;
		}
		set
		{
			waveTableSoundEngine = value;
		}
	}

	public string BankName
	{
		get
		{
			return bankName;
		}
		set
		{
			bankName = value;
		}
	}

	public string DataROM
	{
		get
		{
			return dataROM;
		}
		set
		{
			dataROM = value;
		}
	}

	public string CreationDate
	{
		get
		{
			return creationDate;
		}
		set
		{
			creationDate = value;
		}
	}

	public string Author
	{
		get
		{
			return author;
		}
		set
		{
			author = value;
		}
	}

	public string TargetProduct
	{
		get
		{
			return targetProduct;
		}
		set
		{
			targetProduct = value;
		}
	}

	public string Copyright
	{
		get
		{
			return copyright;
		}
		set
		{
			copyright = value;
		}
	}

	public string Comments
	{
		get
		{
			return comments;
		}
		set
		{
			comments = value;
		}
	}

	public string Tools
	{
		get
		{
			return tools;
		}
		set
		{
			tools = value;
		}
	}

	public SFVersion ROMVersion
	{
		get
		{
			return verROM;
		}
		set
		{
			verROM = value;
		}
	}

	internal InfoChunk(RiffChunk chunk)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		if (chunk.ReadChunkID() != _008F(107394768))
		{
			throw new InvalidDataException(_008F(107394759));
		}
		RiffChunk nextSubChunk;
		while ((nextSubChunk = chunk.GetNextSubChunk()) != null)
		{
			string chunkID = nextSubChunk.ChunkID;
			switch (_003CPrivateImplementationDetails_003E1.ComputeStringHash(chunkID))
			{
			case 3349434627u:
				if (!(chunkID == _008F(107394734)))
				{
					break;
				}
				flag = true;
				verSoundFont = nextSubChunk.GetDataAsStructure(new SFVersionBuilder());
				continue;
			case 2408165810u:
				if (!(chunkID == _008F(107394725)))
				{
					break;
				}
				flag2 = true;
				waveTableSoundEngine = nextSubChunk.GetDataAsString();
				continue;
			case 186167360u:
				if (!(chunkID == _008F(107394748)))
				{
					break;
				}
				flag3 = true;
				bankName = nextSubChunk.GetDataAsString();
				continue;
			case 1286587406u:
				if (!(chunkID == _008F(107394707)))
				{
					break;
				}
				dataROM = nextSubChunk.GetDataAsString();
				continue;
			case 2337496513u:
				if (!(chunkID == _008F(107394698)))
				{
					break;
				}
				verROM = nextSubChunk.GetDataAsStructure(new SFVersionBuilder());
				continue;
			case 3696333059u:
				if (!(chunkID == _008F(107394721)))
				{
					break;
				}
				creationDate = nextSubChunk.GetDataAsString();
				continue;
			case 802522432u:
				if (!(chunkID == _008F(107394712)))
				{
					break;
				}
				author = nextSubChunk.GetDataAsString();
				continue;
			case 1438214986u:
				if (!(chunkID == _008F(107395183)))
				{
					break;
				}
				targetProduct = nextSubChunk.GetDataAsString();
				continue;
			case 3794880202u:
				if (!(chunkID == _008F(107395174)))
				{
					break;
				}
				copyright = nextSubChunk.GetDataAsString();
				continue;
			case 439062212u:
				if (!(chunkID == _008F(107395197)))
				{
					break;
				}
				comments = nextSubChunk.GetDataAsString();
				continue;
			case 3955789767u:
				if (!(chunkID == _008F(107395188)))
				{
					break;
				}
				tools = nextSubChunk.GetDataAsString();
				continue;
			}
			throw new InvalidDataException(string.Format(_008F(107395147), nextSubChunk.ChunkID));
		}
		if (!flag)
		{
			throw new InvalidDataException(_008F(107395114));
		}
		if (!flag2)
		{
			throw new InvalidDataException(_008F(107395093));
		}
		if (!flag3)
		{
			throw new InvalidDataException(_008F(107395036));
		}
	}

	public override string ToString()
	{
		return string.Format(_008F(107394955), BankName, Author, Copyright, CreationDate, Tools, _008F(107394189), WaveTableSoundEngine, SoundFontVersion, TargetProduct, DataROM, ROMVersion);
	}

	static InfoChunk()
	{
		Strings.CreateGetStringDelegate(typeof(InfoChunk));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008F(107397365), _008F(107397328)), _008F(107397323), _008F(107397318)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008F(107397345)))
		{
			return;
		}
		throw new SecurityException(_008F(107397288));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
