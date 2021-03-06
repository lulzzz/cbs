using System;
using Dolittle.Events;

namespace Events.DataCollector
{
    public class DataCollectorUserInformationChanged : IEvent
    {
        public Guid DataCollectorId { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }

        public int YearOfBirth { get; set; }
        public int Sex { get; set; }

        public string Region { get; set; }
        public string District { get; set; }

        public DataCollectorUserInformationChanged(Guid dataCollectorId, string fullName, string displayName, int yearOfBirth, int sex, string region, string district)
        {
            DataCollectorId = dataCollectorId;
            FullName = fullName;
            DisplayName = displayName;
            YearOfBirth = yearOfBirth;
            Sex = sex;
            Region = region;
            District = district;
        }
    }
}