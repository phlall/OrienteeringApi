using AutoMapper;
using OrienteeringApi.Database;
using OrienteeringApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Mapping
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            this.CreateMap<ControlModel, Control>().ReverseMap();
            this.CreateMap<LessonControlModel, LessonControl>().ReverseMap();
            this.CreateMap<LessonGroupModel, LessonGroup>().ForMember(x => x.LessonSubject, i => i.Ignore());
            this.CreateMap<LessonGroup, LessonGroupModel>();
            this.CreateMap<QA, QAModel>(); 
            this.CreateMap<QAModel, QA>().ForMember(x => x.LessonSubject, i => i.Ignore());
            this.CreateMap<LessonSubjectModel, LessonSubject>().ReverseMap();
            this.CreateMap<MapModel, Map>().ReverseMap();
            this.CreateMap<SchoolModel, School>().ReverseMap();
            this.CreateMap<PupilModel, Pupil>().ReverseMap();
            this.CreateMap<LessonGroupSimpleModel, LessonGroup>().ForMember(x => x.LessonSubject, i => i.Ignore()); 
            this.CreateMap<LessonGroup, LessonGroupSimpleModel>();
            this.CreateMap<School, SchoolModel>().ReverseMap(); ;
            this.CreateMap<LessonGroupModel, LessonGroup>().ForMember(x => x.LessonGroupSessions, i => i.Ignore());
            this.CreateMap<LessonGroup, LessonGroupModel>()
                .ForMember(x => x.LessonSubject, o => o.MapFrom(x => x.LessonSubject.Name))
                .ForMember(x => x.LessonGroupSessions, o => o.MapFrom(x => x.LessonGroupSessions.Count()));
            this.CreateMap<LessonGroupSessionModel, LessonGroupSession>().ReverseMap();
        }
    }
}
