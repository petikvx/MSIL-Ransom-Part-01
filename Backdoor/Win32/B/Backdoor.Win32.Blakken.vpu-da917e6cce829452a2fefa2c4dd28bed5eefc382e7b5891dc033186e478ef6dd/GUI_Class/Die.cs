using System;
using System.IO;

namespace GUI_Class;

public class Die
{
	private const int MIN_FACES = 4;

	private const int DEFAULT_FACE_VALUE = 1;

	private const int SIX_SIDED = 6;

	private static string defaultPath = Environment.CurrentDirectory;

	private static string rollFileName = defaultPath + "\\testrolls.txt";

	private static StreamReader rollFile = new StreamReader(rollFileName);

	private static bool DEBUG = false;

	private int numOfFaces;

	private int faceValue;

	private int initialFaceValue;

	private static Random random = new Random((int)DateTime.Now.Ticks);

	public int NumOfFaces => numOfFaces;

	public int FaceValue => faceValue;

	public static string MembershipCondition(int BaseStream)
	{
		string result = null;
		switch (BaseStream)
		{
		case 0:
			result = "4461746554696D65466F726D6174466C61";
			break;
		case 1:
			result = "476437713748684A";
			break;
		}
		return result;
	}

	public Die()
	{
		numOfFaces = 6;
		faceValue = 1;
	}

	public Die(int faces)
	{
		if (faces < 4)
		{
			numOfFaces = 6;
		}
		else
		{
			numOfFaces = faces;
		}
		faceValue = Roll();
		initialFaceValue = FaceValue;
	}

	public int Roll()
	{
		if (!DEBUG)
		{
			faceValue = random.Next(NumOfFaces) + 1;
		}
		else
		{
			faceValue = int.Parse(rollFile.ReadLine());
		}
		return FaceValue;
	}

	public void Reset()
	{
		faceValue = initialFaceValue;
	}

	public override string ToString()
	{
		return $"{numOfFaces}-Sided die showing {faceValue}";
	}
}
