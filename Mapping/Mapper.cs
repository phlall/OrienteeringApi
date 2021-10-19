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
            this.CreateMap<LessonControlModel, LessonControl>().ForMember(x => x.QAId, o => o.MapFrom(x => x.Id)).ForMember(x => x.Id, i => i.Ignore());
            this.CreateMap<LessonControl, LessonControlModel>();
            this.CreateMap<LessonGroupModel, LessonGroup>().ForMember(x => x.LessonSubject, i => i.Ignore());
            //this.CreateMap<LessonGroup, LessonGroupModel>();
            this.CreateMap<QA, QAModel>(); 
            this.CreateMap<QAModel, QA>().ForMember(x => x.LessonSubject, i => i.Ignore());
            this.CreateMap<SchoolModel, School>().ReverseMap();
            this.CreateMap<PupilModel, Pupil>().ReverseMap();
            this.CreateMap<LessonGroupSimpleModel, LessonGroup>().ForMember(x => x.LessonSubject, i => i.Ignore()); 
            this.CreateMap<LessonGroup, LessonGroupSimpleModel>();
            this.CreateMap<School, SchoolModel>().ReverseMap();
            this.CreateMap<LessonGroupModel, LessonGroup>().ForMember(x => x.LessonGroupSessions, i => i.Ignore());
            this.CreateMap<LessonGroup, LessonGroupModel>()
                .ForMember(x => x.LessonSubject, o => o.MapFrom(x => x.LessonSubject.Name))
                .ForMember(x => x.LessonGroupSessions, o => o.MapFrom(x => x.LessonGroupSessions.Count()));
            this.CreateMap<LessonGroupSessionModel, LessonGroupSession>().ReverseMap();
            this.CreateMap<LessonSubjectModel, LessonSubject>().ReverseMap();
            this.CreateMap<MapModel, Map>();
            //this.CreateMap<Map, MapModel>().ForMember(x => x.MapNodes, i => i.Ignore());
            this.CreateMap<Map, MapModel>();
            this.CreateMap<NewMapModel, Map>().ForMember(x => x.MapImage, i => i.Ignore()).ForMember(x => x.MapImageId, i => i.Ignore());
            this.CreateMap<MapNode, MapNodeModel>().ReverseMap();
            this.CreateMap<MapNode, MapNodeChildModel>().ReverseMap();
            this.CreateMap<MapImage, MapImageModel>().ReverseMap();
            this.CreateMap<MapImage, MapImageChildModel>().ReverseMap();
           // this.CreateMap<MapImage, MapImageModel>().ForMember(x => x.Maps, i => i.Ignore()).ForMember(x => x.School, i => i.Ignore()); 
        }
    }
}
