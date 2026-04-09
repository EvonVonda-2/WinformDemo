using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Winform
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单线程示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            MessageBox.Show("素菜已经做好");
            Thread.Sleep(2000);
            MessageBox.Show("肉菜已经做好");
            Thread.Sleep(2000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜已经做好");
                Thread.Sleep(2000);
                MessageBox.Show("肉菜已经做好");
                Thread.Sleep(2000);

            });

            t.Start();




        }




        /// <summary>
        /// Task相比于Thread更方便，且不需要手动管理线程的生命周期，Task会自动处理线程池中的线程资源。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜已经做好");
                Thread.Sleep(2000);
                MessageBox.Show("肉菜已经做好");
                Thread.Sleep(2000);
            });




        }





        /// <summary>
        /// 两个线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜已经做好");
            });

            Task.Run(() =>
            {
                Thread.Sleep(2000);
                MessageBox.Show("肉菜已经做好");
            });


        }



        /// <summary>
        /// 一旦一个方法被设置为async，那么它就独立出来一个线程，不会阻塞UI线程，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void  button5_Click(object sender, EventArgs e)
        {
            await  Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜已经做好");
                Thread.Sleep(2000);
                MessageBox.Show("肉菜已经做好");
            });

               MessageBox.Show("菜都做好了，大家快来吃饭", "提示");

        }
        /// <summary>
        /// 等待所有任务完成后再执行后续操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {

            List<Task> ts=new List<Task>();

            ts.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜已经做好");
            }));

            ts.Add(Task.Run(() =>
            {
                Thread.Sleep(2000);
                MessageBox.Show("肉菜已经做好");

            }));


            Task.WhenAll(ts).ContinueWith(t=>
            {
                MessageBox.Show("菜做好了快来吃！");

            });







        }
    }
}
