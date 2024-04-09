﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IThongSoBLL
    {
        List<ThongSoModel> GetBySanPham(int id);
        ThongSoModel GetByID(int id);
        bool Create(ThongSoModel model);
        bool Update(ThongSoModel model);
        bool Delete(int id);
        bool DeleteBySanPham(int id);
    }
}