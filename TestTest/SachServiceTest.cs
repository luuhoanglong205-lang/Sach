using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using NUnit.Framework;

namespace TestTest
{
    [TestFixture]
    public class SachServiceTest
    {
        SachService sachService;

        [SetUp]
        public void Setup()
        {
            sachService = new SachService();
        }

        [Test]
        public void Test_suaSachThanhCong()
        {
            Sach sachMoi = new Sach
            {
                MaSach = "S01",
                TenSach = "Doremon",
                TacGia = "Long",
                NamXuatBan = 2026,
                Gia = 15000
            };

            var result = sachService.SuaSach("S01", sachMoi);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Test_suaSachKhongThanhCong()
        {
            Sach sachMoi = new Sach
            {
                MaSach = "S02",
                TenSach = "Doremon",
                TacGia = "Long",
                NamXuatBan = 2026,
                Gia = 15000
            };

            var result = sachService.SuaSach("S10", sachMoi);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_TrungMaSach()
        {
            Sach sachMoi = new Sach
            {
                MaSach = "S02",
                TenSach = "Doremon",
                TacGia = "Long",
                NamXuatBan = 2026,
                Gia = 15000
            };

            var result = sachService.SuaSach("S01", sachMoi);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_suaSachKhongTonTai()
        {
            Sach sachMoi = new Sach
            {
                MaSach = "S04",
                TenSach = "Doremon",
                TacGia = "Long",
                NamXuatBan = 2026,
                Gia = 15000
            };

            var result = sachService.SuaSach("S10", sachMoi);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_suaGiaSach()
        {
            Sach sachMoi = new Sach
            {
                MaSach = "S01",
                TenSach = "Doremon",
                TacGia = "Long",
                NamXuatBan = 2026,
                Gia = 20000
            };

            sachService.SuaSach("S01", sachMoi);

            Assert.That(sachService.GetAll()[0].Gia, Is.EqualTo(20000));
        }
    }
}