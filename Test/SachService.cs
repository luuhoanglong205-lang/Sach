using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class SachService
    {
        List<Sach> listsach = new List<Sach>();

        public SachService()
        {
            listsach.Add(new Sach { MaSach = "S01", TenSach = "Doremon", TacGia = "Long", NamXuatBan = 2026, Gia = 15000 });
            listsach.Add(new Sach { MaSach = "S02", TenSach = "Conan", TacGia = "Long", NamXuatBan = 2025, Gia = 20000 });
            listsach.Add(new Sach { MaSach = "S03", TenSach = "One Piece", TacGia = "Long", NamXuatBan = 2024, Gia = 25000 });
        }

        public bool SuaSach(string ma, Sach sach)
        {
            var sacSua = listsach.FirstOrDefault(x => x.MaSach == ma);

            if (sacSua == null)
                return false;

            if (listsach.Any(x => x.MaSach == sach.MaSach && x.MaSach != ma))
                return false;

            sacSua.MaSach = sach.MaSach;
            sacSua.TenSach = sach.TenSach;
            sacSua.TacGia = sach.TacGia;
            sacSua.NamXuatBan = sach.NamXuatBan;
            sacSua.Gia = sach.Gia;

            return true;
        }

        public List<Sach> GetAll()
        {
            return listsach;
        }
    }
}