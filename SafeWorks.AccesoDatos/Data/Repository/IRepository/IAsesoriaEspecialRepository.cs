﻿using SafeWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SafeWorks.AccesoDatos.Data.Repository.IRepository
{
    public interface IAsesoriaEspecialRepository : IRepository<AsesoriaEspecial>
    {

        void Update(AsesoriaEspecial asesoriaespecial);
    }
}
