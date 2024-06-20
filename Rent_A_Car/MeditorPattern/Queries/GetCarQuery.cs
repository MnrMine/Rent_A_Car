using MediatR;
using Microsoft.AspNetCore.Localization;
using Rent_A_Car.MeditorPattern.Results;

namespace Rent_A_Car.MeditorPattern.Queries
{
    public class GetCarQuery:IRequest<List<GetCarQueryResult>>  
    {
    }
}
