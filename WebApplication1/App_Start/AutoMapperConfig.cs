using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Site.Model.layer;
using Site.Views.ViewModels;

namespace Site.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper mapper;

        public static void Configuration()
        {
            MapperConfiguration configuration = new MapperConfiguration(t =>
            {

                t.CreateMap<Drs, DrsViewModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                t.CreateMap<DrsViewModel, Drs>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();

                t.CreateMap<Nurses, NursesViewModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                t.CreateMap<NursesViewModel, Nurses>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();


                t.CreateMap<Patients, PatientsViewModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                t.CreateMap<PatientsViewModel, Patients>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();


                t.CreateMap<RolesViewModel, RolesViewModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                t.CreateMap<RolesViewModel, RolesViewModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();


            });
            mapper = configuration.CreateMapper();
        }
    }
}