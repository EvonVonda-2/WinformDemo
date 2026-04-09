using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hmi.Core.Entities;

namespace Hmi.Infrastructure.Data
{
    public  class HmiDbContext: DbContext
    {
        //"name=HmiDbConnection"表示在配置文件中查找名为HmiDbConnection的连接字符串
        public HmiDbContext() :base("name=HmiDbConnection"){

        }

        //DbSet<Device>表示在数据库中创建一个名为Devices的表，用于存储Device实体的数据
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //表名
            modelBuilder.Entity<Device>().ToTable("Devices");

            //主键
            modelBuilder.Entity<Device>().HasKey(x => x.Id);

            //字段约束
            modelBuilder.Entity<Device>().Property(x => x.Name).IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Device>().Property(x => x.Ip).IsRequired().HasMaxLength(50);

            base.OnModelCreating(modelBuilder);



        }


    }
}
