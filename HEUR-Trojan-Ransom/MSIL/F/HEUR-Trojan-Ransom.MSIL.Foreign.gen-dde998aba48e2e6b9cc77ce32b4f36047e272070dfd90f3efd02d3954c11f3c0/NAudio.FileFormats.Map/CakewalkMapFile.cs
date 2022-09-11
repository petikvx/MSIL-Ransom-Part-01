using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.FileFormats.Map;

public sealed class CakewalkMapFile
{
	private int mapEntryCount;

	private readonly List<CakewalkDrumMapping> drumMappings;

	private MapBlockHeader fileHeader1;

	private MapBlockHeader fileHeader2;

	private MapBlockHeader mapNameHeader;

	private MapBlockHeader outputs1Header;

	private MapBlockHeader outputs2Header;

	private MapBlockHeader outputs3Header;

	private int outputs1Count;

	private int outputs2Count;

	private int outputs3Count;

	private string mapName;

	[NonSerialized]
	internal static GetString _0096;

	public List<CakewalkDrumMapping> DrumMappings => drumMappings;

	public CakewalkMapFile(string filename)
	{
		using BinaryReader binaryReader = new BinaryReader(File.OpenRead(filename), Encoding.Unicode);
		drumMappings = new List<CakewalkDrumMapping>();
		ReadMapHeader(binaryReader);
		for (int i = 0; i < mapEntryCount; i++)
		{
			drumMappings.Add(ReadMapEntry(binaryReader));
		}
		ReadMapName(binaryReader);
		ReadOutputsSection1(binaryReader);
		if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
		{
			ReadOutputsSection2(binaryReader);
			if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
			{
				ReadOutputsSection3(binaryReader);
			}
		}
	}

	private void ReadMapHeader(BinaryReader reader)
	{
		fileHeader1 = MapBlockHeader.Read(reader);
		fileHeader2 = MapBlockHeader.Read(reader);
		mapEntryCount = reader.ReadInt32();
	}

	private CakewalkDrumMapping ReadMapEntry(BinaryReader reader)
	{
		CakewalkDrumMapping cakewalkDrumMapping = new CakewalkDrumMapping();
		reader.ReadInt32();
		cakewalkDrumMapping.InNote = reader.ReadInt32();
		reader.ReadInt32();
		reader.ReadInt32();
		reader.ReadInt32();
		reader.ReadInt32();
		reader.ReadInt32();
		reader.ReadInt32();
		cakewalkDrumMapping.VelocityScale = reader.ReadSingle();
		cakewalkDrumMapping.Channel = reader.ReadInt32();
		cakewalkDrumMapping.OutNote = reader.ReadInt32();
		cakewalkDrumMapping.OutPort = reader.ReadInt32();
		cakewalkDrumMapping.VelocityAdjust = reader.ReadInt32();
		char[] array = reader.ReadChars(32);
		int i;
		for (i = 0; i < array.Length && array[i] != 0; i++)
		{
		}
		cakewalkDrumMapping.NoteName = new string(array, 0, i);
		return cakewalkDrumMapping;
	}

	private void ReadMapName(BinaryReader reader)
	{
		mapNameHeader = MapBlockHeader.Read(reader);
		char[] array = reader.ReadChars(34);
		int i;
		for (i = 0; i < array.Length && array[i] != 0; i++)
		{
		}
		mapName = new string(array, 0, i);
		reader.ReadBytes(98);
	}

	private void ReadOutputsSection1(BinaryReader reader)
	{
		outputs1Header = MapBlockHeader.Read(reader);
		outputs1Count = reader.ReadInt32();
		for (int i = 0; i < outputs1Count; i++)
		{
			reader.ReadBytes(20);
		}
	}

	private void ReadOutputsSection2(BinaryReader reader)
	{
		outputs2Header = MapBlockHeader.Read(reader);
		outputs2Count = reader.ReadInt32();
		for (int i = 0; i < outputs2Count; i++)
		{
			reader.ReadBytes(24);
		}
	}

	private void ReadOutputsSection3(BinaryReader reader)
	{
		outputs3Header = MapBlockHeader.Read(reader);
		if (outputs3Header.Length > 0)
		{
			outputs3Count = reader.ReadInt32();
			for (int i = 0; i < outputs3Count; i++)
			{
				reader.ReadBytes(36);
			}
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(_0096(107405290), fileHeader1);
		stringBuilder.AppendFormat(_0096(107405233), fileHeader2);
		stringBuilder.AppendFormat(_0096(107405208), mapEntryCount);
		foreach (CakewalkDrumMapping drumMapping in drumMappings)
		{
			stringBuilder.AppendFormat(_0096(107404667), drumMapping);
		}
		stringBuilder.AppendFormat(_0096(107404678), mapNameHeader);
		stringBuilder.AppendFormat(_0096(107404649), mapName);
		stringBuilder.AppendFormat(_0096(107404596), outputs1Header, outputs1Count);
		stringBuilder.AppendFormat(_0096(107404583), outputs2Header, outputs2Count);
		stringBuilder.AppendFormat(_0096(107404506), outputs3Header, outputs3Count);
		return stringBuilder.ToString();
	}

	static CakewalkMapFile()
	{
		Strings.CreateGetStringDelegate(typeof(CakewalkMapFile));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0096(107399934), _0096(107399897)), _0096(107399892), _0096(107399887)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0096(107399914)))
		{
			return;
		}
		throw new SecurityException(_0096(107399857));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
