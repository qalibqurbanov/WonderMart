﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonderMart.Domain.Entities.Common.Abstractions;

namespace WonderMart.Domain.Entities.Common.Concretes
{
    public abstract class EntityBase : IEntityBase, IAuditable
    {
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
