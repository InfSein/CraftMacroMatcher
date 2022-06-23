using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = CraftMacroMatcher.Structs.Action;

namespace CraftMacroMatcher
{
    public class Structs
    {
        #region 食物的结构体
        public struct FoodProps
        {
            public string name;
            public float craftsmanshipAdd_Percent;
            public float controlAdd_Percent;
            public float cpAdd_Percent;
            public int craftsmanshipAdd_Max;
            public int controlAdd_Max;
            public int cpAdd_Max;
        }
        public struct UCraftProcess
        {
            public string targetItemName;
            public int need_craftsmanship;
            public int need_control;
            public List<int> actions;
        }
        #endregion

        #region 工序的结构体
        public struct CraftProcess
        {
            public string name;
            public int steps;
            public int times;
            public int need_craftsmanship;
            public int need_control;
            public int need_cp;
            public string targetItemName;
            public List<Action> actions;
        }
        public struct Action
        {
            /// <summary> 技能id </summary>
            public int id;
            /// <summary> 宏等待时间 </summary>
            public int wait_time;
            /// <summary> 消耗制作力 </summary>
            public int cp_cost;
            /// <summary> 技能名(中文) </summary>
            public string name_cn;
            /// <summary> 技能名(英文) </summary>
            public string name_en;
            /// <summary> 技能名(日文) </summary>
            public string name_jp;
            /// <summary> 技能名(模拟器导出的工序名) </summary>
            //public string name_sm;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="id">技能id</param>
            /// <param name="wait_time">宏等待时间</param>
            /// <param name="cp_cost">消耗制作力</param>
            /// <param name="name_cn">技能名(中文)</param>
            /// <param name="name_en">技能名(英文)</param>
            /// <param name="name_jp">技能名(日文)</param>
            public Action(int id, int wait_time, int cp_cost, string name_cn, string name_jp, string name_en)
            {
                this.id = id;
                this.wait_time = wait_time;
                this.cp_cost = cp_cost;
                this.name_cn = name_cn;
                this.name_jp = name_jp;
                this.name_en = name_en;
                //this.name_sm = name_sm;
            }

        }
        #endregion

    }
    public class Actions
    {
        #region Craft Actions

        #region 首次作业
        public static readonly Action MuscleMemory = new Action(
            (int)ActId.MuscleMemory, 3, 6, "坚信", "確信", "Muscle Memory"
        );
        public static readonly Action Reflect = new Action(
            (int)ActId.Reflect, 3, 6, "闲静", "真価", "Reflect"
        );
        public static readonly Action TrainedEye = new Action(
            (int)ActId.TrainedEye, 3, 250, "工匠的神速技巧", "匠の早業", "Trained Eye"
        );
        #endregion

        #region 作业
        public static Action BasicSynthesis = new Action(
            (int)ActId.BasicSynthesis, 3, 0, "制作", "作業", "Basic Synthesis"
        );
        public static Action CarefulSynthesis = new Action(
            (int)ActId.CarefulSynthesis, 3, 5, "模范制作", "模範作業", "Careful Synthesis"
        );
        public static Action RapidSynthesis = new Action(
            (int)ActId.RapidSynthesis, 3, 0, "高速制作", "突貫作業", "Rapid Synthesis"
        );
        public static Action FocusedSynthesis = new Action(
            (int)ActId.FocusedSynthesis, 3, 5, "注视制作", "注視作業", "Focused Synthesis"
        );
        public static Action Groundwork = new Action(
            (int)ActId.Groundwork, 3, 18, "坯料制作", "下地作業", "Groundwork"
        );
        public static Action IntensiveSynthesis = new Action(
            (int)ActId.IntensiveSynthesis, 3, 6, "集中制作", "集中作業", "Intensive Synthesis"
        );
        public static Action PrudentSynthesis = new Action(
            (int)ActId.PrudentSynthesis, 3, 18, "俭约制作", "倹約作業", "Prudent Synthesis"
        );
        public static Action DelicateSynthesis = new Action(
            (int)ActId.DelicateSynthesis, 3, 32, "精密制作", "精密作業", "Delicate Synthesis"
        );
        #endregion

        #region 加工
        public static readonly Action BasicTouch = new Action(
            (int)ActId.BasicTouch, 3, 18, "加工", "加工", "Basic Touch"
        );
        public static readonly Action HastyTouch = new Action(
            (int)ActId.HastyTouch, 3, 0, "仓促", "ヘイスティタッチ", "Hasty Touch"
        );
        public static readonly Action StandardTouch = new Action(
            (int)ActId.StandardTouch, 3, 32, "中级加工", "中級加工", "Standard Touch"
        );
        public static readonly Action ByregotsBlessing = new Action(
            (int)ActId.ByregotsBlessing, 3, 24, "比尔格的祝福", "ビエルゴの祝福", "Byregot's Blessing"
        );
        public static readonly Action PreciseTouch = new Action(
            (int)ActId.PreciseTouch, 3, 18, "集中加工", "集中加工", "Precise Touch"
        );
        public static readonly Action PrudentTouch = new Action(
            (int)ActId.PrudentTouch, 3, 25, "俭约加工", "倹約加工", "Prudent Touch"
        );
        public static readonly Action FocusedTouch = new Action(
            (int)ActId.FocusedTouch, 3, 18, "注视加工", "注視加工", "Focused Touch"
        );
        public static readonly Action PreparatoryTouch = new Action(
            (int)ActId.PreparatoryTouch, 3, 40, "坯料加工", "下地加工", "Preparatory Touch"
        );
        public static readonly Action AdvancedTouch = new Action(
            (int)ActId.AdvancedTouch, 3, 46, "上级加工", "上級加工", "Advanced Touch"
        );
        public static readonly Action TrainedFinesse = new Action(
            (int)ActId.TrainedFinesse, 3, 32, "工匠的神技", "匠の神業", "Trained Finesse"
        );
        #endregion

