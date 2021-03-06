using System;
using Concepts;
using Dolittle.Commands;

namespace Domain.DataCollector.Changing
{
    public class ChangeLocation : ICommand
    {
        public Guid DataCollectorId { get; set; }
        public Location Location { get; set; }
    }
}