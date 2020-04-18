using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Mapping
{
  public class CourseProfile : Profile
  {
    public CourseProfile()
    {
      CreateMap<Course, CourseViewModel>();
    }
  }
}
