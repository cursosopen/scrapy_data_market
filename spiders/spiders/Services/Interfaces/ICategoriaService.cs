﻿using spiders.Models.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Services.Interfaces
{
    public interface ICategoriaService
    {
        List<Categoria> BuscarCategorias();
    }
}