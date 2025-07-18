﻿using AutoMapper;
using orchid_backend_net.Application.Common.Mappings;
using orchid_backend_net.Domain.Entities;

namespace orchid_backend_net.Application.Sample
{
    public class SampleDTO : IMapFrom<Samples>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Dob { get; set; }
        public bool Status { get; set; }

        public SampleDTO Create(string id, string name, string description, DateOnly dob)
        {
            return new SampleDTO { ID = id, Name = name, Description = description, Dob = dob };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Samples, SampleDTO>()
                .ReverseMap();
        }
    }
}
