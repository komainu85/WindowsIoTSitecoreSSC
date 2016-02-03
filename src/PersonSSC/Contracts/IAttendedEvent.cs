using Sitecore.Analytics.Model.Framework;

namespace PersonSSC.Contracts
{
    public interface IAttendedEvent : IFacet
    {
        bool Attended { get; set; }
    }
}