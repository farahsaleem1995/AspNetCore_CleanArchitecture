using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
  public class CourseService : ICourseService
  {
    private readonly ICourseRepository _courseRepository;
    private readonly IMapper _mapper;

    public CourseService(ICourseRepository courseRepository, IMapper mapper)
    {
      _courseRepository = courseRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<CourseViewModel>> GetCourses()
    {
      var courses = await _courseRepository.GetCourses();
      var courseViewModels = _mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(courses);
      return courseViewModels;
    }
  }
}
