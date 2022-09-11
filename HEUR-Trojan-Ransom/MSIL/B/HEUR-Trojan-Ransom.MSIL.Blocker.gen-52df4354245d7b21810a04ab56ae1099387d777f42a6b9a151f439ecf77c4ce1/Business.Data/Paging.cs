using System;
using System.Collections.Generic;
using Business.Utils;
using Newtonsoft.Json;

namespace Business.Data;

public struct Paging<T> : IPaging
{
	public List<T> Data { get; set; }

	public int Length { get; set; }

	public int CurrentPage { get; set; }

	public int Count { get; set; }

	public int CountPage { get; set; }

	dynamic IPaging.Data
	{
		get
		{
			return Data;
		}
		set
		{
			Data = value;
		}
	}

	public static implicit operator Paging<T>(string value)
	{
		return Help2.TryJsonDeserialize<Paging<T>>(value, Array.Empty<JsonConverter>());
	}

	public static implicit operator Paging<T>(byte[] value)
	{
		return value.TryBinaryDeserialize<Paging<T>>();
	}

	public override string ToString()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public byte[] ToBytes()
	{
		return this.BinarySerialize();
	}
}
