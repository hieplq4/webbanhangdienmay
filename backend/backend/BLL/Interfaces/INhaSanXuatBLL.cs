﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface INhaSanXuatBLL
    {
        List<NhaSanXuatModel> Get();
        List<NhaSanXuatModel> GetAll(int pageIndex, int pageSize, out int total, string Ten);
        NhaSanXuatModel GetByID(int id);
        bool Create(NhaSanXuatModel model);
        bool Update(NhaSanXuatModel model);
        bool Delete(int id);
    }
}
