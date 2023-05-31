namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.EtrThresholds
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.Protocol.Tables.AlarmThresholds.Etr;

	public class CreateEtrThreshold : Message
	{
		public Preset Preset { get; set; }
	}

	public class CreateEtrThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreateEtrThreshold Request { get; set; }

		public string ThresholdID { get; set; }
	}

	public class EditEtrThreshold : Message
	{
		public string PresetToUpdateName { get; set; }

		public Preset Preset { get; set; }
	}

	public class EditEtrThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditEtrThreshold Request { get; set; }

		public string PresetId { get; set; }
	}

	public class DeleteEtrThresholds : Message
	{
		public IEnumerable<string> PresetNamesToDelete { get; set; }
	}

	public class DeleteEtrThresholdsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllStreamsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteEtrThresholds Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
