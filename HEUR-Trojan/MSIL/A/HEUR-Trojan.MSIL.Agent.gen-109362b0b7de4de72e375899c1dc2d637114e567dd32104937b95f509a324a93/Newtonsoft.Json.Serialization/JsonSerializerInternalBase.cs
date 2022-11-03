using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization;

internal abstract class JsonSerializerInternalBase
{
	private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
	{
		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}
	}

	private ErrorContext? _currentErrorContext;

	private BidirectionalDictionary<string, object>? _mappings;

	internal readonly JsonSerializer Serializer;

	internal readonly ITraceWriter? TraceWriter;

	protected JsonSerializerProxy? InternalSerializer;

	internal BidirectionalDictionary<string, object> DefaultReferenceMappings
	{
		get
		{
			if (_mappings == null)
			{
				_mappings = new BidirectionalDictionary<string, object>(EqualityComparer<string>.Default, new ReferenceEqualsEqualityComparer(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
			}
			return _mappings;
		}
	}

	protected JsonSerializerInternalBase(JsonSerializer serializer)
	{
		ValidationUtils.ArgumentNotNull(serializer, "serializer");
		Serializer = serializer;
		TraceWriter = serializer.TraceWriter;
	}

	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract? containerContract, JsonProperty property)
	{
		return property.NullValueHandling ?? containerContract?.ItemNullValueHandling ?? Serializer._nullValueHandling;
	}

	private ErrorContext GetErrorContext(object? currentObject, object? member, string path, Exception error)
	{
		if (_currentErrorContext == null)
		{
			_currentErrorContext = new ErrorContext(currentObject, member, path, error);
		}
		if (_currentErrorContext!.Error != error)
		{
			throw new InvalidOperationException("Current error context error is different to requested error.");
		}
		return _currentErrorContext;
	}

	protected void ClearErrorContext()
	{
		if (_currentErrorContext == null)
		{
			throw new InvalidOperationException("Could not clear error context. Error context is already null.");
		}
		_currentErrorContext = null;
	}

	protected bool IsErrorHandled(object? currentObject, JsonContract? contract, object? keyValue, IJsonLineInfo? lineInfo, string path, Exception ex)
	{
		ErrorContext errorContext = GetErrorContext(currentObject, keyValue, path, ex);
		if (TraceWriter != null && TraceWriter!.LevelFilter >= TraceLevel.Error && !errorContext.Traced)
		{
			errorContext.Traced = true;
			string text = ((GetType() == typeof(JsonSerializerInternalWriter)) ? "Error serializing" : "Error deserializing");
			if (contract != null)
			{
				text = text + " " + contract!.UnderlyingType;
			}
			text = text + ". " + ex.Message;
			if (!(ex is JsonException))
			{
				text = JsonPosition.FormatMessage(lineInfo, path, text);
			}
			TraceWriter!.Trace(TraceLevel.Error, text, ex);
		}
		if (contract != null && currentObject != null)
		{
			contract!.InvokeOnError(currentObject, Serializer.Context, errorContext);
		}
		if (!errorContext.Handled)
		{
			Serializer.OnError(new ErrorEventArgs(currentObject, errorContext));
		}
		return errorContext.Handled;
	}
}
