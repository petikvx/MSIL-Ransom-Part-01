using System;

namespace TryPaper;

public class ServiceResponse<T>
{
	public T Result { get; set; }

	public bool Success { get; private set; }

	public Guid ResponseId { get; private set; }

	public string Message { get; private set; }

	public ServiceResponse(bool success, string message)
	{
		Success = success;
		Message = message;
	}
}
