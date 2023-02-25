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

        //public string[] W = new string[24] {  "门诗淇","卢艺文","耿馨", "王宇彤","牟星月","徐靖涵","贾紫怡","辛奕璇","刘春宏","张馨月",
        //    "闫旭","付晓艺","王思睿","李明倩","吴玥","赵思寒", "徐源婕","刘欣雨","姜欢格","邱雯轩","王雪洁","杨若涵","李悦","牟城燕" };
        //public string[] M = new string[24] { "高鑫烨" ,"范力晨", "高海瑞", "李恺", "刘晓雨", "郝运", "刘翰轩", "付韫齐", "贺玺", "汪泓羽",
        //    "罗盛源", "王贺晨", "杨家铭", "张博源", "戴济泽", "王浩泽","耿阳","潘星宇","陈瑞","李明睿","任亿","白智文", "赵伯翰","孙文龙",};

        public string[] W = new string[24] {  "张凉维","张凉维","张凉维", "张凉维","张凉维","张凉维","张凉维","张凉维","张凉维","张凉维",
            "张凉维","张凉维","张凉维","张凉维","张凉维","张凉维", "张凉维","张凉维","比利王","张凉维","张凉维","张凉维","张凉维","张凉维" };
        public string[] M = new string[24] { "刘勃轩" ,"刘勃轩", "刘勃轩", "刘勃轩", "刘勃轩" ,"V♂a♂n", "刘勃轩", "刘勃轩", "刘勃轩", "刘勃轩",
           "刘勃轩" ,"刘勃轩", "刘勃轩", "刘勃轩", "刘勃轩" ,"刘勃轩", "刘勃轩", "刘勃轩","刘勃轩", "刘勃轩","刘勃轩", "刘勃轩", "刘勃轩", "刘勃轩"};

        public Su[] Msu = new Su[24];
        public Su[] Wsu = new Su[24];

        public MainWindow()
        {
            InitializeComponent();
        }
        private void us_Click(object sender, RoutedEventArgs e)
        {
            Load();
            Set();
        }
        private void us_cClick(object sender, RoutedEventArgs e)
        {
            ReSet();
        }
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
        private void Load()
        { 
            Random ro = new Random();
            int[] lists = new int[24];
            for (int i = 0; i < 24; i++)
            {
                lists[i] = i;
            }
            for (int i = 0; i < 24; i++)
            {
                int p = lists[i], s = ro.Next(0,24);
                lists[i] = lists[s];
                lists[s] = p;
            }
            for (int i = 0; i < 24; i++)
            {
                Su step = new Su();
                step.name = M[lists[i]];
                step.sand = lists[i] + 1;

                Msu[i] = step;
            }
            for (int i = 0; i < 24; i++)
            {
                int p = lists[i], s = ro.Next(0, 24);
                lists[i] = lists[s];
                lists[s] = p;
            }
            for (int i = 0; i < 24; i++)
            {
                Su step = new Su();
                step.name = W[lists[i]];
                step.sand = lists[i] + 1;

                Wsu[i] = step;
            }
        }
    }
}
