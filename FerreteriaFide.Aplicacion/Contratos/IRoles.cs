﻿using FerreteriaFide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Aplicacion.Contratos
{
    public interface IRoles
    {
        List<Roles> GetAllRoles();
        
        Roles GetRoles(int IdRol);
    }
}
