﻿namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.PidThresholds
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App Message allowing to add new entries to the PID Thresholds table.
	/// </summary>
	public class CreatePidThreshold : Message
	{
		public PidThresholdData ThresholdData { get; set; }
	}

	public class CreatePidThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreatePidThreshold Request { get; set; }

		public string ThresholdID { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to edit existing entries from the PID Thresholds table.
	/// </summary>
	public class EditPidThreshold : Message
	{
		public string ThresholdToUpdateName { get; set; }

		public PidThresholdData ThresholdData { get; set; }
	}

	public class EditPidThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditPidThreshold Request { get; set; }

		public string ThresholdId { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to delete existing entries from the PID Thresholds table.
	/// </summary>
	public class DeletePidThresholds : Message
	{
		public IEnumerable<string> ThresholdToDeleteNames { get; set; }
	}

	public class DeletePidThresholdsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllThresholdsDeleted { get; set; }

		public string Description { get; set; }

		public DeletePidThresholds Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
