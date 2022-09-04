using System.IO;

namespace The_chViewer;

public class Config
{
	private sbyte logFormat = -1;

	private sbyte disableLogSpeed = -1;

	private int speedThres = -1;

	private sbyte disableLogDist = -1;

	private int distThres = -1;

	private int swATime = -1;

	private int swBTime = -1;

	private int swCTime = -1;

	private short unk1 = -1;

	private sbyte swATimeOrDist = -1;

	private sbyte swBTimeOrDist = -1;

	private sbyte swCTimeOrDist = -1;

	private int swADist = -1;

	private int swBDist = -1;

	private int swCDist = -1;

	private sbyte unk2 = -1;

	private int remainder = -1;

	private int unk3 = -1;

	private int unk4 = -1;

	public Config(BinaryReader buf)
	{
		logFormat = buf.ReadSByte();
		disableLogSpeed = buf.ReadSByte();
		speedThres = buf.ReadInt32();
		disableLogDist = buf.ReadSByte();
		distThres = buf.ReadInt32();
		swATime = buf.ReadByte();
		swBTime = buf.ReadByte();
		swCTime = buf.ReadByte();
		unk1 = buf.ReadInt16();
		swATimeOrDist = buf.ReadSByte();
		swBTimeOrDist = buf.ReadSByte();
		swCTimeOrDist = buf.ReadSByte();
		swADist = buf.ReadInt32();
		swBDist = buf.ReadInt32();
		swCDist = buf.ReadInt32();
		unk2 = buf.ReadSByte();
		remainder = buf.ReadByte();
		unk3 = buf.ReadByte();
		unk4 = buf.ReadByte();
	}

	public string toString()
	{
		return "[Config: logFormat = " + logFormat + ",disableLogSpeed = " + disableLogSpeed + ",speedThres = " + speedThres + ",disableLogDist = " + disableLogDist + ",distThres = " + distThres + ",swATime = " + swATime + ",swBTime = " + swBTime + ",swCTime = " + swCTime + ",unk1 = " + unk1 + ",swATimeOrDist = " + swATimeOrDist + ",swBTimeOrDist = " + swBTimeOrDist + ",swCTimeOrDist = " + swCTimeOrDist + ",swADist = " + swADist + ",swBDist = " + swBDist + ",swCDist = " + swCDist + ",unk2 = " + unk2 + ",remainder = " + remainder + ",unk3 = " + unk3 + ",unk4 = " + unk4;
	}

	public void write(BinaryWriter buf)
	{
		buf.BaseStream.Seek(5L, SeekOrigin.Begin);
		buf.Write(logFormat);
		buf.Write(disableLogSpeed);
		buf.Write(speedThres);
		buf.Write(disableLogDist);
		buf.Write(distThres);
		buf.Write(swATime);
		buf.Write(swBTime);
		buf.Write(swCTime);
		buf.Write(unk1);
		buf.Write(swATimeOrDist);
		buf.Write(swBTimeOrDist);
		buf.Write(swCTimeOrDist);
		buf.Write(swADist);
		buf.Write(swBDist);
		buf.Write(swCDist);
		buf.Write(unk2);
	}

	public sbyte getDisableLogDist()
	{
		return disableLogDist;
	}

	public void setDisableLogDist(sbyte disableLogDist)
	{
		this.disableLogDist = disableLogDist;
	}

	public sbyte getDisableLogSpeed()
	{
		return disableLogSpeed;
	}

	public void setDisableLogSpeed(sbyte disableLogSpeed)
	{
		this.disableLogSpeed = disableLogSpeed;
	}

	public int getDistThres()
	{
		return distThres;
	}

	public void setDistThres(int distThres)
	{
		this.distThres = distThres;
	}

	public sbyte getLogFormat()
	{
		return logFormat;
	}

	public void setLogFormat(sbyte logFormat)
	{
		this.logFormat = logFormat;
	}

	public int getSpeedThres()
	{
		return speedThres;
	}

	public void setSpeedThres(int speedThres)
	{
		this.speedThres = speedThres;
	}

	public int getSwADist()
	{
		return swADist;
	}

	public void setSwADist(int swADist)
	{
		this.swADist = swADist;
	}

	public int getSwATime()
	{
		return swATime;
	}

	public void setSwATime(int swATime)
	{
		this.swATime = swATime;
	}

	public sbyte getSwATimeOrDist()
	{
		return swATimeOrDist;
	}

	public void setSwATimeOrDist(sbyte swATimeOrDist)
	{
		this.swATimeOrDist = swATimeOrDist;
	}

	public int getSwBDist()
	{
		return swBDist;
	}

	public void setSwBDist(int swBDist)
	{
		this.swBDist = swBDist;
	}

	public int getSwBTime()
	{
		return swBTime;
	}

	public void setSwBTime(int swBTime)
	{
		this.swBTime = swBTime;
	}

	public sbyte getSwBTimeOrDist()
	{
		return swBTimeOrDist;
	}

	public void setSwBTimeOrDist(sbyte swBTimeOrDist)
	{
		this.swBTimeOrDist = swBTimeOrDist;
	}

	public int getSwCDist()
	{
		return swCDist;
	}

	public void setSwCDist(int swCDist)
	{
		this.swCDist = swCDist;
	}

	public int getSwCTime()
	{
		return swCTime;
	}

	public void setSwCTime(int swCTime)
	{
		this.swCTime = swCTime;
	}

	public sbyte getSwCTimeOrDist()
	{
		return swCTimeOrDist;
	}

	public void setSwCTimeOrDist(sbyte swCTimeOrDist)
	{
		this.swCTimeOrDist = swCTimeOrDist;
	}

	public short getUnk1()
	{
		return unk1;
	}

	public void setUnk1(short unk1)
	{
		this.unk1 = unk1;
	}

	public sbyte getUnk2()
	{
		return unk2;
	}

	public void setUnk2(sbyte unk2)
	{
		this.unk2 = unk2;
	}

	public int getRemainder()
	{
		return remainder;
	}

	public int getUnk3()
	{
		return unk3;
	}

	public int getUnk4()
	{
		return unk4;
	}
}
