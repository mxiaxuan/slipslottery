using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式化語法動態建構元件
{
    public partial class 程式化語法動態建構元件 : Form
    {
        public Label myPGlabel1;
        public List<Button> listPGButtons = new List<Button>();
        public 程式化語法動態建構元件()
        {
            InitializeComponent();
        }

        private void 程式化語法動態建構元件_Load(object sender, EventArgs e)
        {
            程式化語法產生Label();
            程式化語法產生按鈕(7,7);
        }

        void 程式化語法產生Label()
        {
            myPGlabel1 = new Label();
            myPGlabel1.BackColor = Color.LightSalmon;//設定背景
            myPGlabel1.ForeColor = Color.Blue;//設定前景色
            myPGlabel1.Font = new Font("微軟正黑體", 18);//設定字體
            myPGlabel1.Text = "彩券投注單";//輸出文字
            myPGlabel1.Location = new Point(175, 10);
            //設定label方位 175為寬 10為高
            myPGlabel1.Size = new Size(400, 36);
            //設定label本身的寬跟高
            myPGlabel1.TextAlign = ContentAlignment.MiddleCenter;
            //設定文字置中
            Controls.Add(myPGlabel1);
        }

        void 程式化語法產生按鈕(int col,int row)//橫row直column
        {
            int 號碼 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    號碼 += 1;

                    Button colbutton = new Button();
                    colbutton.ForeColor = Color.Blue;
                    colbutton.BackColor = Color.Pink;
                    colbutton.Font = new Font("微軟正黑體", 18);
                    colbutton.Text = string.Format("{0}", 號碼);
                    colbutton.Location = new Point(135 + 68 * j, 60 + 42 * i);
                    //方位位於x=170,y=60
                    //每一個cloum間隔68,每一個row間隔42
                    colbutton.Size = new Size(66, 40);
                    colbutton.TextAlign = ContentAlignment.MiddleCenter;
                    colbutton.Click += new EventHandler(colbutton_Click);
                    colbutton.Enabled = false;
                    //事件指定運算子+= 事件解除運算子-=
                    Controls.Add(colbutton);
                    listPGButtons.Add(colbutton);
                }    
            }
        }

        private void colbutton_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;//轉型

            //MessageBox.Show($"按下:{mybutton.Text}");

            if(mybutton.BackColor== Color.Red)
            //這邊程式是寫如果按下是紅色的話那再按一下變回原本的粉色，
            //如若原本就是粉色，那點下去就為紅色。
            {
                mybutton.BackColor = Color.Pink;
            }
            else
            {
                mybutton.BackColor = Color.Red;
            }   
        }
        void 清除所有號碼()
        {
            foreach(Button button in listPGButtons)
            {
                button.BackColor = Color.Pink;
            }
        }

        //1.TODO利用無窮迴圈剔除重複 2.加入所選號碼集合
        private void btn快選_Click(object sender, EventArgs e)
        {
            清除所有號碼();

            Random rnd = new Random();
            List<int> selectedIndices = new List<int>();
            //新增一個List來存放無重複的索引值

            while (selectedIndices.Count < 6)//while無窮迴圈
            {
                int indexRum = rnd.Next(0, 49);

                // 檢查索引是否已被選取
                if (selectedIndices.Contains(indexRum) == false)
                //檢查selectedIndices中是否有包含indexRum裡的重複值
                //如果沒包含的話就進行下方程式
                {
                    // 將索引添加到已選取索引列表中
                    selectedIndices.Add(indexRum);

                    // 將按鈕在選取的索引位置設置為紅色背景
                    listPGButtons[indexRum].BackColor = Color.Red;
                }
            }
        }
    }
}
