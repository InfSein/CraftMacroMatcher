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
    public partial class AddTinc : Form
    {
        Dictionary<string, FoodProps> Tincs;
        public AddTinc()
        {
            InitializeComponent();
        }

        private void AddTinc_Load(object sender, EventArgs e)
        {
            Tincs = MainForm.LoadTincs();
            SurfTincList(sender, e);
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (CBX_LOAD_TINC.Text != "新增..." && CBX_LOAD_TINC.Text != "")
            {
                Tincs.Remove(CBX_LOAD_TINC.Text);
            }
            var name = TBX_TINC_NAME.Text;
            //name = name.Replace(' ', '_');
            string saveName = $"({(CBX_ISHQ.Checked ? "HQ" : "NQ")}) {name}";
            if (Tincs.ContainsKey(saveName))
            {
                MessageBox.Show("已存在同名药水");
                return;
            }
            FoodProps fp = new FoodProps
            {
                name = name,
                craftsmanshipAdd_Percent = ParseText(TBX_CRAFTSM_PERCENT.Text, "float"),
                controlAdd_Percent = ParseText(TBX_CONTROL_PERCENT.Text, "float"),
                cpAdd_Percent = ParseText(TBX_CP_PERCENT.Text, "float"),
                craftsmanshipAdd_Max = ParseText(TBX_CRAFTSM_MAX.Text, "int"),
                controlAdd_Max = ParseText(TBX_CONTROL_MAX.Text, "int"),
                cpAdd_Max = ParseText(TBX_CP_MAX.Text, "int")
            };
            Tincs.Add(saveName, fp);
            string json = JsonConvert.SerializeObject(Tincs);
            System.IO.File.WriteAllText(ProgramDatas.TincPath, json);

            MessageBox.Show("药水添加/编辑成功");
            Tincs = MainForm.LoadTincs();
            SurfTincList(sender, e);

            ClearTexts(sender, e);
        }

        private void CBX_LOAD_TINC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_LOAD_TINC.Text == "新增...")
            {
                return;
            }
            FoodProps selectedTinc = Tincs[CBX_LOAD_TINC.Text];
            TBX_TINC_NAME.Text = selectedTinc.name;
            TBX_CRAFTSM_PERCENT.Text = selectedTinc.craftsmanshipAdd_Percent.ToString();
            TBX_CONTROL_PERCENT.Text = selectedTinc.controlAdd_Percent.ToString();
            TBX_CP_PERCENT.Text = selectedTinc.cpAdd_Percent.ToString();
            TBX_CRAFTSM_MAX.Text = selectedTinc.craftsmanshipAdd_Max.ToString();
            TBX_CONTROL_MAX.Text = selectedTinc.controlAdd_Max.ToString();
            TBX_CP_MAX.Text = selectedTinc.cpAdd_Max.ToString();
        }

        private dynamic ParseText(string text, string type)
        {
            if (text == "" || text == null) { text = "0"; }
            if (type == "float")
            {
                return float.Parse(text);
            }
            if (type == "int")
            {
                return int.Parse(text);
            }
            return null;
        }
        private void SurfTincList(object sender, EventArgs e)
        {
            CBX_LOAD_TINC.Items.Clear();
            CBX_LOAD_TINC.Items.Add("新增...");
            foreach (var f in Tincs)
            {
                CBX_LOAD_TINC.Items.Add(f.Key);
            }
        }
        private void ClearTexts(object sender, EventArgs e)
        {
            CBX_LOAD_TINC.Text = "";
            TBX_TINC_NAME.Text = "";
            TBX_CRAFTSM_PERCENT.Text = "";
            TBX_CONTROL_PERCENT.Text = "";
            TBX_CP_PERCENT.Text = "";
            TBX_CRAFTSM_MAX.Text = "";
            TBX_CONTROL_MAX.Text = "";
            TBX_CP_MAX.Text = "";
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            var text = CBX_LOAD_TINC.Text;
            if (text == "新增..." || text == "")
            {
                MessageBox.Show("尚未选择");
                return;
            }
            try
            {
                string key = text;
                Tincs.Remove(key);
                string json = JsonConvert.SerializeObject(Tincs);
                System.IO.File.WriteAllText(ProgramDatas.TincPath, json);
                MessageBox.Show("删除成功");
                Tincs = MainForm.LoadTincs();
                SurfTincList(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"对象不存在或删除失败\nDetail:{ex}");
                return;
            }
        }

        private void BTN_ADJUST_Click(object sender, EventArgs e)
        {
            AdjustSeqOfFoodsOrTincs asofot = new AdjustSeqOfFoodsOrTincs(Tincs, "tinc");
            asofot.ShowDialog();
            Tincs = MainForm.LoadTincs();
            SurfTincList(sender, e);
        }
    }
}
