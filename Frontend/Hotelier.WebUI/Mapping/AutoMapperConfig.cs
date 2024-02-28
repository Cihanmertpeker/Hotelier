using AutoMapper;
using Hotelier.EntityLayer.Concrete;
using Hotelier.WebUI.Dtos.ServiceDto;
using Hotelier.WebUI.Dtos.StaffDto;
using Hotelier.WebUI.Dtos.SubscribeDto;
using Hotelier.WebUI.Dtos.TestimonialDto;

namespace Hotelier.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

        }
    }
}
