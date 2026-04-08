using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hmi.Core.Entities;
using Hmi.Infrastructure.Data;

namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddDevice_Click(object sender, EventArgs e)
        {


            Task.Run(() =>
            {
                using (var db = new HmiDbContext())
                {
                    var device = new Device
                    {
                        Name = "TestDevice1",
                        Ip = "192.168.0.100",
                        Port = 502,
                        StationId = 1,
                        IsEnabled = true
                    };
                    db.Devices.Add(device);
                    db.SaveChanges();
                }
            });

    

            

            MessageBox.Show("Device added successfully!");

        }

        private void BtnLoadDevices_Click(object sender, EventArgs e)
        {
            using (var db = new HmiDbContext())
            {
                // 查询 Devices 并一次性加载到内存，再绑定到 DataGridView
                var list = db.Devices
                    .OrderBy(d => d.Id)
                    .ToList();

                dgvDevices.DataSource = list;
            }
        }
    }
}
