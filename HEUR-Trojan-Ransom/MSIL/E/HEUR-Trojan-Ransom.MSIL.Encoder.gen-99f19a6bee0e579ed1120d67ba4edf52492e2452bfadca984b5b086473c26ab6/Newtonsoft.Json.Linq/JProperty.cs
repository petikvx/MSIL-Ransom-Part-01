using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq;

public class JProperty : JContainer
{
	private class JPropertyList : IEnumerable, IEnumerable<JToken>, IList<JToken>, ICollection<JToken>
	{
		internal JToken? _token;

		public int Count
		{
			get
			{
				if (_token == null)
				{
					return 0;
				}
				return 1;
			}
		}

		public bool IsReadOnly => false;

		public JToken this[int index]
		{
			get
			{
				if (index != 0)
				{
					throw new IndexOutOfRangeException();
				}
				return _token;
			}
			set
			{
				if (index != 0)
				{
					throw new IndexOutOfRangeException();
				}
				_token = value;
			}
		}

		public IEnumerator<JToken> GetEnumerator()
		{
			if (_token != null)
			{
				yield return _token;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(JToken item)
		{
			_token = item;
		}

		public void Clear()
		{
			_token = null;
		}

		public bool Contains(JToken item)
		{
			return _token == item;
		}

		public void CopyTo(JToken[] array, int arrayIndex)
		{
			if (_token != null)
			{
				array[arrayIndex] = _token;
			}
		}

		public bool Remove(JToken item)
		{
			if (_token == item)
			{
				_token = null;
				return true;
			}
			return false;
		}

		public int IndexOf(JToken item)
		{
			if (_token != item)
			{
				return -1;
			}
			return 0;
		}

		public void Insert(int index, JToken item)
		{
			if (index == 0)
			{
				_token = item;
			}
		}

		public void RemoveAt(int index)
		{
			if (index == 0)
			{
				_token = null;
			}
		}
	}

	private readonly JPropertyList _content = new JPropertyList();

	private readonly string _name;

	protected override IList<JToken> ChildrenTokens => _content;

	public string Name
	{
		[DebuggerStepThrough]
		get
		{
			return _name;
		}
	}

	public new JToken Value
	{
		[DebuggerStepThrough]
		get
		{
			return _content._token;
		}
		set
		{
			CheckReentrancy();
			JToken item = value ?? JValue.CreateNull();
			if (_content._token == null)
			{
				InsertItem(0, item, skipParentCheck: false);
			}
			else
			{
				SetItem(0, item);
			}
		}
	}

	public override JTokenType Type
	{
		[DebuggerStepThrough]
		get
		{
			return JTokenType.Property;
		}
	}

	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		Task task = writer.WritePropertyNameAsync(_name, cancellationToken);
		if (task.IsCompletedSucessfully())
		{
			return WriteValueAsync(writer, cancellationToken, converters);
		}
		return WriteToAsync(task, writer, cancellationToken, converters);
	}

	private async Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		await task.ConfigureAwait(continueOnCapturedContext: false);
		await WriteValueAsync(writer, cancellationToken, converters).ConfigureAwait(continueOnCapturedContext: false);
	}

	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters)
	{
		JToken value = Value;
		if (value == null)
		{
			return writer.WriteNullAsync(cancellationToken);
		}
		return value.WriteToAsync(writer, cancellationToken, converters);
	}

	public new static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(reader, null, cancellationToken);
	}

	public new static async Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (reader.TokenType == JsonToken.None && !(await reader.ReadAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)))
		{
			throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader.");
		}
		await reader.MoveToContentAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (reader.TokenType != JsonToken.PropertyName)
		{
			throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		}
		JProperty p = new JProperty((string)reader.Value);
		p.SetLineInfo(reader as IJsonLineInfo, settings);
		await p.ReadTokenFromAsync(reader, settings, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return p;
	}

	public JProperty(JProperty other)
		: base(other)
	{
		_name = other.Name;
	}

	internal override JToken GetItem(int index)
	{
		if (index != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return Value;
	}

	internal override void SetItem(int index, JToken? item)
	{
		if (index != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (!JContainer.IsTokenUnchanged(Value, item))
		{
			((JObject)base.Parent)?.InternalPropertyChanging(this);
			base.SetItem(0, item);
			((JObject)base.Parent)?.InternalPropertyChanged(this);
		}
	}

	internal override bool RemoveItem(JToken? item)
	{
		throw new JsonException("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
	}

	internal override void RemoveItemAt(int index)
	{
		throw new JsonException("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
	}

	internal override int IndexOfItem(JToken? item)
	{
		if (item == null)
		{
			return -1;
		}
		return _content.IndexOf(item);
	}

	internal override void InsertItem(int index, JToken? item, bool skipParentCheck)
	{
		if (item == null || item!.Type != JTokenType.Comment)
		{
			if (Value != null)
			{
				throw new JsonException("{0} cannot have multiple values.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
			}
			base.InsertItem(0, item, skipParentCheck: false);
		}
	}

	internal override bool ContainsItem(JToken? item)
	{
		return Value == item;
	}

	internal override void MergeItem(object content, JsonMergeSettings? settings)
	{
		JToken jToken = (content as JProperty)?.Value;
		if (jToken != null && jToken.Type != JTokenType.Null)
		{
			Value = jToken;
		}
	}

	internal override void ClearItems()
	{
		throw new JsonException("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
	}

	internal override bool DeepEquals(JToken node)
	{
		if (node is JProperty jProperty && _name == jProperty.Name)
		{
			return ContentsEqual(jProperty);
		}
		return false;
	}

	internal override JToken CloneToken()
	{
		return new JProperty(this);
	}

	internal JProperty(string name)
	{
		ValidationUtils.ArgumentNotNull(name, "name");
		_name = name;
	}

	public JProperty(string name, params object[] content)
		: this(name, (object?)content)
	{
	}

	public JProperty(string name, object? content)
	{
		ValidationUtils.ArgumentNotNull(name, "name");
		_name = name;
		Value = (IsMultiContent(content) ? new JArray(content) : JContainer.CreateFromContent(content));
	}

	public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
	{
		writer.WritePropertyName(_name);
		JToken value = Value;
		if (value != null)
		{
			value.WriteTo(writer, converters);
		}
		else
		{
			writer.WriteNull();
		}
	}

	internal override int GetDeepHashCode()
	{
		return _name.GetHashCode() ^ (Value?.GetDeepHashCode() ?? 0);
	}

	public new static JProperty Load(JsonReader reader)
	{
		return Load(reader, null);
	}

	public new static JProperty Load(JsonReader reader, JsonLoadSettings? settings)
	{
		if (reader.TokenType == JsonToken.None && !reader.Read())
		{
			throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader.");
		}
		reader.MoveToContent();
		if (reader.TokenType != JsonToken.PropertyName)
		{
			throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		}
		JProperty jProperty = new JProperty((string)reader.Value);
		jProperty.SetLineInfo(reader as IJsonLineInfo, settings);
		jProperty.ReadTokenFrom(reader, settings);
		return jProperty;
	}
}
