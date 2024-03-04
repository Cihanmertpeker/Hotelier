using AutoMapper;
using Hotelier.EntityLayer.Concrete;
using Hotelier.WebUI.Dtos.AboutDto;
using Hotelier.WebUI.Dtos.BookingDto;
using Hotelier.WebUI.Dtos.LoginDto;
using Hotelier.WebUI.Dtos.RegisterDto;
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

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
        }
    }
}
