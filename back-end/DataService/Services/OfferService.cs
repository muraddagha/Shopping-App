using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Offer;

namespace DataService.Services
{
    public interface IOfferService : IService<Offer, OfferDto, OfferCreateDto, OfferUpdateDto>
    {

    }
    public class OfferService : Service<Offer, OfferDto, OfferCreateDto, OfferUpdateDto>, IOfferService
    {
        public OfferService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}