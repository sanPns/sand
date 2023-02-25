using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Su
    {
        public string name;
        public int ords;
        public int sand;
    }

    public partial class MainWindow : Window
    {

        public string[] W = new string[30] {  "张凉维","张凉维","张凉维", "张凉维","张凉维","张凉维","张凉维","张凉维","张凉维","张凉维",
            "张凉维","张凉维","张凉维","张凉维","张凉维","张凉维", "张凉维","张凉维","比利王","张凉维","张凉维","张凉维","张凉维" ,"刘勃轩" ,"刘勃轩" ,"刘勃轩" ,"刘勃轩" ,"刘勃轩" ,"刘勃轩" ,"刘勃轩"};
        public string[] M = new string[30] { "刘勃轩" ,"", "刘勃轩", "", "刘勃轩" ,"V♂a♂n", "刘勃轩", "刘勃轩", "刘勃轩", "刘勃轩",
           "刘勃轩" ,"刘勃轩", "刘勃轩", "刘勃轩", "" ,"", "刘勃轩", "","刘勃轩", "","刘勃轩", "", "刘勃轩", "刘勃轩" ,"" ,"" ,"" ,"" ,"" ,""};
        //学生姓名数组
        public Su[] Msu = new Su[24];
        public Su[] Wsu = new Su[24];
        //学生对象数组 看起来没啥用，实际上也没啥用 就当是为了以后升级做的铺垫吧
        public MainWindow()
        {
            InitializeComponent();
        }
        private void us_Click(object sender, RoutedEventArgs e)
        {
            NameAverage();
            Load();
            Set();
        }
        private void us_cClick(object sender, RoutedEventArgs e)
        {
            ReSet();
        }
        //两个按钮的函数
        public void NameAverage()
        {
            Random ro = new Random();
            for (int i = 0; i < 24; i++)
            {
                while(M[i] == "")
                {
                    M[i] = W[ro.Next(0, 24)];
                }
            }
            for (int i = 0; i < 23; i++)
            {
                int j = 1;
                while (W[i] == "")
                {
                    W[i] = W[i + j];
                    W[i + j] = "";
                    j++;
                }
            }
        }
        //此函数用于平均两个名字数组使其一个长23一个24 前提：W实际长度必须大于M
        public void ReSet()
        {
            clac8.Text = "";
            clac6.Text = "";
            clac4.Text = "";
            clac2.Text = "";
            clac7.Text = "";
            clac5.Text = "";
            clac3.Text = "";
            clac1.Text = "";
        }
        //重置，把全部文本都清空
        private void Set()
        {
            ReSet();
            clac8.Text += "\n";
            for (int i = 0; i < 6; i++)
            {
                clac1.Text += Msu[i].name+"\n";
            }
            for (int i = 6; i < 12; i++)
            {
                clac3.Text += Msu[i].name + "\n";
            }
            for (int i = 12; i < 18; i++)
            {
                clac5.Text += Msu[i].name + "\n";
            }
            for (int i = 18; i < 24; i++)
            {
                clac7.Text += Msu[i].name + "\n";
            }
            for (int i = 0; i < 6; i++)
            {
                clac2.Text += Wsu[i].name + "\n";
            }
            for (int i = 6; i < 12; i++)
            {
                clac4.Text += Wsu[i].name + "\n";
            }
            for (int i = 12; i < 18; i++)
            {
                clac6.Text += Wsu[i].name + "\n";
            }
            for (int i = 18; i < 23; i++)
            {
                clac8.Text += Wsu[i].name + "\n";
            }
        }
        //把学生姓名按顺序输出到文本框 这段写的挺暴力的，无所谓了，反正占不了多少资源

        private void Load()
        { 
            /*这个函数生成了一个由0-23组成顺序随机的数组
             *将这些顺序随机的数字当作数组下标
             *再用这些下标当作索引创建学生对象*/
            Random ro = new Random();
            int[] lists = new int[24];
            for (int i = 0; i < 24; i++)
            {
                lists[i] = i;
            }
            //初始化下标
            for (int i = 0; i < 24; i++)
            {
                int p = lists[i], s = ro.Next(0,24);
                lists[i] = lists[s];
                lists[s] = p;
            }
            //随机打乱下标
            for (int i = 0; i < 24; i++)
            {
                Su step = new Su();
                step.name = M[lists[i]];
                step.sand = lists[i] + 1;

                Msu[i] = step;
            }
            //以上面生成的下标为索引初始化学生对象

            //下边是女生的排列，原理一样
            for (int i = 0; i < 23; i++)
            {
                lists[i] = i;
            }
            for (int i = 0; i < 23; i++)
            {
                int p = lists[i], s = ro.Next(0, 23);
                lists[i] = lists[s];
                lists[s] = p;
            }
            for (int i = 0; i < 23; i++)
            {
                Su step = new Su();
                step.name = W[lists[i]];
                step.sand = lists[i] + 1;

                Wsu[i] = step;
            }
        }
        //读取学生姓名随机打乱并创建学生类 男女区分开
    }
}
