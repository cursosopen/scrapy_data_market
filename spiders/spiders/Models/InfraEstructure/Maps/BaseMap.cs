using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Models.InfraEstructure.Maps
{
    public abstract class BaseMap<TEntity> : EntityTypeConfiguration<TEntity> 
        where TEntity : class
    {
        protected BaseMap()
        {
            SetKey();
            SetNameTable();
            SetProperties();
            SetRelation();
        }

        public abstract void SetKey();
        public abstract void SetNameTable();
        public abstract void SetProperties();
        public abstract void SetRelation();
    }
}
