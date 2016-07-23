using System;
using LiteAuth.Entity;
using LiteAuth.Test.DbConn;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orm.Son.Core;

namespace LiteAuth.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitDb()
        {
            using (var db = new DbContext())
            {
                var user = db.CreateTable<SysUser>();
                var menu = db.CreateTable<Permission>();
                var region = db.CreateTable<Region>();
                var role = db.CreateTable<Role>();
                var permissionInRole = db.CreateTable<PermissionInRole>();
                var regionInRole = db.CreateTable<RegionInRole>();
                var roleInUser = db.CreateTable<Role>();

                Assert.IsTrue(user);
                Assert.IsTrue(menu);
                Assert.IsTrue(region);
                Assert.IsTrue(role);
                Assert.IsTrue(permissionInRole);
                Assert.IsTrue(regionInRole);
                Assert.IsTrue(roleInUser);
            }
        }

        [TestMethod]
        public void Insert()
        {
            var obj = new SysUser{
                Name = "admin",
                Pwd = "admin",
                RealName = "王五",
                PhoneNumber = "12345678910",
                Email = "admin@sys.com",
                Enable = true
            };

            using (var db = new DbContext())
            {
                var res = db.Insert(obj);
                Assert.IsTrue(res>0);
            }
        }
    }
}
