using System.Collections.Generic;

namespace The_chViewer;

public class Response
{
	private int typeOfResponse;

	private int cntDataCur;

	private int nextIdx;

	private Config config;

	private List<object> data = new List<object>(100);

	private GpsRec minGpsRec;

	private GpsRec maxGpsRec;

	private int _id;

	private bool _isNull;

	public int Id { get; set; }

	public void addRec(object obj)
	{
		data.Add(obj);
	}

	public List<object> getRecs()
	{
		return data;
	}

	public int getCntDataCur()
	{
		return cntDataCur;
	}

	public int getNextIdx()
	{
		return nextIdx;
	}

	public int getTypeOfResponse()
	{
		return typeOfResponse;
	}

	public void setTypeOfResponse(int typeOfResponse)
	{
		this.typeOfResponse = typeOfResponse;
	}

	public void setCntDataCur(int cntDataCur)
	{
		this.cntDataCur = cntDataCur;
	}

	public void setNextIdx(int nextIdx)
	{
		this.nextIdx = nextIdx;
	}

	public Config getConfig()
	{
		return config;
	}

	public void setConfig(Config config)
	{
		this.config = config;
	}

	public GpsRec getMaxGpsRec()
	{
		return maxGpsRec;
	}

	public GpsRec getMinGpsRec()
	{
		return minGpsRec;
	}

	public void initMinMaxGpsRec(GpsRec init)
	{
		minGpsRec = new GpsRec(init);
		maxGpsRec = new GpsRec(init);
	}
}
