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

        public string[] W = new string[30] { "阚宏艳", "李欣阳 ", "张嘉颖", "李卓然", "吴姝菡", "滕人梓", 
            "王嘉欣", "曲洁", "杨美予", "于雪", "梁诗琪", "蒋智慧", "刘雨桐", "周奕彤", "冷艺璇", 
            "汪雨涵", "赵思涵", "杨崛艺", "孙潇然", "马子月", "陈靖宇", "高艺萌", "李思瑶", "季颖 ", 
            "孙灿 ", "孙小茗", "高佳妍", "卢艺文","",""};
        public string[] M = new string[30] { "孟凡琨", "赵政捷", "杜明睿", "宋嘉烨", "边震 ", "王博",
            "张艺轩", "孙鸿宇", "吴晨宇", "王伟昊", "王天鹤", "马综英", "陈国轩", "孙浩文", "李子昂",
            "王福太", "王雲林", "徐浩文", "朱鸿宇", "" ,"" ,"" ,"" ,"", "", "", "", "", "", ""};
        //学生姓名数组
        public Su[] Msu = new Su[19];
        public Su[] Wsu = new Su[28];
        public int signM = 0;
        public int signW = 0;
        //学生对象数组 看起来没啥用，实际上也没啥用 就当是为了以后升级做的铺垫吧
        public MainWindow()
        {
            InitializeComponent();
        }
        private void us_Click(object sender, RoutedEventArgs e)
        {
            //NameAverage();
            signM = 0;
            signW = 0;
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
            //当M中某项为空时，随机抽取一个W中的非空项放入M
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
            //
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
            Random ro = new Random();
            for(int i = 0; i < 6; i++)
            {
                PL:
                if(ro.Next(0,2) == 0)
                {
                    
                    if (signW == 28)
                        goto PL;
                    clac1.Text += Wsu[signW].name + "\n"; signW++;
                    clac2.Text += Wsu[signW].name + "\n"; signW++;
                }
                else
                {
                    if (signM == 18)
                        goto PL;
                    clac1.Text += Msu[signM].name + "\n"; signM++;
                    if (signM == 18)
                        goto PL;
                    clac2.Text += Msu[signM].name + "\n"; signM++;
                }
            }
            for (int i = 0; i < 6; i++)
            {
            PL:
                if (ro.Next(0, 2) == 0)
                {

                    if (signW == 28)
                        goto PL;
                    clac3.Text += Wsu[signW].name + "\n"; signW++;
                    clac4.Text += Wsu[signW].name + "\n"; signW++;
                }
                else
                {
                    if (signM == 18)
                        goto PL;
                    clac3.Text += Msu[signM].name + "\n"; signM++;
                    if (signM == 18)
                        goto PL;
                    clac4.Text += Msu[signM].name + "\n"; signM++;
                }
            }
            for (int i = 0; i < 6; i++)
            {
            PL:
                if (ro.Next(0, 2) == 0)
                {

                    if (signW == 28)
                        goto PL;
                    clac5.Text += Wsu[signW].name + "\n"; signW++;
                    clac6.Text += Wsu[signW].name + "\n"; signW++;
                }
                else
                {
                    if (signM == 18)
                        goto PL;
                    clac5.Text += Msu[signM].name + "\n"; signM++;
                    if (signM == 18)
                        goto PL;
                    clac6.Text += Msu[signM].name + "\n"; signM++;
                }
            }

            clac7.Text += Msu[18].name + "\n"; 
            clac8.Text +="\n";

            for (int i = 0; i < 5; i++)
            {
            PL:
                if (ro.Next(0, 2) == 0)
                {

                    if (signW == 28)
                        goto PL;
                    clac7.Text += Wsu[signW].name + "\n"; signW++;
                    clac8.Text += Wsu[signW].name + "\n"; signW++;
                }
                else
                {
                    if (signM == 18)
                        goto PL;
                    clac7.Text += Msu[signM].name + "\n"; signM++;
                    if (signM == 18)
                        goto PL;
                    clac8.Text += Msu[signM].name + "\n"; signM++;
                }
            }
        }
        //把学生姓名按顺序输出到文本框 这段写的挺暴力的，无所谓了，反正占不了多少资源
      
        private void Load()
        { 
            /*这个函数生成了一个由0-23组成顺序随机的数组
             *将这些顺序随机的数字当作数组下标
             *再用这些下标当作索引创建学生对象*/
            Random ro = new Random();
            int[] lists = new int[30];
            for (int i = 0; i < 19; i++)
            {
                lists[i] = i;
            }
            //初始化下标
            for (int i = 0; i < 19; i++)
            {
                int p = lists[i], s = ro.Next(0, 19);
                lists[i] = lists[s];
                lists[s] = p;
            }
            //随机打乱下标
            for (int i = 0; i < 19; i++)
            {
                Su step = new Su();
                step.name = M[lists[i]];
                step.sand = lists[i] + 1;

                Msu[i] = step;
            }
            //以上面生成的下标为索引初始化学生对象

            //下边是女生的排列，原理一样
            for (int i = 0; i < 28; i++)
            {
                lists[i] = i;
            }
            for (int i = 0; i < 28; i++)
            {
                int p = lists[i], s = ro.Next(0, 28);
                lists[i] = lists[s];
                lists[s] = p;
            }
            for (int i = 0; i < 28; i++)
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
