using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftMacroMatcher
{
    internal class Structs
    {
        #region 用户定义的结构体
        public struct CMMData
        {
            public List<UCraftProcess> processes;
        }
        public struct UCraftProcess
        {
            public string targetItemName;
            public List<int> actions;
        }
        #endregion

        #region 程序使用的结构体
        public struct CraftProcess
        {
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

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="id">技能id</param>
            /// <param name="wait_time">宏等待时间</param>
            /// <param name="cp_cost">消耗制作力</param>
            /// <param name="name_cn">技能名(中文)</param>
            /// <param name="name_en">技能名(英文)</param>
            /// <param name="name_jp">技能名(日文)</param>
            public Action(int id, int wait_time, int cp_cost, string name_cn, string name_en, string name_jp)
            {
                this.id = id;
                this.wait_time = wait_time;
                this.cp_cost = cp_cost;
                this.name_cn = name_cn;
                this.name_en = name_en;
                this.name_jp = name_jp;
            }
        }
        #endregion

        #region Craft Actions
        // to-do: 录入技能数据~
        /// <summary> 测试 </summary>
        public static Action test = new Action(
            1,0,0,"","",""
            );
        #endregion
    }
}
