﻿using KinoTeatrTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTeatrTask.Services
{
    internal interface ICrudServices
    {
        void Show(Entity entity);
        void Choose(int Id);
        void buy(Entity entity);
        void Update(int Id, Entity entity);
        void Delete(int Id);
        Entity GetEntity(int Id);
        Entity[] GetAll();
    }
}
