using AutoMapper;
using RSwitch.AMBS.Model.DTO.Auth;
using RSwitch.AMBS.Model.User;
using static RSwitch.AMBS.Web.Contracts.Constants.HttpCustomHeaders;

namespace RSwitch.AMBS.Web.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //** Domain to Resource Start **//
            CreateMap<LoginUser, LoginRequestDTO>();
            CreateMap<LoginUser, LoginResponseDTO>();

            //CreateMap<MemberPostRequestDTO, P_MemberInsertRequestDTO>()
            //    .ForMember(src => src.FirstName, opt => opt.MapFrom(dest => dest.MemberKYCInformation.FirstName))
            //    .ForMember(src => src.MiddleName, opt => opt.MapFrom(dest => dest.MemberKYCInformation.MiddleName))

            //CreateMap<MemberDocumentsPostRequestDTO, P_MemberDocuments>().ReverseMap();

            //** Domain to Resource End **//

            //** Resource to Domain Start **//

            CreateMap<LoginResponseDTO, LoginUser>().ForMember(des => des.Id, opt => opt.Ignore())
                .ForMember(x => x.Login, opt => opt.Ignore());
            //CreateMap<RoleResponseDTO, Role>();

            //** Resource to Domain End **//
        }
    }
}
