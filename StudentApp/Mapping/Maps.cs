using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentApp.Core.Models;
using StudentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Student, StudentVM>()
          .ForMember(a => a.LevelList, m => m.Ignore())
                .ReverseMap();
            CreateMap<Student, ShowStudentVM>().ReverseMap();
            CreateMap<Level, LevelVM>().ReverseMap();
            CreateMap<Level, IEnumerable<SelectListItem>>().ReverseMap();
        }
    }
}
