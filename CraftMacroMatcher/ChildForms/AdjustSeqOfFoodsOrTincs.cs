using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CraftMacroMatcher.Structs;

namespace CraftMacroMatcher.ChildForms
{
    public partial class AdjustSeqOfFoodsOrTincs : Form
    {
        Dictionary<string, FoodProps> data;
        string path;

        private new readonly string Enter = @"
";
        public AdjustSeqOfFoodsOrTincs(dynamic data, string type)
        {
            this.data = data;
            InitializeComponent();
            if (type == "food")
            {
                path = ProgramDatas.FoodPath;
                groupBox1.Text = "输入食物列表";
                label2.Text = "重命名或删除任意一行即会删除对应食物";
            }
            else if (type == "tinc")
            {
                path = ProgramDatas.TincPath;
                groupBox1.Text = "输入药水列表";
                label2.Text = "重命名或删除任意一行即会删除对应药水";
            }
        }

        private void AdjustSeqOfFoodsOrTincs_Load(object sender, EventArgs e)
        {
            TBX_TARGETS.Text = "";
            foreach(var d in data)
            {
                TBX_TARGETS.Text += d.Key + Enter;
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            string[] targets = TBX_TARGETS.Text.Split('\n');
            Dictionary<string, FoodProps> newData = new Dictionary<string, FoodProps>();
            foreach (var t in targets)
            {
                if (t.Length == 0) continue;
                var tt = t;
                if (t[t.Length-1]==' ' || t[t.Length-1]=='\r' || t[t.Length-1]=='\t')
                {
                    tt = t.Trim();
                }
                if (data.ContainsKey(tt))
                {
                    newData.Add(tt, data[tt]);
                }
                // 为了避免产生意外问题,禁止进行添加
                //else
                //{
                //    var d = new FoodProps();
                //    newData.Add(tt, d);
                //}
            }
            string json = JsonConvert.SerializeObject(newData);
            System.IO.File.WriteAllText(path, json);
            MessageBox.Show("保存成功！");
            this.Close();
        }
    }
}
