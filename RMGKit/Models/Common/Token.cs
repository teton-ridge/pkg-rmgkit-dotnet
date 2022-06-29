using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Common
{
	/// <summary>
	/// Represents a simple token response.
	/// </summary>
	public class Token
	{
		[JsonPropertyName("token")]
		public string? Value { get; set; }

		public Token() {}
	}
}

