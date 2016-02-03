using System;
using PersonSSC.Contracts;
using Sitecore.Analytics.Model.Framework;

namespace PersonSSC.Data
{
    [Serializable]
    public class AttendedEvent : Facet, IAttendedEvent
    {
        public bool Attended { get; set; }
    }
}