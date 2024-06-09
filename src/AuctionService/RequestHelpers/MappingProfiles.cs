using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // From (Aution + Item) to AuctionDto
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();

        // from CreateAuctionDto to (Aution + Item)
        // mapping some source properties to destination Item
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(dest => dest.Item, o => o.MapFrom(src => src));
        CreateMap<CreateAuctionDto, Item>();

    }
}
