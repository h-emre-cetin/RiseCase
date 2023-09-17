using RiseCase.Models;

namespace RiseCase.Repositories.Abstract
{
    public interface IContactReportRepository
    {
        ContactReportModel GetReportByLocation();

        ContactReportModel GetReportOfLocationRank();

        ContactReportModel GetReportOfLocationContactCount(string location);

        ContactReportModel GetReportOfLocationPhoneNumberCount(string location);
    }
}
