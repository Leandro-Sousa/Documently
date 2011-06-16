﻿using System;

namespace Documently.Domain.Events
{
	//public interface IDomainEvent
	//{
	//    Guid AggregateId { get; set; }
	//    int Version { get; set; }
	//}

	[Serializable]
	public class DomainEvent
	{
		private Guid _AggregateId;
		public Guid AggregateId
		{
			get { return _AggregateId; }
			set { _AggregateId = value; }
		}

		//public int Version { get; set; }
	}
}