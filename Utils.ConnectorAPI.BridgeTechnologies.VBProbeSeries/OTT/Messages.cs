namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.OTT
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreateOttChannel : Message
	{
		public OttChannelData ChannelData { get; set; }
	}

	public class CreateOttChannelResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreateOttChannel Request { get; set; }

		public string ChannelId { get; set; }
	}

	public class EditOttChannel : Message
	{
		public string ChannelId { get; set; }

		public OttChannelData ChannelData { get; set; }
	}

	public class EditOttChannelResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditOttChannel Request { get; set; }

		public string ChannelId { get; set; }
	}

	public class DeleteOttChannels : Message
	{
		public string[] ChannelIds { get; set; }

		public bool DeleteAllOrNone { get; set; }
	}

	public class DeleteOttChannelsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllChannelsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteOttChannels Request { get; set; }

		public List<string> DeletedIds { get; set; }

		public List<string> FoundButNotDeletedIds { get; set; }

		public List<string> NotFoundIds { get; set; }
	}
}
