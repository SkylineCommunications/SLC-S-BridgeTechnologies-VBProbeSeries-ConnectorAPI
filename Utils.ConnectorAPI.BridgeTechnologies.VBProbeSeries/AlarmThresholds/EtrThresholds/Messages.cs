namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.EtrThresholds
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreateEtrThreshold : Message
	{
		public EtrThresholdData ThresholdData { get; set; }
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
		public string ThresholdToUpdateName { get; set; }

		public EtrThresholdData ThresholdData { get; set; }
	}

	public class EditEtrThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditEtrThreshold Request { get; set; }

		public string ThresholdId { get; set; }
	}

	public class DeleteEtrThresholds : Message
	{
		public IEnumerable<string> ThresholdToDeleteNames { get; set; }
	}

	public class DeleteEtrThresholdsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllThresholdsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteEtrThresholds Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
