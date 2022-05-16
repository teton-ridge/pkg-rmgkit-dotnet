using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Common
{
	/// <summary>
	/// Represents a simple token response.
	/// </summary>
	[DataContract]
	public class Token
	{
		[DataMember(Name = "token")]
		public string? Value { get; set; }

		public Token() {}
	}
}

