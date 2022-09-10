using System.Collections.Generic;

public class GClass2
{
	public static readonly GClass2 gclass2_0 = new GClass2();

	private Dictionary<string, GStruct0> dictionary_0;

	private GClass2()
	{
		dictionary_0 = new Dictionary<string, GStruct0>();
		dictionary_0.Add("w1", new GStruct0("w1", new KeyValuePair<string, int>("Lumber", 25)));
		dictionary_0.Add("w2", new GStruct0("w2", new KeyValuePair<string, int>("Lumber", 25)));
		dictionary_0.Add("w3", new GStruct0("w3", new KeyValuePair<string, int>("Lumber", 25), new KeyValuePair<string, int>("Crop", 25)));
		dictionary_0.Add("w4", new GStruct0("w4", new KeyValuePair<string, int>("Clay", 25)));
		dictionary_0.Add("w5", new GStruct0("w5", new KeyValuePair<string, int>("Clay", 25)));
		dictionary_0.Add("w6", new GStruct0("w6", new KeyValuePair<string, int>("Clay", 25), new KeyValuePair<string, int>("Crop", 25)));
		dictionary_0.Add("w7", new GStruct0("w7", new KeyValuePair<string, int>("Iron", 25)));
		dictionary_0.Add("w8", new GStruct0("w8", new KeyValuePair<string, int>("Iron", 25)));
		dictionary_0.Add("w9", new GStruct0("w9", new KeyValuePair<string, int>("Iron", 25), new KeyValuePair<string, int>("Crop", 25)));
		dictionary_0.Add("w10", new GStruct0("w10", new KeyValuePair<string, int>("Crop", 25)));
		dictionary_0.Add("w11", new GStruct0("w11", new KeyValuePair<string, int>("Crop", 25)));
		dictionary_0.Add("w12", new GStruct0("w12", new KeyValuePair<string, int>("Crop", 50)));
	}

	public string method_0(string string_0)
	{
		if (!dictionary_0.ContainsKey(string_0.ToLower()))
		{
			return "Unknown";
		}
		GStruct0 gStruct = dictionary_0[string_0.ToLower()];
		string text = "";
		for (int i = 0; i < gStruct.method_1().Count; i++)
		{
			KeyValuePair<string, int> keyValuePair = gStruct.method_1()[i];
			object obj = text;
			text = string.Concat(obj, keyValuePair.Key, ": ", keyValuePair.Value, "%");
			if (i < gStruct.method_1().Count - 1)
			{
				text += ", ";
			}
		}
		return text;
	}

	public int method_1(string string_0)
	{
		if (!dictionary_0.ContainsKey(string_0.ToLower()))
		{
			return 0;
		}
		return dictionary_0[string_0.ToLower()].method_2();
	}
}
