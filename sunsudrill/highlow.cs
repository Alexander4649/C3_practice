using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace highandlow
{
    public partial class Form1 : Form
    {
        Random rand = new Random(); //乱数定義
        long kazu = 0; //変数初期
        long good = 0; //当たりカウント初期
        long bad = 0; //外れカウント初期

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // HIGHボタンが押されたとき
            if(kazu >= 5)
            {
                label2.Text = "あたり";
                good++;
            }
            else
            {
                label2.Text = "はずれ";
                bad++;
            }
            
            label1.Text = kazu.ToString(); //変数に入った乱数を表示
            button1.Enabled = false; //リセット押下時ボタンを無効に
            button2.Enabled = false; //リセット押下時ボタンを無効に
            button3.Enabled = true;  //選択されたらリセットが表示
            label3.Text = "当たり回数：" + good.ToString();
            label4.Text = "外れ回数：" + bad.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LOWを押したとき実行
            if (kazu <= 5) 
            {
                label2.Text = "あたり";
                good++;
            }
            else
            {
                label2.Text = "はずれ";
                bad++;
            }
            label1.Text = kazu.ToString(); //変数に入った乱数を表示
            button1.Enabled = false; //リセット押下時ボタンを無効に
            button2.Enabled = false; //リセット押下時ボタンを無効に
            button3.Enabled = true;  //選択されたらリセットが表示
            label3.Text = "当たり回数：" + good.ToString();
            label4.Text = "外れ回数：" +  bad.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = kazu.ToString(); //変数に入った乱数を表示
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init(); //initメソッドから参照
        }

        private void button3_Click(object sender, EventArgs e)
        {
            init();　//initメソッドから参照
        }

        private void init()
        {
            label1.Text = "?"; //初期は？
            label2.Text = "?の数は5より大きいか小さいか"; //問題の問をラベル２に
            label3.Text = "当たり回数：" + good.ToString();
            label4.Text = "外れ回数：" + bad.ToString();
            label5.Text = "ハイ＆ローゲーム";

            kazu = rand.Next(1, 10); //乱数の範囲を指定
            Console.WriteLine("乱数" + kazu); //乱数の結果を出力コンソールに表示

            button1.Enabled = true; //リセット押下時ボタンを有効に
            button2.Enabled = true; //リセット押下時ボタンを有効に
            button3.Enabled = false;//選択されるまでリセットは押せない
          //testtesttest
        }

        private void label3_Click(object sender, EventArgs e)
        {
            init();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            init();
        }
    }
}
