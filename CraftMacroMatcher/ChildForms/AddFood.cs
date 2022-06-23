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
    public partial class AddFood : Form
    {
        Dictionary<string, FoodProps> Foods;
        public AddFood()
        {
            InitializeComponent();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            Foods = MainForm.LoadFoods();
            SurfFoodList(sender, e);
        }
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (CBX_LOAD_FOOD.Text != "新增..." && CBX_LOAD_FOOD.Text != "")
            {
                Foods.Remove(CBX_LOAD_FOOD.Text);
            }
            string saveName = $"({(CBX_ISHQ.Checked ? "HQ" : "NQ")}) {TBX_FOOD_NAME.Text}";
            if (Foods.ContainsKey(saveName))
            {
                MessageBox.Show("已存在同名食物");
                return;
            }
            FoodProps fp = new FoodProps
            {
                name = TBX_FOOD_NAME.Text,
                craftsmanshipAdd_Percent = ParseText(TBX_CRAFTSM_PERCENT.Text, "float"),
                controlAdd_Percent = ParseText(TBX_CONTROL_PERCENT.Text, "float"),
                cpAdd_Percent = ParseText(TBX_CP_PERCENT.Text, "float"),
                craftsmanshipAdd_Max = ParseText(TBX_CRAFTSM_MAX.Text, "int"),
                controlAdd_Max = ParseText(TBX_CONTROL_MAX.Text, "int"),
                cpAdd_Max = ParseText(TBX_CP_MAX.Text, "int")
            };
            Foods.Add(saveName, fp);
            string json = JsonConvert.SerializeObject(Foods);
            System.IO.File.WriteAllText(ProgramDatas.FoodPath, json);

            MessageBox.Show("食物添加/编辑成功");
            Foods = MainForm.LoadFoods();
            SurfFoodList(sender, e);

            ClearTexts(sender, e);
        }

        private void CBX_LOAD_FOOD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_LOAD_FOOD.Text == "新增...")
            {
                return;
            }
            FoodProps selectedFood = Foods[CBX_LOAD_FOOD.Text];
            TBX_FOOD_NAME.Text = selectedFood.name;
            TBX_CRAFTSM_PERCENT.Text = selectedFood.craftsmanshipAdd_Percent.ToString();
            TBX_CONTROL_PERCENT.Text = selectedFood.controlAdd_Percent.ToString();
            TBX_CP_PERCENT.Text = selectedFood.cpAdd_Percent.ToString();
            TBX_CRAFTSM_MAX.Text = selectedFood.craftsmanshipAdd_Max.ToString();
            TBX_CONTROL_MAX.Text = selectedFood.controlAdd_Max.ToString();
            TBX_CP_MAX.Text = selectedFood.cpAdd_Max.ToString();
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
        private void SurfFoodList(object sender, EventArgs e)
        {
            CBX_LOAD_FOOD.Items.Clear();
            CBX_LOAD_FOOD.Items.Add("新增...");
            foreach (var f in Foods)
            {
                CBX_LOAD_FOOD.Items.Add(f.Key);
            }
        }
        private void ClearTexts(object sender, EventArgs e)
        {
            CBX_LOAD_FOOD.Text = "";
            TBX_FOOD_NAME.Text = "";
            TBX_CRAFTSM_PERCENT.Text = "";
            TBX_CONTROL_PERCENT.Text = "";
            TBX_CP_PERCENT.Text = "";
            TBX_CRAFTSM_MAX.Text = "";
            TBX_CONTROL_MAX.Text = "";
            TBX_CP_MAX.Text = "";
        }
    }
}
