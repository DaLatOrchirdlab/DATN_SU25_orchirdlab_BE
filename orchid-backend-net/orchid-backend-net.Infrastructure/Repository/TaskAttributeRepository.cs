﻿using AutoMapper;
using orchid_backend_net.Domain.Entities;
using orchid_backend_net.Domain.IRepositories;
using orchid_backend_net.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orchid_backend_net.Infrastructure.Repository
{
    public class TaskAttributeRepository(OrchidDbContext context, IMapper mapper) : RepositoryBase<TaskAttribute, TaskAttribute, OrchidDbContext>(context, mapper), ITaskAttributeRepository
    {
    }
}