        #region 耐久度
        public static readonly Action MastersMend = new Action(
            (int)ActId.MastersMend, 3, 88, "精修", "マスターズメンド", "Master's Mend"
        );
        public static readonly Action WasteNot = new Action(
            (int)ActId.WasteNot, 2, 56, "俭约", "倹約", "Waste Not"
        );
        public static readonly Action WasteNotII = new Action(
            (int)ActId.WasteNotII, 2, 98, "长期俭约", "長期倹約", "Waste Not II"
        );
        public static readonly Action Manipulation = new Action(
            (int)ActId.Manipulation, 2, 96, "掌握", "マニピュレーション", "Manipulation"
        );
        #endregion

        #region 增益
        public static readonly Action Veneration = new Action(
            (int)ActId.Veneration, 2, 18, "崇敬", "ヴェネレーション", "Veneration"
        );
        public static readonly Action GreatStrides = new Action(
            (int)ActId.GreatStrides, 2, 32, "阔步", "グレートストライド", "Great Strides"
        );
        public static readonly Action Innovation = new Action(
            (int)ActId.Innovation, 2, 18, "改革", "イノベーション", "Innovation"
        );
        #endregion

        #region 其他
        public static readonly Action Observe = new Action(
            (int)ActId.Observe, 3, 7, "观察", "経過観察", "Observe"
        );
        public static readonly Action TricksOfTheTrade = new Action(
            (int)ActId.TricksOfTheTrade, 3, 0, "秘诀", "秘訣", "Tricks of the Trade"
        );
        public static readonly Action FinalAppraisal = new Action(
            (int)ActId.FinalAppraisal, 2, 1, "最终确认", "最終確認", "Final Appraisal"
        );
        public static readonly Action HeartAndSoul = new Action(
            (int)ActId.HeartAndSoul, 3, 0, "专心致志", "一心不乱", "Heart and Soul"
        );
        public static readonly Action CarefulObservation = new Action(
            (int)ActId.CarefulObservation, 3, 0, "设计变动", "設計変更", "Careful Observation"
        );
        #endregion

        #endregion

        public static readonly List<Action> ActionList = new List<Action>()
        {
            MuscleMemory, Reflect, TrainedEye,
            BasicSynthesis, CarefulSynthesis, RapidSynthesis, FocusedSynthesis, Groundwork, IntensiveSynthesis, PrudentSynthesis, DelicateSynthesis,
            BasicTouch, HastyTouch, StandardTouch, ByregotsBlessing, PreciseTouch, PrudentTouch, FocusedTouch, PreparatoryTouch, AdvancedTouch, TrainedFinesse,
            MastersMend, WasteNot, WasteNotII, Manipulation,
            Veneration, GreatStrides, Innovation,
            Observe, TricksOfTheTrade, FinalAppraisal, HeartAndSoul, CarefulObservation
        };

        public static Action SearchAction(dynamic src)
        {
            if(src is int)
            {
                return ActionList.Find(x => x.id == src);
            }
            else
            {
                var findByCn = ActionList.Find(x => x.name_cn == src);
                if (findByCn.name_cn != null) { return findByCn; }
                var findByJp = ActionList.Find(x => x.name_jp == src);
                if (findByJp.name_jp != null) { return findByJp; }
                var findByEn = ActionList.Find(x => x.name_en == src);
                if (findByEn.name_en != null) { return findByEn; }
            }
            throw new Exception($"Invalid ActionName/Id: {src.ToString()}");
        }
        #region Enums
        public enum ActId
        {
            // 首次作业
            MuscleMemory = 1,
            Reflect,
            TrainedEye,

            // 作业
            BasicSynthesis = 100,
            CarefulSynthesis,
            RapidSynthesis,
            FocusedSynthesis,
            Groundwork,
            IntensiveSynthesis,
            PrudentSynthesis,
            DelicateSynthesis,

            // 加工
            BasicTouch = 200,
            HastyTouch,
            StandardTouch,
            ByregotsBlessing,
            PreciseTouch,
            PrudentTouch,
            FocusedTouch,
            PreparatoryTouch,
            AdvancedTouch,
            TrainedFinesse,

            // 耐久度
            MastersMend = 300,
            WasteNot,
            WasteNotII,
            Manipulation,

            // 增益
            Veneration = 400,
            GreatStrides,
            Innovation,

            // 其他
            Observe = 500,
            TricksOfTheTrade,
            FinalAppraisal,
            HeartAndSoul,
            CarefulObservation
        };
        #endregion
    }
}
