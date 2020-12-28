﻿using AutoMapper;
using QuizMania.WebAPI.Models;
using QuizMania.WebAPI.DTOs;

namespace QuizMania.WebAPI.Profiles
{
    public class QuestionAnswerProfile : Profile
    {
        public QuestionAnswerProfile()
        {
            CreateMap<QuestionAnswer, QuestionAnswerReadDTO>().ForMember(dest => dest.ChosenAnswerIds, opt => opt.MapFrom(src=> src.ChosenAnswers));
        }
    }
}
