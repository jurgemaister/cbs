using System;
using Dolittle.ReadModels;

namespace Read.HealthRisks
{
    public class HealthRisk : IReadModel
    {
        public Guid Id { get; set; }

        public int ReadableId { get; set; }
        public string Name { get; set; }

        public HealthRisk(Guid id)
        {
            Id = id;
        }
    }
}
