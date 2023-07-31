using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sunsudrill
{
    public partial class Form1 : Form
    {
        Random random = new Random(); //乱数定義
        long noA = 0; //変数問題A初期
        long noB = 0; //変数問題B初期
        long noC = 0; //変数問題C初期
        long mondaiCnt = 0; //出題数カウント
        int mondaiMax = 0; //最大出題数
        int seikaiCnt = 0; //正解数
        //double seikairitu = 0; //正解率
        long type = 0; //1:足し算、2:引き算
        string typeStr; //演算記号表示用

        public Form1()
        {
            InitializeComponent();
        }

        private void InBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar >'9') && (e.KeyChar != '\b')) //文字コード表0~9の範囲 かつ バックスペース以外の時
            {
                if(!(e.KeyChar == '-' && InBOX.TextLength == 0)) //マイナスは入力できる
                {
                    e.Handled = true; //入力された値を無視
                }
            }

            if ((e.KeyChar == (char)Keys.Enter) && InBOX.Text != "" && InBOX.Text != "-")
            {
                Console.WriteLine(InBOX.Text);
                //OutBox.AppendText(InBOX.Text + "\r\n");
                kotaeawase();
                InBOX.Text = "";
                if(mondaiCnt < mondaiMax)
                {
                    MondaiSakusei();
                }
                else
                {
                    Seiseki();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MondaiSakusei(); //フォーム出力時にmondaiメソッド呼び出し
            InBOX.Enabled = false; //回答欄を入力不可にする
        }

        //問題作成
        private void MondaiSakusei()
        {
            noA = random.Next(1,10); //乱数1~10
            noB = random.Next(1,10); //乱数1~10
            //MondaiLbl.Text = noA + "+" + noB + "="; //乱数A＋乱数Bを出力
            MondaiLbl.Text = noA + typeStr + noB + "=";
            if(type == 1)
            {
                noC = noA + noB;
            }
            else
            {
                {
                    noC = noA - noB;
                }
            }
            //noC = noA + noB; //答え計算
            mondaiCnt++; //出題数カウント
        }

        //答え合わせ
        //変数と入力値を比較することで答え合わせできる
        private void kotaeawase()
        {
            if(noC == Int64.Parse(InBOX.Text))
            {
                OutBox.AppendText("〇");
                seikaiCnt++;
            }
            else
            {
                OutBox.AppendText("×");
            }
            OutBox.AppendText(MondaiLbl.Text + InBOX.Text + "\r\n");
        }

        //成績表示
        private void Seiseki()
        {
            InBOX.Enabled = false;
            MondaiLbl.Text = ""; //問題表示クリア
            OutBox.AppendText("問題数は" + mondaiCnt + "で\r\n");
            OutBox.AppendText("正解数は" + seikaiCnt + "でした\r\n");
            //seikairitu = seikaiCnt / mondaiCnt * 100;
            OutBox.AppendText("正解率は" + seikairitu + "%です。");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //出題数変更
            if (RB10.Checked)
            {
                mondaiMax = 10;
            }
            if (RB20.Checked)
            {
                mondaiMax = 20;
            }
            if (RB30.Checked)
            {
                mondaiMax = 30;
            }
            //計算タイプ変更
            if(RBtasu.Checked)
            {
                type = 1;
                typeStr = "+";
            }
            if(RBhiku.Checked)
            {
                type = 2;
                typeStr = "-";
            }
            //mondaiMax = 5; //最大出題数
            mondaiCnt = 0;
            seikaiCnt = 0; //正解数カウント
            MondaiSakusei(); //開始ボタン押下時にmondaiメソッド呼び出し
            InBOX.Enabled = true; //入力可にする
            InBOX.Focus(); //回答欄へフォーカスを移す
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
